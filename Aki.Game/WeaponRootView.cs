using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002276 RID: 8822
[NullableContext(1)]
[Nullable(0)]
public class WeaponRootView : UiViewBase
{
	// Token: 0x06015D1F RID: 89375 RVA: 0x00653BD7 File Offset: 0x00651DD7
	public WeaponRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015D20 RID: 89376 RVA: 0x00653BFC File Offset: 0x00651DFC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015D21 RID: 89377 RVA: 0x00653C68 File Offset: 0x00651E68
	protected override void OnBeforeCreate()
	{
		IWeaponRootViewParam weaponRootViewParam = this.OpenParam as IWeaponRootViewParam;
		if (weaponRootViewParam == null)
		{
			Log.Instance.Error(ELogModule.Weapon, ELogAuthor.LZK, "进入武器培养界面未传参", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!weaponRootViewParam.IsFromRoleRootView)
		{
			WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
		}
		this.WeaponIncId = weaponRootViewParam.WeaponIncId;
		this.WeaponSkinId = weaponRootViewParam.WeaponSkinId;
		this.WeaponObserver = UiSceneManager.Instance.InitWeaponObserver(false);
		this.WeaponScabbardObserver = UiSceneManager.Instance.InitWeaponScabbardObserver();
	}

	// Token: 0x06015D22 RID: 89378 RVA: 0x00653CF0 File Offset: 0x00651EF0
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponRootView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponRootView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015D23 RID: 89379 RVA: 0x00653D33 File Offset: 0x00651F33
	protected override void OnHandleLoadScene()
	{
		if (this.WeaponObserver == null)
		{
			this.WeaponObserver = UiSceneManager.Instance.InitWeaponObserver(false);
		}
		if (this.WeaponScabbardObserver == null)
		{
			this.WeaponScabbardObserver = UiSceneManager.Instance.InitWeaponScabbardObserver();
		}
	}

	// Token: 0x06015D24 RID: 89380 RVA: 0x00653D68 File Offset: 0x00651F68
	protected override void OnBeforeShow()
	{
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.WeaponRootView, true);
		this.UpdateDynamicTabComponent();
		if (!UiCameraModel.Instance.IsPlayingAnimation())
		{
			if (this.IsFirstShowWeapon)
			{
				WeaponController.Instance.OnSelectedWeaponChange(WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId), this.WeaponObserver, this.WeaponScabbardObserver, this.WeaponSkinId, false);
				this.IsFirstShowWeapon = false;
			}
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.WeaponRootView, false);
		}
	}

	// Token: 0x06015D25 RID: 89381 RVA: 0x00653DED File Offset: 0x00651FED
	protected override void OnAfterShow()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
	}

	// Token: 0x06015D26 RID: 89382 RVA: 0x00653DFA File Offset: 0x00651FFA
	private WeaponTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? _)
	{
		return new WeaponTabItem();
	}

	// Token: 0x06015D27 RID: 89383 RVA: 0x00653E04 File Offset: 0x00652004
	private void ToggleCallBack(int index)
	{
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
		WeaponTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.TabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, this.WeaponIncId, null);
	}

	// Token: 0x06015D28 RID: 89384 RVA: 0x00653E5C File Offset: 0x0065205C
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06015D29 RID: 89385 RVA: 0x00653E94 File Offset: 0x00652094
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeaponCanGoBreach, new Action(this.WeaponCanGoBreachEvent));
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06015D2A RID: 89386 RVA: 0x00653ECE File Offset: 0x006520CE
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeaponCanGoBreach, new Action(this.WeaponCanGoBreachEvent));
		EventSystem.Instance.Remove<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06015D2B RID: 89387 RVA: 0x00653F08 File Offset: 0x00652108
	private void WeaponCanGoBreachEvent()
	{
		this.UpdateDynamicTabComponent();
	}

	// Token: 0x06015D2C RID: 89388 RVA: 0x00653F10 File Offset: 0x00652110
	private void OnCameraFinish(UiCameraHandleData handleData)
	{
		if (handleData.GetViewName() != EUiViewName.WeaponRootView)
		{
			return;
		}
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.WeaponRootView, false);
		if (this.WeaponObserver != null && this.WeaponScabbardObserver != null && this.IsFirstShowWeapon)
		{
			WeaponController.Instance.OnSelectedWeaponChange(WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId), this.WeaponObserver, this.WeaponScabbardObserver, this.WeaponSkinId, false);
			this.IsFirstShowWeapon = false;
		}
	}

	// Token: 0x06015D2D RID: 89389 RVA: 0x00653F96 File Offset: 0x00652196
	protected override void OnBeforePlayCloseSequence()
	{
		this.ReleaseWeaponObserver();
	}

	// Token: 0x06015D2E RID: 89390 RVA: 0x00653F9E File Offset: 0x0065219E
	protected override void OnHandleReleaseScene()
	{
		this.ReleaseWeaponObserver();
	}

	// Token: 0x06015D2F RID: 89391 RVA: 0x00653FA8 File Offset: 0x006521A8
	private void ReleaseWeaponObserver()
	{
		if (this.WeaponObserver != null)
		{
			UiSceneManager.Instance.HideObserver(this.WeaponObserver, "ShowHideWeaponEffect");
			UiSceneManager.Instance.DestroyWeaponObserver(this.WeaponObserver);
			this.WeaponObserver = null;
		}
		if (this.WeaponScabbardObserver != null)
		{
			UiSceneManager.Instance.HideObserver(this.WeaponScabbardObserver, "ShowHideWeaponEffect");
			UiSceneManager.Instance.DestroyWeaponScabbardObserver(this.WeaponScabbardObserver);
			this.WeaponScabbardObserver = null;
		}
		this.IsFirstShowWeapon = true;
	}

	// Token: 0x06015D30 RID: 89392 RVA: 0x00654024 File Offset: 0x00652224
	protected override void OnBeforeDestroy()
	{
		this.ReleaseWeaponObserver();
		this.UnBindRedDot();
		IWeaponRootViewParam weaponRootViewParam = this.OpenParam as IWeaponRootViewParam;
		if (weaponRootViewParam != null && weaponRootViewParam.IsFromRoleRootView && UiSceneManager.Instance.HasRoleSystemRoleActor())
		{
			WeaponController.Instance.RoleFadeOut(UiSceneManager.Instance.GetRoleSystemRoleActor(), "RoleFadeOutCurve");
		}
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		this.TabDataList.Clear();
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
	}

	// Token: 0x06015D31 RID: 89393 RVA: 0x006540B9 File Offset: 0x006522B9
	private void BackClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015D32 RID: 89394 RVA: 0x006540C4 File Offset: 0x006522C4
	protected void UpdateDynamicTabComponent()
	{
		this.TabDataList = this.GetWeaponTabList();
		int lastIndex = this.TabComponent.GetSelectedIndex();
		this.TabComponent.RefreshTabItemByLength(this.TabDataList.Count, delegate
		{
			int index = (lastIndex > 0) ? lastIndex : 0;
			this.TabComponent.SelectToggleByIndex(index, false);
			this.BindRedDot();
		});
	}

	// Token: 0x06015D33 RID: 89395 RVA: 0x00654120 File Offset: 0x00652320
	public List<UiDynamicTab> GetWeaponTabList()
	{
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.WeaponRootView);
		bool flag = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId).CanGoBreach();
		foreach (UiDynamicTab item in viewTabList)
		{
			if ((!(item.ChildViewName == EUiTabViewName.WeaponBreachView) || flag) && (!(item.ChildViewName == EUiTabViewName.WeaponLevelUpView) || !flag))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06015D34 RID: 89396 RVA: 0x006541D4 File Offset: 0x006523D4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 1)
		{
			if (this.TabComponent == null)
			{
				return null;
			}
			if (this.TabComponent.GetTabComponent().GetLayout() == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.JT;
				string message = "角色界面聚焦引导的额外参数配置有误, 找不到Layout";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int tabId = int.Parse(configParams[0]);
			UUIItem rootItem = this.TabComponent.GetTabItemByIndex(this.TabDataList.FindIndex((UiDynamicTab data) => data.Id == tabId)).GetRootItem();
			if (rootItem != null)
			{
				return new UUIItem[]
				{
					rootItem,
					rootItem
				};
			}
		}
		return null;
	}

	// Token: 0x06015D35 RID: 89397 RVA: 0x00654280 File Offset: 0x00652480
	private void BindRedDot()
	{
		int num = this.TabDataList.FindIndex((UiDynamicTab config) => config.ChildViewName == EUiTabViewName.WeaponResonanceView);
		if (num >= 0)
		{
			WeaponTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(num);
			if (tabItemByIndex != null)
			{
				tabItemByIndex.BindRedDot(ERedDotName.RedDotWeaponResonanceTab, new int?(this.WeaponIncId));
			}
		}
	}

	// Token: 0x06015D36 RID: 89398 RVA: 0x006542E4 File Offset: 0x006524E4
	private void UnBindRedDot()
	{
		int num = this.TabDataList.FindIndex((UiDynamicTab config) => config.ChildViewName == EUiTabViewName.WeaponResonanceView);
		if (num >= 0)
		{
			WeaponTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(num);
			if (tabItemByIndex != null)
			{
				tabItemByIndex.UnBindRedDot();
				RedDotController.Instance.UnBindRedDotAndClearData(ERedDotName.RedDotWeaponResonanceTab);
			}
		}
	}

	// Token: 0x0400B7B8 RID: 47032
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x0400B7B9 RID: 47033
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<WeaponTabItem> TabComponent;

	// Token: 0x0400B7BA RID: 47034
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x0400B7BB RID: 47035
	private bool IsFirstShowWeapon = true;

	// Token: 0x0400B7BC RID: 47036
	private int WeaponIncId;

	// Token: 0x0400B7BD RID: 47037
	private int WeaponSkinId = -1;

	// Token: 0x0400B7BE RID: 47038
	[Nullable(2)]
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B7BF RID: 47039
	[Nullable(2)]
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x020084D4 RID: 34004
	[NullableContext(0)]
	private enum EWeaponRootViewDefine
	{
		// Token: 0x0402AD3B RID: 175419
		CaptionList,
		// Token: 0x0402AD3C RID: 175420
		ViewItem
	}
}
