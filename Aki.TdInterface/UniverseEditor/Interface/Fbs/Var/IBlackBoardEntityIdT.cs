using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A10 RID: 14864
	public class IBlackBoardEntityIdT
	{
		// Token: 0x170065DE RID: 26078
		// (get) Token: 0x06014163 RID: 82275 RVA: 0x002F0BB9 File Offset: 0x002EEDB9
		// (set) Token: 0x06014164 RID: 82276 RVA: 0x002F0BC1 File Offset: 0x002EEDC1
		public EBlackBoardType Type { get; set; }

		// Token: 0x170065DF RID: 26079
		// (get) Token: 0x06014165 RID: 82277 RVA: 0x002F0BCA File Offset: 0x002EEDCA
		// (set) Token: 0x06014166 RID: 82278 RVA: 0x002F0BD2 File Offset: 0x002EEDD2
		public string Key { get; set; }

		// Token: 0x170065E0 RID: 26080
		// (get) Token: 0x06014167 RID: 82279 RVA: 0x002F0BDB File Offset: 0x002EEDDB
		// (set) Token: 0x06014168 RID: 82280 RVA: 0x002F0BE3 File Offset: 0x002EEDE3
		public int EntityId { get; set; }

		// Token: 0x06014169 RID: 82281 RVA: 0x002F0BEC File Offset: 0x002EEDEC
		public IBlackBoardEntityIdT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.EntityId = 0;
		}
	}
}
