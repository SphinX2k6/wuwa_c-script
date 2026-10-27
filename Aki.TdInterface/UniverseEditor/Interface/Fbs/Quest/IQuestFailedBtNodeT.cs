using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD5 RID: 16341
	public class IQuestFailedBtNodeT
	{
		// Token: 0x1700727F RID: 29311
		// (get) Token: 0x060177C1 RID: 96193 RVA: 0x00363018 File Offset: 0x00361218
		// (set) Token: 0x060177C2 RID: 96194 RVA: 0x00363020 File Offset: 0x00361220
		public EBtNode Type { get; set; }

		// Token: 0x17007280 RID: 29312
		// (get) Token: 0x060177C3 RID: 96195 RVA: 0x00363029 File Offset: 0x00361229
		// (set) Token: 0x060177C4 RID: 96196 RVA: 0x00363031 File Offset: 0x00361231
		public int Id { get; set; }

		// Token: 0x17007281 RID: 29313
		// (get) Token: 0x060177C5 RID: 96197 RVA: 0x0036303A File Offset: 0x0036123A
		// (set) Token: 0x060177C6 RID: 96198 RVA: 0x00363042 File Offset: 0x00361242
		public string Desc { get; set; }

		// Token: 0x17007282 RID: 29314
		// (get) Token: 0x060177C7 RID: 96199 RVA: 0x0036304B File Offset: 0x0036124B
		// (set) Token: 0x060177C8 RID: 96200 RVA: 0x00363053 File Offset: 0x00361253
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007283 RID: 29315
		// (get) Token: 0x060177C9 RID: 96201 RVA: 0x0036305C File Offset: 0x0036125C
		// (set) Token: 0x060177CA RID: 96202 RVA: 0x00363064 File Offset: 0x00361264
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007284 RID: 29316
		// (get) Token: 0x060177CB RID: 96203 RVA: 0x0036306D File Offset: 0x0036126D
		// (set) Token: 0x060177CC RID: 96204 RVA: 0x00363075 File Offset: 0x00361275
		public bool Disabled { get; set; }

		// Token: 0x17007285 RID: 29317
		// (get) Token: 0x060177CD RID: 96205 RVA: 0x0036307E File Offset: 0x0036127E
		// (set) Token: 0x060177CE RID: 96206 RVA: 0x00363086 File Offset: 0x00361286
		public bool ReturnTempSavePointFirst { get; set; }

		// Token: 0x17007286 RID: 29318
		// (get) Token: 0x060177CF RID: 96207 RVA: 0x0036308F File Offset: 0x0036128F
		// (set) Token: 0x060177D0 RID: 96208 RVA: 0x00363097 File Offset: 0x00361297
		public bool AutoFailed { get; set; }

		// Token: 0x17007287 RID: 29319
		// (get) Token: 0x060177D1 RID: 96209 RVA: 0x003630A0 File Offset: 0x003612A0
		// (set) Token: 0x060177D2 RID: 96210 RVA: 0x003630A8 File Offset: 0x003612A8
		public IQuestFailedConditionT FailedCondition { get; set; }

		// Token: 0x17007288 RID: 29320
		// (get) Token: 0x060177D3 RID: 96211 RVA: 0x003630B1 File Offset: 0x003612B1
		// (set) Token: 0x060177D4 RID: 96212 RVA: 0x003630B9 File Offset: 0x003612B9
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17007289 RID: 29321
		// (get) Token: 0x060177D5 RID: 96213 RVA: 0x003630C2 File Offset: 0x003612C2
		// (set) Token: 0x060177D6 RID: 96214 RVA: 0x003630CA File Offset: 0x003612CA
		public byte NullMask { get; set; }

		// Token: 0x060177D7 RID: 96215 RVA: 0x003630D4 File Offset: 0x003612D4
		public IQuestFailedBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.ReturnTempSavePointFirst = false;
			this.AutoFailed = false;
			this.FailedCondition = null;
			this.FinishActions = null;
			this.NullMask = 0;
		}
	}
}
