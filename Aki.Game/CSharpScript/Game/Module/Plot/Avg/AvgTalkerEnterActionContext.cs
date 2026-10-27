using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020050E4 RID: 20708
	public class AvgTalkerEnterActionContext
	{
		// Token: 0x17008090 RID: 32912
		// (get) Token: 0x06034F86 RID: 216966 RVA: 0x00C8C5AF File Offset: 0x00C8A7AF
		// (set) Token: 0x06034F87 RID: 216967 RVA: 0x00C8C5B7 File Offset: 0x00C8A7B7
		public int CharacterId { get; set; }

		// Token: 0x17008091 RID: 32913
		// (get) Token: 0x06034F88 RID: 216968 RVA: 0x00C8C5C0 File Offset: 0x00C8A7C0
		// (set) Token: 0x06034F89 RID: 216969 RVA: 0x00C8C5C8 File Offset: 0x00C8A7C8
		public EAvgRolePosition Position { get; set; }

		// Token: 0x17008092 RID: 32914
		// (get) Token: 0x06034F8A RID: 216970 RVA: 0x00C8C5D1 File Offset: 0x00C8A7D1
		// (set) Token: 0x06034F8B RID: 216971 RVA: 0x00C8C5D9 File Offset: 0x00C8A7D9
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x17008093 RID: 32915
		// (get) Token: 0x06034F8C RID: 216972 RVA: 0x00C8C5E2 File Offset: 0x00C8A7E2
		// (set) Token: 0x06034F8D RID: 216973 RVA: 0x00C8C5EA File Offset: 0x00C8A7EA
		public bool IsLoop { get; set; }
	}
}
