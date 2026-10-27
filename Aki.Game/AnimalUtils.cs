using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x02002E20 RID: 11808
public class AnimalUtils
{
	// Token: 0x06018DEC RID: 101868 RVA: 0x00667CE6 File Offset: 0x00665EE6
	[NullableContext(1)]
	[return: Nullable(2)]
	public static AnimalComponent GetAnimalComponentConfig(CreatureDataComponent creatureDataComponent)
	{
		return TdUtils.GetComponent<AnimalComponent>(creatureDataComponent.GetPbEntityInitData().ComponentsData, EConfigComponent.AnimalComponent);
	}
}
