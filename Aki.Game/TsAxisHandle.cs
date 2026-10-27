using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000257 RID: 599
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsAxisHandle.TsAxisHandle_C")]
public class TsAxisHandle : UObject, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000595 RID: 1429
	// (get) Token: 0x06002476 RID: 9334 RVA: 0x000DDF7F File Offset: 0x000DC17F
	// (set) Token: 0x06002477 RID: 9335 RVA: 0x000DDF93 File Offset: 0x000DC193
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

	// Token: 0x17000596 RID: 1430
	// (get) Token: 0x06002478 RID: 9336 RVA: 0x000DDFA8 File Offset: 0x000DC1A8
	// (set) Token: 0x06002479 RID: 9337 RVA: 0x000DDFBC File Offset: 0x000DC1BC
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

	// Token: 0x0600247A RID: 9338 RVA: 0x000DDFD1 File Offset: 0x000DC1D1
	public void Initialize(TsBasePlayerController playerController)
	{
		this.PlayerController = playerController;
		this.OnInputStat = Stat.Create("TsAxisHandle.OnInputAxis", "", "STATGROUP_KuroBattle");
	}

	// Token: 0x0600247B RID: 9339 RVA: 0x000DDFF4 File Offset: 0x000DC1F4
	public void Reset()
	{
		this.PlayerController = null;
		this.AxisName = string.Empty;
		this.OnInputAxisCallback = null;
	}

	// Token: 0x0600247C RID: 9340 RVA: 0x000DE010 File Offset: 0x000DC210
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

	// Token: 0x0600247D RID: 9341 RVA: 0x000DE094 File Offset: 0x000DC294
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnInputAxis(float value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnInputAxis"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAxisHandle.__OnInputAxis_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAxisHandle.__OnInputAxis_FunctionParams*)ptr + 15L / (long)sizeof(TsAxisHandle.__OnInputAxis_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600247E RID: 9342 RVA: 0x000DE10A File Offset: 0x000DC30A
	protected void OnInputAxis_Implementation(float value)
	{
		Action<string, float> onInputAxisCallback = this.OnInputAxisCallback;
		if (onInputAxisCallback == null)
		{
			return;
		}
		onInputAxisCallback(this.AxisName, value);
	}

	// Token: 0x0600247F RID: 9343 RVA: 0x000DE123 File Offset: 0x000DC323
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAxisHandle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsAxisHandle.TsAxisHandle_C");
		}
		return TsAxisHandle._ClassPtr;
	}

	// Token: 0x06002480 RID: 9344 RVA: 0x000DE148 File Offset: 0x000DC348
	public TsAxisHandle() : this(BuiltinUtils.AllocNativeUObject(TsAxisHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002481 RID: 9345 RVA: 0x000DE170 File Offset: 0x000DC370
	public TsAxisHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAxisHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002482 RID: 9346 RVA: 0x000DE1A3 File Offset: 0x000DC3A3
	protected TsAxisHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06002483 RID: 9347 RVA: 0x000DE1AC File Offset: 0x000DC3AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnInputAxis_Implementation(TsAxisHandle.__OnInputAxis_FunctionParams* __Params)
	{
		this.OnInputAxis_Implementation(__Params->value);
	}

	// Token: 0x040023DC RID: 9180
	[Nullable(2)]
	private Stat OnInputStat;

	// Token: 0x040023DD RID: 9181
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string, float> OnInputAxisCallback;

	// Token: 0x040023DE RID: 9182
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsAxisHandle.TsAxisHandle_C";

	// Token: 0x040023DF RID: 9183
	private static IntPtr _ClassPtr;

	// Token: 0x040023E0 RID: 9184
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040023E1 RID: 9185
	private static int __PropertyOffset_PlayerController;

	// Token: 0x040023E2 RID: 9186
	private static int __PropertyOffset_AxisName;

	// Token: 0x02007445 RID: 29765
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __OnInputAxis_FunctionParams
	{
		// Token: 0x0402682D RID: 157741
		[FieldOffset(0)]
		public float value;
	}
}
