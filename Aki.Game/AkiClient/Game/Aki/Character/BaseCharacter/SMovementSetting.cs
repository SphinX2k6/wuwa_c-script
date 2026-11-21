using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200335E RID: 13150
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMovementSetting.SMovementSetting")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SMovementSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021514 RID: 136468 RVA: 0x0095DD58 File Offset: 0x0095BF58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovementSetting._ScriptStructPtr != 0) ? SMovementSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMovementSetting.SMovementSetting", ref SMovementSetting._ScriptStructPtr);
		}

		// Token: 0x170043B9 RID: 17337
		// (get) Token: 0x06021515 RID: 136469 RVA: 0x0095DD7C File Offset: 0x0095BF7C
		// (set) Token: 0x06021516 RID: 136470 RVA: 0x0095DD8C File Offset: 0x0095BF8C
		public unsafe float WalkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_WalkSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_WalkSpeed) = value;
			}
		}

		// Token: 0x170043BA RID: 17338
		// (get) Token: 0x06021517 RID: 136471 RVA: 0x0095DD9D File Offset: 0x0095BF9D
		// (set) Token: 0x06021518 RID: 136472 RVA: 0x0095DDAD File Offset: 0x0095BFAD
		public unsafe float RunSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_RunSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_RunSpeed) = value;
			}
		}

		// Token: 0x170043BB RID: 17339
		// (get) Token: 0x06021519 RID: 136473 RVA: 0x0095DDBE File Offset: 0x0095BFBE
		// (set) Token: 0x0602151A RID: 136474 RVA: 0x0095DDCE File Offset: 0x0095BFCE
		public unsafe float SprintSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_SprintSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_SprintSpeed) = value;
			}
		}

		// Token: 0x170043BC RID: 17340
		// (get) Token: 0x0602151B RID: 136475 RVA: 0x0095DDDF File Offset: 0x0095BFDF
		// (set) Token: 0x0602151C RID: 136476 RVA: 0x0095DDEF File Offset: 0x0095BFEF
		public unsafe float SwingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_SwingSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_SwingSpeed) = value;
			}
		}

		// Token: 0x170043BD RID: 17341
		// (get) Token: 0x0602151D RID: 136477 RVA: 0x0095DE00 File Offset: 0x0095C000
		// (set) Token: 0x0602151E RID: 136478 RVA: 0x0095DE10 File Offset: 0x0095C010
		public unsafe float Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x170043BE RID: 17342
		// (get) Token: 0x0602151F RID: 136479 RVA: 0x0095DE21 File Offset: 0x0095C021
		// (set) Token: 0x06021520 RID: 136480 RVA: 0x0095DE31 File Offset: 0x0095C031
		public unsafe float SwingAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_SwingAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_SwingAcceleration) = value;
			}
		}

		// Token: 0x170043BF RID: 17343
		// (get) Token: 0x06021521 RID: 136481 RVA: 0x0095DE42 File Offset: 0x0095C042
		// (set) Token: 0x06021522 RID: 136482 RVA: 0x0095DE52 File Offset: 0x0095C052
		public unsafe float GroundFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_GroundFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_GroundFriction) = value;
			}
		}

		// Token: 0x170043C0 RID: 17344
		// (get) Token: 0x06021523 RID: 136483 RVA: 0x0095DE63 File Offset: 0x0095C063
		// (set) Token: 0x06021524 RID: 136484 RVA: 0x0095DE77 File Offset: 0x0095C077
		public unsafe UCurveVector MovementCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SMovementSetting.__PropertyOffset_MovementCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMovementSetting.__PropertyOffset_MovementCurve, value);
			}
		}

		// Token: 0x170043C1 RID: 17345
		// (get) Token: 0x06021525 RID: 136485 RVA: 0x0095DE8C File Offset: 0x0095C08C
		// (set) Token: 0x06021526 RID: 136486 RVA: 0x0095DEA0 File Offset: 0x0095C0A0
		public unsafe UCurveFloat RotationRateCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SMovementSetting.__PropertyOffset_RotationRateCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMovementSetting.__PropertyOffset_RotationRateCurve, value);
			}
		}

		// Token: 0x170043C2 RID: 17346
		// (get) Token: 0x06021527 RID: 136487 RVA: 0x0095DEB5 File Offset: 0x0095C0B5
		// (set) Token: 0x06021528 RID: 136488 RVA: 0x0095DEC5 File Offset: 0x0095C0C5
		public unsafe float NormalSwimSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_NormalSwimSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_NormalSwimSpeed) = value;
			}
		}

		// Token: 0x170043C3 RID: 17347
		// (get) Token: 0x06021529 RID: 136489 RVA: 0x0095DED6 File Offset: 0x0095C0D6
		// (set) Token: 0x0602152A RID: 136490 RVA: 0x0095DEE6 File Offset: 0x0095C0E6
		public unsafe float FastSwimSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_FastSwimSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_FastSwimSpeed) = value;
			}
		}

		// Token: 0x170043C4 RID: 17348
		// (get) Token: 0x0602152B RID: 136491 RVA: 0x0095DEF7 File Offset: 0x0095C0F7
		// (set) Token: 0x0602152C RID: 136492 RVA: 0x0095DF07 File Offset: 0x0095C107
		public unsafe float ControllerRotationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_ControllerRotationSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_ControllerRotationSpeed) = value;
			}
		}

		// Token: 0x170043C5 RID: 17349
		// (get) Token: 0x0602152D RID: 136493 RVA: 0x0095DF18 File Offset: 0x0095C118
		// (set) Token: 0x0602152E RID: 136494 RVA: 0x0095DF5B File Offset: 0x0095C15B
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
					result = (this._ControllerRotationSpeedSetting = new SMovementRotationSetting(base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_ControllerRotationSpeedSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementRotationSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting.__PropertyOffset_ControllerRotationSpeedSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602152F RID: 136495 RVA: 0x0095DF7C File Offset: 0x0095C17C
		public SMovementSetting()
		{
		}

		// Token: 0x06021530 RID: 136496 RVA: 0x0095DF84 File Offset: 0x0095C184
		protected override IntPtr GetUStructPtr()
		{
			return SMovementSetting.StaticStruct();
		}

		// Token: 0x06021531 RID: 136497 RVA: 0x0095DF90 File Offset: 0x0095C190
		public SMovementSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021532 RID: 136498 RVA: 0x0095DF9A File Offset: 0x0095C19A
		public SMovementSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021533 RID: 136499 RVA: 0x0095DFA5 File Offset: 0x0095C1A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovementSetting(Pointer, false, true);
		}

		// Token: 0x06021534 RID: 136500 RVA: 0x0095DFAF File Offset: 0x0095C1AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovementSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04012358 RID: 74584
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMovementSetting.SMovementSetting";

		// Token: 0x04012359 RID: 74585
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401235A RID: 74586
		internal static int __PropertyOffset_WalkSpeed;

		// Token: 0x0401235B RID: 74587
		internal static int __PropertyOffset_RunSpeed;

		// Token: 0x0401235C RID: 74588
		internal static int __PropertyOffset_SprintSpeed;

		// Token: 0x0401235D RID: 74589
		internal static int __PropertyOffset_SwingSpeed;

		// Token: 0x0401235E RID: 74590
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x0401235F RID: 74591
		internal static int __PropertyOffset_SwingAcceleration;

		// Token: 0x04012360 RID: 74592
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x04012361 RID: 74593
		internal static int __PropertyOffset_MovementCurve;

		// Token: 0x04012362 RID: 74594
		internal static int __PropertyOffset_RotationRateCurve;

		// Token: 0x04012363 RID: 74595
		internal static int __PropertyOffset_NormalSwimSpeed;

		// Token: 0x04012364 RID: 74596
		internal static int __PropertyOffset_FastSwimSpeed;

		// Token: 0x04012365 RID: 74597
		internal static int __PropertyOffset_ControllerRotationSpeed;

		// Token: 0x04012366 RID: 74598
		internal static int __PropertyOffset_ControllerRotationSpeedSetting;

		// Token: 0x04012367 RID: 74599
		private SMovementRotationSetting _ControllerRotationSpeedSetting;
	}
}
