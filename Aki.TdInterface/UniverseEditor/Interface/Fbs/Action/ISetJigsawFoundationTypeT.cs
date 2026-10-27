using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700B RID: 28683
	public class ISetJigsawFoundationTypeT
	{
		// Token: 0x1700D508 RID: 54536
		// (get) Token: 0x06032BCF RID: 207823 RVA: 0x006D8872 File Offset: 0x006D6A72
		// (set) Token: 0x06032BD0 RID: 207824 RVA: 0x006D887A File Offset: 0x006D6A7A
		public ESetJigsawFoundationType Type { get; set; }

		// Token: 0x06032BD1 RID: 207825 RVA: 0x006D8883 File Offset: 0x006D6A83
		public ISetJigsawFoundationTypeT()
		{
			this.Type = ESetJigsawFoundationType.SetPieceState;
		}
	}
}
