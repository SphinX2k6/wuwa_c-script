using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DFF RID: 11775
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShield.LogicDataShield_C")]
public class LogicDataShield : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002214 RID: 8724
	// (get) Token: 0x06018BFD RID: 101373 RVA: 0x006592CC File Offset: 0x006574CC
	// (set) Token: 0x06018BFE RID: 101374 RVA: 0x006592DC File Offset: 0x006574DC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DefenseCanDodgeBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DefenseCanDodgeBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DefenseCanDodgeBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002215 RID: 8725
	// (get) Token: 0x06018BFF RID: 101375 RVA: 0x006592ED File Offset: 0x006574ED
	// (set) Token: 0x06018C00 RID: 101376 RVA: 0x006592FD File Offset: 0x006574FD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DefenseCaughtTrigger
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DefenseCaughtTrigger) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DefenseCaughtTrigger) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002216 RID: 8726
	// (get) Token: 0x06018C01 RID: 101377 RVA: 0x00659310 File Offset: 0x00657510
	// (set) Token: 0x06018C02 RID: 101378 RVA: 0x00659349 File Offset: 0x00657549
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> DefenseBulletIdList
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._DefenseBulletIdList) == null)
			{
				result = (this._DefenseBulletIdList = new TArray<string>(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DefenseBulletIdList, this));
			}
			return result;
		}
		set
		{
			this.DefenseBulletIdList.CopyAssign(value);
		}
	}

	// Token: 0x17002217 RID: 8727
	// (get) Token: 0x06018C03 RID: 101379 RVA: 0x00659358 File Offset: 0x00657558
	// (set) Token: 0x06018C04 RID: 101380 RVA: 0x00659391 File Offset: 0x00657591
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> NotDefenseBulletIdList
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._NotDefenseBulletIdList) == null)
			{
				result = (this._NotDefenseBulletIdList = new TArray<string>(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_NotDefenseBulletIdList, this));
			}
			return result;
		}
		set
		{
			this.NotDefenseBulletIdList.CopyAssign(value);
		}
	}

	// Token: 0x17002218 RID: 8728
	// (get) Token: 0x06018C05 RID: 101381 RVA: 0x0065939F File Offset: 0x0065759F
	// (set) Token: 0x06018C06 RID: 101382 RVA: 0x006593AF File Offset: 0x006575AF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECampType SelfCampType
	{
		get
		{
			return (ECampType)(*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_SelfCampType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_SelfCampType) = (byte)value;
		}
	}

	// Token: 0x17002219 RID: 8729
	// (get) Token: 0x06018C07 RID: 101383 RVA: 0x006593C0 File Offset: 0x006575C0
	// (set) Token: 0x06018C08 RID: 101384 RVA: 0x006593D0 File Offset: 0x006575D0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECampType FriendCampType
	{
		get
		{
			return (ECampType)(*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_FriendCampType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_FriendCampType) = (byte)value;
		}
	}

	// Token: 0x1700221A RID: 8730
	// (get) Token: 0x06018C09 RID: 101385 RVA: 0x006593E1 File Offset: 0x006575E1
	// (set) Token: 0x06018C0A RID: 101386 RVA: 0x006593F1 File Offset: 0x006575F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECampType EnemyCampType
	{
		get
		{
			return (ECampType)(*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_EnemyCampType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_EnemyCampType) = (byte)value;
		}
	}

	// Token: 0x1700221B RID: 8731
	// (get) Token: 0x06018C0B RID: 101387 RVA: 0x00659402 File Offset: 0x00657602
	// (set) Token: 0x06018C0C RID: 101388 RVA: 0x00659412 File Offset: 0x00657612
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int DefenseAngle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DefenseAngle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DefenseAngle) = value;
		}
	}

	// Token: 0x1700221C RID: 8732
	// (get) Token: 0x06018C0D RID: 101389 RVA: 0x00659424 File Offset: 0x00657624
	// (set) Token: 0x06018C0E RID: 101390 RVA: 0x0065945D File Offset: 0x0065765D
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<long> AddBuffToSelf
	{
		get
		{
			base.FastCheckIsValid();
			TArray<long> result;
			if ((result = this._AddBuffToSelf) == null)
			{
				result = (this._AddBuffToSelf = new TArray<long>(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_AddBuffToSelf, this));
			}
			return result;
		}
		set
		{
			this.AddBuffToSelf.CopyAssign(value);
		}
	}

	// Token: 0x1700221D RID: 8733
	// (get) Token: 0x06018C0F RID: 101391 RVA: 0x0065946C File Offset: 0x0065766C
	// (set) Token: 0x06018C10 RID: 101392 RVA: 0x006594A5 File Offset: 0x006576A5
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<long> AddBuffToEnemy
	{
		get
		{
			base.FastCheckIsValid();
			TArray<long> result;
			if ((result = this._AddBuffToEnemy) == null)
			{
				result = (this._AddBuffToEnemy = new TArray<long>(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_AddBuffToEnemy, this));
			}
			return result;
		}
		set
		{
			this.AddBuffToEnemy.CopyAssign(value);
		}
	}

	// Token: 0x1700221E RID: 8734
	// (get) Token: 0x06018C11 RID: 101393 RVA: 0x006594B3 File Offset: 0x006576B3
	// (set) Token: 0x06018C12 RID: 101394 RVA: 0x006594C3 File Offset: 0x006576C3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int DecreaseBulletHitCount
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DecreaseBulletHitCount);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_DecreaseBulletHitCount) = value;
		}
	}

	// Token: 0x1700221F RID: 8735
	// (get) Token: 0x06018C13 RID: 101395 RVA: 0x006594D4 File Offset: 0x006576D4
	// (set) Token: 0x06018C14 RID: 101396 RVA: 0x0065950D File Offset: 0x0065770D
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> SelfCalcTypeArray
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._SelfCalcTypeArray) == null)
			{
				result = (this._SelfCalcTypeArray = new TArray<int>(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_SelfCalcTypeArray, this));
			}
			return result;
		}
		set
		{
			this.SelfCalcTypeArray.CopyAssign(value);
		}
	}

	// Token: 0x17002220 RID: 8736
	// (get) Token: 0x06018C15 RID: 101397 RVA: 0x0065951C File Offset: 0x0065771C
	// (set) Token: 0x06018C16 RID: 101398 RVA: 0x00659555 File Offset: 0x00657755
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> FriendCalcTypeArray
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._FriendCalcTypeArray) == null)
			{
				result = (this._FriendCalcTypeArray = new TArray<int>(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_FriendCalcTypeArray, this));
			}
			return result;
		}
		set
		{
			this.FriendCalcTypeArray.CopyAssign(value);
		}
	}

	// Token: 0x17002221 RID: 8737
	// (get) Token: 0x06018C17 RID: 101399 RVA: 0x00659564 File Offset: 0x00657764
	// (set) Token: 0x06018C18 RID: 101400 RVA: 0x0065959D File Offset: 0x0065779D
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> EnemyCalcTypeArray
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._EnemyCalcTypeArray) == null)
			{
				result = (this._EnemyCalcTypeArray = new TArray<int>(base.NativePtr + (IntPtr)LogicDataShield.__PropertyOffset_EnemyCalcTypeArray, this));
			}
			return result;
		}
		set
		{
			this.EnemyCalcTypeArray.CopyAssign(value);
		}
	}

	// Token: 0x06018C19 RID: 101401 RVA: 0x006595AB File Offset: 0x006577AB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataShield._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShield.LogicDataShield_C");
		}
		return LogicDataShield._ClassPtr;
	}

	// Token: 0x06018C1A RID: 101402 RVA: 0x006595D0 File Offset: 0x006577D0
	public LogicDataShield() : this(BuiltinUtils.AllocNativeUObject(LogicDataShield.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C1B RID: 101403 RVA: 0x006595F8 File Offset: 0x006577F8
	public LogicDataShield(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShield.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C1C RID: 101404 RVA: 0x0065962B File Offset: 0x0065782B
	protected LogicDataShield(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B8B7 RID: 47287
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShield.LogicDataShield_C";

	// Token: 0x0400B8B8 RID: 47288
	private static IntPtr _ClassPtr;

	// Token: 0x0400B8B9 RID: 47289
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B8BA RID: 47290
	private static int __PropertyOffset_DefenseCanDodgeBullet;

	// Token: 0x0400B8BB RID: 47291
	private static int __PropertyOffset_DefenseCaughtTrigger;

	// Token: 0x0400B8BC RID: 47292
	private static int __PropertyOffset_DefenseBulletIdList;

	// Token: 0x0400B8BD RID: 47293
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _DefenseBulletIdList;

	// Token: 0x0400B8BE RID: 47294
	private static int __PropertyOffset_NotDefenseBulletIdList;

	// Token: 0x0400B8BF RID: 47295
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _NotDefenseBulletIdList;

	// Token: 0x0400B8C0 RID: 47296
	private static int __PropertyOffset_SelfCampType;

	// Token: 0x0400B8C1 RID: 47297
	private static int __PropertyOffset_FriendCampType;

	// Token: 0x0400B8C2 RID: 47298
	private static int __PropertyOffset_EnemyCampType;

	// Token: 0x0400B8C3 RID: 47299
	private static int __PropertyOffset_DefenseAngle;

	// Token: 0x0400B8C4 RID: 47300
	private static int __PropertyOffset_AddBuffToSelf;

	// Token: 0x0400B8C5 RID: 47301
	[Nullable(2)]
	private TArray<long> _AddBuffToSelf;

	// Token: 0x0400B8C6 RID: 47302
	private static int __PropertyOffset_AddBuffToEnemy;

	// Token: 0x0400B8C7 RID: 47303
	[Nullable(2)]
	private TArray<long> _AddBuffToEnemy;

	// Token: 0x0400B8C8 RID: 47304
	private static int __PropertyOffset_DecreaseBulletHitCount;

	// Token: 0x0400B8C9 RID: 47305
	private static int __PropertyOffset_SelfCalcTypeArray;

	// Token: 0x0400B8CA RID: 47306
	[Nullable(2)]
	private TArray<int> _SelfCalcTypeArray;

	// Token: 0x0400B8CB RID: 47307
	private static int __PropertyOffset_FriendCalcTypeArray;

	// Token: 0x0400B8CC RID: 47308
	[Nullable(2)]
	private TArray<int> _FriendCalcTypeArray;

	// Token: 0x0400B8CD RID: 47309
	private static int __PropertyOffset_EnemyCalcTypeArray;

	// Token: 0x0400B8CE RID: 47310
	[Nullable(2)]
	private TArray<int> _EnemyCalcTypeArray;
}
