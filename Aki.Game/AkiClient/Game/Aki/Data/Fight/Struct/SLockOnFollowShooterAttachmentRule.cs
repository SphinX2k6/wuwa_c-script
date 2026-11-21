using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x0200320C RID: 12812
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAttachmentRule.SLockOnFollowShooterAttachmentRule")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 22)]
	public class SLockOnFollowShooterAttachmentRule : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FEB5 RID: 130741 RVA: 0x00939045 File Offset: 0x00937245
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnFollowShooterAttachmentRule._ScriptStructPtr != 0) ? SLockOnFollowShooterAttachmentRule._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAttachmentRule.SLockOnFollowShooterAttachmentRule", ref SLockOnFollowShooterAttachmentRule._ScriptStructPtr);
		}

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0601FEB6 RID: 130742 RVA: 0x00939069 File Offset: 0x00937269
		// (set) Token: 0x0601FEB7 RID: 130743 RVA: 0x0093907D File Offset: 0x0093727D
		public unsafe FName Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_Socket) = value;
			}
		}

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0601FEB8 RID: 130744 RVA: 0x00939092 File Offset: 0x00937292
		// (set) Token: 0x0601FEB9 RID: 130745 RVA: 0x009390A6 File Offset: 0x009372A6
		public unsafe TEnumAsByte<BPEDetachmentRule> DetachLocationRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_DetachLocationRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_DetachLocationRule) = value;
			}
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x0601FEBA RID: 130746 RVA: 0x009390BB File Offset: 0x009372BB
		// (set) Token: 0x0601FEBB RID: 130747 RVA: 0x009390CF File Offset: 0x009372CF
		public unsafe TEnumAsByte<BPEDetachmentRule> DetachRotationRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_DetachRotationRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_DetachRotationRule) = value;
			}
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x0601FEBC RID: 130748 RVA: 0x009390E4 File Offset: 0x009372E4
		// (set) Token: 0x0601FEBD RID: 130749 RVA: 0x009390F8 File Offset: 0x009372F8
		public unsafe TEnumAsByte<BPEDetachmentRule> DetachScaleRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_DetachScaleRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_DetachScaleRule) = value;
			}
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x0601FEBE RID: 130750 RVA: 0x0093910D File Offset: 0x0093730D
		// (set) Token: 0x0601FEBF RID: 130751 RVA: 0x00939121 File Offset: 0x00937321
		public unsafe TEnumAsByte<BPEFollowShooterAttachStrategy> AttachStrategy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AttachStrategy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AttachStrategy) = value;
			}
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0601FEC0 RID: 130752 RVA: 0x00939136 File Offset: 0x00937336
		// (set) Token: 0x0601FEC1 RID: 130753 RVA: 0x0093914A File Offset: 0x0093734A
		public unsafe TEnumAsByte<BPEAttachmentRule> AttachLocationRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AttachLocationRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AttachLocationRule) = value;
			}
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x0601FEC2 RID: 130754 RVA: 0x0093915F File Offset: 0x0093735F
		// (set) Token: 0x0601FEC3 RID: 130755 RVA: 0x00939173 File Offset: 0x00937373
		public unsafe TEnumAsByte<BPEAttachmentRule> AttachRotationRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AttachRotationRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AttachRotationRule) = value;
			}
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0601FEC4 RID: 130756 RVA: 0x00939188 File Offset: 0x00937388
		// (set) Token: 0x0601FEC5 RID: 130757 RVA: 0x0093919C File Offset: 0x0093739C
		public unsafe TEnumAsByte<BPEAttachmentRule> AttachScaleRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AttachScaleRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AttachScaleRule) = value;
			}
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x0601FEC6 RID: 130758 RVA: 0x009391B1 File Offset: 0x009373B1
		// (set) Token: 0x0601FEC7 RID: 130759 RVA: 0x009391C1 File Offset: 0x009373C1
		public unsafe bool AbsoluteLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AbsoluteLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AbsoluteLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0601FEC8 RID: 130760 RVA: 0x009391D2 File Offset: 0x009373D2
		// (set) Token: 0x0601FEC9 RID: 130761 RVA: 0x009391E2 File Offset: 0x009373E2
		public unsafe bool AbsoluteRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AbsoluteRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AbsoluteRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0601FECA RID: 130762 RVA: 0x009391F3 File Offset: 0x009373F3
		// (set) Token: 0x0601FECB RID: 130763 RVA: 0x00939203 File Offset: 0x00937403
		public unsafe bool AbsoluteScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AbsoluteScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_AbsoluteScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FECC RID: 130764 RVA: 0x00939214 File Offset: 0x00937414
		public SLockOnFollowShooterAttachmentRule()
		{
		}

		// Token: 0x0601FECD RID: 130765 RVA: 0x0093921C File Offset: 0x0093741C
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnFollowShooterAttachmentRule.StaticStruct();
		}

		// Token: 0x0601FECE RID: 130766 RVA: 0x00939228 File Offset: 0x00937428
		[NullableContext(2)]
		public SLockOnFollowShooterAttachmentRule(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FECF RID: 130767 RVA: 0x00939232 File Offset: 0x00937432
		public SLockOnFollowShooterAttachmentRule(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FED0 RID: 130768 RVA: 0x0093923D File Offset: 0x0093743D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnFollowShooterAttachmentRule(Pointer, false, true);
		}

		// Token: 0x0601FED1 RID: 130769 RVA: 0x00939247 File Offset: 0x00937447
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnFollowShooterAttachmentRule(Pointer, MemoryOwner);
		}

		// Token: 0x04011246 RID: 70214
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAttachmentRule.SLockOnFollowShooterAttachmentRule";

		// Token: 0x04011247 RID: 70215
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011248 RID: 70216
		internal static int __PropertyOffset_Socket;

		// Token: 0x04011249 RID: 70217
		internal static int __PropertyOffset_DetachLocationRule;

		// Token: 0x0401124A RID: 70218
		internal static int __PropertyOffset_DetachRotationRule;

		// Token: 0x0401124B RID: 70219
		internal static int __PropertyOffset_DetachScaleRule;

		// Token: 0x0401124C RID: 70220
		internal static int __PropertyOffset_AttachStrategy;

		// Token: 0x0401124D RID: 70221
		internal static int __PropertyOffset_AttachLocationRule;

		// Token: 0x0401124E RID: 70222
		internal static int __PropertyOffset_AttachRotationRule;

		// Token: 0x0401124F RID: 70223
		internal static int __PropertyOffset_AttachScaleRule;

		// Token: 0x04011250 RID: 70224
		internal static int __PropertyOffset_AbsoluteLocation;

		// Token: 0x04011251 RID: 70225
		internal static int __PropertyOffset_AbsoluteRotation;

		// Token: 0x04011252 RID: 70226
		internal static int __PropertyOffset_AbsoluteScale;
	}
}
