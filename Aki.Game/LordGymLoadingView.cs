using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200168C RID: 5772
public class LordGymLoadingView : LoadingViewBase
{
	// Token: 0x0600E0BA RID: 57530 RVA: 0x0041F1DB File Offset: 0x0041D3DB
	[NullableContext(1)]
	public LordGymLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0BB RID: 57531 RVA: 0x0041F1E4 File Offset: 0x0041D3E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText))
		};
	}

	// Token: 0x0600E0BC RID: 57532 RVA: 0x0041F207 File Offset: 0x0041D407
	protected override void OnStart()
	{
		base.OnStart();
		AudioSystem.Instance.PostEvent("play_ui_daoguan_3_0_loading_percent");
	}

	// Token: 0x0600E0BD RID: 57533 RVA: 0x0041F21F File Offset: 0x0041D41F
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x0600E0BE RID: 57534 RVA: 0x0041F221 File Offset: 0x0041D421
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(0, value, "");
	}

	// Token: 0x0600E0BF RID: 57535 RVA: 0x0041F230 File Offset: 0x0041D430
	[NullableContext(1)]
	protected override void SetTextProgressValue(int textKey, float value, string suffix = "")
	{
		int num = (int)MathF.Round(value);
		base.GetArtText(textKey).SetText(num.ToString());
	}

	// Token: 0x0200786B RID: 30827
	private class EComponent
	{
		// Token: 0x0402714D RID: 160077
		public const int ProgressText = 0;
	}
}
