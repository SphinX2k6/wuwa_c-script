using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004707 RID: 18183
	public class IRunningNodeStatusT
	{
		// Token: 0x17008222 RID: 33314
		// (get) Token: 0x0601BE21 RID: 114209 RVA: 0x003F3CD7 File Offset: 0x003F1ED7
		// (set) Token: 0x0601BE22 RID: 114210 RVA: 0x003F3CDF File Offset: 0x003F1EDF
		public int Id { get; set; }

		// Token: 0x17008223 RID: 33315
		// (get) Token: 0x0601BE23 RID: 114211 RVA: 0x003F3CE8 File Offset: 0x003F1EE8
		// (set) Token: 0x0601BE24 RID: 114212 RVA: 0x003F3CF0 File Offset: 0x003F1EF0
		public int InstId { get; set; }

		// Token: 0x17008224 RID: 33316
		// (get) Token: 0x0601BE25 RID: 114213 RVA: 0x003F3CF9 File Offset: 0x003F1EF9
		// (set) Token: 0x0601BE26 RID: 114214 RVA: 0x003F3D01 File Offset: 0x003F1F01
		public int Status { get; set; }

		// Token: 0x17008225 RID: 33317
		// (get) Token: 0x0601BE27 RID: 114215 RVA: 0x003F3D0A File Offset: 0x003F1F0A
		// (set) Token: 0x0601BE28 RID: 114216 RVA: 0x003F3D12 File Offset: 0x003F1F12
		public int ChildQuestStatus { get; set; }

		// Token: 0x17008226 RID: 33318
		// (get) Token: 0x0601BE29 RID: 114217 RVA: 0x003F3D1B File Offset: 0x003F1F1B
		// (set) Token: 0x0601BE2A RID: 114218 RVA: 0x003F3D23 File Offset: 0x003F1F23
		public int CurActionIdx { get; set; }

		// Token: 0x17008227 RID: 33319
		// (get) Token: 0x0601BE2B RID: 114219 RVA: 0x003F3D2C File Offset: 0x003F1F2C
		// (set) Token: 0x0601BE2C RID: 114220 RVA: 0x003F3D34 File Offset: 0x003F1F34
		public int EndActionIdx { get; set; }

		// Token: 0x17008228 RID: 33320
		// (get) Token: 0x0601BE2D RID: 114221 RVA: 0x003F3D3D File Offset: 0x003F1F3D
		// (set) Token: 0x0601BE2E RID: 114222 RVA: 0x003F3D45 File Offset: 0x003F1F45
		public List<string> OptionGuids { get; set; }

		// Token: 0x17008229 RID: 33321
		// (get) Token: 0x0601BE2F RID: 114223 RVA: 0x003F3D4E File Offset: 0x003F1F4E
		// (set) Token: 0x0601BE30 RID: 114224 RVA: 0x003F3D56 File Offset: 0x003F1F56
		public int ErrActionIdx { get; set; }

		// Token: 0x1700822A RID: 33322
		// (get) Token: 0x0601BE31 RID: 114225 RVA: 0x003F3D5F File Offset: 0x003F1F5F
		// (set) Token: 0x0601BE32 RID: 114226 RVA: 0x003F3D67 File Offset: 0x003F1F67
		public string CurActionGuid { get; set; }

		// Token: 0x1700822B RID: 33323
		// (get) Token: 0x0601BE33 RID: 114227 RVA: 0x003F3D70 File Offset: 0x003F1F70
		// (set) Token: 0x0601BE34 RID: 114228 RVA: 0x003F3D78 File Offset: 0x003F1F78
		public string EndActionGuid { get; set; }

		// Token: 0x1700822C RID: 33324
		// (get) Token: 0x0601BE35 RID: 114229 RVA: 0x003F3D81 File Offset: 0x003F1F81
		// (set) Token: 0x0601BE36 RID: 114230 RVA: 0x003F3D89 File Offset: 0x003F1F89
		public byte NullMask { get; set; }

		// Token: 0x0601BE37 RID: 114231 RVA: 0x003F3D94 File Offset: 0x003F1F94
		public IRunningNodeStatusT()
		{
			this.Id = 0;
			this.InstId = 0;
			this.Status = 0;
			this.ChildQuestStatus = 0;
			this.CurActionIdx = 0;
			this.EndActionIdx = 0;
			this.OptionGuids = null;
			this.ErrActionIdx = 0;
			this.CurActionGuid = null;
			this.EndActionGuid = null;
			this.NullMask = 0;
		}
	}
}
