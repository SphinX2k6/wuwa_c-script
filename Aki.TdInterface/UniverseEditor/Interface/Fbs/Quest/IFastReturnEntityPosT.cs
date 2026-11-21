using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004257 RID: 16983
	public class IFastReturnEntityPosT
	{
		// Token: 0x170073D3 RID: 29651
		// (get) Token: 0x06017A75 RID: 96885 RVA: 0x0035FC6D File Offset: 0x0035DE6D
		// (set) Token: 0x06017A76 RID: 96886 RVA: 0x0035FC75 File Offset: 0x0035DE75
		public EFastReturnPosType Type { get; set; }

		// Token: 0x170073D4 RID: 29652
		// (get) Token: 0x06017A77 RID: 96887 RVA: 0x0035FC7E File Offset: 0x0035DE7E
		// (set) Token: 0x06017A78 RID: 96888 RVA: 0x0035FC86 File Offset: 0x0035DE86
		public int EntityId { get; set; }

		// Token: 0x170073D5 RID: 29653
		// (get) Token: 0x06017A79 RID: 96889 RVA: 0x0035FC8F File Offset: 0x0035DE8F
		// (set) Token: 0x06017A7A RID: 96890 RVA: 0x0035FC97 File Offset: 0x0035DE97
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x06017A7B RID: 96891 RVA: 0x0035FCA0 File Offset: 0x0035DEA0
		public IFastReturnEntityPosT()
		{
			this.Type = EFastReturnPosType.EntityPos;
			this.EntityId = 0;
			this.TransitionOption = null;
		}
	}
}
