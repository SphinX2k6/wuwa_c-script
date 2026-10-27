using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E75 RID: 24181
	public class AutoPilotSkillHighLightLogic
	{
		// Token: 0x0603D801 RID: 251905 RVA: 0x00ED776E File Offset: 0x00ED596E
		private void StartTimer()
		{
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnHighlightTimeUp), (float)(AutoPilotModel.Instance.GetSkillHighLightTime() * TimeUtil.Instance.InverseMillisecond), null, null, true, 1f);
		}

		// Token: 0x0603D802 RID: 251906 RVA: 0x00ED77AA File Offset: 0x00ED59AA
		private void ClearTimer()
		{
			if (this.TimerHandle != null && TimerSystem.Instance.Has(this.TimerHandle))
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603D803 RID: 251907 RVA: 0x00ED77DE File Offset: 0x00ED59DE
		public void Dispose()
		{
			if (this.Highlighting)
			{
				this.OnHideHighlightExploreSkill();
			}
			this.ClearTimer();
		}

		// Token: 0x0603D804 RID: 251908 RVA: 0x00ED77F4 File Offset: 0x00ED59F4
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

		// Token: 0x0603D805 RID: 251909 RVA: 0x00ED7860 File Offset: 0x00ED5A60
		public void HideHighlightExploreSkill()
		{
			if (!this.Highlighting)
			{
				return;
			}
			Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "主动触发玩家探索技能取消高亮", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnHideHighlightExploreSkill();
		}

		// Token: 0x0603D806 RID: 251910 RVA: 0x00ED789C File Offset: 0x00ED5A9C
		private void TryAddTag()
		{
			Entity vehicleEntity = AutoPilotModel.Instance.VehicleEntity;
			BaseTagComponent baseTagComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null && !baseTagComponent.HasTag(this.HighlightTagId))
			{
				baseTagComponent.AddTag(new int?(this.HighlightTagId));
			}
		}

		// Token: 0x0603D807 RID: 251911 RVA: 0x00ED78E4 File Offset: 0x00ED5AE4
		private void TryRemoveTag()
		{
			Entity vehicleEntity = AutoPilotModel.Instance.VehicleEntity;
			BaseTagComponent baseTagComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null && baseTagComponent.HasTag(this.HighlightTagId))
			{
				baseTagComponent.RemoveTag(new int?(this.HighlightTagId));
			}
		}

		// Token: 0x0603D808 RID: 251912 RVA: 0x00ED792C File Offset: 0x00ED5B2C
		private void OnShowHighlightExploreSkill()
		{
			this.Highlighting = true;
			RouletteController.Instance.ExploreSkillSetRequest((int)this.ExploreToolId, null, false);
			EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseExploreSkill));
			EventSystem.Instance.Add(EEventName.OnChangeSelectedExploreId, new Action(this.OnChangeExploreSkill));
			this.TryAddTag();
			this.StartTimer();
		}

		// Token: 0x0603D809 RID: 251913 RVA: 0x00ED7994 File Offset: 0x00ED5B94
		private void OnHideHighlightExploreSkill()
		{
			this.Highlighting = false;
			this.TryRemoveTag();
			RouletteController.Instance.ExploreSkillSetRequest((int)this.LastExploreToolId, null, false);
			EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseExploreSkill));
			EventSystem.Instance.Remove(EEventName.OnChangeSelectedExploreId, new Action(this.OnChangeExploreSkill));
			this.ClearTimer();
		}

		// Token: 0x0603D80A RID: 251914 RVA: 0x00ED79FC File Offset: 0x00ED5BFC
		private void OnHighlightTimeUp(float delta)
		{
			Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "高亮时间结束，玩家探索技能取消高亮", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnHideHighlightExploreSkill();
		}

		// Token: 0x0603D80B RID: 251915 RVA: 0x00ED7A30 File Offset: 0x00ED5C30
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

		// Token: 0x0603D80C RID: 251916 RVA: 0x00ED7A9C File Offset: 0x00ED5C9C
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

		// Token: 0x0402018B RID: 131467
		private readonly ERouletteExploreId ExploreToolId = ERouletteExploreId.摩托自动巡航;

		// Token: 0x0402018C RID: 131468
		private ERouletteExploreId LastExploreToolId = ERouletteExploreId.摩托自动巡航;

		// Token: 0x0402018D RID: 131469
		private readonly int HighlightTagId = GameplayTagDefine.EGameplayTagId["系统.自动巡航.探索技能高亮"];

		// Token: 0x0402018E RID: 131470
		private bool Highlighting;

		// Token: 0x0402018F RID: 131471
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
