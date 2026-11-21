using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CAA RID: 19626
	public class IConnectionIpEndPointT
	{
		// Token: 0x17008B0F RID: 35599
		// (get) Token: 0x0601E1A6 RID: 123302 RVA: 0x00437AD3 File Offset: 0x00435CD3
		// (set) Token: 0x0601E1A7 RID: 123303 RVA: 0x00437ADB File Offset: 0x00435CDB
		public string Address { get; set; }

		// Token: 0x17008B10 RID: 35600
		// (get) Token: 0x0601E1A8 RID: 123304 RVA: 0x00437AE4 File Offset: 0x00435CE4
		// (set) Token: 0x0601E1A9 RID: 123305 RVA: 0x00437AEC File Offset: 0x00435CEC
		public int Port { get; set; }

		// Token: 0x0601E1AA RID: 123306 RVA: 0x00437AF5 File Offset: 0x00435CF5
		public IConnectionIpEndPointT()
		{
			this.Address = null;
			this.Port = 0;
		}
	}
}
