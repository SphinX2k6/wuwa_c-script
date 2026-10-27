using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A60 RID: 19040
	[NullableContext(1)]
	public interface ITrapDefenseBdProgressInfo
	{
		// Token: 0x17007A8A RID: 31370
		// (get) Token: 0x06031615 RID: 202261
		TrapDefenseBdData BdData { get; }

		// Token: 0x17007A8B RID: 31371
		// (get) Token: 0x06031616 RID: 202262
		bool IsActive { get; }

		// Token: 0x17007A8C RID: 31372
		// (get) Token: 0x06031617 RID: 202263
		bool IsShowQualityArrow { get; }

		// Token: 0x17007A8D RID: 31373
		// (get) Token: 0x06031618 RID: 202264
		ETrapDefenseResKey QualityArrowRes { get; }
	}
}
