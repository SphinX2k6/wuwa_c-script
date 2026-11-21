using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AF5 RID: 23285
	[NullableContext(2)]
	[Nullable(0)]
	public class EntityContext : GeneralContext
	{
		// Token: 0x0603946F RID: 234607 RVA: 0x01009EB0 File Offset: 0x010080B0
		public EntityContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Entity);
		}

		// Token: 0x06039470 RID: 234608 RVA: 0x01009ED0 File Offset: 0x010080D0
		public override void Reset()
		{
			this.EntityId = new int?(0);
		}

		// Token: 0x06039471 RID: 234609 RVA: 0x01009EDE File Offset: 0x010080DE
		[NullableContext(1)]
		public static EntityContext Create(int entityId = 0, GameCtxType? subType = null)
		{
			EntityContext entityContext = GeneralContext.GetObj(EGeneralContextType.Entity, subType, () => new EntityContext()) as EntityContext;
			entityContext.EntityId = new int?(entityId);
			return entityContext;
		}

		// Token: 0x06039472 RID: 234610 RVA: 0x01009F17 File Offset: 0x01008117
		public void AddSubParam(int key, int value)
		{
			if (this.SubParamMap == null)
			{
				this.SubParamMap = new Dictionary<int, int>();
			}
			this.SubParamMap[key] = value;
		}

		// Token: 0x06039473 RID: 234611 RVA: 0x01009F3C File Offset: 0x0100813C
		public int? GetSubParam(int key)
		{
			int value;
			if (this.SubParamMap != null && this.SubParamMap.TryGetValue(key, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x0401E28B RID: 123531
		public int? EntityId = new int?(0);

		// Token: 0x0401E28C RID: 123532
		public bool ClientExecuteActions;

		// Token: 0x0401E28D RID: 123533
		public string SequencePath;

		// Token: 0x0401E28E RID: 123534
		private Dictionary<int, int> SubParamMap;
	}
}
