using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E5A RID: 20058
	public class AutoPilotSkillHighLightLogic
	{
		// Token: 0x06032791 RID: 206737 RVA: 0x00E28CFA File Offset: 0x00E26EFA
		private void StartTimer()
		{
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnHighlightTimeUp), (float)(AutoPilotModel.Instance.GetSkillHighLightTime() * TimeUtil.Instance.InverseMillisecond), null, null, true, 1f);
		}

		// Token: 0x06032792 RID: 206738 RVA: 0x00E28D36 File Offset: 0x00E26F36
		private void ClearTimer()
		{
			if (this.TimerHandle != null && TimerSystem.Instance.Has(this.TimerHandle))
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06032793 RID: 206739 RVA: 0x00E28D6A File Offset: 0x00E26F6A
		public void Dispose()
		{
			if (this.Highlighting)
			{
				this.OnHideHighlightExploreSkill();
			}
			this.ClearTimer();
		}

		// Token: 0x06032794 RID: 206740 RVA: 0x00E28D80 File Offset: 0x00E26F80
		public void ShowHighlightExploreSkill()
		{
			if (this.Highlighting)
			{
				Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "上一次高亮探索技能未结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.LastExploreToolId = (ERouletteExploreId)RouletteModel.Instance.CurrentExploreSkillId;
			Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "主动触发玩家探索技能高亮", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnShowHighlightExploreSkill();
		}

		// Token: 0x06032795 RID: 206741 RVA: 0x00E28DEC File Offset: 0x00E26FEC
		public void HideHighlightExploreSkill()
		{
			if (!this.Highlighting)
			{
				return;
			}
			Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "主动触发玩家探索技能取消高亮", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnHideHighlightExploreSkill();
		}

		// Token: 0x06032796 RID: 206742 RVA: 0x00E28E28 File Offset: 0x00E27028
		private void TryAddTag()
		{
			Entity vehicleEntity = AutoPilotModel.Instance.VehicleEntity;
			BaseTagComponent baseTagComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null && !baseTagComponent.HasTag(this.HighlightTagId))
			{
				baseTagComponent.AddTag(new int?(this.HighlightTagId));
			}
		}

		// Token: 0x06032797 RID: 206743 RVA: 0x00E28E70 File Offset: 0x00E27070
		private void TryRemoveTag()
		{
			Entity vehicleEntity = AutoPilotModel.Instance.VehicleEntity;
			BaseTagComponent baseTagComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null && baseTagComponent.HasTag(this.HighlightTagId))
			{
				baseTagComponent.RemoveTag(new int?(this.HighlightTagId));
			}
		}

		// Token: 0x06032798 RID: 206744 RVA: 0x00E28EB8 File Offset: 0x00E270B8
		private void OnShowHighlightExploreSkill()
		{
			this.Highlighting = true;
			RouletteController.Instance.ExploreSkillSetRequest((int)this.ExploreToolId, null, false);
			EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseExploreSkill));
			EventSystem.Instance.Add(EEventName.OnChangeSelectedExploreId, new Action(this.OnChangeExploreSkill));
			this.TryAddTag();
			this.StartTimer();
		}

		// Token: 0x06032799 RID: 206745 RVA: 0x00E28F20 File Offset: 0x00E27120
		private void OnHideHighlightExploreSkill()
		{
			this.Highlighting = false;
			this.TryRemoveTag();
			RouletteController.Instance.ExploreSkillSetRequest((int)this.LastExploreToolId, null, false);
			EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseExploreSkill));
			EventSystem.Instance.Remove(EEventName.OnChangeSelectedExploreId, new Action(this.OnChangeExploreSkill));
			this.ClearTimer();
		}

		// Token: 0x0603279A RID: 206746 RVA: 0x00E28F88 File Offset: 0x00E27188
		private void OnHighlightTimeUp(float delta)
		{
			Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "高亮时间结束，玩家探索技能取消高亮", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnHideHighlightExploreSkill();
		}

		// Token: 0x0603279B RID: 206747 RVA: 0x00E28FBC File Offset: 0x00E271BC
		private void OnChangeExploreSkill()
		{
			if (RouletteModel.Instance.CurrentExploreSkillId == (int)this.ExploreToolId)
			{
				Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "切换探索技能，玩家探索技能高亮", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.TryAddTag();
				return;
			}
			Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "切换探索技能，玩家探索技能取消高亮", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.TryRemoveTag();
		}

		// Token: 0x0603279C RID: 206748 RVA: 0x00E29028 File Offset: 0x00E27228
		private void OnUseExploreSkill(int charId, int skillId, bool isAutonomousProxy)
		{
			SVisionData visionData = PhantomUtil.GetVisionData((int)this.ExploreToolId);
			if (visionData == null)
			{
				return;
			}
			int 技能ID = visionData.技能ID;
			if (skillId == 技能ID)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AutoPilot;
				ELogAuthor author = ELogAuthor.CB;
				string message = "使用高亮技能，玩家探索技能取消高亮";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.ExploreToolId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.OnHideHighlightExploreSkill();
			}
		}

		// Token: 0x0401AC52 RID: 109650
		private readonly ERouletteExploreId ExploreToolId = ERouletteExploreId.摩托自动巡航;

		// Token: 0x0401AC53 RID: 109651
		private ERouletteExploreId LastExploreToolId = ERouletteExploreId.摩托自动巡航;

		// Token: 0x0401AC54 RID: 109652
		private readonly int HighlightTagId = GameplayTagDefine.EGameplayTagId["系统.自动巡航.探索技能高亮"];

		// Token: 0x0401AC55 RID: 109653
		private bool Highlighting;

		// Token: 0x0401AC56 RID: 109654
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
