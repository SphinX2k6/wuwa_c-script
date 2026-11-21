using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200235D RID: 9053
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpeedReduce.LogicDataSpeedReduce_C")]
public class LogicDataSpeedReduce : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700228F RID: 8847
	// (get) Token: 0x060164EC RID: 91372 RVA: 0x0067F94C File Offset: 0x0067DB4C
	// (set) Token: 0x060164ED RID: 91373 RVA: 0x0067F95C File Offset: 0x0067DB5C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SpeedDampingRatio
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpeedReduce.__PropertyOffset_SpeedDampingRatio);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpeedReduce.__PropertyOffset_SpeedDampingRatio) = value;
		}
	}

	// Token: 0x17002290 RID: 8848
	// (get) Token: 0x060164EE RID: 91374 RVA: 0x0067F96D File Offset: 0x0067DB6D
	// (set) Token: 0x060164EF RID: 91375 RVA: 0x0067F97D File Offset: 0x0067DB7D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsNotThroughObstacles
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpeedReduce.__PropertyOffset_IsNotThroughObstacles) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpeedReduce.__PropertyOffset_IsNotThroughObstacles) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002291 RID: 8849
	// (get) Token: 0x060164F0 RID: 91376 RVA: 0x0067F98E File Offset: 0x0067DB8E
	// (set) Token: 0x060164F1 RID: 91377 RVA: 0x0067F99E File Offset: 0x0067DB9E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpeedReduce.__PropertyOffset_MinSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpeedReduce.__PropertyOffset_MinSpeed) = value;
		}
	}

	// Token: 0x060164F2 RID: 91378 RVA: 0x0067F9AF File Offset: 0x0067DBAF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSpeedReduce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpeedReduce.LogicDataSpeedReduce_C");
		}
		return LogicDataSpeedReduce._ClassPtr;
	}

	// Token: 0x060164F3 RID: 91379 RVA: 0x0067F9D4 File Offset: 0x0067DBD4
	public LogicDataSpeedReduce() : this(BuiltinUtils.AllocNativeUObject(LogicDataSpeedReduce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060164F4 RID: 91380 RVA: 0x0067F9FC File Offset: 0x0067DBFC
	[NullableContext(1)]
	public LogicDataSpeedReduce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpeedReduce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060164F5 RID: 91381 RVA: 0x0067FA2F File Offset: 0x0067DC2F
	protected LogicDataSpeedReduce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC65 RID: 48229
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpeedReduce.LogicDataSpeedReduce_C";

	// Token: 0x0400BC66 RID: 48230
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC67 RID: 48231
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC68 RID: 48232
	private static int __PropertyOffset_SpeedDampingRatio;

	// Token: 0x0400BC69 RID: 48233
	private static int __PropertyOffset_IsNotThroughObstacles;

	// Token: 0x0400BC6A RID: 48234
	private static int __PropertyOffset_MinSpeed;
}
