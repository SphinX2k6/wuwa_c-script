using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020021A8 RID: 8616
public class LordGymLoadingView : LoadingViewBase
{
	// Token: 0x06010C29 RID: 68649 RVA: 0x004128F3 File Offset: 0x00410AF3
	[NullableContext(1)]
	public LordGymLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010C2A RID: 68650 RVA: 0x004128FC File Offset: 0x00410AFC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText))
		};
	}

	// Token: 0x06010C2B RID: 68651 RVA: 0x0041291F File Offset: 0x00410B1F
	protected override void OnStart()
	{
		base.OnStart();
		AudioSystem.Instance.PostEvent("play_ui_daoguan_3_0_loading_percent");
	}

	// Token: 0x06010C2C RID: 68652 RVA: 0x00412937 File Offset: 0x00410B37
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x06010C2D RID: 68653 RVA: 0x00412939 File Offset: 0x00410B39
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(0, value, "");
	}

	// Token: 0x06010C2E RID: 68654 RVA: 0x00412948 File Offset: 0x00410B48
	[NullableContext(1)]
	protected override void SetTextProgressValue(int textKey, float value, string suffix = "")
	{
		int num = (int)MathF.Round(value);
		base.GetArtText(textKey).SetText(num.ToString());
	}

	// Token: 0x020086E0 RID: 34528
	private class EComponent
	{
		// Token: 0x0402BE2C RID: 179756
		public const int ProgressText = 0;
	}
}
