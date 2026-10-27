using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SwingInteraction
{
	// Token: 0x02003AC2 RID: 15042
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingChair.BP_SwingChair_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1488)]
	public class BP_SwingChair_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602059B RID: 132507 RVA: 0x008D039E File Offset: 0x008CE59E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SwingChair_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingChair.BP_SwingChair_C");
			}
			return BP_SwingChair_C._ClassPtr;
		}

		// Token: 0x0602059C RID: 132508 RVA: 0x008D03C4 File Offset: 0x008CE5C4
		public BP_SwingChair_C() : this(BuiltinUtils.AllocNativeUObject(BP_SwingChair_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602059D RID: 132509 RVA: 0x008D03EC File Offset: 0x008CE5EC
		[NullableContext(1)]
		public BP_SwingChair_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SwingChair_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x0602059E RID: 132510 RVA: 0x008D041F File Offset: 0x008CE61F
		// (set) Token: 0x0602059F RID: 132511 RVA: 0x008D0433 File Offset: 0x008CE633
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x060205A0 RID: 132512 RVA: 0x008D0448 File Offset: 0x008CE648
		// (set) Token: 0x060205A1 RID: 132513 RVA: 0x008D045C File Offset: 0x008CE65C
		public unsafe UPhysicsConstraintComponent PhysicsConstraint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x060205A2 RID: 132514 RVA: 0x008D0471 File Offset: 0x008CE671
		// (set) Token: 0x060205A3 RID: 132515 RVA: 0x008D0485 File Offset: 0x008CE685
		public unsafe UStaticMeshComponent Dizuo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x060205A4 RID: 132516 RVA: 0x008D049A File Offset: 0x008CE69A
		// (set) Token: 0x060205A5 RID: 132517 RVA: 0x008D04AE File Offset: 0x008CE6AE
		public unsafe UStaticMeshComponent Yizi
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x060205A6 RID: 132518 RVA: 0x008D04C3 File Offset: 0x008CE6C3
		// (set) Token: 0x060205A7 RID: 132519 RVA: 0x008D04D7 File Offset: 0x008CE6D7
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SwingChair_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x060205A8 RID: 132520 RVA: 0x008D04EC File Offset: 0x008CE6EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingChair_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060205A9 RID: 132521 RVA: 0x008D0500 File Offset: 0x008CE700
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingChair_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060205AA RID: 132522 RVA: 0x008D0515 File Offset: 0x008CE715
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingChair_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x060205AB RID: 132523 RVA: 0x008D0529 File Offset: 0x008CE729
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingChair_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060205AC RID: 132524 RVA: 0x008D053E File Offset: 0x008CE73E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SwingChair_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x060205AD RID: 132525 RVA: 0x008D0552 File Offset: 0x008CE752
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SwingChair_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060205AE RID: 132526 RVA: 0x008D0567 File Offset: 0x008CE767
		protected BP_SwingChair_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA6E RID: 64110
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_SwingChair.BP_SwingChair_C";

		// Token: 0x0400FA6F RID: 64111
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA70 RID: 64112
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA71 RID: 64113
		internal static int __PropertyOffset_1;

		// Token: 0x0400FA72 RID: 64114
		internal static int __PropertyOffset_2;

		// Token: 0x0400FA73 RID: 64115
		internal static int __PropertyOffset_3;

		// Token: 0x0400FA74 RID: 64116
		internal static int __PropertyOffset_4;

		// Token: 0x0400FA75 RID: 64117
		internal static int __PropertyOffset_5;

		// Token: 0x0400FA76 RID: 64118
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FA77 RID: 64119
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400FA78 RID: 64120
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;
	}
}
