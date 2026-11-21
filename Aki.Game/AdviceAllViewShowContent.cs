using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B83 RID: 2947
public class AdviceAllViewShowContent : UiPanelBase
{
	// Token: 0x06007ACB RID: 31435 RVA: 0x00260E17 File Offset: 0x0025F017
	[NullableContext(1)]
	public AdviceAllViewShowContent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007ACC RID: 31436 RVA: 0x00260E2C File Offset: 0x0025F02C
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

	// Token: 0x06007ACD RID: 31437 RVA: 0x00260F0C File Offset: 0x0025F10C
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

	// Token: 0x06007ACE RID: 31438 RVA: 0x00260FDC File Offset: 0x0025F1DC
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

	// Token: 0x06007ACF RID: 31439 RVA: 0x0026105C File Offset: 0x0025F25C
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

	// Token: 0x06007AD0 RID: 31440 RVA: 0x00261090 File Offset: 0x0025F290
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

	// Token: 0x06007AD1 RID: 31441 RVA: 0x0026110D File Offset: 0x0025F30D
	public void RefreshView()
	{
		this.RefreshText();
	}

	// Token: 0x06007AD2 RID: 31442 RVA: 0x00261118 File Offset: 0x0025F318
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceExpression, new Action(this.RefreshExpression));
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceWord, new Action(this.RefreshText));
		EventSystem.Instance.Remove(EEventName.OnChangeAdviceWord, new Action(this.RefreshText));
	}

	// Token: 0x02006E25 RID: 28197
	private static class EComponents
	{
		// Token: 0x0402413E RID: 147774
		public const int ContentItem = 0;

		// Token: 0x0402413F RID: 147775
		public const int EmojiTexture = 1;

		// Token: 0x04024140 RID: 147776
		public const int NameText = 2;

		// Token: 0x04024141 RID: 147777
		public const int TextLayout = 3;

		// Token: 0x04024142 RID: 147778
		public const int ContentText = 4;

		// Token: 0x04024143 RID: 147779
		public const int LikeNumText = 5;

		// Token: 0x04024144 RID: 147780
		public const int DislikeToggle = 6;

		// Token: 0x04024145 RID: 147781
		public const int LikeToggle = 7;

		// Token: 0x04024146 RID: 147782
		public const int ContentText2 = 8;
	}
}
