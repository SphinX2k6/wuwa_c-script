using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F81 RID: 8065
[NullableContext(1)]
[Nullable(0)]
public class ShowerInviteView : UiViewBase
{
	// Token: 0x06013F37 RID: 81719 RVA: 0x005D1568 File Offset: 0x005CF768
	public ShowerInviteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013F38 RID: 81720 RVA: 0x005D1588 File Offset: 0x005CF788
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

	// Token: 0x06013F39 RID: 81721 RVA: 0x005D1700 File Offset: 0x005CF900
	protected override UniTask OnBeforeStartAsync()
	{
		ShowerInviteView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShowerInviteView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013F3A RID: 81722 RVA: 0x005D1744 File Offset: 0x005CF944
	protected override void OnStart()
	{
		List<int> showerSeatConfigIds = this.OpenParam as List<int>;
		ShowerModel.Instance.SetShowerSeatConfigIds(showerSeatConfigIds);
	}

	// Token: 0x06013F3B RID: 81723 RVA: 0x005D1768 File Offset: 0x005CF968
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

	// Token: 0x06013F3C RID: 81724 RVA: 0x005D1918 File Offset: 0x005CFB18
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06013F3D RID: 81725 RVA: 0x005D1936 File Offset: 0x005CFB36
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06013F3E RID: 81726 RVA: 0x005D1954 File Offset: 0x005CFB54
	private void OnCameraFinish(UiCameraHandleData handleData)
	{
		if (handleData.GetViewName() == EUiViewName.ShowerInviteView)
		{
			Log.Instance.Info(ELogModule.Camera, ELogAuthor.LRC, "OnCameraFinish:ShowerInviteView OnCameraFinish", default(ReadOnlySpan<ValueTuple<string, object>>));
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.InitRoleItems();
			}, null, null);
		}
	}

	// Token: 0x06013F3F RID: 81727 RVA: 0x005D19AD File Offset: 0x005CFBAD
	private ShowerInviteItem CreateRoleInfoItem()
	{
		ShowerInviteItem showerInviteItem = new ShowerInviteItem();
		showerInviteItem.BindRoleSelectCallback(new Action<RoleInstance>(this.OnRoleSelectCallback));
		return showerInviteItem;
	}

	// Token: 0x06013F40 RID: 81728 RVA: 0x005D19C8 File Offset: 0x005CFBC8
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

	// Token: 0x06013F41 RID: 81729 RVA: 0x005D1A74 File Offset: 0x005CFC74
	private void RefreshRoleItems()
	{
		for (int i = 0; i < this.RoleShowCount; i++)
		{
			ShowerRoleItem showerRoleItem = this.RoleItems[i];
			RoleInstance roleInstanceByPos = ShowerModel.Instance.GetRoleInstanceByPos(i);
			showerRoleItem.RefreshRoleInfo(ShowerModel.Instance.CurSelectPosIndex, roleInstanceByPos);
		}
	}

	// Token: 0x06013F42 RID: 81730 RVA: 0x005D1ABA File Offset: 0x005CFCBA
	private void OnRoleSelectCallback(RoleInstance roleInstance)
	{
		ShowerModel.Instance.InviteRole(roleInstance);
		this.RefreshView();
	}

	// Token: 0x06013F43 RID: 81731 RVA: 0x005D1ACD File Offset: 0x005CFCCD
	private void OnPosSwitchCallback(int posIndex)
	{
		ShowerModel.Instance.ChangePos(posIndex);
		this.RefreshView();
		this.SetSelectedRoleItem();
	}

	// Token: 0x06013F44 RID: 81732 RVA: 0x005D1AE8 File Offset: 0x005CFCE8
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

	// Token: 0x06013F45 RID: 81733 RVA: 0x005D1B68 File Offset: 0x005CFD68
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

	// Token: 0x06013F46 RID: 81734 RVA: 0x005D1BE8 File Offset: 0x005CFDE8
	private void OnConfirmButtonClick()
	{
		ShowerModel.Instance.SendAndSave();
		UiManager.Instance.CloseAndOpenView(EUiViewName.ShowerInviteView, EUiViewName.ShowerMainView, null, null, true);
	}

	// Token: 0x06013F47 RID: 81735 RVA: 0x005D1C0B File Offset: 0x005CFE0B
	private void OnLeftButtonClick()
	{
		ShowerModel.Instance.LeftPos();
		this.RefreshView();
		this.SetSelectedRoleItem();
	}

	// Token: 0x06013F48 RID: 81736 RVA: 0x005D1C23 File Offset: 0x005CFE23
	private void OnRightButtonClick()
	{
		ShowerModel.Instance.RightPos();
		this.RefreshView();
		this.SetSelectedRoleItem();
	}

	// Token: 0x06013F49 RID: 81737 RVA: 0x005D1C3C File Offset: 0x005CFE3C
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

	// Token: 0x0400A9F7 RID: 43511
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShowerInviteItem, IShowerInviteItemData> RoleInfoScrollView;

	// Token: 0x0400A9F8 RID: 43512
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A9F9 RID: 43513
	private readonly List<IShowerInviteItemData> RoleDataList = new List<IShowerInviteItemData>();

	// Token: 0x0400A9FA RID: 43514
	private readonly List<ShowerRoleItem> RoleItems = new List<ShowerRoleItem>();

	// Token: 0x0400A9FB RID: 43515
	private int RoleShowCount;

	// Token: 0x02008288 RID: 33416
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A24F RID: 172623
		public const int RoleInfoScrollView = 0;

		// Token: 0x0402A250 RID: 172624
		public const int RoleInfoItem = 1;

		// Token: 0x0402A251 RID: 172625
		public const int ConfirmButton = 2;

		// Token: 0x0402A252 RID: 172626
		public const int ConfirmText = 3;

		// Token: 0x0402A253 RID: 172627
		public const int CaptionItem = 4;

		// Token: 0x0402A254 RID: 172628
		public const int MaxCountText = 5;

		// Token: 0x0402A255 RID: 172629
		public const int LeftButton = 6;

		// Token: 0x0402A256 RID: 172630
		public const int RightButton = 7;

		// Token: 0x0402A257 RID: 172631
		public const int PosNameText = 8;

		// Token: 0x0402A258 RID: 172632
		public const int FirstRole = 9;

		// Token: 0x0402A259 RID: 172633
		public const int SecondRole = 10;

		// Token: 0x0402A25A RID: 172634
		public const int ThirdRole = 11;
	}
}
