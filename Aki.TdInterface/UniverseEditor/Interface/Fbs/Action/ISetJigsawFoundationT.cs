using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007008 RID: 28680
	public class ISetJigsawFoundationT
	{
		// Token: 0x1700D505 RID: 54533
		// (get) Token: 0x06032BBD RID: 207805 RVA: 0x006D86E5 File Offset: 0x006D68E5
		// (set) Token: 0x06032BBE RID: 207806 RVA: 0x006D86ED File Offset: 0x006D68ED
		public ISetPieceStateT Config { get; set; }

		// Token: 0x06032BBF RID: 207807 RVA: 0x006D86F6 File Offset: 0x006D68F6
		public ISetJigsawFoundationT()
		{
			this.Config = null;
		}
	}
}
