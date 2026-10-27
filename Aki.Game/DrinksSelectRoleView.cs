using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F4E RID: 3918
[NullableContext(1)]
[Nullable(0)]
public class DrinksSelectRoleView : UiViewBase, IUiCameraBehavior
{
	// Token: 0x06006432 RID: 25650 RVA: 0x0013C3C6 File Offset: 0x0013A5C6
	public DrinksSelectRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006433 RID: 25651 RVA: 0x0013C3E0 File Offset: 0x0013A5E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUISprite)),
			new ValueTuple<int, Type>(13, typeof(UUISprite)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(17, typeof(UUINiagara)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(19, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(16, new Action(this.OnClickedWine)),
			new ValueTuple<int, Delegate>(18, new Action(this.OnClickedReward))
		};
	}

	// Token: 0x06006434 RID: 25652 RVA: 0x0013C5F8 File Offset: 0x0013A7F8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotStart));
		EventSystem.Instance.Add(EEventName.OnDrinksUnlockClickedNotify, new Action(this.OnRedDotRefresh));
		this.NeedRemove = true;
	}

	// Token: 0x06006435 RID: 25653 RVA: 0x0013C644 File Offset: 0x0013A844
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnDrinksUnlockClickedNotify, new Action(this.OnRedDotRefresh));
		if (this.NeedRemove)
		{
			EventSystem.Instance.Remove(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotStart));
		}
	}

	// Token: 0x06006436 RID: 25654 RVA: 0x0013C694 File Offset: 0x0013A894
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksSelectRoleView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksSelectRoleView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006437 RID: 25655 RVA: 0x0013C6D8 File Offset: 0x0013A8D8
	protected override void OnStart()
	{
		this.ConfirmBtn = new ButtonItem(base.GetItem(14));
		this.ConfirmBtn.SetFunction(new Action<int>(this.OnClickedConfirm));
		this.InitRoleSelect();
		string cameraNameByLevelId = DrinksModel.Instance.GetCameraNameByLevelId(this.CurSelectConfig);
		this.CurCameraName = cameraNameByLevelId;
	}

	// Token: 0x06006438 RID: 25656 RVA: 0x0013C72D File Offset: 0x0013A92D
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		DrinksModel.Instance.GetSceneController().HideNpc();
		UiCameraAnimationManager.Instance.DisablePlayerActor();
		this.OnRedDotRefresh();
		this.RefreshRoleSelect(true);
		DrinksModel.Instance.EntityShowOnOpenInviteView();
	}

	// Token: 0x06006439 RID: 25657 RVA: 0x0013C765 File Offset: 0x0013A965
	protected override void OnBeforeHide()
	{
		if (this.IsConfirmHide)
		{
			this.IsConfirmHide = false;
		}
		else
		{
			UiCameraAnimationManager.Instance.EnablePlayerActor();
		}
		this.ResumeTimeDilation();
	}

	// Token: 0x0600643A RID: 25658 RVA: 0x0013C788 File Offset: 0x0013A988
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("DrinksSelectRoleView");
	}

	// Token: 0x0600643B RID: 25659 RVA: 0x0013C799 File Offset: 0x0013A999
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("DrinksSelectRoleView");
	}

	// Token: 0x0600643C RID: 25660 RVA: 0x0013C7AC File Offset: 0x0013A9AC
	protected void InitRoleSelect()
	{
		IEnumerable<DrinksRoleInvite> allInvite = DrinksConfig.Instance.GetAllInvite();
		List<int> list = new List<int>();
		foreach (DrinksRoleInvite drinksRoleInvite in allInvite)
		{
			if (DrinksModel.Instance.CheckLevelIsUnlock(drinksRoleInvite.Id))
			{
				this.CurSelectConfig = drinksRoleInvite.Id;
			}
			list.Add(drinksRoleInvite.Id);
		}
		if (this.CurSelectConfig == -1)
		{
			this.CurSelectConfig = list[0];
		}
		this.RoleLayout.RefreshByData(list, null, true);
	}

	// Token: 0x0600643D RID: 25661 RVA: 0x0013C850 File Offset: 0x0013AA50
	protected void RefreshRoleSelect(bool isInit = false)
	{
		DrinksRoleInvite? inviteConfig = DrinksConfig.Instance.GetInviteConfig(this.CurSelectConfig);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(inviteConfig.Value.RoleId);
		string cameraNameByLevelId = DrinksModel.Instance.GetCameraNameByLevelId(this.CurSelectConfig);
		this.CurCameraName = cameraNameByLevelId;
		if (!isInit)
		{
			this.PushCamera();
		}
		base.GetText(3).ShowTextNew(roleConfig.Value.Name);
		DrinksDrinkMix? drinkMix = DrinksConfig.Instance.GetDrinkMix(inviteConfig.Value.DrinksFavor);
		bool flag = DrinksModel.Instance.CheckLevelIsUnlock(this.CurSelectConfig);
		bool flag2 = false;
		Dictionary<int, IDrinksMixRoleInfo> drinksProgressMap = SpringManorModel.Instance.ActivityData.GetDrinksProgressMap();
		if (flag)
		{
			IDrinksMixRoleInfo drinksMixRoleInfo;
			drinksProgressMap.TryGetValue(inviteConfig.Value.RoleId, out drinksMixRoleInfo);
			flag2 = (drinksMixRoleInfo != null && drinksMixRoleInfo.MaxLike);
			this.UpdatePlayerStorage();
		}
		else
		{
			this.PanelLock.SetTextByTextId(inviteConfig.Value.LockTxt, Array.Empty<string>());
		}
		FColor changeColor = base.GetText(6).changeColor;
		UUIText text = base.GetText(6);
		if (text != null)
		{
			bool bUseChangeColor = flag2;
			FColor? fcolor = new FColor?(changeColor);
			text.SetChangeColor(bUseChangeColor, fcolor);
		}
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(!flag2);
		}
		UUITexture texture = base.GetTexture(9);
		if (texture != null)
		{
			texture.SetUIActive(flag2);
		}
		UUISprite sprite = base.GetSprite(4);
		if (sprite != null)
		{
			sprite.SetUIActive(!flag2);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(flag2);
		}
		UUIButtonComponent button = base.GetButton(16);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag2);
		}
		this.ConfirmBtn.SetUiActive(flag);
		IDrinksMixRoleInfo drinksMixRoleInfo2;
		drinksProgressMap.TryGetValue(inviteConfig.Value.RoleId, out drinksMixRoleInfo2);
		string textId = (drinksMixRoleInfo2 != null) ? "Drinks_Button_Next" : "Drinks_Button_First";
		this.ConfirmBtn.SetLocalTextNew(textId, Array.Empty<object>());
		this.PanelLock.SetUiActive(!flag);
		if (flag2)
		{
			base.SetTextureByPath(drinkMix.Value.Icon, base.GetTexture(9), null, null);
			base.GetText(6).ShowTextNew(drinkMix.Value.Name);
			base.GetText(7).ShowTextNew(inviteConfig.Value.DrinksUnlock);
		}
		else
		{
			base.GetText(6).SetText("???", true);
			base.GetText(7).ShowTextNew(inviteConfig.Value.DrinksLock);
		}
		this.RefreshReward();
	}

	// Token: 0x0600643E RID: 25662 RVA: 0x0013CAFC File Offset: 0x0013ACFC
	private void RefreshReward()
	{
		bool flag = DrinksModel.Instance.CheckLevelIsUnlock(this.CurSelectConfig);
		DrinksRoleInvite? inviteConfig = DrinksConfig.Instance.GetInviteConfig(this.CurSelectConfig);
		bool flag2 = false;
		bool flag3 = false;
		if (flag)
		{
			IDrinksMixRoleInfo drinksMixRoleInfo;
			SpringManorModel.Instance.ActivityData.GetDrinksProgressMap().TryGetValue(inviteConfig.Value.RoleId, out drinksMixRoleInfo);
			flag2 = (drinksMixRoleInfo != null && drinksMixRoleInfo.FirstPass);
			flag3 = (drinksMixRoleInfo != null && drinksMixRoleInfo.RewardGet);
			this.UpdatePlayerStorage();
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(inviteConfig.Value.FirstAward);
		UUISprite sprite = base.GetSprite(12);
		if (sprite != null)
		{
			sprite.SetUIActive(!flag2);
		}
		UUIItem item = base.GetItem(19);
		if (item != null)
		{
			item.SetUIActive(flag2 && !flag3);
		}
		UUIButtonComponent button = base.GetButton(18);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag2 && !flag3);
		}
		UUISprite sprite2 = base.GetSprite(13);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(flag3);
		}
		bool capturedIsReceive = flag3;
		this.RewardScrollView.RefreshByData(dropPackagePreviewItemList, delegate
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.RewardScrollView.GetScrollItemList())
			{
				commonItemSmallItemGrid.SetReceivedVisible(capturedIsReceive);
			}
		}, false);
	}

	// Token: 0x0600643F RID: 25663 RVA: 0x0013CC38 File Offset: 0x0013AE38
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		if (this.CurCameraName != null)
		{
			UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)this.CurCameraName, new int?(viewId), isBlend);
		}
	}

	// Token: 0x06006440 RID: 25664 RVA: 0x0013CC5E File Offset: 0x0013AE5E
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		if (this.CurCameraName != null)
		{
			UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)this.CurCameraName, stackTopInfo, closeViewId, popOrDelete);
		}
	}

	// Token: 0x06006441 RID: 25665 RVA: 0x0013CC84 File Offset: 0x0013AE84
	private void PushCamera()
	{
		if (this.CurCameraName != null)
		{
			UiCameraAnimationManager.Instance.PushCameraHandleByOpenView(this.CurCameraName, null, true, null, null);
		}
	}

	// Token: 0x06006442 RID: 25666 RVA: 0x0013CCC0 File Offset: 0x0013AEC0
	private void UpdatePlayerStorage()
	{
		HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.DrinksUnlockLevelClicked, null);
		bool flag = false;
		if (player == null || !player.Contains(this.CurSelectConfig))
		{
			flag = true;
		}
		if (player != null)
		{
			if (player.Contains(this.CurSelectConfig))
			{
				return;
			}
			player.Add(this.CurSelectConfig);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.DrinksUnlockLevelClicked, player);
		}
		else
		{
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.DrinksUnlockLevelClicked, new HashSet<int>
			{
				this.CurSelectConfig
			});
		}
		if (flag)
		{
			EventSystem.Instance.Emit(EEventName.OnDrinksUnlockClickedNotify);
		}
	}

	// Token: 0x06006443 RID: 25667 RVA: 0x0013CD4B File Offset: 0x0013AF4B
	private void OnToggleStateChange(int id)
	{
		this.CurSelectConfig = id;
		this.RoleLayout.RefreshWithoutDataSync();
		this.RefreshRoleSelect(false);
	}

	// Token: 0x06006444 RID: 25668 RVA: 0x0013CD66 File Offset: 0x0013AF66
	private bool GetToggleStateSelected(int id)
	{
		return this.CurSelectConfig == id;
	}

	// Token: 0x06006445 RID: 25669 RVA: 0x0013CD71 File Offset: 0x0013AF71
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06006446 RID: 25670 RVA: 0x0013CD78 File Offset: 0x0013AF78
	private DrinksRoleSelectItem CreateRoleItem()
	{
		return new DrinksRoleSelectItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			OnToggleStateChangeFunction = new Action<int>(this.OnToggleStateChange)
		};
	}

	// Token: 0x06006447 RID: 25671 RVA: 0x0013CDA3 File Offset: 0x0013AFA3
	private void OnClickedClose()
	{
		DrinksModel.Instance.GetSceneController().ShowNpc();
		DrinksModel.Instance.EntityHideOnCloseInviteView();
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x06006448 RID: 25672 RVA: 0x0013CDCC File Offset: 0x0013AFCC
	private void OnClickedConfirm(int _)
	{
		this.NeedRemove = false;
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.DrinksSelectRoleView, true);
		DrinksRoleInvite? inviteConfig = DrinksConfig.Instance.GetInviteConfig(this.CurSelectConfig);
		EDrinksGameplayOpenWay openWay = (EDrinksGameplayOpenWay)this.OpenParam;
		DrinksController.Instance.SelectRoleAndPlaySeq(inviteConfig.Value.RoleId, openWay, null).ContinueWith(delegate(bool value)
		{
			this.IsConfirmHide = value;
			return value;
		});
	}

	// Token: 0x06006449 RID: 25673 RVA: 0x0013CE48 File Offset: 0x0013B048
	private unsafe void OnClickedWine()
	{
		DrinksRoleInvite? inviteConfig = DrinksConfig.Instance.GetInviteConfig(this.CurSelectConfig);
		int[] mixArrayArray = DrinksConfig.Instance.GetDrinkMix(inviteConfig.Value.DrinksFavor).Value.GetMixArrayArray();
		DrinksSoftDrinkData drinksConfigById = DrinksModel.Instance.GetDrinksConfigById(mixArrayArray[0]);
		DrinksSoftDrinkData drinksConfigById2 = DrinksModel.Instance.GetDrinksConfigById(mixArrayArray[1]);
		DrinksResultInfo drinksResultInfo = new DrinksResultInfo();
		drinksResultInfo.RequireId = 0;
		int num = 2;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int num2 = 0;
		*span[num2] = drinksConfigById.GetMenuBaseId();
		num2++;
		*span[num2] = drinksConfigById2.GetMenuBaseId();
		drinksResultInfo.DrinkBase = list;
		drinksResultInfo.Batching = inviteConfig.Value.GetDrinksFavorBatchingArray();
		drinksResultInfo.Ornament = inviteConfig.Value.DrinksFavorOrnament;
		DrinksResultInfo data = drinksResultInfo;
		DrinksShowInfo param = new DrinksShowInfo
		{
			Data = data,
			RoleId = inviteConfig.Value.RoleId,
			IsGamePlay = false
		};
		UiManager.Instance.OpenView(EUiViewName.DrinksShowView, param, null);
	}

	// Token: 0x0600644A RID: 25674 RVA: 0x0013CF74 File Offset: 0x0013B174
	private void OnClickedReward()
	{
		DrinksRoleInvite? inviteConfig = DrinksConfig.Instance.GetInviteConfig(this.CurSelectConfig);
		DrinksController.Instance.RequestMixDrinkRoleReward(this.CurSelectConfig, inviteConfig.Value.RoleId).ContinueWith(delegate(bool value)
		{
			if (value)
			{
				this.RefreshReward();
			}
		});
	}

	// Token: 0x0600644B RID: 25675 RVA: 0x0013CFC3 File Offset: 0x0013B1C3
	private void OnPlotStart(EUiViewName _, bool __)
	{
		EventSystem.Instance.Remove(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotStart));
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.DrinksSelectRoleView, false);
	}

	// Token: 0x0600644C RID: 25676 RVA: 0x0013CFF8 File Offset: 0x0013B1F8
	private void OnRedDotRefresh()
	{
		IEnumerable<DrinksRoleInvite> allInvite = DrinksConfig.Instance.GetAllInvite();
		List<int> list = new List<int>();
		foreach (DrinksRoleInvite drinksRoleInvite in allInvite)
		{
			list.Add(drinksRoleInvite.Id);
		}
		this.RoleLayout.RefreshByData(list, null, false);
	}

	// Token: 0x04002D7A RID: 11642
	public PopupCaptionItem CaptionItem;

	// Token: 0x04002D7B RID: 11643
	private GenericLayout<DrinksRoleSelectItem, int> RoleLayout;

	// Token: 0x04002D7C RID: 11644
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04002D7D RID: 11645
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04002D7E RID: 11646
	private int CurSelectConfig = -1;

	// Token: 0x04002D7F RID: 11647
	[Nullable(2)]
	private string CurCameraName;

	// Token: 0x04002D80 RID: 11648
	private bool NeedRemove = true;

	// Token: 0x04002D81 RID: 11649
	private ButtonItem ConfirmBtn;

	// Token: 0x04002D82 RID: 11650
	private bool IsConfirmHide;
}
