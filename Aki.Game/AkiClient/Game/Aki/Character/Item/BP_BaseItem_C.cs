using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.CreatureTools;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Item
{
	// Token: 0x02004258 RID: 16984
	[UnrealObjectPath("/Game/Aki/Character/Item/BP_BaseItem.BP_BaseItem_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1100)]
	public class BP_BaseItem_C : __TsBaseItem_InheritProxy, IUnrealUObject, IUnrealObject, IBPI_CreatureInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602C041 RID: 180289 RVA: 0x00A11DE1 File Offset: 0x00A0FFE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseItem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Item/BP_BaseItem.BP_BaseItem_C");
			}
			return BP_BaseItem_C._ClassPtr;
		}

		// Token: 0x0602C042 RID: 180290 RVA: 0x00A11E08 File Offset: 0x00A10008
		public BP_BaseItem_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseItem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C043 RID: 180291 RVA: 0x00A11E30 File Offset: 0x00A10030
		[NullableContext(1)]
		public BP_BaseItem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseItem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D56 RID: 27990
		// (get) Token: 0x0602C044 RID: 180292 RVA: 0x00A11E63 File Offset: 0x00A10063
		// (set) Token: 0x0602C045 RID: 180293 RVA: 0x00A11E77 File Offset: 0x00A10077
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseItem_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseItem_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006D57 RID: 27991
		// (get) Token: 0x0602C046 RID: 180294 RVA: 0x00A11E8C File Offset: 0x00A1008C
		// (set) Token: 0x0602C047 RID: 180295 RVA: 0x00A11EA0 File Offset: 0x00A100A0
		[Nullable(2)]
		public unsafe USceneComponent Scene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseItem_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseItem_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006D58 RID: 27992
		// (get) Token: 0x0602C048 RID: 180296 RVA: 0x00A11EB5 File Offset: 0x00A100B5
		// (set) Token: 0x0602C049 RID: 180297 RVA: 0x00A11EC5 File Offset: 0x00A100C5
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseItem_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseItem_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602C04A RID: 180298 RVA: 0x00A11ED8 File Offset: 0x00A100D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetEntityId()
		{
			BP_BaseItem_C.__GetEntityId_FunctionParams* ptr = stackalloc BP_BaseItem_C.__GetEntityId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseItem_C.__GetEntityId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseItem_C.__GetEntityId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseItem_C.__GetEntityId_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C04B RID: 180299 RVA: 0x00A11F20 File Offset: 0x00A10120
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyEntityId(int EntityId)
		{
			BP_BaseItem_C.__ApplyEntityId_FunctionParams* ptr = stackalloc BP_BaseItem_C.__ApplyEntityId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseItem_C.__ApplyEntityId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseItem_C.__ApplyEntityId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseItem_C.__ApplyEntityId_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C04C RID: 180300 RVA: 0x00A11F66 File Offset: 0x00A10166
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseItem_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602C04D RID: 180301 RVA: 0x00A11F7A File Offset: 0x00A1017A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseItem_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602C04E RID: 180302 RVA: 0x00A11F8F File Offset: 0x00A1018F
		protected BP_BaseItem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016FE3 RID: 94179
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Item/BP_BaseItem.BP_BaseItem_C";

		// Token: 0x04016FE4 RID: 94180
		private static IntPtr _ClassPtr;

		// Token: 0x04016FE5 RID: 94181
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016FE6 RID: 94182
		internal static int __PropertyOffset_1;

		// Token: 0x04016FE7 RID: 94183
		internal static int __PropertyOffset_2;

		// Token: 0x04016FE8 RID: 94184
		internal static int __PropertyOffset_3;

		// Token: 0x04016FE9 RID: 94185
		private static IntPtr __GetEntityId_NativeFunctionPtr;

		// Token: 0x04016FEA RID: 94186
		private static IntPtr __ApplyEntityId_NativeFunctionPtr;

		// Token: 0x04016FEB RID: 94187
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A5B2 RID: 42418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetEntityId_FunctionParams
		{
			// Token: 0x0403244A RID: 205898
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x0200A5B3 RID: 42419
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplyEntityId_FunctionParams
		{
			// Token: 0x0403244B RID: 205899
			[FieldOffset(0)]
			public int EntityId;
		}
	}
}
