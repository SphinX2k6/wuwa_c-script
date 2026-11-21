using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D5 RID: 31189
	public class ISubScreenT
	{
		// Token: 0x1700E4A6 RID: 58534
		// (get) Token: 0x06036F38 RID: 225080 RVA: 0x00758D1B File Offset: 0x00756F1B
		// (set) Token: 0x06036F39 RID: 225081 RVA: 0x00758D23 File Offset: 0x00756F23
		public EScreenType Type { get; set; }

		// Token: 0x1700E4A7 RID: 58535
		// (get) Token: 0x06036F3A RID: 225082 RVA: 0x00758D2C File Offset: 0x00756F2C
		// (set) Token: 0x06036F3B RID: 225083 RVA: 0x00758D34 File Offset: 0x00756F34
		public string SubScreenKey { get; set; }

		// Token: 0x06036F3C RID: 225084 RVA: 0x00758D3D File Offset: 0x00756F3D
		public ISubScreenT()
		{
			this.Type = EScreenType.Main;
			this.SubScreenKey = null;
		}
	}
}
