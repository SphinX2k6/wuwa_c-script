using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200235A RID: 9050
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShield.LogicDataShield_C")]
public class LogicDataShield : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002278 RID: 8824
	// (get) Token: 0x060164B2 RID: 91314 RVA: 0x0067F350 File Offset: 0x0067D550
	// (set) Token: 0x060164B3 RID: 91315 RVA: 0x0067F360 File Offset: 0x0067D560
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

	// Token: 0x17002279 RID: 8825
	// (get) Token: 0x060164B4 RID: 91316 RVA: 0x0067F371 File Offset: 0x0067D571
	// (set) Token: 0x060164B5 RID: 91317 RVA: 0x0067F381 File Offset: 0x0067D581
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

	// Token: 0x1700227A RID: 8826
	// (get) Token: 0x060164B6 RID: 91318 RVA: 0x0067F394 File Offset: 0x0067D594
	// (set) Token: 0x060164B7 RID: 91319 RVA: 0x0067F3CD File Offset: 0x0067D5CD
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

	// Token: 0x1700227B RID: 8827
	// (get) Token: 0x060164B8 RID: 91320 RVA: 0x0067F3DC File Offset: 0x0067D5DC
	// (set) Token: 0x060164B9 RID: 91321 RVA: 0x0067F415 File Offset: 0x0067D615
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

	// Token: 0x1700227C RID: 8828
	// (get) Token: 0x060164BA RID: 91322 RVA: 0x0067F423 File Offset: 0x0067D623
	// (set) Token: 0x060164BB RID: 91323 RVA: 0x0067F433 File Offset: 0x0067D633
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

	// Token: 0x1700227D RID: 8829
	// (get) Token: 0x060164BC RID: 91324 RVA: 0x0067F444 File Offset: 0x0067D644
	// (set) Token: 0x060164BD RID: 91325 RVA: 0x0067F454 File Offset: 0x0067D654
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

	// Token: 0x1700227E RID: 8830
	// (get) Token: 0x060164BE RID: 91326 RVA: 0x0067F465 File Offset: 0x0067D665
	// (set) Token: 0x060164BF RID: 91327 RVA: 0x0067F475 File Offset: 0x0067D675
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

	// Token: 0x1700227F RID: 8831
	// (get) Token: 0x060164C0 RID: 91328 RVA: 0x0067F486 File Offset: 0x0067D686
	// (set) Token: 0x060164C1 RID: 91329 RVA: 0x0067F496 File Offset: 0x0067D696
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

	// Token: 0x17002280 RID: 8832
	// (get) Token: 0x060164C2 RID: 91330 RVA: 0x0067F4A8 File Offset: 0x0067D6A8
	// (set) Token: 0x060164C3 RID: 91331 RVA: 0x0067F4E1 File Offset: 0x0067D6E1
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

	// Token: 0x17002281 RID: 8833
	// (get) Token: 0x060164C4 RID: 91332 RVA: 0x0067F4F0 File Offset: 0x0067D6F0
	// (set) Token: 0x060164C5 RID: 91333 RVA: 0x0067F529 File Offset: 0x0067D729
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

	// Token: 0x17002282 RID: 8834
	// (get) Token: 0x060164C6 RID: 91334 RVA: 0x0067F537 File Offset: 0x0067D737
	// (set) Token: 0x060164C7 RID: 91335 RVA: 0x0067F547 File Offset: 0x0067D747
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

	// Token: 0x17002283 RID: 8835
	// (get) Token: 0x060164C8 RID: 91336 RVA: 0x0067F558 File Offset: 0x0067D758
	// (set) Token: 0x060164C9 RID: 91337 RVA: 0x0067F591 File Offset: 0x0067D791
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

	// Token: 0x17002284 RID: 8836
	// (get) Token: 0x060164CA RID: 91338 RVA: 0x0067F5A0 File Offset: 0x0067D7A0
	// (set) Token: 0x060164CB RID: 91339 RVA: 0x0067F5D9 File Offset: 0x0067D7D9
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

	// Token: 0x17002285 RID: 8837
	// (get) Token: 0x060164CC RID: 91340 RVA: 0x0067F5E8 File Offset: 0x0067D7E8
	// (set) Token: 0x060164CD RID: 91341 RVA: 0x0067F621 File Offset: 0x0067D821
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

	// Token: 0x060164CE RID: 91342 RVA: 0x0067F62F File Offset: 0x0067D82F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataShield._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShield.LogicDataShield_C");
		}
		return LogicDataShield._ClassPtr;
	}

	// Token: 0x060164CF RID: 91343 RVA: 0x0067F654 File Offset: 0x0067D854
	public LogicDataShield() : this(BuiltinUtils.AllocNativeUObject(LogicDataShield.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060164D0 RID: 91344 RVA: 0x0067F67C File Offset: 0x0067D87C
	public LogicDataShield(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShield.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060164D1 RID: 91345 RVA: 0x0067F6AF File Offset: 0x0067D8AF
	protected LogicDataShield(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC3D RID: 48189
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShield.LogicDataShield_C";

	// Token: 0x0400BC3E RID: 48190
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC3F RID: 48191
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC40 RID: 48192
	private static int __PropertyOffset_DefenseCanDodgeBullet;

	// Token: 0x0400BC41 RID: 48193
	private static int __PropertyOffset_DefenseCaughtTrigger;

	// Token: 0x0400BC42 RID: 48194
	private static int __PropertyOffset_DefenseBulletIdList;

	// Token: 0x0400BC43 RID: 48195
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _DefenseBulletIdList;

	// Token: 0x0400BC44 RID: 48196
	private static int __PropertyOffset_NotDefenseBulletIdList;

	// Token: 0x0400BC45 RID: 48197
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _NotDefenseBulletIdList;

	// Token: 0x0400BC46 RID: 48198
	private static int __PropertyOffset_SelfCampType;

	// Token: 0x0400BC47 RID: 48199
	private static int __PropertyOffset_FriendCampType;

	// Token: 0x0400BC48 RID: 48200
	private static int __PropertyOffset_EnemyCampType;

	// Token: 0x0400BC49 RID: 48201
	private static int __PropertyOffset_DefenseAngle;

	// Token: 0x0400BC4A RID: 48202
	private static int __PropertyOffset_AddBuffToSelf;

	// Token: 0x0400BC4B RID: 48203
	[Nullable(2)]
	private TArray<long> _AddBuffToSelf;

	// Token: 0x0400BC4C RID: 48204
	private static int __PropertyOffset_AddBuffToEnemy;

	// Token: 0x0400BC4D RID: 48205
	[Nullable(2)]
	private TArray<long> _AddBuffToEnemy;

	// Token: 0x0400BC4E RID: 48206
	private static int __PropertyOffset_DecreaseBulletHitCount;

	// Token: 0x0400BC4F RID: 48207
	private static int __PropertyOffset_SelfCalcTypeArray;

	// Token: 0x0400BC50 RID: 48208
	[Nullable(2)]
	private TArray<int> _SelfCalcTypeArray;

	// Token: 0x0400BC51 RID: 48209
	private static int __PropertyOffset_FriendCalcTypeArray;

	// Token: 0x0400BC52 RID: 48210
	[Nullable(2)]
	private TArray<int> _FriendCalcTypeArray;

	// Token: 0x0400BC53 RID: 48211
	private static int __PropertyOffset_EnemyCalcTypeArray;

	// Token: 0x0400BC54 RID: 48212
	[Nullable(2)]
	private TArray<int> _EnemyCalcTypeArray;
}
