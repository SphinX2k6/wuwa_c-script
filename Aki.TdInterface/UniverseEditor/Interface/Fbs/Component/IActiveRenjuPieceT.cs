using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E51 RID: 20049
	public class IActiveRenjuPieceT
	{
		// Token: 0x17008F7D RID: 36733
		// (get) Token: 0x0601F792 RID: 128914 RVA: 0x00462802 File Offset: 0x00460A02
		// (set) Token: 0x0601F793 RID: 128915 RVA: 0x0046280A File Offset: 0x00460A0A
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x17008F7E RID: 36734
		// (get) Token: 0x0601F794 RID: 128916 RVA: 0x00462813 File Offset: 0x00460A13
		// (set) Token: 0x0601F795 RID: 128917 RVA: 0x0046281B File Offset: 0x00460A1B
		public List<IRenjuConfigT> RenjuConfig { get; set; }

		// Token: 0x17008F7F RID: 36735
		// (get) Token: 0x0601F796 RID: 128918 RVA: 0x00462824 File Offset: 0x00460A24
		// (set) Token: 0x0601F797 RID: 128919 RVA: 0x0046282C File Offset: 0x00460A2C
		public List<IJigsawItemMatchedConfigT> ExitMatchedConfig { get; set; }

		// Token: 0x17008F80 RID: 36736
		// (get) Token: 0x0601F798 RID: 128920 RVA: 0x00462835 File Offset: 0x00460A35
		// (set) Token: 0x0601F799 RID: 128921 RVA: 0x0046283D File Offset: 0x00460A3D
		public byte NullMask { get; set; }

		// Token: 0x0601F79A RID: 128922 RVA: 0x00462846 File Offset: 0x00460A46
		public IActiveRenjuPieceT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
			this.RenjuConfig = null;
			this.ExitMatchedConfig = null;
			this.NullMask = 0;
		}
	}
}
