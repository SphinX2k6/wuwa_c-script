using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003360 RID: 13152
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMovementSetting_State.SMovementSetting_State")]
	[UnrealStructLayout(1912, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1912)]
	public class SMovementSetting_State : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021540 RID: 136512 RVA: 0x0095E0E0 File Offset: 0x0095C2E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovementSetting_State._ScriptStructPtr != 0) ? SMovementSetting_State._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMovementSetting_State.SMovementSetting_State", ref SMovementSetting_State._ScriptStructPtr);
		}

		// Token: 0x170043C8 RID: 17352
		// (get) Token: 0x06021541 RID: 136513 RVA: 0x0095E104 File Offset: 0x0095C304
		// (set) Token: 0x06021542 RID: 136514 RVA: 0x0095E147 File Offset: 0x0095C347
		public SMovementSetting_Posture FaceDirection
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._FaceDirection) == null)
				{
					result = (this._FaceDirection = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_FaceDirection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_FaceDirection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043C9 RID: 17353
		// (get) Token: 0x06021543 RID: 136515 RVA: 0x0095E168 File Offset: 0x0095C368
		// (set) Token: 0x06021544 RID: 136516 RVA: 0x0095E1AB File Offset: 0x0095C3AB
		public SMovementSetting_Posture LockDirection
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._LockDirection) == null)
				{
					result = (this._LockDirection = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_LockDirection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_LockDirection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043CA RID: 17354
		// (get) Token: 0x06021545 RID: 136517 RVA: 0x0095E1CC File Offset: 0x0095C3CC
		// (set) Token: 0x06021546 RID: 136518 RVA: 0x0095E20F File Offset: 0x0095C40F
		public SMovementSetting_Posture AimDirection
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._AimDirection) == null)
				{
					result = (this._AimDirection = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_AimDirection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_AimDirection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043CB RID: 17355
		// (get) Token: 0x06021547 RID: 136519 RVA: 0x0095E230 File Offset: 0x0095C430
		// (set) Token: 0x06021548 RID: 136520 RVA: 0x0095E273 File Offset: 0x0095C473
		public SMovementSetting_Posture CustomSetting00
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting00) == null)
				{
					result = (this._CustomSetting00 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting00, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting00, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043CC RID: 17356
		// (get) Token: 0x06021549 RID: 136521 RVA: 0x0095E294 File Offset: 0x0095C494
		// (set) Token: 0x0602154A RID: 136522 RVA: 0x0095E2D7 File Offset: 0x0095C4D7
		public SMovementSetting_Posture CustomSetting01
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting01) == null)
				{
					result = (this._CustomSetting01 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting01, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting01, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043CD RID: 17357
		// (get) Token: 0x0602154B RID: 136523 RVA: 0x0095E2F8 File Offset: 0x0095C4F8
		// (set) Token: 0x0602154C RID: 136524 RVA: 0x0095E33B File Offset: 0x0095C53B
		public SMovementSetting_Posture CustomSetting02
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting02) == null)
				{
					result = (this._CustomSetting02 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting02, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting02, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043CE RID: 17358
		// (get) Token: 0x0602154D RID: 136525 RVA: 0x0095E35C File Offset: 0x0095C55C
		// (set) Token: 0x0602154E RID: 136526 RVA: 0x0095E39F File Offset: 0x0095C59F
		public SMovementSetting_Posture CustomSetting03
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting03) == null)
				{
					result = (this._CustomSetting03 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting03, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting03, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043CF RID: 17359
		// (get) Token: 0x0602154F RID: 136527 RVA: 0x0095E3C0 File Offset: 0x0095C5C0
		// (set) Token: 0x06021550 RID: 136528 RVA: 0x0095E403 File Offset: 0x0095C603
		public SMovementSetting_Posture CustomSetting04
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting04) == null)
				{
					result = (this._CustomSetting04 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting04, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting04, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043D0 RID: 17360
		// (get) Token: 0x06021551 RID: 136529 RVA: 0x0095E424 File Offset: 0x0095C624
		// (set) Token: 0x06021552 RID: 136530 RVA: 0x0095E467 File Offset: 0x0095C667
		public SMovementSetting_Posture CustomSetting05
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting05) == null)
				{
					result = (this._CustomSetting05 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting05, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomSetting05, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043D1 RID: 17361
		// (get) Token: 0x06021553 RID: 136531 RVA: 0x0095E488 File Offset: 0x0095C688
		// (set) Token: 0x06021554 RID: 136532 RVA: 0x0095E49C File Offset: 0x0095C69C
		[Nullable(0)]
		public unsafe TEnumAsByte<EWanderDirectionType> WanderDirection
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_WanderDirection);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_WanderDirection) = value;
			}
		}

		// Token: 0x170043D2 RID: 17362
		// (get) Token: 0x06021555 RID: 136533 RVA: 0x0095E4B1 File Offset: 0x0095C6B1
		// (set) Token: 0x06021556 RID: 136534 RVA: 0x0095E4C5 File Offset: 0x0095C6C5
		public unsafe FGameplayTag EnableTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_EnableTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_EnableTag) = value;
			}
		}

		// Token: 0x170043D3 RID: 17363
		// (get) Token: 0x06021557 RID: 136535 RVA: 0x0095E4DA File Offset: 0x0095C6DA
		// (set) Token: 0x06021558 RID: 136536 RVA: 0x0095E4EA File Offset: 0x0095C6EA
		public unsafe float WalkableFloorAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_WalkableFloorAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_WalkableFloorAngle) = value;
			}
		}

		// Token: 0x170043D4 RID: 17364
		// (get) Token: 0x06021559 RID: 136537 RVA: 0x0095E4FC File Offset: 0x0095C6FC
		// (set) Token: 0x0602155A RID: 136538 RVA: 0x0095E53F File Offset: 0x0095C73F
		public TMap<int, TSoftObjectPtr<UDataTable>> CustomMovementDataTableMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, TSoftObjectPtr<UDataTable>> result;
				if ((result = this._CustomMovementDataTableMap) == null)
				{
					result = (this._CustomMovementDataTableMap = new TMap<int, TSoftObjectPtr<UDataTable>>(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomMovementDataTableMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomMovementDataTableMap.CopyAssign(value);
			}
		}

		// Token: 0x170043D5 RID: 17365
		// (get) Token: 0x0602155B RID: 136539 RVA: 0x0095E550 File Offset: 0x0095C750
		// (set) Token: 0x0602155C RID: 136540 RVA: 0x0095E593 File Offset: 0x0095C793
		public TMap<EKuroCustomMovementMode, TSoftObjectPtr<UDataTable>> CustomMovementDTMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroCustomMovementMode, TSoftObjectPtr<UDataTable>> result;
				if ((result = this._CustomMovementDTMap) == null)
				{
					result = (this._CustomMovementDTMap = new TMap<EKuroCustomMovementMode, TSoftObjectPtr<UDataTable>>(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_CustomMovementDTMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomMovementDTMap.CopyAssign(value);
			}
		}

		// Token: 0x0602155D RID: 136541 RVA: 0x0095E5A1 File Offset: 0x0095C7A1
		public SMovementSetting_State()
		{
		}

		// Token: 0x0602155E RID: 136542 RVA: 0x0095E5A9 File Offset: 0x0095C7A9
		protected override IntPtr GetUStructPtr()
		{
			return SMovementSetting_State.StaticStruct();
		}

		// Token: 0x0602155F RID: 136543 RVA: 0x0095E5B5 File Offset: 0x0095C7B5
		[NullableContext(2)]
		public SMovementSetting_State(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021560 RID: 136544 RVA: 0x0095E5BF File Offset: 0x0095C7BF
		public SMovementSetting_State(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021561 RID: 136545 RVA: 0x0095E5CA File Offset: 0x0095C7CA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovementSetting_State(Pointer, false, true);
		}

		// Token: 0x06021562 RID: 136546 RVA: 0x0095E5D4 File Offset: 0x0095C7D4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovementSetting_State(Pointer, MemoryOwner);
		}

		// Token: 0x0401236E RID: 74606
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMovementSetting_State.SMovementSetting_State";

		// Token: 0x0401236F RID: 74607
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012370 RID: 74608
		internal static int __PropertyOffset_FaceDirection;

		// Token: 0x04012371 RID: 74609
		[Nullable(2)]
		private SMovementSetting_Posture _FaceDirection;

		// Token: 0x04012372 RID: 74610
		internal static int __PropertyOffset_LockDirection;

		// Token: 0x04012373 RID: 74611
		[Nullable(2)]
		private SMovementSetting_Posture _LockDirection;

		// Token: 0x04012374 RID: 74612
		internal static int __PropertyOffset_AimDirection;

		// Token: 0x04012375 RID: 74613
		[Nullable(2)]
		private SMovementSetting_Posture _AimDirection;

		// Token: 0x04012376 RID: 74614
		internal static int __PropertyOffset_CustomSetting00;

		// Token: 0x04012377 RID: 74615
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting00;

		// Token: 0x04012378 RID: 74616
		internal static int __PropertyOffset_CustomSetting01;

		// Token: 0x04012379 RID: 74617
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting01;

		// Token: 0x0401237A RID: 74618
		internal static int __PropertyOffset_CustomSetting02;

		// Token: 0x0401237B RID: 74619
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting02;

		// Token: 0x0401237C RID: 74620
		internal static int __PropertyOffset_CustomSetting03;

		// Token: 0x0401237D RID: 74621
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting03;

		// Token: 0x0401237E RID: 74622
		internal static int __PropertyOffset_CustomSetting04;

		// Token: 0x0401237F RID: 74623
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting04;

		// Token: 0x04012380 RID: 74624
		internal static int __PropertyOffset_CustomSetting05;

		// Token: 0x04012381 RID: 74625
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting05;

		// Token: 0x04012382 RID: 74626
		internal static int __PropertyOffset_WanderDirection;

		// Token: 0x04012383 RID: 74627
		internal static int __PropertyOffset_EnableTag;

		// Token: 0x04012384 RID: 74628
		internal static int __PropertyOffset_WalkableFloorAngle;

		// Token: 0x04012385 RID: 74629
		internal static int __PropertyOffset_CustomMovementDataTableMap;

		// Token: 0x04012386 RID: 74630
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<int, TSoftObjectPtr<UDataTable>> _CustomMovementDataTableMap;

		// Token: 0x04012387 RID: 74631
		internal static int __PropertyOffset_CustomMovementDTMap;

		// Token: 0x04012388 RID: 74632
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<EKuroCustomMovementMode, TSoftObjectPtr<UDataTable>> _CustomMovementDTMap;
	}
}
