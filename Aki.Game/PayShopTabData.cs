using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001841 RID: 6209
[NullableContext(1)]
[Nullable(0)]
public class PayShopTabData
{
	// Token: 0x0600F560 RID: 62816 RVA: 0x0047A410 File Offset: 0x00478610
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
		this.MoneyList = new List<int>(info.Money);
	}

	// Token: 0x040089B6 RID: 35254
	public int ShopId;

	// Token: 0x040089B7 RID: 35255
	public int TabId;

	// Token: 0x040089B8 RID: 35256
	public int Sort;

	// Token: 0x040089B9 RID: 35257
	public string Name = "";

	// Token: 0x040089BA RID: 35258
	public int Logic;

	// Token: 0x040089BB RID: 35259
	public bool Enable = true;

	// Token: 0x040089BC RID: 35260
	public string SpriteBgPath = "";

	// Token: 0x040089BD RID: 35261
	public string TextureBgPath = "";

	// Token: 0x040089BE RID: 35262
	public long BeginTime;

	// Token: 0x040089BF RID: 35263
	public long EndTime;

	// Token: 0x040089C0 RID: 35264
	public List<int> MoneyList = new List<int>();
}
