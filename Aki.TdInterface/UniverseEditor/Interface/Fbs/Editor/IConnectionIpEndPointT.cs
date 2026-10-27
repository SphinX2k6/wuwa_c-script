using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004842 RID: 18498
	public class IConnectionIpEndPointT
	{
		// Token: 0x170084C4 RID: 33988
		// (get) Token: 0x0601C9A9 RID: 117161 RVA: 0x0040B183 File Offset: 0x00409383
		// (set) Token: 0x0601C9AA RID: 117162 RVA: 0x0040B18B File Offset: 0x0040938B
		public string Address { get; set; }

		// Token: 0x170084C5 RID: 33989
		// (get) Token: 0x0601C9AB RID: 117163 RVA: 0x0040B194 File Offset: 0x00409394
		// (set) Token: 0x0601C9AC RID: 117164 RVA: 0x0040B19C File Offset: 0x0040939C
		public int Port { get; set; }

		// Token: 0x0601C9AD RID: 117165 RVA: 0x0040B1A5 File Offset: 0x004093A5
		public IConnectionIpEndPointT()
		{
			this.Address = null;
			this.Port = 0;
		}
	}
}
