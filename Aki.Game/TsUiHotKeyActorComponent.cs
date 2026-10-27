using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002CCD RID: 11469
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyActorComponent.TsUiHotKeyActorComponent_C")]
public class TsUiHotKeyActorComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700206E RID: 8302
	// (get) Token: 0x060180CB RID: 98507 RVA: 0x0061DB70 File Offset: 0x0061BD70
	// (set) Token: 0x060180CC RID: 98508 RVA: 0x0061DB84 File Offset: 0x0061BD84
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Mode
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsUiHotKeyActorComponent.__PropertyOffset_Mode)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsUiHotKeyActorComponent.__PropertyOffset_Mode)), value);
		}
	}

	// Token: 0x1700206F RID: 8303
	// (get) Token: 0x060180CD RID: 98509 RVA: 0x0061DB99 File Offset: 0x0061BD99
	// (set) Token: 0x060180CE RID: 98510 RVA: 0x0061DBA9 File Offset: 0x0061BDA9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Index
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiHotKeyActorComponent.__PropertyOffset_Index);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiHotKeyActorComponent.__PropertyOffset_Index) = value;
		}
	}

	// Token: 0x17002070 RID: 8304
	// (get) Token: 0x060180CF RID: 98511 RVA: 0x0061DBBA File Offset: 0x0061BDBA
	// (set) Token: 0x060180D0 RID: 98512 RVA: 0x0061DBCA File Offset: 0x0061BDCA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsUsePool
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiHotKeyActorComponent.__PropertyOffset_IsUsePool) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiHotKeyActorComponent.__PropertyOffset_IsUsePool) = (value ? 1 : 0);
		}
	}

	// Token: 0x060180D1 RID: 98513 RVA: 0x0061DBDC File Offset: 0x0061BDDC
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

	// Token: 0x060180D2 RID: 98514 RVA: 0x0061DC4C File Offset: 0x0061BE4C
	protected virtual void AwakeBP_Implementation()
	{
		this.UiHotKeyState = EUiHotKeyState.Awake;
	}

	// Token: 0x060180D3 RID: 98515 RVA: 0x0061DC58 File Offset: 0x0061BE58
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

	// Token: 0x060180D4 RID: 98516 RVA: 0x0061DCC8 File Offset: 0x0061BEC8
	protected unsafe virtual void StartBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		if (this.Index <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "当前配置的热键id是无效的,无法执行TsUiHotKeyActorComponent逻辑";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Path";
			UUIItem uuiitem = base.RootUIComp.Get();
			ptr = new ValueTuple<string, object>(item, UiNavigationUtil.GetFullPathOfActor((uuiitem != null) ? uuiitem.GetOwner() : null));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Index", this.Index);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.Start();
	}

	// Token: 0x060180D5 RID: 98517 RVA: 0x0061DD6C File Offset: 0x0061BF6C
	private UniTask Start()
	{
		TsUiHotKeyActorComponent.<Start>d__16 <Start>d__;
		<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Start>d__.<>4__this = this;
		<Start>d__.<>1__state = -1;
		<Start>d__.<>t__builder.Start<TsUiHotKeyActorComponent.<Start>d__16>(ref <Start>d__);
		return <Start>d__.<>t__builder.Task;
	}

	// Token: 0x060180D6 RID: 98518 RVA: 0x0061DDB0 File Offset: 0x0061BFB0
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

	// Token: 0x060180D7 RID: 98519 RVA: 0x0061DE20 File Offset: 0x0061C020
	protected virtual void OnEnableBP_Implementation()
	{
		if (this.HotKeyItem == null)
		{
			return;
		}
		this.RegisterAllHotKeyComponent();
		this.TryResetPanelConfig();
	}

	// Token: 0x060180D8 RID: 98520 RVA: 0x0061DE38 File Offset: 0x0061C038
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

	// Token: 0x060180D9 RID: 98521 RVA: 0x0061DEA8 File Offset: 0x0061C0A8
	protected virtual void OnDisableBP_Implementation()
	{
		if (this.HotKeyItem == null)
		{
			return;
		}
		this.UnRegisterAllHotKeyComponent();
	}

	// Token: 0x060180DA RID: 98522 RVA: 0x0061DEBC File Offset: 0x0061C0BC
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

	// Token: 0x060180DB RID: 98523 RVA: 0x0061DF2C File Offset: 0x0061C12C
	protected virtual void OnPreDestroyBP_Implementation()
	{
		this.UnRegisterHotKeyItem();
		this.UiHotKeyState = EUiHotKeyState.Destroy;
	}

	// Token: 0x060180DC RID: 98524 RVA: 0x0061DF3C File Offset: 0x0061C13C
	private UniTask RegisterHotKeyItem()
	{
		TsUiHotKeyActorComponent.<RegisterHotKeyItem>d__23 <RegisterHotKeyItem>d__;
		<RegisterHotKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RegisterHotKeyItem>d__.<>4__this = this;
		<RegisterHotKeyItem>d__.<>1__state = -1;
		<RegisterHotKeyItem>d__.<>t__builder.Start<TsUiHotKeyActorComponent.<RegisterHotKeyItem>d__23>(ref <RegisterHotKeyItem>d__);
		return <RegisterHotKeyItem>d__.<>t__builder.Task;
	}

	// Token: 0x060180DD RID: 98525 RVA: 0x0061DF80 File Offset: 0x0061C180
	private unsafe void TryResetPanelConfig()
	{
		if (!this.IsUsePool)
		{
			return;
		}
		if (this.UiHotKeyState < EUiHotKeyState.Start)
		{
			return;
		}
		if (this.HotKeyItem == null)
		{
			return;
		}
		TsUiNavigationPanelConfig panelConfig = this.PanelConfig;
		if (panelConfig != null && panelConfig.IsValid())
		{
			TsUiNavigationPanelConfig panelConfig2 = this.PanelConfig;
			bool flag;
			if (panelConfig2 == null)
			{
				flag = false;
			}
			else
			{
				UUIItem uuiitem = panelConfig2.RootUIComp.Get();
				flag = ((uuiitem != null) ? new bool?(uuiitem.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "可能存在从对象池获取的情况[UiHotKeyActorComponent]";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GroupName", this.Index);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "Name";
		UUIItem uuiitem2 = base.RootUIComp.Get();
		ptr = new ValueTuple<string, object>(item, (uuiitem2 != null) ? uuiitem2.displayName : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.PanelConfig = UiNavigationLogic.FindUiNavigationPanelConfig(base.GetOwner());
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.AddHotKeyItem(this.HotKeyItem);
	}

	// Token: 0x060180DE RID: 98526 RVA: 0x0061E09F File Offset: 0x0061C29F
	private void UnRegisterHotKeyItem()
	{
		if (this.HotKeyItem == null)
		{
			return;
		}
		this.UnRegisterAllHotKeyComponent();
		this.HotKeyItem.Clear();
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.DeleteKeyItem(this.HotKeyItem);
	}

	// Token: 0x060180DF RID: 98527 RVA: 0x0061E0D8 File Offset: 0x0061C2D8
	private void RegisterAllHotKeyComponent()
	{
		if (this.UiHotKeyState < EUiHotKeyState.Start)
		{
			return;
		}
		if (this.UiHotKeyState == EUiHotKeyState.Register)
		{
			return;
		}
		this.UiHotKeyState = EUiHotKeyState.Register;
		foreach (HotKeyComponent hotKeyComponent in this.HotKeyItem.GetHotKeyComponentArray())
		{
			if (hotKeyComponent != null)
			{
				this.RegisterHotKeyComponent(hotKeyComponent);
			}
		}
	}

	// Token: 0x060180E0 RID: 98528 RVA: 0x0061E150 File Offset: 0x0061C350
	private void UnRegisterAllHotKeyComponent()
	{
		if (this.UiHotKeyState != EUiHotKeyState.Register)
		{
			return;
		}
		this.UiHotKeyState = EUiHotKeyState.UnRegister;
		foreach (HotKeyComponent hotKeyComponent in this.HotKeyItem.GetHotKeyComponentArray())
		{
			if (hotKeyComponent != null)
			{
				this.UnRegisterHotKeyComponent(hotKeyComponent);
			}
		}
	}

	// Token: 0x060180E1 RID: 98529 RVA: 0x0061E1BC File Offset: 0x0061C3BC
	private void RegisterHotKeyComponent(HotKeyComponent hotKeyComponent)
	{
		hotKeyComponent.RegisterMe();
		UiNavigationLogic.BindHotKeyComponentAction(hotKeyComponent, true);
		UiNavigationLogic.BindHotKeyComponentAxis(hotKeyComponent, true);
	}

	// Token: 0x060180E2 RID: 98530 RVA: 0x0061E1D2 File Offset: 0x0061C3D2
	private void UnRegisterHotKeyComponent(HotKeyComponent hotKeyComponent)
	{
		hotKeyComponent.UnRegisterMe();
		UiNavigationLogic.BindHotKeyComponentAction(hotKeyComponent, false);
		UiNavigationLogic.BindHotKeyComponentAxis(hotKeyComponent, false);
	}

	// Token: 0x060180E3 RID: 98531 RVA: 0x0061E1E8 File Offset: 0x0061C3E8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiHotKeyActorComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyActorComponent.TsUiHotKeyActorComponent_C");
		}
		return TsUiHotKeyActorComponent._ClassPtr;
	}

	// Token: 0x060180E4 RID: 98532 RVA: 0x0061E20C File Offset: 0x0061C40C
	public TsUiHotKeyActorComponent() : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060180E5 RID: 98533 RVA: 0x0061E234 File Offset: 0x0061C434
	public TsUiHotKeyActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060180E6 RID: 98534 RVA: 0x0061E267 File Offset: 0x0061C467
	protected TsUiHotKeyActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060180E7 RID: 98535 RVA: 0x0061E270 File Offset: 0x0061C470
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x060180E8 RID: 98536 RVA: 0x0061E278 File Offset: 0x0061C478
	protected virtual void __CPPCALL_StartBP_Implementation()
	{
		this.StartBP_Implementation();
	}

	// Token: 0x060180E9 RID: 98537 RVA: 0x0061E280 File Offset: 0x0061C480
	protected virtual void __CPPCALL_OnEnableBP_Implementation()
	{
		this.OnEnableBP_Implementation();
	}

	// Token: 0x060180EA RID: 98538 RVA: 0x0061E288 File Offset: 0x0061C488
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x060180EB RID: 98539 RVA: 0x0061E290 File Offset: 0x0061C490
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0400B2F2 RID: 45810
	[Nullable(2)]
	public HotKeyItem HotKeyItem;

	// Token: 0x0400B2F3 RID: 45811
	[Nullable(2)]
	public TsUiNavigationPanelConfig PanelConfig;

	// Token: 0x0400B2F4 RID: 45812
	private EUiHotKeyState UiHotKeyState;

	// Token: 0x0400B2F5 RID: 45813
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyActorComponent.TsUiHotKeyActorComponent_C";

	// Token: 0x0400B2F6 RID: 45814
	private static IntPtr _ClassPtr;

	// Token: 0x0400B2F7 RID: 45815
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B2F8 RID: 45816
	private static int __PropertyOffset_Mode;

	// Token: 0x0400B2F9 RID: 45817
	private static int __PropertyOffset_Index;

	// Token: 0x0400B2FA RID: 45818
	private static int __PropertyOffset_IsUsePool;
}
