using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B67 RID: 27495
	public class ICustomJsonT
	{
		// Token: 0x1700C9D3 RID: 51667
		// (get) Token: 0x0602F513 RID: 193811 RVA: 0x0067550E File Offset: 0x0067370E
		// (set) Token: 0x0602F514 RID: 193812 RVA: 0x00675516 File Offset: 0x00673716
		public string Name { get; set; }

		// Token: 0x1700C9D4 RID: 51668
		// (get) Token: 0x0602F515 RID: 193813 RVA: 0x0067551F File Offset: 0x0067371F
		// (set) Token: 0x0602F516 RID: 193814 RVA: 0x00675527 File Offset: 0x00673727
		public string JsonString { get; set; }

		// Token: 0x0602F517 RID: 193815 RVA: 0x00675530 File Offset: 0x00673730
		public ICustomJsonT()
		{
			this.Name = null;
			this.JsonString = null;
		}
	}
}
