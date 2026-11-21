using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033F3 RID: 13299
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting.SMovieCameraConfigItem_SequenceSetting")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class SMovieCameraConfigItem_SequenceSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BBE RID: 138174 RVA: 0x00967DF2 File Offset: 0x00965FF2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_SequenceSetting._ScriptStructPtr != 0) ? SMovieCameraConfigItem_SequenceSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting.SMovieCameraConfigItem_SequenceSetting", ref SMovieCameraConfigItem_SequenceSetting._ScriptStructPtr);
		}

		// Token: 0x170045ED RID: 17901
		// (get) Token: 0x06021BBF RID: 138175 RVA: 0x00967E16 File Offset: 0x00966016
		// (set) Token: 0x06021BC0 RID: 138176 RVA: 0x00967E35 File Offset: 0x00966035
		public TSoftObjectPtr<ULevelSequence> SequenceAsset
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_SequenceAsset, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_SequenceAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170045EE RID: 17902
		// (get) Token: 0x06021BC1 RID: 138177 RVA: 0x00967E5A File Offset: 0x0096605A
		// (set) Token: 0x06021BC2 RID: 138178 RVA: 0x00967E6A File Offset: 0x0096606A
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170045EF RID: 17903
		// (get) Token: 0x06021BC3 RID: 138179 RVA: 0x00967E7B File Offset: 0x0096607B
		// (set) Token: 0x06021BC4 RID: 138180 RVA: 0x00967E8B File Offset: 0x0096608B
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x170045F0 RID: 17904
		// (get) Token: 0x06021BC5 RID: 138181 RVA: 0x00967E9C File Offset: 0x0096609C
		// (set) Token: 0x06021BC6 RID: 138182 RVA: 0x00967EDF File Offset: 0x009660DF
		public SMovieCameraConfigItem_SequenceSetting_BindTarget BindTargetSetting
		{
			get
			{
				base.FastCheckIsValid();
				SMovieCameraConfigItem_SequenceSetting_BindTarget result;
				if ((result = this._BindTargetSetting) == null)
				{
					result = (this._BindTargetSetting = new SMovieCameraConfigItem_SequenceSetting_BindTarget(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_BindTargetSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovieCameraConfigItem_SequenceSetting_BindTarget.StaticStruct(), base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_BindTargetSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045F1 RID: 17905
		// (get) Token: 0x06021BC7 RID: 138183 RVA: 0x00967F00 File Offset: 0x00966100
		// (set) Token: 0x06021BC8 RID: 138184 RVA: 0x00967F43 File Offset: 0x00966143
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget FollowTargetSetting
		{
			get
			{
				base.FastCheckIsValid();
				SMovieCameraConfigItem_SequenceSetting_FollowTarget result;
				if ((result = this._FollowTargetSetting) == null)
				{
					result = (this._FollowTargetSetting = new SMovieCameraConfigItem_SequenceSetting_FollowTarget(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_FollowTargetSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovieCameraConfigItem_SequenceSetting_FollowTarget.StaticStruct(), base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_FollowTargetSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021BC9 RID: 138185 RVA: 0x00967F64 File Offset: 0x00966164
		public SMovieCameraConfigItem_SequenceSetting()
		{
		}

		// Token: 0x06021BCA RID: 138186 RVA: 0x00967F6C File Offset: 0x0096616C
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem_SequenceSetting.StaticStruct();
		}

		// Token: 0x06021BCB RID: 138187 RVA: 0x00967F78 File Offset: 0x00966178
		[NullableContext(2)]
		public SMovieCameraConfigItem_SequenceSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BCC RID: 138188 RVA: 0x00967F82 File Offset: 0x00966182
		public SMovieCameraConfigItem_SequenceSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BCD RID: 138189 RVA: 0x00967F8D File Offset: 0x0096618D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem_SequenceSetting(Pointer, false, true);
		}

		// Token: 0x06021BCE RID: 138190 RVA: 0x00967F97 File Offset: 0x00966197
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem_SequenceSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0401295A RID: 76122
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting.SMovieCameraConfigItem_SequenceSetting";

		// Token: 0x0401295B RID: 76123
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401295C RID: 76124
		internal static int __PropertyOffset_SequenceAsset;

		// Token: 0x0401295D RID: 76125
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x0401295E RID: 76126
		internal static int __PropertyOffset_BlendOutTime;

		// Token: 0x0401295F RID: 76127
		internal static int __PropertyOffset_BindTargetSetting;

		// Token: 0x04012960 RID: 76128
		[Nullable(2)]
		private SMovieCameraConfigItem_SequenceSetting_BindTarget _BindTargetSetting;

		// Token: 0x04012961 RID: 76129
		internal static int __PropertyOffset_FollowTargetSetting;

		// Token: 0x04012962 RID: 76130
		[Nullable(2)]
		private SMovieCameraConfigItem_SequenceSetting_FollowTarget _FollowTargetSetting;
	}
}
