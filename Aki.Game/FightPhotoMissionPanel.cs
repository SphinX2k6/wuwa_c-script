using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025B9 RID: 9657
public class FightPhotoMissionPanel : FightPhotoTabPanelBase
{
	// Token: 0x06013942 RID: 80194 RVA: 0x004E4EE9 File Offset: 0x004E30E9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06013943 RID: 80195 RVA: 0x004E4F24 File Offset: 0x004E3124
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoMissionPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoMissionPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013944 RID: 80196 RVA: 0x004E4F68 File Offset: 0x004E3168
	public UniTask RefreshCondition()
	{
		FightPhotoMissionPanel.<RefreshCondition>d__4 <RefreshCondition>d__;
		<RefreshCondition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCondition>d__.<>4__this = this;
		<RefreshCondition>d__.<>1__state = -1;
		<RefreshCondition>d__.<>t__builder.Start<FightPhotoMissionPanel.<RefreshCondition>d__4>(ref <RefreshCondition>d__);
		return <RefreshCondition>d__.<>t__builder.Task;
	}

	// Token: 0x06013945 RID: 80197 RVA: 0x004E4FAB File Offset: 0x004E31AB
	[NullableContext(1)]
	private FightPhotoConditionItem CreateConditionItem()
	{
		return new FightPhotoConditionItem();
	}

	// Token: 0x040093C4 RID: 37828
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FightPhotoConditionItem, FightPhotoConditionData> ConditionLayout;

	// Token: 0x02008BC2 RID: 35778
	private enum EComponents
	{
		// Token: 0x0402D5CA RID: 185802
		LayoutCondition,
		// Token: 0x0402D5CB RID: 185803
		ItemCondition
	}
}
