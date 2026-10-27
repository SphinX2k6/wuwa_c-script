using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor
{
	// Token: 0x02003C39 RID: 15417
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_PC_Mobile.BP_PhysicsActor_PC_Mobile_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_PhysicsActor_PC_Mobile_C : BP_PhysicsActor_Parent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023774 RID: 145268 RVA: 0x00924A5D File Offset: 0x00922C5D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsActor_PC_Mobile_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_PC_Mobile.BP_PhysicsActor_PC_Mobile_C");
			}
			return BP_PhysicsActor_PC_Mobile_C._ClassPtr;
		}

		// Token: 0x06023775 RID: 145269 RVA: 0x00924A84 File Offset: 0x00922C84
		public BP_PhysicsActor_PC_Mobile_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_PC_Mobile_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023776 RID: 145270 RVA: 0x00924AAC File Offset: 0x00922CAC
		[NullableContext(1)]
		public BP_PhysicsActor_PC_Mobile_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_PC_Mobile_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x06023777 RID: 145271 RVA: 0x00924ADF File Offset: 0x00922CDF
		// (set) Token: 0x06023778 RID: 145272 RVA: 0x00924AF3 File Offset: 0x00922CF3
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_PC_Mobile_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_PC_Mobile_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06023779 RID: 145273 RVA: 0x00924B08 File Offset: 0x00922D08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_PC_Mobile_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x0602377A RID: 145274 RVA: 0x00924B1C File Offset: 0x00922D1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_PC_Mobile_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602377B RID: 145275 RVA: 0x00924B31 File Offset: 0x00922D31
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_PC_Mobile_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x0602377C RID: 145276 RVA: 0x00924B45 File Offset: 0x00922D45
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_PC_Mobile_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602377D RID: 145277 RVA: 0x00924B5A File Offset: 0x00922D5A
		protected BP_PhysicsActor_PC_Mobile_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011821 RID: 71713
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_PC_Mobile.BP_PhysicsActor_PC_Mobile_C";

		// Token: 0x04011822 RID: 71714
		private static IntPtr _ClassPtr;

		// Token: 0x04011823 RID: 71715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011824 RID: 71716
		internal static int __PropertyOffset_1;

		// Token: 0x04011825 RID: 71717
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x04011826 RID: 71718
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;
	}
}
