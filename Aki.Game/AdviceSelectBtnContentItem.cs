using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B80 RID: 2944
internal class AdviceSelectBtnContentItem : UiPanelBase
{
	// Token: 0x06007A96 RID: 31382 RVA: 0x0025FA63 File Offset: 0x0025DC63
	[NullableContext(1)]
	public AdviceSelectBtnContentItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007A97 RID: 31383 RVA: 0x0025FA78 File Offset: 0x0025DC78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnChangeBtn)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickDeleteButton))
		};
	}

	// Token: 0x06007A98 RID: 31384 RVA: 0x0025FB24 File Offset: 0x0025DD24
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnSelectAdviceExpression, new Action(this.OnSelectExpression));
		EventSystem.Instance.Add(EEventName.OnSelectAdviceWord, new Action(this.RefreshWordText));
		EventSystem.Instance.Add(EEventName.OnChangeAdviceWord, new Action(this.RefreshWordConjunctionText));
	}

	// Token: 0x06007A99 RID: 31385 RVA: 0x0025FB88 File Offset: 0x0025DD88
	private void RefreshWordText()
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.GetIndex() == EAdviceSelectItemEnum.SelectWord1 || this.Data.GetIndex() == EAdviceSelectItemEnum.SelectWord2)
		{
			int key = (this.Data.GetIndex() > EAdviceSelectItemEnum.SelectWord1) ? 1 : 0;
			int num;
			AdviceModel.Instance.CurrentWordMap.TryGetValue(key, out num);
			if (num > 0)
			{
				string adviceWordText = AdviceConfig.Instance.GetAdviceWordText(num);
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetText(adviceWordText ?? "", true);
				}
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.useChangeColor = true;
					return;
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalText(base.GetText(1), "AdviceFunc_1", Array.Empty<object>());
				UUIText text3 = base.GetText(1);
				if (text3 != null)
				{
					text3.useChangeColor = false;
				}
			}
		}
	}

	// Token: 0x06007A9A RID: 31386 RVA: 0x0025FC50 File Offset: 0x0025DE50
	private void RefreshWordConjunctionText()
	{
		if (this.Data == null || this.Data.GetIndex() != EAdviceSelectItemEnum.Conjunction)
		{
			return;
		}
		int currentConjunctionId = AdviceModel.Instance.CurrentConjunctionId;
		if (currentConjunctionId > 0)
		{
			string adviceConjunctionText = AdviceConfig.Instance.GetAdviceConjunctionText(currentConjunctionId);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(adviceConjunctionText ?? "", true);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.useChangeColor = true;
				return;
			}
		}
		else
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), "AdviceFunc_1", Array.Empty<object>());
			UUIText text3 = base.GetText(1);
			if (text3 != null)
			{
				text3.useChangeColor = false;
			}
		}
	}

	// Token: 0x06007A9B RID: 31387 RVA: 0x0025FCEC File Offset: 0x0025DEEC
	private void OnSelectExpression()
	{
		this.RefreshExpressionSelectState();
		this.RefreshDeleteButton();
	}

	// Token: 0x06007A9C RID: 31388 RVA: 0x0025FCFC File Offset: 0x0025DEFC
	private void RefreshExpressionSelectState()
	{
		int currentExpressionId = AdviceModel.Instance.CurrentExpressionId;
		AdviceSelectItemData data = this.Data;
		if (data == null || data.GetIndex() != EAdviceSelectItemEnum.AddExpression)
		{
			return;
		}
		if (currentExpressionId != 0)
		{
			ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(currentExpressionId);
			if (expressionConfig != null)
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.ShowTextNew(expressionConfig.Value.Name);
				}
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.useChangeColor = true;
					return;
				}
			}
		}
		else
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), "AdviceFunc_2", Array.Empty<object>());
			UUIText text3 = base.GetText(1);
			if (text3 != null)
			{
				text3.useChangeColor = false;
			}
		}
	}

	// Token: 0x06007A9D RID: 31389 RVA: 0x0025FDAB File Offset: 0x0025DFAB
	private void OnClickDeleteButton()
	{
		AdviceModel.Instance.CurrentExpressionId = 0;
		this.RefreshDeleteButton();
		EventSystem.Instance.Emit(EEventName.OnSelectAdviceExpression);
	}

	// Token: 0x06007A9E RID: 31390 RVA: 0x0025FDCE File Offset: 0x0025DFCE
	private void OnChangeBtn()
	{
		if (this.Data != null)
		{
			AdviceModel.Instance.PreSelectAdviceItemId = (int)this.Data.GetIndex();
		}
		EventSystem.Instance.Emit(EEventName.OnClickAdviceSelectItem);
	}

	// Token: 0x06007A9F RID: 31391 RVA: 0x0025FDFD File Offset: 0x0025DFFD
	[NullableContext(1)]
	public void RefreshView(AdviceSelectItemData data)
	{
		this.Data = data;
		this.RefreshShowText();
		this.RefreshViewByType();
		this.RefreshSprite();
		this.RefreshWordText();
		this.RefreshWordConjunctionText();
		this.RefreshDeleteButton();
	}

	// Token: 0x06007AA0 RID: 31392 RVA: 0x0025FE2C File Offset: 0x0025E02C
	private void RefreshDeleteButton()
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.GetIndex() == EAdviceSelectItemEnum.AddExpression)
		{
			int currentExpressionId = AdviceModel.Instance.CurrentExpressionId;
			base.GetButton(3).RootUIComp.Get().SetUIActive(currentExpressionId != 0);
			return;
		}
		base.GetButton(3).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06007AA1 RID: 31393 RVA: 0x0025FE93 File Offset: 0x0025E093
	private void RefreshViewByType()
	{
		AdviceSelectItemData data = this.Data;
		if (data != null && data.GetIndex() == EAdviceSelectItemEnum.AddExpression)
		{
			this.RefreshExpressionSelectState();
		}
	}

	// Token: 0x06007AA2 RID: 31394 RVA: 0x0025FEB4 File Offset: 0x0025E0B4
	private void RefreshShowText()
	{
		if (this.Data == null)
		{
			return;
		}
		EAdviceSelectItemEnum index = this.Data.GetIndex();
		string textTableId = "";
		if (index == EAdviceSelectItemEnum.SelectWord1)
		{
			textTableId = "AdviceFunc_1";
		}
		else if (index == EAdviceSelectItemEnum.Conjunction)
		{
			textTableId = "AdviceFunc_1";
		}
		else if (index == EAdviceSelectItemEnum.SelectWord2)
		{
			textTableId = "AdviceFunc_1";
		}
		else if (index == EAdviceSelectItemEnum.ChangeWordBtn)
		{
			textTableId = "AdviceFunc_3";
		}
		else if (index == EAdviceSelectItemEnum.AddExpression)
		{
			textTableId = "AdviceFunc_2";
		}
		else if (index == EAdviceSelectItemEnum.AddOrDecreaseBtn)
		{
			textTableId = ((AdviceModel.Instance.CurrentLineModel == ELineMode.SingleLine) ? "AdviceFunc_4" : "AdviceFunc_5");
		}
		LguiUtil.Instance.SetLocalText(base.GetText(1), textTableId, Array.Empty<object>());
	}

	// Token: 0x06007AA3 RID: 31395 RVA: 0x0025FF4C File Offset: 0x0025E14C
	private void RefreshSprite()
	{
		if (this.Data == null)
		{
			return;
		}
		EAdviceSelectItemEnum index = this.Data.GetIndex();
		string path = "";
		if (index == EAdviceSelectItemEnum.SelectWord1)
		{
			path = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnOne.SP_AdviceBtnOne";
		}
		else if (index == EAdviceSelectItemEnum.Conjunction)
		{
			path = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnTwo.SP_AdviceBtnTwo";
		}
		else if (index == EAdviceSelectItemEnum.SelectWord2)
		{
			path = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnThree.SP_AdviceBtnThree";
		}
		else if (index == EAdviceSelectItemEnum.ChangeWordBtn)
		{
			path = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnHuan.SP_AdviceBtnHuan";
		}
		else if (index == EAdviceSelectItemEnum.AddExpression)
		{
			path = "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnbiaoqing.SP_AdviceBtnbiaoqing";
		}
		else if (index == EAdviceSelectItemEnum.AddOrDecreaseBtn)
		{
			path = ((AdviceModel.Instance.CurrentLineModel == ELineMode.SingleLine) ? "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnJia.SP_AdviceBtnJia" : "/Game/Aki/UI/UIResources/UiAdvice/Atlas/SP_AdviceBtnJian.SP_AdviceBtnJian");
		}
		this.SetSpriteByPath(path, base.GetSprite(2), false, null, null);
	}

	// Token: 0x06007AA4 RID: 31396 RVA: 0x0025FFE8 File Offset: 0x0025E1E8
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceExpression, new Action(this.OnSelectExpression));
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceWord, new Action(this.RefreshWordText));
		EventSystem.Instance.Remove(EEventName.OnChangeAdviceWord, new Action(this.RefreshWordConjunctionText));
	}

	// Token: 0x04004C05 RID: 19461
	[Nullable(2)]
	private AdviceSelectItemData Data;

	// Token: 0x02006E22 RID: 28194
	private static class EAdviceSelectBtnContentItemEnum
	{
		// Token: 0x04024128 RID: 147752
		public const int Button = 0;

		// Token: 0x04024129 RID: 147753
		public const int Text = 1;

		// Token: 0x0402412A RID: 147754
		public const int Icon = 2;

		// Token: 0x0402412B RID: 147755
		public const int DeleteButton = 3;
	}
}
