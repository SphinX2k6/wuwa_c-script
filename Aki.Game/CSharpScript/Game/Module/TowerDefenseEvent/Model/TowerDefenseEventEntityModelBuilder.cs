using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003ABD RID: 15037
	public class TowerDefenseEventEntityModelBuilder
	{
		// Token: 0x06026A37 RID: 158263 RVA: 0x00AD2D15 File Offset: 0x00AD0F15
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

		// Token: 0x06026A38 RID: 158264 RVA: 0x00AD2D3F File Offset: 0x00AD0F3F
		public static void Clear()
		{
			TowerDefenseEventSpecialCellModel.Clear();
			TowerDefenseEventTrapModel.Clear();
			TowerDefenseEventMonsterModel.Clear();
			TowerDefenseEventEntityModel.Clear();
		}
	}
}
