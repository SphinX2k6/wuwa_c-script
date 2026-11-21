using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C96 RID: 31894
	public class IUiGameT
	{
		// Token: 0x1700EED4 RID: 61140
		// (get) Token: 0x06039861 RID: 235617 RVA: 0x007C399E File Offset: 0x007C1B9E
		// (set) Token: 0x06039862 RID: 235618 RVA: 0x007C39A6 File Offset: 0x007C1BA6
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x06039863 RID: 235619 RVA: 0x007C39AF File Offset: 0x007C1BAF
		public IUiGameT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
