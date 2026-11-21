using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PermanentRogue;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E47 RID: 15943
	public class RogueBattleMapRoleListPanel : UiPanelBase
	{
		// Token: 0x060289A7 RID: 166311 RVA: 0x00B653F4 File Offset: 0x00B635F4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x060289A8 RID: 166312 RVA: 0x00B6544E File Offset: 0x00B6364E
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<RogueBattleMapRoleLayoutItem, List<int>>(base.GetScrollViewWithScrollbar(0), new Func<RogueBattleMapRoleLayoutItem>(this.CreateLoopItem), null, false, null);
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060289A9 RID: 166313 RVA: 0x00B65483 File Offset: 0x00B63683
		public void BindEvent()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnSelectedItem));
		}

		// Token: 0x060289AA RID: 166314 RVA: 0x00B654A1 File Offset: 0x00B636A1
		public void UnbindEvent()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnSelectedItem));
		}

		// Token: 0x060289AB RID: 166315 RVA: 0x00B654C0 File Offset: 0x00B636C0
		protected override void OnBeforeShow()
		{
			IEnumerable<RogueResBondRole> allRogueResBondRole = RogueBattleConfig.Instance.GetAllRogueResBondRole();
			List<List<int>> list = new List<List<int>>();
			List<int> list2 = new List<int>();
			List<int> list3 = new List<int>();
			int newSeasonId = ActivityPermanentRogueModel.Instance.GetNewSeasonId();
			List<int> trailRole = ActivityPermanentRogueModel.Instance.GetTrailRole(newSeasonId, ERogueResTrialType.Static);
			List<int> trailRole2 = ActivityPermanentRogueModel.Instance.GetTrailRole(newSeasonId, ERogueResTrialType.Dynamic);
			foreach (RogueResBondRole rogueResBondRole in allRogueResBondRole)
			{
				int roleId = rogueResBondRole.RoleId;
				if (RogueBattleModel.Instance.IsRoleGot(roleId))
				{
					list2.Add(roleId);
				}
				else if (RogueBattleModel.Instance.IsRoleGot(rogueResBondRole.TrialRoleId))
				{
					list2.Add(rogueResBondRole.TrialRoleId);
				}
				else
				{
					int baseRoleId = RoleConfig.Instance.GetBaseRoleId(rogueResBondRole.TrialRoleId);
					if (!RoleModel.Instance.IsMainRole(baseRoleId))
					{
						if (trailRole.Contains(rogueResBondRole.TrialRoleId) || trailRole2.Contains(rogueResBondRole.TrialRoleId))
						{
							list3.Add(rogueResBondRole.TrialRoleId);
						}
						else
						{
							list3.Add(roleId);
						}
					}
				}
			}
			if (list2.Count > 0)
			{
				this.CurrentSelectedId = ((this.CurrentSelectedId != 0) ? this.CurrentSelectedId : list2[0]);
				list.Add(list2);
			}
			RogueBattleModel.Instance.SummaryRoleList = list2;
			if (list3.Count > 0)
			{
				this.CurrentSelectedId = ((this.CurrentSelectedId != 0) ? this.CurrentSelectedId : list3[0]);
				list.Add(list3);
			}
			this.ScrollView.RefreshByData(list, delegate
			{
				if (this.CurrentSelectedId != 0)
				{
					EventSystem.Instance.Emit<int>(EEventName.RogueResMapSummaryTeamUpdate, this.CurrentSelectedId);
				}
			}, false);
		}

		// Token: 0x060289AC RID: 166316 RVA: 0x00B65668 File Offset: 0x00B63868
		protected override void OnBeforeDestroy()
		{
			this.ScrollView = null;
		}

		// Token: 0x060289AD RID: 166317 RVA: 0x00B65671 File Offset: 0x00B63871
		[NullableContext(1)]
		private RogueBattleMapRoleLayoutItem CreateLoopItem()
		{
			return new RogueBattleMapRoleLayoutItem();
		}

		// Token: 0x060289AE RID: 166318 RVA: 0x00B65678 File Offset: 0x00B63878
		private void OnSelectedItem(int roleId)
		{
			this.CurrentSelectedId = roleId;
		}

		// Token: 0x040160DE RID: 90334
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueBattleMapRoleLayoutItem, List<int>> ScrollView;

		// Token: 0x040160DF RID: 90335
		private int CurrentSelectedId;
	}
}
