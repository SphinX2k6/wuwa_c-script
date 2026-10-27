using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02003015 RID: 12309
[NullableContext(1)]
public interface IDynamicConditionSwitch
{
	// Token: 0x0601A13E RID: 106814
	void Init(CharacterActorComponent actor, EntityAudioConfig config);

	// Token: 0x0601A13F RID: 106815
	void Do(CharacterActorComponent actor);

	// Token: 0x0601A140 RID: 106816
	void Clear();
}
