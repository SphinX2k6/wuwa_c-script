using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FE3 RID: 4067
public class FloroRanchEntityCreateSystem
{
	// Token: 0x0600A24D RID: 41549 RVA: 0x002FA7D4 File Offset: 0x002F89D4
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
