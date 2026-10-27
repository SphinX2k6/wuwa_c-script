using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C8 RID: 17352
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_SettingsAdditional.SCameraModifier_SettingsAdditional")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class SCameraModifier_SettingsAdditional : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CE92 RID: 183954 RVA: 0x00A2C00C File Offset: 0x00A2A20C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_SettingsAdditional._ScriptStructPtr != 0) ? SCameraModifier_SettingsAdditional._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_SettingsAdditional.SCameraModifier_SettingsAdditional", ref SCameraModifier_SettingsAdditional._ScriptStructPtr);
		}

		// Token: 0x17007183 RID: 29059
		// (get) Token: 0x0602CE93 RID: 183955 RVA: 0x00A2C030 File Offset: 0x00A2A230
		// (set) Token: 0x0602CE94 RID: 183956 RVA: 0x00A2C044 File Offset: 0x00A2A244
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17007184 RID: 29060
		// (get) Token: 0x0602CE95 RID: 183957 RVA: 0x00A2C059 File Offset: 0x00A2A259
		// (set) Token: 0x0602CE96 RID: 183958 RVA: 0x00A2C069 File Offset: 0x00A2A269
		public unsafe bool IsUseArmLengthFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007185 RID: 29061
		// (get) Token: 0x0602CE97 RID: 183959 RVA: 0x00A2C07C File Offset: 0x00A2A27C
		// (set) Token: 0x0602CE98 RID: 183960 RVA: 0x00A2C0BF File Offset: 0x00A2A2BF
		public SFloatCurve ArmLengthFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._ArmLengthFloatCurve) == null)
				{
					result = (this._ArmLengthFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007186 RID: 29062
		// (get) Token: 0x0602CE99 RID: 183961 RVA: 0x00A2C0E0 File Offset: 0x00A2A2E0
		// (set) Token: 0x0602CE9A RID: 183962 RVA: 0x00A2C0F0 File Offset: 0x00A2A2F0
		public unsafe bool IsUseArmRotationFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007187 RID: 29063
		// (get) Token: 0x0602CE9B RID: 183963 RVA: 0x00A2C104 File Offset: 0x00A2A304
		// (set) Token: 0x0602CE9C RID: 183964 RVA: 0x00A2C147 File Offset: 0x00A2A347
		public SFloatCurve ArmRotationFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._ArmRotationFloatCurve) == null)
				{
					result = (this._ArmRotationFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007188 RID: 29064
		// (get) Token: 0x0602CE9D RID: 183965 RVA: 0x00A2C168 File Offset: 0x00A2A368
		// (set) Token: 0x0602CE9E RID: 183966 RVA: 0x00A2C178 File Offset: 0x00A2A378
		public unsafe bool IsUseFovFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007189 RID: 29065
		// (get) Token: 0x0602CE9F RID: 183967 RVA: 0x00A2C18C File Offset: 0x00A2A38C
		// (set) Token: 0x0602CEA0 RID: 183968 RVA: 0x00A2C1CF File Offset: 0x00A2A3CF
		public SFloatCurve FovFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._FovFloatCurve) == null)
				{
					result = (this._FovFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700718A RID: 29066
		// (get) Token: 0x0602CEA1 RID: 183969 RVA: 0x00A2C1F0 File Offset: 0x00A2A3F0
		// (set) Token: 0x0602CEA2 RID: 183970 RVA: 0x00A2C200 File Offset: 0x00A2A400
		public unsafe bool IsModifiedCameraLens
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700718B RID: 29067
		// (get) Token: 0x0602CEA3 RID: 183971 RVA: 0x00A2C211 File Offset: 0x00A2A411
		// (set) Token: 0x0602CEA4 RID: 183972 RVA: 0x00A2C221 File Offset: 0x00A2A421
		public unsafe bool IsUseLensFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700718C RID: 29068
		// (get) Token: 0x0602CEA5 RID: 183973 RVA: 0x00A2C234 File Offset: 0x00A2A434
		// (set) Token: 0x0602CEA6 RID: 183974 RVA: 0x00A2C277 File Offset: 0x00A2A477
		public SFloatCurve LensFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._LensFloatCurve) == null)
				{
					result = (this._LensFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700718D RID: 29069
		// (get) Token: 0x0602CEA7 RID: 183975 RVA: 0x00A2C298 File Offset: 0x00A2A498
		// (set) Token: 0x0602CEA8 RID: 183976 RVA: 0x00A2C2AC File Offset: 0x00A2A4AC
		public unsafe SCameraModifier_Lens CameraLens
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700718E RID: 29070
		// (get) Token: 0x0602CEA9 RID: 183977 RVA: 0x00A2C2C1 File Offset: 0x00A2A4C1
		// (set) Token: 0x0602CEAA RID: 183978 RVA: 0x00A2C2D1 File Offset: 0x00A2A4D1
		public unsafe bool IsUseCameraOffsetFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700718F RID: 29071
		// (get) Token: 0x0602CEAB RID: 183979 RVA: 0x00A2C2E4 File Offset: 0x00A2A4E4
		// (set) Token: 0x0602CEAC RID: 183980 RVA: 0x00A2C327 File Offset: 0x00A2A527
		public SFloatCurve CameraOffsetFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._CameraOffsetFloatCurve) == null)
				{
					result = (this._CameraOffsetFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007190 RID: 29072
		// (get) Token: 0x0602CEAD RID: 183981 RVA: 0x00A2C348 File Offset: 0x00A2A548
		// (set) Token: 0x0602CEAE RID: 183982 RVA: 0x00A2C358 File Offset: 0x00A2A558
		public unsafe bool IsModifiedArmOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007191 RID: 29073
		// (get) Token: 0x0602CEAF RID: 183983 RVA: 0x00A2C369 File Offset: 0x00A2A569
		// (set) Token: 0x0602CEB0 RID: 183984 RVA: 0x00A2C37D File Offset: 0x00A2A57D
		public unsafe FVector ArmOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17007192 RID: 29074
		// (get) Token: 0x0602CEB1 RID: 183985 RVA: 0x00A2C392 File Offset: 0x00A2A592
		// (set) Token: 0x0602CEB2 RID: 183986 RVA: 0x00A2C3A2 File Offset: 0x00A2A5A2
		public unsafe bool IsUseArmOffsetFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007193 RID: 29075
		// (get) Token: 0x0602CEB3 RID: 183987 RVA: 0x00A2C3B4 File Offset: 0x00A2A5B4
		// (set) Token: 0x0602CEB4 RID: 183988 RVA: 0x00A2C3F7 File Offset: 0x00A2A5F7
		public SFloatCurve ArmOffsetFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._ArmOffsetFloatCurve) == null)
				{
					result = (this._ArmOffsetFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_16, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602CEB5 RID: 183989 RVA: 0x00A2C418 File Offset: 0x00A2A618
		public SCameraModifier_SettingsAdditional()
		{
		}

		// Token: 0x0602CEB6 RID: 183990 RVA: 0x00A2C420 File Offset: 0x00A2A620
		public SCameraModifier_SettingsAdditional(string Name, bool IsUseArmLengthFloatCurve, SFloatCurve ArmLengthFloatCurve, bool IsUseArmRotationFloatCurve, SFloatCurve ArmRotationFloatCurve, bool IsUseFovFloatCurve, SFloatCurve FovFloatCurve, bool IsModifiedCameraLens, bool IsUseLensFloatCurve, SFloatCurve LensFloatCurve, SCameraModifier_Lens CameraLens, bool IsUseCameraOffsetFloatCurve, SFloatCurve CameraOffsetFloatCurve, bool IsModifiedArmOffset, FVector ArmOffset, bool IsUseArmOffsetFloatCurve, SFloatCurve ArmOffsetFloatCurve)
		{
			this.Name = Name;
			this.IsUseArmLengthFloatCurve = IsUseArmLengthFloatCurve;
			this.ArmLengthFloatCurve = ArmLengthFloatCurve;
			this.IsUseArmRotationFloatCurve = IsUseArmRotationFloatCurve;
			this.ArmRotationFloatCurve = ArmRotationFloatCurve;
			this.IsUseFovFloatCurve = IsUseFovFloatCurve;
			this.FovFloatCurve = FovFloatCurve;
			this.IsModifiedCameraLens = IsModifiedCameraLens;
			this.IsUseLensFloatCurve = IsUseLensFloatCurve;
			this.LensFloatCurve = LensFloatCurve;
			this.CameraLens = CameraLens;
			this.IsUseCameraOffsetFloatCurve = IsUseCameraOffsetFloatCurve;
			this.CameraOffsetFloatCurve = CameraOffsetFloatCurve;
			this.IsModifiedArmOffset = IsModifiedArmOffset;
			this.ArmOffset = ArmOffset;
			this.IsUseArmOffsetFloatCurve = IsUseArmOffsetFloatCurve;
			this.ArmOffsetFloatCurve = ArmOffsetFloatCurve;
		}

		// Token: 0x0602CEB7 RID: 183991 RVA: 0x00A2C4B8 File Offset: 0x00A2A6B8
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier_SettingsAdditional.StaticStruct();
		}

		// Token: 0x0602CEB8 RID: 183992 RVA: 0x00A2C4C4 File Offset: 0x00A2A6C4
		[NullableContext(2)]
		public SCameraModifier_SettingsAdditional(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CEB9 RID: 183993 RVA: 0x00A2C4CE File Offset: 0x00A2A6CE
		public SCameraModifier_SettingsAdditional(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CEBA RID: 183994 RVA: 0x00A2C4D9 File Offset: 0x00A2A6D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier_SettingsAdditional(Pointer, false, true);
		}

		// Token: 0x0602CEBB RID: 183995 RVA: 0x00A2C4E3 File Offset: 0x00A2A6E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier_SettingsAdditional(Pointer, MemoryOwner);
		}

		// Token: 0x04017D4F RID: 97615
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_SettingsAdditional.SCameraModifier_SettingsAdditional";

		// Token: 0x04017D50 RID: 97616
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017D51 RID: 97617
		internal static int __PropertyOffset_0;

		// Token: 0x04017D52 RID: 97618
		internal static int __PropertyOffset_1;

		// Token: 0x04017D53 RID: 97619
		internal static int __PropertyOffset_2;

		// Token: 0x04017D54 RID: 97620
		[Nullable(2)]
		private SFloatCurve _ArmLengthFloatCurve;

		// Token: 0x04017D55 RID: 97621
		internal static int __PropertyOffset_3;

		// Token: 0x04017D56 RID: 97622
		internal static int __PropertyOffset_4;

		// Token: 0x04017D57 RID: 97623
		[Nullable(2)]
		private SFloatCurve _ArmRotationFloatCurve;

		// Token: 0x04017D58 RID: 97624
		internal static int __PropertyOffset_5;

		// Token: 0x04017D59 RID: 97625
		internal static int __PropertyOffset_6;

		// Token: 0x04017D5A RID: 97626
		[Nullable(2)]
		private SFloatCurve _FovFloatCurve;

		// Token: 0x04017D5B RID: 97627
		internal static int __PropertyOffset_7;

		// Token: 0x04017D5C RID: 97628
		internal static int __PropertyOffset_8;

		// Token: 0x04017D5D RID: 97629
		internal static int __PropertyOffset_9;

		// Token: 0x04017D5E RID: 97630
		[Nullable(2)]
		private SFloatCurve _LensFloatCurve;

		// Token: 0x04017D5F RID: 97631
		internal static int __PropertyOffset_10;

		// Token: 0x04017D60 RID: 97632
		internal static int __PropertyOffset_11;

		// Token: 0x04017D61 RID: 97633
		internal static int __PropertyOffset_12;

		// Token: 0x04017D62 RID: 97634
		[Nullable(2)]
		private SFloatCurve _CameraOffsetFloatCurve;

		// Token: 0x04017D63 RID: 97635
		internal static int __PropertyOffset_13;

		// Token: 0x04017D64 RID: 97636
		internal static int __PropertyOffset_14;

		// Token: 0x04017D65 RID: 97637
		internal static int __PropertyOffset_15;

		// Token: 0x04017D66 RID: 97638
		internal static int __PropertyOffset_16;

		// Token: 0x04017D67 RID: 97639
		[Nullable(2)]
		private SFloatCurve _ArmOffsetFloatCurve;
	}
}
