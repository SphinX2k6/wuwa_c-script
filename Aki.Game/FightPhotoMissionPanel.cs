using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AA4 RID: 6820
public class FightPhotoMissionPanel : FightPhotoTabPanelBase
{
	// Token: 0x06010E22 RID: 69154 RVA: 0x004F3AE9 File Offset: 0x004F1CE9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06010E23 RID: 69155 RVA: 0x004F3B24 File Offset: 0x004F1D24
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoMissionPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoMissionPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010E24 RID: 69156 RVA: 0x004F3B68 File Offset: 0x004F1D68
	public UniTask RefreshCondition()
	{
		FightPhotoMissionPanel.<RefreshCondition>d__4 <RefreshCondition>d__;
		<RefreshCondition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCondition>d__.<>4__this = this;
		<RefreshCondition>d__.<>1__state = -1;
		<RefreshCondition>d__.<>t__builder.Start<FightPhotoMissionPanel.<RefreshCondition>d__4>(ref <RefreshCondition>d__);
		return <RefreshCondition>d__.<>t__builder.Task;
	}

	// Token: 0x06010E25 RID: 69157 RVA: 0x004F3BAB File Offset: 0x004F1DAB
	[NullableContext(1)]
	private FightPhotoConditionItem CreateConditionItem()
	{
		return new FightPhotoConditionItem();
	}

	// Token: 0x0400951A RID: 38170
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FightPhotoConditionItem, FightPhotoConditionData> ConditionLayout;

	// Token: 0x02007D4A RID: 32074
	private enum EComponents
	{
		// Token: 0x040288DF RID: 166111
		LayoutCondition,
		// Token: 0x040288E0 RID: 166112
		ItemCondition
	}
}
