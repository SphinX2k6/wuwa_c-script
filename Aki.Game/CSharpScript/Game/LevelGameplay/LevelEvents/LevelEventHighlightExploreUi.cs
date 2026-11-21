using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CAF RID: 23727
	public class LevelEventHighlightExploreUi : LevelEventBase
	{
		// Token: 0x0603A290 RID: 238224 RVA: 0x010669E4 File Offset: 0x01064BE4
		public LevelEventHighlightExploreUi(int id) : base(id)
		{
		}

		// Token: 0x0603A291 RID: 238225 RVA: 0x010669F0 File Offset: 0x01064BF0
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
