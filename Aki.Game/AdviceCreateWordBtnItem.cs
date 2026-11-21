using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B87 RID: 2951
public class AdviceCreateWordBtnItem : UiPanelBase
{
	// Token: 0x06007ADA RID: 31450 RVA: 0x002612E7 File Offset: 0x0025F4E7
	[NullableContext(1)]
	public AdviceCreateWordBtnItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007ADB RID: 31451 RVA: 0x002612FC File Offset: 0x0025F4FC
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

	// Token: 0x06007ADC RID: 31452 RVA: 0x00261363 File Offset: 0x0025F563
	public void SetType(EActiveCreateWordType type)
	{
		this.Type = type;
	}

	// Token: 0x06007ADD RID: 31453 RVA: 0x0026136C File Offset: 0x0025F56C
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x06007ADE RID: 31454 RVA: 0x00261375 File Offset: 0x0025F575
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

	// Token: 0x06007ADF RID: 31455 RVA: 0x002613B0 File Offset: 0x0025F5B0
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

	// Token: 0x06007AE0 RID: 31456 RVA: 0x00261445 File Offset: 0x0025F645
	private void InitWordViewParam()
	{
		AdviceModel instance = AdviceModel.Instance;
		instance.CurrentChangeWordType = EChangeWordType.Conjunction;
		instance.CurrentSelectWordId = instance.CurrentConjunctionId;
	}

	// Token: 0x06007AE1 RID: 31457 RVA: 0x0026145E File Offset: 0x0025F65E
	public void RefreshView()
	{
		this.RefreshWord();
	}

	// Token: 0x06007AE2 RID: 31458 RVA: 0x00261468 File Offset: 0x0025F668
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

	// Token: 0x04004C19 RID: 19481
	private EActiveCreateWordType Type;

	// Token: 0x04004C1A RID: 19482
	private int Index;

	// Token: 0x02006E27 RID: 28199
	private static class EComponents
	{
		// Token: 0x0402414A RID: 147786
		public const int WordBtn = 0;

		// Token: 0x0402414B RID: 147787
		public const int WordText = 1;
	}
}
