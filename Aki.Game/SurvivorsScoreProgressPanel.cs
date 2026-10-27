using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B22 RID: 11042
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsScoreProgressPanel : UiPanelBase
{
	// Token: 0x06016EE8 RID: 93928 RVA: 0x005D1FC4 File Offset: 0x005D01C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
	}

	// Token: 0x06016EE9 RID: 93929 RVA: 0x005D204A File Offset: 0x005D024A
	protected override void OnStart()
	{
		this.ProgressLayout = new GenericLayout<SurvivorsScoreProgressItem, SurvivorsMilestoneData>(base.GetHorizontalLayout(1), new Func<SurvivorsScoreProgressItem>(this.ProgressItemProxyCreate), null, false, true);
		this.ProgressBarWidth = base.GetSprite(4).GetWidth();
	}

	// Token: 0x06016EEA RID: 93930 RVA: 0x005D207F File Offset: 0x005D027F
	private SurvivorsScoreProgressItem ProgressItemProxyCreate()
	{
		return new SurvivorsScoreProgressItem
		{
			OnClickToGet = this.OnClickToGet
		};
	}

	// Token: 0x06016EEB RID: 93931 RVA: 0x005D2094 File Offset: 0x005D0294
	public UniTask RefreshProgressItem(int currentProgress, IReadOnlyList<SurvivorsMilestoneData> dataList)
	{
		SurvivorsScoreProgressPanel.<RefreshProgressItem>d__7 <RefreshProgressItem>d__;
		<RefreshProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshProgressItem>d__.<>4__this = this;
		<RefreshProgressItem>d__.currentProgress = currentProgress;
		<RefreshProgressItem>d__.dataList = dataList;
		<RefreshProgressItem>d__.<>1__state = -1;
		<RefreshProgressItem>d__.<>t__builder.Start<SurvivorsScoreProgressPanel.<RefreshProgressItem>d__7>(ref <RefreshProgressItem>d__);
		return <RefreshProgressItem>d__.<>t__builder.Task;
	}

	// Token: 0x0400AAA7 RID: 43687
	protected GenericLayout<SurvivorsScoreProgressItem, SurvivorsMilestoneData> ProgressLayout;

	// Token: 0x0400AAA8 RID: 43688
	protected float ProgressBarWidth;

	// Token: 0x0400AAA9 RID: 43689
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x0400AAAA RID: 43690
	private const float REWARD_ITEM_WIDTH = 108f;
}
