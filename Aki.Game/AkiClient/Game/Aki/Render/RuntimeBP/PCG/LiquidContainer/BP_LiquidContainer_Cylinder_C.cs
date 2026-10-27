using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LiquidContainer
{
	// Token: 0x02003C69 RID: 15465
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LiquidContainer/BP_LiquidContainer_Cylinder.BP_LiquidContainer_Cylinder_C")]
	[UnrealStructLayout(1840, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1840)]
	public class BP_LiquidContainer_Cylinder_C : AKuroLiquidContainerActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D99 RID: 146841 RVA: 0x0092EBED File Offset: 0x0092CDED
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LiquidContainer_Cylinder_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/LiquidContainer/BP_LiquidContainer_Cylinder.BP_LiquidContainer_Cylinder_C");
			}
			return BP_LiquidContainer_Cylinder_C._ClassPtr;
		}

		// Token: 0x06023D9A RID: 146842 RVA: 0x0092EC14 File Offset: 0x0092CE14
		public BP_LiquidContainer_Cylinder_C() : this(BuiltinUtils.AllocNativeUObject(BP_LiquidContainer_Cylinder_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D9B RID: 146843 RVA: 0x0092EC3C File Offset: 0x0092CE3C
		[NullableContext(1)]
		public BP_LiquidContainer_Cylinder_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LiquidContainer_Cylinder_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023D9C RID: 146844 RVA: 0x0092EC6F File Offset: 0x0092CE6F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023D9D RID: 146845 RVA: 0x0092EC83 File Offset: 0x0092CE83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023D9E RID: 146846 RVA: 0x0092EC98 File Offset: 0x0092CE98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023D9F RID: 146847 RVA: 0x0092ECAC File Offset: 0x0092CEAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023DA0 RID: 146848 RVA: 0x0092ECC4 File Offset: 0x0092CEC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LiquidContainer_Cylinder_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LiquidContainer_Cylinder_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LiquidContainer_Cylinder_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LiquidContainer_Cylinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023DA1 RID: 146849 RVA: 0x0092ED0C File Offset: 0x0092CF0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LiquidContainer_Cylinder_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LiquidContainer_Cylinder_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LiquidContainer_Cylinder_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LiquidContainer_Cylinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023DA2 RID: 146850 RVA: 0x0092ED54 File Offset: 0x0092CF54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_LiquidContainer_Cylinder_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LiquidContainer_Cylinder_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LiquidContainer_Cylinder_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LiquidContainer_Cylinder_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023DA3 RID: 146851 RVA: 0x0092ED9C File Offset: 0x0092CF9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_LiquidContainer_Cylinder_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LiquidContainer_Cylinder_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LiquidContainer_Cylinder_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LiquidContainer_Cylinder_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023DA4 RID: 146852 RVA: 0x0092EDE3 File Offset: 0x0092CFE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06023DA5 RID: 146853 RVA: 0x0092EDF7 File Offset: 0x0092CFF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023DA6 RID: 146854 RVA: 0x0092EE0C File Offset: 0x0092D00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06023DA7 RID: 146855 RVA: 0x0092EE20 File Offset: 0x0092D020
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LiquidContainer_Cylinder_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023DA8 RID: 146856 RVA: 0x0092EE35 File Offset: 0x0092D035
		protected BP_LiquidContainer_Cylinder_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BAD RID: 72621
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LiquidContainer/BP_LiquidContainer_Cylinder.BP_LiquidContainer_Cylinder_C";

		// Token: 0x04011BAE RID: 72622
		private static IntPtr _ClassPtr;

		// Token: 0x04011BAF RID: 72623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BB0 RID: 72624
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011BB1 RID: 72625
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011BB2 RID: 72626
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011BB3 RID: 72627
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011BB4 RID: 72628
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x04011BB5 RID: 72629
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009EAD RID: 40621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031786 RID: 202630
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EAE RID: 40622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031787 RID: 202631
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
