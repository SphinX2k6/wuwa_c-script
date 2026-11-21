using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DEE RID: 15854
	public class IBlackBoardEntityPosT
	{
		// Token: 0x17006B15 RID: 27413
		// (get) Token: 0x0601549B RID: 87195 RVA: 0x0031405D File Offset: 0x0031225D
		// (set) Token: 0x0601549C RID: 87196 RVA: 0x00314065 File Offset: 0x00312265
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006B16 RID: 27414
		// (get) Token: 0x0601549D RID: 87197 RVA: 0x0031406E File Offset: 0x0031226E
		// (set) Token: 0x0601549E RID: 87198 RVA: 0x00314076 File Offset: 0x00312276
		public string Key { get; set; }

		// Token: 0x17006B17 RID: 27415
		// (get) Token: 0x0601549F RID: 87199 RVA: 0x0031407F File Offset: 0x0031227F
		// (set) Token: 0x060154A0 RID: 87200 RVA: 0x00314087 File Offset: 0x00312287
		public int EntityId { get; set; }

		// Token: 0x060154A1 RID: 87201 RVA: 0x00314090 File Offset: 0x00312290
		public IBlackBoardEntityPosT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.EntityId = 0;
		}
	}
}
