using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002C58 RID: 11352
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneRoleActor.TsUiSceneRoleActor_C")]
public class TsUiSceneRoleActor : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x06017B23 RID: 97059 RVA: 0x006065F0 File Offset: 0x006047F0
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

	// Token: 0x06017B24 RID: 97060 RVA: 0x00606664 File Offset: 0x00604864
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveTick_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06017B25 RID: 97061 RVA: 0x006066DA File Offset: 0x006048DA
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		UiModelBase model = this.Model;
		if (model == null)
		{
			return;
		}
		model.Tick(deltaSeconds);
	}

	// Token: 0x06017B26 RID: 97062 RVA: 0x006066ED File Offset: 0x006048ED
	public int GetRoleActorIndex()
	{
		return this.RoleActorIndex;
	}

	// Token: 0x06017B27 RID: 97063 RVA: 0x006066F5 File Offset: 0x006048F5
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

	// Token: 0x06017B28 RID: 97064 RVA: 0x00606730 File Offset: 0x00604930
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool IsShowUiWepaonEffect()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("IsShowUiWepaonEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams*)ptr + 15L / (long)sizeof(TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06017B29 RID: 97065 RVA: 0x006067A5 File Offset: 0x006049A5
	protected bool IsShowUiWepaonEffect_Implementation()
	{
		return true;
	}

	// Token: 0x06017B2A RID: 97066 RVA: 0x006067A8 File Offset: 0x006049A8
	public void SetMoveOutActor()
	{
		this.BeforeMoveOutPos = base.D_K2_GetActorLocation();
		FHitResult fhitResult = null;
		base.D_K2_SetActorLocation(Vector.ZeroVectorDouble, false, ref fhitResult, false);
	}

	// Token: 0x06017B2B RID: 97067 RVA: 0x006067D4 File Offset: 0x006049D4
	public void SetMoveInActor()
	{
		FHitResult fhitResult = null;
		base.D_K2_SetActorLocation(this.BeforeMoveOutPos, false, ref fhitResult, false);
	}

	// Token: 0x06017B2C RID: 97068 RVA: 0x006067F4 File Offset: 0x006049F4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiSceneRoleActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneRoleActor.TsUiSceneRoleActor_C");
		}
		return TsUiSceneRoleActor._ClassPtr;
	}

	// Token: 0x06017B2D RID: 97069 RVA: 0x00606818 File Offset: 0x00604A18
	public TsUiSceneRoleActor() : this(BuiltinUtils.AllocNativeUObject(TsUiSceneRoleActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06017B2E RID: 97070 RVA: 0x00606840 File Offset: 0x00604A40
	[NullableContext(1)]
	public TsUiSceneRoleActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneRoleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06017B2F RID: 97071 RVA: 0x00606873 File Offset: 0x00604A73
	protected TsUiSceneRoleActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17001FD4 RID: 8148
	// (get) Token: 0x06017B30 RID: 97072 RVA: 0x00606887 File Offset: 0x00604A87
	[Nullable(1)]
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		[NullableContext(1)]
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiSceneRoleActor.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x17001FD5 RID: 8149
	// (get) Token: 0x06017B31 RID: 97073 RVA: 0x00606897 File Offset: 0x00604A97
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiSceneRoleActor.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x06017B32 RID: 97074 RVA: 0x006068AB File Offset: 0x00604AAB
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(AActor.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x06017B33 RID: 97075 RVA: 0x006068B9 File Offset: 0x00604AB9
	protected unsafe virtual void __CPPCALL_IsShowUiWepaonEffect_Implementation(TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams* __Params)
	{
		__Params->__Result = this.IsShowUiWepaonEffect_Implementation();
	}

	// Token: 0x0400B088 RID: 45192
	[Nullable(2)]
	public UiModelBase Model;

	// Token: 0x0400B089 RID: 45193
	private int RoleActorIndex;

	// Token: 0x0400B08A RID: 45194
	private FVectorDouble BeforeMoveOutPos = Vector.ZeroVectorDouble;

	// Token: 0x0400B08B RID: 45195
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiSceneRoleActor.TsUiSceneRoleActor_C";

	// Token: 0x0400B08C RID: 45196
	private static IntPtr _ClassPtr;

	// Token: 0x0400B08D RID: 45197
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B08E RID: 45198
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x0400B08F RID: 45199
	private static int __PropertyOffset_DefaultSceneRoot;

	// Token: 0x0200923C RID: 37436
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __IsShowUiWepaonEffect_FunctionParams
	{
		// Token: 0x0402F4C1 RID: 193729
		[FieldOffset(0)]
		public bool __Result;
	}
}
