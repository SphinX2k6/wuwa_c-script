using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SwingInteraction
{
	// Token: 0x02003AC4 RID: 15044
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingNPC.BP_SwingNPC_C")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1480)]
	public class BP_SwingNPC_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020619 RID: 132633 RVA: 0x008D1057 File Offset: 0x008CF257
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SwingNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingNPC.BP_SwingNPC_C");
			}
			return BP_SwingNPC_C._ClassPtr;
		}

		// Token: 0x0602061A RID: 132634 RVA: 0x008D107C File Offset: 0x008CF27C
		public BP_SwingNPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_SwingNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602061B RID: 132635 RVA: 0x008D10A4 File Offset: 0x008CF2A4
		[NullableContext(1)]
		public BP_SwingNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SwingNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0602061C RID: 132636 RVA: 0x008D10D7 File Offset: 0x008CF2D7
		// (set) Token: 0x0602061D RID: 132637 RVA: 0x008D10EB File Offset: 0x008CF2EB
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingNPC_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingNPC_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0602061E RID: 132638 RVA: 0x008D1100 File Offset: 0x008CF300
		// (set) Token: 0x0602061F RID: 132639 RVA: 0x008D1114 File Offset: 0x008CF314
		public unsafe UPhysicsConstraintComponent PhysicsConstraint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingNPC_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingNPC_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x06020620 RID: 132640 RVA: 0x008D1129 File Offset: 0x008CF329
		// (set) Token: 0x06020621 RID: 132641 RVA: 0x008D113D File Offset: 0x008CF33D
		public unsafe UStaticMeshComponent SwingNPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingNPC_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingNPC_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x06020622 RID: 132642 RVA: 0x008D1152 File Offset: 0x008CF352
		// (set) Token: 0x06020623 RID: 132643 RVA: 0x008D1166 File Offset: 0x008CF366
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingNPC_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingNPC_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x06020624 RID: 132644 RVA: 0x008D117B File Offset: 0x008CF37B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingNPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020625 RID: 132645 RVA: 0x008D118F File Offset: 0x008CF38F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingNPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020626 RID: 132646 RVA: 0x008D11A4 File Offset: 0x008CF3A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingNPC_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06020627 RID: 132647 RVA: 0x008D11B8 File Offset: 0x008CF3B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingNPC_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020628 RID: 132648 RVA: 0x008D11CD File Offset: 0x008CF3CD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingNPC_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06020629 RID: 132649 RVA: 0x008D11E1 File Offset: 0x008CF3E1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingNPC_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602062A RID: 132650 RVA: 0x008D11F6 File Offset: 0x008CF3F6
		protected BP_SwingNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAB7 RID: 64183
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingNPC.BP_SwingNPC_C";

		// Token: 0x0400FAB8 RID: 64184
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAB9 RID: 64185
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FABA RID: 64186
		internal static int __PropertyOffset_1;

		// Token: 0x0400FABB RID: 64187
		internal static int __PropertyOffset_2;

		// Token: 0x0400FABC RID: 64188
		internal static int __PropertyOffset_3;

		// Token: 0x0400FABD RID: 64189
		internal static int __PropertyOffset_4;

		// Token: 0x0400FABE RID: 64190
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FABF RID: 64191
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400FAC0 RID: 64192
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;
	}
}
