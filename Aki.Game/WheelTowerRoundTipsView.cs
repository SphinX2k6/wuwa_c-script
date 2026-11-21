using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000AF8 RID: 2808
public class WheelTowerRoundTipsView : UiTickViewBase
{
	// Token: 0x060073F5 RID: 29685 RVA: 0x0023D675 File Offset: 0x0023B875
	[NullableContext(1)]
	public WheelTowerRoundTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060073F6 RID: 29686 RVA: 0x0023D680 File Offset: 0x0023B880
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060073F7 RID: 29687 RVA: 0x0023D72C File Offset: 0x0023B92C
	protected override void OnStart()
	{
		object openParam = this.OpenParam;
		int num2;
		if (openParam is int)
		{
			int num = (int)openParam;
			num2 = num;
		}
		else
		{
			num2 = 0;
		}
		int num3 = num2;
		UUIArtText artText = base.GetArtText(0);
		if (artText != null)
		{
			artText.SetText(num3.ToString());
		}
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew("WheelTower_NextRoundTips");
		}
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.ShowTextNew("WheelTower_NextRoundName");
		}
		this.RemainTime = 3000f;
	}

	// Token: 0x060073F8 RID: 29688 RVA: 0x0023D7BB File Offset: 0x0023B9BB
	protected override void OnTick(float delta)
	{
		if (this.IsTimerDone)
		{
			return;
		}
		this.RemainTime -= delta;
		if (this.RemainTime <= 0f)
		{
			this.IsTimerDone = true;
			base.CloseMe(null);
		}
	}

	// Token: 0x0400497A RID: 18810
	private const float ShowTimeMs = 3000f;

	// Token: 0x0400497B RID: 18811
	private float RemainTime;

	// Token: 0x0400497C RID: 18812
	private bool IsTimerDone;
}
