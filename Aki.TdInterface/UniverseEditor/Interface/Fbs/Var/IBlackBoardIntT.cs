using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DF4 RID: 15860
	public class IBlackBoardIntT
	{
		// Token: 0x17006B23 RID: 27427
		// (get) Token: 0x060154D3 RID: 87251 RVA: 0x003145DD File Offset: 0x003127DD
		// (set) Token: 0x060154D4 RID: 87252 RVA: 0x003145E5 File Offset: 0x003127E5
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006B24 RID: 27428
		// (get) Token: 0x060154D5 RID: 87253 RVA: 0x003145EE File Offset: 0x003127EE
		// (set) Token: 0x060154D6 RID: 87254 RVA: 0x003145F6 File Offset: 0x003127F6
		public string Key { get; set; }

		// Token: 0x17006B25 RID: 27429
		// (get) Token: 0x060154D7 RID: 87255 RVA: 0x003145FF File Offset: 0x003127FF
		// (set) Token: 0x060154D8 RID: 87256 RVA: 0x00314607 File Offset: 0x00312807
		public int Value { get; set; }

		// Token: 0x060154D9 RID: 87257 RVA: 0x00314610 File Offset: 0x00312810
		public IBlackBoardIntT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Value = 0;
		}
	}
}
