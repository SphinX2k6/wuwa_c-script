using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD2 RID: 20434
	public class ICheckPlayerPositionT
	{
		// Token: 0x1700922B RID: 37419
		// (get) Token: 0x0601FDDC RID: 130524 RVA: 0x0046CE99 File Offset: 0x0046B099
		// (set) Token: 0x0601FDDD RID: 130525 RVA: 0x0046CEA1 File Offset: 0x0046B0A1
		public ECondition Type { get; set; }

		// Token: 0x1700922C RID: 37420
		// (get) Token: 0x0601FDDE RID: 130526 RVA: 0x0046CEAA File Offset: 0x0046B0AA
		// (set) Token: 0x0601FDDF RID: 130527 RVA: 0x0046CEB2 File Offset: 0x0046B0B2
		public TRangeUnion Range { get; set; }

		// Token: 0x1700922D RID: 37421
		// (get) Token: 0x0601FDE0 RID: 130528 RVA: 0x0046CEBB File Offset: 0x0046B0BB
		// (set) Token: 0x0601FDE1 RID: 130529 RVA: 0x0046CEC3 File Offset: 0x0046B0C3
		public bool IsOnRange { get; set; }

		// Token: 0x0601FDE2 RID: 130530 RVA: 0x0046CECC File Offset: 0x0046B0CC
		public ICheckPlayerPositionT()
		{
			this.Type = ECondition.CompareVar;
			this.Range = null;
			this.IsOnRange = false;
		}
	}
}
