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
	// Token: 0x02003E45 RID: 15941
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleMapRoleLayoutItem : GridProxyAbstract<List<int>>
	{
		// Token: 0x0602899D RID: 166301 RVA: 0x00B65074 File Offset: 0x00B63274
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

		// Token: 0x0602899E RID: 166302 RVA: 0x00B650E4 File Offset: 0x00B632E4
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnClickSelected));
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamShowAgain, new Action(this.OnShowAgain));
			this.RoleLayout = new GenericLayout<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo>(base.GetGridLayout(2), new Func<RogueBattleMapRoleLayoutGrid>(this.CreateRoleItem), null, false, true);
		}

		// Token: 0x0602899F RID: 166303 RVA: 0x00B6514A File Offset: 0x00B6334A
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnClickSelected));
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamShowAgain, new Action(this.OnShowAgain));
		}

		// Token: 0x060289A0 RID: 166304 RVA: 0x00B65184 File Offset: 0x00B63384
		private RogueBattleMapRoleLayoutGrid CreateRoleItem()
		{
			RogueBattleMapRoleLayoutGrid rogueBattleMapRoleLayoutGrid = new RogueBattleMapRoleLayoutGrid();
			rogueBattleMapRoleLayoutGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
			return rogueBattleMapRoleLayoutGrid;
		}

		// Token: 0x060289A1 RID: 166305 RVA: 0x00B651A0 File Offset: 0x00B633A0
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

		// Token: 0x060289A2 RID: 166306 RVA: 0x00B651DC File Offset: 0x00B633DC
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

		// Token: 0x060289A3 RID: 166307 RVA: 0x00B6529C File Offset: 0x00B6349C
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

		// Token: 0x060289A4 RID: 166308 RVA: 0x00B65368 File Offset: 0x00B63568
		private void OnShowAgain()
		{
			if (this.CurrentSelected == null)
			{
				return;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.CurrentSelected.Value);
			RoleController.Instance.OnSelectedRoleChangeByConfig(this.CurrentSelected.Value, roleConfig.Value.SkinId, null);
		}

		// Token: 0x040160D7 RID: 90327
		private GenericLayout<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo> RoleLayout;

		// Token: 0x040160D8 RID: 90328
		private List<int> RoleList = new List<int>();

		// Token: 0x040160D9 RID: 90329
		private int? CurrentSelected;
	}
}
