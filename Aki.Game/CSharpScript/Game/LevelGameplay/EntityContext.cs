using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006999 RID: 27033
	[NullableContext(2)]
	[Nullable(0)]
	public class EntityContext : GeneralContext
	{
		// Token: 0x06043437 RID: 275511 RVA: 0x01065C48 File Offset: 0x01063E48
		public EntityContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Entity);
		}

		// Token: 0x06043438 RID: 275512 RVA: 0x01065C68 File Offset: 0x01063E68
		public override void Reset()
		{
			this.EntityId = new int?(0);
		}

		// Token: 0x06043439 RID: 275513 RVA: 0x01065C76 File Offset: 0x01063E76
		[NullableContext(1)]
		public static EntityContext Create(int entityId = 0, GameCtxType? subType = null)
		{
			EntityContext entityContext = GeneralContext.GetObj(EGeneralContextType.Entity, subType, () => new EntityContext()) as EntityContext;
			entityContext.EntityId = new int?(entityId);
			return entityContext;
		}

		// Token: 0x0604343A RID: 275514 RVA: 0x01065CAF File Offset: 0x01063EAF
		public void AddSubParam(int key, int value)
		{
			if (this.SubParamMap == null)
			{
				this.SubParamMap = new Dictionary<int, int>();
			}
			this.SubParamMap[key] = value;
		}

		// Token: 0x0604343B RID: 275515 RVA: 0x01065CD4 File Offset: 0x01063ED4
		public int? GetSubParam(int key)
		{
			int value;
			if (this.SubParamMap != null && this.SubParamMap.TryGetValue(key, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x040230A1 RID: 143521
		public int? EntityId = new int?(0);

		// Token: 0x040230A2 RID: 143522
		public bool ClientExecuteActions;

		// Token: 0x040230A3 RID: 143523
		public string SequencePath;

		// Token: 0x040230A4 RID: 143524
		private Dictionary<int, int> SubParamMap;
	}
}
