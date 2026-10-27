using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200223A RID: 8762
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTaskItem : GridProxyAbstract<MotorTechTaskNode>
{
	// Token: 0x06011186 RID: 70022 RVA: 0x0042B830 File Offset: 0x00429A30
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnBtnIconClick)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnBtnGetClick)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnBtnJumpClick))
		};
	}

	// Token: 0x06011187 RID: 70023 RVA: 0x0042B9A8 File Offset: 0x00429BA8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTaskItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTaskItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011188 RID: 70024 RVA: 0x0042B9EB File Offset: 0x00429BEB
	protected override void OnBeforeDestroy()
	{
		this.RemoveTagCountDownTimer();
	}

	// Token: 0x06011189 RID: 70025 RVA: 0x0042B9F4 File Offset: 0x00429BF4
	public override void Refresh(MotorTechTaskNode data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.TreeType = data.TreeType;
		MotorTask? motorTaskConfig = MotorConfig.Instance.GetMotorTaskConfig(data.TaskId);
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(this.TreeType);
		if (motorTaskConfig == null || motorTechTreeConfig == null)
		{
			return;
		}
		this.JumpId = motorTaskConfig.Value.JumpId;
		int num = data.ProcessInfo.Current;
		int target = data.ProcessInfo.Target;
		string icon = ItemConfig.Instance.GetConfig(motorTechTreeConfig.Value.TpItemId).Value.Icon;
		base.GetText(1).SetText(num.ToString() + "/" + target.ToString(), true);
		base.GetText(8).SetText("+" + motorTaskConfig.Value.RewardTpCount.ToString(), true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), motorTaskConfig.Value.Title, Array.Empty<object>());
		base.SetTextureByPath(icon, base.GetTexture(9), null, null);
		int waitRewardCount = data.RewardInfo.WaitRewardCount;
		int rewardedCount = data.RewardInfo.RewardedCount;
		int maxRewardCount = data.RewardInfo.MaxRewardCount;
		if (waitRewardCount > 0)
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
		}
		else if (maxRewardCount > 0 && rewardedCount >= maxRewardCount)
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(7).SetUIActive(true);
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
		}
		else
		{
			bool flag = motorTaskConfig.Value.JumpId > 0;
			base.GetItem(2).SetUIActive(!flag);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetButton(5).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
		}
		bool flag2 = false;
		if (data.Type == EMotorTechTaskType.Loop)
		{
			flag2 = true;
		}
		else if (data.Type == EMotorTechTaskType.Limited)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			flag2 = ((double)data.EndTime > serverTime);
		}
		this.TagItem.SetUiActive(flag2);
		if (flag2)
		{
			this.TagItem.Refresh(data);
		}
		this.RefreshTagCountDown();
	}

	// Token: 0x0601118A RID: 70026 RVA: 0x0042BCFC File Offset: 0x00429EFC
	private void RefreshTagCountDown()
	{
		this.RemoveTagCountDownTimer();
		if (this.Data == null || this.Data.Type != EMotorTechTaskType.Limited)
		{
			return;
		}
		this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.BeginTagCountDownTimer), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x0601118B RID: 70027 RVA: 0x0042BD58 File Offset: 0x00429F58
	private void BeginTagCountDownTimer(float delta)
	{
		double endTime = (double)this.Data.EndTime;
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (endTime - serverTime <= 0.0)
		{
			this.TagItem.SetUiActive(false);
			this.RemoveTagCountDownTimer();
			return;
		}
		this.TagItem.SetUiActive(true);
		this.TagItem.Refresh(this.Data);
	}

	// Token: 0x0601118C RID: 70028 RVA: 0x0042BDB9 File Offset: 0x00429FB9
	private void RemoveTagCountDownTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0601118D RID: 70029 RVA: 0x0042BDDC File Offset: 0x00429FDC
	private void OnBtnIconClick()
	{
		int tpItemId = MotorConfig.Instance.GetMotorTechTreeConfig(this.TreeType).Value.TpItemId;
		ItemController.Instance.OpenItemTipsByItemId(tpItemId, true, null);
	}

	// Token: 0x0601118E RID: 70030 RVA: 0x0042BE18 File Offset: 0x0042A018
	private void OnBtnGetClick()
	{
		int[] waitRewardTaskIds = MotorcycleDevelopModel.Instance.GetWaitRewardTaskIds(this.TreeType);
		MotorcycleDevelopController.Instance.RequestMotorTechTaskOneKeyReward(waitRewardTaskIds);
	}

	// Token: 0x0601118F RID: 70031 RVA: 0x0042BE41 File Offset: 0x0042A041
	private void OnBtnJumpClick()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x06011190 RID: 70032 RVA: 0x0042BE5C File Offset: 0x0042A05C
	public UUIItem GetBtnGet()
	{
		return base.GetButton(6).RootUIComp.Get();
	}

	// Token: 0x06011191 RID: 70033 RVA: 0x0042BE7D File Offset: 0x0042A07D
	public UUIItem GetNavigationItem()
	{
		return base.GetItem(11);
	}

	// Token: 0x04008236 RID: 33334
	private int TreeType;

	// Token: 0x04008237 RID: 33335
	private int JumpId;

	// Token: 0x04008238 RID: 33336
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04008239 RID: 33337
	[Nullable(2)]
	private MotorcycleTaskTagItem TagItem;

	// Token: 0x0400823A RID: 33338
	[Nullable(2)]
	private MotorTechTaskNode Data;

	// Token: 0x0200876D RID: 34669
	[NullableContext(0)]
	private class EMotorTaskItemComponent
	{
		// Token: 0x0402C04E RID: 180302
		public const int TxtTitle = 0;

		// Token: 0x0402C04F RID: 180303
		public const int TxtProgress = 1;

		// Token: 0x0402C050 RID: 180304
		public const int DoingItem = 2;

		// Token: 0x0402C051 RID: 180305
		public const int DoneItem = 3;

		// Token: 0x0402C052 RID: 180306
		public const int BtnIcon = 4;

		// Token: 0x0402C053 RID: 180307
		public const int BtnJump = 5;

		// Token: 0x0402C054 RID: 180308
		public const int BtnGet = 6;

		// Token: 0x0402C055 RID: 180309
		public const int DoneMaskItem = 7;

		// Token: 0x0402C056 RID: 180310
		public const int TxtAddPointNum = 8;

		// Token: 0x0402C057 RID: 180311
		public const int TexIcon = 9;

		// Token: 0x0402C058 RID: 180312
		public const int TagRoot = 10;

		// Token: 0x0402C059 RID: 180313
		public const int ItemNavigation = 11;
	}
}
