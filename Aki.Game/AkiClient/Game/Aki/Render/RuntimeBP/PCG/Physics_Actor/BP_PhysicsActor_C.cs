using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor
{
	// Token: 0x020030DF RID: 12511
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor.BP_PhysicsActor_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_PhysicsActor_C : BP_PhysicsActor_Parent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E3D0 RID: 123856 RVA: 0x0090ED13 File Offset: 0x0090CF13
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor.BP_PhysicsActor_C");
			}
			return BP_PhysicsActor_C._ClassPtr;
		}

		// Token: 0x0601E3D1 RID: 123857 RVA: 0x0090ED38 File Offset: 0x0090CF38
		public BP_PhysicsActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E3D2 RID: 123858 RVA: 0x0090ED60 File Offset: 0x0090CF60
		[NullableContext(1)]
		public BP_PhysicsActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0601E3D3 RID: 123859 RVA: 0x0090ED93 File Offset: 0x0090CF93
		// (set) Token: 0x0601E3D4 RID: 123860 RVA: 0x0090EDA7 File Offset: 0x0090CFA7
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_C.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x0601E3D5 RID: 123861 RVA: 0x0090EDBC File Offset: 0x0090CFBC
		[SkipLocalsInit]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3D6 RID: 123862 RVA: 0x0090EDD0 File Offset: 0x0090CFD0
		[SkipLocalsInit]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3D7 RID: 123863 RVA: 0x0090EDE4 File Offset: 0x0090CFE4
		[SkipLocalsInit]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3D8 RID: 123864 RVA: 0x0090EDF8 File Offset: 0x0090CFF8
		[SkipLocalsInit]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3D9 RID: 123865 RVA: 0x0090EE0C File Offset: 0x0090D00C
		protected BP_PhysicsActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010007 RID: 65543
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor.BP_PhysicsActor_C";

		// Token: 0x04010008 RID: 65544
		private static IntPtr _ClassPtr;

		// Token: 0x04010009 RID: 65545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401000A RID: 65546
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0401000B RID: 65547
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0401000C RID: 65548
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;
	}
}
