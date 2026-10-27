using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064F9 RID: 25849
	public class ICustomJsonT
	{
		// Token: 0x1700C043 RID: 49219
		// (get) Token: 0x0602CD7D RID: 183677 RVA: 0x0062926E File Offset: 0x0062746E
		// (set) Token: 0x0602CD7E RID: 183678 RVA: 0x00629276 File Offset: 0x00627476
		public string Name { get; set; }

		// Token: 0x1700C044 RID: 49220
		// (get) Token: 0x0602CD7F RID: 183679 RVA: 0x0062927F File Offset: 0x0062747F
		// (set) Token: 0x0602CD80 RID: 183680 RVA: 0x00629287 File Offset: 0x00627487
		public string JsonString { get; set; }

		// Token: 0x0602CD81 RID: 183681 RVA: 0x00629290 File Offset: 0x00627490
		public ICustomJsonT()
		{
			this.Name = null;
			this.JsonString = null;
		}
	}
}
