using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001698 RID: 5784
public class LordGymThird5LoadingView : LoadingViewBase
{
	// Token: 0x0600E130 RID: 57648 RVA: 0x004207A8 File Offset: 0x0041E9A8
	[NullableContext(1)]
	public LordGymThird5LoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E131 RID: 57649 RVA: 0x004207B1 File Offset: 0x0041E9B1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600E132 RID: 57650 RVA: 0x004207EA File Offset: 0x0041E9EA
	protected override void OnStart()
	{
		base.OnStart();
	}

	// Token: 0x0600E133 RID: 57651 RVA: 0x004207F2 File Offset: 0x0041E9F2
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x0600E134 RID: 57652 RVA: 0x004207F4 File Offset: 0x0041E9F4
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(0, value, "");
		this.ChangeSize(value);
	}

	// Token: 0x0600E135 RID: 57653 RVA: 0x0042080C File Offset: 0x0041EA0C
	[NullableContext(1)]
	protected override void SetTextProgressValue(int textKey, float value, string suffix = "")
	{
		int num = (int)MathF.Round(value);
		base.GetText(textKey).SetText(num.ToString() + "%", true);
	}

	// Token: 0x0600E136 RID: 57654 RVA: 0x00420840 File Offset: 0x0041EA40
	private void ChangeSize(float value)
	{
		UUIItem item = base.GetItem(3);
		float num = 0.9f;
		float num2 = 1.1f;
		float num3 = num + (num2 - num) * value / 100f;
		item.SetUIItemScale(new FVector(num3, num3, num3));
	}

	// Token: 0x0600E137 RID: 57655 RVA: 0x0042087B File Offset: 0x0041EA7B
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Start", null, false);
	}

	// Token: 0x0200787E RID: 30846
	private class EComponent
	{
		// Token: 0x0402718E RID: 160142
		public const int ProgressText = 0;

		// Token: 0x0402718F RID: 160143
		public const int SizeChangeItem = 3;
	}
}
