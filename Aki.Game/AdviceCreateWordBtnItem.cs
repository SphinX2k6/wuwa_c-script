using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016CF RID: 5839
public class AdviceCreateWordBtnItem : UiPanelBase
{
	// Token: 0x0600A6FA RID: 42746 RVA: 0x00256EDB File Offset: 0x002550DB
	[NullableContext(1)]
	public AdviceCreateWordBtnItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A6FB RID: 42747 RVA: 0x00256EF0 File Offset: 0x002550F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn))
		};
	}

	// Token: 0x0600A6FC RID: 42748 RVA: 0x00256F57 File Offset: 0x00255157
	public void SetType(EActiveCreateWordType type)
	{
		this.Type = type;
	}

	// Token: 0x0600A6FD RID: 42749 RVA: 0x00256F60 File Offset: 0x00255160
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x0600A6FE RID: 42750 RVA: 0x00256F69 File Offset: 0x00255169
	private void OnClickBtn()
	{
		if (this.Type == EActiveCreateWordType.NormalWord)
		{
			this.InitSortWordViewParam();
			UiManager.Instance.OpenView(EUiViewName.AdviceSortWordView, null, null);
			return;
		}
		this.InitWordViewParam();
		UiManager.Instance.OpenView(EUiViewName.AdviceWordView, null, null);
	}

	// Token: 0x0600A6FF RID: 42751 RVA: 0x00256FA4 File Offset: 0x002551A4
	private void InitSortWordViewParam()
	{
		AdviceModel instance = AdviceModel.Instance;
		int num;
		if (instance.CurrentWordMap.TryGetValue(this.Index, out num) && num > 0)
		{
			instance.CurrentSelectSortTypeId = AdviceConfig.Instance.GetAdviceWordType(num).GetValueOrDefault();
			instance.CurrentSelectSortWordId = num;
		}
		else
		{
			IReadOnlyList<AdviceWordType> adviceWordTypeConfigs = AdviceConfig.Instance.GetAdviceWordTypeConfigs();
			int currentSelectSortTypeId = (adviceWordTypeConfigs != null && adviceWordTypeConfigs.Count > 0) ? adviceWordTypeConfigs[0].Id : 0;
			instance.CurrentSelectSortTypeId = currentSelectSortTypeId;
			instance.CurrentSelectSortWordId = -1;
		}
		instance.CurrentSelectWordIndex = this.Index;
	}

	// Token: 0x0600A700 RID: 42752 RVA: 0x00257039 File Offset: 0x00255239
	private void InitWordViewParam()
	{
		AdviceModel instance = AdviceModel.Instance;
		instance.CurrentChangeWordType = EChangeWordType.Conjunction;
		instance.CurrentSelectWordId = instance.CurrentConjunctionId;
	}

	// Token: 0x0600A701 RID: 42753 RVA: 0x00257052 File Offset: 0x00255252
	public void RefreshView()
	{
		this.RefreshWord();
	}

	// Token: 0x0600A702 RID: 42754 RVA: 0x0025705C File Offset: 0x0025525C
	private void RefreshWord()
	{
		if (this.Type == EActiveCreateWordType.NormalWord)
		{
			int num;
			AdviceModel.Instance.CurrentWordMap.TryGetValue(this.Index, out num);
			if (num <= 0)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(1), "ChangeWord", Array.Empty<object>());
				return;
			}
			string adviceWordText = AdviceConfig.Instance.GetAdviceWordText(num);
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(adviceWordText ?? "", true);
			return;
		}
		else
		{
			int currentConjunctionId = AdviceModel.Instance.CurrentConjunctionId;
			if (currentConjunctionId <= 0)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(1), "ChangeWord", Array.Empty<object>());
				return;
			}
			string adviceConjunctionText = AdviceConfig.Instance.GetAdviceConjunctionText(currentConjunctionId);
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(adviceConjunctionText ?? "", true);
			return;
		}
	}

	// Token: 0x04004B72 RID: 19314
	private EActiveCreateWordType Type;

	// Token: 0x04004B73 RID: 19315
	private int Index;

	// Token: 0x02007CA2 RID: 31906
	private static class EComponents
	{
		// Token: 0x04028E21 RID: 167457
		public const int WordBtn = 0;

		// Token: 0x04028E22 RID: 167458
		public const int WordText = 1;
	}
}
