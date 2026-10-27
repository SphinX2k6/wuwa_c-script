using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3D RID: 27709
	public class IOpenSystemBoardWithReturnTypeT
	{
		// Token: 0x1700CE62 RID: 52834
		// (get) Token: 0x06030CF6 RID: 199926 RVA: 0x006A1852 File Offset: 0x0069FA52
		// (set) Token: 0x06030CF7 RID: 199927 RVA: 0x006A185A File Offset: 0x0069FA5A
		public ESystemType Type { get; set; }

		// Token: 0x06030CF8 RID: 199928 RVA: 0x006A1863 File Offset: 0x0069FA63
		public IOpenSystemBoardWithReturnTypeT()
		{
			this.Type = ESystemType.Shop;
		}
	}
}
