using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E9D RID: 16029
	public class IInformationBoardTypeT
	{
		// Token: 0x17006F4C RID: 28492
		// (get) Token: 0x06016A22 RID: 92706 RVA: 0x00344F42 File Offset: 0x00343142
		// (set) Token: 0x06016A23 RID: 92707 RVA: 0x00344F4A File Offset: 0x0034314A
		public EInformationBoardType Type { get; set; }

		// Token: 0x06016A24 RID: 92708 RVA: 0x00344F53 File Offset: 0x00343153
		public IInformationBoardTypeT()
		{
			this.Type = EInformationBoardType.DangoAbyss;
		}
	}
}
