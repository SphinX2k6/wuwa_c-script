using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200315F RID: 12639
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerGameplayTag.SkillTriggerGameplayTag_C")]
public class SkillTriggerGameplayTag : SkillTriggerBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170025B2 RID: 9650
	// (get) Token: 0x0601B31D RID: 111389 RVA: 0x00768704 File Offset: 0x00766904
	// (set) Token: 0x0601B31E RID: 111390 RVA: 0x0076873D File Offset: 0x0076693D
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

	// Token: 0x0601B31F RID: 111391 RVA: 0x00768765 File Offset: 0x00766965
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SkillTriggerGameplayTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerGameplayTag.SkillTriggerGameplayTag_C");
		}
		return SkillTriggerGameplayTag._ClassPtr;
	}

	// Token: 0x0601B320 RID: 111392 RVA: 0x0076878C File Offset: 0x0076698C
	public SkillTriggerGameplayTag() : this(BuiltinUtils.AllocNativeUObject(SkillTriggerGameplayTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B321 RID: 111393 RVA: 0x007687B4 File Offset: 0x007669B4
	public SkillTriggerGameplayTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SkillTriggerGameplayTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B322 RID: 111394 RVA: 0x007687E7 File Offset: 0x007669E7
	protected SkillTriggerGameplayTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400D3AB RID: 54187
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Component/Skill/SkillTrigger/SkillTriggerGameplayTag.SkillTriggerGameplayTag_C";

	// Token: 0x0400D3AC RID: 54188
	private static IntPtr _ClassPtr;

	// Token: 0x0400D3AD RID: 54189
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400D3AE RID: 54190
	private static int __PropertyOffset_TriggerData;

	// Token: 0x0400D3AF RID: 54191
	[Nullable(2)]
	private FAbilityTriggerData _TriggerData;
}
