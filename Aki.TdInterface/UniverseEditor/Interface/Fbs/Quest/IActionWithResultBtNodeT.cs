using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF0 RID: 15600
	public class IActionWithResultBtNodeT
	{
		// Token: 0x17006AE6 RID: 27366
		// (get) Token: 0x060157B3 RID: 87987 RVA: 0x0031A7FC File Offset: 0x003189FC
		// (set) Token: 0x060157B4 RID: 87988 RVA: 0x0031A804 File Offset: 0x00318A04
		public EBtNode Type { get; set; }

		// Token: 0x17006AE7 RID: 27367
		// (get) Token: 0x060157B5 RID: 87989 RVA: 0x0031A80D File Offset: 0x00318A0D
		// (set) Token: 0x060157B6 RID: 87990 RVA: 0x0031A815 File Offset: 0x00318A15
		public int Id { get; set; }

		// Token: 0x17006AE8 RID: 27368
		// (get) Token: 0x060157B7 RID: 87991 RVA: 0x0031A81E File Offset: 0x00318A1E
		// (set) Token: 0x060157B8 RID: 87992 RVA: 0x0031A826 File Offset: 0x00318A26
		public string Desc { get; set; }

		// Token: 0x17006AE9 RID: 27369
		// (get) Token: 0x060157B9 RID: 87993 RVA: 0x0031A82F File Offset: 0x00318A2F
		// (set) Token: 0x060157BA RID: 87994 RVA: 0x0031A837 File Offset: 0x00318A37
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17006AEA RID: 27370
		// (get) Token: 0x060157BB RID: 87995 RVA: 0x0031A840 File Offset: 0x00318A40
		// (set) Token: 0x060157BC RID: 87996 RVA: 0x0031A848 File Offset: 0x00318A48
		public bool _FoldedForTree { get; set; }

		// Token: 0x17006AEB RID: 27371
		// (get) Token: 0x060157BD RID: 87997 RVA: 0x0031A851 File Offset: 0x00318A51
		// (set) Token: 0x060157BE RID: 87998 RVA: 0x0031A859 File Offset: 0x00318A59
		public bool Disabled { get; set; }

		// Token: 0x17006AEC RID: 27372
		// (get) Token: 0x060157BF RID: 87999 RVA: 0x0031A862 File Offset: 0x00318A62
		// (set) Token: 0x060157C0 RID: 88000 RVA: 0x0031A86A File Offset: 0x00318A6A
		public IActionInfoT Action { get; set; }

		// Token: 0x17006AED RID: 27373
		// (get) Token: 0x060157C1 RID: 88001 RVA: 0x0031A873 File Offset: 0x00318A73
		// (set) Token: 0x060157C2 RID: 88002 RVA: 0x0031A87B File Offset: 0x00318A7B
		public byte NullMask { get; set; }

		// Token: 0x060157C3 RID: 88003 RVA: 0x0031A884 File Offset: 0x00318A84
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
