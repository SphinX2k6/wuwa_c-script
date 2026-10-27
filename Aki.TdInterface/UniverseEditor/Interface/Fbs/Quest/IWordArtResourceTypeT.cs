using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AB RID: 17067
	public class IWordArtResourceTypeT
	{
		// Token: 0x17007923 RID: 31011
		// (get) Token: 0x060194A3 RID: 103587 RVA: 0x003A18E6 File Offset: 0x0039FAE6
		// (set) Token: 0x060194A4 RID: 103588 RVA: 0x003A18EE File Offset: 0x0039FAEE
		public EWordArtResourceType Type { get; set; }

		// Token: 0x060194A5 RID: 103589 RVA: 0x003A18F7 File Offset: 0x0039FAF7
		public IWordArtResourceTypeT()
		{
			this.Type = EWordArtResourceType.Default;
		}
	}
}
