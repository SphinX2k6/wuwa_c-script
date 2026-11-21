using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001820 RID: 6176
[NullableContext(1)]
[Nullable(0)]
public abstract class AbstractGameplayShopExchangePopViewProxy : IGameplayShopExchangePopViewProxy
{
	// Token: 0x17001718 RID: 5912
	// (get) Token: 0x0600F286 RID: 62086 RVA: 0x004732E0 File Offset: 0x004714E0
	// (set) Token: 0x0600F287 RID: 62087 RVA: 0x004732E8 File Offset: 0x004714E8
	[Nullable(2)]
	public object ShopItemProxy { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001719 RID: 5913
	// (get) Token: 0x0600F288 RID: 62088 RVA: 0x004732F1 File Offset: 0x004714F1
	// (set) Token: 0x0600F289 RID: 62089 RVA: 0x004732F9 File Offset: 0x004714F9
	public int CurrencyId { get; set; }

	// Token: 0x1700171A RID: 5914
	// (get) Token: 0x0600F28A RID: 62090 RVA: 0x00473302 File Offset: 0x00471502
	// (set) Token: 0x0600F28B RID: 62091 RVA: 0x0047330A File Offset: 0x0047150A
	public List<int> CurrencyIdList { get; set; } = new List<int>();

	// Token: 0x1700171B RID: 5915
	// (get) Token: 0x0600F28C RID: 62092 RVA: 0x00473313 File Offset: 0x00471513
	// (set) Token: 0x0600F28D RID: 62093 RVA: 0x0047331B File Offset: 0x0047151B
	public int Price { get; set; }

	// Token: 0x1700171C RID: 5916
	// (get) Token: 0x0600F28E RID: 62094 RVA: 0x00473324 File Offset: 0x00471524
	// (set) Token: 0x0600F28F RID: 62095 RVA: 0x0047332C File Offset: 0x0047152C
	public GameplayShopTextData DescribeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x1700171D RID: 5917
	// (get) Token: 0x0600F290 RID: 62096 RVA: 0x00473335 File Offset: 0x00471535
	// (set) Token: 0x0600F291 RID: 62097 RVA: 0x0047333D File Offset: 0x0047153D
	public bool TipTitleItemVisible { get; set; }

	// Token: 0x1700171E RID: 5918
	// (get) Token: 0x0600F292 RID: 62098 RVA: 0x00473346 File Offset: 0x00471546
	// (set) Token: 0x0600F293 RID: 62099 RVA: 0x0047334E File Offset: 0x0047154E
	public bool LeftTimeItemVisible { get; set; }

	// Token: 0x1700171F RID: 5919
	// (get) Token: 0x0600F294 RID: 62100 RVA: 0x00473357 File Offset: 0x00471557
	// (set) Token: 0x0600F295 RID: 62101 RVA: 0x0047335F File Offset: 0x0047155F
	public bool LeftTimeTextVisible { get; set; }

	// Token: 0x17001720 RID: 5920
	// (get) Token: 0x0600F296 RID: 62102 RVA: 0x00473368 File Offset: 0x00471568
	// (set) Token: 0x0600F297 RID: 62103 RVA: 0x00473370 File Offset: 0x00471570
	public GameplayShopTextData LeftTimeDescTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001721 RID: 5921
	// (get) Token: 0x0600F298 RID: 62104 RVA: 0x00473379 File Offset: 0x00471579
	// (set) Token: 0x0600F299 RID: 62105 RVA: 0x00473381 File Offset: 0x00471581
	public GameplayShopTextData LeftTimeTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001722 RID: 5922
	// (get) Token: 0x0600F29A RID: 62106 RVA: 0x0047338A File Offset: 0x0047158A
	// (set) Token: 0x0600F29B RID: 62107 RVA: 0x00473392 File Offset: 0x00471592
	public bool LimitTextItemVisible { get; set; }

	// Token: 0x17001723 RID: 5923
	// (get) Token: 0x0600F29C RID: 62108 RVA: 0x0047339B File Offset: 0x0047159B
	// (set) Token: 0x0600F29D RID: 62109 RVA: 0x004733A3 File Offset: 0x004715A3
	public GameplayShopTextData LimitTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001724 RID: 5924
	// (get) Token: 0x0600F29E RID: 62110 RVA: 0x004733AC File Offset: 0x004715AC
	// (set) Token: 0x0600F29F RID: 62111 RVA: 0x004733B4 File Offset: 0x004715B4
	public bool LockItemVisible { get; set; }

	// Token: 0x17001725 RID: 5925
	// (get) Token: 0x0600F2A0 RID: 62112 RVA: 0x004733BD File Offset: 0x004715BD
	// (set) Token: 0x0600F2A1 RID: 62113 RVA: 0x004733C5 File Offset: 0x004715C5
	public GameplayShopTextData LockTextData { get; set; } = new GameplayShopTextData();

	// Token: 0x17001726 RID: 5926
	// (get) Token: 0x0600F2A2 RID: 62114 RVA: 0x004733CE File Offset: 0x004715CE
	// (set) Token: 0x0600F2A3 RID: 62115 RVA: 0x004733D6 File Offset: 0x004715D6
	public int ReSellTime { get; set; }

	// Token: 0x17001727 RID: 5927
	// (get) Token: 0x0600F2A4 RID: 62116 RVA: 0x004733DF File Offset: 0x004715DF
	// (set) Token: 0x0600F2A5 RID: 62117 RVA: 0x004733E7 File Offset: 0x004715E7
	public int BuyCount { get; set; } = 1;

	// Token: 0x17001728 RID: 5928
	// (get) Token: 0x0600F2A6 RID: 62118 RVA: 0x004733F0 File Offset: 0x004715F0
	// (set) Token: 0x0600F2A7 RID: 62119 RVA: 0x004733F8 File Offset: 0x004715F8
	public int MaxBuyCount { get; set; }

	// Token: 0x17001729 RID: 5929
	// (get) Token: 0x0600F2A8 RID: 62120 RVA: 0x00473401 File Offset: 0x00471601
	// (set) Token: 0x0600F2A9 RID: 62121 RVA: 0x00473409 File Offset: 0x00471609
	public string ExchangeTableTextId { get; set; } = "";

	// Token: 0x1700172A RID: 5930
	// (get) Token: 0x0600F2AA RID: 62122 RVA: 0x00473412 File Offset: 0x00471612
	// (set) Token: 0x0600F2AB RID: 62123 RVA: 0x0047341A File Offset: 0x0047161A
	public string ShopItemResource { get; set; } = "";

	// Token: 0x1700172B RID: 5931
	// (get) Token: 0x0600F2AC RID: 62124 RVA: 0x00473423 File Offset: 0x00471623
	// (set) Token: 0x0600F2AD RID: 62125 RVA: 0x0047342B File Offset: 0x0047162B
	[Nullable(2)]
	public string CurrencyItemResourceId { [NullableContext(2)] get; [NullableContext(2)] set; } = "";

	// Token: 0x0600F2AE RID: 62126
	public abstract void OnConfirmButtonClick(int viewId);

	// Token: 0x0600F2AF RID: 62127
	public abstract bool CheckConfirmButtonCanInteract();

	// Token: 0x0600F2B0 RID: 62128
	public abstract UiPanelBase ShopItemCreate();

	// Token: 0x0600F2B1 RID: 62129
	public abstract void ShopItemRefresh();

	// Token: 0x0600F2B2 RID: 62130
	public abstract bool CheckMoneyEnough();

	// Token: 0x0600F2B3 RID: 62131
	public abstract void OnResellTimeRefresh();
}
