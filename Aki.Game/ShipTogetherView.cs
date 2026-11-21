using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F64 RID: 8036
public class ShipTogetherView : UiViewBase
{
	// Token: 0x06013E11 RID: 81425 RVA: 0x005CBEF3 File Offset: 0x005CA0F3
	[NullableContext(1)]
	public ShipTogetherView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013E12 RID: 81426 RVA: 0x005CBEFC File Offset: 0x005CA0FC
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

	// Token: 0x06013E13 RID: 81427 RVA: 0x005CBF7C File Offset: 0x005CA17C
	protected override void OnStart()
	{
		this.RoleScrollView = new LoopScrollView<ShipTogetherRoleItem, IShipTogetherRoleItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<ShipTogetherRoleItem>(this.CreateLoopItem), false);
		ShipTogetherModel.Instance.CurrentSelectTogetherRoleId = ShipTogetherModel.Instance.RiderSharingRoleId;
	}

	// Token: 0x06013E14 RID: 81428 RVA: 0x005CBFD0 File Offset: 0x005CA1D0
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

	// Token: 0x06013E15 RID: 81429 RVA: 0x005CC138 File Offset: 0x005CA338
	[NullableContext(1)]
	private ShipTogetherRoleItem CreateLoopItem()
	{
		ShipTogetherRoleItem shipTogetherRoleItem = new ShipTogetherRoleItem();
		shipTogetherRoleItem.BindOnClickToggleCallBack(new Action<UUIExtendToggle, int>(this.RoleItemToggleCallBack));
		return shipTogetherRoleItem;
	}

	// Token: 0x06013E16 RID: 81430 RVA: 0x005CC151 File Offset: 0x005CA351
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

	// Token: 0x06013E17 RID: 81431 RVA: 0x005CC184 File Offset: 0x005CA384
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

	// Token: 0x0400A97A RID: 43386
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTogetherRoleItem, IShipTogetherRoleItemData> RoleScrollView;

	// Token: 0x0400A97B RID: 43387
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x0200826A RID: 33386
	private class EChildType
	{
		// Token: 0x0402A1AA RID: 172458
		public const int RoleLoopScrollView = 0;

		// Token: 0x0402A1AB RID: 172459
		public const int RoleItem = 1;

		// Token: 0x0402A1AC RID: 172460
		public const int ConfirmBtn = 2;
	}
}
