using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043DE RID: 17374
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting.SMovieCameraConfigItem_SequenceSetting")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class SMovieCameraConfigItem_SequenceSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D012 RID: 184338 RVA: 0x00A2E2D6 File Offset: 0x00A2C4D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_SequenceSetting._ScriptStructPtr != 0) ? SMovieCameraConfigItem_SequenceSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting.SMovieCameraConfigItem_SequenceSetting", ref SMovieCameraConfigItem_SequenceSetting._ScriptStructPtr);
		}

		// Token: 0x17007200 RID: 29184
		// (get) Token: 0x0602D013 RID: 184339 RVA: 0x00A2E2FA File Offset: 0x00A2C4FA
		// (set) Token: 0x0602D014 RID: 184340 RVA: 0x00A2E319 File Offset: 0x00A2C519
		public TSoftObjectPtr<ULevelSequence> SequenceAsset
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17007201 RID: 29185
		// (get) Token: 0x0602D015 RID: 184341 RVA: 0x00A2E33E File Offset: 0x00A2C53E
		// (set) Token: 0x0602D016 RID: 184342 RVA: 0x00A2E34E File Offset: 0x00A2C54E
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007202 RID: 29186
		// (get) Token: 0x0602D017 RID: 184343 RVA: 0x00A2E35F File Offset: 0x00A2C55F
		// (set) Token: 0x0602D018 RID: 184344 RVA: 0x00A2E36F File Offset: 0x00A2C56F
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007203 RID: 29187
		// (get) Token: 0x0602D019 RID: 184345 RVA: 0x00A2E380 File Offset: 0x00A2C580
		// (set) Token: 0x0602D01A RID: 184346 RVA: 0x00A2E3C3 File Offset: 0x00A2C5C3
		public SMovieCameraConfigItem_SequenceSetting_BindTarget BindTargetSetting
		{
			get
			{
				base.FastCheckIsValid();
				SMovieCameraConfigItem_SequenceSetting_BindTarget result;
				if ((result = this._BindTargetSetting) == null)
				{
					result = (this._BindTargetSetting = new SMovieCameraConfigItem_SequenceSetting_BindTarget(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovieCameraConfigItem_SequenceSetting_BindTarget.StaticStruct(), base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007204 RID: 29188
		// (get) Token: 0x0602D01B RID: 184347 RVA: 0x00A2E3E4 File Offset: 0x00A2C5E4
		// (set) Token: 0x0602D01C RID: 184348 RVA: 0x00A2E427 File Offset: 0x00A2C627
		public SMovieCameraConfigItem_SequenceSetting_FollowTarget FollowTargetSetting
		{
			get
			{
				base.FastCheckIsValid();
				SMovieCameraConfigItem_SequenceSetting_FollowTarget result;
				if ((result = this._FollowTargetSetting) == null)
				{
					result = (this._FollowTargetSetting = new SMovieCameraConfigItem_SequenceSetting_FollowTarget(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovieCameraConfigItem_SequenceSetting_FollowTarget.StaticStruct(), base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602D01D RID: 184349 RVA: 0x00A2E448 File Offset: 0x00A2C648
		public SMovieCameraConfigItem_SequenceSetting()
		{
		}

		// Token: 0x0602D01E RID: 184350 RVA: 0x00A2E450 File Offset: 0x00A2C650
		public SMovieCameraConfigItem_SequenceSetting(TSoftObjectPtr<ULevelSequence> SequenceAsset, float BlendInTime, float BlendOutTime, SMovieCameraConfigItem_SequenceSetting_BindTarget BindTargetSetting, SMovieCameraConfigItem_SequenceSetting_FollowTarget FollowTargetSetting)
		{
			this.SequenceAsset = SequenceAsset;
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
			this.BindTargetSetting = BindTargetSetting;
			this.FollowTargetSetting = FollowTargetSetting;
		}

		// Token: 0x0602D01F RID: 184351 RVA: 0x00A2E47D File Offset: 0x00A2C67D
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem_SequenceSetting.StaticStruct();
		}

		// Token: 0x0602D020 RID: 184352 RVA: 0x00A2E489 File Offset: 0x00A2C689
		[NullableContext(2)]
		public SMovieCameraConfigItem_SequenceSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D021 RID: 184353 RVA: 0x00A2E493 File Offset: 0x00A2C693
		public SMovieCameraConfigItem_SequenceSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D022 RID: 184354 RVA: 0x00A2E49E File Offset: 0x00A2C69E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem_SequenceSetting(Pointer, false, true);
		}

		// Token: 0x0602D023 RID: 184355 RVA: 0x00A2E4A8 File Offset: 0x00A2C6A8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem_SequenceSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04017E21 RID: 97825
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting.SMovieCameraConfigItem_SequenceSetting";

		// Token: 0x04017E22 RID: 97826
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017E23 RID: 97827
		internal static int __PropertyOffset_0;

		// Token: 0x04017E24 RID: 97828
		internal static int __PropertyOffset_1;

		// Token: 0x04017E25 RID: 97829
		internal static int __PropertyOffset_2;

		// Token: 0x04017E26 RID: 97830
		internal static int __PropertyOffset_3;

		// Token: 0x04017E27 RID: 97831
		[Nullable(2)]
		private SMovieCameraConfigItem_SequenceSetting_BindTarget _BindTargetSetting;

		// Token: 0x04017E28 RID: 97832
		internal static int __PropertyOffset_4;

		// Token: 0x04017E29 RID: 97833
		[Nullable(2)]
		private SMovieCameraConfigItem_SequenceSetting_FollowTarget _FollowTargetSetting;
	}
}
