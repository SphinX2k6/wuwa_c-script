using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Destructible
{
	// Token: 0x020031CD RID: 12749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Destructible/DestructibleStruct.DestructibleStruct")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 236)]
	public class DestructibleStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F977 RID: 129399 RVA: 0x009310A7 File Offset: 0x0092F2A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (DestructibleStruct._ScriptStructPtr != 0) ? DestructibleStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Destructible/DestructibleStruct.DestructibleStruct", ref DestructibleStruct._ScriptStructPtr);
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x0601F978 RID: 129400 RVA: 0x009310CB File Offset: 0x0092F2CB
		// (set) Token: 0x0601F979 RID: 129401 RVA: 0x009310DF File Offset: 0x0092F2DF
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)DestructibleStruct.__PropertyOffset_备注)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)DestructibleStruct.__PropertyOffset_备注)), value);
			}
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0601F97A RID: 129402 RVA: 0x009310F4 File Offset: 0x0092F2F4
		// (set) Token: 0x0601F97B RID: 129403 RVA: 0x00931113 File Offset: 0x0092F313
		public TSoftObjectPtr<UKuroDestructibleAsset> DestructibleAsset
		{
			get
			{
				return new TSoftObjectPtr<UKuroDestructibleAsset>(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_DestructibleAsset, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_DestructibleAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0601F97C RID: 129404 RVA: 0x00931138 File Offset: 0x0092F338
		// (set) Token: 0x0601F97D RID: 129405 RVA: 0x00931157 File Offset: 0x0092F357
		public TSoftObjectPtr<UKuroDestructibleDestructionAsset> DestructibleDestructionAsset
		{
			get
			{
				return new TSoftObjectPtr<UKuroDestructibleDestructionAsset>(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_DestructibleDestructionAsset, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_DestructibleDestructionAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0601F97E RID: 129406 RVA: 0x0093117C File Offset: 0x0092F37C
		// (set) Token: 0x0601F97F RID: 129407 RVA: 0x0093118C File Offset: 0x0092F38C
		public unsafe bool IsRelativePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_IsRelativePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_IsRelativePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0601F980 RID: 129408 RVA: 0x0093119D File Offset: 0x0092F39D
		// (set) Token: 0x0601F981 RID: 129409 RVA: 0x009311B1 File Offset: 0x0092F3B1
		public unsafe FVectorDouble Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0601F982 RID: 129410 RVA: 0x009311C6 File Offset: 0x0092F3C6
		// (set) Token: 0x0601F983 RID: 129411 RVA: 0x009311DA File Offset: 0x0092F3DA
		public unsafe FTransform ModelTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_ModelTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_ModelTransform) = value;
			}
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0601F984 RID: 129412 RVA: 0x009311EF File Offset: 0x0092F3EF
		// (set) Token: 0x0601F985 RID: 129413 RVA: 0x009311FF File Offset: 0x0092F3FF
		public unsafe float TraceSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_TraceSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_TraceSpeed) = value;
			}
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0601F986 RID: 129414 RVA: 0x00931210 File Offset: 0x0092F410
		// (set) Token: 0x0601F987 RID: 129415 RVA: 0x00931220 File Offset: 0x0092F420
		public unsafe ETrackMethod TrackMethod
		{
			get
			{
				return (ETrackMethod)(*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_TrackMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_TrackMethod) = (byte)value;
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0601F988 RID: 129416 RVA: 0x00931231 File Offset: 0x0092F431
		// (set) Token: 0x0601F989 RID: 129417 RVA: 0x00931241 File Offset: 0x0092F441
		public unsafe float TrackPredictionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_TrackPredictionFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_TrackPredictionFactor) = value;
			}
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0601F98A RID: 129418 RVA: 0x00931252 File Offset: 0x0092F452
		// (set) Token: 0x0601F98B RID: 129419 RVA: 0x00931262 File Offset: 0x0092F462
		public unsafe float StopTrackTargetDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_StopTrackTargetDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_StopTrackTargetDistance) = value;
			}
		}

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0601F98C RID: 129420 RVA: 0x00931273 File Offset: 0x0092F473
		// (set) Token: 0x0601F98D RID: 129421 RVA: 0x00931287 File Offset: 0x0092F487
		public unsafe FVector LocalRotationAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_LocalRotationAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_LocalRotationAxis) = value;
			}
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0601F98E RID: 129422 RVA: 0x0093129C File Offset: 0x0092F49C
		// (set) Token: 0x0601F98F RID: 129423 RVA: 0x009312AC File Offset: 0x0092F4AC
		public unsafe float AngularImpulseRadians
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_AngularImpulseRadians);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_AngularImpulseRadians) = value;
			}
		}

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0601F990 RID: 129424 RVA: 0x009312BD File Offset: 0x0092F4BD
		// (set) Token: 0x0601F991 RID: 129425 RVA: 0x009312CD File Offset: 0x0092F4CD
		public unsafe int HitBuff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_HitBuff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_HitBuff) = value;
			}
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0601F992 RID: 129426 RVA: 0x009312DE File Offset: 0x0092F4DE
		// (set) Token: 0x0601F993 RID: 129427 RVA: 0x009312EE File Offset: 0x0092F4EE
		public unsafe int RevertMaximumHP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_RevertMaximumHP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DestructibleStruct.__PropertyOffset_RevertMaximumHP) = value;
			}
		}

		// Token: 0x0601F994 RID: 129428 RVA: 0x009312FF File Offset: 0x0092F4FF
		public DestructibleStruct()
		{
		}

		// Token: 0x0601F995 RID: 129429 RVA: 0x00931307 File Offset: 0x0092F507
		protected override IntPtr GetUStructPtr()
		{
			return DestructibleStruct.StaticStruct();
		}

		// Token: 0x0601F996 RID: 129430 RVA: 0x00931313 File Offset: 0x0092F513
		[NullableContext(2)]
		public DestructibleStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F997 RID: 129431 RVA: 0x0093131D File Offset: 0x0092F51D
		public DestructibleStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F998 RID: 129432 RVA: 0x00931328 File Offset: 0x0092F528
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new DestructibleStruct(Pointer, false, true);
		}

		// Token: 0x0601F999 RID: 129433 RVA: 0x00931332 File Offset: 0x0092F532
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new DestructibleStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04010F24 RID: 69412
		public const string __ObjectPath = "/Game/Aki/Data/Level/Destructible/DestructibleStruct.DestructibleStruct";

		// Token: 0x04010F25 RID: 69413
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F26 RID: 69414
		internal static int __PropertyOffset_备注;

		// Token: 0x04010F27 RID: 69415
		internal static int __PropertyOffset_DestructibleAsset;

		// Token: 0x04010F28 RID: 69416
		internal static int __PropertyOffset_DestructibleDestructionAsset;

		// Token: 0x04010F29 RID: 69417
		internal static int __PropertyOffset_IsRelativePosition;

		// Token: 0x04010F2A RID: 69418
		internal static int __PropertyOffset_Position;

		// Token: 0x04010F2B RID: 69419
		internal static int __PropertyOffset_ModelTransform;

		// Token: 0x04010F2C RID: 69420
		internal static int __PropertyOffset_TraceSpeed;

		// Token: 0x04010F2D RID: 69421
		internal static int __PropertyOffset_TrackMethod;

		// Token: 0x04010F2E RID: 69422
		internal static int __PropertyOffset_TrackPredictionFactor;

		// Token: 0x04010F2F RID: 69423
		internal static int __PropertyOffset_StopTrackTargetDistance;

		// Token: 0x04010F30 RID: 69424
		internal static int __PropertyOffset_LocalRotationAxis;

		// Token: 0x04010F31 RID: 69425
		internal static int __PropertyOffset_AngularImpulseRadians;

		// Token: 0x04010F32 RID: 69426
		internal static int __PropertyOffset_HitBuff;

		// Token: 0x04010F33 RID: 69427
		internal static int __PropertyOffset_RevertMaximumHP;
	}
}
