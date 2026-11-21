using System;
using CSharpScript.Game.Module.Kurotato;

// Token: 0x02000E60 RID: 3680
public class KurotatoSmallItemGrid : SmallItemGridBase
{
	// Token: 0x1700102C RID: 4140
	// (get) Token: 0x0600938E RID: 37774 RVA: 0x002BEF77 File Offset: 0x002BD177
	public override ESmallItemGridType Type
	{
		get
		{
			return ESmallItemGridType.Kurotato;
		}
	}

	// Token: 0x040056BF RID: 22207
	public int Id;

	// Token: 0x040056C0 RID: 22208
	public EKurotatoCardType CardType;

	// Token: 0x040056C1 RID: 22209
	public bool? IsReceivedVisible;
}
