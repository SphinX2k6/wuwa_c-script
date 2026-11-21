using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DF RID: 22495
	public class IFixedStreamingSourceT
	{
		// Token: 0x1700A2B5 RID: 41653
		// (get) Token: 0x06024577 RID: 148855 RVA: 0x004FE587 File Offset: 0x004FC787
		// (set) Token: 0x06024578 RID: 148856 RVA: 0x004FE58F File Offset: 0x004FC78F
		public EStreamingSourceMode Type { get; set; }

		// Token: 0x1700A2B6 RID: 41654
		// (get) Token: 0x06024579 RID: 148857 RVA: 0x004FE598 File Offset: 0x004FC798
		// (set) Token: 0x0602457A RID: 148858 RVA: 0x004FE5A0 File Offset: 0x004FC7A0
		public IStreamingSourceConfigT StreamingSourceConfig { get; set; }

		// Token: 0x0602457B RID: 148859 RVA: 0x004FE5A9 File Offset: 0x004FC7A9
		public IFixedStreamingSourceT()
		{
			this.Type = EStreamingSourceMode.Fixed;
			this.StreamingSourceConfig = null;
		}
	}
}
