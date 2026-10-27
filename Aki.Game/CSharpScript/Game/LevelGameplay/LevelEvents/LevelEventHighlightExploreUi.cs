using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B37 RID: 27447
	public class LevelEventHighlightExploreUi : LevelEventBase
	{
		// Token: 0x0604413E RID: 278846 RVA: 0x010BD158 File Offset: 0x010BB358
		public LevelEventHighlightExploreUi(int id) : base(id)
		{
		}

		// Token: 0x0604413F RID: 278847 RVA: 0x010BD164 File Offset: 0x010BB364
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(false, false, true);
			}
			BaseExploreComponent activeExploreComponent = CharacterExploreModel.Instance.GetActiveExploreComponent();
			if (activeExploreComponent == null)
			{
				return;
			}
			ToggleHighlightExploreUi toggleHighlightExploreUi = inParams as ToggleHighlightExploreUi;
			switch (toggleHighlightExploreUi.Type)
			{
			case EHighlightExploreSkillIconType.Show:
			{
				IShowHighlightExploreSkillIcon showHighlightExploreSkillIcon = toggleHighlightExploreUi as IShowHighlightExploreSkillIcon;
				BaseExploreComponent baseExploreComponent = activeExploreComponent;
				int skillType = showHighlightExploreSkillIcon.SkillType;
				float duration = showHighlightExploreSkillIcon.Duration;
				bool? isSwitchBack = showHighlightExploreSkillIcon.IsSwitchBack;
				EHighlightType? highlightType = showHighlightExploreSkillIcon.HighlightType;
				baseExploreComponent.ShowHighlightExploreSkill(skillType, duration, isSwitchBack, (highlightType != null) ? highlightType.GetValueOrDefault().ToEnumString() : null, null, null, null);
				return;
			}
			case EHighlightExploreSkillIconType.Hide:
				activeExploreComponent.HideHighlightExploreSkill();
				break;
			case EHighlightExploreSkillIconType.ToggleAndHighlightItem:
			{
				IToggleAndHighlightItem toggleAndHighlightItem = toggleHighlightExploreUi as IToggleAndHighlightItem;
				BaseExploreComponent baseExploreComponent2 = activeExploreComponent;
				int skillType2 = toggleAndHighlightItem.SkillType;
				float duration2 = -1f;
				bool? needRevertSkill = new bool?(toggleAndHighlightItem.IsSwitchBack.GetValueOrDefault());
				EHighlightType? highlightType = toggleAndHighlightItem.HighlightType;
				baseExploreComponent2.ShowHighlightExploreSkill(skillType2, duration2, needRevertSkill, (highlightType != null) ? highlightType.GetValueOrDefault().ToEnumString() : null, new int?(toggleAndHighlightItem.ItemId), toggleAndHighlightItem.IsShowTips, null);
				ILeaveAreaItem leaveAreaItem = LeaveAreaItemInfoIds.Get(toggleAndHighlightItem.ItemId);
				if (leaveAreaItem != null)
				{
					LeaveAreaItemInfo.TryLeave(leaveAreaItem);
					return;
				}
				break;
			}
			default:
				return;
			}
		}
	}
}
