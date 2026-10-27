using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A0 RID: 27040
	public class GmLevelActionContext : GeneralContext
	{
		// Token: 0x0604344C RID: 275532 RVA: 0x01065F6E File Offset: 0x0106416E
		public GmLevelActionContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.GmLevelAction);
		}

		// Token: 0x0604344D RID: 275533 RVA: 0x01065F82 File Offset: 0x01064182
		public override void Reset()
		{
		}

		// Token: 0x0604344E RID: 275534 RVA: 0x01065F84 File Offset: 0x01064184
		[NullableContext(1)]
		public static GmLevelActionContext Create(GameCtxType? subType = null)
		{
			return GeneralContext.GetObj(EGeneralContextType.GmLevelAction, subType, () => new GmLevelActionContext()) as GmLevelActionContext;
		}
	}
}
