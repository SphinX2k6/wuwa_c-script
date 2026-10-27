using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3A RID: 27706
	public class IOpenSystemBoardWithReturnT
	{
		// Token: 0x1700CE5F RID: 52831
		// (get) Token: 0x06030CE4 RID: 199908 RVA: 0x006A16A5 File Offset: 0x0069F8A5
		// (set) Token: 0x06030CE5 RID: 199909 RVA: 0x006A16AD File Offset: 0x0069F8AD
		public TOpenSystemBoardWithReturnUnion SystemType { get; set; }

		// Token: 0x06030CE6 RID: 199910 RVA: 0x006A16B6 File Offset: 0x0069F8B6
		public IOpenSystemBoardWithReturnT()
		{
			this.SystemType = null;
		}
	}
}
