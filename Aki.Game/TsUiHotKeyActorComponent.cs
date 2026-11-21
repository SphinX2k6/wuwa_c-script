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

// Token: 0x02002226 RID: 8742
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyActorComponent.TsUiHotKeyActorComponent_C")]
public class TsUiHotKeyActorComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x170020C1 RID: 8385
	// (get) Token: 0x06015948 RID: 88392 RVA: 0x006437A0 File Offset: 0x006419A0
	// (set) Token: 0x06015949 RID: 88393 RVA: 0x006437B4 File Offset: 0x006419B4
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

	// Token: 0x170020C2 RID: 8386
	// (get) Token: 0x0601594A RID: 88394 RVA: 0x006437C9 File Offset: 0x006419C9
	// (set) Token: 0x0601594B RID: 88395 RVA: 0x006437D9 File Offset: 0x006419D9
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

	// Token: 0x170020C3 RID: 8387
	// (get) Token: 0x0601594C RID: 88396 RVA: 0x006437EA File Offset: 0x006419EA
	// (set) Token: 0x0601594D RID: 88397 RVA: 0x006437FA File Offset: 0x006419FA
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

	// Token: 0x0601594E RID: 88398 RVA: 0x0064380C File Offset: 0x00641A0C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void AwakeBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiHotKeyActorComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AwakeBP"), TsUiHotKeyActorComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AwakeBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601594F RID: 88399 RVA: 0x00643865 File Offset: 0x00641A65
	protected virtual void AwakeBP_Implementation()
	{
		this.UiHotKeyState = EUiHotKeyState.Awake;
	}

	// Token: 0x06015950 RID: 88400 RVA: 0x00643870 File Offset: 0x00641A70
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void StartBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiHotKeyActorComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StartBP"), TsUiHotKeyActorComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.StartBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015951 RID: 88401 RVA: 0x006438CC File Offset: 0x00641ACC
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

	// Token: 0x06015952 RID: 88402 RVA: 0x00643970 File Offset: 0x00641B70
	private UniTask Start()
	{
		TsUiHotKeyActorComponent.<Start>d__16 <Start>d__;
		<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Start>d__.<>4__this = this;
		<Start>d__.<>1__state = -1;
		<Start>d__.<>t__builder.Start<TsUiHotKeyActorComponent.<Start>d__16>(ref <Start>d__);
		return <Start>d__.<>t__builder.Task;
	}

	// Token: 0x06015953 RID: 88403 RVA: 0x006439B4 File Offset: 0x00641BB4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnEnableBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiHotKeyActorComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnEnableBP"), TsUiHotKeyActorComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnEnableBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015954 RID: 88404 RVA: 0x00643A0D File Offset: 0x00641C0D
	protected virtual void OnEnableBP_Implementation()
	{
		if (this.HotKeyItem == null)
		{
			return;
		}
		this.RegisterAllHotKeyComponent();
		this.TryResetPanelConfig();
	}

	// Token: 0x06015955 RID: 88405 RVA: 0x00643A24 File Offset: 0x00641C24
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnDisableBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiHotKeyActorComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnDisableBP"), TsUiHotKeyActorComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnDisableBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015956 RID: 88406 RVA: 0x00643A7D File Offset: 0x00641C7D
	protected virtual void OnDisableBP_Implementation()
	{
		if (this.HotKeyItem == null)
		{
			return;
		}
		this.UnRegisterAllHotKeyComponent();
	}

	// Token: 0x06015957 RID: 88407 RVA: 0x00643A90 File Offset: 0x00641C90
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnPreDestroyBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiHotKeyActorComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPreDestroyBP"), TsUiHotKeyActorComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnPreDestroyBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015958 RID: 88408 RVA: 0x00643AE9 File Offset: 0x00641CE9
	protected virtual void OnPreDestroyBP_Implementation()
	{
		this.UnRegisterHotKeyItem();
		this.UiHotKeyState = EUiHotKeyState.Destroy;
	}

	// Token: 0x06015959 RID: 88409 RVA: 0x00643AF8 File Offset: 0x00641CF8
	private UniTask RegisterHotKeyItem()
	{
		TsUiHotKeyActorComponent.<RegisterHotKeyItem>d__23 <RegisterHotKeyItem>d__;
		<RegisterHotKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RegisterHotKeyItem>d__.<>4__this = this;
		<RegisterHotKeyItem>d__.<>1__state = -1;
		<RegisterHotKeyItem>d__.<>t__builder.Start<TsUiHotKeyActorComponent.<RegisterHotKeyItem>d__23>(ref <RegisterHotKeyItem>d__);
		return <RegisterHotKeyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601595A RID: 88410 RVA: 0x00643B3C File Offset: 0x00641D3C
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

	// Token: 0x0601595B RID: 88411 RVA: 0x00643C5B File Offset: 0x00641E5B
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

	// Token: 0x0601595C RID: 88412 RVA: 0x00643C94 File Offset: 0x00641E94
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

	// Token: 0x0601595D RID: 88413 RVA: 0x00643D0C File Offset: 0x00641F0C
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

	// Token: 0x0601595E RID: 88414 RVA: 0x00643D78 File Offset: 0x00641F78
	private void RegisterHotKeyComponent(HotKeyComponent hotKeyComponent)
	{
		hotKeyComponent.RegisterMe();
		UiNavigationLogic.BindHotKeyComponentAction(hotKeyComponent, true);
		UiNavigationLogic.BindHotKeyComponentAxis(hotKeyComponent, true);
	}

	// Token: 0x0601595F RID: 88415 RVA: 0x00643D8E File Offset: 0x00641F8E
	private void UnRegisterHotKeyComponent(HotKeyComponent hotKeyComponent)
	{
		hotKeyComponent.UnRegisterMe();
		UiNavigationLogic.BindHotKeyComponentAction(hotKeyComponent, false);
		UiNavigationLogic.BindHotKeyComponentAxis(hotKeyComponent, false);
	}

	// Token: 0x06015960 RID: 88416 RVA: 0x00643DA4 File Offset: 0x00641FA4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiHotKeyActorComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyActorComponent.TsUiHotKeyActorComponent_C");
		}
		return TsUiHotKeyActorComponent._ClassPtr;
	}

	// Token: 0x06015961 RID: 88417 RVA: 0x00643DC8 File Offset: 0x00641FC8
	public TsUiHotKeyActorComponent() : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06015962 RID: 88418 RVA: 0x00643DF0 File Offset: 0x00641FF0
	public TsUiHotKeyActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06015963 RID: 88419 RVA: 0x00643E23 File Offset: 0x00642023
	protected TsUiHotKeyActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06015964 RID: 88420 RVA: 0x00643E2C File Offset: 0x0064202C
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x06015965 RID: 88421 RVA: 0x00643E34 File Offset: 0x00642034
	protected virtual void __CPPCALL_StartBP_Implementation()
	{
		this.StartBP_Implementation();
	}

	// Token: 0x06015966 RID: 88422 RVA: 0x00643E3C File Offset: 0x0064203C
	protected virtual void __CPPCALL_OnEnableBP_Implementation()
	{
		this.OnEnableBP_Implementation();
	}

	// Token: 0x06015967 RID: 88423 RVA: 0x00643E44 File Offset: 0x00642044
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x06015968 RID: 88424 RVA: 0x00643E4C File Offset: 0x0064204C
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0400B65E RID: 46686
	[Nullable(2)]
	public HotKeyItem HotKeyItem;

	// Token: 0x0400B65F RID: 46687
	[Nullable(2)]
	public TsUiNavigationPanelConfig PanelConfig;

	// Token: 0x0400B660 RID: 46688
	private EUiHotKeyState UiHotKeyState;

	// Token: 0x0400B661 RID: 46689
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyActorComponent.TsUiHotKeyActorComponent_C";

	// Token: 0x0400B662 RID: 46690
	private static IntPtr _ClassPtr;

	// Token: 0x0400B663 RID: 46691
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B664 RID: 46692
	private static int __PropertyOffset_Mode;

	// Token: 0x0400B665 RID: 46693
	private static int __PropertyOffset_Index;

	// Token: 0x0400B666 RID: 46694
	private static int __PropertyOffset_IsUsePool;
}
