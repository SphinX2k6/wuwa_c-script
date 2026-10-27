using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200680D RID: 26637
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookTitleTemplateData : IMultiTemplateGridData<DangBrawlHandBookTitleData, DangoBrawlHandBookTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x17009733 RID: 38707
		// (get) Token: 0x060426F9 RID: 272121 RVA: 0x01022E8A File Offset: 0x0102108A
		// (set) Token: 0x060426FA RID: 272122 RVA: 0x01022E92 File Offset: 0x01021092
		public DangBrawlHandBookTitleData Data { get; set; }

		// Token: 0x17009734 RID: 38708
		// (get) Token: 0x060426FB RID: 272123 RVA: 0x01022E9B File Offset: 0x0102109B
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x060426FC RID: 272124 RVA: 0x01022EA8 File Offset: 0x010210A8
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x060426FD RID: 272125 RVA: 0x01022EAB File Offset: 0x010210AB
		public DangoBrawlHandBookTitleItem CreateProxy()
		{
			return new DangoBrawlHandBookTitleItem();
		}

		// Token: 0x060426FE RID: 272126 RVA: 0x01022EB2 File Offset: 0x010210B2
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x04022A03 RID: 141827
		private const int TitleTemplateIndex = 0;
	}
}
