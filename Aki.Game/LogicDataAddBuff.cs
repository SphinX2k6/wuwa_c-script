using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200234B RID: 9035
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAddBuff.LogicDataAddBuff_C")]
public class LogicDataAddBuff : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002227 RID: 8743
	// (get) Token: 0x060163D4 RID: 91092 RVA: 0x0067DB48 File Offset: 0x0067BD48
	// (set) Token: 0x060163D5 RID: 91093 RVA: 0x0067DB58 File Offset: 0x0067BD58
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long BuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataAddBuff.__PropertyOffset_BuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataAddBuff.__PropertyOffset_BuffId) = value;
		}
	}

	// Token: 0x060163D6 RID: 91094 RVA: 0x0067DB69 File Offset: 0x0067BD69
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataAddBuff._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAddBuff.LogicDataAddBuff_C");
		}
		return LogicDataAddBuff._ClassPtr;
	}

	// Token: 0x060163D7 RID: 91095 RVA: 0x0067DB90 File Offset: 0x0067BD90
	public LogicDataAddBuff() : this(BuiltinUtils.AllocNativeUObject(LogicDataAddBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060163D8 RID: 91096 RVA: 0x0067DBB8 File Offset: 0x0067BDB8
	[NullableContext(1)]
	public LogicDataAddBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060163D9 RID: 91097 RVA: 0x0067DBEB File Offset: 0x0067BDEB
	protected LogicDataAddBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBA9 RID: 48041
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAddBuff.LogicDataAddBuff_C";

	// Token: 0x0400BBAA RID: 48042
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBAB RID: 48043
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBAC RID: 48044
	private static int __PropertyOffset_BuffId;
}
