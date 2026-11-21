using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683C RID: 26684
	public class IAwakeEntityT
	{
		// Token: 0x1700C438 RID: 50232
		// (get) Token: 0x0602D9C3 RID: 186819 RVA: 0x0063D970 File Offset: 0x0063BB70
		// (set) Token: 0x0602D9C4 RID: 186820 RVA: 0x0063D978 File Offset: 0x0063BB78
		public IAwakeWithTransformVarT Position { get; set; }

		// Token: 0x1700C439 RID: 50233
		// (get) Token: 0x0602D9C5 RID: 186821 RVA: 0x0063D981 File Offset: 0x0063BB81
		// (set) Token: 0x0602D9C6 RID: 186822 RVA: 0x0063D989 File Offset: 0x0063BB89
		public bool IsSnap { get; set; }

		// Token: 0x1700C43A RID: 50234
		// (get) Token: 0x0602D9C7 RID: 186823 RVA: 0x0063D992 File Offset: 0x0063BB92
		// (set) Token: 0x0602D9C8 RID: 186824 RVA: 0x0063D99A File Offset: 0x0063BB9A
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C43B RID: 50235
		// (get) Token: 0x0602D9C9 RID: 186825 RVA: 0x0063D9A3 File Offset: 0x0063BBA3
		// (set) Token: 0x0602D9CA RID: 186826 RVA: 0x0063D9AB File Offset: 0x0063BBAB
		public byte NullMask { get; set; }

		// Token: 0x0602D9CB RID: 186827 RVA: 0x0063D9B4 File Offset: 0x0063BBB4
		public IAwakeEntityT()
		{
			this.Position = null;
			this.IsSnap = false;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}
