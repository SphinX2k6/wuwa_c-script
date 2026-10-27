using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A36 RID: 27190
	public class ILogT
	{
		// Token: 0x1700C9AC RID: 51628
		// (get) Token: 0x0602F964 RID: 194916 RVA: 0x0067A256 File Offset: 0x00678456
		// (set) Token: 0x0602F965 RID: 194917 RVA: 0x0067A25E File Offset: 0x0067845E
		public string Level { get; set; }

		// Token: 0x1700C9AD RID: 51629
		// (get) Token: 0x0602F966 RID: 194918 RVA: 0x0067A267 File Offset: 0x00678467
		// (set) Token: 0x0602F967 RID: 194919 RVA: 0x0067A26F File Offset: 0x0067846F
		public string Content { get; set; }

		// Token: 0x0602F968 RID: 194920 RVA: 0x0067A278 File Offset: 0x00678478
		public ILogT()
		{
			this.Level = null;
			this.Content = null;
		}
	}
}
