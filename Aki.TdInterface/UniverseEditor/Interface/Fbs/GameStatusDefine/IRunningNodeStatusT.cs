using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B6F RID: 19311
	public class IRunningNodeStatusT
	{
		// Token: 0x17008863 RID: 34915
		// (get) Token: 0x0601D5F6 RID: 120310 RVA: 0x0041FF73 File Offset: 0x0041E173
		// (set) Token: 0x0601D5F7 RID: 120311 RVA: 0x0041FF7B File Offset: 0x0041E17B
		public int Id { get; set; }

		// Token: 0x17008864 RID: 34916
		// (get) Token: 0x0601D5F8 RID: 120312 RVA: 0x0041FF84 File Offset: 0x0041E184
		// (set) Token: 0x0601D5F9 RID: 120313 RVA: 0x0041FF8C File Offset: 0x0041E18C
		public int InstId { get; set; }

		// Token: 0x17008865 RID: 34917
		// (get) Token: 0x0601D5FA RID: 120314 RVA: 0x0041FF95 File Offset: 0x0041E195
		// (set) Token: 0x0601D5FB RID: 120315 RVA: 0x0041FF9D File Offset: 0x0041E19D
		public int Status { get; set; }

		// Token: 0x17008866 RID: 34918
		// (get) Token: 0x0601D5FC RID: 120316 RVA: 0x0041FFA6 File Offset: 0x0041E1A6
		// (set) Token: 0x0601D5FD RID: 120317 RVA: 0x0041FFAE File Offset: 0x0041E1AE
		public int ChildQuestStatus { get; set; }

		// Token: 0x17008867 RID: 34919
		// (get) Token: 0x0601D5FE RID: 120318 RVA: 0x0041FFB7 File Offset: 0x0041E1B7
		// (set) Token: 0x0601D5FF RID: 120319 RVA: 0x0041FFBF File Offset: 0x0041E1BF
		public int CurActionIdx { get; set; }

		// Token: 0x17008868 RID: 34920
		// (get) Token: 0x0601D600 RID: 120320 RVA: 0x0041FFC8 File Offset: 0x0041E1C8
		// (set) Token: 0x0601D601 RID: 120321 RVA: 0x0041FFD0 File Offset: 0x0041E1D0
		public int EndActionIdx { get; set; }

		// Token: 0x17008869 RID: 34921
		// (get) Token: 0x0601D602 RID: 120322 RVA: 0x0041FFD9 File Offset: 0x0041E1D9
		// (set) Token: 0x0601D603 RID: 120323 RVA: 0x0041FFE1 File Offset: 0x0041E1E1
		public List<string> OptionGuids { get; set; }

		// Token: 0x1700886A RID: 34922
		// (get) Token: 0x0601D604 RID: 120324 RVA: 0x0041FFEA File Offset: 0x0041E1EA
		// (set) Token: 0x0601D605 RID: 120325 RVA: 0x0041FFF2 File Offset: 0x0041E1F2
		public int ErrActionIdx { get; set; }

		// Token: 0x1700886B RID: 34923
		// (get) Token: 0x0601D606 RID: 120326 RVA: 0x0041FFFB File Offset: 0x0041E1FB
		// (set) Token: 0x0601D607 RID: 120327 RVA: 0x00420003 File Offset: 0x0041E203
		public string CurActionGuid { get; set; }

		// Token: 0x1700886C RID: 34924
		// (get) Token: 0x0601D608 RID: 120328 RVA: 0x0042000C File Offset: 0x0041E20C
		// (set) Token: 0x0601D609 RID: 120329 RVA: 0x00420014 File Offset: 0x0041E214
		public string EndActionGuid { get; set; }

		// Token: 0x1700886D RID: 34925
		// (get) Token: 0x0601D60A RID: 120330 RVA: 0x0042001D File Offset: 0x0041E21D
		// (set) Token: 0x0601D60B RID: 120331 RVA: 0x00420025 File Offset: 0x0041E225
		public byte NullMask { get; set; }

		// Token: 0x0601D60C RID: 120332 RVA: 0x00420030 File Offset: 0x0041E230
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
