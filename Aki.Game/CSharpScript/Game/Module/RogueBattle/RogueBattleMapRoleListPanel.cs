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
	// Token: 0x02004E7E RID: 20094
	public class RogueBattleMapRoleListPanel : UiPanelBase
	{
		// Token: 0x06033B3C RID: 211772 RVA: 0x00C1BED0 File Offset: 0x00C1A0D0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06033B3D RID: 211773 RVA: 0x00C1BF2A File Offset: 0x00C1A12A
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

		// Token: 0x06033B3E RID: 211774 RVA: 0x00C1BF5F File Offset: 0x00C1A15F
		public void BindEvent()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnSelectedItem));
		}

		// Token: 0x06033B3F RID: 211775 RVA: 0x00C1BF7D File Offset: 0x00C1A17D
		public void UnbindEvent()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnSelectedItem));
		}

		// Token: 0x06033B40 RID: 211776 RVA: 0x00C1BF9C File Offset: 0x00C1A19C
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

		// Token: 0x06033B41 RID: 211777 RVA: 0x00C1C144 File Offset: 0x00C1A344
		protected override void OnBeforeDestroy()
		{
			this.ScrollView = null;
		}

		// Token: 0x06033B42 RID: 211778 RVA: 0x00C1C14D File Offset: 0x00C1A34D
		[NullableContext(1)]
		private RogueBattleMapRoleLayoutItem CreateLoopItem()
		{
			return new RogueBattleMapRoleLayoutItem();
		}

		// Token: 0x06033B43 RID: 211779 RVA: 0x00C1C154 File Offset: 0x00C1A354
		private void OnSelectedItem(int roleId)
		{
			this.CurrentSelectedId = roleId;
		}

		// Token: 0x0401B70B RID: 112395
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueBattleMapRoleLayoutItem, List<int>> ScrollView;

		// Token: 0x0401B70C RID: 112396
		private int CurrentSelectedId;
	}
}
