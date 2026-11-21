using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020026CC RID: 9932
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerGameplayTag.SkillTriggerGameplayTag_C")]
public class SkillTriggerGameplayTag : SkillTriggerBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027A3 RID: 10147
	// (get) Token: 0x06018E22 RID: 101922 RVA: 0x007900D0 File Offset: 0x0078E2D0
	// (set) Token: 0x06018E23 RID: 101923 RVA: 0x00790109 File Offset: 0x0078E309
	[UProperty(EPropertyFlags.CPF_None)]
	public FAbilityTriggerData TriggerData
	{
		get
		{
			base.FastCheckIsValid();
			FAbilityTriggerData result;
			if ((result = this._TriggerData) == null)
			{
				result = (this._TriggerData = new FAbilityTriggerData(base.NativePtr + (IntPtr)SkillTriggerGameplayTag.__PropertyOffset_TriggerData, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FAbilityTriggerData.StaticStruct(), base.NativePtr + (IntPtr)SkillTriggerGameplayTag.__PropertyOffset_TriggerData, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06018E24 RID: 101924 RVA: 0x00790131 File Offset: 0x0078E331
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SkillTriggerGameplayTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerGameplayTag.SkillTriggerGameplayTag_C");
		}
		return SkillTriggerGameplayTag._ClassPtr;
	}

	// Token: 0x06018E25 RID: 101925 RVA: 0x00790158 File Offset: 0x0078E358
	public SkillTriggerGameplayTag() : this(BuiltinUtils.AllocNativeUObject(SkillTriggerGameplayTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018E26 RID: 101926 RVA: 0x00790180 File Offset: 0x0078E380
	public SkillTriggerGameplayTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerGameplayTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018E27 RID: 101927 RVA: 0x007901B3 File Offset: 0x0078E3B3
	protected SkillTriggerGameplayTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400D80E RID: 55310
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerGameplayTag.SkillTriggerGameplayTag_C";

	// Token: 0x0400D80F RID: 55311
	private static IntPtr _ClassPtr;

	// Token: 0x0400D810 RID: 55312
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400D811 RID: 55313
	private static int __PropertyOffset_TriggerData;

	// Token: 0x0400D812 RID: 55314
	[Nullable(2)]
	private FAbilityTriggerData _TriggerData;
}
