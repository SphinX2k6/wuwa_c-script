using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006966 RID: 26982
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityPositionData
	{
		// Token: 0x06043313 RID: 275219 RVA: 0x01062307 File Offset: 0x01060507
		public EntityPositionData(int entityId, PosA pos)
		{
			this.EntityId = entityId;
			this.Pos = pos;
		}

		// Token: 0x1700980A RID: 38922
		// (get) Token: 0x06043314 RID: 275220 RVA: 0x0106231D File Offset: 0x0106051D
		public int EntityId { get; }

		// Token: 0x1700980B RID: 38923
		// (get) Token: 0x06043315 RID: 275221 RVA: 0x01062325 File Offset: 0x01060525
		public PosA Pos { get; }
	}
}
