using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C5 RID: 21445
	public class IAnEventT
	{
		// Token: 0x170097B0 RID: 38832
		// (get) Token: 0x060217B7 RID: 137143 RVA: 0x0049E2F5 File Offset: 0x0049C4F5
		// (set) Token: 0x060217B8 RID: 137144 RVA: 0x0049E2FD File Offset: 0x0049C4FD
		public ESceneItemSeqEventCbType Type { get; set; }

		// Token: 0x170097B1 RID: 38833
		// (get) Token: 0x060217B9 RID: 137145 RVA: 0x0049E306 File Offset: 0x0049C506
		// (set) Token: 0x060217BA RID: 137146 RVA: 0x0049E30E File Offset: 0x0049C50E
		public string EventName { get; set; }

		// Token: 0x170097B2 RID: 38834
		// (get) Token: 0x060217BB RID: 137147 RVA: 0x0049E317 File Offset: 0x0049C517
		// (set) Token: 0x060217BC RID: 137148 RVA: 0x0049E31F File Offset: 0x0049C51F
		public IActionInfoT Action { get; set; }

		// Token: 0x060217BD RID: 137149 RVA: 0x0049E328 File Offset: 0x0049C528
		public IAnEventT()
		{
			this.Type = ESceneItemSeqEventCbType.ANS;
			this.EventName = null;
			this.Action = null;
		}
	}
}
