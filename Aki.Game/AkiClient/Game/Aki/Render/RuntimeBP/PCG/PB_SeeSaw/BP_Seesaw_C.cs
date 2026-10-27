using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PB_SeeSaw
{
	// Token: 0x02003C3C RID: 15420
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PB_SeeSaw/BP_Seesaw.BP_Seesaw_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1540)]
	public class BP_Seesaw_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023798 RID: 145304 RVA: 0x00924D88 File Offset: 0x00922F88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Seesaw_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PB_SeeSaw/BP_Seesaw.BP_Seesaw_C");
			}
			return BP_Seesaw_C._ClassPtr;
		}

		// Token: 0x06023799 RID: 145305 RVA: 0x00924DAC File Offset: 0x00922FAC
		public BP_Seesaw_C() : this(BuiltinUtils.AllocNativeUObject(BP_Seesaw_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602379A RID: 145306 RVA: 0x00924DD4 File Offset: 0x00922FD4
		[NullableContext(1)]
		public BP_Seesaw_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Seesaw_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x0602379B RID: 145307 RVA: 0x00924E07 File Offset: 0x00923007
		// (set) Token: 0x0602379C RID: 145308 RVA: 0x00924E1B File Offset: 0x0092301B
		public unsafe UStaticMeshComponent SM_Old_Box_27CM_T
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x0602379D RID: 145309 RVA: 0x00924E30 File Offset: 0x00923030
		// (set) Token: 0x0602379E RID: 145310 RVA: 0x00924E44 File Offset: 0x00923044
		public unsafe UStaticMeshComponent SM_Old_Box_27BM_T
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x0602379F RID: 145311 RVA: 0x00924E59 File Offset: 0x00923059
		// (set) Token: 0x060237A0 RID: 145312 RVA: 0x00924E6D File Offset: 0x0092306D
		public unsafe UPhysicsConstraintComponent Axis
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x060237A1 RID: 145313 RVA: 0x00924E82 File Offset: 0x00923082
		// (set) Token: 0x060237A2 RID: 145314 RVA: 0x00924E96 File Offset: 0x00923096
		public unsafe UStaticMeshComponent Base
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x060237A3 RID: 145315 RVA: 0x00924EAB File Offset: 0x009230AB
		// (set) Token: 0x060237A4 RID: 145316 RVA: 0x00924EBF File Offset: 0x009230BF
		public unsafe UStaticMeshComponent Board
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x060237A5 RID: 145317 RVA: 0x00924ED4 File Offset: 0x009230D4
		// (set) Token: 0x060237A6 RID: 145318 RVA: 0x00924EE8 File Offset: 0x009230E8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seesaw_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x060237A7 RID: 145319 RVA: 0x00924EFD File Offset: 0x009230FD
		// (set) Token: 0x060237A8 RID: 145320 RVA: 0x00924F0D File Offset: 0x0092310D
		public unsafe float MeshBoundRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x060237A9 RID: 145321 RVA: 0x00924F1E File Offset: 0x0092311E
		// (set) Token: 0x060237AA RID: 145322 RVA: 0x00924F32 File Offset: 0x00923132
		public unsafe FVectorDouble MeshPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x060237AB RID: 145323 RVA: 0x00924F47 File Offset: 0x00923147
		// (set) Token: 0x060237AC RID: 145324 RVA: 0x00924F57 File Offset: 0x00923157
		public unsafe float PlayerImpulseLerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x060237AD RID: 145325 RVA: 0x00924F68 File Offset: 0x00923168
		// (set) Token: 0x060237AE RID: 145326 RVA: 0x00924F78 File Offset: 0x00923178
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x060237AF RID: 145327 RVA: 0x00924F89 File Offset: 0x00923189
		// (set) Token: 0x060237B0 RID: 145328 RVA: 0x00924F99 File Offset: 0x00923199
		public unsafe float PlayerImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seesaw_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x060237B1 RID: 145329 RVA: 0x00924FAA File Offset: 0x009231AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seesaw_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060237B2 RID: 145330 RVA: 0x00924FBE File Offset: 0x009231BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seesaw_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060237B3 RID: 145331 RVA: 0x00924FD4 File Offset: 0x009231D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Seesaw_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Seesaw_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seesaw_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seesaw_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seesaw_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060237B4 RID: 145332 RVA: 0x0092501C File Offset: 0x0092321C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Seesaw_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Seesaw_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seesaw_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seesaw_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seesaw_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060237B5 RID: 145333 RVA: 0x00925063 File Offset: 0x00923263
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seesaw_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060237B6 RID: 145334 RVA: 0x00925077 File Offset: 0x00923277
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seesaw_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060237B7 RID: 145335 RVA: 0x0092508C File Offset: 0x0092328C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seesaw_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x060237B8 RID: 145336 RVA: 0x009250A0 File Offset: 0x009232A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seesaw_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060237B9 RID: 145337 RVA: 0x009250B5 File Offset: 0x009232B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seesaw_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x060237BA RID: 145338 RVA: 0x009250C9 File Offset: 0x009232C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seesaw_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060237BB RID: 145339 RVA: 0x009250DE File Offset: 0x009232DE
		protected BP_Seesaw_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011833 RID: 71731
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PB_SeeSaw/BP_Seesaw.BP_Seesaw_C";

		// Token: 0x04011834 RID: 71732
		private static IntPtr _ClassPtr;

		// Token: 0x04011835 RID: 71733
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011836 RID: 71734
		internal static int __PropertyOffset_1;

		// Token: 0x04011837 RID: 71735
		internal static int __PropertyOffset_2;

		// Token: 0x04011838 RID: 71736
		internal static int __PropertyOffset_3;

		// Token: 0x04011839 RID: 71737
		internal static int __PropertyOffset_4;

		// Token: 0x0401183A RID: 71738
		internal static int __PropertyOffset_5;

		// Token: 0x0401183B RID: 71739
		internal static int __PropertyOffset_6;

		// Token: 0x0401183C RID: 71740
		internal static int __PropertyOffset_7;

		// Token: 0x0401183D RID: 71741
		internal static int __PropertyOffset_8;

		// Token: 0x0401183E RID: 71742
		internal static int __PropertyOffset_9;

		// Token: 0x0401183F RID: 71743
		internal static int __PropertyOffset_10;

		// Token: 0x04011840 RID: 71744
		internal static int __PropertyOffset_11;

		// Token: 0x04011841 RID: 71745
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011842 RID: 71746
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011843 RID: 71747
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011844 RID: 71748
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x04011845 RID: 71749
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009E71 RID: 40561
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316FD RID: 202493
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
