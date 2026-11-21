using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200209E RID: 8350
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsScoreProgressPanel : UiPanelBase
{
	// Token: 0x06014919 RID: 84249 RVA: 0x005FEB40 File Offset: 0x005FCD40
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

	// Token: 0x0601491A RID: 84250 RVA: 0x005FEBC6 File Offset: 0x005FCDC6
	protected override void OnStart()
	{
		this.ProgressLayout = new GenericLayout<SurvivorsScoreProgressItem, SurvivorsMilestoneData>(base.GetHorizontalLayout(1), new Func<SurvivorsScoreProgressItem>(this.ProgressItemProxyCreate), null, false, true);
		this.ProgressBarWidth = base.GetSprite(4).GetWidth();
	}

	// Token: 0x0601491B RID: 84251 RVA: 0x005FEBFB File Offset: 0x005FCDFB
	private SurvivorsScoreProgressItem ProgressItemProxyCreate()
	{
		return new SurvivorsScoreProgressItem
		{
			OnClickToGet = this.OnClickToGet
		};
	}

	// Token: 0x0601491C RID: 84252 RVA: 0x005FEC10 File Offset: 0x005FCE10
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

	// Token: 0x0400AEAD RID: 44717
	protected GenericLayout<SurvivorsScoreProgressItem, SurvivorsMilestoneData> ProgressLayout;

	// Token: 0x0400AEAE RID: 44718
	protected float ProgressBarWidth;

	// Token: 0x0400AEAF RID: 44719
	[Nullable(2)]
	public Action OnClickToGet;

	// Token: 0x0400AEB0 RID: 44720
	private const float REWARD_ITEM_WIDTH = 108f;
}
