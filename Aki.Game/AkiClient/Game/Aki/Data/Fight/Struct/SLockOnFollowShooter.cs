using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F6A RID: 16234
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooter.SLockOnFollowShooter")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class SLockOnFollowShooter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029606 RID: 169478 RVA: 0x009C2B8D File Offset: 0x009C0D8D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnFollowShooter._ScriptStructPtr != 0) ? SLockOnFollowShooter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooter.SLockOnFollowShooter", ref SLockOnFollowShooter._ScriptStructPtr);
		}

		// Token: 0x170062E1 RID: 25313
		// (get) Token: 0x06029607 RID: 169479 RVA: 0x009C2BB1 File Offset: 0x009C0DB1
		// (set) Token: 0x06029608 RID: 169480 RVA: 0x009C2BC1 File Offset: 0x009C0DC1
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062E2 RID: 25314
		// (get) Token: 0x06029609 RID: 169481 RVA: 0x009C2BD2 File Offset: 0x009C0DD2
		// (set) Token: 0x0602960A RID: 169482 RVA: 0x009C2BE2 File Offset: 0x009C0DE2
		public unsafe float GapTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170062E3 RID: 25315
		// (get) Token: 0x0602960B RID: 169483 RVA: 0x009C2BF3 File Offset: 0x009C0DF3
		// (set) Token: 0x0602960C RID: 169484 RVA: 0x009C2C03 File Offset: 0x009C0E03
		public unsafe int Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170062E4 RID: 25316
		// (get) Token: 0x0602960D RID: 169485 RVA: 0x009C2C14 File Offset: 0x009C0E14
		// (set) Token: 0x0602960E RID: 169486 RVA: 0x009C2C24 File Offset: 0x009C0E24
		public unsafe int Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170062E5 RID: 25317
		// (get) Token: 0x0602960F RID: 169487 RVA: 0x009C2C35 File Offset: 0x009C0E35
		// (set) Token: 0x06029610 RID: 169488 RVA: 0x009C2C45 File Offset: 0x009C0E45
		public unsafe float WorldDistanceWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170062E6 RID: 25318
		// (get) Token: 0x06029611 RID: 169489 RVA: 0x009C2C56 File Offset: 0x009C0E56
		// (set) Token: 0x06029612 RID: 169490 RVA: 0x009C2C66 File Offset: 0x009C0E66
		public unsafe float ScreenDistanceWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170062E7 RID: 25319
		// (get) Token: 0x06029613 RID: 169491 RVA: 0x009C2C77 File Offset: 0x009C0E77
		// (set) Token: 0x06029614 RID: 169492 RVA: 0x009C2C87 File Offset: 0x009C0E87
		public unsafe float CharacterExtraWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170062E8 RID: 25320
		// (get) Token: 0x06029615 RID: 169493 RVA: 0x009C2C98 File Offset: 0x009C0E98
		// (set) Token: 0x06029616 RID: 169494 RVA: 0x009C2CA8 File Offset: 0x009C0EA8
		public unsafe float SceneItemExtraWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170062E9 RID: 25321
		// (get) Token: 0x06029617 RID: 169495 RVA: 0x009C2CBC File Offset: 0x009C0EBC
		// (set) Token: 0x06029618 RID: 169496 RVA: 0x009C2CFF File Offset: 0x009C0EFF
		public TArray<SLockOnFollowShooterAutoAim> ArrayAutoAimConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SLockOnFollowShooterAutoAim> result;
				if ((result = this._ArrayAutoAimConfig) == null)
				{
					result = (this._ArrayAutoAimConfig = new TArray<SLockOnFollowShooterAutoAim>(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ArrayAutoAimConfig.CopyAssign(value);
			}
		}

		// Token: 0x170062EA RID: 25322
		// (get) Token: 0x06029619 RID: 169497 RVA: 0x009C2D10 File Offset: 0x009C0F10
		// (set) Token: 0x0602961A RID: 169498 RVA: 0x009C2D53 File Offset: 0x009C0F53
		public FGameplayTagContainer LockOnGameplayTagContainer
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._LockOnGameplayTagContainer) == null)
				{
					result = (this._LockOnGameplayTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170062EB RID: 25323
		// (get) Token: 0x0602961B RID: 169499 RVA: 0x009C2D74 File Offset: 0x009C0F74
		// (set) Token: 0x0602961C RID: 169500 RVA: 0x009C2DB7 File Offset: 0x009C0FB7
		public FGameplayTagContainer AutoDetectEnableTagContainer
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AutoDetectEnableTagContainer) == null)
				{
					result = (this._AutoDetectEnableTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170062EC RID: 25324
		// (get) Token: 0x0602961D RID: 169501 RVA: 0x009C2DD8 File Offset: 0x009C0FD8
		// (set) Token: 0x0602961E RID: 169502 RVA: 0x009C2E1B File Offset: 0x009C101B
		public FGameplayTagContainer IgnoreLockOnGameplayTagContainer
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._IgnoreLockOnGameplayTagContainer) == null)
				{
					result = (this._IgnoreLockOnGameplayTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170062ED RID: 25325
		// (get) Token: 0x0602961F RID: 169503 RVA: 0x009C2E3C File Offset: 0x009C103C
		// (set) Token: 0x06029620 RID: 169504 RVA: 0x009C2E7F File Offset: 0x009C107F
		public FGameplayTagContainer AutoShootGameplayTagContainer
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AutoShootGameplayTagContainer) == null)
				{
					result = (this._AutoShootGameplayTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170062EE RID: 25326
		// (get) Token: 0x06029621 RID: 169505 RVA: 0x009C2EA0 File Offset: 0x009C10A0
		// (set) Token: 0x06029622 RID: 169506 RVA: 0x009C2EB0 File Offset: 0x009C10B0
		public unsafe float CameraForwardDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170062EF RID: 25327
		// (get) Token: 0x06029623 RID: 169507 RVA: 0x009C2EC1 File Offset: 0x009C10C1
		// (set) Token: 0x06029624 RID: 169508 RVA: 0x009C2ED5 File Offset: 0x009C10D5
		public unsafe string CustomEntityKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnFollowShooter.__PropertyOffset_14)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnFollowShooter.__PropertyOffset_14)), value);
			}
		}

		// Token: 0x170062F0 RID: 25328
		// (get) Token: 0x06029625 RID: 169509 RVA: 0x009C2EEA File Offset: 0x009C10EA
		// (set) Token: 0x06029626 RID: 169510 RVA: 0x009C2EFE File Offset: 0x009C10FE
		public unsafe string CustomBulletTargetKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnFollowShooter.__PropertyOffset_15)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLockOnFollowShooter.__PropertyOffset_15)), value);
			}
		}

		// Token: 0x170062F1 RID: 25329
		// (get) Token: 0x06029627 RID: 169511 RVA: 0x009C2F14 File Offset: 0x009C1114
		// (set) Token: 0x06029628 RID: 169512 RVA: 0x009C2F57 File Offset: 0x009C1157
		public TSet<string> CustomBulletTargetRowNameSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._CustomBulletTargetRowNameSet) == null)
				{
					result = (this._CustomBulletTargetRowNameSet = new TSet<string>(base.NativePtr + (IntPtr)SLockOnFollowShooter.__PropertyOffset_16, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomBulletTargetRowNameSet.CopyAssign(value);
			}
		}

		// Token: 0x06029629 RID: 169513 RVA: 0x009C2F65 File Offset: 0x009C1165
		public SLockOnFollowShooter()
		{
		}

		// Token: 0x0602962A RID: 169514 RVA: 0x009C2F70 File Offset: 0x009C1170
		public SLockOnFollowShooter(bool Enable, float GapTime, int Distance, int Radius, float WorldDistanceWeight, float ScreenDistanceWeight, float CharacterExtraWeight, float SceneItemExtraWeight, TArray<SLockOnFollowShooterAutoAim> ArrayAutoAimConfig, FGameplayTagContainer LockOnGameplayTagContainer, FGameplayTagContainer AutoDetectEnableTagContainer, FGameplayTagContainer IgnoreLockOnGameplayTagContainer, FGameplayTagContainer AutoShootGameplayTagContainer, float CameraForwardDistance, string CustomEntityKey, string CustomBulletTargetKey, TSet<string> CustomBulletTargetRowNameSet)
		{
			this.Enable = Enable;
			this.GapTime = GapTime;
			this.Distance = Distance;
			this.Radius = Radius;
			this.WorldDistanceWeight = WorldDistanceWeight;
			this.ScreenDistanceWeight = ScreenDistanceWeight;
			this.CharacterExtraWeight = CharacterExtraWeight;
			this.SceneItemExtraWeight = SceneItemExtraWeight;
			this.ArrayAutoAimConfig = ArrayAutoAimConfig;
			this.LockOnGameplayTagContainer = LockOnGameplayTagContainer;
			this.AutoDetectEnableTagContainer = AutoDetectEnableTagContainer;
			this.IgnoreLockOnGameplayTagContainer = IgnoreLockOnGameplayTagContainer;
			this.AutoShootGameplayTagContainer = AutoShootGameplayTagContainer;
			this.CameraForwardDistance = CameraForwardDistance;
			this.CustomEntityKey = CustomEntityKey;
			this.CustomBulletTargetKey = CustomBulletTargetKey;
			this.CustomBulletTargetRowNameSet = CustomBulletTargetRowNameSet;
		}

		// Token: 0x0602962B RID: 169515 RVA: 0x009C3008 File Offset: 0x009C1208
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnFollowShooter.StaticStruct();
		}

		// Token: 0x0602962C RID: 169516 RVA: 0x009C3014 File Offset: 0x009C1214
		[NullableContext(2)]
		public SLockOnFollowShooter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602962D RID: 169517 RVA: 0x009C301E File Offset: 0x009C121E
		public SLockOnFollowShooter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602962E RID: 169518 RVA: 0x009C3029 File Offset: 0x009C1229
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnFollowShooter(Pointer, false, true);
		}

		// Token: 0x0602962F RID: 169519 RVA: 0x009C3033 File Offset: 0x009C1233
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnFollowShooter(Pointer, MemoryOwner);
		}

		// Token: 0x04015339 RID: 86841
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnFollowShooter.SLockOnFollowShooter";

		// Token: 0x0401533A RID: 86842
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401533B RID: 86843
		internal static int __PropertyOffset_0;

		// Token: 0x0401533C RID: 86844
		internal static int __PropertyOffset_1;

		// Token: 0x0401533D RID: 86845
		internal static int __PropertyOffset_2;

		// Token: 0x0401533E RID: 86846
		internal static int __PropertyOffset_3;

		// Token: 0x0401533F RID: 86847
		internal static int __PropertyOffset_4;

		// Token: 0x04015340 RID: 86848
		internal static int __PropertyOffset_5;

		// Token: 0x04015341 RID: 86849
		internal static int __PropertyOffset_6;

		// Token: 0x04015342 RID: 86850
		internal static int __PropertyOffset_7;

		// Token: 0x04015343 RID: 86851
		internal static int __PropertyOffset_8;

		// Token: 0x04015344 RID: 86852
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SLockOnFollowShooterAutoAim> _ArrayAutoAimConfig;

		// Token: 0x04015345 RID: 86853
		internal static int __PropertyOffset_9;

		// Token: 0x04015346 RID: 86854
		[Nullable(2)]
		private FGameplayTagContainer _LockOnGameplayTagContainer;

		// Token: 0x04015347 RID: 86855
		internal static int __PropertyOffset_10;

		// Token: 0x04015348 RID: 86856
		[Nullable(2)]
		private FGameplayTagContainer _AutoDetectEnableTagContainer;

		// Token: 0x04015349 RID: 86857
		internal static int __PropertyOffset_11;

		// Token: 0x0401534A RID: 86858
		[Nullable(2)]
		private FGameplayTagContainer _IgnoreLockOnGameplayTagContainer;

		// Token: 0x0401534B RID: 86859
		internal static int __PropertyOffset_12;

		// Token: 0x0401534C RID: 86860
		[Nullable(2)]
		private FGameplayTagContainer _AutoShootGameplayTagContainer;

		// Token: 0x0401534D RID: 86861
		internal static int __PropertyOffset_13;

		// Token: 0x0401534E RID: 86862
		internal static int __PropertyOffset_14;

		// Token: 0x0401534F RID: 86863
		internal static int __PropertyOffset_15;

		// Token: 0x04015350 RID: 86864
		internal static int __PropertyOffset_16;

		// Token: 0x04015351 RID: 86865
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _CustomBulletTargetRowNameSet;
	}
}
