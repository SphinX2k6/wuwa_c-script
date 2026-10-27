using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E2 RID: 27106
	public class ILeisureInteractT
	{
		// Token: 0x1700C91F RID: 51487
		// (get) Token: 0x0602F661 RID: 194145 RVA: 0x00674F1D File Offset: 0x0067311D
		// (set) Token: 0x0602F662 RID: 194146 RVA: 0x00674F25 File Offset: 0x00673125
		public TLeisureInteractOptionUnion Option { get; set; }

		// Token: 0x1700C920 RID: 51488
		// (get) Token: 0x0602F663 RID: 194147 RVA: 0x00674F2E File Offset: 0x0067312E
		// (set) Token: 0x0602F664 RID: 194148 RVA: 0x00674F36 File Offset: 0x00673136
		public int SceneEntity { get; set; }

		// Token: 0x1700C921 RID: 51489
		// (get) Token: 0x0602F665 RID: 194149 RVA: 0x00674F3F File Offset: 0x0067313F
		// (set) Token: 0x0602F666 RID: 194150 RVA: 0x00674F47 File Offset: 0x00673147
		public byte NullMask { get; set; }

		// Token: 0x0602F667 RID: 194151 RVA: 0x00674F50 File Offset: 0x00673150
		public ILeisureInteractT()
		{
			this.Option = null;
			this.SceneEntity = 0;
			this.NullMask = 0;
		}
	}
}
