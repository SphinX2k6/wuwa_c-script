using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E7C RID: 20092
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleMapRoleLayoutItem : GridProxyAbstract<List<int>>
	{
		// Token: 0x06033B32 RID: 211762 RVA: 0x00C1BB50 File Offset: 0x00C19D50
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06033B33 RID: 211763 RVA: 0x00C1BBC0 File Offset: 0x00C19DC0
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnClickSelected));
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamShowAgain, new Action(this.OnShowAgain));
			this.RoleLayout = new GenericLayout<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo>(base.GetGridLayout(2), new Func<RogueBattleMapRoleLayoutGrid>(this.CreateRoleItem), null, false, true);
		}

		// Token: 0x06033B34 RID: 211764 RVA: 0x00C1BC26 File Offset: 0x00C19E26
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnClickSelected));
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamShowAgain, new Action(this.OnShowAgain));
		}

		// Token: 0x06033B35 RID: 211765 RVA: 0x00C1BC60 File Offset: 0x00C19E60
		private RogueBattleMapRoleLayoutGrid CreateRoleItem()
		{
			RogueBattleMapRoleLayoutGrid rogueBattleMapRoleLayoutGrid = new RogueBattleMapRoleLayoutGrid();
			rogueBattleMapRoleLayoutGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
			return rogueBattleMapRoleLayoutGrid;
		}

		// Token: 0x06033B36 RID: 211766 RVA: 0x00C1BC7C File Offset: 0x00C19E7C
		private bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				IRogueBattleMapRoleGridInfo rogueBattleMapRoleGridInfo = (IRogueBattleMapRoleGridInfo)data;
				int? currentSelected = this.CurrentSelected;
				int configId = rogueBattleMapRoleGridInfo.ConfigId;
				return !(currentSelected.GetValueOrDefault() == configId & currentSelected != null);
			}
			return true;
		}

		// Token: 0x06033B37 RID: 211767 RVA: 0x00C1BCB8 File Offset: 0x00C19EB8
		private void OnClickSelected(int roleId)
		{
			int? currentSelected = this.CurrentSelected;
			this.CurrentSelected = (this.RoleList.Contains(roleId) ? new int?(roleId) : null);
			if (currentSelected != null)
			{
				RogueBattleMapRoleLayoutGrid selectedProxy = this.RoleLayout.GetSelectedProxy();
				if (selectedProxy != null)
				{
					selectedProxy.SetSelected(false, false);
				}
			}
			if (this.CurrentSelected == null)
			{
				return;
			}
			this.RoleLayout.SelectGridProxy(this.RoleList.IndexOf(roleId), false);
			RogueBattleMapRoleLayoutGrid selectedProxy2 = this.RoleLayout.GetSelectedProxy();
			if (selectedProxy2 != null)
			{
				selectedProxy2.SetSelected(true, false);
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
			RoleController.Instance.OnSelectedRoleChangeByConfig(roleId, roleConfig.Value.SkinId, null);
		}

		// Token: 0x06033B38 RID: 211768 RVA: 0x00C1BD78 File Offset: 0x00C19F78
		public override void Refresh(List<int> data, bool isSelected, int gridIndex)
		{
			this.RoleList = data;
			bool flag = RogueBattleModel.Instance.IsRoleGot(data[0]);
			string textStringId = flag ? "RogueRes_Overall_Role_8" : "RogueRes_Overall_Role_9";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
			List<IRogueBattleMapRoleGridInfo> list = new List<IRogueBattleMapRoleGridInfo>();
			foreach (int configId in data)
			{
				RogueBattleMapRoleGridInfo item = new RogueBattleMapRoleGridInfo
				{
					ConfigId = configId,
					IsGain = flag,
					NeedLevel = true
				};
				list.Add(item);
			}
			this.RoleLayout.RefreshByData(list, delegate
			{
				if (this.CurrentSelected != null)
				{
					this.OnClickSelected(this.CurrentSelected.Value);
				}
			}, false);
		}

		// Token: 0x06033B39 RID: 211769 RVA: 0x00C1BE44 File Offset: 0x00C1A044
		private void OnShowAgain()
		{
			if (this.CurrentSelected == null)
			{
				return;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.CurrentSelected.Value);
			RoleController.Instance.OnSelectedRoleChangeByConfig(this.CurrentSelected.Value, roleConfig.Value.SkinId, null);
		}

		// Token: 0x0401B704 RID: 112388
		private GenericLayout<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo> RoleLayout;

		// Token: 0x0401B705 RID: 112389
		private List<int> RoleList = new List<int>();

		// Token: 0x0401B706 RID: 112390
		private int? CurrentSelected;
	}
}
