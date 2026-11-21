using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AFC RID: 23292
	public class GmLevelActionContext : GeneralContext
	{
		// Token: 0x06039484 RID: 234628 RVA: 0x0100A1D6 File Offset: 0x010083D6
		public GmLevelActionContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.GmLevelAction);
		}

		// Token: 0x06039485 RID: 234629 RVA: 0x0100A1EA File Offset: 0x010083EA
		public override void Reset()
		{
		}

		// Token: 0x06039486 RID: 234630 RVA: 0x0100A1EC File Offset: 0x010083EC
		[NullableContext(1)]
		public static GmLevelActionContext Create(GameCtxType? subType = null)
		{
			return GeneralContext.GetObj(EGeneralContextType.GmLevelAction, subType, () => new GmLevelActionContext()) as GmLevelActionContext;
		}
	}
}
