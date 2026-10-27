using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Kurotato;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B60 RID: 23392
	public class KurotatoMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17008CB2 RID: 36018
		// (get) Token: 0x0603B388 RID: 242568 RVA: 0x00E1ED24 File Offset: 0x00E1CF24
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Kurotato;
			}
		}

		// Token: 0x0401EE04 RID: 126468
		public int Id;

		// Token: 0x0401EE05 RID: 126469
		public EKurotatoCardType CardType;

		// Token: 0x0401EE06 RID: 126470
		public bool? IsNewVisible;

		// Token: 0x0401EE07 RID: 126471
		public bool? IsDisable;

		// Token: 0x0401EE08 RID: 126472
		[Nullable(2)]
		public string RightTopValue;
	}
}
