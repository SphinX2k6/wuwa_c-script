using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B3 RID: 28851
	public class ILiftMoveTypeCircularT
	{
		// Token: 0x1700D35C RID: 54108
		// (get) Token: 0x06032197 RID: 205207 RVA: 0x006C7D66 File Offset: 0x006C5F66
		// (set) Token: 0x06032198 RID: 205208 RVA: 0x006C7D6E File Offset: 0x006C5F6E
		public ELiftMoveType Type { get; set; }

		// Token: 0x06032199 RID: 205209 RVA: 0x006C7D77 File Offset: 0x006C5F77
		public ILiftMoveTypeCircularT()
		{
			this.Type = ELiftMoveType.Default;
		}
	}
}
