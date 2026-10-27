using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200699A RID: 27034
	public class DynamicInteractContext : GeneralContext
	{
		// Token: 0x0604343C RID: 275516 RVA: 0x01065D09 File Offset: 0x01063F09
		public DynamicInteractContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.DynamicInteract);
		}

		// Token: 0x0604343D RID: 275517 RVA: 0x01065D2A File Offset: 0x01063F2A
		public override void Reset()
		{
			this.EntityId = new int?(0);
		}

		// Token: 0x0604343E RID: 275518 RVA: 0x01065D38 File Offset: 0x01063F38
		[NullableContext(1)]
		public static DynamicInteractContext Create(int entityId = 0, [Nullable(2)] GeneralContext finalContexrpb = null, GameCtxType? subType = null)
		{
			DynamicInteractContext dynamicInteractContext = GeneralContext.GetObj(EGeneralContextType.DynamicInteract, subType, () => new DynamicInteractContext()) as DynamicInteractContext;
			dynamicInteractContext.EntityId = new int?(entityId);
			dynamicInteractContext.FinalContext = finalContexrpb;
			return dynamicInteractContext;
		}

		// Token: 0x040230A5 RID: 143525
		public int? EntityId = new int?(0);

		// Token: 0x040230A6 RID: 143526
		[Nullable(2)]
		public GeneralContext FinalContext;
	}
}
