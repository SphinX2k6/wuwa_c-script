using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200577A RID: 22394
	[NullableContext(1)]
	[Nullable(0)]
	internal class WeaponAttrInfoItemData : IMultiTemplateGridData<IKurotatoAttrDisplay, WeaponAttrInfoItem>, IMultiTemplateGridData
	{
		// Token: 0x17008872 RID: 34930
		// (get) Token: 0x06038E4B RID: 233035 RVA: 0x00D85B75 File Offset: 0x00D83D75
		// (set) Token: 0x06038E4C RID: 233036 RVA: 0x00D85B7D File Offset: 0x00D83D7D
		public IKurotatoAttrDisplay Data { get; set; }

		// Token: 0x17008873 RID: 34931
		// (get) Token: 0x06038E4D RID: 233037 RVA: 0x00D85B86 File Offset: 0x00D83D86
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06038E4E RID: 233038 RVA: 0x00D85B8E File Offset: 0x00D83D8E
		public WeaponAttrInfoItemData(IKurotatoAttrDisplay data)
		{
			this.Data = data;
		}

		// Token: 0x06038E4F RID: 233039 RVA: 0x00D85B9D File Offset: 0x00D83D9D
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06038E50 RID: 233040 RVA: 0x00D85BA0 File Offset: 0x00D83DA0
		public ISyncGridProxy CreateProxy()
		{
			return new WeaponAttrInfoItem();
		}
	}
}
