using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200026D RID: 621
[UClass("/Game/Aki/TypeScript/Game/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Effect/TsEffectActor.TsEffectActor_C")]
public class TsEffectActor : AActor, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject, IUnrealUObject
{
	// Token: 0x060025D4 RID: 9684 RVA: 0x000E2FCB File Offset: 0x000E11CB
	[NullableContext(1)]
	public void SetEffectHandle(int handleId = 0, string path = "", EEffectType type = EEffectType.Scene)
	{
		this.HandleId = new int?(handleId);
		this.EffectPath = path;
		this.EffectType = type;
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x000E2FE8 File Offset: 0x000E11E8
	public void SetTimeScale(float timeScale)
	{
		float? timeScale2 = this.TimeScale;
		if (!(timeScale2.GetValueOrDefault() == timeScale & timeScale2 != null))
		{
			this.TimeScale = new float?(timeScale);
		}
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x000E301E File Offset: 0x000E121E
	public float GetTimeScale()
	{
		return this.TimeScale.GetValueOrDefault(1f);
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x000E3030 File Offset: 0x000E1230
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GetHandle(ref int handle)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEffectActor.__GetHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEffectActor.__GetHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsEffectActor.__GetHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->handle = handle;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		handle = ptr2->handle;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x000E30AF File Offset: 0x000E12AF
	protected void GetHandle_Implementation(ref int handle)
	{
		((IBPI_EffectInterface_C)this).GetHandle(ref handle);
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x000E30B8 File Offset: 0x000E12B8
	void IBPI_EffectInterface_C.GetHandle(ref int handle)
	{
		handle = this.HandleId.GetValueOrDefault();
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x000E30C8 File Offset: 0x000E12C8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetHandle(int handle)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetHandle"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEffectActor.__SetHandle_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEffectActor.__SetHandle_FunctionParams*)ptr + 15L / (long)sizeof(TsEffectActor.__SetHandle_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->handle = handle;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x000E313E File Offset: 0x000E133E
	protected void SetHandle_Implementation(int handle)
	{
		((IBPI_EffectInterface_C)this).SetHandle(handle);
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x000E3147 File Offset: 0x000E1347
	void IBPI_EffectInterface_C.SetHandle(int handle)
	{
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x000E314C File Offset: 0x000E134C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveHandle()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RemoveHandle"), out num);
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

	// Token: 0x060025DE RID: 9694 RVA: 0x000E31BC File Offset: 0x000E13BC
	protected void RemoveHandle_Implementation()
	{
		((IBPI_EffectInterface_C)this).RemoveHandle();
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x000E31C4 File Offset: 0x000E13C4
	void IBPI_EffectInterface_C.RemoveHandle()
	{
		this.HandleId = new int?(0);
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x000E31D4 File Offset: 0x000E13D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)endPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x000E324D File Offset: 0x000E144D
	protected void ReceiveEndPlay_Implementation(EEndPlayReason endPlayReason)
	{
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x000E324F File Offset: 0x000E144F
	[NullableContext(1)]
	public void StopEffect(string reason, bool immediately = false, bool destroyActor = false)
	{
		if (!EffectSystem.Instance.IsValid(this.HandleId.GetValueOrDefault()))
		{
			return;
		}
		EffectSystem.Instance.StopEffectById(this.HandleId.GetValueOrDefault(), reason, immediately, new bool?(destroyActor));
	}

	// Token: 0x060025E3 RID: 9699 RVA: 0x000E3287 File Offset: 0x000E1487
	[NullableContext(1)]
	public string GetEffectPath()
	{
		return this.EffectPath;
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x000E328F File Offset: 0x000E148F
	public EEffectType GetEffectType()
	{
		return this.EffectType;
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x000E3297 File Offset: 0x000E1497
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsEffectActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Effect/TsEffectActor.TsEffectActor_C");
		}
		return TsEffectActor._ClassPtr;
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x000E32BC File Offset: 0x000E14BC
	public TsEffectActor() : this(BuiltinUtils.AllocNativeUObject(TsEffectActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x000E32E4 File Offset: 0x000E14E4
	[NullableContext(1)]
	public TsEffectActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x000E3317 File Offset: 0x000E1517
	protected TsEffectActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x170005C9 RID: 1481
	// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000E334B File Offset: 0x000E154B
	[Nullable(1)]
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		[NullableContext(1)]
		get
		{
			return *(base.NativePtr + (IntPtr)TsEffectActor.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x170005CA RID: 1482
	// (get) Token: 0x060025EA RID: 9706 RVA: 0x000E335B File Offset: 0x000E155B
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsEffectActor.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x000E336F File Offset: 0x000E156F
	protected unsafe virtual void __CPPCALL_GetHandle_Implementation(TsEffectActor.__GetHandle_FunctionParams* __Params)
	{
		this.GetHandle_Implementation(ref __Params->handle);
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x000E337D File Offset: 0x000E157D
	protected unsafe virtual void __CPPCALL_SetHandle_Implementation(TsEffectActor.__SetHandle_FunctionParams* __Params)
	{
		this.SetHandle_Implementation(__Params->handle);
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x000E338B File Offset: 0x000E158B
	protected virtual void __CPPCALL_RemoveHandle_Implementation()
	{
		this.RemoveHandle_Implementation();
	}

	// Token: 0x060025EE RID: 9710 RVA: 0x000E3394 File Offset: 0x000E1594
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0400247A RID: 9338
	public EffectActorPoolEnum InPool;

	// Token: 0x0400247B RID: 9339
	private int? HandleId = new int?(0);

	// Token: 0x0400247C RID: 9340
	[Nullable(1)]
	private string EffectPath = "";

	// Token: 0x0400247D RID: 9341
	private EEffectType EffectType = EEffectType.Scene;

	// Token: 0x0400247E RID: 9342
	public int OwnerEntityId;

	// Token: 0x0400247F RID: 9343
	private float? TimeScale = new float?((float)1);

	// Token: 0x04002480 RID: 9344
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Effect/TsEffectActor.TsEffectActor_C";

	// Token: 0x04002481 RID: 9345
	private static IntPtr _ClassPtr;

	// Token: 0x04002482 RID: 9346
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002483 RID: 9347
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x04002484 RID: 9348
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x02007454 RID: 29780
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetHandle_FunctionParams
	{
		// Token: 0x0402684D RID: 157773
		[FieldOffset(0)]
		public int handle;
	}

	// Token: 0x02007455 RID: 29781
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetHandle_FunctionParams
	{
		// Token: 0x0402684E RID: 157774
		[FieldOffset(0)]
		public int handle;
	}
}
