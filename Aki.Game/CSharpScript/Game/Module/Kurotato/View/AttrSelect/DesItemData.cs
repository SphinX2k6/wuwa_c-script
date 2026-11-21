using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004755 RID: 18261
	[NullableContext(1)]
	[Nullable(0)]
	internal class DesItemData : IMultiTemplateGridData<string, DesItem>, IMultiTemplateGridData
	{
		// Token: 0x17005C3E RID: 23614
		// (get) Token: 0x0602DD6E RID: 187758 RVA: 0x00CD49E7 File Offset: 0x00CD2BE7
		// (set) Token: 0x0602DD6F RID: 187759 RVA: 0x00CD49EF File Offset: 0x00CD2BEF
		public string Data { get; set; }

		// Token: 0x17005C3F RID: 23615
		// (get) Token: 0x0602DD70 RID: 187760 RVA: 0x00CD49F8 File Offset: 0x00CD2BF8
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0602DD71 RID: 187761 RVA: 0x00CD4A00 File Offset: 0x00CD2C00
		public DesItemData(string data)
		{
			this.Data = data;
		}

		// Token: 0x0602DD72 RID: 187762 RVA: 0x00CD4A0F File Offset: 0x00CD2C0F
		public int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x0602DD73 RID: 187763 RVA: 0x00CD4A12 File Offset: 0x00CD2C12
		public ISyncGridProxy CreateProxy()
		{
			return new DesItem();
		}
	}
}
