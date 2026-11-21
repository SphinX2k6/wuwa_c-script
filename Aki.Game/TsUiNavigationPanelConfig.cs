using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Module.UiNavigation.UIComponent;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002220 RID: 8736
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPanelConfig.TsUiNavigationPanelConfig_C")]
public class TsUiNavigationPanelConfig : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x170020AE RID: 8366
	// (get) Token: 0x0601585A RID: 88154 RVA: 0x0063F1B8 File Offset: 0x0063D3B8
	// (set) Token: 0x0601585B RID: 88155 RVA: 0x0063F1CC File Offset: 0x0063D3CC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ViewName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_ViewName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_ViewName)), value);
		}
	}

	// Token: 0x170020AF RID: 8367
	// (get) Token: 0x0601585C RID: 88156 RVA: 0x0063F1E1 File Offset: 0x0063D3E1
	// (set) Token: 0x0601585D RID: 88157 RVA: 0x0063F1F1 File Offset: 0x0063D3F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Independent
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_Independent) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_Independent) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020B0 RID: 8368
	// (get) Token: 0x0601585E RID: 88158 RVA: 0x0063F202 File Offset: 0x0063D402
	// (set) Token: 0x0601585F RID: 88159 RVA: 0x0063F212 File Offset: 0x0063D412
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsChildPanel
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_IsChildPanel) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_IsChildPanel) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020B1 RID: 8369
	// (get) Token: 0x06015860 RID: 88160 RVA: 0x0063F223 File Offset: 0x0063D423
	// (set) Token: 0x06015861 RID: 88161 RVA: 0x0063F233 File Offset: 0x0063D433
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedCacheListener
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_NeedCacheListener) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_NeedCacheListener) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020B2 RID: 8370
	// (get) Token: 0x06015862 RID: 88162 RVA: 0x0063F244 File Offset: 0x0063D444
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<AActor> DefaultNavigationActor
	{
		get
		{
			base.FastCheckIsValid();
			TArray<AActor> result;
			if ((result = this._DefaultNavigationActor) == null)
			{
				result = (this._DefaultNavigationActor = new TArray<AActor>(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_DefaultNavigationActor, this));
			}
			return result;
		}
	}

	// Token: 0x170020B3 RID: 8371
	// (get) Token: 0x06015863 RID: 88163 RVA: 0x0063F280 File Offset: 0x0063D480
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, SNavigationDynamicListenerConfig> DynamicListenerConfigMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, SNavigationDynamicListenerConfig> result;
			if ((result = this._DynamicListenerConfigMap) == null)
			{
				result = (this._DynamicListenerConfigMap = new TMap<string, SNavigationDynamicListenerConfig>(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_DynamicListenerConfigMap, this));
			}
			return result;
		}
	}

	// Token: 0x170020B4 RID: 8372
	// (get) Token: 0x06015864 RID: 88164 RVA: 0x0063F2BC File Offset: 0x0063D4BC
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SNavigationGroup> NormalGroup
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SNavigationGroup> result;
			if ((result = this._NormalGroup) == null)
			{
				result = (this._NormalGroup = new TArray<SNavigationGroup>(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_NormalGroup, this));
			}
			return result;
		}
	}

	// Token: 0x170020B5 RID: 8373
	// (get) Token: 0x06015865 RID: 88165 RVA: 0x0063F2F8 File Offset: 0x0063D4F8
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SNavigationGroup> BookmarkGroup
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SNavigationGroup> result;
			if ((result = this._BookmarkGroup) == null)
			{
				result = (this._BookmarkGroup = new TArray<SNavigationGroup>(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_BookmarkGroup, this));
			}
			return result;
		}
	}

	// Token: 0x170020B6 RID: 8374
	// (get) Token: 0x06015866 RID: 88166 RVA: 0x0063F334 File Offset: 0x0063D534
	// (set) Token: 0x06015867 RID: 88167 RVA: 0x0063F36D File Offset: 0x0063D56D
	[UProperty(EPropertyFlags.CPF_None)]
	public SNavigationGroup ScrollBarGroup
	{
		get
		{
			base.FastCheckIsValid();
			SNavigationGroup result;
			if ((result = this._ScrollBarGroup) == null)
			{
				result = (this._ScrollBarGroup = new SNavigationGroup(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_ScrollBarGroup, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SNavigationGroup.StaticStruct(), base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_ScrollBarGroup, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170020B7 RID: 8375
	// (get) Token: 0x06015868 RID: 88168 RVA: 0x0063F395 File Offset: 0x0063D595
	// (set) Token: 0x06015869 RID: 88169 RVA: 0x0063F3A5 File Offset: 0x0063D5A5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool AllowNavigateInKeyBoard
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_AllowNavigateInKeyBoard) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_AllowNavigateInKeyBoard) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020B8 RID: 8376
	// (get) Token: 0x0601586A RID: 88170 RVA: 0x0063F3B6 File Offset: 0x0063D5B6
	// (set) Token: 0x0601586B RID: 88171 RVA: 0x0063F3C6 File Offset: 0x0063D5C6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool FirstFindFromSubPanelWhenFindNone
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_FirstFindFromSubPanelWhenFindNone) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_FirstFindFromSubPanelWhenFindNone) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020B9 RID: 8377
	// (get) Token: 0x0601586C RID: 88172 RVA: 0x0063F3D7 File Offset: 0x0063D5D7
	// (set) Token: 0x0601586D RID: 88173 RVA: 0x0063F3EB File Offset: 0x0063D5EB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string InteractiveTag
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_InteractiveTag)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationPanelConfig.__PropertyOffset_InteractiveTag)), value);
		}
	}

	// Token: 0x0601586E RID: 88174 RVA: 0x0063F400 File Offset: 0x0063D600
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void AwakeBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationPanelConfig) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AwakeBP"), TsUiNavigationPanelConfig.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AwakeBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601586F RID: 88175 RVA: 0x0063F459 File Offset: 0x0063D659
	protected virtual void AwakeBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.InitDefaultParam();
		this.InitDynamicListenerIndexMap();
		this.InitPanelHandle();
	}

	// Token: 0x06015870 RID: 88176 RVA: 0x0063F478 File Offset: 0x0063D678
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void StartBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationPanelConfig) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StartBP"), TsUiNavigationPanelConfig.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.StartBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015871 RID: 88177 RVA: 0x0063F4D1 File Offset: 0x0063D6D1
	protected virtual void StartBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.NavigationViewCreate();
	}

	// Token: 0x06015872 RID: 88178 RVA: 0x0063F4E4 File Offset: 0x0063D6E4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnEnableBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationPanelConfig) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnEnableBP"), TsUiNavigationPanelConfig.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnEnableBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015873 RID: 88179 RVA: 0x0063F53D File Offset: 0x0063D73D
	protected virtual void OnEnableBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.IsInActive = true;
		this.HandleAddPanel();
		this.HandleUIActivePanel();
		this.HandleChildUIActivePanel();
	}

	// Token: 0x06015874 RID: 88180 RVA: 0x0063F560 File Offset: 0x0063D760
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnDisableBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationPanelConfig) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnDisableBP"), TsUiNavigationPanelConfig.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnDisableBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015875 RID: 88181 RVA: 0x0063F5B9 File Offset: 0x0063D7B9
	protected virtual void OnDisableBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.IsInActive = false;
		this.HandleAddPanel();
		this.HandleUIActivePanel();
		this.HandleChildUIActivePanel();
		if (this.LastFindResultWasWaitingScrollAnimation)
		{
			UiNavigationViewHandle viewHandle = this.ViewHandle;
			if (viewHandle == null)
			{
				return;
			}
			viewHandle.NotifyWaitingScrollPanelHidden();
		}
	}

	// Token: 0x06015876 RID: 88182 RVA: 0x0063F5F4 File Offset: 0x0063D7F4
	private void HandleUIActivePanel()
	{
		if (this.Independent)
		{
			this.HandleViewHandleFunction(delegate
			{
				UiNavigationViewHandle viewHandle = this.ViewHandle;
				if (viewHandle == null)
				{
					return;
				}
				viewHandle.SetIsActive(this.IsInActive);
			});
		}
	}

	// Token: 0x06015877 RID: 88183 RVA: 0x0063F610 File Offset: 0x0063D810
	private void HandleAddPanel()
	{
		if (this.IsInActive)
		{
			UiNavigationViewHandle viewHandle = this.ViewHandle;
			if (viewHandle == null)
			{
				return;
			}
			viewHandle.SetCurrentAddPanel(this);
		}
	}

	// Token: 0x06015878 RID: 88184 RVA: 0x0063F62B File Offset: 0x0063D82B
	private void HandleChildUIActivePanel()
	{
		if (this.IsChildPanel && this.Independent)
		{
			UiNavigationViewHandle viewHandle = this.ViewHandle;
			if (viewHandle == null)
			{
				return;
			}
			viewHandle.SetIsUsable(this.IsInActive);
		}
	}

	// Token: 0x06015879 RID: 88185 RVA: 0x0063F654 File Offset: 0x0063D854
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnPreDestroyBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationPanelConfig) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPreDestroyBP"), TsUiNavigationPanelConfig.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnPreDestroyBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601587A RID: 88186 RVA: 0x0063F6AD File Offset: 0x0063D8AD
	protected virtual void OnPreDestroyBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		SpecialPanelHandleBase panelHandle = this.PanelHandle;
		if (panelHandle != null)
		{
			panelHandle.Clear();
		}
		this.NavigationViewDestroy();
		this.ViewHandle = null;
	}

	// Token: 0x0601587B RID: 88187 RVA: 0x0063F6D5 File Offset: 0x0063D8D5
	private void InitDefaultParam()
	{
		this.HotKeyItemSet = new HashSet<HotKeyItem>();
	}

	// Token: 0x0601587C RID: 88188 RVA: 0x0063F6E4 File Offset: 0x0063D8E4
	private void InitDynamicListenerIndexMap()
	{
		this.DynamicListenerIndexMap = new Dictionary<int, bool>();
		foreach (SNavigationDynamicListenerConfig snavigationDynamicListenerConfig in this.DynamicListenerConfigMap.Values)
		{
			if (snavigationDynamicListenerConfig != null)
			{
				this.DynamicListenerIndexMap[snavigationDynamicListenerConfig.Index] = snavigationDynamicListenerConfig.NeedWaitRegister;
			}
		}
	}

	// Token: 0x0601587D RID: 88189 RVA: 0x0063F764 File Offset: 0x0063D964
	private void NavigationViewCreate()
	{
		this.IncId = ++UiNavigationUtil.IncId;
		EventSystem.Instance.Emit<int, AActor>(EEventName.NavigationViewCreate, this.IncId, base.GetOwner());
	}

	// Token: 0x0601587E RID: 88190 RVA: 0x0063F795 File Offset: 0x0063D995
	private void NavigationViewDestroy()
	{
		EventSystem.Instance.Emit<int, AActor>(EEventName.NavigationViewDestroy, this.IncId, base.GetOwner());
	}

	// Token: 0x0601587F RID: 88191 RVA: 0x0063F7B4 File Offset: 0x0063D9B4
	private Dictionary<string, NavigationGroup> GetGroupMap()
	{
		Dictionary<string, NavigationGroup> dictionary = new Dictionary<string, NavigationGroup>();
		int i = 0;
		int num = this.NormalGroup.Num();
		while (i < num)
		{
			SNavigationGroup snavigationGroup = this.NormalGroup.Get(i);
			snavigationGroup.GroupType = 0;
			NavigationGroup value = new NavigationGroup(snavigationGroup);
			dictionary[snavigationGroup.GroupName] = value;
			i++;
		}
		int j = 0;
		int num2 = this.BookmarkGroup.Num();
		while (j < num2)
		{
			SNavigationGroup snavigationGroup2 = this.BookmarkGroup.Get(j);
			snavigationGroup2.GroupType = 1;
			NavigationGroup value2 = new NavigationGroup(snavigationGroup2);
			dictionary[snavigationGroup2.GroupName] = value2;
			j++;
		}
		if (this.ScrollBarGroup != null)
		{
			this.ScrollBarGroup.GroupType = 2;
			this.TsScrollBarGroup = new NavigationGroup(this.ScrollBarGroup);
			dictionary[this.ScrollBarGroup.GroupName] = this.TsScrollBarGroup;
		}
		return dictionary;
	}

	// Token: 0x06015880 RID: 88192 RVA: 0x0063F89C File Offset: 0x0063DA9C
	private void InitPanelHandle()
	{
		this.PanelHandle = NavigationPanelHandleCreator.GetPanelHandle(this.InteractiveTag);
		if (this.PanelHandle != null)
		{
			this.PanelHandle.Init();
			this.PanelHandle.SetGroupMap(this.GetGroupMap());
			this.PanelHandle.SetDefaultNavigationListenerList(this.DefaultNavigationActor);
		}
	}

	// Token: 0x06015881 RID: 88193 RVA: 0x0063F8EF File Offset: 0x0063DAEF
	private void HandleViewHandleFunction(Action handleFunction)
	{
		if (this.ViewHandle != null)
		{
			handleFunction();
			return;
		}
		if (this.ViewHandleCacheFunctionList == null)
		{
			this.ViewHandleCacheFunctionList = new List<Action>();
		}
		this.ViewHandleCacheFunctionList.Add(handleFunction);
	}

	// Token: 0x06015882 RID: 88194 RVA: 0x0063F920 File Offset: 0x0063DB20
	private void ExecuteViewHandleFunction()
	{
		if (this.ViewHandleCacheFunctionList != null)
		{
			foreach (Action action in this.ViewHandleCacheFunctionList)
			{
				action();
			}
			this.ViewHandleCacheFunctionList = new List<Action>();
		}
	}

	// Token: 0x06015883 RID: 88195 RVA: 0x0063F984 File Offset: 0x0063DB84
	public void RegisterNavigationListener(TsUiNavigationBehaviorListener listener)
	{
		if (this.PanelHandle == null)
		{
			return;
		}
		this.PanelHandle.AddListener(listener);
		listener.GetNavigationComponent().SetPanelHandle(this.PanelHandle);
		listener.GetNavigationComponent().Start();
		if (StringUtils.IsEmpty(listener.GroupName))
		{
			return;
		}
		NavigationGroup navigationGroup = this.PanelHandle.GetNavigationGroup(listener.GroupName);
		if (navigationGroup == null)
		{
			return;
		}
		navigationGroup.AddListener(listener);
		if (navigationGroup.GroupType == 2)
		{
			this.HandleViewHandleFunction(delegate
			{
				UiNavigationViewHandle viewHandle = this.ViewHandle;
				if (viewHandle == null)
				{
					return;
				}
				viewHandle.MarkRefreshScrollDataDirty();
			});
		}
	}

	// Token: 0x06015884 RID: 88196 RVA: 0x0063FA08 File Offset: 0x0063DC08
	public unsafe void DynamicListenerConfigHandle(TsUiNavigationBehaviorListener listener)
	{
		if (this.PanelHandle == null)
		{
			return;
		}
		string dynamicTag = listener.DynamicTag;
		if (StringUtils.IsBlank(dynamicTag))
		{
			return;
		}
		SNavigationDynamicListenerConfig valueOrDefault = this.DynamicListenerConfigMap.GetValueOrDefault(dynamicTag);
		if (valueOrDefault == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "导航监听组件找不到对应的动态配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("导航组名字", listener.GroupName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", this.ViewName);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (valueOrDefault.LayoutActor != null)
		{
			listener.LayoutActor = valueOrDefault.LayoutActor;
		}
		if (valueOrDefault.ScrollActor != null)
		{
			listener.ScrollViewActor = valueOrDefault.ScrollActor;
		}
		if (StringUtils.IsBlank(listener.GroupName))
		{
			return;
		}
		if (this.PanelHandle.GetNavigationGroup(listener.GroupName) == null)
		{
			return;
		}
		this.PanelHandle.ReplaceDefaultNavigationListener(listener, valueOrDefault.Index);
	}

	// Token: 0x06015885 RID: 88197 RVA: 0x0063FB01 File Offset: 0x0063DD01
	public void UnRegisterNavigationListener(TsUiNavigationBehaviorListener listener)
	{
		if (this.PanelHandle == null)
		{
			return;
		}
		this.PanelHandle.TryRemoveListener(listener);
	}

	// Token: 0x06015886 RID: 88198 RVA: 0x0063FB18 File Offset: 0x0063DD18
	[NullableContext(2)]
	public void SetViewHandle(UiNavigationViewHandle viewHandle)
	{
		this.ViewHandle = viewHandle;
		this.ExecuteViewHandleFunction();
	}

	// Token: 0x06015887 RID: 88199 RVA: 0x0063FB27 File Offset: 0x0063DD27
	[return: Nullable(2)]
	public NavigationGroup GetNavigationGroup(string groupName)
	{
		SpecialPanelHandleBase panelHandle = this.PanelHandle;
		if (panelHandle == null)
		{
			return null;
		}
		return panelHandle.GetNavigationGroup(groupName);
	}

	// Token: 0x06015888 RID: 88200 RVA: 0x0063FB3B File Offset: 0x0063DD3B
	[NullableContext(2)]
	public TsUiNavigationBehaviorListener GetFocusListener()
	{
		UiNavigationViewHandle viewHandle = this.ViewHandle;
		if (viewHandle == null)
		{
			return null;
		}
		return viewHandle.GetFocusListener();
	}

	// Token: 0x06015889 RID: 88201 RVA: 0x0063FB4E File Offset: 0x0063DD4E
	public SpecialPanelHandleBase GetPanelHandle()
	{
		return this.PanelHandle;
	}

	// Token: 0x0601588A RID: 88202 RVA: 0x0063FB58 File Offset: 0x0063DD58
	private void CommonFindNavigationLogic(FindNavigationResult result)
	{
		if (!this.IsAllowNavigate())
		{
			result.Result = EFindNavigationResult.CantFocus;
			return;
		}
		UUIItem uuiitem = base.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		if (!uuiitem.IsUIActiveInHierarchy())
		{
			result.Result = EFindNavigationResult.CantFocus;
			return;
		}
		if (this.FindAction != null)
		{
			this.FindAction.FindNavigation(result);
			if (result.IsFinishFind())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "结束导航行为";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动作", this.FindAction.GetType().Name);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.FindAction = null;
			}
			return;
		}
		UiNavigationViewHandle viewHandle = this.ViewHandle;
		if (viewHandle != null && viewHandle.IsWaitToFindDynamicGrid)
		{
			NavigationDynamicScrollViewFindContext dynamicScrollViewNavigationContext = this.ViewHandle.GetDynamicScrollViewNavigationContext();
			UUIDynScrollViewComponent uuidynScrollViewComponent = dynamicScrollViewNavigationContext.ScrollView as UUIDynScrollViewComponent;
			if (!uuidynScrollViewComponent.IsAllDisplayItemUpdateCompleted())
			{
				result.Result = EFindNavigationResult.DynamicScrollViewNotReady;
				return;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationModeModule.FindDynamicScrollViewNavigationComponent(dynamicScrollViewNavigationContext);
			if (tsUiNavigationBehaviorListener != null && tsUiNavigationBehaviorListener.IsCanFocus())
			{
				result.Result = EFindNavigationResult.CanFocus;
				result.Listener = tsUiNavigationBehaviorListener;
				uuidynScrollViewComponent.NavigateScrollToUIItem(tsUiNavigationBehaviorListener.RootUIComp, dynamicScrollViewNavigationContext.Reversed, dynamicScrollViewNavigationContext.WrapMode);
				this.ViewHandle.ClearDynamicScrollViewNavigationContext();
				return;
			}
			TsUiNavigationBehaviorListener lastListener = dynamicScrollViewNavigationContext.LastListener;
			if (lastListener != null && lastListener.IsCanFocus())
			{
				result.Result = EFindNavigationResult.CanFocus;
				result.Listener = dynamicScrollViewNavigationContext.LastListener;
				this.ViewHandle.ClearDynamicScrollViewNavigationContext();
				return;
			}
		}
		result.Result = EFindNavigationResult.None;
	}

	// Token: 0x0601588B RID: 88203 RVA: 0x0063FCC0 File Offset: 0x0063DEC0
	public void CommonFindNavigationByListener(FindNavigationResult result, [Nullable(2)] TsUiNavigationBehaviorListener listener, bool needWaitRegister)
	{
		if (listener == null)
		{
			if (needWaitRegister)
			{
				result.Result = EFindNavigationResult.WaitDynamicListener;
				return;
			}
			result.Result = EFindNavigationResult.None;
			return;
		}
		else
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = listener;
			if (listener.IsScrollOrLayoutActor())
			{
				if (!listener.IsScrollOrLayoutActive())
				{
					result.Result = EFindNavigationResult.None;
					return;
				}
				NavigationGroup navigationGroup = listener.GetNavigationGroup();
				if ((navigationGroup == null || navigationGroup.WaitScrollAnimation) && listener.IsInScrollOrLayoutAnimation())
				{
					result.Result = EFindNavigationResult.LoopOrLayoutAnimation;
					return;
				}
				if (listener.HasDynamicScrollView())
				{
					UiNavigationScrollProxy scrollProxy = listener.ScrollProxy;
					UUIDynScrollViewComponent uuidynScrollViewComponent = ((scrollProxy != null) ? scrollProxy.ScrollView : null) as UUIDynScrollViewComponent;
					if (uuidynScrollViewComponent == null || !uuidynScrollViewComponent.IsAllDisplayItemUpdateCompleted())
					{
						result.Result = EFindNavigationResult.DynamicScrollViewNotReady;
						return;
					}
				}
				SpecialPanelHandleBase panelHandle = this.PanelHandle;
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = (panelHandle != null) ? panelHandle.GetLoopOrLayoutListener(listener) : null;
				if (tsUiNavigationBehaviorListener2 == null)
				{
					result.Result = EFindNavigationResult.None;
					return;
				}
				tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
			}
			else
			{
				NavigationGroup navigationGroup2 = listener.GetNavigationGroup();
				if (navigationGroup2 != null && navigationGroup2.SuitableListenerByNoDynamic)
				{
					SpecialPanelHandleBase panelHandle2 = this.PanelHandle;
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener3 = (panelHandle2 != null) ? panelHandle2.GetSuitableListenerWithoutLayout(listener) : null;
					if (tsUiNavigationBehaviorListener3 != null)
					{
						tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener3;
					}
				}
			}
			if (!tsUiNavigationBehaviorListener.IsCanFocus())
			{
				result.Result = EFindNavigationResult.None;
				return;
			}
			if (!tsUiNavigationBehaviorListener.IsRegisterToPanelConfig())
			{
				result.Result = EFindNavigationResult.WaitRegisterToPanelConfig;
				return;
			}
			result.Result = EFindNavigationResult.CanFocus;
			result.Listener = tsUiNavigationBehaviorListener;
			return;
		}
	}

	// Token: 0x0601588C RID: 88204 RVA: 0x0063FDD8 File Offset: 0x0063DFD8
	public void FindSuitableNavigation(bool isDefault)
	{
		FindNavigationResult findNavigationResult = new FindNavigationResult();
		this.CommonFindNavigationLogic(findNavigationResult);
		if (findNavigationResult.Result == EFindNavigationResult.None)
		{
			SpecialPanelHandleBase panelHandle = this.PanelHandle;
			List<TsUiNavigationBehaviorListener> list = (panelHandle != null) ? panelHandle.GetSuitableNavigationListenerList(isDefault) : null;
			if (list != null)
			{
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					TsUiNavigationBehaviorListener listener = list[i];
					Dictionary<int, bool> dynamicListenerIndexMap = this.DynamicListenerIndexMap;
					bool needWaitRegister = dynamicListenerIndexMap == null || dynamicListenerIndexMap.GetValueOrDefault(i, true);
					this.CommonFindNavigationByListener(findNavigationResult, listener, needWaitRegister);
					if (findNavigationResult.Result != EFindNavigationResult.None)
					{
						break;
					}
					i++;
				}
			}
			if (findNavigationResult.Result == EFindNavigationResult.None)
			{
				findNavigationResult.Result = EFindNavigationResult.CantFocus;
			}
		}
		this.LastFindResultWasWaitingScrollAnimation = TsUiNavigationPanelConfig.IsWaitingScrollAnimationResult(findNavigationResult.Result);
		SpecialPanelHandleBase panelHandle2 = this.PanelHandle;
		if (panelHandle2 != null)
		{
			panelHandle2.NotifyFindResult(findNavigationResult);
		}
		UiNavigationViewHandle viewHandle = this.ViewHandle;
		if (viewHandle == null)
		{
			return;
		}
		viewHandle.NotifySuitableNavigation(findNavigationResult);
	}

	// Token: 0x0601588D RID: 88205 RVA: 0x0063FE99 File Offset: 0x0063E099
	private static bool IsWaitingScrollAnimationResult(EFindNavigationResult value)
	{
		return value == EFindNavigationResult.WaitDynamicListener || value == EFindNavigationResult.LoopOrLayoutAnimation || value == EFindNavigationResult.DynamicScrollViewNotReady || value == EFindNavigationResult.WaitRegisterToPanelConfig;
	}

	// Token: 0x0601588E RID: 88206 RVA: 0x0063FEB0 File Offset: 0x0063E0B0
	public void SetFindNavigationAction(FindActionBase findAction)
	{
		this.FindAction = findAction;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "新增导航行为";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动作", findAction.GetType().Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601588F RID: 88207 RVA: 0x0063FEF8 File Offset: 0x0063E0F8
	private bool CheckReFindCondition()
	{
		if (this.ViewHandle == null)
		{
			return false;
		}
		if (!this.IsInActive && this.Independent)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "[ReFindNavigation]独立界面刚刚隐藏,触发导航对象取消不做通知处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (this.ViewHandle.HasNavigationButDisActive())
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "[ReFindNavigation]界面已经处于HasNavigationButDisActive状态,触发导航对象取消不做通知处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.Independent || this.ViewHandle.GetIsActive();
	}

	// Token: 0x06015890 RID: 88208 RVA: 0x0063FF86 File Offset: 0x0063E186
	public void ReFindNavigation()
	{
		if (!this.CheckReFindCondition())
		{
			return;
		}
		UiNavigationViewHandle viewHandle = this.ViewHandle;
		if (viewHandle == null)
		{
			return;
		}
		viewHandle.MarkRefreshNavigationDirty(0);
	}

	// Token: 0x06015891 RID: 88209 RVA: 0x0063FFA2 File Offset: 0x0063E1A2
	public void ReFindScrollbar()
	{
		if (this.ViewHandle == null)
		{
			return;
		}
		this.ViewHandle.FindNextScrollData();
	}

	// Token: 0x06015892 RID: 88210 RVA: 0x0063FFB8 File Offset: 0x0063E1B8
	public void TryFindScrollbar()
	{
		if (this.ViewHandle == null)
		{
			return;
		}
		this.ViewHandle.TryFindScrollData();
	}

	// Token: 0x06015893 RID: 88211 RVA: 0x0063FFCE File Offset: 0x0063E1CE
	public void FindNavigationInNoneState()
	{
		if (this.ViewHandle == null)
		{
			return;
		}
		if (!this.ViewHandle.IsNonNavigation())
		{
			return;
		}
		this.ViewHandle.MarkResetCurrentPanelDirty();
		this.ViewHandle.MarkRefreshNavigationDirty(0);
	}

	// Token: 0x06015894 RID: 88212 RVA: 0x00640000 File Offset: 0x0063E200
	public bool IsAllowNavigate()
	{
		bool flag = Info.Instance.IsInGamepad();
		return this.AllowNavigateInKeyBoard || flag;
	}

	// Token: 0x06015895 RID: 88213 RVA: 0x00640020 File Offset: 0x0063E220
	public bool CanOverrideFindNavigation(ELGUINavigationDirection direction, TsUiNavigationBehaviorListener lastListener, [Nullable(2)] TsUiNavigationBehaviorListener targetListener)
	{
		return this.PanelHandle != null && this.PanelHandle.CanOverrideFindNavigation(direction, lastListener, targetListener);
	}

	// Token: 0x06015896 RID: 88214 RVA: 0x0064003A File Offset: 0x0063E23A
	[NullableContext(2)]
	public TsUiNavigationBehaviorListener HandleOverrideFindNavigation(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener)
	{
		if (this.PanelHandle == null)
		{
			return null;
		}
		return this.PanelHandle.HandleOverrideFindNavigation(direction, lastListener, targetListener);
	}

	// Token: 0x06015897 RID: 88215 RVA: 0x00640054 File Offset: 0x0063E254
	[NullableContext(2)]
	public TsUiNavigationBehaviorListener HandleAfterFindOpposite(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener, bool isPositive)
	{
		if (this.PanelHandle == null)
		{
			return null;
		}
		return this.PanelHandle.HandleAfterFindOpposite(direction, lastListener, targetListener, isPositive);
	}

	// Token: 0x06015898 RID: 88216 RVA: 0x00640070 File Offset: 0x0063E270
	public void AddHotKeyItem(HotKeyItem hotKeyItem)
	{
		HashSet<HotKeyItem> hotKeyItemSet = this.HotKeyItemSet;
		if (hotKeyItemSet != null)
		{
			hotKeyItemSet.Add(hotKeyItem);
		}
		this.HandleAsyncHotKeyState(hotKeyItem);
	}

	// Token: 0x06015899 RID: 88217 RVA: 0x0064008C File Offset: 0x0063E28C
	private void HandleAsyncHotKeyState(HotKeyItem hotKeyItem)
	{
		foreach (KeyValuePair<HotKeyViewDefine.ELogicMode, bool> keyValuePair in this.GetOrCreateCacheHotKeyStateMap())
		{
			HotKeyViewDefine.ELogicMode key = keyValuePair.Key;
			bool value = keyValuePair.Value;
			foreach (HotKeyComponent hotKeyComponent in hotKeyItem.GetHotKeyComponentArray())
			{
				if (hotKeyComponent != null)
				{
					hotKeyComponent.SetVisibleMode(key, value, false);
				}
				if (this.ViewHandle != null)
				{
					if (hotKeyComponent != null)
					{
						hotKeyComponent.RefreshSelfHotKeyState(this.ViewHandle);
					}
					if (hotKeyComponent != null)
					{
						hotKeyComponent.RefreshSelfHotKeyText(this.ViewHandle);
					}
				}
			}
		}
		if (this.CacheHotKeyComponentCallbackMap != null)
		{
			foreach (Action<HotKeyItem> action in this.CacheHotKeyComponentCallbackMap.Values)
			{
				action(hotKeyItem);
			}
		}
	}

	// Token: 0x0601589A RID: 88218 RVA: 0x006401B4 File Offset: 0x0063E3B4
	private Dictionary<HotKeyViewDefine.ELogicMode, bool> GetOrCreateCacheHotKeyStateMap()
	{
		if (this.CacheHotKeyStateMap == null)
		{
			this.CacheHotKeyStateMap = new Dictionary<HotKeyViewDefine.ELogicMode, bool>();
		}
		return this.CacheHotKeyStateMap;
	}

	// Token: 0x0601589B RID: 88219 RVA: 0x006401CF File Offset: 0x0063E3CF
	public void DeleteKeyItem(HotKeyItem hotKeyItem)
	{
		HashSet<HotKeyItem> hotKeyItemSet = this.HotKeyItemSet;
		if (hotKeyItemSet == null)
		{
			return;
		}
		hotKeyItemSet.Remove(hotKeyItem);
	}

	// Token: 0x0601589C RID: 88220 RVA: 0x006401E4 File Offset: 0x0063E3E4
	public void SetHotKeyVisibleMode(HotKeyViewDefine.ELogicMode mode, bool active)
	{
		this.GetOrCreateCacheHotKeyStateMap()[mode] = active;
		if (this.HotKeyItemSet == null)
		{
			return;
		}
		if (this.HotKeyItemSet != null)
		{
			foreach (HotKeyItem hotKeyItem in this.HotKeyItemSet)
			{
				foreach (HotKeyComponent hotKeyComponent in hotKeyItem.GetHotKeyComponentArray())
				{
					if (hotKeyComponent != null)
					{
						hotKeyComponent.SetVisibleMode(mode, active, false);
					}
				}
			}
		}
	}

	// Token: 0x0601589D RID: 88221 RVA: 0x00640294 File Offset: 0x0063E494
	public void NotifyListenerFocus(TsUiNavigationBehaviorListener listener)
	{
		if (this.ViewHandle == null)
		{
			this.HandleViewHandleFunction(delegate
			{
				this.NotifyListenerFocus(listener);
			});
			return;
		}
		if (!this.ViewHandle.IsListenerCanFocusByPanelConfig)
		{
			return;
		}
		if (!this.IsAllowNavigate())
		{
			return;
		}
		this.ViewHandle.UpdateFocus(listener);
	}

	// Token: 0x0601589E RID: 88222 RVA: 0x006402F8 File Offset: 0x0063E4F8
	public void UpdateHotKeyTextForce(TArray<string> tagArray, string text)
	{
		foreach (HotKeyItem hotKeyItem in this.HotKeyItemSet)
		{
			foreach (HotKeyComponent hotKeyComponent in hotKeyItem.GetHotKeyComponentArray())
			{
				string value = (hotKeyComponent != null) ? hotKeyComponent.GetBindButtonTag() : null;
				if (tagArray.Contains(value) && hotKeyComponent != null)
				{
					hotKeyComponent.SetHotKeyDescTextForce(text);
				}
			}
		}
	}

	// Token: 0x0601589F RID: 88223 RVA: 0x006403A0 File Offset: 0x0063E5A0
	public List<TsUiNavigationBehaviorListener> GetListenerListByTag(string tag)
	{
		SpecialPanelHandleBase panelHandle = this.PanelHandle;
		return ((panelHandle != null) ? panelHandle.GetListenerListByTag(tag) : null) ?? new List<TsUiNavigationBehaviorListener>();
	}

	// Token: 0x060158A0 RID: 88224 RVA: 0x006403C0 File Offset: 0x0063E5C0
	public void RefreshHotKeyComponents()
	{
		if (this.HotKeyItemSet == null)
		{
			return;
		}
		foreach (HotKeyItem hotKeyItem in this.HotKeyItemSet)
		{
			foreach (HotKeyComponent hotKeyComponent in hotKeyItem.GetHotKeyComponentArray())
			{
				if (hotKeyComponent != null)
				{
					hotKeyComponent.RefreshSelfHotKeyState(this.ViewHandle);
				}
				if (hotKeyComponent != null)
				{
					hotKeyComponent.RefreshSelfHotKeyText(this.ViewHandle);
				}
			}
		}
	}

	// Token: 0x060158A1 RID: 88225 RVA: 0x00640470 File Offset: 0x0063E670
	public void RefreshHotKeyTextId()
	{
		if (this.HotKeyItemSet == null)
		{
			return;
		}
		foreach (HotKeyItem hotKeyItem in this.HotKeyItemSet)
		{
			foreach (HotKeyComponent hotKeyComponent in hotKeyItem.GetHotKeyComponentArray())
			{
				if (hotKeyComponent != null)
				{
					hotKeyComponent.RefreshSelfHotKeyText(this.ViewHandle);
				}
			}
		}
	}

	// Token: 0x170020BA RID: 8378
	// (get) Token: 0x060158A2 RID: 88226 RVA: 0x00640510 File Offset: 0x0063E710
	// (set) Token: 0x060158A3 RID: 88227 RVA: 0x00640524 File Offset: 0x0063E724
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor GamepadMouseActor
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationPanelConfig.__PropertyOffset_GamepadMouseActor);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationPanelConfig.__PropertyOffset_GamepadMouseActor, value);
		}
	}

	// Token: 0x170020BB RID: 8379
	// (get) Token: 0x060158A4 RID: 88228 RVA: 0x00640539 File Offset: 0x0063E739
	public bool IsGamepadControlMouse
	{
		get
		{
			return this.Independent && this.GamepadMouseActor != null && this.GamepadMouseActor.IsValid();
		}
	}

	// Token: 0x170020BC RID: 8380
	// (get) Token: 0x060158A5 RID: 88229 RVA: 0x0064055A File Offset: 0x0063E75A
	[Nullable(2)]
	public UUIItem GamepadMouseItem
	{
		[NullableContext(2)]
		get
		{
			if (this.GamepadMouseItemInternal == null)
			{
				AActor gamepadMouseActor = this.GamepadMouseActor;
				this.GamepadMouseItemInternal = (((gamepadMouseActor != null) ? gamepadMouseActor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem);
			}
			return this.GamepadMouseItemInternal;
		}
	}

	// Token: 0x060158A6 RID: 88230 RVA: 0x00640591 File Offset: 0x0063E791
	public void MarkToFindDynamicGrid(NavigationDynamicScrollViewFindContext navigationDynamicScrollViewFindInfo)
	{
		UiNavigationViewHandle viewHandle = this.ViewHandle;
		if (viewHandle != null)
		{
			viewHandle.SetDynamicScrollViewNavigationContext(navigationDynamicScrollViewFindInfo);
		}
		UiNavigationViewHandle viewHandle2 = this.ViewHandle;
		if (viewHandle2 == null)
		{
			return;
		}
		viewHandle2.MarkRefreshNavigationDirty(0);
	}

	// Token: 0x060158A7 RID: 88231 RVA: 0x006405B6 File Offset: 0x0063E7B6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationPanelConfig._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPanelConfig.TsUiNavigationPanelConfig_C");
		}
		return TsUiNavigationPanelConfig._ClassPtr;
	}

	// Token: 0x060158A8 RID: 88232 RVA: 0x006405DC File Offset: 0x0063E7DC
	public TsUiNavigationPanelConfig() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationPanelConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060158A9 RID: 88233 RVA: 0x00640604 File Offset: 0x0063E804
	public TsUiNavigationPanelConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationPanelConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060158AA RID: 88234 RVA: 0x00640637 File Offset: 0x0063E837
	protected TsUiNavigationPanelConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060158AB RID: 88235 RVA: 0x0064064B File Offset: 0x0063E84B
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x060158AC RID: 88236 RVA: 0x00640653 File Offset: 0x0063E853
	protected virtual void __CPPCALL_StartBP_Implementation()
	{
		this.StartBP_Implementation();
	}

	// Token: 0x060158AD RID: 88237 RVA: 0x0064065B File Offset: 0x0063E85B
	protected virtual void __CPPCALL_OnEnableBP_Implementation()
	{
		this.OnEnableBP_Implementation();
	}

	// Token: 0x060158AE RID: 88238 RVA: 0x00640663 File Offset: 0x0063E863
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x060158AF RID: 88239 RVA: 0x0064066B File Offset: 0x0063E86B
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0400B625 RID: 46629
	[Nullable(2)]
	public NavigationGroup TsScrollBarGroup;

	// Token: 0x0400B626 RID: 46630
	[Nullable(2)]
	public UiNavigationViewHandle ViewHandle;

	// Token: 0x0400B627 RID: 46631
	public bool IsInActive;

	// Token: 0x0400B628 RID: 46632
	public bool LastFindResultWasWaitingScrollAnimation;

	// Token: 0x0400B629 RID: 46633
	[Nullable(2)]
	private SpecialPanelHandleBase PanelHandle;

	// Token: 0x0400B62A RID: 46634
	private List<Action> ViewHandleCacheFunctionList = new List<Action>();

	// Token: 0x0400B62B RID: 46635
	private int IncId;

	// Token: 0x0400B62C RID: 46636
	[Nullable(2)]
	private FindActionBase FindAction;

	// Token: 0x0400B62D RID: 46637
	[Nullable(2)]
	private Dictionary<int, bool> DynamicListenerIndexMap;

	// Token: 0x0400B62E RID: 46638
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<HotKeyItem> HotKeyItemSet;

	// Token: 0x0400B62F RID: 46639
	[Nullable(2)]
	private Dictionary<HotKeyViewDefine.ELogicMode, bool> CacheHotKeyStateMap;

	// Token: 0x0400B630 RID: 46640
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<EHotKeyCacheKey, Action<HotKeyItem>> CacheHotKeyComponentCallbackMap;

	// Token: 0x0400B631 RID: 46641
	[Nullable(2)]
	private UUIItem GamepadMouseItemInternal;

	// Token: 0x0400B632 RID: 46642
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPanelConfig.TsUiNavigationPanelConfig_C";

	// Token: 0x0400B633 RID: 46643
	private static IntPtr _ClassPtr;

	// Token: 0x0400B634 RID: 46644
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B635 RID: 46645
	private static int __PropertyOffset_ViewName;

	// Token: 0x0400B636 RID: 46646
	private static int __PropertyOffset_Independent;

	// Token: 0x0400B637 RID: 46647
	private static int __PropertyOffset_IsChildPanel;

	// Token: 0x0400B638 RID: 46648
	private static int __PropertyOffset_NeedCacheListener;

	// Token: 0x0400B639 RID: 46649
	private static int __PropertyOffset_DefaultNavigationActor;

	// Token: 0x0400B63A RID: 46650
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _DefaultNavigationActor;

	// Token: 0x0400B63B RID: 46651
	private static int __PropertyOffset_DynamicListenerConfigMap;

	// Token: 0x0400B63C RID: 46652
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, SNavigationDynamicListenerConfig> _DynamicListenerConfigMap;

	// Token: 0x0400B63D RID: 46653
	private static int __PropertyOffset_NormalGroup;

	// Token: 0x0400B63E RID: 46654
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SNavigationGroup> _NormalGroup;

	// Token: 0x0400B63F RID: 46655
	private static int __PropertyOffset_BookmarkGroup;

	// Token: 0x0400B640 RID: 46656
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SNavigationGroup> _BookmarkGroup;

	// Token: 0x0400B641 RID: 46657
	private static int __PropertyOffset_ScrollBarGroup;

	// Token: 0x0400B642 RID: 46658
	[Nullable(2)]
	private SNavigationGroup _ScrollBarGroup;

	// Token: 0x0400B643 RID: 46659
	private static int __PropertyOffset_AllowNavigateInKeyBoard;

	// Token: 0x0400B644 RID: 46660
	private static int __PropertyOffset_FirstFindFromSubPanelWhenFindNone;

	// Token: 0x0400B645 RID: 46661
	private static int __PropertyOffset_InteractiveTag;

	// Token: 0x0400B646 RID: 46662
	private static int __PropertyOffset_GamepadMouseActor;
}
