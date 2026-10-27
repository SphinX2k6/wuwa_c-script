using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor
{
	// Token: 0x02003C36 RID: 15414
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor.BP_PhysicsActor_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_PhysicsActor_C : BP_PhysicsActor_Parent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602374F RID: 145231 RVA: 0x0092467B File Offset: 0x0092287B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor.BP_PhysicsActor_C");
			}
			return BP_PhysicsActor_C._ClassPtr;
		}

		// Token: 0x06023750 RID: 145232 RVA: 0x009246A0 File Offset: 0x009228A0
		public BP_PhysicsActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023751 RID: 145233 RVA: 0x009246C8 File Offset: 0x009228C8
		[NullableContext(1)]
		public BP_PhysicsActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x06023752 RID: 145234 RVA: 0x009246FB File Offset: 0x009228FB
		// (set) Token: 0x06023753 RID: 145235 RVA: 0x0092470F File Offset: 0x0092290F
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06023754 RID: 145236 RVA: 0x00924724 File Offset: 0x00922924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06023755 RID: 145237 RVA: 0x00924738 File Offset: 0x00922938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023756 RID: 145238 RVA: 0x0092474D File Offset: 0x0092294D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06023757 RID: 145239 RVA: 0x00924761 File Offset: 0x00922961
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023758 RID: 145240 RVA: 0x00924776 File Offset: 0x00922976
		protected BP_PhysicsActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401180B RID: 71691
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor.BP_PhysicsActor_C";

		// Token: 0x0401180C RID: 71692
		private static IntPtr _ClassPtr;

		// Token: 0x0401180D RID: 71693
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401180E RID: 71694
		internal static int __PropertyOffset_1;

		// Token: 0x0401180F RID: 71695
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x04011810 RID: 71696
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;
	}
}
