using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AF6 RID: 23286
	public class DynamicInteractContext : GeneralContext
	{
		// Token: 0x06039474 RID: 234612 RVA: 0x01009F71 File Offset: 0x01008171
		public DynamicInteractContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.DynamicInteract);
		}

		// Token: 0x06039475 RID: 234613 RVA: 0x01009F92 File Offset: 0x01008192
		public override void Reset()
		{
			this.EntityId = new int?(0);
		}

		// Token: 0x06039476 RID: 234614 RVA: 0x01009FA0 File Offset: 0x010081A0
		[NullableContext(1)]
		public static DynamicInteractContext Create(int entityId = 0, [Nullable(2)] GeneralContext finalContexrpb = null, GameCtxType? subType = null)
		{
			DynamicInteractContext dynamicInteractContext = GeneralContext.GetObj(EGeneralContextType.DynamicInteract, subType, () => new DynamicInteractContext()) as DynamicInteractContext;
			dynamicInteractContext.EntityId = new int?(entityId);
			dynamicInteractContext.FinalContext = finalContexrpb;
			return dynamicInteractContext;
		}

		// Token: 0x0401E28F RID: 123535
		public int? EntityId = new int?(0);

		// Token: 0x0401E290 RID: 123536
		[Nullable(2)]
		public GeneralContext FinalContext;
	}
}
