using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022A4 RID: 8868
public class WeeklyRogueEnvironmentTips : UiViewBase
{
	// Token: 0x06015E79 RID: 89721 RVA: 0x0065A267 File Offset: 0x00658467
	[NullableContext(1)]
	public WeeklyRogueEnvironmentTips(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015E7A RID: 89722 RVA: 0x0065A270 File Offset: 0x00658470
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnBtnBack))
		};
	}

	// Token: 0x06015E7B RID: 89723 RVA: 0x0065A2D8 File Offset: 0x006584D8
	protected override void OnBeforeShow()
	{
		RogueWeeklyCycle value = WeeklyRogueModel.Instance.ActivityData.GetCycleConfig().Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.BuffDesc, value.BuffDescParam());
	}

	// Token: 0x06015E7C RID: 89724 RVA: 0x0065A31C File Offset: 0x0065851C
	private void OnBtnBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x02008504 RID: 34052
	private enum EComponent
	{
		// Token: 0x0402AE0F RID: 175631
		TxtContent,
		// Token: 0x0402AE10 RID: 175632
		BtnBack
	}
}
