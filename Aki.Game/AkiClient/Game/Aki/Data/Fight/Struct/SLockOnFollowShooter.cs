using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x0200320B RID: 12811
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooter.SLockOnFollowShooter")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class SLockOnFollowShooter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FE8C RID: 130700 RVA: 0x00938C31 File Offset: 0x00936E31
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnFollowShooter._ScriptStructPtr != 0) ? SLockOnFollowShooter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooter.SLockOnFollowShooter", ref SLockOnFollowShooter._ScriptStructPtr);
		}

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0601FE8D RID: 130701 RVA: 0x00938C55 File Offset: 0x00936E55
		// (set) Token: 0x0601FE8E RID: 130702 RVA: 0x00938C65 File Offset: 0x00936E65
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0601FE8F RID: 130703 RVA: 0x00938C76 File Offset: 0x00936E76
		// (set) Token: 0x0601FE90 RID: 130704 RVA: 0x00938C86 File Offset: 0x00936E86
		public unsafe float GapTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_GapTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_GapTime) = value;
			}
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0601FE91 RID: 130705 RVA: 0x00938C97 File Offset: 0x00936E97
		// (set) Token: 0x0601FE92 RID: 130706 RVA: 0x00938CA7 File Offset: 0x00936EA7
		public unsafe int Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0601FE93 RID: 130707 RVA: 0x00938CB8 File Offset: 0x00936EB8
		// (set) Token: 0x0601FE94 RID: 130708 RVA: 0x00938CC8 File Offset: 0x00936EC8
		public unsafe int Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0601FE95 RID: 130709 RVA: 0x00938CD9 File Offset: 0x00936ED9
		// (set) Token: 0x0601FE96 RID: 130710 RVA: 0x00938CE9 File Offset: 0x00936EE9
		public unsafe float WorldDistanceWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_WorldDistanceWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_WorldDistanceWeight) = value;
			}
		}

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x0601FE97 RID: 130711 RVA: 0x00938CFA File Offset: 0x00936EFA
		// (set) Token: 0x0601FE98 RID: 130712 RVA: 0x00938D0A File Offset: 0x00936F0A
		public unsafe float ScreenDistanceWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_ScreenDistanceWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_ScreenDistanceWeight) = value;
			}
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x0601FE99 RID: 130713 RVA: 0x00938D1B File Offset: 0x00936F1B
		// (set) Token: 0x0601FE9A RID: 130714 RVA: 0x00938D2B File Offset: 0x00936F2B
		public unsafe float CharacterExtraWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_CharacterExtraWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_CharacterExtraWeight) = value;
			}
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0601FE9B RID: 130715 RVA: 0x00938D3C File Offset: 0x00936F3C
		// (set) Token: 0x0601FE9C RID: 130716 RVA: 0x00938D4C File Offset: 0x00936F4C
		public unsafe float SceneItemExtraWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_SceneItemExtraWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_SceneItemExtraWeight) = value;
			}
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0601FE9D RID: 130717 RVA: 0x00938D60 File Offset: 0x00936F60
		// (set) Token: 0x0601FE9E RID: 130718 RVA: 0x00938DA3 File Offset: 0x00936FA3
		public TArray<SLockOnFollowShooterAutoAim> ArrayAutoAimConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SLockOnFollowShooterAutoAim> result;
				if ((result = this._ArrayAutoAimConfig) == null)
				{
					result = (this._ArrayAutoAimConfig = new TArray<SLockOnFollowShooterAutoAim>(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_ArrayAutoAimConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ArrayAutoAimConfig.CopyAssign(value);
			}
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0601FE9F RID: 130719 RVA: 0x00938DB4 File Offset: 0x00936FB4
		// (set) Token: 0x0601FEA0 RID: 130720 RVA: 0x00938DF7 File Offset: 0x00936FF7
		public FGameplayTagContainer LockOnGameplayTagContainer
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._LockOnGameplayTagContainer) == null)
				{
					result = (this._LockOnGameplayTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_LockOnGameplayTagContainer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_LockOnGameplayTagContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0601FEA1 RID: 130721 RVA: 0x00938E18 File Offset: 0x00937018
		// (set) Token: 0x0601FEA2 RID: 130722 RVA: 0x00938E5B File Offset: 0x0093705B
		public FGameplayTagContainer AutoDetectEnableTagContainer
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AutoDetectEnableTagContainer) == null)
				{
					result = (this._AutoDetectEnableTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_AutoDetectEnableTagContainer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_AutoDetectEnableTagContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0601FEA3 RID: 130723 RVA: 0x00938E7C File Offset: 0x0093707C
		// (set) Token: 0x0601FEA4 RID: 130724 RVA: 0x00938EBF File Offset: 0x009370BF
		public FGameplayTagContainer IgnoreLockOnGameplayTagContainer
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._IgnoreLockOnGameplayTagContainer) == null)
				{
					result = (this._IgnoreLockOnGameplayTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_IgnoreLockOnGameplayTagContainer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_IgnoreLockOnGameplayTagContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0601FEA5 RID: 130725 RVA: 0x00938EE0 File Offset: 0x009370E0
		// (set) Token: 0x0601FEA6 RID: 130726 RVA: 0x00938F23 File Offset: 0x00937123
		public FGameplayTagContainer AutoShootGameplayTagContainer
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AutoShootGameplayTagContainer) == null)
				{
					result = (this._AutoShootGameplayTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_AutoShootGameplayTagContainer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_AutoShootGameplayTagContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0601FEA7 RID: 130727 RVA: 0x00938F44 File Offset: 0x00937144
		// (set) Token: 0x0601FEA8 RID: 130728 RVA: 0x00938F54 File Offset: 0x00937154
		public unsafe float CameraForwardDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_CameraForwardDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_CameraForwardDistance) = value;
			}
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0601FEA9 RID: 130729 RVA: 0x00938F65 File Offset: 0x00937165
		// (set) Token: 0x0601FEAA RID: 130730 RVA: 0x00938F79 File Offset: 0x00937179
		public unsafe string CustomEntityKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnFollowShooter.__PropertyOffset_CustomEntityKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnFollowShooter.__PropertyOffset_CustomEntityKey)), value);
			}
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0601FEAB RID: 130731 RVA: 0x00938F8E File Offset: 0x0093718E
		// (set) Token: 0x0601FEAC RID: 130732 RVA: 0x00938FA2 File Offset: 0x009371A2
		public unsafe string CustomBulletTargetKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnFollowShooter.__PropertyOffset_CustomBulletTargetKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnFollowShooter.__PropertyOffset_CustomBulletTargetKey)), value);
			}
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0601FEAD RID: 130733 RVA: 0x00938FB8 File Offset: 0x009371B8
		// (set) Token: 0x0601FEAE RID: 130734 RVA: 0x00938FFB File Offset: 0x009371FB
		public TSet<string> CustomBulletTargetRowNameSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._CustomBulletTargetRowNameSet) == null)
				{
					result = (this._CustomBulletTargetRowNameSet = new TSet<string>(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_CustomBulletTargetRowNameSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomBulletTargetRowNameSet.CopyAssign(value);
			}
		}

		// Token: 0x0601FEAF RID: 130735 RVA: 0x00939009 File Offset: 0x00937209
		public SLockOnFollowShooter()
		{
		}

		// Token: 0x0601FEB0 RID: 130736 RVA: 0x00939011 File Offset: 0x00937211
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnFollowShooter.StaticStruct();
		}

		// Token: 0x0601FEB1 RID: 130737 RVA: 0x0093901D File Offset: 0x0093721D
		[NullableContext(2)]
		public SLockOnFollowShooter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FEB2 RID: 130738 RVA: 0x00939027 File Offset: 0x00937227
		public SLockOnFollowShooter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FEB3 RID: 130739 RVA: 0x00939032 File Offset: 0x00937232
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnFollowShooter(Pointer, false, true);
		}

		// Token: 0x0601FEB4 RID: 130740 RVA: 0x0093903C File Offset: 0x0093723C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnFollowShooter(Pointer, MemoryOwner);
		}

		// Token: 0x0401122D RID: 70189
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnFollowShooter.SLockOnFollowShooter";

		// Token: 0x0401122E RID: 70190
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401122F RID: 70191
		internal static int __PropertyOffset_Enable;

		// Token: 0x04011230 RID: 70192
		internal static int __PropertyOffset_GapTime;

		// Token: 0x04011231 RID: 70193
		internal static int __PropertyOffset_Distance;

		// Token: 0x04011232 RID: 70194
		internal static int __PropertyOffset_Radius;

		// Token: 0x04011233 RID: 70195
		internal static int __PropertyOffset_WorldDistanceWeight;

		// Token: 0x04011234 RID: 70196
		internal static int __PropertyOffset_ScreenDistanceWeight;

		// Token: 0x04011235 RID: 70197
		internal static int __PropertyOffset_CharacterExtraWeight;

		// Token: 0x04011236 RID: 70198
		internal static int __PropertyOffset_SceneItemExtraWeight;

		// Token: 0x04011237 RID: 70199
		internal static int __PropertyOffset_ArrayAutoAimConfig;

		// Token: 0x04011238 RID: 70200
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SLockOnFollowShooterAutoAim> _ArrayAutoAimConfig;

		// Token: 0x04011239 RID: 70201
		internal static int __PropertyOffset_LockOnGameplayTagContainer;

		// Token: 0x0401123A RID: 70202
		[Nullable(2)]
		private FGameplayTagContainer _LockOnGameplayTagContainer;

		// Token: 0x0401123B RID: 70203
		internal static int __PropertyOffset_AutoDetectEnableTagContainer;

		// Token: 0x0401123C RID: 70204
		[Nullable(2)]
		private FGameplayTagContainer _AutoDetectEnableTagContainer;

		// Token: 0x0401123D RID: 70205
		internal static int __PropertyOffset_IgnoreLockOnGameplayTagContainer;

		// Token: 0x0401123E RID: 70206
		[Nullable(2)]
		private FGameplayTagContainer _IgnoreLockOnGameplayTagContainer;

		// Token: 0x0401123F RID: 70207
		internal static int __PropertyOffset_AutoShootGameplayTagContainer;

		// Token: 0x04011240 RID: 70208
		[Nullable(2)]
		private FGameplayTagContainer _AutoShootGameplayTagContainer;

		// Token: 0x04011241 RID: 70209
		internal static int __PropertyOffset_CameraForwardDistance;

		// Token: 0x04011242 RID: 70210
		internal static int __PropertyOffset_CustomEntityKey;

		// Token: 0x04011243 RID: 70211
		internal static int __PropertyOffset_CustomBulletTargetKey;

		// Token: 0x04011244 RID: 70212
		internal static int __PropertyOffset_CustomBulletTargetRowNameSet;

		// Token: 0x04011245 RID: 70213
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _CustomBulletTargetRowNameSet;
	}
}
