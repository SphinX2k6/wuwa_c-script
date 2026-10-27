using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000E84 RID: 3716
[UClass("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscSkillData.KscSkillData_C")]
public class KscSkillData : KscBpDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x06005AC7 RID: 23239 RVA: 0x00108AD8 File Offset: 0x00106CD8
	// (set) Token: 0x06005AC8 RID: 23240 RVA: 0x00108AE8 File Offset: 0x00106CE8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)KscSkillData.__PropertyOffset_SkillIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)KscSkillData.__PropertyOffset_SkillIndex) = value;
		}
	}

	// Token: 0x06005AC9 RID: 23241 RVA: 0x00108AF9 File Offset: 0x00106CF9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (KscSkillData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscSkillData.KscSkillData_C");
		}
		return KscSkillData._ClassPtr;
	}

	// Token: 0x06005ACA RID: 23242 RVA: 0x00108B20 File Offset: 0x00106D20
	public KscSkillData() : this(BuiltinUtils.AllocNativeUObject(KscSkillData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005ACB RID: 23243 RVA: 0x00108B48 File Offset: 0x00106D48
	[NullableContext(1)]
	public KscSkillData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscSkillData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005ACC RID: 23244 RVA: 0x00108B7B File Offset: 0x00106D7B
	protected KscSkillData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400297D RID: 10621
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscSkillData.KscSkillData_C";

	// Token: 0x0400297E RID: 10622
	private static IntPtr _ClassPtr;

	// Token: 0x0400297F RID: 10623
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002980 RID: 10624
	private static int __PropertyOffset_SkillIndex;
}
