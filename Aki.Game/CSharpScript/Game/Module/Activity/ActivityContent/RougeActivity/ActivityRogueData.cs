using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity
{
	// Token: 0x0200512C RID: 20780
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityRogueData : ActivityBaseData
	{
		// Token: 0x1700656D RID: 25965
		// (get) Token: 0x06033F3F RID: 212799 RVA: 0x00E88857 File Offset: 0x00E86A57
		// (set) Token: 0x06033F3E RID: 212798 RVA: 0x00E88838 File Offset: 0x00E86A38
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

		// Token: 0x1700656E RID: 25966
		// (get) Token: 0x06033F40 RID: 212800 RVA: 0x00E8885F File Offset: 0x00E86A5F
		public RogueSeasonData SeasonData
		{
			get
			{
				return this.SeasonDataInternal;
			}
		}

		// Token: 0x06033F41 RID: 212801 RVA: 0x00E88868 File Offset: 0x00E86A68
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

		// Token: 0x06033F42 RID: 212802 RVA: 0x00E888E0 File Offset: 0x00E86AE0
		public override bool NeedSelfControlFirstRedPoint()
		{
			return false;
		}

		// Token: 0x1700656F RID: 25967
		// (get) Token: 0x06033F43 RID: 212803 RVA: 0x00E888E3 File Offset: 0x00E86AE3
		public override bool RedPointShowState
		{
			get
			{
				return this.GetRogueActivityState() != ERogueActivityState.Close && (base.GetIfFirstOpen() || (base.IsUnLock() && this.GetExDataRedPointShowState()));
			}
		}

		// Token: 0x06033F44 RID: 212804 RVA: 0x00E88910 File Offset: 0x00E86B10
		public RogueActivity? GetExtraConfig()
		{
			ActivityRogueConfig instance = ActivityRogueConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetActivityUniversalConfig(base.Id);
		}

		// Token: 0x06033F45 RID: 212805 RVA: 0x00E8893B File Offset: 0x00E86B3B
		public override bool GetExDataRedPointShowState()
		{
			return base.GetPreGuideQuestFinishState() && (this.FunctionBtnRedDotInternal || RoguelikeModel.Instance.GetRoguelikeAchievementRedDot() || RoguelikeModel.Instance.CheckHasCanUnlockSkill() || RoguelikeModel.Instance.CheckRoguelikeShopRedDot());
		}

		// Token: 0x06033F46 RID: 212806 RVA: 0x00E88973 File Offset: 0x00E86B73
		public ERogueActivityState GetRogueActivityState()
		{
			if (this.CheckIfInOpenTime())
			{
				return ERogueActivityState.Open;
			}
			return ERogueActivityState.Close;
		}

		// Token: 0x06033F47 RID: 212807 RVA: 0x00E88980 File Offset: 0x00E86B80
		public void OnQuestStateChange(int questId, QuestState state)
		{
			if (Array.IndexOf<int>(this.LocalConfig.Value.PreShowGuideQuest(), questId) < 0)
			{
				return;
			}
			if (state != QuestState.Finish)
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0401B7D8 RID: 112600
		private bool FunctionBtnRedDotInternal;

		// Token: 0x0401B7D9 RID: 112601
		private RogueSeasonData SeasonDataInternal;
	}
}
