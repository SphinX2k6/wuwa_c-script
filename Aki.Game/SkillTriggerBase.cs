using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020026CA RID: 9930
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerBase.SkillTriggerBase_C")]
public class SkillTriggerBase : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027A1 RID: 10145
	// (get) Token: 0x06018E15 RID: 101909 RVA: 0x0078FF98 File Offset: 0x0078E198
	// (set) Token: 0x06018E16 RID: 101910 RVA: 0x0078FFD1 File Offset: 0x0078E1D1
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SSkillBehaviorCondition> TriggerConditionGroup
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SSkillBehaviorCondition> result;
			if ((result = this._TriggerConditionGroup) == null)
			{
				result = (this._TriggerConditionGroup = new TArray<SSkillBehaviorCondition>(base.NativePtr + (IntPtr)SkillTriggerBase.__PropertyOffset_TriggerConditionGroup, this));
			}
			return result;
		}
		set
		{
			this.TriggerConditionGroup.CopyAssign(value);
		}
	}

	// Token: 0x170027A2 RID: 10146
	// (get) Token: 0x06018E17 RID: 101911 RVA: 0x0078FFDF File Offset: 0x0078E1DF
	// (set) Token: 0x06018E18 RID: 101912 RVA: 0x0078FFF3 File Offset: 0x0078E1F3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TriggerConditionFormula
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SkillTriggerBase.__PropertyOffset_TriggerConditionFormula)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SkillTriggerBase.__PropertyOffset_TriggerConditionFormula)), value);
		}
	}

	// Token: 0x06018E19 RID: 101913 RVA: 0x00790008 File Offset: 0x0078E208
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SkillTriggerBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerBase.SkillTriggerBase_C");
		}
		return SkillTriggerBase._ClassPtr;
	}

	// Token: 0x06018E1A RID: 101914 RVA: 0x0079002C File Offset: 0x0078E22C
	public SkillTriggerBase() : this(BuiltinUtils.AllocNativeUObject(SkillTriggerBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018E1B RID: 101915 RVA: 0x00790054 File Offset: 0x0078E254
	public SkillTriggerBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018E1C RID: 101916 RVA: 0x00790087 File Offset: 0x0078E287
	protected SkillTriggerBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400D807 RID: 55303
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerBase.SkillTriggerBase_C";

	// Token: 0x0400D808 RID: 55304
	private static IntPtr _ClassPtr;

	// Token: 0x0400D809 RID: 55305
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400D80A RID: 55306
	private static int __PropertyOffset_TriggerConditionGroup;

	// Token: 0x0400D80B RID: 55307
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehaviorCondition> _TriggerConditionGroup;

	// Token: 0x0400D80C RID: 55308
	private static int __PropertyOffset_TriggerConditionFormula;
}
