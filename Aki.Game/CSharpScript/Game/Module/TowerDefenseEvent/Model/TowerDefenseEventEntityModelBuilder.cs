using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B15 RID: 19221
	public class TowerDefenseEventEntityModelBuilder
	{
		// Token: 0x06031CA7 RID: 203943 RVA: 0x00B8ECA9 File Offset: 0x00B8CEA9
		[NullableContext(1)]
		[return: Nullable(2)]
		public static ITowerDefenseEventCombatInfo Get(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			ITowerDefenseEventCombatInfo result;
			if ((result = TowerDefenseEventSpecialCellModel.BuildModel(entityData, componentDataMap)) == null && (result = TowerDefenseEventTrapModel.BuildModel(entityData, componentDataMap)) == null)
			{
				result = (TowerDefenseEventMonsterModel.BuildModel(entityData, componentDataMap) ?? TowerDefenseEventEntityModel.BuildModel(entityData, componentDataMap));
			}
			return result;
		}

		// Token: 0x06031CA8 RID: 203944 RVA: 0x00B8ECD3 File Offset: 0x00B8CED3
		public static void Clear()
		{
			TowerDefenseEventSpecialCellModel.Clear();
			TowerDefenseEventTrapModel.Clear();
			TowerDefenseEventMonsterModel.Clear();
			TowerDefenseEventEntityModel.Clear();
		}
	}
}
