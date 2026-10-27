using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B24 RID: 6948
public class FloroRanchEntityCreateSystem
{
	// Token: 0x0600CE3C RID: 52796 RVA: 0x002EF6F4 File Offset: 0x002ED8F4
	[NullableContext(1)]
	public static FloroRanchEntityBase CreateFloroRanchEntity(FloroRanchPlayUnit entityData)
	{
		FloroRanchEntityCreateData floroRanchEntityComponentDefine = FloroRanchEntityDefine.GetFloroRanchEntityComponentDefine((EFloroRanchEntityType)entityData.Type);
		FloroRanchEntityBase floroRanchEntityBase = new FloroRanchEntityBase(entityData);
		foreach (ValueTuple<Type, Func<FloroRanchEntityComponentBase>> valueTuple in floroRanchEntityComponentDefine.Components)
		{
			floroRanchEntityBase.AddComponent(valueTuple.Item1, valueTuple.Item2);
		}
		floroRanchEntityBase.Init();
		floroRanchEntityBase.RefreshEntityData(entityData);
		return floroRanchEntityBase;
	}
}
