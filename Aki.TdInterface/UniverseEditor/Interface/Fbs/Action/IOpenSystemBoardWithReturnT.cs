using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A1 RID: 29601
	public class IOpenSystemBoardWithReturnT
	{
		// Token: 0x1700D97A RID: 55674
		// (get) Token: 0x06033C3D RID: 212029 RVA: 0x006FBB65 File Offset: 0x006F9D65
		// (set) Token: 0x06033C3E RID: 212030 RVA: 0x006FBB6D File Offset: 0x006F9D6D
		public TOpenSystemBoardWithReturnUnion SystemType { get; set; }

		// Token: 0x06033C3F RID: 212031 RVA: 0x006FBB76 File Offset: 0x006F9D76
		public IOpenSystemBoardWithReturnT()
		{
			this.SystemType = null;
		}
	}
}
