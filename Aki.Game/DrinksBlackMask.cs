using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F57 RID: 3927
public class DrinksBlackMask : UiPanelBase
{
	// Token: 0x06006476 RID: 25718 RVA: 0x0013DBC4 File Offset: 0x0013BDC4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06006477 RID: 25719 RVA: 0x0013DBE7 File Offset: 0x0013BDE7
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06006478 RID: 25720 RVA: 0x0013DBFC File Offset: 0x0013BDFC
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

	// Token: 0x06006479 RID: 25721 RVA: 0x0013DC76 File Offset: 0x0013BE76
	protected void HideMask()
	{
		base.SetUiActive(false);
	}

	// Token: 0x020075A2 RID: 30114
	private static class EDefine
	{
		// Token: 0x04026E2B RID: 159275
		public const int Txt = 0;
	}
}
