using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A4 RID: 29604
	public class IOpenSystemBoardWithReturnTypeT
	{
		// Token: 0x1700D97D RID: 55677
		// (get) Token: 0x06033C4F RID: 212047 RVA: 0x006FBD12 File Offset: 0x006F9F12
		// (set) Token: 0x06033C50 RID: 212048 RVA: 0x006FBD1A File Offset: 0x006F9F1A
		public ESystemType Type { get; set; }

		// Token: 0x06033C51 RID: 212049 RVA: 0x006FBD23 File Offset: 0x006F9F23
		public IOpenSystemBoardWithReturnTypeT()
		{
			this.Type = ESystemType.Shop;
		}
	}
}
