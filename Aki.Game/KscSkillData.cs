using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000339 RID: 825
[UClass("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscSkillData.KscSkillData_C")]
public class KscSkillData : KscBpDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170006CA RID: 1738
	// (get) Token: 0x06002E5E RID: 11870 RVA: 0x00110788 File Offset: 0x0010E988
	// (set) Token: 0x06002E5F RID: 11871 RVA: 0x00110798 File Offset: 0x0010E998
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

	// Token: 0x06002E60 RID: 11872 RVA: 0x001107A9 File Offset: 0x0010E9A9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (KscSkillData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscSkillData.KscSkillData_C");
		}
		return KscSkillData._ClassPtr;
	}

	// Token: 0x06002E61 RID: 11873 RVA: 0x001107D0 File Offset: 0x0010E9D0
	public KscSkillData() : this(BuiltinUtils.AllocNativeUObject(KscSkillData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002E62 RID: 11874 RVA: 0x001107F8 File Offset: 0x0010E9F8
	[NullableContext(1)]
	public KscSkillData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscSkillData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002E63 RID: 11875 RVA: 0x0011082B File Offset: 0x0010EA2B
	protected KscSkillData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x04002A18 RID: 10776
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscSkillData.KscSkillData_C";

	// Token: 0x04002A19 RID: 10777
	private static IntPtr _ClassPtr;

	// Token: 0x04002A1A RID: 10778
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002A1B RID: 10779
	private static int __PropertyOffset_SkillIndex;
}
