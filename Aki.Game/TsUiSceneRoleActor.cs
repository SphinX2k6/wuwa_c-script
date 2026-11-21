using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020021B1 RID: 8625
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneRoleActor.TsUiSceneRoleActor_C")]
public class TsUiSceneRoleActor : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x06015398 RID: 86936 RVA: 0x0062C098 File Offset: 0x0062A298
	public void Init(int roleActorIndex, EUiModelUseWay useWay)
	{
		this.RoleActorIndex = roleActorIndex;
		base.SetTickableWhenPaused(true);
		base.SetActorTickEnabled(true);
		base.CustomTimeDilation = CharacterModel.Instance.InverseSelfCenteredTimeDilation;
		UKuroRenderingRuntimeBPPluginBPLibrary.SetActorUISceneRendering(this, true);
		this.Model = UiModelSystem.Instance.CreateUiModelByUseWay(useWay, this);
		UiModelBase model = this.Model;
		if (model != null)
		{
			model.Init();
		}
		UiModelBase model2 = this.Model;
		if (model2 != null)
		{
			model2.Start();
		}
		base.SetPrimitiveEntityType(1U);
	}

	// Token: 0x06015399 RID: 86937 RVA: 0x0062C10C File Offset: 0x0062A30C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiSceneRoleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), TsUiSceneRoleActor.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSeconds);
			return;
		}
		AActor.__ReceiveTick_FunctionParams* ptr = stackalloc AActor.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601539A RID: 86938 RVA: 0x0062C198 File Offset: 0x0062A398
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		UiModelBase model = this.Model;
		if (model == null)
		{
			return;
		}
		model.Tick(deltaSeconds);
	}

	// Token: 0x0601539B RID: 86939 RVA: 0x0062C1AB File Offset: 0x0062A3AB
	public int GetRoleActorIndex()
	{
		return this.RoleActorIndex;
	}

	// Token: 0x0601539C RID: 86940 RVA: 0x0062C1B3 File Offset: 0x0062A3B3
	public void Destroy()
	{
		UiModelBase model = this.Model;
		if (model != null)
		{
			model.End();
		}
		UiModelBase model2 = this.Model;
		if (model2 != null)
		{
			model2.Clear();
		}
		this.Model = null;
		this.RoleActorIndex = 0;
		UKuroActorManager.DestroyActor(this);
	}

	// Token: 0x0601539D RID: 86941 RVA: 0x0062C1EC File Offset: 0x0062A3EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool IsShowUiWepaonEffect()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiSceneRoleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("IsShowUiWepaonEffect"), TsUiSceneRoleActor.StaticClass(), out intPtr, out num))
		{
			return this.IsShowUiWepaonEffect_Implementation();
		}
		TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams* ptr = stackalloc TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601539E RID: 86942 RVA: 0x0062C276 File Offset: 0x0062A476
	protected bool IsShowUiWepaonEffect_Implementation()
	{
		return true;
	}

	// Token: 0x0601539F RID: 86943 RVA: 0x0062C27C File Offset: 0x0062A47C
	public void SetMoveOutActor()
	{
		this.BeforeMoveOutPos = base.D_K2_GetActorLocation();
		FHitResult fhitResult = null;
		base.D_K2_SetActorLocation(Vector.ZeroVectorDouble, false, ref fhitResult, false);
	}

	// Token: 0x060153A0 RID: 86944 RVA: 0x0062C2A8 File Offset: 0x0062A4A8
	public void SetMoveInActor()
	{
		FHitResult fhitResult = null;
		base.D_K2_SetActorLocation(this.BeforeMoveOutPos, false, ref fhitResult, false);
	}

	// Token: 0x060153A1 RID: 86945 RVA: 0x0062C2C8 File Offset: 0x0062A4C8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiSceneRoleActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneRoleActor.TsUiSceneRoleActor_C");
		}
		return TsUiSceneRoleActor._ClassPtr;
	}

	// Token: 0x060153A2 RID: 86946 RVA: 0x0062C2EC File Offset: 0x0062A4EC
	public TsUiSceneRoleActor() : this(BuiltinUtils.AllocNativeUObject(TsUiSceneRoleActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060153A3 RID: 86947 RVA: 0x0062C314 File Offset: 0x0062A514
	[NullableContext(1)]
	public TsUiSceneRoleActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneRoleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060153A4 RID: 86948 RVA: 0x0062C347 File Offset: 0x0062A547
	protected TsUiSceneRoleActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17002026 RID: 8230
	// (get) Token: 0x060153A5 RID: 86949 RVA: 0x0062C35B File Offset: 0x0062A55B
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiSceneRoleActor.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x060153A6 RID: 86950 RVA: 0x0062C36F File Offset: 0x0062A56F
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x060153A7 RID: 86951 RVA: 0x0062C37D File Offset: 0x0062A57D
	protected unsafe virtual void __CPPCALL_IsShowUiWepaonEffect_Implementation(TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams* __Params)
	{
		__Params->__Result = this.IsShowUiWepaonEffect_Implementation();
	}

	// Token: 0x0400B3F5 RID: 46069
	[Nullable(2)]
	public UiModelBase Model;

	// Token: 0x0400B3F6 RID: 46070
	private int RoleActorIndex;

	// Token: 0x0400B3F7 RID: 46071
	private FVectorDouble BeforeMoveOutPos = Vector.ZeroVectorDouble;

	// Token: 0x0400B3F8 RID: 46072
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneRoleActor.TsUiSceneRoleActor_C";

	// Token: 0x0400B3F9 RID: 46073
	private static IntPtr _ClassPtr;

	// Token: 0x0400B3FA RID: 46074
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B3FB RID: 46075
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x02008466 RID: 33894
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __IsShowUiWepaonEffect_FunctionParams
	{
		// Token: 0x0402AB4D RID: 174925
		[FieldOffset(0)]
		public bool __Result;
	}
}
