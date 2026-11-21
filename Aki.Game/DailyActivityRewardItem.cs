using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EB6 RID: 3766
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DailyActivityRewardItem : GridProxyAbstract<DailyActivityRewardData>
{
	// Token: 0x0600968C RID: 38540 RVA: 0x002C94BB File Offset: 0x002C76BB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600968D RID: 38541 RVA: 0x002C94F4 File Offset: 0x002C76F4
	protected override UniTask OnBeforeStartAsync()
	{
		DailyActivityRewardItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DailyActivityRewardItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600968E RID: 38542 RVA: 0x002C9538 File Offset: 0x002C7738
	[NullableContext(1)]
	public override void Refresh(DailyActivityRewardData data, bool isSelected, int gridIndex)
	{
		double progress = data.Progress;
		float num = (float)(gridIndex + 1) / (float)data.MaxIndex;
		float num2 = (float)gridIndex / (float)data.MaxIndex;
		if (progress >= (double)num)
		{
			this.ProgressSprite.SetFillAmount(1f);
		}
		else
		{
			double num3 = progress - (double)num2;
			double num4 = (num3 > 0.0) ? (num3 / (double)(num - num2)) : 0.0;
			this.ProgressSprite.SetFillAmount((float)num4);
		}
		this.Data = data;
		this.RewardItem.Refresh(data.RewardId, isSelected, gridIndex);
		this.DailyActiveState = this.RewardItem.DailyActiveState;
	}

	// Token: 0x0600968F RID: 38543 RVA: 0x002C95D8 File Offset: 0x002C77D8
	public void RefreshProgress(double progress)
	{
		this.Data.Progress = progress;
		this.RefreshSelf();
	}

	// Token: 0x06009690 RID: 38544 RVA: 0x002C95EC File Offset: 0x002C77EC
	public void RefreshSelf()
	{
		this.Refresh(this.Data, false, base.GridIndex);
	}

	// Token: 0x06009691 RID: 38545 RVA: 0x002C9604 File Offset: 0x002C7804
	public UniTask PlayRewardAnimAsync()
	{
		DailyActivityRewardItem.<PlayRewardAnimAsync>d__12 <PlayRewardAnimAsync>d__;
		<PlayRewardAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRewardAnimAsync>d__.<>4__this = this;
		<PlayRewardAnimAsync>d__.<>1__state = -1;
		<PlayRewardAnimAsync>d__.<>t__builder.Start<DailyActivityRewardItem.<PlayRewardAnimAsync>d__12>(ref <PlayRewardAnimAsync>d__);
		return <PlayRewardAnimAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04005A59 RID: 23129
	private UUISprite ProgressSprite;

	// Token: 0x04005A5A RID: 23130
	private DailyActivityRewardItemContent RewardItem;

	// Token: 0x04005A5B RID: 23131
	private DailyActivityRewardData Data;

	// Token: 0x04005A5C RID: 23132
	public EDailyActiveState? DailyActiveState;

	// Token: 0x04005A5D RID: 23133
	public Action RewardRequestDelegate;

	// Token: 0x04005A5E RID: 23134
	public DailyActivityDefine.IActivityRewardPanelDataAdapter DataAdapter;

	// Token: 0x04005A5F RID: 23135
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RewardPopupData> ShowRewardPopupDelegate;
}
