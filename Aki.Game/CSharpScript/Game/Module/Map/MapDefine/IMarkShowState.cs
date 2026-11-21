using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200453B RID: 17723
	public interface IMarkShowState
	{
		// Token: 0x170059AC RID: 22956
		// (get) Token: 0x0602CADC RID: 183004
		// (set) Token: 0x0602CADD RID: 183005
		int Id { get; set; }

		// Token: 0x170059AD RID: 22957
		// (get) Token: 0x0602CADE RID: 183006
		// (set) Token: 0x0602CADF RID: 183007
		bool NeedFocus { get; set; }

		// Token: 0x170059AE RID: 22958
		// (get) Token: 0x0602CAE0 RID: 183008
		// (set) Token: 0x0602CAE1 RID: 183009
		MapMarkShowFlag ShowFlag { get; set; }
	}
}
