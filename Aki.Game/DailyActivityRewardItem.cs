using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019F7 RID: 6647
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DailyActivityRewardItem : GridProxyAbstract<DailyActivityRewardData>
{
	// Token: 0x0600C27F RID: 49791 RVA: 0x002BE4E3 File Offset: 0x002BC6E3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600C280 RID: 49792 RVA: 0x002BE51C File Offset: 0x002BC71C
	protected override UniTask OnBeforeStartAsync()
	{
		DailyActivityRewardItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DailyActivityRewardItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C281 RID: 49793 RVA: 0x002BE560 File Offset: 0x002BC760
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

	// Token: 0x0600C282 RID: 49794 RVA: 0x002BE600 File Offset: 0x002BC800
	public void RefreshProgress(double progress)
	{
		this.Data.Progress = progress;
		this.RefreshSelf();
	}

	// Token: 0x0600C283 RID: 49795 RVA: 0x002BE614 File Offset: 0x002BC814
	public void RefreshSelf()
	{
		this.Refresh(this.Data, false, base.GridIndex);
	}

	// Token: 0x0600C284 RID: 49796 RVA: 0x002BE62C File Offset: 0x002BC82C
	public UniTask PlayRewardAnimAsync()
	{
		DailyActivityRewardItem.<PlayRewardAnimAsync>d__12 <PlayRewardAnimAsync>d__;
		<PlayRewardAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRewardAnimAsync>d__.<>4__this = this;
		<PlayRewardAnimAsync>d__.<>1__state = -1;
		<PlayRewardAnimAsync>d__.<>t__builder.Start<DailyActivityRewardItem.<PlayRewardAnimAsync>d__12>(ref <PlayRewardAnimAsync>d__);
		return <PlayRewardAnimAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400598A RID: 22922
	private UUISprite ProgressSprite;

	// Token: 0x0400598B RID: 22923
	private DailyActivityRewardItemContent RewardItem;

	// Token: 0x0400598C RID: 22924
	private DailyActivityRewardData Data;

	// Token: 0x0400598D RID: 22925
	public EDailyActiveState? DailyActiveState;

	// Token: 0x0400598E RID: 22926
	public Action RewardRequestDelegate;

	// Token: 0x0400598F RID: 22927
	public DailyActivityDefine.IActivityRewardPanelDataAdapter DataAdapter;

	// Token: 0x04005990 RID: 22928
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RewardPopupData> ShowRewardPopupDelegate;
}
