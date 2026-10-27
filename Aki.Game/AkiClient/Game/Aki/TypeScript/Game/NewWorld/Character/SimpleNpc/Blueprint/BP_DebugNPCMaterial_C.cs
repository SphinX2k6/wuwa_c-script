using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003A10 RID: 14864
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_DebugNPCMaterial.BP_DebugNPCMaterial_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class BP_DebugNPCMaterial_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F29D RID: 127645 RVA: 0x008AE6DD File Offset: 0x008AC8DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DebugNPCMaterial_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_DebugNPCMaterial.BP_DebugNPCMaterial_C");
			}
			return BP_DebugNPCMaterial_C._ClassPtr;
		}

		// Token: 0x0601F29E RID: 127646 RVA: 0x008AE704 File Offset: 0x008AC904
		public BP_DebugNPCMaterial_C() : this(BuiltinUtils.AllocNativeUObject(BP_DebugNPCMaterial_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F29F RID: 127647 RVA: 0x008AE72C File Offset: 0x008AC92C
		[NullableContext(1)]
		public BP_DebugNPCMaterial_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DebugNPCMaterial_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x0601F2A0 RID: 127648 RVA: 0x008AE75F File Offset: 0x008AC95F
		// (set) Token: 0x0601F2A1 RID: 127649 RVA: 0x008AE773 File Offset: 0x008AC973
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugNPCMaterial_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugNPCMaterial_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x0601F2A2 RID: 127650 RVA: 0x008AE788 File Offset: 0x008AC988
		// (set) Token: 0x0601F2A3 RID: 127651 RVA: 0x008AE79C File Offset: 0x008AC99C
		public unsafe AActor NPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugNPCMaterial_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugNPCMaterial_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x0601F2A4 RID: 127652 RVA: 0x008AE7B1 File Offset: 0x008AC9B1
		// (set) Token: 0x0601F2A5 RID: 127653 RVA: 0x008AE7C5 File Offset: 0x008AC9C5
		public unsafe PD_HolographicEffect_C Data
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_HolographicEffect_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugNPCMaterial_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugNPCMaterial_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x0601F2A6 RID: 127654 RVA: 0x008AE7DA File Offset: 0x008AC9DA
		// (set) Token: 0x0601F2A7 RID: 127655 RVA: 0x008AE7EE File Offset: 0x008AC9EE
		public unsafe BP_NPCMaterialController_C HolographicComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_NPCMaterialController_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugNPCMaterial_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DebugNPCMaterial_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0601F2A8 RID: 127656 RVA: 0x008AE803 File Offset: 0x008ACA03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Remove()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugNPCMaterial_C.__Remove_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2A9 RID: 127657 RVA: 0x008AE817 File Offset: 0x008ACA17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Add()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DebugNPCMaterial_C.__Add_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2AA RID: 127658 RVA: 0x008AE82B File Offset: 0x008ACA2B
		protected BP_DebugNPCMaterial_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EEC5 RID: 61125
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_DebugNPCMaterial.BP_DebugNPCMaterial_C";

		// Token: 0x0400EEC6 RID: 61126
		private static IntPtr _ClassPtr;

		// Token: 0x0400EEC7 RID: 61127
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EEC8 RID: 61128
		internal static int __PropertyOffset_0;

		// Token: 0x0400EEC9 RID: 61129
		internal static int __PropertyOffset_1;

		// Token: 0x0400EECA RID: 61130
		internal static int __PropertyOffset_2;

		// Token: 0x0400EECB RID: 61131
		internal static int __PropertyOffset_3;

		// Token: 0x0400EECC RID: 61132
		private static IntPtr __Remove_NativeFunctionPtr;

		// Token: 0x0400EECD RID: 61133
		private static IntPtr __Add_NativeFunctionPtr;
	}
}
