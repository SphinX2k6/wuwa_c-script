using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera
{
	// Token: 0x02003F27 RID: 16167
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraSettings.SZoneFollowCameraSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SZoneFollowCameraSettings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060290F0 RID: 168176 RVA: 0x009BACEB File Offset: 0x009B8EEB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SZoneFollowCameraSettings._ScriptStructPtr != 0) ? SZoneFollowCameraSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraSettings.SZoneFollowCameraSettings", ref SZoneFollowCameraSettings._ScriptStructPtr);
		}

		// Token: 0x1700612F RID: 24879
		// (get) Token: 0x060290F1 RID: 168177 RVA: 0x009BAD0F File Offset: 0x009B8F0F
		// (set) Token: 0x060290F2 RID: 168178 RVA: 0x009BAD1F File Offset: 0x009B8F1F
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006130 RID: 24880
		// (get) Token: 0x060290F3 RID: 168179 RVA: 0x009BAD30 File Offset: 0x009B8F30
		// (set) Token: 0x060290F4 RID: 168180 RVA: 0x009BAD40 File Offset: 0x009B8F40
		public unsafe float CameraFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006131 RID: 24881
		// (get) Token: 0x060290F5 RID: 168181 RVA: 0x009BAD54 File Offset: 0x009B8F54
		// (set) Token: 0x060290F6 RID: 168182 RVA: 0x009BAD97 File Offset: 0x009B8F97
		public TArray<SZoneFollowCameraZoneSetting> ZoneConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SZoneFollowCameraZoneSetting> result;
				if ((result = this._ZoneConfigs) == null)
				{
					result = (this._ZoneConfigs = new TArray<SZoneFollowCameraZoneSetting>(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ZoneConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17006132 RID: 24882
		// (get) Token: 0x060290F7 RID: 168183 RVA: 0x009BADA5 File Offset: 0x009B8FA5
		// (set) Token: 0x060290F8 RID: 168184 RVA: 0x009BADB9 File Offset: 0x009B8FB9
		public unsafe FVector DefaultCameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006133 RID: 24883
		// (get) Token: 0x060290F9 RID: 168185 RVA: 0x009BADCE File Offset: 0x009B8FCE
		// (set) Token: 0x060290FA RID: 168186 RVA: 0x009BADE2 File Offset: 0x009B8FE2
		public unsafe FRotator DefaultCameraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraSettings.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x060290FB RID: 168187 RVA: 0x009BADF7 File Offset: 0x009B8FF7
		public SZoneFollowCameraSettings()
		{
		}

		// Token: 0x060290FC RID: 168188 RVA: 0x009BADFF File Offset: 0x009B8FFF
		public SZoneFollowCameraSettings(float LerpSpeed, float CameraFov, TArray<SZoneFollowCameraZoneSetting> ZoneConfigs, FVector DefaultCameraOffset, FRotator DefaultCameraRotation)
		{
			this.LerpSpeed = LerpSpeed;
			this.CameraFov = CameraFov;
			this.ZoneConfigs = ZoneConfigs;
			this.DefaultCameraOffset = DefaultCameraOffset;
			this.DefaultCameraRotation = DefaultCameraRotation;
		}

		// Token: 0x060290FD RID: 168189 RVA: 0x009BAE2C File Offset: 0x009B902C
		protected override IntPtr GetUStructPtr()
		{
			return SZoneFollowCameraSettings.StaticStruct();
		}

		// Token: 0x060290FE RID: 168190 RVA: 0x009BAE38 File Offset: 0x009B9038
		[NullableContext(2)]
		public SZoneFollowCameraSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060290FF RID: 168191 RVA: 0x009BAE42 File Offset: 0x009B9042
		public SZoneFollowCameraSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029100 RID: 168192 RVA: 0x009BAE4D File Offset: 0x009B904D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SZoneFollowCameraSettings(Pointer, false, true);
		}

		// Token: 0x06029101 RID: 168193 RVA: 0x009BAE57 File Offset: 0x009B9057
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SZoneFollowCameraSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04015040 RID: 86080
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraSettings.SZoneFollowCameraSettings";

		// Token: 0x04015041 RID: 86081
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015042 RID: 86082
		internal static int __PropertyOffset_0;

		// Token: 0x04015043 RID: 86083
		internal static int __PropertyOffset_1;

		// Token: 0x04015044 RID: 86084
		internal static int __PropertyOffset_2;

		// Token: 0x04015045 RID: 86085
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SZoneFollowCameraZoneSetting> _ZoneConfigs;

		// Token: 0x04015046 RID: 86086
		internal static int __PropertyOffset_3;

		// Token: 0x04015047 RID: 86087
		internal static int __PropertyOffset_4;
	}
}
