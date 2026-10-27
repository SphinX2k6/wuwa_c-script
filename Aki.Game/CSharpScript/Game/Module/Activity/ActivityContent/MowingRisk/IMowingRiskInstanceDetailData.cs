using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063C1 RID: 25537
	[NullableContext(1)]
	public interface IMowingRiskInstanceDetailData
	{
		// Token: 0x170093C5 RID: 37829
		// (get) Token: 0x060403EA RID: 263146
		// (set) Token: 0x060403EB RID: 263147
		string TitleTextId { get; set; }

		// Token: 0x170093C6 RID: 37830
		// (get) Token: 0x060403EC RID: 263148
		// (set) Token: 0x060403ED RID: 263149
		string ContentTextId { get; set; }

		// Token: 0x170093C7 RID: 37831
		// (get) Token: 0x060403EE RID: 263150
		// (set) Token: 0x060403EF RID: 263151
		IMowingRiskInstanceDetailAttributeItemData[] AttributeList { get; set; }

		// Token: 0x170093C8 RID: 37832
		// (get) Token: 0x060403F0 RID: 263152
		// (set) Token: 0x060403F1 RID: 263153
		IMowingRiskInstanceDetailLockItemData LockData { get; set; }
	}
}
