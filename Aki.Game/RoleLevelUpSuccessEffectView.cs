using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002891 RID: 10385
public class RoleLevelUpSuccessEffectView : UiViewBase
{
	// Token: 0x06015609 RID: 87561 RVA: 0x00563783 File Offset: 0x00561983
	[NullableContext(1)]
	public RoleLevelUpSuccessEffectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601560A RID: 87562 RVA: 0x0056378C File Offset: 0x0056198C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickButton)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickButton))
		};
	}

	// Token: 0x0601560B RID: 87563 RVA: 0x00563864 File Offset: 0x00561A64
	protected override void OnBeforeCreate()
	{
		if (this.OpenParam == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.YYZ, "RoleLevelUpSuccessEffectView 打开失败,未传入界面数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.Data = (ILevelUpSuccessEffectData)this.OpenParam;
		this.SetAudioInternal();
	}

	// Token: 0x0601560C RID: 87564 RVA: 0x005638B0 File Offset: 0x00561AB0
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		this.EffectTextLayout = new GenericScrollViewNew<SuccessDescriptionItem, SingleText>(base.GetScrollViewWithScrollbar(0), new Func<SuccessDescriptionItem>(this.CreateTextItem), item.GetOwner() as AUIBaseActor, false, null);
	}

	// Token: 0x0601560D RID: 87565 RVA: 0x005638F0 File Offset: 0x00561AF0
	protected override void OnBeforeShow()
	{
		this.SetTitleInternal();
		this.SetViewContentInternal();
		this.SetTipsTextInternal();
	}

	// Token: 0x0601560E RID: 87566 RVA: 0x00563904 File Offset: 0x00561B04
	private void SetAudioInternal()
	{
		string audioId = this.Data.AudioId;
		if (audioId != null)
		{
			string path = AudioConfig.Instance.GetAudioPath(audioId).Value.Path;
			base.SetAudioEvent(path);
		}
	}

	// Token: 0x0601560F RID: 87567 RVA: 0x00563944 File Offset: 0x00561B44
	private void OnClickButton()
	{
		Action clickFunction = this.Data.ClickFunction;
		if (clickFunction != null)
		{
			clickFunction();
		}
		base.CloseMe(null);
	}

	// Token: 0x06015610 RID: 87568 RVA: 0x0056396D File Offset: 0x00561B6D
	[NullableContext(1)]
	private SuccessDescriptionItem CreateTextItem()
	{
		return new SuccessDescriptionItem();
	}

	// Token: 0x06015611 RID: 87569 RVA: 0x00563974 File Offset: 0x00561B74
	private void SetTipsTextInternal()
	{
		string key = this.Data.ClickText ?? "Text_BackToView_Text";
		base.GetText(3).ShowTextNew(key);
	}

	// Token: 0x06015612 RID: 87570 RVA: 0x005639A4 File Offset: 0x00561BA4
	private void SetTitleInternal()
	{
		string key = this.Data.Title ?? "Text_ActivedSucceed_Text";
		base.GetText(2).ShowTextNew(key);
	}

	// Token: 0x06015613 RID: 87571 RVA: 0x005639D4 File Offset: 0x00561BD4
	private void SetViewContentInternal()
	{
		if (this.EffectTextLayout != null)
		{
			List<SingleText> textList = this.Data.TextList;
			if (textList != null)
			{
				this.EffectTextLayout.RefreshByData(textList, null, false);
				return;
			}
			base.GetScrollViewWithScrollbar(0).RootUIComp.Get().SetUIActive(false);
		}
	}

	// Token: 0x04009FB8 RID: 40888
	[Nullable(2)]
	private ILevelUpSuccessEffectData Data;

	// Token: 0x04009FB9 RID: 40889
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<SuccessDescriptionItem, SingleText> EffectTextLayout;

	// Token: 0x02008E91 RID: 36497
	public enum ERoleSuccessEffectNode
	{
		// Token: 0x0402E3C7 RID: 189383
		TextScrollLayout,
		// Token: 0x0402E3C8 RID: 189384
		TextItem,
		// Token: 0x0402E3C9 RID: 189385
		Title,
		// Token: 0x0402E3CA RID: 189386
		TipsText,
		// Token: 0x0402E3CB RID: 189387
		TipsButton,
		// Token: 0x0402E3CC RID: 189388
		TipsButton2
	}
}
