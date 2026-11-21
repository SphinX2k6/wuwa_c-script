using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AC2 RID: 23234
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityPositionData
	{
		// Token: 0x0603934B RID: 234315 RVA: 0x0100656F File Offset: 0x0100476F
		public EntityPositionData(int entityId, PosA pos)
		{
			this.EntityId = entityId;
			this.Pos = pos;
		}

		// Token: 0x17006CEA RID: 27882
		// (get) Token: 0x0603934C RID: 234316 RVA: 0x01006585 File Offset: 0x01004785
		public int EntityId { get; }

		// Token: 0x17006CEB RID: 27883
		// (get) Token: 0x0603934D RID: 234317 RVA: 0x0100658D File Offset: 0x0100478D
		public PosA Pos { get; }
	}
}
