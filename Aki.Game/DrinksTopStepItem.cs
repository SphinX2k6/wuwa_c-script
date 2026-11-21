using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000423 RID: 1059
public class DrinksTopStepItem : UiPanelBase
{
	// Token: 0x060038A1 RID: 14497 RVA: 0x00149CC4 File Offset: 0x00147EC4
	public DrinksTopStepItem(int step)
	{
		this.Step = step;
		this.StepType = (int)DrinksUtils.GetStepType(this.Step);
	}

	// Token: 0x170007E1 RID: 2017
	// (get) Token: 0x060038A2 RID: 14498 RVA: 0x00149CF2 File Offset: 0x00147EF2
	// (set) Token: 0x060038A3 RID: 14499 RVA: 0x00149CFA File Offset: 0x00147EFA
	public int Step { get; set; }

	// Token: 0x060038A4 RID: 14500 RVA: 0x00149D04 File Offset: 0x00147F04
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x060038A5 RID: 14501 RVA: 0x00149D60 File Offset: 0x00147F60
	public void UpdateCurState(EDrinksPlayStep curStep)
	{
		EToggleState state = (curStep == (EDrinksPlayStep)this.Step || (DrinksUtils.GetStepType((int)curStep) == EDrinksRequireType.Batching && this.StepType == 2)) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		this.UpdateStepItem();
	}

	// Token: 0x060038A6 RID: 14502 RVA: 0x00149DB4 File Offset: 0x00147FB4
	public void UpdateStepItem()
	{
		DrinksResultInfo currentPlayData = DrinksModel.Instance.GetCurrentPlayData();
		if (this.StepType == 1)
		{
			if (currentPlayData.DrinkBase[this.Step] == 0)
			{
				this.SetEmpty(true);
				return;
			}
			this.SetEmpty(false);
			base.SetTextureByPath(DrinksConfig.Instance.GetDrinkBase(currentPlayData.DrinkBase[this.Step]).Value.DrinkIcon, base.GetTexture(2), null, null);
			return;
		}
		else if (this.StepType == 3)
		{
			if (currentPlayData.Ornament == 0)
			{
				this.SetEmpty(true);
				return;
			}
			this.SetEmpty(false);
			base.SetTextureByPath(DrinksConfig.Instance.GetOrnament(currentPlayData.Ornament).Value.Icon, base.GetTexture(2), null, null);
			return;
		}
		else
		{
			if (currentPlayData.Batching == null)
			{
				this.SetEmpty(true);
				return;
			}
			int num = this.Step - 2;
			if (currentPlayData.Batching.Count <= num || currentPlayData.Batching[num] == 0)
			{
				this.SetEmpty(true);
				return;
			}
			this.SetEmpty(false);
			base.SetTextureByPath(DrinksConfig.Instance.GetBatching(currentPlayData.Batching[num]).Value.Icon, base.GetTexture(2), null, null);
			return;
		}
	}

	// Token: 0x060038A7 RID: 14503 RVA: 0x00149F1B File Offset: 0x0014811B
	protected void SetEmpty(bool isEmpty)
	{
		this.IsEmpty = isEmpty;
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(isEmpty);
		}
		UUITexture texture2 = base.GetTexture(2);
		if (texture2 == null)
		{
			return;
		}
		texture2.SetUIActive(!isEmpty);
	}

	// Token: 0x04002E87 RID: 11911
	protected int StepType = 1;

	// Token: 0x04002E88 RID: 11912
	protected bool IsEmpty = true;

	// Token: 0x0200674D RID: 26445
	private static class EItem
	{
		// Token: 0x040221D5 RID: 139733
		public const int Self = 0;

		// Token: 0x040221D6 RID: 139734
		public const int TexEmpty = 1;

		// Token: 0x040221D7 RID: 139735
		public const int TexIcon = 2;
	}
}
