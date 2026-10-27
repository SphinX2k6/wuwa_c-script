using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200577C RID: 22396
	[NullableContext(1)]
	[Nullable(0)]
	internal class AttrInfoItemData : IMultiTemplateGridData<IKurotatoAttrDisplay, AttrInfoItem>, IMultiTemplateGridData
	{
		// Token: 0x17008874 RID: 34932
		// (get) Token: 0x06038E54 RID: 233044 RVA: 0x00D85C59 File Offset: 0x00D83E59
		// (set) Token: 0x06038E55 RID: 233045 RVA: 0x00D85C61 File Offset: 0x00D83E61
		public IKurotatoAttrDisplay Data { get; set; }

		// Token: 0x17008875 RID: 34933
		// (get) Token: 0x06038E56 RID: 233046 RVA: 0x00D85C6A File Offset: 0x00D83E6A
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06038E57 RID: 233047 RVA: 0x00D85C72 File Offset: 0x00D83E72
		public AttrInfoItemData(IKurotatoAttrDisplay data)
		{
			this.Data = data;
		}

		// Token: 0x06038E58 RID: 233048 RVA: 0x00D85C81 File Offset: 0x00D83E81
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06038E59 RID: 233049 RVA: 0x00D85C84 File Offset: 0x00D83E84
		public ISyncGridProxy CreateProxy()
		{
			return new AttrInfoItem();
		}
	}
}
