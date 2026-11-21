using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004107 RID: 16647
	public class IActionWithResultBtNodeT
	{
		// Token: 0x170070A0 RID: 28832
		// (get) Token: 0x06016CEB RID: 93419 RVA: 0x00341A74 File Offset: 0x0033FC74
		// (set) Token: 0x06016CEC RID: 93420 RVA: 0x00341A7C File Offset: 0x0033FC7C
		public EBtNode Type { get; set; }

		// Token: 0x170070A1 RID: 28833
		// (get) Token: 0x06016CED RID: 93421 RVA: 0x00341A85 File Offset: 0x0033FC85
		// (set) Token: 0x06016CEE RID: 93422 RVA: 0x00341A8D File Offset: 0x0033FC8D
		public int Id { get; set; }

		// Token: 0x170070A2 RID: 28834
		// (get) Token: 0x06016CEF RID: 93423 RVA: 0x00341A96 File Offset: 0x0033FC96
		// (set) Token: 0x06016CF0 RID: 93424 RVA: 0x00341A9E File Offset: 0x0033FC9E
		public string Desc { get; set; }

		// Token: 0x170070A3 RID: 28835
		// (get) Token: 0x06016CF1 RID: 93425 RVA: 0x00341AA7 File Offset: 0x0033FCA7
		// (set) Token: 0x06016CF2 RID: 93426 RVA: 0x00341AAF File Offset: 0x0033FCAF
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x170070A4 RID: 28836
		// (get) Token: 0x06016CF3 RID: 93427 RVA: 0x00341AB8 File Offset: 0x0033FCB8
		// (set) Token: 0x06016CF4 RID: 93428 RVA: 0x00341AC0 File Offset: 0x0033FCC0
		public bool _FoldedForTree { get; set; }

		// Token: 0x170070A5 RID: 28837
		// (get) Token: 0x06016CF5 RID: 93429 RVA: 0x00341AC9 File Offset: 0x0033FCC9
		// (set) Token: 0x06016CF6 RID: 93430 RVA: 0x00341AD1 File Offset: 0x0033FCD1
		public bool Disabled { get; set; }

		// Token: 0x170070A6 RID: 28838
		// (get) Token: 0x06016CF7 RID: 93431 RVA: 0x00341ADA File Offset: 0x0033FCDA
		// (set) Token: 0x06016CF8 RID: 93432 RVA: 0x00341AE2 File Offset: 0x0033FCE2
		public IActionInfoT Action { get; set; }

		// Token: 0x170070A7 RID: 28839
		// (get) Token: 0x06016CF9 RID: 93433 RVA: 0x00341AEB File Offset: 0x0033FCEB
		// (set) Token: 0x06016CFA RID: 93434 RVA: 0x00341AF3 File Offset: 0x0033FCF3
		public byte NullMask { get; set; }

		// Token: 0x06016CFB RID: 93435 RVA: 0x00341AFC File Offset: 0x0033FCFC
		public IActionWithResultBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.Action = null;
			this.NullMask = 0;
		}
	}
}
