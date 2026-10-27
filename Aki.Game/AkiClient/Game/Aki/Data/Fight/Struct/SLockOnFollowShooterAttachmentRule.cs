using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F6B RID: 16235
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAttachmentRule.SLockOnFollowShooterAttachmentRule")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 22)]
	public class SLockOnFollowShooterAttachmentRule : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029630 RID: 169520 RVA: 0x009C303C File Offset: 0x009C123C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnFollowShooterAttachmentRule._ScriptStructPtr != 0) ? SLockOnFollowShooterAttachmentRule._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAttachmentRule.SLockOnFollowShooterAttachmentRule", ref SLockOnFollowShooterAttachmentRule._ScriptStructPtr);
		}

		// Token: 0x170062F2 RID: 25330
		// (get) Token: 0x06029631 RID: 169521 RVA: 0x009C3060 File Offset: 0x009C1260
		// (set) Token: 0x06029632 RID: 169522 RVA: 0x009C3074 File Offset: 0x009C1274
		public unsafe FName Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170062F3 RID: 25331
		// (get) Token: 0x06029633 RID: 169523 RVA: 0x009C3089 File Offset: 0x009C1289
		// (set) Token: 0x06029634 RID: 169524 RVA: 0x009C309D File Offset: 0x009C129D
		public unsafe TEnumAsByte<BPEDetachmentRule> DetachLocationRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170062F4 RID: 25332
		// (get) Token: 0x06029635 RID: 169525 RVA: 0x009C30B2 File Offset: 0x009C12B2
		// (set) Token: 0x06029636 RID: 169526 RVA: 0x009C30C6 File Offset: 0x009C12C6
		public unsafe TEnumAsByte<BPEDetachmentRule> DetachRotationRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170062F5 RID: 25333
		// (get) Token: 0x06029637 RID: 169527 RVA: 0x009C30DB File Offset: 0x009C12DB
		// (set) Token: 0x06029638 RID: 169528 RVA: 0x009C30EF File Offset: 0x009C12EF
		public unsafe TEnumAsByte<BPEDetachmentRule> DetachScaleRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170062F6 RID: 25334
		// (get) Token: 0x06029639 RID: 169529 RVA: 0x009C3104 File Offset: 0x009C1304
		// (set) Token: 0x0602963A RID: 169530 RVA: 0x009C3118 File Offset: 0x009C1318
		public unsafe TEnumAsByte<BPEFollowShooterAttachStrategy> AttachStrategy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170062F7 RID: 25335
		// (get) Token: 0x0602963B RID: 169531 RVA: 0x009C312D File Offset: 0x009C132D
		// (set) Token: 0x0602963C RID: 169532 RVA: 0x009C3141 File Offset: 0x009C1341
		public unsafe TEnumAsByte<BPEAttachmentRule> AttachLocationRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170062F8 RID: 25336
		// (get) Token: 0x0602963D RID: 169533 RVA: 0x009C3156 File Offset: 0x009C1356
		// (set) Token: 0x0602963E RID: 169534 RVA: 0x009C316A File Offset: 0x009C136A
		public unsafe TEnumAsByte<BPEAttachmentRule> AttachRotationRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170062F9 RID: 25337
		// (get) Token: 0x0602963F RID: 169535 RVA: 0x009C317F File Offset: 0x009C137F
		// (set) Token: 0x06029640 RID: 169536 RVA: 0x009C3193 File Offset: 0x009C1393
		public unsafe TEnumAsByte<BPEAttachmentRule> AttachScaleRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170062FA RID: 25338
		// (get) Token: 0x06029641 RID: 169537 RVA: 0x009C31A8 File Offset: 0x009C13A8
		// (set) Token: 0x06029642 RID: 169538 RVA: 0x009C31B8 File Offset: 0x009C13B8
		public unsafe bool AbsoluteLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062FB RID: 25339
		// (get) Token: 0x06029643 RID: 169539 RVA: 0x009C31C9 File Offset: 0x009C13C9
		// (set) Token: 0x06029644 RID: 169540 RVA: 0x009C31D9 File Offset: 0x009C13D9
		public unsafe bool AbsoluteRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062FC RID: 25340
		// (get) Token: 0x06029645 RID: 169541 RVA: 0x009C31EA File Offset: 0x009C13EA
		// (set) Token: 0x06029646 RID: 169542 RVA: 0x009C31FA File Offset: 0x009C13FA
		public unsafe bool AbsoluteScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAttachmentRule.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x06029647 RID: 169543 RVA: 0x009C320B File Offset: 0x009C140B
		public SLockOnFollowShooterAttachmentRule()
		{
		}

		// Token: 0x06029648 RID: 169544 RVA: 0x009C3214 File Offset: 0x009C1414
		public SLockOnFollowShooterAttachmentRule(FName Socket, TEnumAsByte<BPEDetachmentRule> DetachLocationRule, TEnumAsByte<BPEDetachmentRule> DetachRotationRule, TEnumAsByte<BPEDetachmentRule> DetachScaleRule, TEnumAsByte<BPEFollowShooterAttachStrategy> AttachStrategy, TEnumAsByte<BPEAttachmentRule> AttachLocationRule, TEnumAsByte<BPEAttachmentRule> AttachRotationRule, TEnumAsByte<BPEAttachmentRule> AttachScaleRule, bool AbsoluteLocation, bool AbsoluteRotation, bool AbsoluteScale)
		{
			this.Socket = Socket;
			this.DetachLocationRule = DetachLocationRule;
			this.DetachRotationRule = DetachRotationRule;
			this.DetachScaleRule = DetachScaleRule;
			this.AttachStrategy = AttachStrategy;
			this.AttachLocationRule = AttachLocationRule;
			this.AttachRotationRule = AttachRotationRule;
			this.AttachScaleRule = AttachScaleRule;
			this.AbsoluteLocation = AbsoluteLocation;
			this.AbsoluteRotation = AbsoluteRotation;
			this.AbsoluteScale = AbsoluteScale;
		}

		// Token: 0x06029649 RID: 169545 RVA: 0x009C327C File Offset: 0x009C147C
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnFollowShooterAttachmentRule.StaticStruct();
		}

		// Token: 0x0602964A RID: 169546 RVA: 0x009C3288 File Offset: 0x009C1488
		[NullableContext(2)]
		public SLockOnFollowShooterAttachmentRule(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602964B RID: 169547 RVA: 0x009C3292 File Offset: 0x009C1492
		public SLockOnFollowShooterAttachmentRule(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602964C RID: 169548 RVA: 0x009C329D File Offset: 0x009C149D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnFollowShooterAttachmentRule(Pointer, false, true);
		}

		// Token: 0x0602964D RID: 169549 RVA: 0x009C32A7 File Offset: 0x009C14A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnFollowShooterAttachmentRule(Pointer, MemoryOwner);
		}

		// Token: 0x04015352 RID: 86866
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAttachmentRule.SLockOnFollowShooterAttachmentRule";

		// Token: 0x04015353 RID: 86867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015354 RID: 86868
		internal static int __PropertyOffset_0;

		// Token: 0x04015355 RID: 86869
		internal static int __PropertyOffset_1;

		// Token: 0x04015356 RID: 86870
		internal static int __PropertyOffset_2;

		// Token: 0x04015357 RID: 86871
		internal static int __PropertyOffset_3;

		// Token: 0x04015358 RID: 86872
		internal static int __PropertyOffset_4;

		// Token: 0x04015359 RID: 86873
		internal static int __PropertyOffset_5;

		// Token: 0x0401535A RID: 86874
		internal static int __PropertyOffset_6;

		// Token: 0x0401535B RID: 86875
		internal static int __PropertyOffset_7;

		// Token: 0x0401535C RID: 86876
		internal static int __PropertyOffset_8;

		// Token: 0x0401535D RID: 86877
		internal static int __PropertyOffset_9;

		// Token: 0x0401535E RID: 86878
		internal static int __PropertyOffset_10;
	}
}
