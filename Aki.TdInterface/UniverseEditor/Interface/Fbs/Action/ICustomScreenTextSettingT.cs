using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7C RID: 27516
	public class ICustomScreenTextSettingT
	{
		// Token: 0x1700C9F0 RID: 51696
		// (get) Token: 0x0602F5A1 RID: 193953 RVA: 0x00676249 File Offset: 0x00674449
		// (set) Token: 0x0602F5A2 RID: 193954 RVA: 0x00676251 File Offset: 0x00674451
		public bool IsShowTextInfo { get; set; }

		// Token: 0x1700C9F1 RID: 51697
		// (get) Token: 0x0602F5A3 RID: 193955 RVA: 0x0067625A File Offset: 0x0067445A
		// (set) Token: 0x0602F5A4 RID: 193956 RVA: 0x00676262 File Offset: 0x00674462
		public string TidTextContent { get; set; }

		// Token: 0x1700C9F2 RID: 51698
		// (get) Token: 0x0602F5A5 RID: 193957 RVA: 0x0067626B File Offset: 0x0067446B
		// (set) Token: 0x0602F5A6 RID: 193958 RVA: 0x00676273 File Offset: 0x00674473
		public byte NullMask { get; set; }

		// Token: 0x0602F5A7 RID: 193959 RVA: 0x0067627C File Offset: 0x0067447C
		public ICustomScreenTextSettingT()
		{
			this.IsShowTextInfo = false;
			this.TidTextContent = null;
			this.NullMask = 0;
		}
	}
}
