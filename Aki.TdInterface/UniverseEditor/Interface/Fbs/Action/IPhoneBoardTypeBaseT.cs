using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007413 RID: 29715
	public class IPhoneBoardTypeBaseT
	{
		// Token: 0x1700DA4D RID: 55885
		// (get) Token: 0x06033FE4 RID: 212964 RVA: 0x00702166 File Offset: 0x00700366
		// (set) Token: 0x06033FE5 RID: 212965 RVA: 0x0070216E File Offset: 0x0070036E
		public EPhoneBoardType Type { get; set; }

		// Token: 0x06033FE6 RID: 212966 RVA: 0x00702177 File Offset: 0x00700377
		public IPhoneBoardTypeBaseT()
		{
			this.Type = EPhoneBoardType.MessageBoard;
		}
	}
}
