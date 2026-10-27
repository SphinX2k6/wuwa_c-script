using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay.Guarantee;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200699F RID: 27039
	public class GuaranteeContext : GeneralContext
	{
		// Token: 0x0604344A RID: 275530 RVA: 0x01065F26 File Offset: 0x01064126
		public GuaranteeContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Guarantee);
		}

		// Token: 0x0604344B RID: 275531 RVA: 0x01065F3A File Offset: 0x0106413A
		[NullableContext(1)]
		public static GuaranteeContext Create(GameCtxType? subType = null, EGuaranteeReason guaranteeReason = EGuaranteeReason.Unknown)
		{
			GuaranteeContext guaranteeContext = GeneralContext.GetObj(EGeneralContextType.Guarantee, subType, () => new GuaranteeContext()) as GuaranteeContext;
			guaranteeContext.GuaranteeReason = guaranteeReason;
			return guaranteeContext;
		}

		// Token: 0x040230AE RID: 143534
		public EGuaranteeReason GuaranteeReason;
	}
}
