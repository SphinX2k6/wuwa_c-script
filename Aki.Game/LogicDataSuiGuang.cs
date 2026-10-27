using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E04 RID: 11780
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSuiGuang.LogicDataSuiGuang_C")]
public class LogicDataSuiGuang : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700223D RID: 8765
	// (get) Token: 0x06018C63 RID: 101475 RVA: 0x00659CAC File Offset: 0x00657EAC
	// (set) Token: 0x06018C64 RID: 101476 RVA: 0x00659CBC File Offset: 0x00657EBC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IncludeBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSuiGuang.__PropertyOffset_IncludeBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSuiGuang.__PropertyOffset_IncludeBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700223E RID: 8766
	// (get) Token: 0x06018C65 RID: 101477 RVA: 0x00659CCD File Offset: 0x00657ECD
	// (set) Token: 0x06018C66 RID: 101478 RVA: 0x00659CE1 File Offset: 0x00657EE1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag NeedTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSuiGuang.__PropertyOffset_NeedTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSuiGuang.__PropertyOffset_NeedTag) = value;
		}
	}

	// Token: 0x1700223F RID: 8767
	// (get) Token: 0x06018C67 RID: 101479 RVA: 0x00659CF6 File Offset: 0x00657EF6
	// (set) Token: 0x06018C68 RID: 101480 RVA: 0x00659D0A File Offset: 0x00657F0A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string NewBulletId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataSuiGuang.__PropertyOffset_NewBulletId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataSuiGuang.__PropertyOffset_NewBulletId)), value);
		}
	}

	// Token: 0x06018C69 RID: 101481 RVA: 0x00659D1F File Offset: 0x00657F1F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSuiGuang._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSuiGuang.LogicDataSuiGuang_C");
		}
		return LogicDataSuiGuang._ClassPtr;
	}

	// Token: 0x06018C6A RID: 101482 RVA: 0x00659D44 File Offset: 0x00657F44
	public LogicDataSuiGuang() : this(BuiltinUtils.AllocNativeUObject(LogicDataSuiGuang.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C6B RID: 101483 RVA: 0x00659D6C File Offset: 0x00657F6C
	public LogicDataSuiGuang(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSuiGuang.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C6C RID: 101484 RVA: 0x00659D9F File Offset: 0x00657F9F
	protected LogicDataSuiGuang(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B8F9 RID: 47353
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSuiGuang.LogicDataSuiGuang_C";

	// Token: 0x0400B8FA RID: 47354
	private static IntPtr _ClassPtr;

	// Token: 0x0400B8FB RID: 47355
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B8FC RID: 47356
	private static int __PropertyOffset_IncludeBullet;

	// Token: 0x0400B8FD RID: 47357
	private static int __PropertyOffset_NeedTag;

	// Token: 0x0400B8FE RID: 47358
	private static int __PropertyOffset_NewBulletId;
}
