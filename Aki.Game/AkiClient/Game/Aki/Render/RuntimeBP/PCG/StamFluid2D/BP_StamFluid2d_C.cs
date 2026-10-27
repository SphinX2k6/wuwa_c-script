using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.StamFluid2D
{
	// Token: 0x02003BEA RID: 15338
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/StamFluid2D/BP_StamFluid2d.BP_StamFluid2d_C")]
	[UnrealStructLayout(2176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class BP_StamFluid2d_C : AStamFluidGPU2DActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022D1A RID: 142618 RVA: 0x00913055 File Offset: 0x00911255
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StamFluid2d_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/StamFluid2D/BP_StamFluid2d.BP_StamFluid2d_C");
			}
			return BP_StamFluid2d_C._ClassPtr;
		}

		// Token: 0x06022D1B RID: 142619 RVA: 0x0091307C File Offset: 0x0091127C
		public BP_StamFluid2d_C() : this(BuiltinUtils.AllocNativeUObject(BP_StamFluid2d_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022D1C RID: 142620 RVA: 0x009130A4 File Offset: 0x009112A4
		[NullableContext(1)]
		public BP_StamFluid2d_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StamFluid2d_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x06022D1D RID: 142621 RVA: 0x009130D7 File Offset: 0x009112D7
		// (set) Token: 0x06022D1E RID: 142622 RVA: 0x009130EB File Offset: 0x009112EB
		public unsafe UBoxComponent ActivationBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StamFluid2d_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StamFluid2d_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x06022D1F RID: 142623 RVA: 0x00913100 File Offset: 0x00911300
		// (set) Token: 0x06022D20 RID: 142624 RVA: 0x00913114 File Offset: 0x00911314
		public unsafe UBoxComponent InteractBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StamFluid2d_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StamFluid2d_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06022D21 RID: 142625 RVA: 0x00913129 File Offset: 0x00911329
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StamFluid2d_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022D22 RID: 142626 RVA: 0x0091313D File Offset: 0x0091133D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StamFluid2d_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022D23 RID: 142627 RVA: 0x00913154 File Offset: 0x00911354
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_StamFluid2d_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StamFluid2d_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StamFluid2d_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StamFluid2d_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StamFluid2d_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D24 RID: 142628 RVA: 0x0091319C File Offset: 0x0091139C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_StamFluid2d_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StamFluid2d_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StamFluid2d_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StamFluid2d_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StamFluid2d_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022D25 RID: 142629 RVA: 0x009131E4 File Offset: 0x009113E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_StamFluid2d_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_StamFluid2d_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_StamFluid2d_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StamFluid2d_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StamFluid2d_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D26 RID: 142630 RVA: 0x00913248 File Offset: 0x00911448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_StamFluid2d_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_StamFluid2d_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_StamFluid2d_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StamFluid2d_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StamFluid2d_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D27 RID: 142631 RVA: 0x00913294 File Offset: 0x00911494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_StamFluid2d_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_StamFluid2d_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_StamFluid2d_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StamFluid2d_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StamFluid2d_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022D28 RID: 142632 RVA: 0x009132E0 File Offset: 0x009114E0
		protected BP_StamFluid2d_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011215 RID: 70165
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/StamFluid2D/BP_StamFluid2d.BP_StamFluid2d_C";

		// Token: 0x04011216 RID: 70166
		private static IntPtr _ClassPtr;

		// Token: 0x04011217 RID: 70167
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011218 RID: 70168
		internal static int __PropertyOffset_1;

		// Token: 0x04011219 RID: 70169
		internal static int __PropertyOffset_2;

		// Token: 0x0401121A RID: 70170
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401121B RID: 70171
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401121C RID: 70172
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x0401121D RID: 70173
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009DD5 RID: 40405
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315D6 RID: 202198
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DD6 RID: 40406
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040315D7 RID: 202199
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040315D8 RID: 202200
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040315D9 RID: 202201
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009DD7 RID: 40407
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040315DA RID: 202202
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
