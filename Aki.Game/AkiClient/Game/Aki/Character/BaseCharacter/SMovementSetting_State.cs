using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004327 RID: 17191
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMovementSetting_State.SMovementSetting_State")]
	[UnrealStructLayout(1752, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1748)]
	public class SMovementSetting_State : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C83A RID: 182330 RVA: 0x00A2172A File Offset: 0x00A1F92A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovementSetting_State._ScriptStructPtr != 0) ? SMovementSetting_State._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMovementSetting_State.SMovementSetting_State", ref SMovementSetting_State._ScriptStructPtr);
		}

		// Token: 0x17006F9D RID: 28573
		// (get) Token: 0x0602C83B RID: 182331 RVA: 0x00A21750 File Offset: 0x00A1F950
		// (set) Token: 0x0602C83C RID: 182332 RVA: 0x00A21793 File Offset: 0x00A1F993
		public SMovementSetting_Posture FaceDirection
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._FaceDirection) == null)
				{
					result = (this._FaceDirection = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F9E RID: 28574
		// (get) Token: 0x0602C83D RID: 182333 RVA: 0x00A217B4 File Offset: 0x00A1F9B4
		// (set) Token: 0x0602C83E RID: 182334 RVA: 0x00A217F7 File Offset: 0x00A1F9F7
		public SMovementSetting_Posture LockDirection
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._LockDirection) == null)
				{
					result = (this._LockDirection = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F9F RID: 28575
		// (get) Token: 0x0602C83F RID: 182335 RVA: 0x00A21818 File Offset: 0x00A1FA18
		// (set) Token: 0x0602C840 RID: 182336 RVA: 0x00A2185B File Offset: 0x00A1FA5B
		public SMovementSetting_Posture AimDirection
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._AimDirection) == null)
				{
					result = (this._AimDirection = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FA0 RID: 28576
		// (get) Token: 0x0602C841 RID: 182337 RVA: 0x00A2187C File Offset: 0x00A1FA7C
		// (set) Token: 0x0602C842 RID: 182338 RVA: 0x00A218BF File Offset: 0x00A1FABF
		public SMovementSetting_Posture CustomSetting00
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting00) == null)
				{
					result = (this._CustomSetting00 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FA1 RID: 28577
		// (get) Token: 0x0602C843 RID: 182339 RVA: 0x00A218E0 File Offset: 0x00A1FAE0
		// (set) Token: 0x0602C844 RID: 182340 RVA: 0x00A21923 File Offset: 0x00A1FB23
		public SMovementSetting_Posture CustomSetting01
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting01) == null)
				{
					result = (this._CustomSetting01 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FA2 RID: 28578
		// (get) Token: 0x0602C845 RID: 182341 RVA: 0x00A21944 File Offset: 0x00A1FB44
		// (set) Token: 0x0602C846 RID: 182342 RVA: 0x00A21987 File Offset: 0x00A1FB87
		public SMovementSetting_Posture CustomSetting02
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting02) == null)
				{
					result = (this._CustomSetting02 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FA3 RID: 28579
		// (get) Token: 0x0602C847 RID: 182343 RVA: 0x00A219A8 File Offset: 0x00A1FBA8
		// (set) Token: 0x0602C848 RID: 182344 RVA: 0x00A219EB File Offset: 0x00A1FBEB
		public SMovementSetting_Posture CustomSetting03
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting03) == null)
				{
					result = (this._CustomSetting03 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FA4 RID: 28580
		// (get) Token: 0x0602C849 RID: 182345 RVA: 0x00A21A0C File Offset: 0x00A1FC0C
		// (set) Token: 0x0602C84A RID: 182346 RVA: 0x00A21A4F File Offset: 0x00A1FC4F
		public SMovementSetting_Posture CustomSetting04
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting04) == null)
				{
					result = (this._CustomSetting04 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FA5 RID: 28581
		// (get) Token: 0x0602C84B RID: 182347 RVA: 0x00A21A70 File Offset: 0x00A1FC70
		// (set) Token: 0x0602C84C RID: 182348 RVA: 0x00A21AB3 File Offset: 0x00A1FCB3
		public SMovementSetting_Posture CustomSetting05
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting_Posture result;
				if ((result = this._CustomSetting05) == null)
				{
					result = (this._CustomSetting05 = new SMovementSetting_Posture(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_Posture.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006FA6 RID: 28582
		// (get) Token: 0x0602C84D RID: 182349 RVA: 0x00A21AD4 File Offset: 0x00A1FCD4
		// (set) Token: 0x0602C84E RID: 182350 RVA: 0x00A21AE8 File Offset: 0x00A1FCE8
		[Nullable(0)]
		public unsafe TEnumAsByte<EWanderDirectionType> WanderDirection
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_9);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006FA7 RID: 28583
		// (get) Token: 0x0602C84F RID: 182351 RVA: 0x00A21AFD File Offset: 0x00A1FCFD
		// (set) Token: 0x0602C850 RID: 182352 RVA: 0x00A21B11 File Offset: 0x00A1FD11
		public unsafe FGameplayTag EnableTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006FA8 RID: 28584
		// (get) Token: 0x0602C851 RID: 182353 RVA: 0x00A21B26 File Offset: 0x00A1FD26
		// (set) Token: 0x0602C852 RID: 182354 RVA: 0x00A21B36 File Offset: 0x00A1FD36
		public unsafe float WalkableFloorAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting_State.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x0602C853 RID: 182355 RVA: 0x00A21B47 File Offset: 0x00A1FD47
		public SMovementSetting_State()
		{
		}

		// Token: 0x0602C854 RID: 182356 RVA: 0x00A21B50 File Offset: 0x00A1FD50
		public SMovementSetting_State(SMovementSetting_Posture FaceDirection, SMovementSetting_Posture LockDirection, SMovementSetting_Posture AimDirection, SMovementSetting_Posture CustomSetting00, SMovementSetting_Posture CustomSetting01, SMovementSetting_Posture CustomSetting02, SMovementSetting_Posture CustomSetting03, SMovementSetting_Posture CustomSetting04, SMovementSetting_Posture CustomSetting05, [Nullable(0)] TEnumAsByte<EWanderDirectionType> WanderDirection, FGameplayTag EnableTag, float WalkableFloorAngle)
		{
			this.FaceDirection = FaceDirection;
			this.LockDirection = LockDirection;
			this.AimDirection = AimDirection;
			this.CustomSetting00 = CustomSetting00;
			this.CustomSetting01 = CustomSetting01;
			this.CustomSetting02 = CustomSetting02;
			this.CustomSetting03 = CustomSetting03;
			this.CustomSetting04 = CustomSetting04;
			this.CustomSetting05 = CustomSetting05;
			this.WanderDirection = WanderDirection;
			this.EnableTag = EnableTag;
			this.WalkableFloorAngle = WalkableFloorAngle;
		}

		// Token: 0x0602C855 RID: 182357 RVA: 0x00A21BC0 File Offset: 0x00A1FDC0
		protected override IntPtr GetUStructPtr()
		{
			return SMovementSetting_State.StaticStruct();
		}

		// Token: 0x0602C856 RID: 182358 RVA: 0x00A21BCC File Offset: 0x00A1FDCC
		[NullableContext(2)]
		public SMovementSetting_State(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C857 RID: 182359 RVA: 0x00A21BD6 File Offset: 0x00A1FDD6
		public SMovementSetting_State(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C858 RID: 182360 RVA: 0x00A21BE1 File Offset: 0x00A1FDE1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovementSetting_State(Pointer, false, true);
		}

		// Token: 0x0602C859 RID: 182361 RVA: 0x00A21BEB File Offset: 0x00A1FDEB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovementSetting_State(Pointer, MemoryOwner);
		}

		// Token: 0x0401776A RID: 96106
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMovementSetting_State.SMovementSetting_State";

		// Token: 0x0401776B RID: 96107
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401776C RID: 96108
		internal static int __PropertyOffset_0;

		// Token: 0x0401776D RID: 96109
		[Nullable(2)]
		private SMovementSetting_Posture _FaceDirection;

		// Token: 0x0401776E RID: 96110
		internal static int __PropertyOffset_1;

		// Token: 0x0401776F RID: 96111
		[Nullable(2)]
		private SMovementSetting_Posture _LockDirection;

		// Token: 0x04017770 RID: 96112
		internal static int __PropertyOffset_2;

		// Token: 0x04017771 RID: 96113
		[Nullable(2)]
		private SMovementSetting_Posture _AimDirection;

		// Token: 0x04017772 RID: 96114
		internal static int __PropertyOffset_3;

		// Token: 0x04017773 RID: 96115
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting00;

		// Token: 0x04017774 RID: 96116
		internal static int __PropertyOffset_4;

		// Token: 0x04017775 RID: 96117
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting01;

		// Token: 0x04017776 RID: 96118
		internal static int __PropertyOffset_5;

		// Token: 0x04017777 RID: 96119
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting02;

		// Token: 0x04017778 RID: 96120
		internal static int __PropertyOffset_6;

		// Token: 0x04017779 RID: 96121
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting03;

		// Token: 0x0401777A RID: 96122
		internal static int __PropertyOffset_7;

		// Token: 0x0401777B RID: 96123
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting04;

		// Token: 0x0401777C RID: 96124
		internal static int __PropertyOffset_8;

		// Token: 0x0401777D RID: 96125
		[Nullable(2)]
		private SMovementSetting_Posture _CustomSetting05;

		// Token: 0x0401777E RID: 96126
		internal static int __PropertyOffset_9;

		// Token: 0x0401777F RID: 96127
		internal static int __PropertyOffset_10;

		// Token: 0x04017780 RID: 96128
		internal static int __PropertyOffset_11;
	}
}
