using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C0B RID: 19467
	public class IElementalBoxStateTargetT
	{
		// Token: 0x17008D6A RID: 36202
		// (get) Token: 0x0601ED51 RID: 126289 RVA: 0x00451352 File Offset: 0x0044F552
		// (set) Token: 0x0601ED52 RID: 126290 RVA: 0x0045135A File Offset: 0x0044F55A
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x0601ED53 RID: 126291 RVA: 0x00451363 File Offset: 0x0044F563
		public IElementalBoxStateTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
		}
	}
}
