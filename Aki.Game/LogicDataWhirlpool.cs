using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E07 RID: 11783
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataWhirlpool.LogicDataWhirlpool_C")]
public class LogicDataWhirlpool : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002247 RID: 8775
	// (get) Token: 0x06018C83 RID: 101507 RVA: 0x00659FE8 File Offset: 0x006581E8
	// (set) Token: 0x06018C84 RID: 101508 RVA: 0x00659FF8 File Offset: 0x006581F8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MoveTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_MoveTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_MoveTime) = value;
		}
	}

	// Token: 0x17002248 RID: 8776
	// (get) Token: 0x06018C85 RID: 101509 RVA: 0x0065A009 File Offset: 0x00658209
	// (set) Token: 0x06018C86 RID: 101510 RVA: 0x0065A019 File Offset: 0x00658219
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float WeightLimit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_WeightLimit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_WeightLimit) = value;
		}
	}

	// Token: 0x17002249 RID: 8777
	// (get) Token: 0x06018C87 RID: 101511 RVA: 0x0065A02A File Offset: 0x0065822A
	// (set) Token: 0x06018C88 RID: 101512 RVA: 0x0065A03E File Offset: 0x0065823E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EVelocityCurveType> VelocityCurve
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_VelocityCurve);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_VelocityCurve) = value;
		}
	}

	// Token: 0x1700224A RID: 8778
	// (get) Token: 0x06018C89 RID: 101513 RVA: 0x0065A053 File Offset: 0x00658253
	// (set) Token: 0x06018C8A RID: 101514 RVA: 0x0065A067 File Offset: 0x00658267
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag TagNeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_TagNeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_TagNeed) = value;
		}
	}

	// Token: 0x1700224B RID: 8779
	// (get) Token: 0x06018C8B RID: 101515 RVA: 0x0065A07C File Offset: 0x0065827C
	// (set) Token: 0x06018C8C RID: 101516 RVA: 0x0065A090 File Offset: 0x00658290
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName AttackerSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_AttackerSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_AttackerSocketName) = value;
		}
	}

	// Token: 0x1700224C RID: 8780
	// (get) Token: 0x06018C8D RID: 101517 RVA: 0x0065A0A5 File Offset: 0x006582A5
	// (set) Token: 0x06018C8E RID: 101518 RVA: 0x0065A0B5 File Offset: 0x006582B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CancelByHit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_CancelByHit) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_CancelByHit) = (value ? 1 : 0);
		}
	}

	// Token: 0x06018C8F RID: 101519 RVA: 0x0065A0C6 File Offset: 0x006582C6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataWhirlpool._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataWhirlpool.LogicDataWhirlpool_C");
		}
		return LogicDataWhirlpool._ClassPtr;
	}

	// Token: 0x06018C90 RID: 101520 RVA: 0x0065A0EC File Offset: 0x006582EC
	public LogicDataWhirlpool() : this(BuiltinUtils.AllocNativeUObject(LogicDataWhirlpool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C91 RID: 101521 RVA: 0x0065A114 File Offset: 0x00658314
	[NullableContext(1)]
	public LogicDataWhirlpool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataWhirlpool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C92 RID: 101522 RVA: 0x0065A147 File Offset: 0x00658347
	protected LogicDataWhirlpool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B90D RID: 47373
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataWhirlpool.LogicDataWhirlpool_C";

	// Token: 0x0400B90E RID: 47374
	private static IntPtr _ClassPtr;

	// Token: 0x0400B90F RID: 47375
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B910 RID: 47376
	private static int __PropertyOffset_MoveTime;

	// Token: 0x0400B911 RID: 47377
	private static int __PropertyOffset_WeightLimit;

	// Token: 0x0400B912 RID: 47378
	private static int __PropertyOffset_VelocityCurve;

	// Token: 0x0400B913 RID: 47379
	private static int __PropertyOffset_TagNeed;

	// Token: 0x0400B914 RID: 47380
	private static int __PropertyOffset_AttackerSocketName;

	// Token: 0x0400B915 RID: 47381
	private static int __PropertyOffset_CancelByHit;
}
