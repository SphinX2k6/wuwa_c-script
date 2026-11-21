using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200256B RID: 9579
[NullableContext(1)]
public interface IDynamicConditionSwitch
{
	// Token: 0x06017A86 RID: 96902
	void Init(CharacterActorComponent actor, EntityAudioConfig config);

	// Token: 0x06017A87 RID: 96903
	void Do(CharacterActorComponent actor);

	// Token: 0x06017A88 RID: 96904
	void Clear();
}
