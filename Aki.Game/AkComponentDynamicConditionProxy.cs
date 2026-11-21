using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200256D RID: 9581
[NullableContext(1)]
[Nullable(0)]
public class AkComponentDynamicConditionProxy : IDynamicConditionSwitch
{
	// Token: 0x06017A8E RID: 96910 RVA: 0x006FE388 File Offset: 0x006FC588
	public void Init(CharacterActorComponent actor, EntityAudioConfig config)
	{
		this.Clear();
		if (config.BoneHiddenSwitchLength > 0)
		{
			BoneHiddenSwitch boneHiddenSwitch = new BoneHiddenSwitch();
			boneHiddenSwitch.Init(actor, config);
			this.Conditions.Add(boneHiddenSwitch);
		}
	}

	// Token: 0x06017A8F RID: 96911 RVA: 0x006FE3C0 File Offset: 0x006FC5C0
	public void Do(CharacterActorComponent actor)
	{
		foreach (IDynamicConditionSwitch dynamicConditionSwitch in this.Conditions)
		{
			dynamicConditionSwitch.Do(actor);
		}
	}

	// Token: 0x06017A90 RID: 96912 RVA: 0x006FE414 File Offset: 0x006FC614
	public void Clear()
	{
		foreach (IDynamicConditionSwitch dynamicConditionSwitch in this.Conditions)
		{
			dynamicConditionSwitch.Clear();
		}
		this.Conditions.Clear();
	}

	// Token: 0x0400C986 RID: 51590
	private readonly List<IDynamicConditionSwitch> Conditions = new List<IDynamicConditionSwitch>();
}
