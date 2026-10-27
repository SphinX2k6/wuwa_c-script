using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200315D RID: 12637
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerBase.SkillTriggerBase_C")]
public class SkillTriggerBase : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x170025B0 RID: 9648
	// (get) Token: 0x0601B310 RID: 111376 RVA: 0x007685CC File Offset: 0x007667CC
	// (set) Token: 0x0601B311 RID: 111377 RVA: 0x00768605 File Offset: 0x00766805
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

	// Token: 0x170025B1 RID: 9649
	// (get) Token: 0x0601B312 RID: 111378 RVA: 0x00768613 File Offset: 0x00766813
	// (set) Token: 0x0601B313 RID: 111379 RVA: 0x00768627 File Offset: 0x00766827
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

	// Token: 0x0601B314 RID: 111380 RVA: 0x0076863C File Offset: 0x0076683C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SkillTriggerBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerBase.SkillTriggerBase_C");
		}
		return SkillTriggerBase._ClassPtr;
	}

	// Token: 0x0601B315 RID: 111381 RVA: 0x00768660 File Offset: 0x00766860
	public SkillTriggerBase() : this(BuiltinUtils.AllocNativeUObject(SkillTriggerBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B316 RID: 111382 RVA: 0x00768688 File Offset: 0x00766888
	public SkillTriggerBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B317 RID: 111383 RVA: 0x007686BB File Offset: 0x007668BB
	protected SkillTriggerBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400D3A4 RID: 54180
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerBase.SkillTriggerBase_C";

	// Token: 0x0400D3A5 RID: 54181
	private static IntPtr _ClassPtr;

	// Token: 0x0400D3A6 RID: 54182
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400D3A7 RID: 54183
	private static int __PropertyOffset_TriggerConditionGroup;

	// Token: 0x0400D3A8 RID: 54184
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehaviorCondition> _TriggerConditionGroup;

	// Token: 0x0400D3A9 RID: 54185
	private static int __PropertyOffset_TriggerConditionFormula;
}
