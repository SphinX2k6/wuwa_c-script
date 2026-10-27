using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight
{
	// Token: 0x02003F4F RID: 16207
	[UnrealObjectPath("/Game/Aki/Data/Fight/BP_BulletHitWorldEntityBridge.BP_BulletHitWorldEntityBridge_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_BulletHitWorldEntityBridge_C : UBulletHitWorldEntityBridge, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602945A RID: 169050 RVA: 0x009BFE96 File Offset: 0x009BE096
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BulletHitWorldEntityBridge_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/BP_BulletHitWorldEntityBridge.BP_BulletHitWorldEntityBridge_C");
			}
			return BP_BulletHitWorldEntityBridge_C._ClassPtr;
		}

		// Token: 0x0602945B RID: 169051 RVA: 0x009BFEBC File Offset: 0x009BE0BC
		public BP_BulletHitWorldEntityBridge_C() : this(BuiltinUtils.AllocNativeUObject(BP_BulletHitWorldEntityBridge_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602945C RID: 169052 RVA: 0x009BFEE4 File Offset: 0x009BE0E4
		[NullableContext(1)]
		public BP_BulletHitWorldEntityBridge_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BulletHitWorldEntityBridge_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602945D RID: 169053 RVA: 0x009BFF18 File Offset: 0x009BE118
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool HasTag(int EntityId, in FGameplayTag Tag)
		{
			BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__HasTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__HasTag_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602945E RID: 169054 RVA: 0x009BFF70 File Offset: 0x009BE170
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool HasTag_Implementation(int EntityId, in FGameplayTag Tag)
		{
			BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__HasTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__HasTag_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602945F RID: 169055 RVA: 0x009BFFCC File Offset: 0x009BE1CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override int GetCampRelationship(int Camp1, int Camp2)
		{
			BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Camp1 = Camp1;
			ptr->Camp2 = Camp2;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06029460 RID: 169056 RVA: 0x009C0020 File Offset: 0x009BE220
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetCampRelationship_Implementation(int Camp1, int Camp2)
		{
			BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Camp1 = Camp1;
			ptr->Camp2 = Camp2;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06029461 RID: 169057 RVA: 0x009C0074 File Offset: 0x009BE274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override int GetCamp(int EntityId)
		{
			BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__GetCamp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__GetCamp_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06029462 RID: 169058 RVA: 0x009C00C0 File Offset: 0x009BE2C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetCamp_Implementation(int EntityId)
		{
			BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__GetCamp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__GetCamp_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06029463 RID: 169059 RVA: 0x009C010D File Offset: 0x009BE30D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void NotifyExistedOperationList()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__NotifyExistedOperationList_NativeFunctionPtr, null);
		}

		// Token: 0x06029464 RID: 169060 RVA: 0x009C0121 File Offset: 0x009BE321
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void NotifyExistedOperationList_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__NotifyExistedOperationList_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029465 RID: 169061 RVA: 0x009C0138 File Offset: 0x009BE338
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void NotifyExistedImmediatelyOperation(in FBulletHitWorldEntityOperation Operation)
		{
			BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_NativeFunctionPtr, (void*)ptr, 1);
			if (Operation != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBulletHitWorldEntityOperation.StaticStruct(), &ptr->Operation, Operation.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029466 RID: 169062 RVA: 0x009C019C File Offset: 0x009BE39C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void NotifyExistedImmediatelyOperation_Implementation(in FBulletHitWorldEntityOperation Operation)
		{
			BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_NativeFunctionPtr, (void*)ptr, 1);
			if (Operation != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBulletHitWorldEntityOperation.StaticStruct(), &ptr->Operation, Operation.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029467 RID: 169063 RVA: 0x009C0200 File Offset: 0x009BE400
		protected BP_BulletHitWorldEntityBridge_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015237 RID: 86583
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/BP_BulletHitWorldEntityBridge.BP_BulletHitWorldEntityBridge_C";

		// Token: 0x04015238 RID: 86584
		private static IntPtr _ClassPtr;

		// Token: 0x04015239 RID: 86585
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401523A RID: 86586
		private static IntPtr __HasTag_NativeFunctionPtr;

		// Token: 0x0401523B RID: 86587
		private static IntPtr __GetCampRelationship_NativeFunctionPtr;

		// Token: 0x0401523C RID: 86588
		private static IntPtr __GetCamp_NativeFunctionPtr;

		// Token: 0x0401523D RID: 86589
		private static IntPtr __NotifyExistedOperationList_NativeFunctionPtr;

		// Token: 0x0401523E RID: 86590
		private static IntPtr __NotifyExistedImmediatelyOperation_NativeFunctionPtr;

		// Token: 0x0200A2E0 RID: 41696
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected new ref struct __HasTag_FunctionParams
		{
			// Token: 0x04032029 RID: 204841
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0403202A RID: 204842
			[FieldOffset(4)]
			public FGameplayTag Tag;

			// Token: 0x0403202B RID: 204843
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200A2E1 RID: 41697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __GetCampRelationship_FunctionParams
		{
			// Token: 0x0403202C RID: 204844
			[FieldOffset(0)]
			public int Camp1;

			// Token: 0x0403202D RID: 204845
			[FieldOffset(4)]
			public int Camp2;

			// Token: 0x0403202E RID: 204846
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x0200A2E2 RID: 41698
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected new ref struct __GetCamp_FunctionParams
		{
			// Token: 0x0403202F RID: 204847
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04032030 RID: 204848
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x0200A2E3 RID: 41699
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected new ref struct __NotifyExistedImmediatelyOperation_FunctionParams
		{
			// Token: 0x04032031 RID: 204849
			[FieldOffset(0)]
			public byte Operation;
		}
	}
}
