using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera
{
	// Token: 0x02003F28 RID: 16168
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraZoneSetting.SZoneFollowCameraZoneSetting")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 108)]
	public class SZoneFollowCameraZoneSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029102 RID: 168194 RVA: 0x009BAE60 File Offset: 0x009B9060
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SZoneFollowCameraZoneSetting._ScriptStructPtr != 0) ? SZoneFollowCameraZoneSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraZoneSetting.SZoneFollowCameraZoneSetting", ref SZoneFollowCameraZoneSetting._ScriptStructPtr);
		}

		// Token: 0x17006134 RID: 24884
		// (get) Token: 0x06029103 RID: 168195 RVA: 0x009BAE84 File Offset: 0x009B9084
		// (set) Token: 0x06029104 RID: 168196 RVA: 0x009BAE98 File Offset: 0x009B9098
		public unsafe FTransform BoxTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006135 RID: 24885
		// (get) Token: 0x06029105 RID: 168197 RVA: 0x009BAEAD File Offset: 0x009B90AD
		// (set) Token: 0x06029106 RID: 168198 RVA: 0x009BAEC1 File Offset: 0x009B90C1
		public unsafe FVector BoxExtend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006136 RID: 24886
		// (get) Token: 0x06029107 RID: 168199 RVA: 0x009BAED6 File Offset: 0x009B90D6
		// (set) Token: 0x06029108 RID: 168200 RVA: 0x009BAEEA File Offset: 0x009B90EA
		public unsafe FVector CenterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006137 RID: 24887
		// (get) Token: 0x06029109 RID: 168201 RVA: 0x009BAEFF File Offset: 0x009B90FF
		// (set) Token: 0x0602910A RID: 168202 RVA: 0x009BAF13 File Offset: 0x009B9113
		public unsafe FVector CameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006138 RID: 24888
		// (get) Token: 0x0602910B RID: 168203 RVA: 0x009BAF28 File Offset: 0x009B9128
		// (set) Token: 0x0602910C RID: 168204 RVA: 0x009BAF3C File Offset: 0x009B913C
		public unsafe FRotator CameraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006139 RID: 24889
		// (get) Token: 0x0602910D RID: 168205 RVA: 0x009BAF51 File Offset: 0x009B9151
		// (set) Token: 0x0602910E RID: 168206 RVA: 0x009BAF65 File Offset: 0x009B9165
		public unsafe FVector CameraOffsetAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602910F RID: 168207 RVA: 0x009BAF7A File Offset: 0x009B917A
		public SZoneFollowCameraZoneSetting()
		{
		}

		// Token: 0x06029110 RID: 168208 RVA: 0x009BAF82 File Offset: 0x009B9182
		public SZoneFollowCameraZoneSetting(FTransform BoxTransform, FVector BoxExtend, FVector CenterPosition, FVector CameraOffset, FRotator CameraRotation, FVector CameraOffsetAlpha)
		{
			this.BoxTransform = BoxTransform;
			this.BoxExtend = BoxExtend;
			this.CenterPosition = CenterPosition;
			this.CameraOffset = CameraOffset;
			this.CameraRotation = CameraRotation;
			this.CameraOffsetAlpha = CameraOffsetAlpha;
		}

		// Token: 0x06029111 RID: 168209 RVA: 0x009BAFB7 File Offset: 0x009B91B7
		protected override IntPtr GetUStructPtr()
		{
			return SZoneFollowCameraZoneSetting.StaticStruct();
		}

		// Token: 0x06029112 RID: 168210 RVA: 0x009BAFC3 File Offset: 0x009B91C3
		[NullableContext(2)]
		public SZoneFollowCameraZoneSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029113 RID: 168211 RVA: 0x009BAFCD File Offset: 0x009B91CD
		public SZoneFollowCameraZoneSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029114 RID: 168212 RVA: 0x009BAFD8 File Offset: 0x009B91D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SZoneFollowCameraZoneSetting(Pointer, false, true);
		}

		// Token: 0x06029115 RID: 168213 RVA: 0x009BAFE2 File Offset: 0x009B91E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SZoneFollowCameraZoneSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04015048 RID: 86088
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraZoneSetting.SZoneFollowCameraZoneSetting";

		// Token: 0x04015049 RID: 86089
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401504A RID: 86090
		internal static int __PropertyOffset_0;

		// Token: 0x0401504B RID: 86091
		internal static int __PropertyOffset_1;

		// Token: 0x0401504C RID: 86092
		internal static int __PropertyOffset_2;

		// Token: 0x0401504D RID: 86093
		internal static int __PropertyOffset_3;

		// Token: 0x0401504E RID: 86094
		internal static int __PropertyOffset_4;

		// Token: 0x0401504F RID: 86095
		internal static int __PropertyOffset_5;
	}
}
