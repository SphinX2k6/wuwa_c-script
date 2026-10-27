using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A3B RID: 6715
[NullableContext(1)]
[Nullable(0)]
internal class RewardInfoItem : UiPanelBase
{
	// Token: 0x0600C575 RID: 50549 RVA: 0x002CCC28 File Offset: 0x002CAE28
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600C576 RID: 50550 RVA: 0x002CCCB0 File Offset: 0x002CAEB0
	protected override UniTask OnBeforeStartAsync()
	{
		RewardInfoItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RewardInfoItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C577 RID: 50551 RVA: 0x002CCCF3 File Offset: 0x002CAEF3
	public void SetTitle(string title)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(title, true);
	}

	// Token: 0x0600C578 RID: 50552 RVA: 0x002CCD08 File Offset: 0x002CAF08
	public void SetProgress(float progress)
	{
		UUISliderComponent slider = base.GetSlider(2);
		if (slider == null)
		{
			return;
		}
		slider.SetValue(progress, true);
	}

	// Token: 0x0600C579 RID: 50553 RVA: 0x002CCD1D File Offset: 0x002CAF1D
	public void RefreshByProgress(float progress)
	{
		this.SetProgress(progress);
		this.RefreshRewardItem(progress);
	}

	// Token: 0x0600C57A RID: 50554 RVA: 0x002CCD2D File Offset: 0x002CAF2D
	private void RefreshRewardItem(float progress)
	{
		DangoAbyssBattleTreasureRoot dangoAbyssBattleTreasureRoot = this.DangoAbyssBattleTreasureRoot;
		if (dangoAbyssBattleTreasureRoot == null)
		{
			return;
		}
		dangoAbyssBattleTreasureRoot.RefreshRewardItem(progress * 100f);
	}

	// Token: 0x04005B0B RID: 23307
	public Dictionary<int, int> RewardTimeMap = new Dictionary<int, int>();

	// Token: 0x04005B0C RID: 23308
	public float FullTime;

	// Token: 0x04005B0D RID: 23309
	[Nullable(2)]
	private DangoAbyssBattleTreasureRoot DangoAbyssBattleTreasureRoot;
}
