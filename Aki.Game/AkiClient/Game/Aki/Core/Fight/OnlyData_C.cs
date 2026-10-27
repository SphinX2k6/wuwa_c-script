using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200400A RID: 16394
	[UnrealObjectPath("/Game/Aki/Core/Fight/OnlyData.OnlyData_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class OnlyData_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029FA4 RID: 171940 RVA: 0x009D25B8 File Offset: 0x009D07B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (OnlyData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/OnlyData.OnlyData_C");
			}
			return OnlyData_C._ClassPtr;
		}

		// Token: 0x06029FA5 RID: 171941 RVA: 0x009D25DC File Offset: 0x009D07DC
		public OnlyData_C() : this(BuiltinUtils.AllocNativeUObject(OnlyData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029FA6 RID: 171942 RVA: 0x009D2604 File Offset: 0x009D0804
		[NullableContext(1)]
		public OnlyData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(OnlyData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06029FA7 RID: 171943 RVA: 0x009D2638 File Offset: 0x009D0838
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetCommonNewBulletData([Nullable(1)] string DataName, UObject __WorldContext, ref bool isFind, ref SReBulletDataMain BulletData)
		{
			OnlyData_C.StaticClass();
			OnlyData_C.__GetCommonNewBulletData_FunctionParams* ptr = stackalloc OnlyData_C.__GetCommonNewBulletData_FunctionParams[(UIntPtr)4055] + 15L / (long)sizeof(OnlyData_C.__GetCommonNewBulletData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnlyData_C.__GetCommonNewBulletData_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->DataName), DataName);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->isFind = isFind;
			if (BulletData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMain.StaticStruct(), &ptr->BulletData, BulletData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(OnlyData_C._ClassDefaultObjectPtr, OnlyData_C.__GetCommonNewBulletData_NativeFunctionPtr, (void*)ptr);
			isFind = ptr->isFind;
			if (BulletData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMain.StaticStruct(), BulletData.NativePtr, &ptr->BulletData, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(OnlyData_C.__GetCommonNewBulletData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029FA8 RID: 171944 RVA: 0x009D270C File Offset: 0x009D090C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetCommonHitData([Nullable(1)] string DataName, UObject __WorldContext, ref bool isFind, ref SHitEffect HitData)
		{
			OnlyData_C.StaticClass();
			OnlyData_C.__GetCommonHitData_FunctionParams* ptr = stackalloc OnlyData_C.__GetCommonHitData_FunctionParams[(UIntPtr)391] + 15L / (long)sizeof(OnlyData_C.__GetCommonHitData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnlyData_C.__GetCommonHitData_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->DataName), DataName);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->isFind = isFind;
			if (HitData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitEffect.StaticStruct(), &ptr->HitData, HitData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(OnlyData_C._ClassDefaultObjectPtr, OnlyData_C.__GetCommonHitData_NativeFunctionPtr, (void*)ptr);
			isFind = ptr->isFind;
			if (HitData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitEffect.StaticStruct(), HitData.NativePtr, &ptr->HitData, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(OnlyData_C.__GetCommonHitData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029FA9 RID: 171945 RVA: 0x009D27E0 File Offset: 0x009D09E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetCommonBulletData([Nullable(1)] string DataName, UObject __WorldContext, ref bool isFind, ref SBulletDataMain BulletData)
		{
			OnlyData_C.StaticClass();
			OnlyData_C.__GetCommonBulletData_FunctionParams* ptr = stackalloc OnlyData_C.__GetCommonBulletData_FunctionParams[(UIntPtr)751] + 15L / (long)sizeof(OnlyData_C.__GetCommonBulletData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnlyData_C.__GetCommonBulletData_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->DataName), DataName);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->isFind = isFind;
			if (BulletData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataMain.StaticStruct(), &ptr->BulletData, BulletData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(OnlyData_C._ClassDefaultObjectPtr, OnlyData_C.__GetCommonBulletData_NativeFunctionPtr, (void*)ptr);
			isFind = ptr->isFind;
			if (BulletData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataMain.StaticStruct(), BulletData.NativePtr, &ptr->BulletData, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(OnlyData_C.__GetCommonBulletData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029FAA RID: 171946 RVA: 0x009D28B3 File Offset: 0x009D0AB3
		protected OnlyData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159DF RID: 88543
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/OnlyData.OnlyData_C";

		// Token: 0x040159E0 RID: 88544
		private static IntPtr _ClassPtr;

		// Token: 0x040159E1 RID: 88545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040159E2 RID: 88546
		private static IntPtr __GetCommonNewBulletData_NativeFunctionPtr;

		// Token: 0x040159E3 RID: 88547
		private static IntPtr __GetCommonHitData_NativeFunctionPtr;

		// Token: 0x040159E4 RID: 88548
		private static IntPtr __GetCommonBulletData_NativeFunctionPtr;

		// Token: 0x0200A31C RID: 41756
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4040)]
		protected ref struct __GetCommonNewBulletData_FunctionParams
		{
			// Token: 0x040320CF RID: 205007
			[FieldOffset(0)]
			public FString DataName;

			// Token: 0x040320D0 RID: 205008
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040320D1 RID: 205009
			[FieldOffset(24)]
			public bool isFind;

			// Token: 0x040320D2 RID: 205010
			[FieldOffset(32)]
			public byte BulletData;
		}

		// Token: 0x0200A31D RID: 41757
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 376)]
		protected ref struct __GetCommonHitData_FunctionParams
		{
			// Token: 0x040320D3 RID: 205011
			[FieldOffset(0)]
			public FString DataName;

			// Token: 0x040320D4 RID: 205012
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040320D5 RID: 205013
			[FieldOffset(24)]
			public bool isFind;

			// Token: 0x040320D6 RID: 205014
			[FieldOffset(28)]
			public byte HitData;
		}

		// Token: 0x0200A31E RID: 41758
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 736)]
		protected ref struct __GetCommonBulletData_FunctionParams
		{
			// Token: 0x040320D7 RID: 205015
			[FieldOffset(0)]
			public FString DataName;

			// Token: 0x040320D8 RID: 205016
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x040320D9 RID: 205017
			[FieldOffset(24)]
			public bool isFind;

			// Token: 0x040320DA RID: 205018
			[FieldOffset(32)]
			public byte BulletData;
		}
	}
}
