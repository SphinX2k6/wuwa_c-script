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
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000403 RID: 1027
[NullableContext(1)]
[Nullable(0)]
public class DrinksSelectRoleView : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x060037CA RID: 14282 RVA: 0x00144C86 File Offset: 0x00142E86
	public DrinksSelectRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060037CB RID: 14283 RVA: 0x00144CA0 File Offset: 0x00142EA0
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

	// Token: 0x060037CC RID: 14284 RVA: 0x00144EB8 File Offset: 0x001430B8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotStart));
		EventSystem.Instance.Add(EEventName.OnDrinksUnlockClickedNotify, new Action(this.OnRedDotRefresh));
		this.NeedRemove = true;
	}

	// Token: 0x060037CD RID: 14285 RVA: 0x00144F04 File Offset: 0x00143104
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnDrinksUnlockClickedNotify, new Action(this.OnRedDotRefresh));
		if (this.NeedRemove)
		{
			EventSystem.Instance.Remove(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotStart));
		}
	}

	// Token: 0x060037CE RID: 14286 RVA: 0x00144F54 File Offset: 0x00143154
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksSelectRoleView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksSelectRoleView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060037CF RID: 14287 RVA: 0x00144F98 File Offset: 0x00143198
	protected override void OnStart()
	{
		this.ConfirmBtn = new ButtonItem(base.GetItem(14));
		this.ConfirmBtn.SetFunction(new Action<int>(this.OnClickedConfirm));
		this.InitRoleSelect();
		string cameraNameByLevelId = DrinksModel.Instance.GetCameraNameByLevelId(this.CurSelectConfig);
		this.CurCameraName = cameraNameByLevelId;
	}

	// Token: 0x060037D0 RID: 14288 RVA: 0x00144FED File Offset: 0x001431ED
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		DrinksModel.Instance.GetSceneController().HideNpc();
		UiCameraModel.Instance.DisablePlayerActor();
		this.OnRedDotRefresh();
		this.RefreshRoleSelect(true);
		DrinksModel.Instance.EntityShowOnOpenInviteView();
	}

	// Token: 0x060037D1 RID: 14289 RVA: 0x00145025 File Offset: 0x00143225
	protected override void OnBeforeHide()
	{
		if (this.IsConfirmHide)
		{
			this.IsConfirmHide = false;
		}
		else
		{
			UiCameraModel.Instance.EnablePlayerActor();
		}
		this.ResumeTimeDilation();
	}

	// Token: 0x060037D2 RID: 14290 RVA: 0x00145048 File Offset: 0x00143248
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("DrinksSelectRoleView");
	}

	// Token: 0x060037D3 RID: 14291 RVA: 0x00145059 File Offset: 0x00143259
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("DrinksSelectRoleView");
	}

	// Token: 0x060037D4 RID: 14292 RVA: 0x0014506C File Offset: 0x0014326C
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

	// Token: 0x060037D5 RID: 14293 RVA: 0x00145110 File Offset: 0x00143310
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

	// Token: 0x060037D6 RID: 14294 RVA: 0x001453BC File Offset: 0x001435BC
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

	// Token: 0x060037D7 RID: 14295 RVA: 0x001454F8 File Offset: 0x001436F8
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		if (this.CurCameraName != null)
		{
			UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)this.CurCameraName, viewId, operationType);
		}
	}

	// Token: 0x060037D8 RID: 14296 RVA: 0x00145519 File Offset: 0x00143719
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		if (this.CurCameraName != null)
		{
			UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)this.CurCameraName, nextViewName, closeViewId, operationType);
		}
	}

	// Token: 0x060037D9 RID: 14297 RVA: 0x0014553C File Offset: 0x0014373C
	private void PushCamera()
	{
		if (this.CurCameraName != null)
		{
			UiCameraModel.Instance.PushCameraHandleByOpenView(this.CurCameraName, base.GetViewId(), EUiCameraHandleOperationType.Blend);
		}
	}

	// Token: 0x060037DA RID: 14298 RVA: 0x00145560 File Offset: 0x00143760
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

	// Token: 0x060037DB RID: 14299 RVA: 0x001455EB File Offset: 0x001437EB
	private void OnToggleStateChange(int id)
	{
		this.CurSelectConfig = id;
		this.RoleLayout.RefreshWithoutDataSync();
		this.RefreshRoleSelect(false);
	}

	// Token: 0x060037DC RID: 14300 RVA: 0x00145606 File Offset: 0x00143806
	private bool GetToggleStateSelected(int id)
	{
		return this.CurSelectConfig == id;
	}

	// Token: 0x060037DD RID: 14301 RVA: 0x00145611 File Offset: 0x00143811
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060037DE RID: 14302 RVA: 0x00145618 File Offset: 0x00143818
	private DrinksRoleSelectItem CreateRoleItem()
	{
		return new DrinksRoleSelectItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			OnToggleStateChangeFunction = new Action<int>(this.OnToggleStateChange)
		};
	}

	// Token: 0x060037DF RID: 14303 RVA: 0x00145643 File Offset: 0x00143843
	private void OnClickedClose()
	{
		DrinksModel.Instance.GetSceneController().ShowNpc();
		DrinksModel.Instance.EntityHideOnCloseInviteView();
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x060037E0 RID: 14304 RVA: 0x0014566C File Offset: 0x0014386C
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

	// Token: 0x060037E1 RID: 14305 RVA: 0x001456E8 File Offset: 0x001438E8
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

	// Token: 0x060037E2 RID: 14306 RVA: 0x00145814 File Offset: 0x00143A14
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

	// Token: 0x060037E3 RID: 14307 RVA: 0x00145863 File Offset: 0x00143A63
	private void OnPlotStart(EUiViewName _, bool __)
	{
		EventSystem.Instance.Remove(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotStart));
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.DrinksSelectRoleView, false);
	}

	// Token: 0x060037E4 RID: 14308 RVA: 0x00145898 File Offset: 0x00143A98
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

	// Token: 0x04002E13 RID: 11795
	public PopupCaptionItem CaptionItem;

	// Token: 0x04002E14 RID: 11796
	private GenericLayout<DrinksRoleSelectItem, int> RoleLayout;

	// Token: 0x04002E15 RID: 11797
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04002E16 RID: 11798
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04002E17 RID: 11799
	private int CurSelectConfig = -1;

	// Token: 0x04002E18 RID: 11800
	[Nullable(2)]
	private string CurCameraName;

	// Token: 0x04002E19 RID: 11801
	private bool NeedRemove = true;

	// Token: 0x04002E1A RID: 11802
	private ButtonItem ConfirmBtn;

	// Token: 0x04002E1B RID: 11803
	private bool IsConfirmHide;
}
