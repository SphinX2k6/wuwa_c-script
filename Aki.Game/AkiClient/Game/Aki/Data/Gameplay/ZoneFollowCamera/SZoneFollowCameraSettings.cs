using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera
{
	// Token: 0x020031D3 RID: 12755
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraSettings.SZoneFollowCameraSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SZoneFollowCameraSettings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FA05 RID: 129541 RVA: 0x00931ECF File Offset: 0x009300CF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SZoneFollowCameraSettings._ScriptStructPtr != 0) ? SZoneFollowCameraSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraSettings.SZoneFollowCameraSettings", ref SZoneFollowCameraSettings._ScriptStructPtr);
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x0601FA06 RID: 129542 RVA: 0x00931EF3 File Offset: 0x009300F3
		// (set) Token: 0x0601FA07 RID: 129543 RVA: 0x00931F03 File Offset: 0x00930103
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_LerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_LerpSpeed) = value;
			}
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x0601FA08 RID: 129544 RVA: 0x00931F14 File Offset: 0x00930114
		// (set) Token: 0x0601FA09 RID: 129545 RVA: 0x00931F24 File Offset: 0x00930124
		public unsafe float CameraFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_CameraFov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_CameraFov) = value;
			}
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0601FA0A RID: 129546 RVA: 0x00931F38 File Offset: 0x00930138
		// (set) Token: 0x0601FA0B RID: 129547 RVA: 0x00931F7B File Offset: 0x0093017B
		public TArray<SZoneFollowCameraZoneSetting> ZoneConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SZoneFollowCameraZoneSetting> result;
				if ((result = this._ZoneConfigs) == null)
				{
					result = (this._ZoneConfigs = new TArray<SZoneFollowCameraZoneSetting>(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_ZoneConfigs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ZoneConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0601FA0C RID: 129548 RVA: 0x00931F89 File Offset: 0x00930189
		// (set) Token: 0x0601FA0D RID: 129549 RVA: 0x00931F9D File Offset: 0x0093019D
		public unsafe FVector DefaultCameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_DefaultCameraOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_DefaultCameraOffset) = value;
			}
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x0601FA0E RID: 129550 RVA: 0x00931FB2 File Offset: 0x009301B2
		// (set) Token: 0x0601FA0F RID: 129551 RVA: 0x00931FC6 File Offset: 0x009301C6
		public unsafe FRotator DefaultCameraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_DefaultCameraRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_DefaultCameraRotation) = value;
			}
		}

		// Token: 0x0601FA10 RID: 129552 RVA: 0x00931FDB File Offset: 0x009301DB
		public SZoneFollowCameraSettings()
		{
		}

		// Token: 0x0601FA11 RID: 129553 RVA: 0x00931FE3 File Offset: 0x009301E3
		protected override IntPtr GetUStructPtr()
		{
			return SZoneFollowCameraSettings.StaticStruct();
		}

		// Token: 0x0601FA12 RID: 129554 RVA: 0x00931FEF File Offset: 0x009301EF
		[NullableContext(2)]
		public SZoneFollowCameraSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA13 RID: 129555 RVA: 0x00931FF9 File Offset: 0x009301F9
		public SZoneFollowCameraSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA14 RID: 129556 RVA: 0x00932004 File Offset: 0x00930204
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SZoneFollowCameraSettings(Pointer, false, true);
		}

		// Token: 0x0601FA15 RID: 129557 RVA: 0x0093200E File Offset: 0x0093020E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SZoneFollowCameraSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04010F70 RID: 69488
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraSettings.SZoneFollowCameraSettings";

		// Token: 0x04010F71 RID: 69489
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F72 RID: 69490
		internal static int __PropertyOffset_LerpSpeed;

		// Token: 0x04010F73 RID: 69491
		internal static int __PropertyOffset_CameraFov;

		// Token: 0x04010F74 RID: 69492
		internal static int __PropertyOffset_ZoneConfigs;

		// Token: 0x04010F75 RID: 69493
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SZoneFollowCameraZoneSetting> _ZoneConfigs;

		// Token: 0x04010F76 RID: 69494
		internal static int __PropertyOffset_DefaultCameraOffset;

		// Token: 0x04010F77 RID: 69495
		internal static int __PropertyOffset_DefaultCameraRotation;
	}
}
