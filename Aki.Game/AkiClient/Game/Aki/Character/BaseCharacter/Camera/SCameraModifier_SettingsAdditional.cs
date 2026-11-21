using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E3 RID: 13283
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_SettingsAdditional.SCameraModifier_SettingsAdditional")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class SCameraModifier_SettingsAdditional : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021A96 RID: 137878 RVA: 0x009667C4 File Offset: 0x009649C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_SettingsAdditional._ScriptStructPtr != 0) ? SCameraModifier_SettingsAdditional._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_SettingsAdditional.SCameraModifier_SettingsAdditional", ref SCameraModifier_SettingsAdditional._ScriptStructPtr);
		}

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x06021A97 RID: 137879 RVA: 0x009667E8 File Offset: 0x009649E8
		// (set) Token: 0x06021A98 RID: 137880 RVA: 0x009667FC File Offset: 0x009649FC
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17004584 RID: 17796
		// (get) Token: 0x06021A99 RID: 137881 RVA: 0x00966811 File Offset: 0x00964A11
		// (set) Token: 0x06021A9A RID: 137882 RVA: 0x00966821 File Offset: 0x00964A21
		public unsafe bool IsUseArmLengthFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseArmLengthFloatCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseArmLengthFloatCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004585 RID: 17797
		// (get) Token: 0x06021A9B RID: 137883 RVA: 0x00966834 File Offset: 0x00964A34
		// (set) Token: 0x06021A9C RID: 137884 RVA: 0x00966877 File Offset: 0x00964A77
		public SFloatCurve ArmLengthFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._ArmLengthFloatCurve) == null)
				{
					result = (this._ArmLengthFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_ArmLengthFloatCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_ArmLengthFloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004586 RID: 17798
		// (get) Token: 0x06021A9D RID: 137885 RVA: 0x00966898 File Offset: 0x00964A98
		// (set) Token: 0x06021A9E RID: 137886 RVA: 0x009668A8 File Offset: 0x00964AA8
		public unsafe bool IsUseArmRotationFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseArmRotationFloatCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseArmRotationFloatCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004587 RID: 17799
		// (get) Token: 0x06021A9F RID: 137887 RVA: 0x009668BC File Offset: 0x00964ABC
		// (set) Token: 0x06021AA0 RID: 137888 RVA: 0x009668FF File Offset: 0x00964AFF
		public SFloatCurve ArmRotationFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._ArmRotationFloatCurve) == null)
				{
					result = (this._ArmRotationFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_ArmRotationFloatCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_ArmRotationFloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004588 RID: 17800
		// (get) Token: 0x06021AA1 RID: 137889 RVA: 0x00966920 File Offset: 0x00964B20
		// (set) Token: 0x06021AA2 RID: 137890 RVA: 0x00966930 File Offset: 0x00964B30
		public unsafe bool IsUseFovFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseFovFloatCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseFovFloatCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004589 RID: 17801
		// (get) Token: 0x06021AA3 RID: 137891 RVA: 0x00966944 File Offset: 0x00964B44
		// (set) Token: 0x06021AA4 RID: 137892 RVA: 0x00966987 File Offset: 0x00964B87
		public SFloatCurve FovFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._FovFloatCurve) == null)
				{
					result = (this._FovFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_FovFloatCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_FovFloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x06021AA5 RID: 137893 RVA: 0x009669A8 File Offset: 0x00964BA8
		// (set) Token: 0x06021AA6 RID: 137894 RVA: 0x009669B8 File Offset: 0x00964BB8
		public unsafe bool IsModifiedCameraLens
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsModifiedCameraLens) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsModifiedCameraLens) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x06021AA7 RID: 137895 RVA: 0x009669C9 File Offset: 0x00964BC9
		// (set) Token: 0x06021AA8 RID: 137896 RVA: 0x009669D9 File Offset: 0x00964BD9
		public unsafe bool IsUseLensFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseLensFloatCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseLensFloatCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x06021AA9 RID: 137897 RVA: 0x009669EC File Offset: 0x00964BEC
		// (set) Token: 0x06021AAA RID: 137898 RVA: 0x00966A2F File Offset: 0x00964C2F
		public SFloatCurve LensFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._LensFloatCurve) == null)
				{
					result = (this._LensFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_LensFloatCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_LensFloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x06021AAB RID: 137899 RVA: 0x00966A50 File Offset: 0x00964C50
		// (set) Token: 0x06021AAC RID: 137900 RVA: 0x00966A64 File Offset: 0x00964C64
		public unsafe SCameraModifier_Lens CameraLens
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_CameraLens);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_CameraLens) = value;
			}
		}

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x06021AAD RID: 137901 RVA: 0x00966A79 File Offset: 0x00964C79
		// (set) Token: 0x06021AAE RID: 137902 RVA: 0x00966A89 File Offset: 0x00964C89
		public unsafe bool IsUseCameraOffsetFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseCameraOffsetFloatCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseCameraOffsetFloatCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x06021AAF RID: 137903 RVA: 0x00966A9C File Offset: 0x00964C9C
		// (set) Token: 0x06021AB0 RID: 137904 RVA: 0x00966ADF File Offset: 0x00964CDF
		public SFloatCurve CameraOffsetFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._CameraOffsetFloatCurve) == null)
				{
					result = (this._CameraOffsetFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_CameraOffsetFloatCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_CameraOffsetFloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004590 RID: 17808
		// (get) Token: 0x06021AB1 RID: 137905 RVA: 0x00966B00 File Offset: 0x00964D00
		// (set) Token: 0x06021AB2 RID: 137906 RVA: 0x00966B10 File Offset: 0x00964D10
		public unsafe bool IsModifiedArmOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsModifiedArmOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsModifiedArmOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004591 RID: 17809
		// (get) Token: 0x06021AB3 RID: 137907 RVA: 0x00966B21 File Offset: 0x00964D21
		// (set) Token: 0x06021AB4 RID: 137908 RVA: 0x00966B35 File Offset: 0x00964D35
		public unsafe FVector ArmOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_ArmOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_ArmOffset) = value;
			}
		}

		// Token: 0x17004592 RID: 17810
		// (get) Token: 0x06021AB5 RID: 137909 RVA: 0x00966B4A File Offset: 0x00964D4A
		// (set) Token: 0x06021AB6 RID: 137910 RVA: 0x00966B5A File Offset: 0x00964D5A
		public unsafe bool IsUseArmOffsetFloatCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseArmOffsetFloatCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_IsUseArmOffsetFloatCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004593 RID: 17811
		// (get) Token: 0x06021AB7 RID: 137911 RVA: 0x00966B6C File Offset: 0x00964D6C
		// (set) Token: 0x06021AB8 RID: 137912 RVA: 0x00966BAF File Offset: 0x00964DAF
		public SFloatCurve ArmOffsetFloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				SFloatCurve result;
				if ((result = this._ArmOffsetFloatCurve) == null)
				{
					result = (this._ArmOffsetFloatCurve = new SFloatCurve(base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_ArmOffsetFloatCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_SettingsAdditional.__PropertyOffset_ArmOffsetFloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021AB9 RID: 137913 RVA: 0x00966BD0 File Offset: 0x00964DD0
		public SCameraModifier_SettingsAdditional()
		{
		}

		// Token: 0x06021ABA RID: 137914 RVA: 0x00966BD8 File Offset: 0x00964DD8
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier_SettingsAdditional.StaticStruct();
		}

		// Token: 0x06021ABB RID: 137915 RVA: 0x00966BE4 File Offset: 0x00964DE4
		[NullableContext(2)]
		public SCameraModifier_SettingsAdditional(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021ABC RID: 137916 RVA: 0x00966BEE File Offset: 0x00964DEE
		public SCameraModifier_SettingsAdditional(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021ABD RID: 137917 RVA: 0x00966BF9 File Offset: 0x00964DF9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier_SettingsAdditional(Pointer, false, true);
		}

		// Token: 0x06021ABE RID: 137918 RVA: 0x00966C03 File Offset: 0x00964E03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier_SettingsAdditional(Pointer, MemoryOwner);
		}

		// Token: 0x040128B7 RID: 75959
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_SettingsAdditional.SCameraModifier_SettingsAdditional";

		// Token: 0x040128B8 RID: 75960
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128B9 RID: 75961
		internal static int __PropertyOffset_Name;

		// Token: 0x040128BA RID: 75962
		internal static int __PropertyOffset_IsUseArmLengthFloatCurve;

		// Token: 0x040128BB RID: 75963
		internal static int __PropertyOffset_ArmLengthFloatCurve;

		// Token: 0x040128BC RID: 75964
		[Nullable(2)]
		private SFloatCurve _ArmLengthFloatCurve;

		// Token: 0x040128BD RID: 75965
		internal static int __PropertyOffset_IsUseArmRotationFloatCurve;

		// Token: 0x040128BE RID: 75966
		internal static int __PropertyOffset_ArmRotationFloatCurve;

		// Token: 0x040128BF RID: 75967
		[Nullable(2)]
		private SFloatCurve _ArmRotationFloatCurve;

		// Token: 0x040128C0 RID: 75968
		internal static int __PropertyOffset_IsUseFovFloatCurve;

		// Token: 0x040128C1 RID: 75969
		internal static int __PropertyOffset_FovFloatCurve;

		// Token: 0x040128C2 RID: 75970
		[Nullable(2)]
		private SFloatCurve _FovFloatCurve;

		// Token: 0x040128C3 RID: 75971
		internal static int __PropertyOffset_IsModifiedCameraLens;

		// Token: 0x040128C4 RID: 75972
		internal static int __PropertyOffset_IsUseLensFloatCurve;

		// Token: 0x040128C5 RID: 75973
		internal static int __PropertyOffset_LensFloatCurve;

		// Token: 0x040128C6 RID: 75974
		[Nullable(2)]
		private SFloatCurve _LensFloatCurve;

		// Token: 0x040128C7 RID: 75975
		internal static int __PropertyOffset_CameraLens;

		// Token: 0x040128C8 RID: 75976
		internal static int __PropertyOffset_IsUseCameraOffsetFloatCurve;

		// Token: 0x040128C9 RID: 75977
		internal static int __PropertyOffset_CameraOffsetFloatCurve;

		// Token: 0x040128CA RID: 75978
		[Nullable(2)]
		private SFloatCurve _CameraOffsetFloatCurve;

		// Token: 0x040128CB RID: 75979
		internal static int __PropertyOffset_IsModifiedArmOffset;

		// Token: 0x040128CC RID: 75980
		internal static int __PropertyOffset_ArmOffset;

		// Token: 0x040128CD RID: 75981
		internal static int __PropertyOffset_IsUseArmOffsetFloatCurve;

		// Token: 0x040128CE RID: 75982
		internal static int __PropertyOffset_ArmOffsetFloatCurve;

		// Token: 0x040128CF RID: 75983
		[Nullable(2)]
		private SFloatCurve _ArmOffsetFloatCurve;
	}
}
