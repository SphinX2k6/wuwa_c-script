using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033F5 RID: 13301
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_FollowTarget.SMovieCameraConfigItem_SequenceSetting_FollowTarget")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SMovieCameraConfigItem_SequenceSetting_FollowTarget : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BE6 RID: 138214 RVA: 0x00968148 File Offset: 0x00966348
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_SequenceSetting_FollowTarget._ScriptStructPtr != 0) ? SMovieCameraConfigItem_SequenceSetting_FollowTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_FollowTarget.SMovieCameraConfigItem_SequenceSetting_FollowTarget", ref SMovieCameraConfigItem_SequenceSetting_FollowTarget._ScriptStructPtr);
		}

		// Token: 0x170045FA RID: 17914
		// (get) Token: 0x06021BE7 RID: 138215 RVA: 0x0096816C File Offset: 0x0096636C
		// (set) Token: 0x06021BE8 RID: 138216 RVA: 0x0096817C File Offset: 0x0096637C
		public unsafe bool IsFollowTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_IsFollowTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_IsFollowTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045FB RID: 17915
		// (get) Token: 0x06021BE9 RID: 138217 RVA: 0x0096818D File Offset: 0x0096638D
		// (set) Token: 0x06021BEA RID: 138218 RVA: 0x009681A1 File Offset: 0x009663A1
		public unsafe TEnumAsByte<EMovieCameraSequenceSettingFollowTargetType> FollowType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_FollowType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_FollowType) = value;
			}
		}

		// Token: 0x170045FC RID: 17916
		// (get) Token: 0x06021BEB RID: 138219 RVA: 0x009681B6 File Offset: 0x009663B6
		// (set) Token: 0x06021BEC RID: 138220 RVA: 0x009681C6 File Offset: 0x009663C6
		public unsafe float FollowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_FollowSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_FollowSpeed) = value;
			}
		}

		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x06021BED RID: 138221 RVA: 0x009681D7 File Offset: 0x009663D7
		// (set) Token: 0x06021BEE RID: 138222 RVA: 0x009681E7 File Offset: 0x009663E7
		public unsafe float PitchFollowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_PitchFollowSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_PitchFollowSpeed) = value;
			}
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x06021BEF RID: 138223 RVA: 0x009681F8 File Offset: 0x009663F8
		// (set) Token: 0x06021BF0 RID: 138224 RVA: 0x00968208 File Offset: 0x00966408
		public unsafe float AngleFollowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_AngleFollowSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_FollowTarget.__PropertyOffset_AngleFollowSpeed) = value;
			}
		}

		// Token: 0x06021BF1 RID: 138225 RVA: 0x00968219 File Offset: 0x00966419
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget()
		{
		}

		// Token: 0x06021BF2 RID: 138226 RVA: 0x00968221 File Offset: 0x00966421
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem_SequenceSetting_FollowTarget.StaticStruct();
		}

		// Token: 0x06021BF3 RID: 138227 RVA: 0x0096822D File Offset: 0x0096642D
		[NullableContext(2)]
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BF4 RID: 138228 RVA: 0x00968237 File Offset: 0x00966437
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BF5 RID: 138229 RVA: 0x00968242 File Offset: 0x00966442
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem_SequenceSetting_FollowTarget(Pointer, false, true);
		}

		// Token: 0x06021BF6 RID: 138230 RVA: 0x0096824C File Offset: 0x0096644C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem_SequenceSetting_FollowTarget(Pointer, MemoryOwner);
		}

		// Token: 0x0401296D RID: 76141
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_FollowTarget.SMovieCameraConfigItem_SequenceSetting_FollowTarget";

		// Token: 0x0401296E RID: 76142
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401296F RID: 76143
		internal static int __PropertyOffset_IsFollowTarget;

		// Token: 0x04012970 RID: 76144
		internal static int __PropertyOffset_FollowType;

		// Token: 0x04012971 RID: 76145
		internal static int __PropertyOffset_FollowSpeed;

		// Token: 0x04012972 RID: 76146
		internal static int __PropertyOffset_PitchFollowSpeed;

		// Token: 0x04012973 RID: 76147
		internal static int __PropertyOffset_AngleFollowSpeed;
	}
}
