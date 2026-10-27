using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D4A RID: 11594
public class WeeklyRogueEnvironmentTips : UiViewBase
{
	// Token: 0x060185D7 RID: 99799 RVA: 0x00634257 File Offset: 0x00632457
	[NullableContext(1)]
	public WeeklyRogueEnvironmentTips(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060185D8 RID: 99800 RVA: 0x00634260 File Offset: 0x00632460
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

	// Token: 0x060185D9 RID: 99801 RVA: 0x006342C8 File Offset: 0x006324C8
	protected override void OnBeforeShow()
	{
		RogueWeeklyCycle value = WeeklyRogueModel.Instance.ActivityData.GetCycleConfig().Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.BuffDesc, value.BuffDescParam());
	}

	// Token: 0x060185DA RID: 99802 RVA: 0x0063430C File Offset: 0x0063250C
	private void OnBtnBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x020092DD RID: 37597
	private enum EComponent
	{
		// Token: 0x0402F787 RID: 194439
		TxtContent,
		// Token: 0x0402F788 RID: 194440
		BtnBack
	}
}
