using System;

namespace System.Text
{
	// Token: 0x02000212 RID: 530
	internal sealed class CodePageDataItem
	{
		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x00080E4D File Offset: 0x0007F04D
		public int UIFamilyCodePage { get; }

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x00080E55 File Offset: 0x0007F055
		public string WebName { get; }

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x00080E5D File Offset: 0x0007F05D
		public string HeaderName { get; }

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x00080E65 File Offset: 0x0007F065
		public string BodyName { get; }

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x00080E6D File Offset: 0x0007F06D
		public string DisplayName { get; }

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x00080E75 File Offset: 0x0007F075
		public uint Flags { get; }

		// Token: 0x06002945 RID: 10565 RVA: 0x00080E7D File Offset: 0x0007F07D
		internal CodePageDataItem(int uiFamilyCodePage, string webName, string headerName, string bodyName, string displayName, uint flags)
		{
			this.UIFamilyCodePage = uiFamilyCodePage;
			this.WebName = webName;
			this.HeaderName = headerName;
			this.BodyName = bodyName;
			this.DisplayName = displayName;
			this.Flags = flags;
		}
	}
}
