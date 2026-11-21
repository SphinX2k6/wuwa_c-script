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

// Token: 0x02000271 RID: 625
[UClass("/Game/Aki/TypeScript/Game/Effect/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Effect/TsEffectActor.TsEffectActor_C")]
public class TsEffectActor : AActor, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject, IUnrealUObject
{
	// Token: 0x0600268E RID: 9870 RVA: 0x000E95B3 File Offset: 0x000E77B3
	[NullableContext(1)]
	public void SetEffectHandle(int handleId = 0, string path = "", EEffectType type = EEffectType.Scene)
	{
		this.HandleId = new int?(handleId);
		this.EffectPath = path;
		this.EffectType = type;
	}

	// Token: 0x0600268F RID: 9871 RVA: 0x000E95D0 File Offset: 0x000E77D0
	public void SetTimeScale(float timeScale)
	{
		float? timeScale2 = this.TimeScale;
		if (!(timeScale2.GetValueOrDefault() == timeScale & timeScale2 != null))
		{
			this.TimeScale = new float?(timeScale);
		}
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x000E9606 File Offset: 0x000E7806
	public float GetTimeScale()
	{
		return this.TimeScale.GetValueOrDefault(1f);
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x000E9618 File Offset: 0x000E7818
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GetHandle(ref int handle)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEffectActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetHandle"), TsEffectActor.StaticClass(), out intPtr, out num))
		{
			this.GetHandle_Implementation(ref handle);
			return;
		}
		TsEffectActor.__GetHandle_FunctionParams* ptr = stackalloc TsEffectActor.__GetHandle_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEffectActor.__GetHandle_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->handle = handle;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		handle = ptr->handle;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x000E96AD File Offset: 0x000E78AD
	protected void GetHandle_Implementation(ref int handle)
	{
		((IBPI_EffectInterface_C)this).GetHandle(ref handle);
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x000E96B6 File Offset: 0x000E78B6
	void IBPI_EffectInterface_C.GetHandle(ref int handle)
	{
		handle = this.HandleId.GetValueOrDefault();
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x000E96C8 File Offset: 0x000E78C8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetHandle(int handle)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEffectActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetHandle"), TsEffectActor.StaticClass(), out intPtr, out num))
		{
			this.SetHandle_Implementation(handle);
			return;
		}
		TsEffectActor.__SetHandle_FunctionParams* ptr = stackalloc TsEffectActor.__SetHandle_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEffectActor.__SetHandle_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->handle = handle;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x000E9754 File Offset: 0x000E7954
	protected void SetHandle_Implementation(int handle)
	{
		((IBPI_EffectInterface_C)this).SetHandle(handle);
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x000E975D File Offset: 0x000E795D
	void IBPI_EffectInterface_C.SetHandle(int handle)
	{
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x000E9760 File Offset: 0x000E7960
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void RemoveHandle()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsEffectActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveHandle"), TsEffectActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.RemoveHandle_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x000E97B9 File Offset: 0x000E79B9
	protected void RemoveHandle_Implementation()
	{
		((IBPI_EffectInterface_C)this).RemoveHandle();
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x000E97C1 File Offset: 0x000E79C1
	void IBPI_EffectInterface_C.RemoveHandle()
	{
		this.HandleId = new int?(0);
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x000E97D0 File Offset: 0x000E79D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEffectActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), TsEffectActor.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x000E985F File Offset: 0x000E7A5F
	protected void ReceiveEndPlay_Implementation(EEndPlayReason endPlayReason)
	{
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x000E9861 File Offset: 0x000E7A61
	[NullableContext(1)]
	public void StopEffect(string reason, bool immediately = false, bool destroyActor = false)
	{
		if (!EffectSystem.Instance.IsValid(this.HandleId.GetValueOrDefault()))
		{
			return;
		}
		EffectSystem.Instance.StopEffectById(this.HandleId.GetValueOrDefault(), reason, immediately, new bool?(destroyActor));
	}

	// Token: 0x0600269D RID: 9885 RVA: 0x000E9899 File Offset: 0x000E7A99
	[NullableContext(1)]
	public string GetEffectPath()
	{
		return this.EffectPath;
	}

	// Token: 0x0600269E RID: 9886 RVA: 0x000E98A1 File Offset: 0x000E7AA1
	public EEffectType GetEffectType()
	{
		return this.EffectType;
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x000E98A9 File Offset: 0x000E7AA9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsEffectActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Effect/TsEffectActor.TsEffectActor_C");
		}
		return TsEffectActor._ClassPtr;
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x000E98D0 File Offset: 0x000E7AD0
	public TsEffectActor() : this(BuiltinUtils.AllocNativeUObject(TsEffectActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x000E98F8 File Offset: 0x000E7AF8
	[NullableContext(1)]
	public TsEffectActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x000E992B File Offset: 0x000E7B2B
	protected TsEffectActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x170005F0 RID: 1520
	// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000E995F File Offset: 0x000E7B5F
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsEffectActor.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x000E9973 File Offset: 0x000E7B73
	protected unsafe virtual void __CPPCALL_GetHandle_Implementation(TsEffectActor.__GetHandle_FunctionParams* __Params)
	{
		this.GetHandle_Implementation(ref __Params->handle);
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x000E9981 File Offset: 0x000E7B81
	protected unsafe virtual void __CPPCALL_SetHandle_Implementation(TsEffectActor.__SetHandle_FunctionParams* __Params)
	{
		this.SetHandle_Implementation(__Params->handle);
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x000E998F File Offset: 0x000E7B8F
	protected virtual void __CPPCALL_RemoveHandle_Implementation()
	{
		this.RemoveHandle_Implementation();
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x000E9998 File Offset: 0x000E7B98
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x040024FB RID: 9467
	public EffectActorPoolEnum InPool;

	// Token: 0x040024FC RID: 9468
	private int? HandleId = new int?(0);

	// Token: 0x040024FD RID: 9469
	[Nullable(1)]
	private string EffectPath = "";

	// Token: 0x040024FE RID: 9470
	private EEffectType EffectType = EEffectType.Scene;

	// Token: 0x040024FF RID: 9471
	public int OwnerEntityId;

	// Token: 0x04002500 RID: 9472
	private float? TimeScale = new float?((float)1);

	// Token: 0x04002501 RID: 9473
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Effect/TsEffectActor.TsEffectActor_C";

	// Token: 0x04002502 RID: 9474
	private static IntPtr _ClassPtr;

	// Token: 0x04002503 RID: 9475
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002504 RID: 9476
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x020065E5 RID: 26085
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetHandle_FunctionParams
	{
		// Token: 0x04021B8B RID: 138123
		[FieldOffset(0)]
		public int handle;
	}

	// Token: 0x020065E6 RID: 26086
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetHandle_FunctionParams
	{
		// Token: 0x04021B8C RID: 138124
		[FieldOffset(0)]
		public int handle;
	}
}
