using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004673 RID: 18035
	public class IGoToNodeT
	{
		// Token: 0x17008012 RID: 32786
		// (get) Token: 0x0601B609 RID: 112137 RVA: 0x003E44A4 File Offset: 0x003E26A4
		// (set) Token: 0x0601B60A RID: 112138 RVA: 0x003E44AC File Offset: 0x003E26AC
		public EGmCommand Type { get; set; }

		// Token: 0x17008013 RID: 32787
		// (get) Token: 0x0601B60B RID: 112139 RVA: 0x003E44B5 File Offset: 0x003E26B5
		// (set) Token: 0x0601B60C RID: 112140 RVA: 0x003E44BD File Offset: 0x003E26BD
		public EGoToNodeTreeType TreeType { get; set; }

		// Token: 0x17008014 RID: 32788
		// (get) Token: 0x0601B60D RID: 112141 RVA: 0x003E44C6 File Offset: 0x003E26C6
		// (set) Token: 0x0601B60E RID: 112142 RVA: 0x003E44CE File Offset: 0x003E26CE
		public int TreeId { get; set; }

		// Token: 0x17008015 RID: 32789
		// (get) Token: 0x0601B60F RID: 112143 RVA: 0x003E44D7 File Offset: 0x003E26D7
		// (set) Token: 0x0601B610 RID: 112144 RVA: 0x003E44DF File Offset: 0x003E26DF
		public int NodeId { get; set; }

		// Token: 0x0601B611 RID: 112145 RVA: 0x003E44E8 File Offset: 0x003E26E8
		public IGoToNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.TreeType = EGoToNodeTreeType.None;
			this.TreeId = 0;
			this.NodeId = 0;
		}
	}
}
