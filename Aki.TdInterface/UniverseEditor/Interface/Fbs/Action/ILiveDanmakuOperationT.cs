using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E9 RID: 28905
	public class ILiveDanmakuOperationT
	{
		// Token: 0x1700D3B0 RID: 54192
		// (get) Token: 0x0603232C RID: 205612 RVA: 0x006CA5C2 File Offset: 0x006C87C2
		// (set) Token: 0x0603232D RID: 205613 RVA: 0x006CA5CA File Offset: 0x006C87CA
		public ELiveDanmakuOperationType Type { get; set; }

		// Token: 0x0603232E RID: 205614 RVA: 0x006CA5D3 File Offset: 0x006C87D3
		public ILiveDanmakuOperationT()
		{
			this.Type = ELiveDanmakuOperationType.Load;
		}
	}
}
