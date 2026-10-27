using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LongGrass
{
	// Token: 0x02003CF4 RID: 15604
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LongGrass/BP_WeaponEnvReadback.BP_WeaponEnvReadback_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class BP_WeaponEnvReadback_C : AKuroCSReadback, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025359 RID: 152409 RVA: 0x009541C4 File Offset: 0x009523C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WeaponEnvReadback_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LongGrass/BP_WeaponEnvReadback.BP_WeaponEnvReadback_C");
			}
			return BP_WeaponEnvReadback_C._ClassPtr;
		}

		// Token: 0x0602535A RID: 152410 RVA: 0x009541E8 File Offset: 0x009523E8
		public BP_WeaponEnvReadback_C() : this(BuiltinUtils.AllocNativeUObject(BP_WeaponEnvReadback_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602535B RID: 152411 RVA: 0x00954210 File Offset: 0x00952410
		[NullableContext(1)]
		public BP_WeaponEnvReadback_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WeaponEnvReadback_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602535C RID: 152412 RVA: 0x00954243 File Offset: 0x00952443
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvReadback_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602535D RID: 152413 RVA: 0x00954257 File Offset: 0x00952457
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponEnvReadback_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602535E RID: 152414 RVA: 0x0095426C File Offset: 0x0095246C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_WeaponEnvReadback_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_WeaponEnvReadback_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WeaponEnvReadback_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvReadback_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponEnvReadback_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602535F RID: 152415 RVA: 0x009542B8 File Offset: 0x009524B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_WeaponEnvReadback_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_WeaponEnvReadback_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WeaponEnvReadback_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponEnvReadback_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponEnvReadback_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025360 RID: 152416 RVA: 0x00954304 File Offset: 0x00952504
		protected BP_WeaponEnvReadback_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012894 RID: 75924
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LongGrass/BP_WeaponEnvReadback.BP_WeaponEnvReadback_C";

		// Token: 0x04012895 RID: 75925
		private static IntPtr _ClassPtr;

		// Token: 0x04012896 RID: 75926
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012897 RID: 75927
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012898 RID: 75928
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009FCF RID: 40911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031A47 RID: 203335
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
