using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.TypeScript.Game.NewWorld.Bullet.LogicDataClass;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200234D RID: 9037
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBase.LogicDataBase_C")]
public class LogicDataBase : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700222A RID: 8746
	// (get) Token: 0x060163E2 RID: 91106 RVA: 0x0067DCD0 File Offset: 0x0067BED0
	// (set) Token: 0x060163E3 RID: 91107 RVA: 0x0067DCE0 File Offset: 0x0067BEE0
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

	// Token: 0x060163E4 RID: 91108 RVA: 0x0067DCF1 File Offset: 0x0067BEF1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBase.LogicDataBase_C");
		}
		return LogicDataBase._ClassPtr;
	}

	// Token: 0x060163E5 RID: 91109 RVA: 0x0067DD18 File Offset: 0x0067BF18
	public LogicDataBase() : this(BuiltinUtils.AllocNativeUObject(LogicDataBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060163E6 RID: 91110 RVA: 0x0067DD40 File Offset: 0x0067BF40
	[NullableContext(1)]
	public LogicDataBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060163E7 RID: 91111 RVA: 0x0067DD73 File Offset: 0x0067BF73
	protected LogicDataBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBB2 RID: 48050
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBase.LogicDataBase_C";

	// Token: 0x0400BBB3 RID: 48051
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBB4 RID: 48052
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBB5 RID: 48053
	private static int __PropertyOffset_ExecuteStage;
}
