using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016CB RID: 5835
public class AdviceAllViewShowContent : UiPanelBase
{
	// Token: 0x0600A6EB RID: 42731 RVA: 0x00256A0B File Offset: 0x00254C0B
	[NullableContext(1)]
	public AdviceAllViewShowContent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A6EC RID: 42732 RVA: 0x00256A20 File Offset: 0x00254C20
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
	}

	// Token: 0x0600A6ED RID: 42733 RVA: 0x00256B00 File Offset: 0x00254D00
	protected override void OnStart()
	{
		base.GetExtendToggle(6).RootUIComp.Get().SetUIActive(false);
		base.GetExtendToggle(7).RootUIComp.Get().SetUIActive(false);
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIText text2 = base.GetText(8);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
		EventSystem.Instance.Add(EEventName.OnSelectAdviceExpression, new Action(this.RefreshExpression));
		EventSystem.Instance.Add(EEventName.OnSelectAdviceWord, new Action(this.RefreshText));
		EventSystem.Instance.Add(EEventName.OnChangeAdviceWord, new Action(this.RefreshText));
		this.RefreshPlayerName();
		this.RefreshExpression();
		this.RefreshText();
	}

	// Token: 0x0600A6EE RID: 42734 RVA: 0x00256BD0 File Offset: 0x00254DD0
	private void RefreshText()
	{
		if (AdviceModel.Instance.CurrentLineModel == ELineMode.MutiLine)
		{
			UUIText text = base.GetText(8);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			UUIText text2 = base.GetText(8);
			if (text2 != null)
			{
				text2.SetText(AdviceModel.Instance.GetSecondLineText(), true);
			}
		}
		else
		{
			UUIText text3 = base.GetText(8);
			if (text3 != null)
			{
				text3.SetUIActive(false);
			}
		}
		string firstLineText = AdviceModel.Instance.GetFirstLineText();
		UUIText text4 = base.GetText(4);
		if (text4 == null)
		{
			return;
		}
		text4.SetText(firstLineText, true);
	}

	// Token: 0x0600A6EF RID: 42735 RVA: 0x00256C50 File Offset: 0x00254E50
	private void RefreshPlayerName()
	{
		string playerName = FunctionModel.Instance.GetPlayerName();
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(playerName ?? "", true);
	}

	// Token: 0x0600A6F0 RID: 42736 RVA: 0x00256C84 File Offset: 0x00254E84
	private void RefreshExpression()
	{
		int currentExpressionId = AdviceModel.Instance.CurrentExpressionId;
		if (currentExpressionId > 0)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(currentExpressionId);
			if (expressionConfig != null)
			{
				base.SetTextureByPath(expressionConfig.Value.ExpressionTexturePath, base.GetTexture(1), null, null);
				return;
			}
		}
		else
		{
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(false);
		}
	}

	// Token: 0x0600A6F1 RID: 42737 RVA: 0x00256D01 File Offset: 0x00254F01
	public void RefreshView()
	{
		this.RefreshText();
	}

	// Token: 0x0600A6F2 RID: 42738 RVA: 0x00256D0C File Offset: 0x00254F0C
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceExpression, new Action(this.RefreshExpression));
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceWord, new Action(this.RefreshText));
		EventSystem.Instance.Remove(EEventName.OnChangeAdviceWord, new Action(this.RefreshText));
	}

	// Token: 0x02007CA0 RID: 31904
	private static class EComponents
	{
		// Token: 0x04028E15 RID: 167445
		public const int ContentItem = 0;

		// Token: 0x04028E16 RID: 167446
		public const int EmojiTexture = 1;

		// Token: 0x04028E17 RID: 167447
		public const int NameText = 2;

		// Token: 0x04028E18 RID: 167448
		public const int TextLayout = 3;

		// Token: 0x04028E19 RID: 167449
		public const int ContentText = 4;

		// Token: 0x04028E1A RID: 167450
		public const int LikeNumText = 5;

		// Token: 0x04028E1B RID: 167451
		public const int DislikeToggle = 6;

		// Token: 0x04028E1C RID: 167452
		public const int LikeToggle = 7;

		// Token: 0x04028E1D RID: 167453
		public const int ContentText2 = 8;
	}
}
