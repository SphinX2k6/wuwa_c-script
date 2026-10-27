using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F6E RID: 3950
public class DrinksTopStepItem : UiPanelBase
{
	// Token: 0x06006509 RID: 25865 RVA: 0x00141428 File Offset: 0x0013F628
	public DrinksTopStepItem(int step)
	{
		this.Step = step;
		this.StepType = (int)DrinksUtils.GetStepType(this.Step);
	}

	// Token: 0x170007BF RID: 1983
	// (get) Token: 0x0600650A RID: 25866 RVA: 0x00141456 File Offset: 0x0013F656
	// (set) Token: 0x0600650B RID: 25867 RVA: 0x0014145E File Offset: 0x0013F65E
	public int Step { get; set; }

	// Token: 0x0600650C RID: 25868 RVA: 0x00141468 File Offset: 0x0013F668
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600650D RID: 25869 RVA: 0x001414C4 File Offset: 0x0013F6C4
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

	// Token: 0x0600650E RID: 25870 RVA: 0x00141518 File Offset: 0x0013F718
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

	// Token: 0x0600650F RID: 25871 RVA: 0x0014167F File Offset: 0x0013F87F
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

	// Token: 0x04002DEE RID: 11758
	protected int StepType = 1;

	// Token: 0x04002DEF RID: 11759
	protected bool IsEmpty = true;

	// Token: 0x020075B9 RID: 30137
	private static class EItem
	{
		// Token: 0x04026E8A RID: 159370
		public const int Self = 0;

		// Token: 0x04026E8B RID: 159371
		public const int TexEmpty = 1;

		// Token: 0x04026E8C RID: 159372
		public const int TexIcon = 2;
	}
}
