using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DC0 RID: 7616
[NullableContext(2)]
[Nullable(0)]
public class GuideStepViewData
{
	// Token: 0x17001274 RID: 4724
	// (get) Token: 0x0600E772 RID: 59250 RVA: 0x00368E3A File Offset: 0x0036703A
	public bool IsMultiAttach
	{
		get
		{
			return this.MultiAttachItems != null;
		}
	}

	// Token: 0x17001275 RID: 4725
	// (get) Token: 0x0600E773 RID: 59251 RVA: 0x00368E48 File Offset: 0x00367048
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

	// Token: 0x0600E774 RID: 59252 RVA: 0x00368F2B File Offset: 0x0036712B
	public UUIItem GetAttachedUiItem()
	{
		return this.AttachedUiItem;
	}

	// Token: 0x0600E775 RID: 59253 RVA: 0x00368F33 File Offset: 0x00367133
	public void ResetAttachedUiItem()
	{
		this.AttachedUiItem = null;
	}

	// Token: 0x0600E776 RID: 59254 RVA: 0x00368F3C File Offset: 0x0036713C
	public UUIItem GetAttachedUiItemForShow()
	{
		return this.AttachedUiItemForShow ?? this.AttachedUiItem;
	}

	// Token: 0x0600E777 RID: 59255 RVA: 0x00368F4E File Offset: 0x0036714E
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UUIItem> GetMultiAttachItems()
	{
		return this.MultiAttachItems;
	}

	// Token: 0x0600E778 RID: 59256 RVA: 0x00368F58 File Offset: 0x00367158
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

	// Token: 0x0600E779 RID: 59257 RVA: 0x00368FD8 File Offset: 0x003671D8
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

	// Token: 0x0600E77A RID: 59258 RVA: 0x00369058 File Offset: 0x00367258
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

	// Token: 0x0600E77B RID: 59259 RVA: 0x003690D5 File Offset: 0x003672D5
	[NullableContext(1)]
	public void TryLockScrollView(UUIScrollViewComponent scrollView)
	{
		this.ScrollView = scrollView;
		this.ScrollViewEnable = this.ScrollView.GetEnable();
		this.ScrollView.SetEnable(false);
	}

	// Token: 0x0600E77C RID: 59260 RVA: 0x003690FB File Offset: 0x003672FB
	public void TryUnLockScrollView()
	{
		if (this.ScrollView == null)
		{
			return;
		}
		this.ScrollView.SetEnable(this.ScrollViewEnable);
	}

	// Token: 0x0600E77D RID: 59261 RVA: 0x00369117 File Offset: 0x00367317
	public UiPanelBase GetAttachedView()
	{
		return this.AttachedView;
	}

	// Token: 0x0600E77E RID: 59262 RVA: 0x0036911F File Offset: 0x0036731F
	[NullableContext(1)]
	public void SetAttachedView(UiPanelBase value)
	{
		this.AttachedView = value;
	}

	// Token: 0x0600E77F RID: 59263 RVA: 0x00369128 File Offset: 0x00367328
	[NullableContext(1)]
	public GuideStepViewData(GuideStepInfo owner)
	{
		this.Owner = owner;
	}

	// Token: 0x0600E780 RID: 59264 RVA: 0x0036913E File Offset: 0x0036733E
	public void Clear()
	{
		this.TryUnLockScrollView();
		this.AttachedView = null;
		this.AttachedUiItem = null;
		this.AttachedUiItemForShow = null;
		this.ScrollView = null;
	}

	// Token: 0x04006B05 RID: 27397
	private bool ScrollViewEnable = true;

	// Token: 0x04006B06 RID: 27398
	private UUIScrollViewComponent ScrollView;

	// Token: 0x04006B07 RID: 27399
	private readonly GuideStepInfo Owner;

	// Token: 0x04006B08 RID: 27400
	private object ViewConfInner;

	// Token: 0x04006B09 RID: 27401
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> MultiAttachItems;

	// Token: 0x04006B0A RID: 27402
	private UiPanelBase AttachedView;

	// Token: 0x04006B0B RID: 27403
	public bool IsAttachToBattleView;

	// Token: 0x04006B0C RID: 27404
	private UUIItem AttachedUiItem;

	// Token: 0x04006B0D RID: 27405
	private UUIItem AttachedUiItemForShow;
}
