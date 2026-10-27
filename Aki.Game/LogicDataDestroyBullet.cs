using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF6 RID: 11766
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyBullet.LogicDataDestroyBullet_C")]
public class LogicDataDestroyBullet : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021E0 RID: 8672
	// (get) Token: 0x06018B71 RID: 101233 RVA: 0x0065837C File Offset: 0x0065657C
	// (set) Token: 0x06018B72 RID: 101234 RVA: 0x0065838C File Offset: 0x0065658C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletObject BulletOwner
	{
		get
		{
			return (EBulletObject)(*(base.NativePtr + (IntPtr)LogicDataDestroyBullet.__PropertyOffset_BulletOwner));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataDestroyBullet.__PropertyOffset_BulletOwner) = (byte)value;
		}
	}

	// Token: 0x170021E1 RID: 8673
	// (get) Token: 0x06018B73 RID: 101235 RVA: 0x0065839D File Offset: 0x0065659D
	// (set) Token: 0x06018B74 RID: 101236 RVA: 0x006583B1 File Offset: 0x006565B1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string DestroyBulletRowName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataDestroyBullet.__PropertyOffset_DestroyBulletRowName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataDestroyBullet.__PropertyOffset_DestroyBulletRowName)), value);
		}
	}

	// Token: 0x170021E2 RID: 8674
	// (get) Token: 0x06018B75 RID: 101237 RVA: 0x006583C6 File Offset: 0x006565C6
	// (set) Token: 0x06018B76 RID: 101238 RVA: 0x006583D6 File Offset: 0x006565D6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SummonChildBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataDestroyBullet.__PropertyOffset_SummonChildBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataDestroyBullet.__PropertyOffset_SummonChildBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x06018B77 RID: 101239 RVA: 0x006583E7 File Offset: 0x006565E7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataDestroyBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyBullet.LogicDataDestroyBullet_C");
		}
		return LogicDataDestroyBullet._ClassPtr;
	}

	// Token: 0x06018B78 RID: 101240 RVA: 0x0065840C File Offset: 0x0065660C
	public LogicDataDestroyBullet() : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B79 RID: 101241 RVA: 0x00658434 File Offset: 0x00656634
	public LogicDataDestroyBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B7A RID: 101242 RVA: 0x00658467 File Offset: 0x00656667
	protected LogicDataDestroyBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B859 RID: 47193
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyBullet.LogicDataDestroyBullet_C";

	// Token: 0x0400B85A RID: 47194
	private static IntPtr _ClassPtr;

	// Token: 0x0400B85B RID: 47195
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B85C RID: 47196
	private static int __PropertyOffset_BulletOwner;

	// Token: 0x0400B85D RID: 47197
	private static int __PropertyOffset_DestroyBulletRowName;

	// Token: 0x0400B85E RID: 47198
	private static int __PropertyOffset_SummonChildBullet;
}
