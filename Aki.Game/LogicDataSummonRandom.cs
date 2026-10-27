using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E05 RID: 11781
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSummonRandom.LogicDataSummonRandom_C")]
public class LogicDataSummonRandom : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002240 RID: 8768
	// (get) Token: 0x06018C6D RID: 101485 RVA: 0x00659DA8 File Offset: 0x00657FA8
	// (set) Token: 0x06018C6E RID: 101486 RVA: 0x00659DB8 File Offset: 0x00657FB8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SummonIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSummonRandom.__PropertyOffset_SummonIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSummonRandom.__PropertyOffset_SummonIndex) = value;
		}
	}

	// Token: 0x17002241 RID: 8769
	// (get) Token: 0x06018C6F RID: 101487 RVA: 0x00659DC9 File Offset: 0x00657FC9
	// (set) Token: 0x06018C70 RID: 101488 RVA: 0x00659DD9 File Offset: 0x00657FD9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSummonRandom.__PropertyOffset_SkillId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSummonRandom.__PropertyOffset_SkillId) = value;
		}
	}

	// Token: 0x17002242 RID: 8770
	// (get) Token: 0x06018C71 RID: 101489 RVA: 0x00659DEA File Offset: 0x00657FEA
	// (set) Token: 0x06018C72 RID: 101490 RVA: 0x00659DFA File Offset: 0x00657FFA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsVisible
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSummonRandom.__PropertyOffset_IsVisible) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSummonRandom.__PropertyOffset_IsVisible) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002243 RID: 8771
	// (get) Token: 0x06018C73 RID: 101491 RVA: 0x00659E0B File Offset: 0x0065800B
	// (set) Token: 0x06018C74 RID: 101492 RVA: 0x00659E1B File Offset: 0x0065801B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DestroySummonOnDestroy
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSummonRandom.__PropertyOffset_DestroySummonOnDestroy) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSummonRandom.__PropertyOffset_DestroySummonOnDestroy) = (value ? 1 : 0);
		}
	}

	// Token: 0x06018C75 RID: 101493 RVA: 0x00659E2C File Offset: 0x0065802C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSummonRandom._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSummonRandom.LogicDataSummonRandom_C");
		}
		return LogicDataSummonRandom._ClassPtr;
	}

	// Token: 0x06018C76 RID: 101494 RVA: 0x00659E50 File Offset: 0x00658050
	public LogicDataSummonRandom() : this(BuiltinUtils.AllocNativeUObject(LogicDataSummonRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C77 RID: 101495 RVA: 0x00659E78 File Offset: 0x00658078
	[NullableContext(1)]
	public LogicDataSummonRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSummonRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C78 RID: 101496 RVA: 0x00659EAB File Offset: 0x006580AB
	protected LogicDataSummonRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B8FF RID: 47359
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSummonRandom.LogicDataSummonRandom_C";

	// Token: 0x0400B900 RID: 47360
	private static IntPtr _ClassPtr;

	// Token: 0x0400B901 RID: 47361
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B902 RID: 47362
	private static int __PropertyOffset_SummonIndex;

	// Token: 0x0400B903 RID: 47363
	private static int __PropertyOffset_SkillId;

	// Token: 0x0400B904 RID: 47364
	private static int __PropertyOffset_IsVisible;

	// Token: 0x0400B905 RID: 47365
	private static int __PropertyOffset_DestroySummonOnDestroy;
}
