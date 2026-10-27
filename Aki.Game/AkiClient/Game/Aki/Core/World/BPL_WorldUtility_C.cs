using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.AI.Struct;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.Map.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.World
{
	// Token: 0x02003FE4 RID: 16356
	[UnrealObjectPath("/Game/Aki/Core/World/BPL_WorldUtility.BPL_WorldUtility_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_WorldUtility_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029E4C RID: 171596 RVA: 0x009CF51A File Offset: 0x009CD71A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_WorldUtility_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/World/BPL_WorldUtility.BPL_WorldUtility_C");
			}
			return BPL_WorldUtility_C._ClassPtr;
		}

		// Token: 0x06029E4D RID: 171597 RVA: 0x009CF540 File Offset: 0x009CD740
		public BPL_WorldUtility_C() : this(BuiltinUtils.AllocNativeUObject(BPL_WorldUtility_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029E4E RID: 171598 RVA: 0x009CF568 File Offset: 0x009CD768
		[NullableContext(1)]
		public BPL_WorldUtility_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_WorldUtility_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06029E4F RID: 171599 RVA: 0x009CF59C File Offset: 0x009CD79C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadAiConfig(FName RoleName, UObject __WorldContext, ref bool Exist, ref SAIConfig Out_Row)
		{
			BPL_WorldUtility_C.StaticClass();
			BPL_WorldUtility_C.__LoadAiConfig_FunctionParams* ptr = stackalloc BPL_WorldUtility_C.__LoadAiConfig_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(BPL_WorldUtility_C.__LoadAiConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_WorldUtility_C.__LoadAiConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RoleName = RoleName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Exist = Exist;
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SAIConfig.StaticStruct(), &ptr->Out_Row, Out_Row.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_WorldUtility_C._ClassDefaultObjectPtr, BPL_WorldUtility_C.__LoadAiConfig_NativeFunctionPtr, (void*)ptr);
			Exist = ptr->Exist;
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SAIConfig.StaticStruct(), Out_Row.NativePtr, &ptr->Out_Row, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_WorldUtility_C.__LoadAiConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E50 RID: 171600 RVA: 0x009CF66C File Offset: 0x009CD86C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetEntityProperty(FName RoleName, UObject __WorldContext, ref bool Exist, ref SEntityProperty Out_Row)
		{
			BPL_WorldUtility_C.StaticClass();
			BPL_WorldUtility_C.__GetEntityProperty_FunctionParams* ptr = stackalloc BPL_WorldUtility_C.__GetEntityProperty_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(BPL_WorldUtility_C.__GetEntityProperty_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_WorldUtility_C.__GetEntityProperty_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RoleName = RoleName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Exist = Exist;
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEntityProperty.StaticStruct(), &ptr->Out_Row, Out_Row.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_WorldUtility_C._ClassDefaultObjectPtr, BPL_WorldUtility_C.__GetEntityProperty_NativeFunctionPtr, (void*)ptr);
			Exist = ptr->Exist;
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEntityProperty.StaticStruct(), Out_Row.NativePtr, &ptr->Out_Row, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_WorldUtility_C.__GetEntityProperty_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E51 RID: 171601 RVA: 0x009CF73C File Offset: 0x009CD93C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetMapTableByName(FName RowName, UObject __WorldContext, ref bool Exist, ref SMapConfig Out_Row)
		{
			BPL_WorldUtility_C.StaticClass();
			BPL_WorldUtility_C.__GetMapTableByName_FunctionParams* ptr = stackalloc BPL_WorldUtility_C.__GetMapTableByName_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BPL_WorldUtility_C.__GetMapTableByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_WorldUtility_C.__GetMapTableByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RowName = RowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Exist = Exist;
			ptr->Out_Row = Out_Row;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_WorldUtility_C._ClassDefaultObjectPtr, BPL_WorldUtility_C.__GetMapTableByName_NativeFunctionPtr, (void*)ptr);
			Exist = ptr->Exist;
			Out_Row = ptr->Out_Row;
		}

		// Token: 0x06029E52 RID: 171602 RVA: 0x009CF7C8 File Offset: 0x009CD9C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetModelTableByName(FName RowName, UObject __WorldContext, ref bool Exist, ref SModelConfig Out_Row)
		{
			BPL_WorldUtility_C.StaticClass();
			BPL_WorldUtility_C.__GetModelTableByName_FunctionParams* ptr = stackalloc BPL_WorldUtility_C.__GetModelTableByName_FunctionParams[(UIntPtr)2375] + 15L / (long)sizeof(BPL_WorldUtility_C.__GetModelTableByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_WorldUtility_C.__GetModelTableByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RowName = RowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Exist = Exist;
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SModelConfig.StaticStruct(), &ptr->Out_Row, Out_Row.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_WorldUtility_C._ClassDefaultObjectPtr, BPL_WorldUtility_C.__GetModelTableByName_NativeFunctionPtr, (void*)ptr);
			Exist = ptr->Exist;
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SModelConfig.StaticStruct(), Out_Row.NativePtr, &ptr->Out_Row, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_WorldUtility_C.__GetModelTableByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E53 RID: 171603 RVA: 0x009CF898 File Offset: 0x009CDA98
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetEntityTableByName(FName RowName, UObject __WorldContext, ref bool Exist, ref SEntityConfig Out_Row)
		{
			BPL_WorldUtility_C.StaticClass();
			BPL_WorldUtility_C.__GetEntityTableByName_FunctionParams* ptr = stackalloc BPL_WorldUtility_C.__GetEntityTableByName_FunctionParams[(UIntPtr)1399] + 15L / (long)sizeof(BPL_WorldUtility_C.__GetEntityTableByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_WorldUtility_C.__GetEntityTableByName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RowName = RowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Exist = Exist;
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEntityConfig.StaticStruct(), &ptr->Out_Row, Out_Row.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_WorldUtility_C._ClassDefaultObjectPtr, BPL_WorldUtility_C.__GetEntityTableByName_NativeFunctionPtr, (void*)ptr);
			Exist = ptr->Exist;
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEntityConfig.StaticStruct(), Out_Row.NativePtr, &ptr->Out_Row, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_WorldUtility_C.__GetEntityTableByName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E54 RID: 171604 RVA: 0x009CF965 File Offset: 0x009CDB65
		protected BPL_WorldUtility_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015841 RID: 88129
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/World/BPL_WorldUtility.BPL_WorldUtility_C";

		// Token: 0x04015842 RID: 88130
		private static IntPtr _ClassPtr;

		// Token: 0x04015843 RID: 88131
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015844 RID: 88132
		private static IntPtr __LoadAiConfig_NativeFunctionPtr;

		// Token: 0x04015845 RID: 88133
		private static IntPtr __GetEntityProperty_NativeFunctionPtr;

		// Token: 0x04015846 RID: 88134
		private static IntPtr __GetMapTableByName_NativeFunctionPtr;

		// Token: 0x04015847 RID: 88135
		private static IntPtr __GetModelTableByName_NativeFunctionPtr;

		// Token: 0x04015848 RID: 88136
		private static IntPtr __GetEntityTableByName_NativeFunctionPtr;

		// Token: 0x0200A2F6 RID: 41718
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __LoadAiConfig_FunctionParams
		{
			// Token: 0x04032051 RID: 204881
			[FieldOffset(0)]
			public FName RoleName;

			// Token: 0x04032052 RID: 204882
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04032053 RID: 204883
			[FieldOffset(24)]
			public bool Exist;

			// Token: 0x04032054 RID: 204884
			[FieldOffset(32)]
			public byte Out_Row;
		}

		// Token: 0x0200A2F7 RID: 41719
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __GetEntityProperty_FunctionParams
		{
			// Token: 0x04032055 RID: 204885
			[FieldOffset(0)]
			public FName RoleName;

			// Token: 0x04032056 RID: 204886
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04032057 RID: 204887
			[FieldOffset(24)]
			public bool Exist;

			// Token: 0x04032058 RID: 204888
			[FieldOffset(32)]
			public byte Out_Row;
		}

		// Token: 0x0200A2F8 RID: 41720
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetMapTableByName_FunctionParams
		{
			// Token: 0x04032059 RID: 204889
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x0403205A RID: 204890
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0403205B RID: 204891
			[FieldOffset(24)]
			public bool Exist;

			// Token: 0x0403205C RID: 204892
			[FieldOffset(28)]
			public SMapConfig Out_Row;
		}

		// Token: 0x0200A2F9 RID: 41721
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2360)]
		protected ref struct __GetModelTableByName_FunctionParams
		{
			// Token: 0x0403205D RID: 204893
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x0403205E RID: 204894
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0403205F RID: 204895
			[FieldOffset(24)]
			public bool Exist;

			// Token: 0x04032060 RID: 204896
			[FieldOffset(32)]
			public byte Out_Row;
		}

		// Token: 0x0200A2FA RID: 41722
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1384)]
		protected ref struct __GetEntityTableByName_FunctionParams
		{
			// Token: 0x04032061 RID: 204897
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x04032062 RID: 204898
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04032063 RID: 204899
			[FieldOffset(24)]
			public bool Exist;

			// Token: 0x04032064 RID: 204900
			[FieldOffset(32)]
			public byte Out_Row;
		}
	}
}
