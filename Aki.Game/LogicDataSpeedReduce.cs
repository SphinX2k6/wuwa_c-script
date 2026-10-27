using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E02 RID: 11778
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpeedReduce.LogicDataSpeedReduce_C")]
public class LogicDataSpeedReduce : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700222B RID: 8747
	// (get) Token: 0x06018C37 RID: 101431 RVA: 0x006598C8 File Offset: 0x00657AC8
	// (set) Token: 0x06018C38 RID: 101432 RVA: 0x006598D8 File Offset: 0x00657AD8
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

	// Token: 0x1700222C RID: 8748
	// (get) Token: 0x06018C39 RID: 101433 RVA: 0x006598E9 File Offset: 0x00657AE9
	// (set) Token: 0x06018C3A RID: 101434 RVA: 0x006598F9 File Offset: 0x00657AF9
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

	// Token: 0x1700222D RID: 8749
	// (get) Token: 0x06018C3B RID: 101435 RVA: 0x0065990A File Offset: 0x00657B0A
	// (set) Token: 0x06018C3C RID: 101436 RVA: 0x0065991A File Offset: 0x00657B1A
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

	// Token: 0x06018C3D RID: 101437 RVA: 0x0065992B File Offset: 0x00657B2B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSpeedReduce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpeedReduce.LogicDataSpeedReduce_C");
		}
		return LogicDataSpeedReduce._ClassPtr;
	}

	// Token: 0x06018C3E RID: 101438 RVA: 0x00659950 File Offset: 0x00657B50
	public LogicDataSpeedReduce() : this(BuiltinUtils.AllocNativeUObject(LogicDataSpeedReduce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C3F RID: 101439 RVA: 0x00659978 File Offset: 0x00657B78
	[NullableContext(1)]
	public LogicDataSpeedReduce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpeedReduce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C40 RID: 101440 RVA: 0x006599AB File Offset: 0x00657BAB
	protected LogicDataSpeedReduce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B8DF RID: 47327
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpeedReduce.LogicDataSpeedReduce_C";

	// Token: 0x0400B8E0 RID: 47328
	private static IntPtr _ClassPtr;

	// Token: 0x0400B8E1 RID: 47329
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B8E2 RID: 47330
	private static int __PropertyOffset_SpeedDampingRatio;

	// Token: 0x0400B8E3 RID: 47331
	private static int __PropertyOffset_IsNotThroughObstacles;

	// Token: 0x0400B8E4 RID: 47332
	private static int __PropertyOffset_MinSpeed;
}
