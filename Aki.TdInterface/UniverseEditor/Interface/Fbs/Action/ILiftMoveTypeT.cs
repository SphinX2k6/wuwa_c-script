using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B0 RID: 28848
	public class ILiftMoveTypeT
	{
		// Token: 0x1700D359 RID: 54105
		// (get) Token: 0x06032185 RID: 205189 RVA: 0x006C7BEE File Offset: 0x006C5DEE
		// (set) Token: 0x06032186 RID: 205190 RVA: 0x006C7BF6 File Offset: 0x006C5DF6
		public ELiftMoveType Type { get; set; }

		// Token: 0x06032187 RID: 205191 RVA: 0x006C7BFF File Offset: 0x006C5DFF
		public ILiftMoveTypeT()
		{
			this.Type = ELiftMoveType.Default;
		}
	}
}
