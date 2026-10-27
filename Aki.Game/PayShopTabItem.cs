using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019BC RID: 6588
[NullableContext(1)]
[Nullable(0)]
public class PayShopTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600C081 RID: 49281 RVA: 0x002B613B File Offset: 0x002B433B
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIText)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
	}

	// Token: 0x0600C082 RID: 49282 RVA: 0x002B6179 File Offset: 0x002B4379
	public UUIText GetNameTextComponent()
	{
		return base.GetText(5);
	}

	// Token: 0x0600C083 RID: 49283 RVA: 0x002B6184 File Offset: 0x002B4384
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

	// Token: 0x0600C084 RID: 49284 RVA: 0x002B61CF File Offset: 0x002B43CF
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x0600C085 RID: 49285 RVA: 0x002B61E0 File Offset: 0x002B43E0
	public override void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.Refresh(data, isSelected, gridIndex);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(false);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600C086 RID: 49286 RVA: 0x002B6228 File Offset: 0x002B4428
	public override void BindRedDot(ERedDotName redDotName, int? uId = 0)
	{
		base.BindRedDot(redDotName, uId);
		this.RedDotId = uId;
	}

	// Token: 0x0600C087 RID: 49287 RVA: 0x002B6239 File Offset: 0x002B4439
	public override void UnBindRedDot()
	{
		base.UnBindGivenUid(this.RedDotId);
	}

	// Token: 0x04005671 RID: 22129
	private int? RedDotId;

	// Token: 0x04005672 RID: 22130
	private readonly Dictionary<PayShopDefine.EPayShopTabType, UUIItem> ContentItemMap = new Dictionary<PayShopDefine.EPayShopTabType, UUIItem>();

	// Token: 0x04005673 RID: 22131
	private PayShopDefine.EPayShopTabType? CurrentPayShopId;

	// Token: 0x02007EE9 RID: 32489
	[NullableContext(0)]
	private class ECommonTabItem
	{
		// Token: 0x04029775 RID: 169845
		public const int NameText = 5;

		// Token: 0x04029776 RID: 169846
		public const int ContentItem = 6;
	}
}
