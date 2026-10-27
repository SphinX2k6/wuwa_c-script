using System;
using CSharpScript.Game.Module.Kurotato;

// Token: 0x020019A3 RID: 6563
public class KurotatoSmallItemGrid : SmallItemGridBase
{
	// Token: 0x17001008 RID: 4104
	// (get) Token: 0x0600BF86 RID: 49030 RVA: 0x002B3FF3 File Offset: 0x002B21F3
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Kurotato;
		}
	}

	// Token: 0x04005610 RID: 22032
	public int Id;

	// Token: 0x04005611 RID: 22033
	public EKurotatoCardType CardType;

	// Token: 0x04005612 RID: 22034
	public bool? IsReceivedVisible;
}
