using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200470D RID: 18189
	public class IRunningTreeT
	{
		// Token: 0x1700823C RID: 33340
		// (get) Token: 0x0601BE73 RID: 114291 RVA: 0x003F4785 File Offset: 0x003F2985
		// (set) Token: 0x0601BE74 RID: 114292 RVA: 0x003F478D File Offset: 0x003F298D
		public int Id { get; set; }

		// Token: 0x1700823D RID: 33341
		// (get) Token: 0x0601BE75 RID: 114293 RVA: 0x003F4796 File Offset: 0x003F2996
		// (set) Token: 0x0601BE76 RID: 114294 RVA: 0x003F479E File Offset: 0x003F299E
		public bool IsOccupy { get; set; }

		// Token: 0x1700823E RID: 33342
		// (get) Token: 0x0601BE77 RID: 114295 RVA: 0x003F47A7 File Offset: 0x003F29A7
		// (set) Token: 0x0601BE78 RID: 114296 RVA: 0x003F47AF File Offset: 0x003F29AF
		public bool IsHide { get; set; }

		// Token: 0x1700823F RID: 33343
		// (get) Token: 0x0601BE79 RID: 114297 RVA: 0x003F47B8 File Offset: 0x003F29B8
		// (set) Token: 0x0601BE7A RID: 114298 RVA: 0x003F47C0 File Offset: 0x003F29C0
		public bool IsSuspend { get; set; }

		// Token: 0x17008240 RID: 33344
		// (get) Token: 0x0601BE7B RID: 114299 RVA: 0x003F47C9 File Offset: 0x003F29C9
		// (set) Token: 0x0601BE7C RID: 114300 RVA: 0x003F47D1 File Offset: 0x003F29D1
		public EQuestStatus QuestStatus { get; set; }

		// Token: 0x17008241 RID: 33345
		// (get) Token: 0x0601BE7D RID: 114301 RVA: 0x003F47DA File Offset: 0x003F29DA
		// (set) Token: 0x0601BE7E RID: 114302 RVA: 0x003F47E2 File Offset: 0x003F29E2
		public IRunningTreeConfigT Tree { get; set; }

		// Token: 0x17008242 RID: 33346
		// (get) Token: 0x0601BE7F RID: 114303 RVA: 0x003F47EB File Offset: 0x003F29EB
		// (set) Token: 0x0601BE80 RID: 114304 RVA: 0x003F47F3 File Offset: 0x003F29F3
		public byte NullMask { get; set; }

		// Token: 0x0601BE81 RID: 114305 RVA: 0x003F47FC File Offset: 0x003F29FC
		public IRunningTreeT()
		{
			this.Id = 0;
			this.IsOccupy = false;
			this.IsHide = false;
			this.IsSuspend = false;
			this.QuestStatus = EQuestStatus.None;
			this.Tree = null;
			this.NullMask = 0;
		}
	}
}
