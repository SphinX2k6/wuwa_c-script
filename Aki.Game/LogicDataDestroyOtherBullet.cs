using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF7 RID: 11767
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyOtherBullet.LogicDataDestroyOtherBullet_C")]
public class LogicDataDestroyOtherBullet : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021E3 RID: 8675
	// (get) Token: 0x06018B7B RID: 101243 RVA: 0x00658470 File Offset: 0x00656670
	// (set) Token: 0x06018B7C RID: 101244 RVA: 0x00658480 File Offset: 0x00656680
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECamp Camp
	{
		get
		{
			return (ECamp)(*(base.NativePtr + (IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_Camp));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_Camp) = (byte)value;
		}
	}

	// Token: 0x170021E4 RID: 8676
	// (get) Token: 0x06018B7D RID: 101245 RVA: 0x00658491 File Offset: 0x00656691
	// (set) Token: 0x06018B7E RID: 101246 RVA: 0x006584A5 File Offset: 0x006566A5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BulletId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_BulletId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_BulletId)), value);
		}
	}

	// Token: 0x170021E5 RID: 8677
	// (get) Token: 0x06018B7F RID: 101247 RVA: 0x006584BA File Offset: 0x006566BA
	// (set) Token: 0x06018B80 RID: 101248 RVA: 0x006584CA File Offset: 0x006566CA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SummonChildBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_SummonChildBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_SummonChildBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x06018B81 RID: 101249 RVA: 0x006584DB File Offset: 0x006566DB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataDestroyOtherBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyOtherBullet.LogicDataDestroyOtherBullet_C");
		}
		return LogicDataDestroyOtherBullet._ClassPtr;
	}

	// Token: 0x06018B82 RID: 101250 RVA: 0x00658500 File Offset: 0x00656700
	public LogicDataDestroyOtherBullet() : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyOtherBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B83 RID: 101251 RVA: 0x00658528 File Offset: 0x00656728
	public LogicDataDestroyOtherBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyOtherBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B84 RID: 101252 RVA: 0x0065855B File Offset: 0x0065675B
	protected LogicDataDestroyOtherBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B85F RID: 47199
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyOtherBullet.LogicDataDestroyOtherBullet_C";

	// Token: 0x0400B860 RID: 47200
	private static IntPtr _ClassPtr;

	// Token: 0x0400B861 RID: 47201
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B862 RID: 47202
	private static int __PropertyOffset_Camp;

	// Token: 0x0400B863 RID: 47203
	private static int __PropertyOffset_BulletId;

	// Token: 0x0400B864 RID: 47204
	private static int __PropertyOffset_SummonChildBullet;
}
