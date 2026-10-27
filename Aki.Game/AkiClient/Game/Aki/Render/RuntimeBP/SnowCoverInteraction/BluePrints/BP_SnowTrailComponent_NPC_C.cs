using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints
{
	// Token: 0x02003AD4 RID: 15060
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent_NPC.BP_SnowTrailComponent_NPC_C")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class BP_SnowTrailComponent_NPC_C : UKuroBPActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060207EE RID: 133102 RVA: 0x008D4528 File Offset: 0x008D2728
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTrailComponent_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent_NPC.BP_SnowTrailComponent_NPC_C");
			}
			return BP_SnowTrailComponent_NPC_C._ClassPtr;
		}

		// Token: 0x060207EF RID: 133103 RVA: 0x008D454C File Offset: 0x008D274C
		public BP_SnowTrailComponent_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailComponent_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060207F0 RID: 133104 RVA: 0x008D4574 File Offset: 0x008D2774
		[NullableContext(1)]
		public BP_SnowTrailComponent_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailComponent_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x060207F1 RID: 133105 RVA: 0x008D45A7 File Offset: 0x008D27A7
		// (set) Token: 0x060207F2 RID: 133106 RVA: 0x008D45B7 File Offset: 0x008D27B7
		public unsafe bool UseActorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x060207F3 RID: 133107 RVA: 0x008D45C8 File Offset: 0x008D27C8
		// (set) Token: 0x060207F4 RID: 133108 RVA: 0x008D45D8 File Offset: 0x008D27D8
		public unsafe bool UseSimplePrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x060207F5 RID: 133109 RVA: 0x008D45E9 File Offset: 0x008D27E9
		// (set) Token: 0x060207F6 RID: 133110 RVA: 0x008D45F9 File Offset: 0x008D27F9
		public unsafe int NFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x060207F7 RID: 133111 RVA: 0x008D460A File Offset: 0x008D280A
		// (set) Token: 0x060207F8 RID: 133112 RVA: 0x008D461A File Offset: 0x008D281A
		public unsafe float Hardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x060207F9 RID: 133113 RVA: 0x008D462B File Offset: 0x008D282B
		// (set) Token: 0x060207FA RID: 133114 RVA: 0x008D463B File Offset: 0x008D283B
		public unsafe float RayLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x060207FB RID: 133115 RVA: 0x008D464C File Offset: 0x008D284C
		// (set) Token: 0x060207FC RID: 133116 RVA: 0x008D465C File Offset: 0x008D285C
		public unsafe float TrailRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x060207FD RID: 133117 RVA: 0x008D466D File Offset: 0x008D286D
		// (set) Token: 0x060207FE RID: 133118 RVA: 0x008D467D File Offset: 0x008D287D
		public unsafe float DistanceTraveld2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x060207FF RID: 133119 RVA: 0x008D468E File Offset: 0x008D288E
		// (set) Token: 0x06020800 RID: 133120 RVA: 0x008D46A2 File Offset: 0x008D28A2
		public unsafe FVector LastUpdateLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x06020801 RID: 133121 RVA: 0x008D46B7 File Offset: 0x008D28B7
		// (set) Token: 0x06020802 RID: 133122 RVA: 0x008D46CB File Offset: 0x008D28CB
		public unsafe BP_SnowTraceManager_C MyTraceManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTraceManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_NPC_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_NPC_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x06020803 RID: 133123 RVA: 0x008D46E0 File Offset: 0x008D28E0
		// (set) Token: 0x06020804 RID: 133124 RVA: 0x008D46F4 File Offset: 0x008D28F4
		public unsafe FVector LastCheckLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x06020805 RID: 133125 RVA: 0x008D470C File Offset: 0x008D290C
		// (set) Token: 0x06020806 RID: 133126 RVA: 0x008D4745 File Offset: 0x008D2945
		[Nullable(1)]
		public TArray<FName> BoneNameList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoneNameList) == null)
				{
					result = (this._BoneNameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoneNameList.CopyAssign(value);
			}
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x06020807 RID: 133127 RVA: 0x008D4753 File Offset: 0x008D2953
		// (set) Token: 0x06020808 RID: 133128 RVA: 0x008D4767 File Offset: 0x008D2967
		public unsafe FVector BoneTransOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x06020809 RID: 133129 RVA: 0x008D477C File Offset: 0x008D297C
		// (set) Token: 0x0602080A RID: 133130 RVA: 0x008D478C File Offset: 0x008D298C
		public unsafe bool SelfEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0602080B RID: 133131 RVA: 0x008D479D File Offset: 0x008D299D
		// (set) Token: 0x0602080C RID: 133132 RVA: 0x008D47AD File Offset: 0x008D29AD
		public unsafe int FrameConter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0602080D RID: 133133 RVA: 0x008D47BE File Offset: 0x008D29BE
		// (set) Token: 0x0602080E RID: 133134 RVA: 0x008D47D2 File Offset: 0x008D29D2
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_NPC_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_NPC_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x0602080F RID: 133135 RVA: 0x008D47E8 File Offset: 0x008D29E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateDeltaTime(float DeltaTime)
		{
			BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020810 RID: 133136 RVA: 0x008D482E File Offset: 0x008D2A2E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SnowCollisionActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__SnowCollisionActor_NativeFunctionPtr, null);
		}

		// Token: 0x06020811 RID: 133137 RVA: 0x008D4842 File Offset: 0x008D2A42
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SnowCollisionBone()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__SnowCollisionBone_NativeFunctionPtr, null);
		}

		// Token: 0x06020812 RID: 133138 RVA: 0x008D4858 File Offset: 0x008D2A58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RegisterTrailComp(float Radius, float Depth, float Hardness, float TrailRotation, FVector TrailLocation)
		{
			BP_SnowTrailComponent_NPC_C.__RegisterTrailComp_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_NPC_C.__RegisterTrailComp_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_SnowTrailComponent_NPC_C.__RegisterTrailComp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_NPC_C.__RegisterTrailComp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Radius = Radius;
			ptr->Depth = Depth;
			ptr->Hardness = Hardness;
			ptr->TrailRotation = TrailRotation;
			ptr->TrailLocation = TrailLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__RegisterTrailComp_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020813 RID: 133139 RVA: 0x008D48BC File Offset: 0x008D2ABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FindTrailManager()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__FindTrailManager_NativeFunctionPtr, null);
		}

		// Token: 0x06020814 RID: 133140 RVA: 0x008D48D0 File Offset: 0x008D2AD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020815 RID: 133141 RVA: 0x008D48E4 File Offset: 0x008D2AE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020816 RID: 133142 RVA: 0x008D48FC File Offset: 0x008D2AFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_NPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020817 RID: 133143 RVA: 0x008D4944 File Offset: 0x008D2B44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_NPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020818 RID: 133144 RVA: 0x008D498B File Offset: 0x008D2B8B
		protected BP_SnowTrailComponent_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBE2 RID: 64482
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent_NPC.BP_SnowTrailComponent_NPC_C";

		// Token: 0x0400FBE3 RID: 64483
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBE4 RID: 64484
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBE5 RID: 64485
		internal static int __PropertyOffset_1;

		// Token: 0x0400FBE6 RID: 64486
		internal static int __PropertyOffset_2;

		// Token: 0x0400FBE7 RID: 64487
		internal static int __PropertyOffset_3;

		// Token: 0x0400FBE8 RID: 64488
		internal static int __PropertyOffset_4;

		// Token: 0x0400FBE9 RID: 64489
		internal static int __PropertyOffset_5;

		// Token: 0x0400FBEA RID: 64490
		internal static int __PropertyOffset_6;

		// Token: 0x0400FBEB RID: 64491
		internal static int __PropertyOffset_7;

		// Token: 0x0400FBEC RID: 64492
		internal static int __PropertyOffset_8;

		// Token: 0x0400FBED RID: 64493
		internal static int __PropertyOffset_9;

		// Token: 0x0400FBEE RID: 64494
		internal static int __PropertyOffset_10;

		// Token: 0x0400FBEF RID: 64495
		internal static int __PropertyOffset_11;

		// Token: 0x0400FBF0 RID: 64496
		private TArray<FName> _BoneNameList;

		// Token: 0x0400FBF1 RID: 64497
		internal static int __PropertyOffset_12;

		// Token: 0x0400FBF2 RID: 64498
		internal static int __PropertyOffset_13;

		// Token: 0x0400FBF3 RID: 64499
		internal static int __PropertyOffset_14;

		// Token: 0x0400FBF4 RID: 64500
		internal static int __PropertyOffset_15;

		// Token: 0x0400FBF5 RID: 64501
		private static IntPtr __UpdateDeltaTime_NativeFunctionPtr;

		// Token: 0x0400FBF6 RID: 64502
		private static IntPtr __SnowCollisionActor_NativeFunctionPtr;

		// Token: 0x0400FBF7 RID: 64503
		private static IntPtr __SnowCollisionBone_NativeFunctionPtr;

		// Token: 0x0400FBF8 RID: 64504
		private static IntPtr __RegisterTrailComp_NativeFunctionPtr;

		// Token: 0x0400FBF9 RID: 64505
		private static IntPtr __FindTrailManager_NativeFunctionPtr;

		// Token: 0x0400FBFA RID: 64506
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FBFB RID: 64507
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009BC9 RID: 39881
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateDeltaTime_FunctionParams
		{
			// Token: 0x04031257 RID: 201303
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02009BCA RID: 39882
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __RegisterTrailComp_FunctionParams
		{
			// Token: 0x04031258 RID: 201304
			[FieldOffset(0)]
			public float Radius;

			// Token: 0x04031259 RID: 201305
			[FieldOffset(4)]
			public float Depth;

			// Token: 0x0403125A RID: 201306
			[FieldOffset(8)]
			public float Hardness;

			// Token: 0x0403125B RID: 201307
			[FieldOffset(12)]
			public float TrailRotation;

			// Token: 0x0403125C RID: 201308
			[FieldOffset(16)]
			public FVector TrailLocation;
		}

		// Token: 0x02009BCB RID: 39883
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403125D RID: 201309
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
