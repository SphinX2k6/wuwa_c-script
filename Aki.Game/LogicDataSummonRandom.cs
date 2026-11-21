using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002361 RID: 9057
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSummonRandom.LogicDataSummonRandom_C")]
public class LogicDataSummonRandom : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170022A8 RID: 8872
	// (get) Token: 0x0601652E RID: 91438 RVA: 0x0067FF7C File Offset: 0x0067E17C
	// (set) Token: 0x0601652F RID: 91439 RVA: 0x0067FF8C File Offset: 0x0067E18C
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

	// Token: 0x170022A9 RID: 8873
	// (get) Token: 0x06016530 RID: 91440 RVA: 0x0067FF9D File Offset: 0x0067E19D
	// (set) Token: 0x06016531 RID: 91441 RVA: 0x0067FFAD File Offset: 0x0067E1AD
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

	// Token: 0x170022AA RID: 8874
	// (get) Token: 0x06016532 RID: 91442 RVA: 0x0067FFBE File Offset: 0x0067E1BE
	// (set) Token: 0x06016533 RID: 91443 RVA: 0x0067FFCE File Offset: 0x0067E1CE
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

	// Token: 0x170022AB RID: 8875
	// (get) Token: 0x06016534 RID: 91444 RVA: 0x0067FFDF File Offset: 0x0067E1DF
	// (set) Token: 0x06016535 RID: 91445 RVA: 0x0067FFEF File Offset: 0x0067E1EF
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

	// Token: 0x06016536 RID: 91446 RVA: 0x00680000 File Offset: 0x0067E200
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSummonRandom._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSummonRandom.LogicDataSummonRandom_C");
		}
		return LogicDataSummonRandom._ClassPtr;
	}

	// Token: 0x06016537 RID: 91447 RVA: 0x00680024 File Offset: 0x0067E224
	public LogicDataSummonRandom() : this(BuiltinUtils.AllocNativeUObject(LogicDataSummonRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016538 RID: 91448 RVA: 0x0068004C File Offset: 0x0067E24C
	[NullableContext(1)]
	public LogicDataSummonRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSummonRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016539 RID: 91449 RVA: 0x0068007F File Offset: 0x0067E27F
	protected LogicDataSummonRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC8D RID: 48269
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSummonRandom.LogicDataSummonRandom_C";

	// Token: 0x0400BC8E RID: 48270
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC8F RID: 48271
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC90 RID: 48272
	private static int __PropertyOffset_SummonIndex;

	// Token: 0x0400BC91 RID: 48273
	private static int __PropertyOffset_SkillId;

	// Token: 0x0400BC92 RID: 48274
	private static int __PropertyOffset_IsVisible;

	// Token: 0x0400BC93 RID: 48275
	private static int __PropertyOffset_DestroySummonOnDestroy;
}
