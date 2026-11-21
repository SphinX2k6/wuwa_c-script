using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight
{
	// Token: 0x020031F5 RID: 12789
	[UnrealObjectPath("/Game/Aki/Data/Fight/BP_BulletHitWorldEntityBridge.BP_BulletHitWorldEntityBridge_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_BulletHitWorldEntityBridge_C : UBulletHitWorldEntityBridge, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FD31 RID: 130353 RVA: 0x009369A6 File Offset: 0x00934BA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BulletHitWorldEntityBridge_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/BP_BulletHitWorldEntityBridge.BP_BulletHitWorldEntityBridge_C");
			}
			return BP_BulletHitWorldEntityBridge_C._ClassPtr;
		}

		// Token: 0x0601FD32 RID: 130354 RVA: 0x009369CC File Offset: 0x00934BCC
		public BP_BulletHitWorldEntityBridge_C() : this(BuiltinUtils.AllocNativeUObject(BP_BulletHitWorldEntityBridge_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FD33 RID: 130355 RVA: 0x009369F4 File Offset: 0x00934BF4
		[NullableContext(1)]
		public BP_BulletHitWorldEntityBridge_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BulletHitWorldEntityBridge_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FD34 RID: 130356 RVA: 0x00936A28 File Offset: 0x00934C28
		[SkipLocalsInit]
		public unsafe override bool HasTag(int EntityId, in FGameplayTag Tag)
		{
			BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__HasTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__HasTag_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FD35 RID: 130357 RVA: 0x00936A80 File Offset: 0x00934C80
		[SkipLocalsInit]
		protected unsafe virtual bool HasTag_Implementation(int EntityId, in FGameplayTag Tag)
		{
			BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__HasTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__HasTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__HasTag_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FD36 RID: 130358 RVA: 0x00936AD8 File Offset: 0x00934CD8
		[SkipLocalsInit]
		public unsafe override int GetCampRelationship(int Camp1, int Camp2)
		{
			BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Camp1 = Camp1;
			ptr->Camp2 = Camp2;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FD37 RID: 130359 RVA: 0x00936B2C File Offset: 0x00934D2C
		[SkipLocalsInit]
		protected unsafe virtual int GetCampRelationship_Implementation(int Camp1, int Camp2)
		{
			BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Camp1 = Camp1;
			ptr->Camp2 = Camp2;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__GetCampRelationship_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FD38 RID: 130360 RVA: 0x00936B80 File Offset: 0x00934D80
		[SkipLocalsInit]
		public unsafe override int GetCamp(int EntityId)
		{
			BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__GetCamp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__GetCamp_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FD39 RID: 130361 RVA: 0x00936BCC File Offset: 0x00934DCC
		[SkipLocalsInit]
		protected unsafe virtual int GetCamp_Implementation(int EntityId)
		{
			BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__GetCamp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__GetCamp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__GetCamp_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FD3A RID: 130362 RVA: 0x00936C18 File Offset: 0x00934E18
		[SkipLocalsInit]
		public override void NotifyExistedOperationList()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__NotifyExistedOperationList_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD3B RID: 130363 RVA: 0x00936C2C File Offset: 0x00934E2C
		[SkipLocalsInit]
		protected virtual void NotifyExistedOperationList_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__NotifyExistedOperationList_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD3C RID: 130364 RVA: 0x00936C40 File Offset: 0x00934E40
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601FD3D RID: 130365 RVA: 0x00936CA4 File Offset: 0x00934EA4
		[NullableContext(2)]
		[SkipLocalsInit]
		protected unsafe virtual void NotifyExistedImmediatelyOperation_Implementation(in FBulletHitWorldEntityOperation Operation)
		{
			BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams* ptr = stackalloc BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_NativeFunctionPtr, (void*)ptr, 1);
			if (Operation != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBulletHitWorldEntityOperation.StaticStruct(), &ptr->Operation, Operation.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BulletHitWorldEntityBridge_C.__NotifyExistedImmediatelyOperation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FD3E RID: 130366 RVA: 0x00936D07 File Offset: 0x00934F07
		protected BP_BulletHitWorldEntityBridge_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401114F RID: 69967
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/BP_BulletHitWorldEntityBridge.BP_BulletHitWorldEntityBridge_C";

		// Token: 0x04011150 RID: 69968
		private static IntPtr _ClassPtr;

		// Token: 0x04011151 RID: 69969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011152 RID: 69970
		private static IntPtr __HasTag_NativeFunctionPtr;

		// Token: 0x04011153 RID: 69971
		private static IntPtr __GetCampRelationship_NativeFunctionPtr;

		// Token: 0x04011154 RID: 69972
		private static IntPtr __GetCamp_NativeFunctionPtr;

		// Token: 0x04011155 RID: 69973
		private static IntPtr __NotifyExistedOperationList_NativeFunctionPtr;

		// Token: 0x04011156 RID: 69974
		private static IntPtr __NotifyExistedImmediatelyOperation_NativeFunctionPtr;

		// Token: 0x02008F28 RID: 36648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected new ref struct __HasTag_FunctionParams
		{
			// Token: 0x0402CC5F RID: 183391
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0402CC60 RID: 183392
			[FieldOffset(4)]
			public FGameplayTag Tag;

			// Token: 0x0402CC61 RID: 183393
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02008F29 RID: 36649
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __GetCampRelationship_FunctionParams
		{
			// Token: 0x0402CC62 RID: 183394
			[FieldOffset(0)]
			public int Camp1;

			// Token: 0x0402CC63 RID: 183395
			[FieldOffset(4)]
			public int Camp2;

			// Token: 0x0402CC64 RID: 183396
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x02008F2A RID: 36650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected new ref struct __GetCamp_FunctionParams
		{
			// Token: 0x0402CC65 RID: 183397
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0402CC66 RID: 183398
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02008F2B RID: 36651
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected new ref struct __NotifyExistedImmediatelyOperation_FunctionParams
		{
			// Token: 0x0402CC67 RID: 183399
			[FieldOffset(0)]
			public byte Operation;
		}
	}
}
