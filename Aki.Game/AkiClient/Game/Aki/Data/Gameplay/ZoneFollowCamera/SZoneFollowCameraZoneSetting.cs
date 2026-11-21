using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera
{
	// Token: 0x020031D4 RID: 12756
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraZoneSetting.SZoneFollowCameraZoneSetting")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 108)]
	public class SZoneFollowCameraZoneSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FA16 RID: 129558 RVA: 0x00932017 File Offset: 0x00930217
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SZoneFollowCameraZoneSetting._ScriptStructPtr != 0) ? SZoneFollowCameraZoneSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraZoneSetting.SZoneFollowCameraZoneSetting", ref SZoneFollowCameraZoneSetting._ScriptStructPtr);
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x0601FA17 RID: 129559 RVA: 0x0093203B File Offset: 0x0093023B
		// (set) Token: 0x0601FA18 RID: 129560 RVA: 0x0093204F File Offset: 0x0093024F
		public unsafe FTransform BoxTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_BoxTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_BoxTransform) = value;
			}
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x0601FA19 RID: 129561 RVA: 0x00932064 File Offset: 0x00930264
		// (set) Token: 0x0601FA1A RID: 129562 RVA: 0x00932078 File Offset: 0x00930278
		public unsafe FVector BoxExtend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_BoxExtend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_BoxExtend) = value;
			}
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x0601FA1B RID: 129563 RVA: 0x0093208D File Offset: 0x0093028D
		// (set) Token: 0x0601FA1C RID: 129564 RVA: 0x009320A1 File Offset: 0x009302A1
		public unsafe FVector CenterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_CenterPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_CenterPosition) = value;
			}
		}

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x0601FA1D RID: 129565 RVA: 0x009320B6 File Offset: 0x009302B6
		// (set) Token: 0x0601FA1E RID: 129566 RVA: 0x009320CA File Offset: 0x009302CA
		public unsafe FVector CameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_CameraOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_CameraOffset) = value;
			}
		}

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x0601FA1F RID: 129567 RVA: 0x009320DF File Offset: 0x009302DF
		// (set) Token: 0x0601FA20 RID: 129568 RVA: 0x009320F3 File Offset: 0x009302F3
		public unsafe FRotator CameraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_CameraRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_CameraRotation) = value;
			}
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x0601FA21 RID: 129569 RVA: 0x00932108 File Offset: 0x00930308
		// (set) Token: 0x0601FA22 RID: 129570 RVA: 0x0093211C File Offset: 0x0093031C
		public unsafe FVector CameraOffsetAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_CameraOffsetAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SZoneFollowCameraZoneSetting.__PropertyOffset_CameraOffsetAlpha) = value;
			}
		}

		// Token: 0x0601FA23 RID: 129571 RVA: 0x00932131 File Offset: 0x00930331
		public SZoneFollowCameraZoneSetting()
		{
		}

		// Token: 0x0601FA24 RID: 129572 RVA: 0x00932139 File Offset: 0x00930339
		protected override IntPtr GetUStructPtr()
		{
			return SZoneFollowCameraZoneSetting.StaticStruct();
		}

		// Token: 0x0601FA25 RID: 129573 RVA: 0x00932145 File Offset: 0x00930345
		[NullableContext(2)]
		public SZoneFollowCameraZoneSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA26 RID: 129574 RVA: 0x0093214F File Offset: 0x0093034F
		public SZoneFollowCameraZoneSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA27 RID: 129575 RVA: 0x0093215A File Offset: 0x0093035A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SZoneFollowCameraZoneSetting(Pointer, false, true);
		}

		// Token: 0x0601FA28 RID: 129576 RVA: 0x00932164 File Offset: 0x00930364
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SZoneFollowCameraZoneSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04010F78 RID: 69496
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/ZoneFollowCamera/SZoneFollowCameraZoneSetting.SZoneFollowCameraZoneSetting";

		// Token: 0x04010F79 RID: 69497
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F7A RID: 69498
		internal static int __PropertyOffset_BoxTransform;

		// Token: 0x04010F7B RID: 69499
		internal static int __PropertyOffset_BoxExtend;

		// Token: 0x04010F7C RID: 69500
		internal static int __PropertyOffset_CenterPosition;

		// Token: 0x04010F7D RID: 69501
		internal static int __PropertyOffset_CameraOffset;

		// Token: 0x04010F7E RID: 69502
		internal static int __PropertyOffset_CameraRotation;

		// Token: 0x04010F7F RID: 69503
		internal static int __PropertyOffset_CameraOffsetAlpha;
	}
}
