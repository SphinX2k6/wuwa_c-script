using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200577E RID: 22398
	[NullableContext(1)]
	[Nullable(0)]
	internal class DesItemData : IMultiTemplateGridData<string, DesItem>, IMultiTemplateGridData
	{
		// Token: 0x17008876 RID: 34934
		// (get) Token: 0x06038E5E RID: 233054 RVA: 0x00D85D27 File Offset: 0x00D83F27
		// (set) Token: 0x06038E5F RID: 233055 RVA: 0x00D85D2F File Offset: 0x00D83F2F
		public string Data { get; set; }

		// Token: 0x17008877 RID: 34935
		// (get) Token: 0x06038E60 RID: 233056 RVA: 0x00D85D38 File Offset: 0x00D83F38
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06038E61 RID: 233057 RVA: 0x00D85D40 File Offset: 0x00D83F40
		public DesItemData(string data)
		{
			this.Data = data;
		}

		// Token: 0x06038E62 RID: 233058 RVA: 0x00D85D4F File Offset: 0x00D83F4F
		public int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x06038E63 RID: 233059 RVA: 0x00D85D52 File Offset: 0x00D83F52
		public ISyncGridProxy CreateProxy()
		{
			return new DesItem();
		}
	}
}
