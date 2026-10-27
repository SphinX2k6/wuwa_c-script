using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DFD RID: 11773
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataRebound.LogicDataRebound_C")]
public class LogicDataRebound : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002204 RID: 8708
	// (get) Token: 0x06018BD5 RID: 101333 RVA: 0x00658E70 File Offset: 0x00657070
	// (set) Token: 0x06018BD6 RID: 101334 RVA: 0x00658EA9 File Offset: 0x006570A9
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

	// Token: 0x17002205 RID: 8709
	// (get) Token: 0x06018BD7 RID: 101335 RVA: 0x00658EB8 File Offset: 0x006570B8
	// (set) Token: 0x06018BD8 RID: 101336 RVA: 0x00658EF1 File Offset: 0x006570F1
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

	// Token: 0x17002206 RID: 8710
	// (get) Token: 0x06018BD9 RID: 101337 RVA: 0x00658F16 File Offset: 0x00657116
	// (set) Token: 0x06018BDA RID: 101338 RVA: 0x00658F2A File Offset: 0x0065712A
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

	// Token: 0x17002207 RID: 8711
	// (get) Token: 0x06018BDB RID: 101339 RVA: 0x00658F3F File Offset: 0x0065713F
	// (set) Token: 0x06018BDC RID: 101340 RVA: 0x00658F53 File Offset: 0x00657153
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

	// Token: 0x17002208 RID: 8712
	// (get) Token: 0x06018BDD RID: 101341 RVA: 0x00658F68 File Offset: 0x00657168
	// (set) Token: 0x06018BDE RID: 101342 RVA: 0x00658FA1 File Offset: 0x006571A1
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

	// Token: 0x17002209 RID: 8713
	// (get) Token: 0x06018BDF RID: 101343 RVA: 0x00658FC8 File Offset: 0x006571C8
	// (set) Token: 0x06018BE0 RID: 101344 RVA: 0x00659001 File Offset: 0x00657201
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

	// Token: 0x1700220A RID: 8714
	// (get) Token: 0x06018BE1 RID: 101345 RVA: 0x00659029 File Offset: 0x00657229
	// (set) Token: 0x06018BE2 RID: 101346 RVA: 0x00659039 File Offset: 0x00657239
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

	// Token: 0x1700220B RID: 8715
	// (get) Token: 0x06018BE3 RID: 101347 RVA: 0x0065904A File Offset: 0x0065724A
	// (set) Token: 0x06018BE4 RID: 101348 RVA: 0x0065905A File Offset: 0x0065725A
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

	// Token: 0x06018BE5 RID: 101349 RVA: 0x0065906B File Offset: 0x0065726B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataRebound._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataRebound.LogicDataRebound_C");
		}
		return LogicDataRebound._ClassPtr;
	}

	// Token: 0x06018BE6 RID: 101350 RVA: 0x00659090 File Offset: 0x00657290
	public LogicDataRebound() : this(BuiltinUtils.AllocNativeUObject(LogicDataRebound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018BE7 RID: 101351 RVA: 0x006590B8 File Offset: 0x006572B8
	public LogicDataRebound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataRebound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018BE8 RID: 101352 RVA: 0x006590EB File Offset: 0x006572EB
	protected LogicDataRebound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B89C RID: 47260
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataRebound.LogicDataRebound_C";

	// Token: 0x0400B89D RID: 47261
	private static IntPtr _ClassPtr;

	// Token: 0x0400B89E RID: 47262
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B89F RID: 47263
	private static int __PropertyOffset_BulletRowName;

	// Token: 0x0400B8A0 RID: 47264
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _BulletRowName;

	// Token: 0x0400B8A1 RID: 47265
	private static int __PropertyOffset_EffectRebound;

	// Token: 0x0400B8A2 RID: 47266
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectRebound;

	// Token: 0x0400B8A3 RID: 47267
	private static int __PropertyOffset_PositionOffset;

	// Token: 0x0400B8A4 RID: 47268
	private static int __PropertyOffset_RotationOffset;

	// Token: 0x0400B8A5 RID: 47269
	private static int __PropertyOffset_ScreenShake;

	// Token: 0x0400B8A6 RID: 47270
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftClassPtr<UCameraShakeBase> _ScreenShake;

	// Token: 0x0400B8A7 RID: 47271
	private static int __PropertyOffset_CameraModified;

	// Token: 0x0400B8A8 RID: 47272
	[Nullable(2)]
	private SCounterAttackCamera _CameraModified;

	// Token: 0x0400B8A9 RID: 47273
	private static int __PropertyOffset_ReboundBitMask;

	// Token: 0x0400B8AA RID: 47274
	private static int __PropertyOffset_DestroyOtherBullet;
}
