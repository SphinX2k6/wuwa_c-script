using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints
{
	// Token: 0x020030AE RID: 12462
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent_NPC.BP_SnowTrailComponent_NPC_C")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class BP_SnowTrailComponent_NPC_C : UKuroBPActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE4A RID: 122442 RVA: 0x00905018 File Offset: 0x00903218
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTrailComponent_NPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent_NPC.BP_SnowTrailComponent_NPC_C");
			}
			return BP_SnowTrailComponent_NPC_C._ClassPtr;
		}

		// Token: 0x0601DE4B RID: 122443 RVA: 0x0090503C File Offset: 0x0090323C
		public BP_SnowTrailComponent_NPC_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailComponent_NPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE4C RID: 122444 RVA: 0x00905064 File Offset: 0x00903264
		[NullableContext(1)]
		public BP_SnowTrailComponent_NPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailComponent_NPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x0601DE4D RID: 122445 RVA: 0x00905097 File Offset: 0x00903297
		// (set) Token: 0x0601DE4E RID: 122446 RVA: 0x009050A7 File Offset: 0x009032A7
		public unsafe bool UseActorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_UseActorPos) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_UseActorPos) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x0601DE4F RID: 122447 RVA: 0x009050B8 File Offset: 0x009032B8
		// (set) Token: 0x0601DE50 RID: 122448 RVA: 0x009050C8 File Offset: 0x009032C8
		public unsafe bool UseSimplePrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_UseSimplePrint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_UseSimplePrint) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x0601DE51 RID: 122449 RVA: 0x009050D9 File Offset: 0x009032D9
		// (set) Token: 0x0601DE52 RID: 122450 RVA: 0x009050E9 File Offset: 0x009032E9
		public unsafe int NFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_NFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_NFrame) = value;
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x0601DE53 RID: 122451 RVA: 0x009050FA File Offset: 0x009032FA
		// (set) Token: 0x0601DE54 RID: 122452 RVA: 0x0090510A File Offset: 0x0090330A
		public unsafe float Hardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_Hardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_Hardness) = value;
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x0601DE55 RID: 122453 RVA: 0x0090511B File Offset: 0x0090331B
		// (set) Token: 0x0601DE56 RID: 122454 RVA: 0x0090512B File Offset: 0x0090332B
		public unsafe float RayLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_RayLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_RayLength) = value;
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x0601DE57 RID: 122455 RVA: 0x0090513C File Offset: 0x0090333C
		// (set) Token: 0x0601DE58 RID: 122456 RVA: 0x0090514C File Offset: 0x0090334C
		public unsafe float TrailRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_TrailRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_TrailRadius) = value;
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x0601DE59 RID: 122457 RVA: 0x0090515D File Offset: 0x0090335D
		// (set) Token: 0x0601DE5A RID: 122458 RVA: 0x0090516D File Offset: 0x0090336D
		public unsafe float DistanceTraveld2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_DistanceTraveld2D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_DistanceTraveld2D) = value;
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x0601DE5B RID: 122459 RVA: 0x0090517E File Offset: 0x0090337E
		// (set) Token: 0x0601DE5C RID: 122460 RVA: 0x00905192 File Offset: 0x00903392
		public unsafe FVector LastUpdateLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_LastUpdateLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_LastUpdateLocation) = value;
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x0601DE5D RID: 122461 RVA: 0x009051A7 File Offset: 0x009033A7
		// (set) Token: 0x0601DE5E RID: 122462 RVA: 0x009051BB File Offset: 0x009033BB
		public unsafe FVector LastCheckLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_LastCheckLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_LastCheckLocation) = value;
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x0601DE5F RID: 122463 RVA: 0x009051D0 File Offset: 0x009033D0
		// (set) Token: 0x0601DE60 RID: 122464 RVA: 0x00905209 File Offset: 0x00903409
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
					result = (this._BoneNameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_BoneNameList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoneNameList.CopyAssign(value);
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x0601DE61 RID: 122465 RVA: 0x00905217 File Offset: 0x00903417
		// (set) Token: 0x0601DE62 RID: 122466 RVA: 0x0090522B File Offset: 0x0090342B
		public unsafe FVector BoneTransOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_BoneTransOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_BoneTransOffset) = value;
			}
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x0601DE63 RID: 122467 RVA: 0x00905240 File Offset: 0x00903440
		// (set) Token: 0x0601DE64 RID: 122468 RVA: 0x00905250 File Offset: 0x00903450
		public unsafe bool SelfEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_SelfEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_SelfEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x0601DE65 RID: 122469 RVA: 0x00905261 File Offset: 0x00903461
		// (set) Token: 0x0601DE66 RID: 122470 RVA: 0x00905271 File Offset: 0x00903471
		public unsafe int FrameConter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_FrameConter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_NPC_C.__PropertyOffset_FrameConter) = value;
			}
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x0601DE67 RID: 122471 RVA: 0x00905282 File Offset: 0x00903482
		// (set) Token: 0x0601DE68 RID: 122472 RVA: 0x00905296 File Offset: 0x00903496
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_NPC_C.__PropertyOffset_SkeletalMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_NPC_C.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x0601DE69 RID: 122473 RVA: 0x009052AC File Offset: 0x009034AC
		[SkipLocalsInit]
		public unsafe virtual void UpdateDeltaTime(float DeltaTime)
		{
			BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__UpdateDeltaTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE6A RID: 122474 RVA: 0x009052F2 File Offset: 0x009034F2
		[SkipLocalsInit]
		public virtual void SnowCollisionActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__SnowCollisionActor_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE6B RID: 122475 RVA: 0x00905306 File Offset: 0x00903506
		[SkipLocalsInit]
		public virtual void SnowCollisionBone()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__SnowCollisionBone_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE6C RID: 122476 RVA: 0x0090531C File Offset: 0x0090351C
		[SkipLocalsInit]
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

		// Token: 0x0601DE6D RID: 122477 RVA: 0x00905380 File Offset: 0x00903580
		[SkipLocalsInit]
		public virtual void FindTrailManager()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__FindTrailManager_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE6E RID: 122478 RVA: 0x00905394 File Offset: 0x00903594
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE6F RID: 122479 RVA: 0x009053A8 File Offset: 0x009035A8
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE70 RID: 122480 RVA: 0x009053BC File Offset: 0x009035BC
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_NPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE71 RID: 122481 RVA: 0x00905404 File Offset: 0x00903604
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_NPC_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_NPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTrailComponent_NPC_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE72 RID: 122482 RVA: 0x0090544A File Offset: 0x0090364A
		protected BP_SnowTrailComponent_NPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC7E RID: 64638
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent_NPC.BP_SnowTrailComponent_NPC_C";

		// Token: 0x0400FC7F RID: 64639
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC80 RID: 64640
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC81 RID: 64641
		internal static int __PropertyOffset_UseActorPos;

		// Token: 0x0400FC82 RID: 64642
		internal static int __PropertyOffset_UseSimplePrint;

		// Token: 0x0400FC83 RID: 64643
		internal static int __PropertyOffset_NFrame;

		// Token: 0x0400FC84 RID: 64644
		internal static int __PropertyOffset_Hardness;

		// Token: 0x0400FC85 RID: 64645
		internal static int __PropertyOffset_RayLength;

		// Token: 0x0400FC86 RID: 64646
		internal static int __PropertyOffset_TrailRadius;

		// Token: 0x0400FC87 RID: 64647
		internal static int __PropertyOffset_DistanceTraveld2D;

		// Token: 0x0400FC88 RID: 64648
		internal static int __PropertyOffset_LastUpdateLocation;

		// Token: 0x0400FC89 RID: 64649
		internal static int __PropertyOffset_LastCheckLocation;

		// Token: 0x0400FC8A RID: 64650
		internal static int __PropertyOffset_BoneNameList;

		// Token: 0x0400FC8B RID: 64651
		[Nullable(2)]
		private TArray<FName> _BoneNameList;

		// Token: 0x0400FC8C RID: 64652
		internal static int __PropertyOffset_BoneTransOffset;

		// Token: 0x0400FC8D RID: 64653
		internal static int __PropertyOffset_SelfEnable;

		// Token: 0x0400FC8E RID: 64654
		internal static int __PropertyOffset_FrameConter;

		// Token: 0x0400FC8F RID: 64655
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x0400FC90 RID: 64656
		private static IntPtr __UpdateDeltaTime_NativeFunctionPtr;

		// Token: 0x0400FC91 RID: 64657
		private static IntPtr __SnowCollisionActor_NativeFunctionPtr;

		// Token: 0x0400FC92 RID: 64658
		private static IntPtr __SnowCollisionBone_NativeFunctionPtr;

		// Token: 0x0400FC93 RID: 64659
		private static IntPtr __RegisterTrailComp_NativeFunctionPtr;

		// Token: 0x0400FC94 RID: 64660
		private static IntPtr __FindTrailManager_NativeFunctionPtr;

		// Token: 0x0400FC95 RID: 64661
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC96 RID: 64662
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008DD1 RID: 36305
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateDeltaTime_FunctionParams
		{
			// Token: 0x0402C9DF RID: 182751
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02008DD2 RID: 36306
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __RegisterTrailComp_FunctionParams
		{
			// Token: 0x0402C9E0 RID: 182752
			[FieldOffset(0)]
			public float Radius;

			// Token: 0x0402C9E1 RID: 182753
			[FieldOffset(4)]
			public float Depth;

			// Token: 0x0402C9E2 RID: 182754
			[FieldOffset(8)]
			public float Hardness;

			// Token: 0x0402C9E3 RID: 182755
			[FieldOffset(12)]
			public float TrailRotation;

			// Token: 0x0402C9E4 RID: 182756
			[FieldOffset(16)]
			public FVector TrailLocation;
		}

		// Token: 0x02008DD3 RID: 36307
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C9E5 RID: 182757
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
