using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002358 RID: 9048
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataRebound.LogicDataRebound_C")]
public class LogicDataRebound : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002268 RID: 8808
	// (get) Token: 0x0601648A RID: 91274 RVA: 0x0067EEF4 File Offset: 0x0067D0F4
	// (set) Token: 0x0601648B RID: 91275 RVA: 0x0067EF2D File Offset: 0x0067D12D
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> BulletRowName
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._BulletRowName) == null)
			{
				result = (this._BulletRowName = new TArray<string>(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_BulletRowName, this));
			}
			return result;
		}
		set
		{
			this.BulletRowName.CopyAssign(value);
		}
	}

	// Token: 0x17002269 RID: 8809
	// (get) Token: 0x0601648C RID: 91276 RVA: 0x0067EF3C File Offset: 0x0067D13C
	// (set) Token: 0x0601648D RID: 91277 RVA: 0x0067EF75 File Offset: 0x0067D175
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> EffectRebound
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._EffectRebound) == null)
			{
				result = (this._EffectRebound = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_EffectRebound, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_EffectRebound, 1);
		}
	}

	// Token: 0x1700226A RID: 8810
	// (get) Token: 0x0601648E RID: 91278 RVA: 0x0067EF9A File Offset: 0x0067D19A
	// (set) Token: 0x0601648F RID: 91279 RVA: 0x0067EFAE File Offset: 0x0067D1AE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector PositionOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_PositionOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_PositionOffset) = value;
		}
	}

	// Token: 0x1700226B RID: 8811
	// (get) Token: 0x06016490 RID: 91280 RVA: 0x0067EFC3 File Offset: 0x0067D1C3
	// (set) Token: 0x06016491 RID: 91281 RVA: 0x0067EFD7 File Offset: 0x0067D1D7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FRotator RotationOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_RotationOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_RotationOffset) = value;
		}
	}

	// Token: 0x1700226C RID: 8812
	// (get) Token: 0x06016492 RID: 91282 RVA: 0x0067EFEC File Offset: 0x0067D1EC
	// (set) Token: 0x06016493 RID: 91283 RVA: 0x0067F025 File Offset: 0x0067D225
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftClassPtr<UCameraShakeBase> ScreenShake
	{
		get
		{
			base.FastCheckIsValid();
			TSoftClassPtr<UCameraShakeBase> result;
			if ((result = this._ScreenShake) == null)
			{
				result = (this._ScreenShake = new TSoftClassPtr<UCameraShakeBase>(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_ScreenShake, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_ScreenShake, 1);
		}
	}

	// Token: 0x1700226D RID: 8813
	// (get) Token: 0x06016494 RID: 91284 RVA: 0x0067F04C File Offset: 0x0067D24C
	// (set) Token: 0x06016495 RID: 91285 RVA: 0x0067F085 File Offset: 0x0067D285
	[UProperty(EPropertyFlags.CPF_None)]
	public SCounterAttackCamera CameraModified
	{
		get
		{
			base.FastCheckIsValid();
			SCounterAttackCamera result;
			if ((result = this._CameraModified) == null)
			{
				result = (this._CameraModified = new SCounterAttackCamera(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_CameraModified, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SCounterAttackCamera.StaticStruct(), base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_CameraModified, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700226E RID: 8814
	// (get) Token: 0x06016496 RID: 91286 RVA: 0x0067F0AD File Offset: 0x0067D2AD
	// (set) Token: 0x06016497 RID: 91287 RVA: 0x0067F0BD File Offset: 0x0067D2BD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ReboundBitMask
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_ReboundBitMask);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_ReboundBitMask) = value;
		}
	}

	// Token: 0x1700226F RID: 8815
	// (get) Token: 0x06016498 RID: 91288 RVA: 0x0067F0CE File Offset: 0x0067D2CE
	// (set) Token: 0x06016499 RID: 91289 RVA: 0x0067F0DE File Offset: 0x0067D2DE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DestroyOtherBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_DestroyOtherBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataRebound.__PropertyOffset_DestroyOtherBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601649A RID: 91290 RVA: 0x0067F0EF File Offset: 0x0067D2EF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataRebound._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataRebound.LogicDataRebound_C");
		}
		return LogicDataRebound._ClassPtr;
	}

	// Token: 0x0601649B RID: 91291 RVA: 0x0067F114 File Offset: 0x0067D314
	public LogicDataRebound() : this(BuiltinUtils.AllocNativeUObject(LogicDataRebound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601649C RID: 91292 RVA: 0x0067F13C File Offset: 0x0067D33C
	public LogicDataRebound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataRebound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601649D RID: 91293 RVA: 0x0067F16F File Offset: 0x0067D36F
	protected LogicDataRebound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC22 RID: 48162
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataRebound.LogicDataRebound_C";

	// Token: 0x0400BC23 RID: 48163
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC24 RID: 48164
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC25 RID: 48165
	private static int __PropertyOffset_BulletRowName;

	// Token: 0x0400BC26 RID: 48166
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _BulletRowName;

	// Token: 0x0400BC27 RID: 48167
	private static int __PropertyOffset_EffectRebound;

	// Token: 0x0400BC28 RID: 48168
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectRebound;

	// Token: 0x0400BC29 RID: 48169
	private static int __PropertyOffset_PositionOffset;

	// Token: 0x0400BC2A RID: 48170
	private static int __PropertyOffset_RotationOffset;

	// Token: 0x0400BC2B RID: 48171
	private static int __PropertyOffset_ScreenShake;

	// Token: 0x0400BC2C RID: 48172
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftClassPtr<UCameraShakeBase> _ScreenShake;

	// Token: 0x0400BC2D RID: 48173
	private static int __PropertyOffset_CameraModified;

	// Token: 0x0400BC2E RID: 48174
	[Nullable(2)]
	private SCounterAttackCamera _CameraModified;

	// Token: 0x0400BC2F RID: 48175
	private static int __PropertyOffset_ReboundBitMask;

	// Token: 0x0400BC30 RID: 48176
	private static int __PropertyOffset_DestroyOtherBullet;
}
