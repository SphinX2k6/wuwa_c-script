using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.TypeScript.Game.NewWorld.Bullet.LogicDataClass;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF2 RID: 11762
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBase.LogicDataBase_C")]
public class LogicDataBase : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021C6 RID: 8646
	// (get) Token: 0x06018B2D RID: 101165 RVA: 0x00657C4C File Offset: 0x00655E4C
	// (set) Token: 0x06018B2E RID: 101166 RVA: 0x00657C5C File Offset: 0x00655E5C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletLogicStage ExecuteStage
	{
		get
		{
			return (EBulletLogicStage)(*(base.NativePtr + (IntPtr)LogicDataBase.__PropertyOffset_ExecuteStage));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataBase.__PropertyOffset_ExecuteStage) = (byte)value;
		}
	}

	// Token: 0x06018B2F RID: 101167 RVA: 0x00657C6D File Offset: 0x00655E6D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBase.LogicDataBase_C");
		}
		return LogicDataBase._ClassPtr;
	}

	// Token: 0x06018B30 RID: 101168 RVA: 0x00657C94 File Offset: 0x00655E94
	public LogicDataBase() : this(BuiltinUtils.AllocNativeUObject(LogicDataBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B31 RID: 101169 RVA: 0x00657CBC File Offset: 0x00655EBC
	[NullableContext(1)]
	public LogicDataBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B32 RID: 101170 RVA: 0x00657CEF File Offset: 0x00655EEF
	protected LogicDataBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B82C RID: 47148
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBase.LogicDataBase_C";

	// Token: 0x0400B82D RID: 47149
	private static IntPtr _ClassPtr;

	// Token: 0x0400B82E RID: 47150
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B82F RID: 47151
	private static int __PropertyOffset_ExecuteStage;
}
