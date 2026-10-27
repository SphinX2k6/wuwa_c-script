using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020029E9 RID: 10729
public class ShipTogetherView : UiViewBase
{
	// Token: 0x0601640A RID: 91146 RVA: 0x005A0EFF File Offset: 0x0059F0FF
	[NullableContext(1)]
	public ShipTogetherView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601640B RID: 91147 RVA: 0x005A0F08 File Offset: 0x0059F108
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x0601640C RID: 91148 RVA: 0x005A0F88 File Offset: 0x0059F188
	protected override void OnStart()
	{
		this.RoleScrollView = new LoopScrollView<ShipTogetherRoleItem, IShipTogetherRoleItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<ShipTogetherRoleItem>(this.CreateLoopItem), false);
		ShipTogetherModel.Instance.CurrentSelectTogetherRoleId = ShipTogetherModel.Instance.RiderSharingRoleId;
	}

	// Token: 0x0601640D RID: 91149 RVA: 0x005A0FDC File Offset: 0x0059F1DC
	protected override void OnBeforeShow()
	{
		ShipTogetherView.<>c__DisplayClass6_0 CS$<>8__locals1 = new ShipTogetherView.<>c__DisplayClass6_0();
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		ShipTogetherView.<>c__DisplayClass6_0 CS$<>8__locals2 = CS$<>8__locals1;
		FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
		CS$<>8__locals2.currentFormationList = ((currentFormationData != null) ? currentFormationData.RoleIdList : null);
		List<IShipTogetherRoleItemData> list = new List<IShipTogetherRoleItemData>();
		CS$<>8__locals1.originalIdList = new List<int>();
		foreach (int num in CS$<>8__locals1.currentFormationList)
		{
			if (num > 100000)
			{
				TrialRoleInfo? trialRoleInfo;
				CS$<>8__locals1.originalIdList.Add((RoleConfig.Instance.GetTrialRoleConfig(num) != null) ? trialRoleInfo.GetValueOrDefault().ParentId : 0);
			}
		}
		foreach (RoleInstance roleInstance in roleList)
		{
			if (!RoleModel.Instance.IsMainRole(roleInstance.GetRoleId()))
			{
				ShipTogetherRoleItemData item = new ShipTogetherRoleItemData
				{
					RoleInstance = roleInstance,
					IsInFormation = (CS$<>8__locals1.currentFormationList.Contains(roleInstance.GetRoleId()) || CS$<>8__locals1.originalIdList.Contains(roleInstance.GetRoleId()))
				};
				list.Add(item);
			}
		}
		list.Sort(delegate(IShipTogetherRoleItemData a, IShipTogetherRoleItemData b)
		{
			RoleInstance roleInstance2 = a.RoleInstance;
			RoleInstance roleInstance3 = b.RoleInstance;
			bool flag = CS$<>8__locals1.currentFormationList.Contains(roleInstance2.GetRoleId()) || CS$<>8__locals1.originalIdList.Contains(roleInstance2.GetRoleId());
			bool flag2 = CS$<>8__locals1.currentFormationList.Contains(roleInstance3.GetRoleId()) || CS$<>8__locals1.originalIdList.Contains(roleInstance3.GetRoleId());
			if (!flag && !flag2)
			{
				int favorLevel = roleInstance2.GetFavorData().GetFavorLevel();
				int favorLevel2 = roleInstance3.GetFavorData().GetFavorLevel();
				if (favorLevel != favorLevel2)
				{
					return favorLevel2 - favorLevel;
				}
				return roleInstance3.GetRoleCreateTime() - roleInstance2.GetRoleCreateTime();
			}
			else
			{
				if (flag && flag2)
				{
					return 0;
				}
				if (flag)
				{
					return 1;
				}
				return -1;
			}
		});
		LoopScrollView<ShipTogetherRoleItem, IShipTogetherRoleItemData> roleScrollView = this.RoleScrollView;
		if (roleScrollView == null)
		{
			return;
		}
		roleScrollView.RefreshByData(list, false, null, false);
	}

	// Token: 0x0601640E RID: 91150 RVA: 0x005A1144 File Offset: 0x0059F344
	[NullableContext(1)]
	private ShipTogetherRoleItem CreateLoopItem()
	{
		ShipTogetherRoleItem shipTogetherRoleItem = new ShipTogetherRoleItem();
		shipTogetherRoleItem.BindOnClickToggleCallBack(new Action<UUIExtendToggle, int>(this.RoleItemToggleCallBack));
		return shipTogetherRoleItem;
	}

	// Token: 0x0601640F RID: 91151 RVA: 0x005A115D File Offset: 0x0059F35D
	[NullableContext(2)]
	private void RoleItemToggleCallBack(UUIExtendToggle toggle, int roleId)
	{
		if (this.CurrentSelectToggle != toggle)
		{
			UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
			if (currentSelectToggle != null)
			{
				currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		this.CurrentSelectToggle = toggle;
		ShipTogetherModel.Instance.CurrentSelectTogetherRoleId = roleId;
	}

	// Token: 0x06016410 RID: 91152 RVA: 0x005A1190 File Offset: 0x0059F390
	private void OnClickConfirmBtn()
	{
		if (ShipTogetherModel.Instance.CurrentSelectTogetherRoleId != -1)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnChangeRideSharingPassenger, ShipTogetherModel.Instance.CurrentSelectTogetherRoleId, 1);
		}
		else
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnRemoveRideSharingPassenger, -1, -1);
		}
		base.CloseMe(null);
	}

	// Token: 0x0400A590 RID: 42384
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTogetherRoleItem, IShipTogetherRoleItemData> RoleScrollView;

	// Token: 0x0400A591 RID: 42385
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x02009023 RID: 36899
	private class EChildType
	{
		// Token: 0x0402EAB2 RID: 191154
		public const int RoleLoopScrollView = 0;

		// Token: 0x0402EAB3 RID: 191155
		public const int RoleItem = 1;

		// Token: 0x0402EAB4 RID: 191156
		public const int ConfirmBtn = 2;
	}
}
