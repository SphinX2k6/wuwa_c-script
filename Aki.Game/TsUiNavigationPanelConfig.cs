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

// Token: 0x02002CC7 RID: 11463
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPanelConfig.TsUiNavigationPanelConfig_C")]
public class TsUiNavigationPanelConfig : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700205D RID: 8285
	// (get) Token: 0x06017FE1 RID: 98273 RVA: 0x00619538 File Offset: 0x00617738
	// (set) Token: 0x06017FE2 RID: 98274 RVA: 0x0061954C File Offset: 0x0061774C
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

	// Token: 0x1700205E RID: 8286
	// (get) Token: 0x06017FE3 RID: 98275 RVA: 0x00619561 File Offset: 0x00617761
	// (set) Token: 0x06017FE4 RID: 98276 RVA: 0x00619571 File Offset: 0x00617771
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

	// Token: 0x1700205F RID: 8287
	// (get) Token: 0x06017FE5 RID: 98277 RVA: 0x00619582 File Offset: 0x00617782
	// (set) Token: 0x06017FE6 RID: 98278 RVA: 0x00619592 File Offset: 0x00617792
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

	// Token: 0x17002060 RID: 8288
	// (get) Token: 0x06017FE7 RID: 98279 RVA: 0x006195A3 File Offset: 0x006177A3
	// (set) Token: 0x06017FE8 RID: 98280 RVA: 0x006195B3 File Offset: 0x006177B3
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

	// Token: 0x17002061 RID: 8289
	// (get) Token: 0x06017FE9 RID: 98281 RVA: 0x006195C4 File Offset: 0x006177C4
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

	// Token: 0x17002062 RID: 8290
	// (get) Token: 0x06017FEA RID: 98282 RVA: 0x00619600 File Offset: 0x00617800
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

	// Token: 0x17002063 RID: 8291
	// (get) Token: 0x06017FEB RID: 98283 RVA: 0x0061963C File Offset: 0x0061783C
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

	// Token: 0x17002064 RID: 8292
	// (get) Token: 0x06017FEC RID: 98284 RVA: 0x00619678 File Offset: 0x00617878
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

	// Token: 0x17002065 RID: 8293
	// (get) Token: 0x06017FED RID: 98285 RVA: 0x006196B4 File Offset: 0x006178B4
	// (set) Token: 0x06017FEE RID: 98286 RVA: 0x006196ED File Offset: 0x006178ED
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

	// Token: 0x17002066 RID: 8294
	// (get) Token: 0x06017FEF RID: 98287 RVA: 0x00619715 File Offset: 0x00617915
	// (set) Token: 0x06017FF0 RID: 98288 RVA: 0x00619725 File Offset: 0x00617925
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

	// Token: 0x17002067 RID: 8295
	// (get) Token: 0x06017FF1 RID: 98289 RVA: 0x00619736 File Offset: 0x00617936
	// (set) Token: 0x06017FF2 RID: 98290 RVA: 0x00619746 File Offset: 0x00617946
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

	// Token: 0x17002068 RID: 8296
	// (get) Token: 0x06017FF3 RID: 98291 RVA: 0x00619757 File Offset: 0x00617957
	// (set) Token: 0x06017FF4 RID: 98292 RVA: 0x0061976B File Offset: 0x0061796B
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

	// Token: 0x06017FF5 RID: 98293 RVA: 0x00619780 File Offset: 0x00617980
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void AwakeBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AwakeBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017FF6 RID: 98294 RVA: 0x006197F0 File Offset: 0x006179F0
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

	// Token: 0x06017FF7 RID: 98295 RVA: 0x0061980C File Offset: 0x00617A0C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void StartBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StartBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017FF8 RID: 98296 RVA: 0x0061987C File Offset: 0x00617A7C
	protected virtual void StartBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.NavigationViewCreate();
	}

	// Token: 0x06017FF9 RID: 98297 RVA: 0x0061988C File Offset: 0x00617A8C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnEnableBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnEnableBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017FFA RID: 98298 RVA: 0x006198FC File Offset: 0x00617AFC
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

	// Token: 0x06017FFB RID: 98299 RVA: 0x00619920 File Offset: 0x00617B20
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnDisableBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnDisableBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017FFC RID: 98300 RVA: 0x00619990 File Offset: 0x00617B90
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

	// Token: 0x06017FFD RID: 98301 RVA: 0x006199CB File Offset: 0x00617BCB
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

	// Token: 0x06017FFE RID: 98302 RVA: 0x006199E7 File Offset: 0x00617BE7
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

	// Token: 0x06017FFF RID: 98303 RVA: 0x00619A02 File Offset: 0x00617C02
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

	// Token: 0x06018000 RID: 98304 RVA: 0x00619A2C File Offset: 0x00617C2C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnPreDestroyBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPreDestroyBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06018001 RID: 98305 RVA: 0x00619A9C File Offset: 0x00617C9C
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

	// Token: 0x06018002 RID: 98306 RVA: 0x00619AC4 File Offset: 0x00617CC4
	private void InitDefaultParam()
	{
		this.HotKeyItemSet = new HashSet<HotKeyItem>();
	}

	// Token: 0x06018003 RID: 98307 RVA: 0x00619AD4 File Offset: 0x00617CD4
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

	// Token: 0x06018004 RID: 98308 RVA: 0x00619B54 File Offset: 0x00617D54
	private void NavigationViewCreate()
	{
		this.IncId = ++UiNavigationUtil.IncId;
		EventSystem.Instance.Emit<int, AActor>(EEventName.NavigationViewCreate, this.IncId, base.GetOwner());
	}

	// Token: 0x06018005 RID: 98309 RVA: 0x00619B85 File Offset: 0x00617D85
	private void NavigationViewDestroy()
	{
		EventSystem.Instance.Emit<int, AActor>(EEventName.NavigationViewDestroy, this.IncId, base.GetOwner());
	}

	// Token: 0x06018006 RID: 98310 RVA: 0x00619BA4 File Offset: 0x00617DA4
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

	// Token: 0x06018007 RID: 98311 RVA: 0x00619C8C File Offset: 0x00617E8C
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

	// Token: 0x06018008 RID: 98312 RVA: 0x00619CDF File Offset: 0x00617EDF
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

	// Token: 0x06018009 RID: 98313 RVA: 0x00619D10 File Offset: 0x00617F10
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

	// Token: 0x0601800A RID: 98314 RVA: 0x00619D74 File Offset: 0x00617F74
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

	// Token: 0x0601800B RID: 98315 RVA: 0x00619DF8 File Offset: 0x00617FF8
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

	// Token: 0x0601800C RID: 98316 RVA: 0x00619EF1 File Offset: 0x006180F1
	public void UnRegisterNavigationListener(TsUiNavigationBehaviorListener listener)
	{
		if (this.PanelHandle == null)
		{
			return;
		}
		this.PanelHandle.TryRemoveListener(listener);
	}

	// Token: 0x0601800D RID: 98317 RVA: 0x00619F08 File Offset: 0x00618108
	[NullableContext(2)]
	public void SetViewHandle(UiNavigationViewHandle viewHandle)
	{
		this.ViewHandle = viewHandle;
		this.ExecuteViewHandleFunction();
	}

	// Token: 0x0601800E RID: 98318 RVA: 0x00619F17 File Offset: 0x00618117
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

	// Token: 0x0601800F RID: 98319 RVA: 0x00619F2B File Offset: 0x0061812B
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

	// Token: 0x06018010 RID: 98320 RVA: 0x00619F3E File Offset: 0x0061813E
	public SpecialPanelHandleBase GetPanelHandle()
	{
		return this.PanelHandle;
	}

	// Token: 0x06018011 RID: 98321 RVA: 0x00619F48 File Offset: 0x00618148
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

	// Token: 0x06018012 RID: 98322 RVA: 0x0061A0B0 File Offset: 0x006182B0
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

	// Token: 0x06018013 RID: 98323 RVA: 0x0061A1C8 File Offset: 0x006183C8
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

	// Token: 0x06018014 RID: 98324 RVA: 0x0061A289 File Offset: 0x00618489
	private static bool IsWaitingScrollAnimationResult(EFindNavigationResult value)
	{
		return value == EFindNavigationResult.WaitDynamicListener || value == EFindNavigationResult.LoopOrLayoutAnimation || value == EFindNavigationResult.DynamicScrollViewNotReady || value == EFindNavigationResult.WaitRegisterToPanelConfig;
	}

	// Token: 0x06018015 RID: 98325 RVA: 0x0061A2A0 File Offset: 0x006184A0
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

	// Token: 0x06018016 RID: 98326 RVA: 0x0061A2E8 File Offset: 0x006184E8
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

	// Token: 0x06018017 RID: 98327 RVA: 0x0061A376 File Offset: 0x00618576
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

	// Token: 0x06018018 RID: 98328 RVA: 0x0061A392 File Offset: 0x00618592
	public void ReFindScrollbar()
	{
		if (this.ViewHandle == null)
		{
			return;
		}
		this.ViewHandle.FindNextScrollData();
	}

	// Token: 0x06018019 RID: 98329 RVA: 0x0061A3A8 File Offset: 0x006185A8
	public void TryFindScrollbar()
	{
		if (this.ViewHandle == null)
		{
			return;
		}
		this.ViewHandle.TryFindScrollData();
	}

	// Token: 0x0601801A RID: 98330 RVA: 0x0061A3BE File Offset: 0x006185BE
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

	// Token: 0x0601801B RID: 98331 RVA: 0x0061A3F0 File Offset: 0x006185F0
	public bool IsAllowNavigate()
	{
		bool flag = Info.Instance.IsInGamepad();
		return this.AllowNavigateInKeyBoard || flag;
	}

	// Token: 0x0601801C RID: 98332 RVA: 0x0061A410 File Offset: 0x00618610
	public bool CanOverrideFindNavigation(ELGUINavigationDirection direction, TsUiNavigationBehaviorListener lastListener, [Nullable(2)] TsUiNavigationBehaviorListener targetListener)
	{
		return this.PanelHandle != null && this.PanelHandle.CanOverrideFindNavigation(direction, lastListener, targetListener);
	}

	// Token: 0x0601801D RID: 98333 RVA: 0x0061A42A File Offset: 0x0061862A
	[NullableContext(2)]
	public TsUiNavigationBehaviorListener HandleOverrideFindNavigation(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener)
	{
		if (this.PanelHandle == null)
		{
			return null;
		}
		return this.PanelHandle.HandleOverrideFindNavigation(direction, lastListener, targetListener);
	}

	// Token: 0x0601801E RID: 98334 RVA: 0x0061A444 File Offset: 0x00618644
	[NullableContext(2)]
	public TsUiNavigationBehaviorListener HandleAfterFindOpposite(ELGUINavigationDirection direction, [Nullable(1)] TsUiNavigationBehaviorListener lastListener, TsUiNavigationBehaviorListener targetListener, bool isPositive)
	{
		if (this.PanelHandle == null)
		{
			return null;
		}
		return this.PanelHandle.HandleAfterFindOpposite(direction, lastListener, targetListener, isPositive);
	}

	// Token: 0x0601801F RID: 98335 RVA: 0x0061A460 File Offset: 0x00618660
	public void AddHotKeyItem(HotKeyItem hotKeyItem)
	{
		HashSet<HotKeyItem> hotKeyItemSet = this.HotKeyItemSet;
		if (hotKeyItemSet != null)
		{
			hotKeyItemSet.Add(hotKeyItem);
		}
		this.HandleAsyncHotKeyState(hotKeyItem);
	}

	// Token: 0x06018020 RID: 98336 RVA: 0x0061A47C File Offset: 0x0061867C
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

	// Token: 0x06018021 RID: 98337 RVA: 0x0061A5A4 File Offset: 0x006187A4
	private Dictionary<HotKeyViewDefine.ELogicMode, bool> GetOrCreateCacheHotKeyStateMap()
	{
		if (this.CacheHotKeyStateMap == null)
		{
			this.CacheHotKeyStateMap = new Dictionary<HotKeyViewDefine.ELogicMode, bool>();
		}
		return this.CacheHotKeyStateMap;
	}

	// Token: 0x06018022 RID: 98338 RVA: 0x0061A5BF File Offset: 0x006187BF
	public void DeleteKeyItem(HotKeyItem hotKeyItem)
	{
		HashSet<HotKeyItem> hotKeyItemSet = this.HotKeyItemSet;
		if (hotKeyItemSet == null)
		{
			return;
		}
		hotKeyItemSet.Remove(hotKeyItem);
	}

	// Token: 0x06018023 RID: 98339 RVA: 0x0061A5D4 File Offset: 0x006187D4
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

	// Token: 0x06018024 RID: 98340 RVA: 0x0061A684 File Offset: 0x00618884
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

	// Token: 0x06018025 RID: 98341 RVA: 0x0061A6E8 File Offset: 0x006188E8
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

	// Token: 0x06018026 RID: 98342 RVA: 0x0061A790 File Offset: 0x00618990
	public List<TsUiNavigationBehaviorListener> GetListenerListByTag(string tag)
	{
		SpecialPanelHandleBase panelHandle = this.PanelHandle;
		return ((panelHandle != null) ? panelHandle.GetListenerListByTag(tag) : null) ?? new List<TsUiNavigationBehaviorListener>();
	}

	// Token: 0x06018027 RID: 98343 RVA: 0x0061A7B0 File Offset: 0x006189B0
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

	// Token: 0x06018028 RID: 98344 RVA: 0x0061A860 File Offset: 0x00618A60
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

	// Token: 0x17002069 RID: 8297
	// (get) Token: 0x06018029 RID: 98345 RVA: 0x0061A900 File Offset: 0x00618B00
	// (set) Token: 0x0601802A RID: 98346 RVA: 0x0061A914 File Offset: 0x00618B14
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

	// Token: 0x1700206A RID: 8298
	// (get) Token: 0x0601802B RID: 98347 RVA: 0x0061A929 File Offset: 0x00618B29
	public bool IsGamepadControlMouse
	{
		get
		{
			return this.Independent && this.GamepadMouseActor != null && this.GamepadMouseActor.IsValid();
		}
	}

	// Token: 0x1700206B RID: 8299
	// (get) Token: 0x0601802C RID: 98348 RVA: 0x0061A94A File Offset: 0x00618B4A
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

	// Token: 0x0601802D RID: 98349 RVA: 0x0061A981 File Offset: 0x00618B81
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

	// Token: 0x0601802E RID: 98350 RVA: 0x0061A9A6 File Offset: 0x00618BA6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationPanelConfig._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPanelConfig.TsUiNavigationPanelConfig_C");
		}
		return TsUiNavigationPanelConfig._ClassPtr;
	}

	// Token: 0x0601802F RID: 98351 RVA: 0x0061A9CC File Offset: 0x00618BCC
	public TsUiNavigationPanelConfig() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationPanelConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018030 RID: 98352 RVA: 0x0061A9F4 File Offset: 0x00618BF4
	public TsUiNavigationPanelConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationPanelConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018031 RID: 98353 RVA: 0x0061AA27 File Offset: 0x00618C27
	protected TsUiNavigationPanelConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06018032 RID: 98354 RVA: 0x0061AA3B File Offset: 0x00618C3B
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x06018033 RID: 98355 RVA: 0x0061AA43 File Offset: 0x00618C43
	protected virtual void __CPPCALL_StartBP_Implementation()
	{
		this.StartBP_Implementation();
	}

	// Token: 0x06018034 RID: 98356 RVA: 0x0061AA4B File Offset: 0x00618C4B
	protected virtual void __CPPCALL_OnEnableBP_Implementation()
	{
		this.OnEnableBP_Implementation();
	}

	// Token: 0x06018035 RID: 98357 RVA: 0x0061AA53 File Offset: 0x00618C53
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x06018036 RID: 98358 RVA: 0x0061AA5B File Offset: 0x00618C5B
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0400B2BA RID: 45754
	[Nullable(2)]
	public NavigationGroup TsScrollBarGroup;

	// Token: 0x0400B2BB RID: 45755
	[Nullable(2)]
	public UiNavigationViewHandle ViewHandle;

	// Token: 0x0400B2BC RID: 45756
	public bool IsInActive;

	// Token: 0x0400B2BD RID: 45757
	public bool LastFindResultWasWaitingScrollAnimation;

	// Token: 0x0400B2BE RID: 45758
	[Nullable(2)]
	private SpecialPanelHandleBase PanelHandle;

	// Token: 0x0400B2BF RID: 45759
	private List<Action> ViewHandleCacheFunctionList = new List<Action>();

	// Token: 0x0400B2C0 RID: 45760
	private int IncId;

	// Token: 0x0400B2C1 RID: 45761
	[Nullable(2)]
	private FindActionBase FindAction;

	// Token: 0x0400B2C2 RID: 45762
	[Nullable(2)]
	private Dictionary<int, bool> DynamicListenerIndexMap;

	// Token: 0x0400B2C3 RID: 45763
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<HotKeyItem> HotKeyItemSet;

	// Token: 0x0400B2C4 RID: 45764
	[Nullable(2)]
	private Dictionary<HotKeyViewDefine.ELogicMode, bool> CacheHotKeyStateMap;

	// Token: 0x0400B2C5 RID: 45765
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Dictionary<EHotKeyCacheKey, Action<HotKeyItem>> CacheHotKeyComponentCallbackMap;

	// Token: 0x0400B2C6 RID: 45766
	[Nullable(2)]
	private UUIItem GamepadMouseItemInternal;

	// Token: 0x0400B2C7 RID: 45767
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationPanelConfig.TsUiNavigationPanelConfig_C";

	// Token: 0x0400B2C8 RID: 45768
	private static IntPtr _ClassPtr;

	// Token: 0x0400B2C9 RID: 45769
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B2CA RID: 45770
	private static int __PropertyOffset_ViewName;

	// Token: 0x0400B2CB RID: 45771
	private static int __PropertyOffset_Independent;

	// Token: 0x0400B2CC RID: 45772
	private static int __PropertyOffset_IsChildPanel;

	// Token: 0x0400B2CD RID: 45773
	private static int __PropertyOffset_NeedCacheListener;

	// Token: 0x0400B2CE RID: 45774
	private static int __PropertyOffset_DefaultNavigationActor;

	// Token: 0x0400B2CF RID: 45775
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _DefaultNavigationActor;

	// Token: 0x0400B2D0 RID: 45776
	private static int __PropertyOffset_DynamicListenerConfigMap;

	// Token: 0x0400B2D1 RID: 45777
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, SNavigationDynamicListenerConfig> _DynamicListenerConfigMap;

	// Token: 0x0400B2D2 RID: 45778
	private static int __PropertyOffset_NormalGroup;

	// Token: 0x0400B2D3 RID: 45779
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SNavigationGroup> _NormalGroup;

	// Token: 0x0400B2D4 RID: 45780
	private static int __PropertyOffset_BookmarkGroup;

	// Token: 0x0400B2D5 RID: 45781
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SNavigationGroup> _BookmarkGroup;

	// Token: 0x0400B2D6 RID: 45782
	private static int __PropertyOffset_ScrollBarGroup;

	// Token: 0x0400B2D7 RID: 45783
	[Nullable(2)]
	private SNavigationGroup _ScrollBarGroup;

	// Token: 0x0400B2D8 RID: 45784
	private static int __PropertyOffset_AllowNavigateInKeyBoard;

	// Token: 0x0400B2D9 RID: 45785
	private static int __PropertyOffset_FirstFindFromSubPanelWhenFindNone;

	// Token: 0x0400B2DA RID: 45786
	private static int __PropertyOffset_InteractiveTag;

	// Token: 0x0400B2DB RID: 45787
	private static int __PropertyOffset_GamepadMouseActor;
}
