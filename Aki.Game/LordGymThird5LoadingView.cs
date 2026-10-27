using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020021B4 RID: 8628
public class LordGymThird5LoadingView : LoadingViewBase
{
	// Token: 0x06010C9F RID: 68767 RVA: 0x00413EC8 File Offset: 0x004120C8
	[NullableContext(1)]
	public LordGymThird5LoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010CA0 RID: 68768 RVA: 0x00413ED1 File Offset: 0x004120D1
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06010CA1 RID: 68769 RVA: 0x00413F0A File Offset: 0x0041210A
	protected override void OnStart()
	{
		base.OnStart();
	}

	// Token: 0x06010CA2 RID: 68770 RVA: 0x00413F12 File Offset: 0x00412112
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x06010CA3 RID: 68771 RVA: 0x00413F14 File Offset: 0x00412114
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(0, value, "");
		this.ChangeSize(value);
	}

	// Token: 0x06010CA4 RID: 68772 RVA: 0x00413F2C File Offset: 0x0041212C
	[NullableContext(1)]
	protected override void SetTextProgressValue(int textKey, float value, string suffix = "")
	{
		int num = (int)MathF.Round(value);
		base.GetText(textKey).SetText(num.ToString() + "%", true);
	}

	// Token: 0x06010CA5 RID: 68773 RVA: 0x00413F60 File Offset: 0x00412160
	private void ChangeSize(float value)
	{
		UUIItem item = base.GetItem(3);
		float num = 0.9f;
		float num2 = 1.1f;
		float num3 = num + (num2 - num) * value / 100f;
		item.SetUIItemScale(new FVector(num3, num3, num3));
	}

	// Token: 0x06010CA6 RID: 68774 RVA: 0x00413F9B File Offset: 0x0041219B
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Start", null, false);
	}

	// Token: 0x020086F3 RID: 34547
	private class EComponent
	{
		// Token: 0x0402BE6D RID: 179821
		public const int ProgressText = 0;

		// Token: 0x0402BE6E RID: 179822
		public const int SizeChangeItem = 3;
	}
}
