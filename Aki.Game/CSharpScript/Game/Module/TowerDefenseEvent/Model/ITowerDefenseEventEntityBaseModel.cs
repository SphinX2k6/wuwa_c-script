using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003AAC RID: 15020
	[NullableContext(1)]
	public interface ITowerDefenseEventEntityBaseModel
	{
		// Token: 0x06026974 RID: 158068
		[return: Nullable(2)]
		public abstract static ITowerDefenseEventCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap);

		// Token: 0x06026975 RID: 158069
		public abstract static void Clear();
	}
}
