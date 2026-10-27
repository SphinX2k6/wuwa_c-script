using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005214 RID: 21012
	public class IExtraRangeComponentT
	{
		// Token: 0x170099EA RID: 39402
		// (get) Token: 0x06022262 RID: 139874 RVA: 0x004BCFED File Offset: 0x004BB1ED
		// (set) Token: 0x06022263 RID: 139875 RVA: 0x004BCFF5 File Offset: 0x004BB1F5
		public bool Disabled { get; set; }

		// Token: 0x170099EB RID: 39403
		// (get) Token: 0x06022264 RID: 139876 RVA: 0x004BCFFE File Offset: 0x004BB1FE
		// (set) Token: 0x06022265 RID: 139877 RVA: 0x004BD006 File Offset: 0x004BB206
		public List<ISunSpiritBlockExtraRangeT> ExtraRangeConfigs { get; set; }

		// Token: 0x170099EC RID: 39404
		// (get) Token: 0x06022266 RID: 139878 RVA: 0x004BD00F File Offset: 0x004BB20F
		// (set) Token: 0x06022267 RID: 139879 RVA: 0x004BD017 File Offset: 0x004BB217
		public byte NullMask { get; set; }

		// Token: 0x06022268 RID: 139880 RVA: 0x004BD020 File Offset: 0x004BB220
		public IExtraRangeComponentT()
		{
			this.Disabled = false;
			this.ExtraRangeConfigs = null;
			this.NullMask = 0;
		}
	}
}
