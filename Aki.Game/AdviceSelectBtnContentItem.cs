using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016C8 RID: 5832
internal class AdviceSelectBtnContentItem : UiPanelBase
{
	// Token: 0x0600A6B6 RID: 42678 RVA: 0x00255653 File Offset: 0x00253853
	[NullableContext(1)]
	public AdviceSelectBtnContentItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A6B7 RID: 42679 RVA: 0x00255668 File Offset: 0x00253868
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

	// Token: 0x0600A6B8 RID: 42680 RVA: 0x00255714 File Offset: 0x00253914
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnSelectAdviceExpression, new Action(this.OnSelectExpression));
		EventSystem.Instance.Add(EEventName.OnSelectAdviceWord, new Action(this.RefreshWordText));
		EventSystem.Instance.Add(EEventName.OnChangeAdviceWord, new Action(this.RefreshWordConjunctionText));
	}

	// Token: 0x0600A6B9 RID: 42681 RVA: 0x00255778 File Offset: 0x00253978
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

	// Token: 0x0600A6BA RID: 42682 RVA: 0x00255840 File Offset: 0x00253A40
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

	// Token: 0x0600A6BB RID: 42683 RVA: 0x002558DC File Offset: 0x00253ADC
	private void OnSelectExpression()
	{
		this.RefreshExpressionSelectState();
		this.RefreshDeleteButton();
	}

	// Token: 0x0600A6BC RID: 42684 RVA: 0x002558EC File Offset: 0x00253AEC
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

	// Token: 0x0600A6BD RID: 42685 RVA: 0x0025599B File Offset: 0x00253B9B
	private void OnClickDeleteButton()
	{
		AdviceModel.Instance.CurrentExpressionId = 0;
		this.RefreshDeleteButton();
		EventSystem.Instance.Emit(EEventName.OnSelectAdviceExpression);
	}

	// Token: 0x0600A6BE RID: 42686 RVA: 0x002559BE File Offset: 0x00253BBE
	private void OnChangeBtn()
	{
		if (this.Data != null)
		{
			AdviceModel.Instance.PreSelectAdviceItemId = (int)this.Data.GetIndex();
		}
		EventSystem.Instance.Emit(EEventName.OnClickAdviceSelectItem);
	}

	// Token: 0x0600A6BF RID: 42687 RVA: 0x002559ED File Offset: 0x00253BED
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

	// Token: 0x0600A6C0 RID: 42688 RVA: 0x00255A1C File Offset: 0x00253C1C
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

	// Token: 0x0600A6C1 RID: 42689 RVA: 0x00255A83 File Offset: 0x00253C83
	private void RefreshViewByType()
	{
		AdviceSelectItemData data = this.Data;
		if (data != null && data.GetIndex() == EAdviceSelectItemEnum.AddExpression)
		{
			this.RefreshExpressionSelectState();
		}
	}

	// Token: 0x0600A6C2 RID: 42690 RVA: 0x00255AA4 File Offset: 0x00253CA4
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

	// Token: 0x0600A6C3 RID: 42691 RVA: 0x00255B3C File Offset: 0x00253D3C
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

	// Token: 0x0600A6C4 RID: 42692 RVA: 0x00255BD8 File Offset: 0x00253DD8
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceExpression, new Action(this.OnSelectExpression));
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceWord, new Action(this.RefreshWordText));
		EventSystem.Instance.Remove(EEventName.OnChangeAdviceWord, new Action(this.RefreshWordConjunctionText));
	}

	// Token: 0x04004B5E RID: 19294
	[Nullable(2)]
	private AdviceSelectItemData Data;

	// Token: 0x02007C9D RID: 31901
	private static class EAdviceSelectBtnContentItemEnum
	{
		// Token: 0x04028DFF RID: 167423
		public const int Button = 0;

		// Token: 0x04028E00 RID: 167424
		public const int Text = 1;

		// Token: 0x04028E01 RID: 167425
		public const int Icon = 2;

		// Token: 0x04028E02 RID: 167426
		public const int DeleteButton = 3;
	}
}
