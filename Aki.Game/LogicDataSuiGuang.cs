using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002360 RID: 9056
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSuiGuang.LogicDataSuiGuang_C")]
public class LogicDataSuiGuang : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170022A5 RID: 8869
	// (get) Token: 0x06016524 RID: 91428 RVA: 0x0067FE80 File Offset: 0x0067E080
	// (set) Token: 0x06016525 RID: 91429 RVA: 0x0067FE90 File Offset: 0x0067E090
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

	// Token: 0x170022A6 RID: 8870
	// (get) Token: 0x06016526 RID: 91430 RVA: 0x0067FEA1 File Offset: 0x0067E0A1
	// (set) Token: 0x06016527 RID: 91431 RVA: 0x0067FEB5 File Offset: 0x0067E0B5
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

	// Token: 0x170022A7 RID: 8871
	// (get) Token: 0x06016528 RID: 91432 RVA: 0x0067FECA File Offset: 0x0067E0CA
	// (set) Token: 0x06016529 RID: 91433 RVA: 0x0067FEDE File Offset: 0x0067E0DE
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

	// Token: 0x0601652A RID: 91434 RVA: 0x0067FEF3 File Offset: 0x0067E0F3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSuiGuang._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSuiGuang.LogicDataSuiGuang_C");
		}
		return LogicDataSuiGuang._ClassPtr;
	}

	// Token: 0x0601652B RID: 91435 RVA: 0x0067FF18 File Offset: 0x0067E118
	public LogicDataSuiGuang() : this(BuiltinUtils.AllocNativeUObject(LogicDataSuiGuang.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601652C RID: 91436 RVA: 0x0067FF40 File Offset: 0x0067E140
	public LogicDataSuiGuang(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSuiGuang.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601652D RID: 91437 RVA: 0x0067FF73 File Offset: 0x0067E173
	protected LogicDataSuiGuang(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC87 RID: 48263
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSuiGuang.LogicDataSuiGuang_C";

	// Token: 0x0400BC88 RID: 48264
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC89 RID: 48265
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC8A RID: 48266
	private static int __PropertyOffset_IncludeBullet;

	// Token: 0x0400BC8B RID: 48267
	private static int __PropertyOffset_NeedTag;

	// Token: 0x0400BC8C RID: 48268
	private static int __PropertyOffset_NewBulletId;
}
