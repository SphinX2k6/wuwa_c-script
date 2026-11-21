using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200575D RID: 22365
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookTitleTemplateData : IMultiTemplateGridData<DangBrawlHandBookTitleData, DangoBrawlHandBookTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x17006A74 RID: 27252
		// (get) Token: 0x0603724E RID: 225870 RVA: 0x00F643CE File Offset: 0x00F625CE
		// (set) Token: 0x0603724F RID: 225871 RVA: 0x00F643D6 File Offset: 0x00F625D6
		public DangBrawlHandBookTitleData Data { get; set; }

		// Token: 0x17006A75 RID: 27253
		// (get) Token: 0x06037250 RID: 225872 RVA: 0x00F643DF File Offset: 0x00F625DF
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06037251 RID: 225873 RVA: 0x00F643EC File Offset: 0x00F625EC
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06037252 RID: 225874 RVA: 0x00F643EF File Offset: 0x00F625EF
		public DangoBrawlHandBookTitleItem CreateProxy()
		{
			return new DangoBrawlHandBookTitleItem();
		}

		// Token: 0x06037253 RID: 225875 RVA: 0x00F643F6 File Offset: 0x00F625F6
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x0401D260 RID: 119392
		private const int TitleTemplateIndex = 0;
	}
}
