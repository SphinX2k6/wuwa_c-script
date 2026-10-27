using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043DF RID: 17375
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_BindTarget.SMovieCameraConfigItem_SequenceSetting_BindTarget")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 132)]
	public class SMovieCameraConfigItem_SequenceSetting_BindTarget : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D024 RID: 184356 RVA: 0x00A2E4B1 File Offset: 0x00A2C6B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_SequenceSetting_BindTarget._ScriptStructPtr != 0) ? SMovieCameraConfigItem_SequenceSetting_BindTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_BindTarget.SMovieCameraConfigItem_SequenceSetting_BindTarget", ref SMovieCameraConfigItem_SequenceSetting_BindTarget._ScriptStructPtr);
		}

		// Token: 0x17007205 RID: 29189
		// (get) Token: 0x0602D025 RID: 184357 RVA: 0x00A2E4D5 File Offset: 0x00A2C6D5
		// (set) Token: 0x0602D026 RID: 184358 RVA: 0x00A2E4E9 File Offset: 0x00A2C6E9
		public unsafe TEnumAsByte<EMovieCameraSequenceSettingBindTargetType> BindTargetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007206 RID: 29190
		// (get) Token: 0x0602D027 RID: 184359 RVA: 0x00A2E4FE File Offset: 0x00A2C6FE
		// (set) Token: 0x0602D028 RID: 184360 RVA: 0x00A2E512 File Offset: 0x00A2C712
		public unsafe FName AttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007207 RID: 29191
		// (get) Token: 0x0602D029 RID: 184361 RVA: 0x00A2E527 File Offset: 0x00A2C727
		// (set) Token: 0x0602D02A RID: 184362 RVA: 0x00A2E53B File Offset: 0x00A2C73B
		public unsafe FVectorDouble AttachLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007208 RID: 29192
		// (get) Token: 0x0602D02B RID: 184363 RVA: 0x00A2E550 File Offset: 0x00A2C750
		// (set) Token: 0x0602D02C RID: 184364 RVA: 0x00A2E564 File Offset: 0x00A2C764
		public unsafe FRotator AttachRotatorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17007209 RID: 29193
		// (get) Token: 0x0602D02D RID: 184365 RVA: 0x00A2E579 File Offset: 0x00A2C779
		// (set) Token: 0x0602D02E RID: 184366 RVA: 0x00A2E58D File Offset: 0x00A2C78D
		public unsafe FVectorDouble SpecificLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700720A RID: 29194
		// (get) Token: 0x0602D02F RID: 184367 RVA: 0x00A2E5A2 File Offset: 0x00A2C7A2
		// (set) Token: 0x0602D030 RID: 184368 RVA: 0x00A2E5B6 File Offset: 0x00A2C7B6
		public unsafe FRotator SpecificRotatorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700720B RID: 29195
		// (get) Token: 0x0602D031 RID: 184369 RVA: 0x00A2E5CB File Offset: 0x00A2C7CB
		// (set) Token: 0x0602D032 RID: 184370 RVA: 0x00A2E5DF File Offset: 0x00A2C7DF
		public unsafe FVectorDouble WorldLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700720C RID: 29196
		// (get) Token: 0x0602D033 RID: 184371 RVA: 0x00A2E5F4 File Offset: 0x00A2C7F4
		// (set) Token: 0x0602D034 RID: 184372 RVA: 0x00A2E608 File Offset: 0x00A2C808
		public unsafe FRotator WorldRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602D035 RID: 184373 RVA: 0x00A2E61D File Offset: 0x00A2C81D
		public SMovieCameraConfigItem_SequenceSetting_BindTarget()
		{
		}

		// Token: 0x0602D036 RID: 184374 RVA: 0x00A2E628 File Offset: 0x00A2C828
		public SMovieCameraConfigItem_SequenceSetting_BindTarget(TEnumAsByte<EMovieCameraSequenceSettingBindTargetType> BindTargetType, FName AttachSocketName, FVectorDouble AttachLocationOffset, FRotator AttachRotatorOffset, FVectorDouble SpecificLocationOffset, FRotator SpecificRotatorOffset, FVectorDouble WorldLocation, FRotator WorldRotation)
		{
			this.BindTargetType = BindTargetType;
			this.AttachSocketName = AttachSocketName;
			this.AttachLocationOffset = AttachLocationOffset;
			this.AttachRotatorOffset = AttachRotatorOffset;
			this.SpecificLocationOffset = SpecificLocationOffset;
			this.SpecificRotatorOffset = SpecificRotatorOffset;
			this.WorldLocation = WorldLocation;
			this.WorldRotation = WorldRotation;
		}

		// Token: 0x0602D037 RID: 184375 RVA: 0x00A2E678 File Offset: 0x00A2C878
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem_SequenceSetting_BindTarget.StaticStruct();
		}

		// Token: 0x0602D038 RID: 184376 RVA: 0x00A2E684 File Offset: 0x00A2C884
		[NullableContext(2)]
		public SMovieCameraConfigItem_SequenceSetting_BindTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D039 RID: 184377 RVA: 0x00A2E68E File Offset: 0x00A2C88E
		public SMovieCameraConfigItem_SequenceSetting_BindTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D03A RID: 184378 RVA: 0x00A2E699 File Offset: 0x00A2C899
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem_SequenceSetting_BindTarget(Pointer, false, true);
		}

		// Token: 0x0602D03B RID: 184379 RVA: 0x00A2E6A3 File Offset: 0x00A2C8A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem_SequenceSetting_BindTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04017E2A RID: 97834
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_BindTarget.SMovieCameraConfigItem_SequenceSetting_BindTarget";

		// Token: 0x04017E2B RID: 97835
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017E2C RID: 97836
		internal static int __PropertyOffset_0;

		// Token: 0x04017E2D RID: 97837
		internal static int __PropertyOffset_1;

		// Token: 0x04017E2E RID: 97838
		internal static int __PropertyOffset_2;

		// Token: 0x04017E2F RID: 97839
		internal static int __PropertyOffset_3;

		// Token: 0x04017E30 RID: 97840
		internal static int __PropertyOffset_4;

		// Token: 0x04017E31 RID: 97841
		internal static int __PropertyOffset_5;

		// Token: 0x04017E32 RID: 97842
		internal static int __PropertyOffset_6;

		// Token: 0x04017E33 RID: 97843
		internal static int __PropertyOffset_7;
	}
}
