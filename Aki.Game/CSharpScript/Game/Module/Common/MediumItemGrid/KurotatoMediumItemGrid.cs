using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Kurotato;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B3F RID: 19263
	public class KurotatoMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17006084 RID: 24708
		// (get) Token: 0x060302D4 RID: 197332 RVA: 0x00D6F290 File Offset: 0x00D6D490
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Kurotato;
			}
		}

		// Token: 0x040198B3 RID: 104627
		public int Id;

		// Token: 0x040198B4 RID: 104628
		public EKurotatoCardType CardType;

		// Token: 0x040198B5 RID: 104629
		public bool? IsNewVisible;

		// Token: 0x040198B6 RID: 104630
		public bool? IsDisable;

		// Token: 0x040198B7 RID: 104631
		[Nullable(2)]
		public string RightTopValue;
	}
}
