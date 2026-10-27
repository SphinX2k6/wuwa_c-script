using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B04 RID: 19204
	[NullableContext(1)]
	public interface ITowerDefenseEventEntityBaseModel
	{
		// Token: 0x06031BE4 RID: 203748
		[return: Nullable(2)]
		public abstract static ITowerDefenseEventCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap);

		// Token: 0x06031BE5 RID: 203749
		public abstract static void Clear();
	}
}
