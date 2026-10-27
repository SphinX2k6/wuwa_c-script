using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A63 RID: 27235
	public class ILoopRangeT
	{
		// Token: 0x1700CA0C RID: 51724
		// (get) Token: 0x0602FB26 RID: 195366 RVA: 0x0067DB36 File Offset: 0x0067BD36
		// (set) Token: 0x0602FB27 RID: 195367 RVA: 0x0067DB3E File Offset: 0x0067BD3E
		public string LeftMark { get; set; }

		// Token: 0x1700CA0D RID: 51725
		// (get) Token: 0x0602FB28 RID: 195368 RVA: 0x0067DB47 File Offset: 0x0067BD47
		// (set) Token: 0x0602FB29 RID: 195369 RVA: 0x0067DB4F File Offset: 0x0067BD4F
		public string RightMark { get; set; }

		// Token: 0x0602FB2A RID: 195370 RVA: 0x0067DB58 File Offset: 0x0067BD58
		public ILoopRangeT()
		{
			this.LeftMark = null;
			this.RightMark = null;
		}
	}
}
