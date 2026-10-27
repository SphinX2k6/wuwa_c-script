using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001B29 RID: 6953
public class FloroRanchEntityDefine : IStaticVariableResetter
{
	// Token: 0x0600CE42 RID: 52802 RVA: 0x002EF81E File Offset: 0x002EDA1E
	static FloroRanchEntityDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchEntityDefine.CreateStaticDefaultValue), new Action(FloroRanchEntityDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600CE43 RID: 52803 RVA: 0x002EF83D File Offset: 0x002EDA3D
	public static void CreateStaticDefaultValue()
	{
		FloroRanchEntityDefine.floroRanchEntityComponentDefine = null;
	}

	// Token: 0x0600CE44 RID: 52804 RVA: 0x002EF845 File Offset: 0x002EDA45
	public static void ResetStaticDefaultValue()
	{
		FloroRanchEntityDefine.floroRanchEntityComponentDefine = null;
	}

	// Token: 0x0600CE45 RID: 52805 RVA: 0x002EF850 File Offset: 0x002EDA50
	[NullableContext(1)]
	public unsafe static FloroRanchEntityCreateData GetFloroRanchEntityComponentDefine(EFloroRanchEntityType entityType)
	{
		if (FloroRanchEntityDefine.floroRanchEntityComponentDefine == null)
		{
			Dictionary<EFloroRanchEntityType, FloroRanchEntityCreateData> dictionary = new Dictionary<EFloroRanchEntityType, FloroRanchEntityCreateData>();
			EFloroRanchEntityType key = EFloroRanchEntityType.Card;
			EFloroRanchEntityType entityType2 = EFloroRanchEntityType.Card;
			int num = 5;
			List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>> list = new List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(num);
			CollectionsMarshal.SetCount<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list, num);
			Span<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>> span = CollectionsMarshal.AsSpan<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchEntityDataComponent), () => new FloroRanchEntityDataComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchCardDataComponent), () => new FloroRanchCardDataComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchMoveComponent), () => new FloroRanchMoveComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchUiPopupRewardComponent), () => new FloroRanchUiPopupRewardComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchUiCardComponent), () => new FloroRanchUiCardComponent());
			dictionary.Add(key, new FloroRanchEntityCreateData(entityType2, list));
			EFloroRanchEntityType key2 = EFloroRanchEntityType.Terrain;
			EFloroRanchEntityType entityType3 = EFloroRanchEntityType.Terrain;
			num2 = 4;
			List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>> list2 = new List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list2, num2);
			span = CollectionsMarshal.AsSpan<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list2);
			num = 0;
			*span[num] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchEntityDataComponent), () => new FloroRanchEntityDataComponent());
			num++;
			*span[num] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchTerrainDataComponent), () => new FloroRanchTerrainDataComponent());
			num++;
			*span[num] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchUiPopupRewardComponent), () => new FloroRanchUiPopupRewardComponent());
			num++;
			*span[num] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchUiTerrainComponent), () => new FloroRanchUiTerrainComponent());
			dictionary.Add(key2, new FloroRanchEntityCreateData(entityType3, list2));
			EFloroRanchEntityType key3 = EFloroRanchEntityType.Toy;
			EFloroRanchEntityType entityType4 = EFloroRanchEntityType.Toy;
			num = 4;
			List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>> list3 = new List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(num);
			CollectionsMarshal.SetCount<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list3, num);
			span = CollectionsMarshal.AsSpan<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list3);
			num2 = 0;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchEntityDataComponent), () => new FloroRanchEntityDataComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchToyDataComponent), () => new FloroRanchToyDataComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchUiPopupRewardComponent), () => new FloroRanchUiPopupRewardComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchUiToyComponent), () => new FloroRanchUiToyComponent());
			dictionary.Add(key3, new FloroRanchEntityCreateData(entityType4, list3));
			EFloroRanchEntityType key4 = EFloroRanchEntityType.Dungeon;
			EFloroRanchEntityType entityType5 = EFloroRanchEntityType.Dungeon;
			num2 = 2;
			List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>> list4 = new List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list4, num2);
			span = CollectionsMarshal.AsSpan<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list4);
			num = 0;
			*span[num] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchEntityDataComponent), () => new FloroRanchEntityDataComponent());
			num++;
			*span[num] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchEmptyUiComponent), () => new FloroRanchEmptyUiComponent());
			dictionary.Add(key4, new FloroRanchEntityCreateData(entityType5, list4));
			EFloroRanchEntityType key5 = EFloroRanchEntityType.Role;
			EFloroRanchEntityType entityType6 = EFloroRanchEntityType.Role;
			num = 4;
			List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>> list5 = new List<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(num);
			CollectionsMarshal.SetCount<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list5, num);
			span = CollectionsMarshal.AsSpan<ValueTuple<Type, Func<FloroRanchEntityComponentBase>>>(list5);
			num2 = 0;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchEntityDataComponent), () => new FloroRanchEntityDataComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchRoleSkillDataComponent), () => new FloroRanchRoleSkillDataComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchUiRoleSkillComponent), () => new FloroRanchUiRoleSkillComponent());
			num2++;
			*span[num2] = new ValueTuple<Type, Func<FloroRanchEntityComponentBase>>(typeof(FloroRanchUiPopupRewardComponent), () => new FloroRanchUiPopupRewardComponent());
			dictionary.Add(key5, new FloroRanchEntityCreateData(entityType6, list5));
			FloroRanchEntityDefine.floroRanchEntityComponentDefine = dictionary;
		}
		return FloroRanchEntityDefine.floroRanchEntityComponentDefine[entityType];
	}

	// Token: 0x04005E90 RID: 24208
	[Nullable(1)]
	private static Dictionary<EFloroRanchEntityType, FloroRanchEntityCreateData> floroRanchEntityComponentDefine;
}
