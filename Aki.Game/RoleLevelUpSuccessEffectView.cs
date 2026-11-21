using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E0C RID: 7692
public class RoleLevelUpSuccessEffectView : UiViewBase
{
	// Token: 0x06013007 RID: 77831 RVA: 0x0058E4DF File Offset: 0x0058C6DF
	[NullableContext(1)]
	public RoleLevelUpSuccessEffectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013008 RID: 77832 RVA: 0x0058E4E8 File Offset: 0x0058C6E8
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

	// Token: 0x06013009 RID: 77833 RVA: 0x0058E5C0 File Offset: 0x0058C7C0
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

	// Token: 0x0601300A RID: 77834 RVA: 0x0058E60C File Offset: 0x0058C80C
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		this.EffectTextLayout = new GenericScrollViewNew<SuccessDescriptionItem, SingleText>(base.GetScrollViewWithScrollbar(0), new Func<SuccessDescriptionItem>(this.CreateTextItem), item.GetOwner() as AUIBaseActor, false, null);
	}

	// Token: 0x0601300B RID: 77835 RVA: 0x0058E64C File Offset: 0x0058C84C
	protected override void OnBeforeShow()
	{
		this.SetTitleInternal();
		this.SetViewContentInternal();
		this.SetTipsTextInternal();
	}

	// Token: 0x0601300C RID: 77836 RVA: 0x0058E660 File Offset: 0x0058C860
	private void SetAudioInternal()
	{
		string audioId = this.Data.AudioId;
		if (audioId != null)
		{
			string path = AudioConfig.Instance.GetAudioPath(audioId).Value.Path;
			base.SetAudioEvent(path);
		}
	}

	// Token: 0x0601300D RID: 77837 RVA: 0x0058E6A0 File Offset: 0x0058C8A0
	private void OnClickButton()
	{
		Action clickFunction = this.Data.ClickFunction;
		if (clickFunction != null)
		{
			clickFunction();
		}
		base.CloseMe(null);
	}

	// Token: 0x0601300E RID: 77838 RVA: 0x0058E6C9 File Offset: 0x0058C8C9
	[NullableContext(1)]
	private SuccessDescriptionItem CreateTextItem()
	{
		return new SuccessDescriptionItem();
	}

	// Token: 0x0601300F RID: 77839 RVA: 0x0058E6D0 File Offset: 0x0058C8D0
	private void SetTipsTextInternal()
	{
		string key = this.Data.ClickText ?? "Text_BackToView_Text";
		base.GetText(3).ShowTextNew(key);
	}

	// Token: 0x06013010 RID: 77840 RVA: 0x0058E700 File Offset: 0x0058C900
	private void SetTitleInternal()
	{
		string key = this.Data.Title ?? "Text_ActivedSucceed_Text";
		base.GetText(2).ShowTextNew(key);
	}

	// Token: 0x06013011 RID: 77841 RVA: 0x0058E730 File Offset: 0x0058C930
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

	// Token: 0x0400A3A1 RID: 41889
	[Nullable(2)]
	private ILevelUpSuccessEffectData Data;

	// Token: 0x0400A3A2 RID: 41890
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<SuccessDescriptionItem, SingleText> EffectTextLayout;

	// Token: 0x020080D7 RID: 32983
	public enum ERoleSuccessEffectNode
	{
		// Token: 0x04029AC1 RID: 170689
		TextScrollLayout,
		// Token: 0x04029AC2 RID: 170690
		TextItem,
		// Token: 0x04029AC3 RID: 170691
		Title,
		// Token: 0x04029AC4 RID: 170692
		TipsText,
		// Token: 0x04029AC5 RID: 170693
		TipsButton,
		// Token: 0x04029AC6 RID: 170694
		TipsButton2
	}
}
