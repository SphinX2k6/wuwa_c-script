using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02003017 RID: 12311
[NullableContext(1)]
[Nullable(0)]
public class AkComponentDynamicConditionProxy : IDynamicConditionSwitch
{
	// Token: 0x0601A146 RID: 106822 RVA: 0x006D6480 File Offset: 0x006D4680
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

	// Token: 0x0601A147 RID: 106823 RVA: 0x006D64B8 File Offset: 0x006D46B8
	public void Do(CharacterActorComponent actor)
	{
		foreach (IDynamicConditionSwitch dynamicConditionSwitch in this.Conditions)
		{
			dynamicConditionSwitch.Do(actor);
		}
	}

	// Token: 0x0601A148 RID: 106824 RVA: 0x006D650C File Offset: 0x006D470C
	public void Clear()
	{
		foreach (IDynamicConditionSwitch dynamicConditionSwitch in this.Conditions)
		{
			dynamicConditionSwitch.Clear();
		}
		this.Conditions.Clear();
	}

	// Token: 0x0400C5B9 RID: 50617
	private readonly List<IDynamicConditionSwitch> Conditions = new List<IDynamicConditionSwitch>();
}
