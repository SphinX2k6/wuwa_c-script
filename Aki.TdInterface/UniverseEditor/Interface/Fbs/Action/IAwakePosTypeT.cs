using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D1 RID: 25041
	public class IAwakePosTypeT
	{
		// Token: 0x1700BABB RID: 47803
		// (get) Token: 0x0602B294 RID: 176788 RVA: 0x005F310A File Offset: 0x005F130A
		// (set) Token: 0x0602B295 RID: 176789 RVA: 0x005F3112 File Offset: 0x005F1312
		public EAwakePosType Type { get; set; }

		// Token: 0x0602B296 RID: 176790 RVA: 0x005F311B File Offset: 0x005F131B
		public IAwakePosTypeT()
		{
			this.Type = EAwakePosType.TransformVar;
		}
	}
}
