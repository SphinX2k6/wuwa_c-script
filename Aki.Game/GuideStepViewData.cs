using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001282 RID: 4738
[NullableContext(2)]
[Nullable(0)]
public class GuideStepViewData
{
	// Token: 0x1700129E RID: 4766
	// (get) Token: 0x0600BB90 RID: 48016 RVA: 0x00374AB2 File Offset: 0x00372CB2
	public bool IsMultiAttach
	{
		get
		{
			return this.MultiAttachItems != null;
		}
	}

	// Token: 0x1700129F RID: 4767
	// (get) Token: 0x0600BB91 RID: 48017 RVA: 0x00374AC0 File Offset: 0x00372CC0
	[Nullable(1)]
	public object ViewConf
	{
		[NullableContext(1)]
		get
		{
			switch (this.Owner.Config.ContentType)
			{
			case 1:
				this.ViewConfInner = GuideConfig.Instance.GetGuideTips(this.Owner.Id);
				break;
			case 3:
				this.ViewConfInner = GuideConfig.Instance.GetGuideTutorial(this.Owner.Id);
				break;
			case 4:
				this.ViewConfInner = GuideConfig.Instance.GetGuideFocus(this.Owner.Id);
				break;
			}
			if (this.ViewConfInner == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "引导步骤id找不到引导类型数据, 清检查配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("this.Owner!.Id", this.Owner.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return this.ViewConfInner;
		}
	}

	// Token: 0x0600BB92 RID: 48018 RVA: 0x00374BA3 File Offset: 0x00372DA3
	public UUIItem GetAttachedUiItem()
	{
		return this.AttachedUiItem;
	}

	// Token: 0x0600BB93 RID: 48019 RVA: 0x00374BAB File Offset: 0x00372DAB
	public void ResetAttachedUiItem()
	{
		this.AttachedUiItem = null;
	}

	// Token: 0x0600BB94 RID: 48020 RVA: 0x00374BB4 File Offset: 0x00372DB4
	public UUIItem GetAttachedUiItemForShow()
	{
		return this.AttachedUiItemForShow ?? this.AttachedUiItem;
	}

	// Token: 0x0600BB95 RID: 48021 RVA: 0x00374BC6 File Offset: 0x00372DC6
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UUIItem> GetMultiAttachItems()
	{
		return this.MultiAttachItems;
	}

	// Token: 0x0600BB96 RID: 48022 RVA: 0x00374BD0 File Offset: 0x00372DD0
	public void SetAttachedUiItem(UUIItem uiItem)
	{
		if (this.Owner.Config.ContentType != 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("引导步骤 ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Owner.Id);
			defaultInterpolatedStringHandler.AppendLiteral(" 的界面类型不是聚焦引导, 无法添加依附的Ui节点");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AttachedUiItem = uiItem;
	}

	// Token: 0x0600BB97 RID: 48023 RVA: 0x00374C50 File Offset: 0x00372E50
	[NullableContext(1)]
	public void SetAttachedUiItemForShow(UUIItem uiItem)
	{
		if (this.Owner.Config.ContentType != 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
			defaultInterpolatedStringHandler.AppendLiteral("引导步骤 ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Owner.Id);
			defaultInterpolatedStringHandler.AppendLiteral(" 的界面类型不是聚焦引导, 无法添加依附的Ui节点(显示用)");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AttachedUiItemForShow = uiItem;
	}

	// Token: 0x0600BB98 RID: 48024 RVA: 0x00374CD0 File Offset: 0x00372ED0
	public void SetMultiAttachItems([Nullable(new byte[]
	{
		2,
		1
	})] List<UUIItem> uiItems)
	{
		if (this.Owner.Config.ContentType != 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("引导步骤 ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Owner.Id);
			defaultInterpolatedStringHandler.AppendLiteral(" 的界面类型不是聚焦引导, 无法添加依附的Ui节点");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.MultiAttachItems = uiItems;
	}

	// Token: 0x0600BB99 RID: 48025 RVA: 0x00374D4D File Offset: 0x00372F4D
	[NullableContext(1)]
	public void TryLockScrollView(UUIScrollViewComponent scrollView)
	{
		this.ScrollView = scrollView;
		this.ScrollViewEnable = this.ScrollView.GetEnable();
		this.ScrollView.SetEnable(false);
	}

	// Token: 0x0600BB9A RID: 48026 RVA: 0x00374D73 File Offset: 0x00372F73
	public void TryUnLockScrollView()
	{
		if (this.ScrollView == null)
		{
			return;
		}
		this.ScrollView.SetEnable(this.ScrollViewEnable);
	}

	// Token: 0x0600BB9B RID: 48027 RVA: 0x00374D8F File Offset: 0x00372F8F
	public UiPanelBase GetAttachedView()
	{
		return this.AttachedView;
	}

	// Token: 0x0600BB9C RID: 48028 RVA: 0x00374D97 File Offset: 0x00372F97
	[NullableContext(1)]
	public void SetAttachedView(UiPanelBase value)
	{
		this.AttachedView = value;
	}

	// Token: 0x0600BB9D RID: 48029 RVA: 0x00374DA0 File Offset: 0x00372FA0
	[NullableContext(1)]
	public GuideStepViewData(GuideStepInfo owner)
	{
		this.Owner = owner;
	}

	// Token: 0x0600BB9E RID: 48030 RVA: 0x00374DB6 File Offset: 0x00372FB6
	public void Clear()
	{
		this.TryUnLockScrollView();
		this.AttachedView = null;
		this.AttachedUiItem = null;
		this.AttachedUiItemForShow = null;
		this.ScrollView = null;
	}

	// Token: 0x04006BE6 RID: 27622
	private bool ScrollViewEnable = true;

	// Token: 0x04006BE7 RID: 27623
	private UUIScrollViewComponent ScrollView;

	// Token: 0x04006BE8 RID: 27624
	private readonly GuideStepInfo Owner;

	// Token: 0x04006BE9 RID: 27625
	private object ViewConfInner;

	// Token: 0x04006BEA RID: 27626
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> MultiAttachItems;

	// Token: 0x04006BEB RID: 27627
	private UiPanelBase AttachedView;

	// Token: 0x04006BEC RID: 27628
	public bool IsAttachToBattleView;

	// Token: 0x04006BED RID: 27629
	private UUIItem AttachedUiItem;

	// Token: 0x04006BEE RID: 27630
	private UUIItem AttachedUiItemForShow;
}
