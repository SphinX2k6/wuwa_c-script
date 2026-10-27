using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity
{
	// Token: 0x020061AE RID: 25006
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityRogueData : ActivityBaseData
	{
		// Token: 0x1700920B RID: 37387
		// (get) Token: 0x0603F27F RID: 258687 RVA: 0x00F4198F File Offset: 0x00F3FB8F
		// (set) Token: 0x0603F27E RID: 258686 RVA: 0x00F41970 File Offset: 0x00F3FB70
		public bool FunctionBtnRedDot
		{
			get
			{
				return this.FunctionBtnRedDotInternal;
			}
			set
			{
				this.FunctionBtnRedDotInternal = value;
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			}
		}

		// Token: 0x1700920C RID: 37388
		// (get) Token: 0x0603F280 RID: 258688 RVA: 0x00F41997 File Offset: 0x00F3FB97
		public RogueSeasonData SeasonData
		{
			get
			{
				return this.SeasonDataInternal;
			}
		}

		// Token: 0x0603F281 RID: 258689 RVA: 0x00F419A0 File Offset: 0x00F3FBA0
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
			RoguelikeActivityData roguelikeActivityData = data.RoguelikeActivityData;
			if (roguelikeActivityData == null)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.BB, "ActivityRougeData无肉鸽额外数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SeasonDataInternal = roguelikeActivityData.RogueSeasonData;
			RoguelikeModel instance = RoguelikeModel.Instance;
			RogueSeasonData rogueSeasonData = roguelikeActivityData.RogueSeasonData;
			instance.TempCountdown = ((rogueSeasonData != null) ? new long?(rogueSeasonData.EndTime) : null);
			this.FunctionBtnRedDotInternal = base.GetIfFirstOpen();
		}

		// Token: 0x0603F282 RID: 258690 RVA: 0x00F41A18 File Offset: 0x00F3FC18
		public override bool NeedSelfControlFirstRedPoint()
		{
			return false;
		}

		// Token: 0x1700920D RID: 37389
		// (get) Token: 0x0603F283 RID: 258691 RVA: 0x00F41A1B File Offset: 0x00F3FC1B
		public override bool RedPointShowState
		{
			get
			{
				return this.GetRogueActivityState() != ERogueActivityState.Close && (base.GetIfFirstOpen() || (base.IsUnLock() && this.GetExDataRedPointShowState()));
			}
		}

		// Token: 0x0603F284 RID: 258692 RVA: 0x00F41A48 File Offset: 0x00F3FC48
		public RogueActivity? GetExtraConfig()
		{
			ActivityRogueConfig instance = ActivityRogueConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetActivityUniversalConfig(base.Id);
		}

		// Token: 0x0603F285 RID: 258693 RVA: 0x00F41A73 File Offset: 0x00F3FC73
		public override bool GetExDataRedPointShowState()
		{
			return base.GetPreGuideQuestFinishState() && (this.FunctionBtnRedDotInternal || RoguelikeModel.Instance.GetRoguelikeAchievementRedDot() || RoguelikeModel.Instance.CheckHasCanUnlockSkill() || RoguelikeModel.Instance.CheckRoguelikeShopRedDot());
		}

		// Token: 0x0603F286 RID: 258694 RVA: 0x00F41AAB File Offset: 0x00F3FCAB
		public ERogueActivityState GetRogueActivityState()
		{
			if (this.CheckIfInOpenTime())
			{
				return ERogueActivityState.Open;
			}
			return ERogueActivityState.Close;
		}

		// Token: 0x0603F287 RID: 258695 RVA: 0x00F41AB8 File Offset: 0x00F3FCB8
		public void OnQuestStateChange(int questId, QuestState state)
		{
			if (!this.LocalConfig.Value.PreShowGuideQuest().Contains(questId))
			{
				return;
			}
			if (state != QuestState.Finish)
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x04020EAB RID: 134827
		private bool FunctionBtnRedDotInternal;

		// Token: 0x04020EAC RID: 134828
		private RogueSeasonData SeasonDataInternal;
	}
}
