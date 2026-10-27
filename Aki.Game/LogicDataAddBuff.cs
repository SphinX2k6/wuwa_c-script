using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF0 RID: 11760
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAddBuff.LogicDataAddBuff_C")]
public class LogicDataAddBuff : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021C3 RID: 8643
	// (get) Token: 0x06018B1F RID: 101151 RVA: 0x00657AC4 File Offset: 0x00655CC4
	// (set) Token: 0x06018B20 RID: 101152 RVA: 0x00657AD4 File Offset: 0x00655CD4
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

	// Token: 0x06018B21 RID: 101153 RVA: 0x00657AE5 File Offset: 0x00655CE5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataAddBuff._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAddBuff.LogicDataAddBuff_C");
		}
		return LogicDataAddBuff._ClassPtr;
	}

	// Token: 0x06018B22 RID: 101154 RVA: 0x00657B0C File Offset: 0x00655D0C
	public LogicDataAddBuff() : this(BuiltinUtils.AllocNativeUObject(LogicDataAddBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B23 RID: 101155 RVA: 0x00657B34 File Offset: 0x00655D34
	[NullableContext(1)]
	public LogicDataAddBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B24 RID: 101156 RVA: 0x00657B67 File Offset: 0x00655D67
	protected LogicDataAddBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B823 RID: 47139
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAddBuff.LogicDataAddBuff_C";

	// Token: 0x0400B824 RID: 47140
	private static IntPtr _ClassPtr;

	// Token: 0x0400B825 RID: 47141
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B826 RID: 47142
	private static int __PropertyOffset_BuffId;
}
