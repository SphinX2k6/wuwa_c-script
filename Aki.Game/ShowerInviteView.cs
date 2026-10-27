using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A06 RID: 10758
[NullableContext(1)]
[Nullable(0)]
public class ShowerInviteView : UiViewBase
{
	// Token: 0x06016530 RID: 91440 RVA: 0x005A6590 File Offset: 0x005A4790
	public ShowerInviteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016531 RID: 91441 RVA: 0x005A65B0 File Offset: 0x005A47B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnConfirmButtonClick)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnLeftButtonClick)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnRightButtonClick))
		};
	}

	// Token: 0x06016532 RID: 91442 RVA: 0x005A6728 File Offset: 0x005A4928
	protected override UniTask OnBeforeStartAsync()
	{
		ShowerInviteView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShowerInviteView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016533 RID: 91443 RVA: 0x005A676C File Offset: 0x005A496C
	protected override void OnStart()
	{
		List<int> showerSeatConfigIds = this.OpenParam as List<int>;
		ShowerModel.Instance.SetShowerSeatConfigIds(showerSeatConfigIds);
	}

	// Token: 0x06016534 RID: 91444 RVA: 0x005A6790 File Offset: 0x005A4990
	protected override void OnBeforeShow()
	{
		ShowerInviteView.<>c__DisplayClass10_0 CS$<>8__locals1 = new ShowerInviteView.<>c__DisplayClass10_0();
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		ShowerInviteView.<>c__DisplayClass10_0 CS$<>8__locals2 = CS$<>8__locals1;
		FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
		CS$<>8__locals2.currentFormationList = ((currentFormationData != null) ? currentFormationData.RoleIdList : null);
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
				ShowerInviteItemData item = new ShowerInviteItemData
				{
					RoleInstance = roleInstance,
					IsInFormation = (CS$<>8__locals1.currentFormationList.Contains(roleInstance.GetRoleId()) || CS$<>8__locals1.originalIdList.Contains(roleInstance.GetRoleId()))
				};
				this.RoleDataList.Add(item);
			}
		}
		this.RoleDataList.Sort(delegate(IShowerInviteItemData a, IShowerInviteItemData b)
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
		foreach (ShowerRoleItem showerRoleItem in this.RoleItems)
		{
			showerRoleItem.SetUiActive(false);
		}
		ShowerModel.Instance.ResetCurInviteRoles();
		this.OnPosSwitchCallback(ShowerModel.Instance.CurSelectPosIndex);
	}

	// Token: 0x06016535 RID: 91445 RVA: 0x005A6940 File Offset: 0x005A4B40
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06016536 RID: 91446 RVA: 0x005A695E File Offset: 0x005A4B5E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06016537 RID: 91447 RVA: 0x005A697C File Offset: 0x005A4B7C
	private void OnCameraFinish(UiCameraHandleData handleData)
	{
		if (handleData.ViewName == EUiViewName.ShowerInviteView)
		{
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LRC, "OnCameraFinish:ShowerInviteView OnCameraFinish", default(ReadOnlySpan<ValueTuple<string, object>>));
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.InitRoleItems();
			}, null, null);
		}
	}

	// Token: 0x06016538 RID: 91448 RVA: 0x005A69D5 File Offset: 0x005A4BD5
	private ShowerInviteItem CreateRoleInfoItem()
	{
		ShowerInviteItem showerInviteItem = new ShowerInviteItem();
		showerInviteItem.BindRoleSelectCallback(new Action<RoleInstance>(this.OnRoleSelectCallback));
		return showerInviteItem;
	}

	// Token: 0x06016539 RID: 91449 RVA: 0x005A69F0 File Offset: 0x005A4BF0
	private void InitRoleItems()
	{
		int num = Math.Min(ShowerModel.Instance.PosCount, this.RoleItems.Count);
		this.RoleShowCount = 0;
		for (int i = 0; i < num; i++)
		{
			ShowerRoleItem showerRoleItem = this.RoleItems[i];
			WorldEntity showerSeatEntityByPos = ShowerModel.Instance.GetShowerSeatEntityByPos(i);
			bool flag = showerRoleItem.SetPos(i, showerSeatEntityByPos);
			showerRoleItem.SetUiActive(flag);
			if (flag)
			{
				this.RoleShowCount++;
			}
		}
		for (int j = 0; j < this.RoleShowCount; j++)
		{
			this.RoleItems[j].BindPosChangeCallback(new Action<int>(this.OnPosSwitchCallback));
		}
		this.RefreshRoleItems();
	}

	// Token: 0x0601653A RID: 91450 RVA: 0x005A6A9C File Offset: 0x005A4C9C
	private void RefreshRoleItems()
	{
		for (int i = 0; i < this.RoleShowCount; i++)
		{
			ShowerRoleItem showerRoleItem = this.RoleItems[i];
			RoleInstance roleInstanceByPos = ShowerModel.Instance.GetRoleInstanceByPos(i);
			showerRoleItem.RefreshRoleInfo(ShowerModel.Instance.CurSelectPosIndex, roleInstanceByPos);
		}
	}

	// Token: 0x0601653B RID: 91451 RVA: 0x005A6AE2 File Offset: 0x005A4CE2
	private void OnRoleSelectCallback(RoleInstance roleInstance)
	{
		ShowerModel.Instance.InviteRole(roleInstance);
		this.RefreshView();
	}

	// Token: 0x0601653C RID: 91452 RVA: 0x005A6AF5 File Offset: 0x005A4CF5
	private void OnPosSwitchCallback(int posIndex)
	{
		ShowerModel.Instance.ChangePos(posIndex);
		this.RefreshView();
		this.SetSelectedRoleItem();
	}

	// Token: 0x0601653D RID: 91453 RVA: 0x005A6B10 File Offset: 0x005A4D10
	private void RefreshView()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "ShowerInvitePos", new <>z__ReadOnlySingleElementList<object>(ShowerModel.Instance.CurSelectPosIndex + 1));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "ShowerInviteNumber", new <>z__ReadOnlySingleElementList<object>(ShowerModel.Instance.GetInviteNumString()));
		LoopScrollView<ShowerInviteItem, IShowerInviteItemData> roleInfoScrollView = this.RoleInfoScrollView;
		if (roleInfoScrollView != null)
		{
			roleInfoScrollView.RefreshByData(this.RoleDataList, false, null, false);
		}
		this.RefreshRoleItems();
	}

	// Token: 0x0601653E RID: 91454 RVA: 0x005A6B90 File Offset: 0x005A4D90
	private void SetSelectedRoleItem()
	{
		RoleInstance roleInstanceByPos = ShowerModel.Instance.GetRoleInstanceByPos(ShowerModel.Instance.CurSelectPosIndex);
		if (roleInstanceByPos == null)
		{
			return;
		}
		int num = 0;
		this.RoleInfoScrollView.DeselectCurrentGridProxy(false);
		while (num < this.RoleDataList.Count && roleInstanceByPos.GetRoleId() != this.RoleDataList[num].RoleInstance.GetRoleId())
		{
			num++;
		}
		this.RoleInfoScrollView.ScrollToGridIndex(num, true);
		this.RoleInfoScrollView.SelectGridProxy(num, false);
	}

	// Token: 0x0601653F RID: 91455 RVA: 0x005A6C10 File Offset: 0x005A4E10
	private void OnConfirmButtonClick()
	{
		ShowerModel.Instance.SendAndSave();
		UiManager.Instance.CloseAndOpenView(EUiViewName.ShowerInviteView, EUiViewName.ShowerMainView, null, null, true);
	}

	// Token: 0x06016540 RID: 91456 RVA: 0x005A6C33 File Offset: 0x005A4E33
	private void OnLeftButtonClick()
	{
		ShowerModel.Instance.LeftPos();
		this.RefreshView();
		this.SetSelectedRoleItem();
	}

	// Token: 0x06016541 RID: 91457 RVA: 0x005A6C4B File Offset: 0x005A4E4B
	private void OnRightButtonClick()
	{
		ShowerModel.Instance.RightPos();
		this.RefreshView();
		this.SetSelectedRoleItem();
	}

	// Token: 0x06016542 RID: 91458 RVA: 0x005A6C64 File Offset: 0x005A4E64
	private void OnClickBack()
	{
		if (ShowerModel.Instance.IsInShower)
		{
			UiManager.Instance.CloseAndOpenView(EUiViewName.ShowerInviteView, EUiViewName.ShowerMainView, null, null, true);
		}
		else
		{
			ShowerModel.Instance.ClearCurInviteRoles();
			base.CloseMe(null);
		}
		AudioSystem.Instance.PostEvent("play_ui_com_cam_whoosh");
	}

	// Token: 0x0400A60D RID: 42509
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShowerInviteItem, IShowerInviteItemData> RoleInfoScrollView;

	// Token: 0x0400A60E RID: 42510
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A60F RID: 42511
	private readonly List<IShowerInviteItemData> RoleDataList = new List<IShowerInviteItemData>();

	// Token: 0x0400A610 RID: 42512
	private readonly List<ShowerRoleItem> RoleItems = new List<ShowerRoleItem>();

	// Token: 0x0400A611 RID: 42513
	private int RoleShowCount;

	// Token: 0x02009041 RID: 36929
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402EB57 RID: 191319
		public const int RoleInfoScrollView = 0;

		// Token: 0x0402EB58 RID: 191320
		public const int RoleInfoItem = 1;

		// Token: 0x0402EB59 RID: 191321
		public const int ConfirmButton = 2;

		// Token: 0x0402EB5A RID: 191322
		public const int ConfirmText = 3;

		// Token: 0x0402EB5B RID: 191323
		public const int CaptionItem = 4;

		// Token: 0x0402EB5C RID: 191324
		public const int MaxCountText = 5;

		// Token: 0x0402EB5D RID: 191325
		public const int LeftButton = 6;

		// Token: 0x0402EB5E RID: 191326
		public const int RightButton = 7;

		// Token: 0x0402EB5F RID: 191327
		public const int PosNameText = 8;

		// Token: 0x0402EB60 RID: 191328
		public const int FirstRole = 9;

		// Token: 0x0402EB61 RID: 191329
		public const int SecondRole = 10;

		// Token: 0x0402EB62 RID: 191330
		public const int ThirdRole = 11;
	}
}
