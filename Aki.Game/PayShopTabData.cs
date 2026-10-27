using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200235C RID: 9052
[NullableContext(1)]
[Nullable(0)]
public class PayShopTabData
{
	// Token: 0x060120B0 RID: 73904 RVA: 0x0046D350 File Offset: 0x0046B550
	public void Phrase(PayShopTabConfigInfo info)
	{
		this.ShopId = info.ShopId;
		this.TabId = info.TabId;
		this.Sort = info.Sort;
		this.Name = info.Name;
		this.Logic = info.Logic;
		this.Enable = info.Enable;
		this.SpriteBgPath = info.TabSelectSpritePath;
		this.TextureBgPath = info.TabContentPath;
		this.BeginTime = info.BeginTime;
		this.EndTime = info.EndTime;
		this.MoneyList = info.Money.ToList<int>();
	}

	// Token: 0x04008871 RID: 34929
	public int ShopId;

	// Token: 0x04008872 RID: 34930
	public int TabId;

	// Token: 0x04008873 RID: 34931
	public int Sort;

	// Token: 0x04008874 RID: 34932
	public string Name = "";

	// Token: 0x04008875 RID: 34933
	public int Logic;

	// Token: 0x04008876 RID: 34934
	public bool Enable = true;

	// Token: 0x04008877 RID: 34935
	public string SpriteBgPath = "";

	// Token: 0x04008878 RID: 34936
	public string TextureBgPath = "";

	// Token: 0x04008879 RID: 34937
	public long BeginTime;

	// Token: 0x0400887A RID: 34938
	public long EndTime;

	// Token: 0x0400887B RID: 34939
	public List<int> MoneyList = new List<int>();
}
