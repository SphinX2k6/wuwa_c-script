using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x0200237C RID: 9084
public class AnimalUtils
{
	// Token: 0x060166AE RID: 91822 RVA: 0x0068DCAE File Offset: 0x0068BEAE
	[NullableContext(1)]
	[return: Nullable(2)]
	public static AnimalComponent GetAnimalComponentConfig(CreatureDataComponent creatureDataComponent)
	{
		return TdUtils.GetComponent<AnimalComponent>(creatureDataComponent.GetPbEntityInitData().ComponentsData, EConfigComponent.AnimalComponent);
	}
}
