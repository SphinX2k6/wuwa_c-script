using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004751 RID: 18257
	[NullableContext(1)]
	[Nullable(0)]
	internal class WeaponAttrInfoItemData : IMultiTemplateGridData<IKurotatoAttrDisplay, WeaponAttrInfoItem>, IMultiTemplateGridData
	{
		// Token: 0x17005C3A RID: 23610
		// (get) Token: 0x0602DD5B RID: 187739 RVA: 0x00CD4835 File Offset: 0x00CD2A35
		// (set) Token: 0x0602DD5C RID: 187740 RVA: 0x00CD483D File Offset: 0x00CD2A3D
		public IKurotatoAttrDisplay Data { get; set; }

		// Token: 0x17005C3B RID: 23611
		// (get) Token: 0x0602DD5D RID: 187741 RVA: 0x00CD4846 File Offset: 0x00CD2A46
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0602DD5E RID: 187742 RVA: 0x00CD484E File Offset: 0x00CD2A4E
		public WeaponAttrInfoItemData(IKurotatoAttrDisplay data)
		{
			this.Data = data;
		}

		// Token: 0x0602DD5F RID: 187743 RVA: 0x00CD485D File Offset: 0x00CD2A5D
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0602DD60 RID: 187744 RVA: 0x00CD4860 File Offset: 0x00CD2A60
		public ISyncGridProxy CreateProxy()
		{
			return new WeaponAttrInfoItem();
		}
	}
}
