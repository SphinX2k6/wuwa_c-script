using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E9F RID: 24223
	public class IRotatorComponent2T
	{
		// Token: 0x1700B2E1 RID: 45793
		// (get) Token: 0x06028902 RID: 166146 RVA: 0x0058BB91 File Offset: 0x00589D91
		// (set) Token: 0x06028903 RID: 166147 RVA: 0x0058BB99 File Offset: 0x00589D99
		public bool Disabled { get; set; }

		// Token: 0x1700B2E2 RID: 45794
		// (get) Token: 0x06028904 RID: 166148 RVA: 0x0058BBA2 File Offset: 0x00589DA2
		// (set) Token: 0x06028905 RID: 166149 RVA: 0x0058BBAA File Offset: 0x00589DAA
		public List<IStateRotationConfigT> Config { get; set; }

		// Token: 0x1700B2E3 RID: 45795
		// (get) Token: 0x06028906 RID: 166150 RVA: 0x0058BBB3 File Offset: 0x00589DB3
		// (set) Token: 0x06028907 RID: 166151 RVA: 0x0058BBBB File Offset: 0x00589DBB
		public byte NullMask { get; set; }

		// Token: 0x06028908 RID: 166152 RVA: 0x0058BBC4 File Offset: 0x00589DC4
		public IRotatorComponent2T()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
