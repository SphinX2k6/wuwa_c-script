using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200040C RID: 1036
public class DrinksBlackMask : UiPanelBase
{
	// Token: 0x0600380E RID: 14350 RVA: 0x00146460 File Offset: 0x00144660
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0600380F RID: 14351 RVA: 0x00146483 File Offset: 0x00144683
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06003810 RID: 14352 RVA: 0x00146498 File Offset: 0x00144698
	public int ShowBackMask(EDrinksPlayStep curStep)
	{
		DrinksStepConfig? stepConfig = DrinksConfig.Instance.GetStepConfig(curStep);
		base.SetUiActive(true);
		AudioSystem.Instance.PostEvent(stepConfig.Value.PrevMaskEvent);
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.HideMask();
		}, (float)stepConfig.Value.PrevMaskEventDelay, null, null, true, 1f);
		return stepConfig.Value.PrevMaskEventDelay / 2;
	}

	// Token: 0x06003811 RID: 14353 RVA: 0x00146512 File Offset: 0x00144712
	protected void HideMask()
	{
		base.SetUiActive(false);
	}

	// Token: 0x02006736 RID: 26422
	private static class EDefine
	{
		// Token: 0x04022176 RID: 139638
		public const int Txt = 0;
	}
}
