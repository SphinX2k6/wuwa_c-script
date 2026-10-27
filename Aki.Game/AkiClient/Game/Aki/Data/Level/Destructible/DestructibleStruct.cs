using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Destructible
{
	// Token: 0x02003F12 RID: 16146
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Destructible/DestructibleStruct.DestructibleStruct")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 236)]
	public class DestructibleStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028FF8 RID: 167928 RVA: 0x009B93BF File Offset: 0x009B75BF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (DestructibleStruct._ScriptStructPtr != 0) ? DestructibleStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Destructible/DestructibleStruct.DestructibleStruct", ref DestructibleStruct._ScriptStructPtr);
		}

		// Token: 0x170060E1 RID: 24801
		// (get) Token: 0x06028FF9 RID: 167929 RVA: 0x009B93E3 File Offset: 0x009B75E3
		// (set) Token: 0x06028FFA RID: 167930 RVA: 0x009B93F7 File Offset: 0x009B75F7
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)DestructibleStruct.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)DestructibleStruct.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170060E2 RID: 24802
		// (get) Token: 0x06028FFB RID: 167931 RVA: 0x009B940C File Offset: 0x009B760C
		// (set) Token: 0x06028FFC RID: 167932 RVA: 0x009B942B File Offset: 0x009B762B
		public TSoftObjectPtr<UKuroDestructibleAsset> DestructibleAsset
		{
			get
			{
				return new TSoftObjectPtr<UKuroDestructibleAsset>(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170060E3 RID: 24803
		// (get) Token: 0x06028FFD RID: 167933 RVA: 0x009B9450 File Offset: 0x009B7650
		// (set) Token: 0x06028FFE RID: 167934 RVA: 0x009B946F File Offset: 0x009B766F
		public TSoftObjectPtr<UKuroDestructibleDestructionAsset> DestructibleDestructionAsset
		{
			get
			{
				return new TSoftObjectPtr<UKuroDestructibleDestructionAsset>(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170060E4 RID: 24804
		// (get) Token: 0x06028FFF RID: 167935 RVA: 0x009B9494 File Offset: 0x009B7694
		// (set) Token: 0x06029000 RID: 167936 RVA: 0x009B94A4 File Offset: 0x009B76A4
		public unsafe bool IsRelativePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060E5 RID: 24805
		// (get) Token: 0x06029001 RID: 167937 RVA: 0x009B94B5 File Offset: 0x009B76B5
		// (set) Token: 0x06029002 RID: 167938 RVA: 0x009B94C9 File Offset: 0x009B76C9
		public unsafe FVectorDouble Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170060E6 RID: 24806
		// (get) Token: 0x06029003 RID: 167939 RVA: 0x009B94DE File Offset: 0x009B76DE
		// (set) Token: 0x06029004 RID: 167940 RVA: 0x009B94F2 File Offset: 0x009B76F2
		public unsafe FTransform ModelTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170060E7 RID: 24807
		// (get) Token: 0x06029005 RID: 167941 RVA: 0x009B9507 File Offset: 0x009B7707
		// (set) Token: 0x06029006 RID: 167942 RVA: 0x009B9517 File Offset: 0x009B7717
		public unsafe float TraceSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170060E8 RID: 24808
		// (get) Token: 0x06029007 RID: 167943 RVA: 0x009B9528 File Offset: 0x009B7728
		// (set) Token: 0x06029008 RID: 167944 RVA: 0x009B9538 File Offset: 0x009B7738
		public unsafe ETrackMethod TrackMethod
		{
			get
			{
				return (ETrackMethod)(*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_7));
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_7) = (byte)value;
			}
		}

		// Token: 0x170060E9 RID: 24809
		// (get) Token: 0x06029009 RID: 167945 RVA: 0x009B9549 File Offset: 0x009B7749
		// (set) Token: 0x0602900A RID: 167946 RVA: 0x009B9559 File Offset: 0x009B7759
		public unsafe float TrackPredictionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170060EA RID: 24810
		// (get) Token: 0x0602900B RID: 167947 RVA: 0x009B956A File Offset: 0x009B776A
		// (set) Token: 0x0602900C RID: 167948 RVA: 0x009B957A File Offset: 0x009B777A
		public unsafe float StopTrackTargetDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170060EB RID: 24811
		// (get) Token: 0x0602900D RID: 167949 RVA: 0x009B958B File Offset: 0x009B778B
		// (set) Token: 0x0602900E RID: 167950 RVA: 0x009B959F File Offset: 0x009B779F
		[Nullable(0)]
		public unsafe TEnumAsByte<FauxPhysicsRotateType> TrackType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_10);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170060EC RID: 24812
		// (get) Token: 0x0602900F RID: 167951 RVA: 0x009B95B4 File Offset: 0x009B77B4
		// (set) Token: 0x06029010 RID: 167952 RVA: 0x009B95C8 File Offset: 0x009B77C8
		public unsafe FVector LocalRotationAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170060ED RID: 24813
		// (get) Token: 0x06029011 RID: 167953 RVA: 0x009B95DD File Offset: 0x009B77DD
		// (set) Token: 0x06029012 RID: 167954 RVA: 0x009B95ED File Offset: 0x009B77ED
		public unsafe float AngularImpulseRadians
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170060EE RID: 24814
		// (get) Token: 0x06029013 RID: 167955 RVA: 0x009B95FE File Offset: 0x009B77FE
		// (set) Token: 0x06029014 RID: 167956 RVA: 0x009B960E File Offset: 0x009B780E
		public unsafe int HitBuff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170060EF RID: 24815
		// (get) Token: 0x06029015 RID: 167957 RVA: 0x009B961F File Offset: 0x009B781F
		// (set) Token: 0x06029016 RID: 167958 RVA: 0x009B962F File Offset: 0x009B782F
		public unsafe int RevertMaximumHP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x06029017 RID: 167959 RVA: 0x009B9640 File Offset: 0x009B7840
		public DestructibleStruct()
		{
		}

		// Token: 0x06029018 RID: 167960 RVA: 0x009B9648 File Offset: 0x009B7848
		public DestructibleStruct(string 备注, TSoftObjectPtr<UKuroDestructibleAsset> DestructibleAsset, TSoftObjectPtr<UKuroDestructibleDestructionAsset> DestructibleDestructionAsset, bool IsRelativePosition, FVectorDouble Position, FTransform ModelTransform, float TraceSpeed, ETrackMethod TrackMethod, float TrackPredictionFactor, float StopTrackTargetDistance, [Nullable(0)] TEnumAsByte<FauxPhysicsRotateType> TrackType, FVector LocalRotationAxis, float AngularImpulseRadians, int HitBuff, int RevertMaximumHP)
		{
			this.备注 = 备注;
			this.DestructibleAsset = DestructibleAsset;
			this.DestructibleDestructionAsset = DestructibleDestructionAsset;
			this.IsRelativePosition = IsRelativePosition;
			this.Position = Position;
			this.ModelTransform = ModelTransform;
			this.TraceSpeed = TraceSpeed;
			this.TrackMethod = TrackMethod;
			this.TrackPredictionFactor = TrackPredictionFactor;
			this.StopTrackTargetDistance = StopTrackTargetDistance;
			this.TrackType = TrackType;
			this.LocalRotationAxis = LocalRotationAxis;
			this.AngularImpulseRadians = AngularImpulseRadians;
			this.HitBuff = HitBuff;
			this.RevertMaximumHP = RevertMaximumHP;
		}

		// Token: 0x06029019 RID: 167961 RVA: 0x009B96D0 File Offset: 0x009B78D0
		protected override IntPtr GetUStructPtr()
		{
			return DestructibleStruct.StaticStruct();
		}

		// Token: 0x0602901A RID: 167962 RVA: 0x009B96DC File Offset: 0x009B78DC
		[NullableContext(2)]
		public DestructibleStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602901B RID: 167963 RVA: 0x009B96E6 File Offset: 0x009B78E6
		public DestructibleStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602901C RID: 167964 RVA: 0x009B96F1 File Offset: 0x009B78F1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new DestructibleStruct(Pointer, false, true);
		}

		// Token: 0x0602901D RID: 167965 RVA: 0x009B96FB File Offset: 0x009B78FB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new DestructibleStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04014F8C RID: 85900
		public const string __ObjectPath = "/Game/Aki/Data/Level/Destructible/DestructibleStruct.DestructibleStruct";

		// Token: 0x04014F8D RID: 85901
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F8E RID: 85902
		internal static int __PropertyOffset_0;

		// Token: 0x04014F8F RID: 85903
		internal static int __PropertyOffset_1;

		// Token: 0x04014F90 RID: 85904
		internal static int __PropertyOffset_2;

		// Token: 0x04014F91 RID: 85905
		internal static int __PropertyOffset_3;

		// Token: 0x04014F92 RID: 85906
		internal static int __PropertyOffset_4;

		// Token: 0x04014F93 RID: 85907
		internal static int __PropertyOffset_5;

		// Token: 0x04014F94 RID: 85908
		internal static int __PropertyOffset_6;

		// Token: 0x04014F95 RID: 85909
		internal static int __PropertyOffset_7;

		// Token: 0x04014F96 RID: 85910
		internal static int __PropertyOffset_8;

		// Token: 0x04014F97 RID: 85911
		internal static int __PropertyOffset_9;

		// Token: 0x04014F98 RID: 85912
		internal static int __PropertyOffset_10;

		// Token: 0x04014F99 RID: 85913
		internal static int __PropertyOffset_11;

		// Token: 0x04014F9A RID: 85914
		internal static int __PropertyOffset_12;

		// Token: 0x04014F9B RID: 85915
		internal static int __PropertyOffset_13;

		// Token: 0x04014F9C RID: 85916
		internal static int __PropertyOffset_14;
	}
}
