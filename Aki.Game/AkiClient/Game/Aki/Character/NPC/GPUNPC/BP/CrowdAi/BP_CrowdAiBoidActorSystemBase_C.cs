using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi
{
	// Token: 0x020032B3 RID: 12979
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiBoidActorSystemBase.BP_CrowdAiBoidActorSystemBase_C")]
	[UnrealStructLayout(2624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2616)]
	public class BP_CrowdAiBoidActorSystemBase_C : AKuroCrowdAiBoidActorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020BA4 RID: 134052 RVA: 0x0094DAFD File Offset: 0x0094BCFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CrowdAiBoidActorSystemBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiBoidActorSystemBase.BP_CrowdAiBoidActorSystemBase_C");
			}
			return BP_CrowdAiBoidActorSystemBase_C._ClassPtr;
		}

		// Token: 0x06020BA5 RID: 134053 RVA: 0x0094DB24 File Offset: 0x0094BD24
		public BP_CrowdAiBoidActorSystemBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_CrowdAiBoidActorSystemBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020BA6 RID: 134054 RVA: 0x0094DB4C File Offset: 0x0094BD4C
		[NullableContext(1)]
		public BP_CrowdAiBoidActorSystemBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CrowdAiBoidActorSystemBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x06020BA7 RID: 134055 RVA: 0x0094DB7F File Offset: 0x0094BD7F
		// (set) Token: 0x06020BA8 RID: 134056 RVA: 0x0094DB93 File Offset: 0x0094BD93
		[Nullable(2)]
		public unsafe GPUNPCData_C Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<GPUNPCData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CrowdAiBoidActorSystemBase_C.__PropertyOffset_Data);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CrowdAiBoidActorSystemBase_C.__PropertyOffset_Data, value);
			}
		}

		// Token: 0x06020BA9 RID: 134057 RVA: 0x0094DBA8 File Offset: 0x0094BDA8
		[SkipLocalsInit]
		public unsafe override bool InitGpuNpc()
		{
			BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams* ptr = stackalloc BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020BAA RID: 134058 RVA: 0x0094DBF0 File Offset: 0x0094BDF0
		[SkipLocalsInit]
		protected unsafe override bool InitGpuNpc_Implementation()
		{
			BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams* ptr = stackalloc BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CrowdAiBoidActorSystemBase_C.__InitGpuNpc_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020BAB RID: 134059 RVA: 0x0094DC35 File Offset: 0x0094BE35
		protected BP_CrowdAiBoidActorSystemBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B41 RID: 72513
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/BP_CrowdAiBoidActorSystemBase.BP_CrowdAiBoidActorSystemBase_C";

		// Token: 0x04011B42 RID: 72514
		private static IntPtr _ClassPtr;

		// Token: 0x04011B43 RID: 72515
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B44 RID: 72516
		internal static int __PropertyOffset_Data;

		// Token: 0x04011B45 RID: 72517
		private static IntPtr __InitGpuNpc_NativeFunctionPtr;

		// Token: 0x02008FB1 RID: 36785
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected new ref struct __InitGpuNpc_FunctionParams
		{
			// Token: 0x0402CD58 RID: 183640
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
