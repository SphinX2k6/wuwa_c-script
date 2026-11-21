using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200025B RID: 603
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsAxisHandle.TsAxisHandle_C")]
public class TsAxisHandle : UObject, IUnrealUObject, IUnrealObject
{
	// Token: 0x170005BC RID: 1468
	// (get) Token: 0x0600252D RID: 9517 RVA: 0x000E435B File Offset: 0x000E255B
	// (set) Token: 0x0600252E RID: 9518 RVA: 0x000E436F File Offset: 0x000E256F
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe TsBasePlayerController PlayerController
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<TsBasePlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + TsAxisHandle.__PropertyOffset_PlayerController);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAxisHandle.__PropertyOffset_PlayerController, value);
		}
	}

	// Token: 0x170005BD RID: 1469
	// (get) Token: 0x0600252F RID: 9519 RVA: 0x000E4384 File Offset: 0x000E2584
	// (set) Token: 0x06002530 RID: 9520 RVA: 0x000E4398 File Offset: 0x000E2598
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe string AxisName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAxisHandle.__PropertyOffset_AxisName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAxisHandle.__PropertyOffset_AxisName)), value);
		}
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x000E43AD File Offset: 0x000E25AD
	public void Initialize(TsBasePlayerController playerController)
	{
		this.PlayerController = playerController;
		this.OnInputStat = Stat.Create("TsAxisHandle.OnInputAxis", "", "STATGROUP_KuroBattle");
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x000E43D0 File Offset: 0x000E25D0
	public void Reset()
	{
		this.PlayerController = null;
		this.AxisName = string.Empty;
		this.OnInputAxisCallback = null;
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x000E43EC File Offset: 0x000E25EC
	public void AddAxisBinding(string axisName, [Nullable(new byte[]
	{
		2,
		1
	})] Action<string, float> onInputAxis)
	{
		if (onInputAxis == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Controller;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加Axis输入绑定时，回调不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AxisName = axisName;
		this.OnInputAxisCallback = onInputAxis;
		FName? dynamicFName = FNameUtil.GetDynamicFName(axisName);
		if (dynamicFName == null)
		{
			return;
		}
		TsBasePlayerController playerController = this.PlayerController;
		if (playerController == null)
		{
			return;
		}
		FName value = dynamicFName.Value;
		FName fname = new FName("OnInputAxis");
		playerController.AddAxisBinding(value, this, fname);
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x000E4470 File Offset: 0x000E2670
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnInputAxis(float value)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAxisHandle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnInputAxis"), TsAxisHandle.StaticClass(), out intPtr, out num))
		{
			this.OnInputAxis_Implementation(value);
			return;
		}
		TsAxisHandle.__OnInputAxis_FunctionParams* ptr = stackalloc TsAxisHandle.__OnInputAxis_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAxisHandle.__OnInputAxis_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->value = value;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x000E44FC File Offset: 0x000E26FC
	protected void OnInputAxis_Implementation(float value)
	{
		Action<string, float> onInputAxisCallback = this.OnInputAxisCallback;
		if (onInputAxisCallback == null)
		{
			return;
		}
		onInputAxisCallback(this.AxisName, value);
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x000E4515 File Offset: 0x000E2715
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAxisHandle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsAxisHandle.TsAxisHandle_C");
		}
		return TsAxisHandle._ClassPtr;
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x000E453C File Offset: 0x000E273C
	public TsAxisHandle() : this(BuiltinUtils.AllocNativeUObject(TsAxisHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x000E4564 File Offset: 0x000E2764
	public TsAxisHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAxisHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x000E4597 File Offset: 0x000E2797
	protected TsAxisHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x000E45A0 File Offset: 0x000E27A0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnInputAxis_Implementation(TsAxisHandle.__OnInputAxis_FunctionParams* __Params)
	{
		this.OnInputAxis_Implementation(__Params->value);
	}

	// Token: 0x0400245A RID: 9306
	[Nullable(2)]
	private Stat OnInputStat;

	// Token: 0x0400245B RID: 9307
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string, float> OnInputAxisCallback;

	// Token: 0x0400245C RID: 9308
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsAxisHandle.TsAxisHandle_C";

	// Token: 0x0400245D RID: 9309
	private static IntPtr _ClassPtr;

	// Token: 0x0400245E RID: 9310
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400245F RID: 9311
	private static int __PropertyOffset_PlayerController;

	// Token: 0x04002460 RID: 9312
	private static int __PropertyOffset_AxisName;

	// Token: 0x020065D6 RID: 26070
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __OnInputAxis_FunctionParams
	{
		// Token: 0x04021B6B RID: 138091
		[FieldOffset(0)]
		public float value;
	}
}
