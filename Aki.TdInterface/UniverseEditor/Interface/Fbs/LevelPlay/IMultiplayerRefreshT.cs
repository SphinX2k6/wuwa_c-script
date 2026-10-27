using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200452B RID: 17707
	public class IMultiplayerRefreshT
	{
		// Token: 0x17007D9A RID: 32154
		// (get) Token: 0x0601AA0B RID: 109067 RVA: 0x003CCFEC File Offset: 0x003CB1EC
		// (set) Token: 0x0601AA0C RID: 109068 RVA: 0x003CCFF4 File Offset: 0x003CB1F4
		public int CompletedRefreshTime { get; set; }

		// Token: 0x17007D9B RID: 32155
		// (get) Token: 0x0601AA0D RID: 109069 RVA: 0x003CCFFD File Offset: 0x003CB1FD
		// (set) Token: 0x0601AA0E RID: 109070 RVA: 0x003CD005 File Offset: 0x003CB205
		public int AllPlayerAwardedRefreshTime { get; set; }

		// Token: 0x17007D9C RID: 32156
		// (get) Token: 0x0601AA0F RID: 109071 RVA: 0x003CD00E File Offset: 0x003CB20E
		// (set) Token: 0x0601AA10 RID: 109072 RVA: 0x003CD016 File Offset: 0x003CB216
		public int AnyPlayerAwardedRefreshTime { get; set; }

		// Token: 0x17007D9D RID: 32157
		// (get) Token: 0x0601AA11 RID: 109073 RVA: 0x003CD01F File Offset: 0x003CB21F
		// (set) Token: 0x0601AA12 RID: 109074 RVA: 0x003CD027 File Offset: 0x003CB227
		public byte NullMask { get; set; }

		// Token: 0x0601AA13 RID: 109075 RVA: 0x003CD030 File Offset: 0x003CB230
		public IMultiplayerRefreshT()
		{
			this.CompletedRefreshTime = 0;
			this.AllPlayerAwardedRefreshTime = 0;
			this.AnyPlayerAwardedRefreshTime = 0;
			this.NullMask = 0;
		}
	}
}
