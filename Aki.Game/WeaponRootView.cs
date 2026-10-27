using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D1C RID: 11548
[NullableContext(1)]
[Nullable(0)]
public class WeaponRootView : UiViewBase
{
	// Token: 0x0601847E RID: 99454 RVA: 0x0062DBE3 File Offset: 0x0062BDE3
	public WeaponRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601847F RID: 99455 RVA: 0x0062DC08 File Offset: 0x0062BE08
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

	// Token: 0x06018480 RID: 99456 RVA: 0x0062DC74 File Offset: 0x0062BE74
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

	// Token: 0x06018481 RID: 99457 RVA: 0x0062DCFC File Offset: 0x0062BEFC
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponRootView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponRootView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018482 RID: 99458 RVA: 0x0062DD3F File Offset: 0x0062BF3F
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

	// Token: 0x06018483 RID: 99459 RVA: 0x0062DD74 File Offset: 0x0062BF74
	protected override void OnBeforeShow()
	{
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.WeaponRootView, true);
		this.UpdateDynamicTabComponent();
		if (!UiCameraAnimationManager.Instance.IsPlayingAnimation())
		{
			if (this.IsFirstShowWeapon)
			{
				WeaponController.Instance.OnSelectedWeaponChange(WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId), this.WeaponObserver, this.WeaponScabbardObserver, this.WeaponSkinId, false);
				this.IsFirstShowWeapon = false;
			}
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.WeaponRootView, false);
		}
	}

	// Token: 0x06018484 RID: 99460 RVA: 0x0062DDF9 File Offset: 0x0062BFF9
	protected override void OnAfterShow()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
	}

	// Token: 0x06018485 RID: 99461 RVA: 0x0062DE06 File Offset: 0x0062C006
	private WeaponTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? _)
	{
		return new WeaponTabItem();
	}

	// Token: 0x06018486 RID: 99462 RVA: 0x0062DE10 File Offset: 0x0062C010
	private void ToggleCallBack(int index)
	{
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
		WeaponTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.TabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, this.WeaponIncId, null);
	}

	// Token: 0x06018487 RID: 99463 RVA: 0x0062DE68 File Offset: 0x0062C068
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06018488 RID: 99464 RVA: 0x0062DEA0 File Offset: 0x0062C0A0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeaponCanGoBreach, new Action(this.WeaponCanGoBreachEvent));
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06018489 RID: 99465 RVA: 0x0062DEDA File Offset: 0x0062C0DA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeaponCanGoBreach, new Action(this.WeaponCanGoBreachEvent));
		EventSystem.Instance.Remove<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x0601848A RID: 99466 RVA: 0x0062DF14 File Offset: 0x0062C114
	private void WeaponCanGoBreachEvent()
	{
		this.UpdateDynamicTabComponent();
	}

	// Token: 0x0601848B RID: 99467 RVA: 0x0062DF1C File Offset: 0x0062C11C
	private void OnCameraFinish(UiCameraHandleData handleData)
	{
		if (handleData.ViewName != EUiViewName.WeaponRootView)
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

	// Token: 0x0601848C RID: 99468 RVA: 0x0062DFA2 File Offset: 0x0062C1A2
	protected override void OnBeforePlayCloseSequence()
	{
		this.ReleaseWeaponObserver();
	}

	// Token: 0x0601848D RID: 99469 RVA: 0x0062DFAA File Offset: 0x0062C1AA
	protected override void OnHandleReleaseScene()
	{
		this.ReleaseWeaponObserver();
	}

	// Token: 0x0601848E RID: 99470 RVA: 0x0062DFB4 File Offset: 0x0062C1B4
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

	// Token: 0x0601848F RID: 99471 RVA: 0x0062E030 File Offset: 0x0062C230
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

	// Token: 0x06018490 RID: 99472 RVA: 0x0062E0C5 File Offset: 0x0062C2C5
	private void BackClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06018491 RID: 99473 RVA: 0x0062E0D0 File Offset: 0x0062C2D0
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

	// Token: 0x06018492 RID: 99474 RVA: 0x0062E12C File Offset: 0x0062C32C
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

	// Token: 0x06018493 RID: 99475 RVA: 0x0062E1E0 File Offset: 0x0062C3E0
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

	// Token: 0x06018494 RID: 99476 RVA: 0x0062E28C File Offset: 0x0062C48C
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

	// Token: 0x06018495 RID: 99477 RVA: 0x0062E2F0 File Offset: 0x0062C4F0
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

	// Token: 0x0400B443 RID: 46147
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x0400B444 RID: 46148
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<WeaponTabItem> TabComponent;

	// Token: 0x0400B445 RID: 46149
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x0400B446 RID: 46150
	private bool IsFirstShowWeapon = true;

	// Token: 0x0400B447 RID: 46151
	private int WeaponIncId;

	// Token: 0x0400B448 RID: 46152
	private int WeaponSkinId = -1;

	// Token: 0x0400B449 RID: 46153
	[Nullable(2)]
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B44A RID: 46154
	[Nullable(2)]
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x020092AC RID: 37548
	[NullableContext(0)]
	private enum EWeaponRootViewDefine
	{
		// Token: 0x0402F6B1 RID: 194225
		CaptionList,
		// Token: 0x0402F6B2 RID: 194226
		ViewItem
	}
}
