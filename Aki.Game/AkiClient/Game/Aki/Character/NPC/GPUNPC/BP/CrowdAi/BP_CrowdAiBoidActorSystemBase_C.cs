using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi
{
	// Token: 0x02004196 RID: 16790
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiBoidActorSystemBase.BP_CrowdAiBoidActorSystemBase_C")]
	[UnrealStructLayout(2624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2616)]
	public class BP_CrowdAiBoidActorSystemBase_C : AKuroCrowdAiBoidActorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B8F2 RID: 178418 RVA: 0x00A03E9C File Offset: 0x00A0209C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CrowdAiBoidActorSystemBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiBoidActorSystemBase.BP_CrowdAiBoidActorSystemBase_C");
			}
			return BP_CrowdAiBoidActorSystemBase_C._ClassPtr;
		}

		// Token: 0x0602B8F3 RID: 178419 RVA: 0x00A03EC0 File Offset: 0x00A020C0
		public BP_CrowdAiBoidActorSystemBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_CrowdAiBoidActorSystemBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B8F4 RID: 178420 RVA: 0x00A03EE8 File Offset: 0x00A020E8
		[NullableContext(1)]
		public BP_CrowdAiBoidActorSystemBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CrowdAiBoidActorSystemBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006BCF RID: 27599
		// (get) Token: 0x0602B8F5 RID: 178421 RVA: 0x00A03F1B File Offset: 0x00A0211B
		// (set) Token: 0x0602B8F6 RID: 178422 RVA: 0x00A03F2F File Offset: 0x00A0212F
		[Nullable(2)]
		public unsafe GPUNPCData_C Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<GPUNPCData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CrowdAiBoidActorSystemBase_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CrowdAiBoidActorSystemBase_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602B8F7 RID: 178423 RVA: 0x00A03F44 File Offset: 0x00A02144
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool InitGpuNpc()
		{
			BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams* ptr = stackalloc BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602B8F8 RID: 178424 RVA: 0x00A03F8C File Offset: 0x00A0218C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool InitGpuNpc_Implementation()
		{
			BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams* ptr = stackalloc BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602B8F9 RID: 178425 RVA: 0x00A03FD2 File Offset: 0x00A021D2
		protected BP_CrowdAiBoidActorSystemBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016AD7 RID: 92887
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiBoidActorSystemBase.BP_CrowdAiBoidActorSystemBase_C";

		// Token: 0x04016AD8 RID: 92888
		private static IntPtr _ClassPtr;

		// Token: 0x04016AD9 RID: 92889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016ADA RID: 92890
		internal static int __PropertyOffset_0;

		// Token: 0x04016ADB RID: 92891
		private static IntPtr __InitGpuNpc_NativeFunctionPtr;

		// Token: 0x0200A548 RID: 42312
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected new ref struct __InitGpuNpc_FunctionParams
		{
			// Token: 0x040323C6 RID: 205766
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
