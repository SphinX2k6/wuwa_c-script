using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay.Guarantee;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AFB RID: 23291
	public class GuaranteeContext : GeneralContext
	{
		// Token: 0x06039482 RID: 234626 RVA: 0x0100A18E File Offset: 0x0100838E
		public GuaranteeContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Guarantee);
		}

		// Token: 0x06039483 RID: 234627 RVA: 0x0100A1A2 File Offset: 0x010083A2
		[NullableContext(1)]
		public static GuaranteeContext Create(GameCtxType? subType = null, EGuaranteeReason guaranteeReason = EGuaranteeReason.Unknown)
		{
			GuaranteeContext guaranteeContext = GeneralContext.GetObj(EGeneralContextType.Guarantee, subType, () => new GuaranteeContext()) as GuaranteeContext;
			guaranteeContext.GuaranteeReason = guaranteeReason;
			return guaranteeContext;
		}

		// Token: 0x0401E298 RID: 123544
		public EGuaranteeReason GuaranteeReason;
	}
}
