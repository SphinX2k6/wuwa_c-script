using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200025A RID: 602
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Controller/TsActionHandle.TsActionHandle_C")]
public class TsActionHandle : UObject, IUnrealUObject, IUnrealObject
{
	// Token: 0x170005BA RID: 1466
	// (get) Token: 0x0600251C RID: 9500 RVA: 0x000E3FB2 File Offset: 0x000E21B2
	// (set) Token: 0x0600251D RID: 9501 RVA: 0x000E3FC6 File Offset: 0x000E21C6
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe TsBasePlayerController PlayerController
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<TsBasePlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + TsActionHandle.__PropertyOffset_PlayerController);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsActionHandle.__PropertyOffset_PlayerController, value);
		}
	}

	// Token: 0x170005BB RID: 1467
	// (get) Token: 0x0600251E RID: 9502 RVA: 0x000E3FDB File Offset: 0x000E21DB
	// (set) Token: 0x0600251F RID: 9503 RVA: 0x000E3FEF File Offset: 0x000E21EF
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe string ActionName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsActionHandle.__PropertyOffset_ActionName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsActionHandle.__PropertyOffset_ActionName)), value);
		}
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x000E4004 File Offset: 0x000E2204
	public void Initialize(TsBasePlayerController playerController)
	{
		this.PlayerController = playerController;
		this.OnPressStat = Stat.Create("TsActionHandle.OnPressAction", "", "STATGROUP_KuroBattle");
		this.OnReleaseStat = Stat.Create("TsActionHandle.OnReleaseAction", "", "STATGROUP_KuroBattle");
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x000E4041 File Offset: 0x000E2241
	public void Reset()
	{
		this.PlayerController = null;
		this.ActionName = string.Empty;
		this.OnInputActionCallback = null;
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x000E405C File Offset: 0x000E225C
	public void AddActionBinding(string actionName, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<string, bool, FKey> onInputAction)
	{
		if (onInputAction == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Controller;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加Action输入绑定时，回调不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.ActionName = actionName;
		this.OnInputActionCallback = onInputAction;
		FName? dynamicFName = FNameUtil.GetDynamicFName(actionName);
		if (dynamicFName == null)
		{
			return;
		}
		TsBasePlayerController playerController = this.PlayerController;
		FName value;
		FName fname;
		if (playerController != null)
		{
			value = dynamicFName.Value;
			EInputEvent keyEvent = EInputEvent.IE_Pressed;
			fname = new FName("OnPressAction");
			playerController.AddActionBinding(value, keyEvent, this, fname);
		}
		TsBasePlayerController playerController2 = this.PlayerController;
		if (playerController2 == null)
		{
			return;
		}
		value = dynamicFName.Value;
		EInputEvent keyEvent2 = EInputEvent.IE_Released;
		fname = new FName("OnReleaseAction");
		playerController2.AddActionBinding(value, keyEvent2, this, fname);
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x000E410C File Offset: 0x000E230C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnPressAction(FKey key)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsActionHandle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPressAction"), TsActionHandle.StaticClass(), out intPtr, out num))
		{
			this.OnPressAction_Implementation(key);
			return;
		}
		TsActionHandle.__OnPressAction_FunctionParams* ptr = stackalloc TsActionHandle.__OnPressAction_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsActionHandle.__OnPressAction_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x000E41B1 File Offset: 0x000E23B1
	protected void OnPressAction_Implementation(FKey key)
	{
		Action<string, bool, FKey> onInputActionCallback = this.OnInputActionCallback;
		if (onInputActionCallback == null)
		{
			return;
		}
		onInputActionCallback(this.ActionName, true, key);
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x000E41CC File Offset: 0x000E23CC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void OnReleaseAction(FKey key)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsActionHandle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnReleaseAction"), TsActionHandle.StaticClass(), out intPtr, out num))
		{
			this.OnReleaseAction_Implementation(key);
			return;
		}
		TsActionHandle.__OnReleaseAction_FunctionParams* ptr = stackalloc TsActionHandle.__OnReleaseAction_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsActionHandle.__OnReleaseAction_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002526 RID: 9510 RVA: 0x000E4271 File Offset: 0x000E2471
	protected void OnReleaseAction_Implementation(FKey key)
	{
		Action<string, bool, FKey> onInputActionCallback = this.OnInputActionCallback;
		if (onInputActionCallback == null)
		{
			return;
		}
		onInputActionCallback(this.ActionName, false, key);
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x000E428B File Offset: 0x000E248B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsActionHandle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Controller/TsActionHandle.TsActionHandle_C");
		}
		return TsActionHandle._ClassPtr;
	}

	// Token: 0x06002528 RID: 9512 RVA: 0x000E42B0 File Offset: 0x000E24B0
	public TsActionHandle() : this(BuiltinUtils.AllocNativeUObject(TsActionHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x000E42D8 File Offset: 0x000E24D8
	public TsActionHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsActionHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x000E430B File Offset: 0x000E250B
	protected TsActionHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600252B RID: 9515 RVA: 0x000E4314 File Offset: 0x000E2514
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnPressAction_Implementation(TsActionHandle.__OnPressAction_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		this.OnPressAction_Implementation(key);
	}

	// Token: 0x0600252C RID: 9516 RVA: 0x000E4338 File Offset: 0x000E2538
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnReleaseAction_Implementation(TsActionHandle.__OnReleaseAction_FunctionParams* __Params)
	{
		FKey key = new FKey(&__Params->key, true, true);
		this.OnReleaseAction_Implementation(key);
	}

	// Token: 0x04002452 RID: 9298
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<string, bool, FKey> OnInputActionCallback;

	// Token: 0x04002453 RID: 9299
	[Nullable(2)]
	private Stat OnPressStat;

	// Token: 0x04002454 RID: 9300
	[Nullable(2)]
	private Stat OnReleaseStat;

	// Token: 0x04002455 RID: 9301
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Controller/TsActionHandle.TsActionHandle_C";

	// Token: 0x04002456 RID: 9302
	private static IntPtr _ClassPtr;

	// Token: 0x04002457 RID: 9303
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002458 RID: 9304
	private static int __PropertyOffset_PlayerController;

	// Token: 0x04002459 RID: 9305
	private static int __PropertyOffset_ActionName;

	// Token: 0x020065D4 RID: 26068
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnPressAction_FunctionParams
	{
		// Token: 0x04021B69 RID: 138089
		[FieldOffset(0)]
		public byte key;
	}

	// Token: 0x020065D5 RID: 26069
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnReleaseAction_FunctionParams
	{
		// Token: 0x04021B6A RID: 138090
		[FieldOffset(0)]
		public byte key;
	}
}
