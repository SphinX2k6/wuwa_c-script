using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor
{
	// Token: 0x02003C3A RID: 15418
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Vehicle.BP_PhysicsActor_Vehicle_C")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1456)]
	public class BP_PhysicsActor_Vehicle_C : AKuroPhysicActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602377E RID: 145278 RVA: 0x00924B63 File Offset: 0x00922D63
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsActor_Vehicle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Vehicle.BP_PhysicsActor_Vehicle_C");
			}
			return BP_PhysicsActor_Vehicle_C._ClassPtr;
		}

		// Token: 0x0602377F RID: 145279 RVA: 0x00924B88 File Offset: 0x00922D88
		public BP_PhysicsActor_Vehicle_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_Vehicle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023780 RID: 145280 RVA: 0x00924BB0 File Offset: 0x00922DB0
		[NullableContext(1)]
		public BP_PhysicsActor_Vehicle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_Vehicle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x06023781 RID: 145281 RVA: 0x00924BE3 File Offset: 0x00922DE3
		// (set) Token: 0x06023782 RID: 145282 RVA: 0x00924BF7 File Offset: 0x00922DF7
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Vehicle_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Vehicle_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06023783 RID: 145283 RVA: 0x00924C0C File Offset: 0x00922E0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_Vehicle_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06023784 RID: 145284 RVA: 0x00924C20 File Offset: 0x00922E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_Vehicle_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023785 RID: 145285 RVA: 0x00924C35 File Offset: 0x00922E35
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_Vehicle_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06023786 RID: 145286 RVA: 0x00924C49 File Offset: 0x00922E49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_Vehicle_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023787 RID: 145287 RVA: 0x00924C5E File Offset: 0x00922E5E
		protected BP_PhysicsActor_Vehicle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011827 RID: 71719
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Vehicle.BP_PhysicsActor_Vehicle_C";

		// Token: 0x04011828 RID: 71720
		private static IntPtr _ClassPtr;

		// Token: 0x04011829 RID: 71721
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401182A RID: 71722
		internal static int __PropertyOffset_1;

		// Token: 0x0401182B RID: 71723
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x0401182C RID: 71724
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;
	}
}
