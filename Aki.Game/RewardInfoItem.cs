using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EFA RID: 3834
[NullableContext(1)]
[Nullable(0)]
internal class RewardInfoItem : UiPanelBase
{
	// Token: 0x06009985 RID: 39301 RVA: 0x002D7D4C File Offset: 0x002D5F4C
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

	// Token: 0x06009986 RID: 39302 RVA: 0x002D7DD4 File Offset: 0x002D5FD4
	protected override UniTask OnBeforeStartAsync()
	{
		RewardInfoItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RewardInfoItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009987 RID: 39303 RVA: 0x002D7E17 File Offset: 0x002D6017
	public void SetTitle(string title)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(title, true);
	}

	// Token: 0x06009988 RID: 39304 RVA: 0x002D7E2C File Offset: 0x002D602C
	public void SetProgress(float progress)
	{
		UUISliderComponent slider = base.GetSlider(2);
		if (slider == null)
		{
			return;
		}
		slider.SetValue(progress, true);
	}

	// Token: 0x06009989 RID: 39305 RVA: 0x002D7E41 File Offset: 0x002D6041
	public void RefreshByProgress(float progress)
	{
		this.SetProgress(progress);
		this.RefreshRewardItem(progress);
	}

	// Token: 0x0600998A RID: 39306 RVA: 0x002D7E51 File Offset: 0x002D6051
	private void RefreshRewardItem(float progress)
	{
		DangoAbyssBattleTreasureRoot dangoAbyssBattleTreasureRoot = this.DangoAbyssBattleTreasureRoot;
		if (dangoAbyssBattleTreasureRoot == null)
		{
			return;
		}
		dangoAbyssBattleTreasureRoot.RefreshRewardItem(progress * 100f);
	}

	// Token: 0x04005BDA RID: 23514
	public Dictionary<int, int> RewardTimeMap = new Dictionary<int, int>();

	// Token: 0x04005BDB RID: 23515
	public float FullTime;

	// Token: 0x04005BDC RID: 23516
	[Nullable(2)]
	private DangoAbyssBattleTreasureRoot DangoAbyssBattleTreasureRoot;
}
