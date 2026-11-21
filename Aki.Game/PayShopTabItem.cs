using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E7A RID: 3706
[NullableContext(1)]
[Nullable(0)]
public class PayShopTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600948B RID: 38027 RVA: 0x002C10CB File Offset: 0x002BF2CB
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIText)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
	}

	// Token: 0x0600948C RID: 38028 RVA: 0x002C1109 File Offset: 0x002BF309
	public UUIText GetNameTextComponent()
	{
		return base.GetText(5);
	}

	// Token: 0x0600948D RID: 38029 RVA: 0x002C1114 File Offset: 0x002BF314
	public UniTask RefreshContentItem(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopTabItem.<RefreshContentItem>d__6 <RefreshContentItem>d__;
		<RefreshContentItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshContentItem>d__.<>4__this = this;
		<RefreshContentItem>d__.payShopId = payShopId;
		<RefreshContentItem>d__.<>1__state = -1;
		<RefreshContentItem>d__.<>t__builder.Start<PayShopTabItem.<RefreshContentItem>d__6>(ref <RefreshContentItem>d__);
		return <RefreshContentItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600948E RID: 38030 RVA: 0x002C115F File Offset: 0x002BF35F
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x0600948F RID: 38031 RVA: 0x002C1170 File Offset: 0x002BF370
	public override void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.Refresh(data, isSelected, gridIndex);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(false);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x06009490 RID: 38032 RVA: 0x002C11B8 File Offset: 0x002BF3B8
	public override void BindRedDot(ERedDotName redDotName, int? uId = 0)
	{
		base.BindRedDot(redDotName, uId);
		this.RedDotId = uId;
	}

	// Token: 0x06009491 RID: 38033 RVA: 0x002C11C9 File Offset: 0x002BF3C9
	public override void UnBindRedDot()
	{
		base.UnBindGivenUid(this.RedDotId);
	}

	// Token: 0x04005723 RID: 22307
	private int? RedDotId;

	// Token: 0x04005724 RID: 22308
	private readonly Dictionary<PayShopDefine.EPayShopTabType, UUIItem> ContentItemMap = new Dictionary<PayShopDefine.EPayShopTabType, UUIItem>();

	// Token: 0x04005725 RID: 22309
	private PayShopDefine.EPayShopTabType? CurrentPayShopId;

	// Token: 0x02007078 RID: 28792
	[NullableContext(0)]
	private class ECommonTabItem
	{
		// Token: 0x04024AB2 RID: 150194
		public const int NameText = 5;

		// Token: 0x04024AB3 RID: 150195
		public const int ContentItem = 6;
	}
}
