using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3C RID: 27708
	public class IDisableAllPlayerOperationT
	{
		// Token: 0x1700CB03 RID: 51971
		// (get) Token: 0x0602FAE2 RID: 195298 RVA: 0x0067E8D4 File Offset: 0x0067CAD4
		// (set) Token: 0x0602FAE3 RID: 195299 RVA: 0x0067E8DC File Offset: 0x0067CADC
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700CB04 RID: 51972
		// (get) Token: 0x0602FAE4 RID: 195300 RVA: 0x0067E8E5 File Offset: 0x0067CAE5
		// (set) Token: 0x0602FAE5 RID: 195301 RVA: 0x0067E8ED File Offset: 0x0067CAED
		public EDisplayModeInPlayerOp DisplayMode { get; set; }

		// Token: 0x1700CB05 RID: 51973
		// (get) Token: 0x0602FAE6 RID: 195302 RVA: 0x0067E8F6 File Offset: 0x0067CAF6
		// (set) Token: 0x0602FAE7 RID: 195303 RVA: 0x0067E8FE File Offset: 0x0067CAFE
		public bool IsUiFadeEffect { get; set; }

		// Token: 0x1700CB06 RID: 51974
		// (get) Token: 0x0602FAE8 RID: 195304 RVA: 0x0067E907 File Offset: 0x0067CB07
		// (set) Token: 0x0602FAE9 RID: 195305 RVA: 0x0067E90F File Offset: 0x0067CB0F
		public byte NullMask { get; set; }

		// Token: 0x0602FAEA RID: 195306 RVA: 0x0067E918 File Offset: 0x0067CB18
		public IDisableAllPlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
			this.DisplayMode = EDisplayModeInPlayerOp.ShowUi;
			this.IsUiFadeEffect = false;
			this.NullMask = 0;
		}
	}
}
