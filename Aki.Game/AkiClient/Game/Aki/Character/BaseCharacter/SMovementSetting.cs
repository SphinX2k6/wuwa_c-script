using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004325 RID: 17189
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMovementSetting.SMovementSetting")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SMovementSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C80C RID: 182284 RVA: 0x00A21311 File Offset: 0x00A1F511
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovementSetting._ScriptStructPtr != 0) ? SMovementSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMovementSetting.SMovementSetting", ref SMovementSetting._ScriptStructPtr);
		}

		// Token: 0x17006F8E RID: 28558
		// (get) Token: 0x0602C80D RID: 182285 RVA: 0x00A21335 File Offset: 0x00A1F535
		// (set) Token: 0x0602C80E RID: 182286 RVA: 0x00A21345 File Offset: 0x00A1F545
		public unsafe float WalkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F8F RID: 28559
		// (get) Token: 0x0602C80F RID: 182287 RVA: 0x00A21356 File Offset: 0x00A1F556
		// (set) Token: 0x0602C810 RID: 182288 RVA: 0x00A21366 File Offset: 0x00A1F566
		public unsafe float RunSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F90 RID: 28560
		// (get) Token: 0x0602C811 RID: 182289 RVA: 0x00A21377 File Offset: 0x00A1F577
		// (set) Token: 0x0602C812 RID: 182290 RVA: 0x00A21387 File Offset: 0x00A1F587
		public unsafe float SprintSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F91 RID: 28561
		// (get) Token: 0x0602C813 RID: 182291 RVA: 0x00A21398 File Offset: 0x00A1F598
		// (set) Token: 0x0602C814 RID: 182292 RVA: 0x00A213A8 File Offset: 0x00A1F5A8
		public unsafe float SwingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F92 RID: 28562
		// (get) Token: 0x0602C815 RID: 182293 RVA: 0x00A213B9 File Offset: 0x00A1F5B9
		// (set) Token: 0x0602C816 RID: 182294 RVA: 0x00A213C9 File Offset: 0x00A1F5C9
		public unsafe float Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006F93 RID: 28563
		// (get) Token: 0x0602C817 RID: 182295 RVA: 0x00A213DA File Offset: 0x00A1F5DA
		// (set) Token: 0x0602C818 RID: 182296 RVA: 0x00A213EA File Offset: 0x00A1F5EA
		public unsafe float SwingAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006F94 RID: 28564
		// (get) Token: 0x0602C819 RID: 182297 RVA: 0x00A213FB File Offset: 0x00A1F5FB
		// (set) Token: 0x0602C81A RID: 182298 RVA: 0x00A2140B File Offset: 0x00A1F60B
		public unsafe float GroundFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006F95 RID: 28565
		// (get) Token: 0x0602C81B RID: 182299 RVA: 0x00A2141C File Offset: 0x00A1F61C
		// (set) Token: 0x0602C81C RID: 182300 RVA: 0x00A21430 File Offset: 0x00A1F630
		public unsafe UCurveVector MovementCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SMovementSetting.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMovementSetting.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17006F96 RID: 28566
		// (get) Token: 0x0602C81D RID: 182301 RVA: 0x00A21445 File Offset: 0x00A1F645
		// (set) Token: 0x0602C81E RID: 182302 RVA: 0x00A21459 File Offset: 0x00A1F659
		public unsafe UCurveFloat RotationRateCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SMovementSetting.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMovementSetting.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006F97 RID: 28567
		// (get) Token: 0x0602C81F RID: 182303 RVA: 0x00A2146E File Offset: 0x00A1F66E
		// (set) Token: 0x0602C820 RID: 182304 RVA: 0x00A2147E File Offset: 0x00A1F67E
		public unsafe float NormalSwimSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006F98 RID: 28568
		// (get) Token: 0x0602C821 RID: 182305 RVA: 0x00A2148F File Offset: 0x00A1F68F
		// (set) Token: 0x0602C822 RID: 182306 RVA: 0x00A2149F File Offset: 0x00A1F69F
		public unsafe float FastSwimSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006F99 RID: 28569
		// (get) Token: 0x0602C823 RID: 182307 RVA: 0x00A214B0 File Offset: 0x00A1F6B0
		// (set) Token: 0x0602C824 RID: 182308 RVA: 0x00A214C0 File Offset: 0x00A1F6C0
		public unsafe float ControllerRotationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006F9A RID: 28570
		// (get) Token: 0x0602C825 RID: 182309 RVA: 0x00A214D4 File Offset: 0x00A1F6D4
		// (set) Token: 0x0602C826 RID: 182310 RVA: 0x00A21517 File Offset: 0x00A1F717
		[Nullable(1)]
		public SMovementRotationSetting ControllerRotationSpeedSetting
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SMovementRotationSetting result;
				if ((result = this._ControllerRotationSpeedSetting) == null)
				{
					result = (this._ControllerRotationSpeedSetting = new SMovementRotationSetting(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementRotationSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C827 RID: 182311 RVA: 0x00A21538 File Offset: 0x00A1F738
		public SMovementSetting()
		{
		}

		// Token: 0x0602C828 RID: 182312 RVA: 0x00A21540 File Offset: 0x00A1F740
		[NullableContext(1)]
		public SMovementSetting(float WalkSpeed, float RunSpeed, float SprintSpeed, float SwingSpeed, float Acceleration, float SwingAcceleration, float GroundFriction, UCurveVector MovementCurve, UCurveFloat RotationRateCurve, float NormalSwimSpeed, float FastSwimSpeed, float ControllerRotationSpeed, SMovementRotationSetting ControllerRotationSpeedSetting)
		{
			this.WalkSpeed = WalkSpeed;
			this.RunSpeed = RunSpeed;
			this.SprintSpeed = SprintSpeed;
			this.SwingSpeed = SwingSpeed;
			this.Acceleration = Acceleration;
			this.SwingAcceleration = SwingAcceleration;
			this.GroundFriction = GroundFriction;
			this.MovementCurve = MovementCurve;
			this.RotationRateCurve = RotationRateCurve;
			this.NormalSwimSpeed = NormalSwimSpeed;
			this.FastSwimSpeed = FastSwimSpeed;
			this.ControllerRotationSpeed = ControllerRotationSpeed;
			this.ControllerRotationSpeedSetting = ControllerRotationSpeedSetting;
		}

		// Token: 0x0602C829 RID: 182313 RVA: 0x00A215B8 File Offset: 0x00A1F7B8
		protected override IntPtr GetUStructPtr()
		{
			return SMovementSetting.StaticStruct();
		}

		// Token: 0x0602C82A RID: 182314 RVA: 0x00A215C4 File Offset: 0x00A1F7C4
		public SMovementSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C82B RID: 182315 RVA: 0x00A215CE File Offset: 0x00A1F7CE
		public SMovementSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C82C RID: 182316 RVA: 0x00A215D9 File Offset: 0x00A1F7D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovementSetting(Pointer, false, true);
		}

		// Token: 0x0602C82D RID: 182317 RVA: 0x00A215E3 File Offset: 0x00A1F7E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovementSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04017754 RID: 96084
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMovementSetting.SMovementSetting";

		// Token: 0x04017755 RID: 96085
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017756 RID: 96086
		internal static int __PropertyOffset_0;

		// Token: 0x04017757 RID: 96087
		internal static int __PropertyOffset_1;

		// Token: 0x04017758 RID: 96088
		internal static int __PropertyOffset_2;

		// Token: 0x04017759 RID: 96089
		internal static int __PropertyOffset_3;

		// Token: 0x0401775A RID: 96090
		internal static int __PropertyOffset_4;

		// Token: 0x0401775B RID: 96091
		internal static int __PropertyOffset_5;

		// Token: 0x0401775C RID: 96092
		internal static int __PropertyOffset_6;

		// Token: 0x0401775D RID: 96093
		internal static int __PropertyOffset_7;

		// Token: 0x0401775E RID: 96094
		internal static int __PropertyOffset_8;

		// Token: 0x0401775F RID: 96095
		internal static int __PropertyOffset_9;

		// Token: 0x04017760 RID: 96096
		internal static int __PropertyOffset_10;

		// Token: 0x04017761 RID: 96097
		internal static int __PropertyOffset_11;

		// Token: 0x04017762 RID: 96098
		internal static int __PropertyOffset_12;

		// Token: 0x04017763 RID: 96099
		private SMovementRotationSetting _ControllerRotationSpeedSetting;
	}
}
