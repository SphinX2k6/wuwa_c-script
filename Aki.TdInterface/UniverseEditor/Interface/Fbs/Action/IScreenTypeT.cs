using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F49 RID: 28489
	public class IScreenTypeT
	{
		// Token: 0x1700D3B6 RID: 54198
		// (get) Token: 0x06032557 RID: 206167 RVA: 0x006CC036 File Offset: 0x006CA236
		// (set) Token: 0x06032558 RID: 206168 RVA: 0x006CC03E File Offset: 0x006CA23E
		public EScreenType Type { get; set; }

		// Token: 0x06032559 RID: 206169 RVA: 0x006CC047 File Offset: 0x006CA247
		public IScreenTypeT()
		{
			this.Type = EScreenType.Main;
		}
	}
}
