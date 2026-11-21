using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004753 RID: 18259
	[NullableContext(1)]
	[Nullable(0)]
	internal class AttrInfoItemData : IMultiTemplateGridData<IKurotatoAttrDisplay, AttrInfoItem>, IMultiTemplateGridData
	{
		// Token: 0x17005C3C RID: 23612
		// (get) Token: 0x0602DD64 RID: 187748 RVA: 0x00CD4919 File Offset: 0x00CD2B19
		// (set) Token: 0x0602DD65 RID: 187749 RVA: 0x00CD4921 File Offset: 0x00CD2B21
		public IKurotatoAttrDisplay Data { get; set; }

		// Token: 0x17005C3D RID: 23613
		// (get) Token: 0x0602DD66 RID: 187750 RVA: 0x00CD492A File Offset: 0x00CD2B2A
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0602DD67 RID: 187751 RVA: 0x00CD4932 File Offset: 0x00CD2B32
		public AttrInfoItemData(IKurotatoAttrDisplay data)
		{
			this.Data = data;
		}

		// Token: 0x0602DD68 RID: 187752 RVA: 0x00CD4941 File Offset: 0x00CD2B41
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0602DD69 RID: 187753 RVA: 0x00CD4944 File Offset: 0x00CD2B44
		public ISyncGridProxy CreateProxy()
		{
			return new AttrInfoItem();
		}
	}
}
