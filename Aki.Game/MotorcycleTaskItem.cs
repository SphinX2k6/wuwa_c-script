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

// Token: 0x0200171E RID: 5918
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTaskItem : GridProxyAbstract<MotorTechTaskNode>
{
	// Token: 0x0600E61C RID: 58908 RVA: 0x004383D4 File Offset: 0x004365D4
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

	// Token: 0x0600E61D RID: 58909 RVA: 0x0043854C File Offset: 0x0043674C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTaskItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTaskItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E61E RID: 58910 RVA: 0x0043858F File Offset: 0x0043678F
	protected override void OnBeforeDestroy()
	{
		this.RemoveTagCountDownTimer();
	}

	// Token: 0x0600E61F RID: 58911 RVA: 0x00438598 File Offset: 0x00436798
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

	// Token: 0x0600E620 RID: 58912 RVA: 0x004388A0 File Offset: 0x00436AA0
	private void RefreshTagCountDown()
	{
		this.RemoveTagCountDownTimer();
		if (this.Data == null || this.Data.Type != EMotorTechTaskType.Limited)
		{
			return;
		}
		this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.BeginTagCountDownTimer), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x0600E621 RID: 58913 RVA: 0x004388FC File Offset: 0x00436AFC
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

	// Token: 0x0600E622 RID: 58914 RVA: 0x0043895D File Offset: 0x00436B5D
	private void RemoveTagCountDownTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600E623 RID: 58915 RVA: 0x00438980 File Offset: 0x00436B80
	private void OnBtnIconClick()
	{
		int tpItemId = MotorConfig.Instance.GetMotorTechTreeConfig(this.TreeType).Value.TpItemId;
		ItemController.Instance.OpenItemTipsByItemId(tpItemId, true, null, false);
	}

	// Token: 0x0600E624 RID: 58916 RVA: 0x004389BC File Offset: 0x00436BBC
	private void OnBtnGetClick()
	{
		int[] waitRewardTaskIds = MotorcycleDevelopModel.Instance.GetWaitRewardTaskIds(this.TreeType);
		MotorcycleDevelopController.Instance.RequestMotorTechTaskOneKeyReward(waitRewardTaskIds);
	}

	// Token: 0x0600E625 RID: 58917 RVA: 0x004389E5 File Offset: 0x00436BE5
	private void OnBtnJumpClick()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x0600E626 RID: 58918 RVA: 0x00438A00 File Offset: 0x00436C00
	public UUIItem GetBtnGet()
	{
		return base.GetButton(6).RootUIComp.Get();
	}

	// Token: 0x0600E627 RID: 58919 RVA: 0x00438A21 File Offset: 0x00436C21
	public UUIItem GetNavigationItem()
	{
		return base.GetItem(11);
	}

	// Token: 0x04008374 RID: 33652
	private int TreeType;

	// Token: 0x04008375 RID: 33653
	private int JumpId;

	// Token: 0x04008376 RID: 33654
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04008377 RID: 33655
	[Nullable(2)]
	private MotorcycleTaskTagItem TagItem;

	// Token: 0x04008378 RID: 33656
	[Nullable(2)]
	private MotorTechTaskNode Data;

	// Token: 0x020078F6 RID: 30966
	[NullableContext(0)]
	private class EMotorTaskItemComponent
	{
		// Token: 0x04027366 RID: 160614
		public const int TxtTitle = 0;

		// Token: 0x04027367 RID: 160615
		public const int TxtProgress = 1;

		// Token: 0x04027368 RID: 160616
		public const int DoingItem = 2;

		// Token: 0x04027369 RID: 160617
		public const int DoneItem = 3;

		// Token: 0x0402736A RID: 160618
		public const int BtnIcon = 4;

		// Token: 0x0402736B RID: 160619
		public const int BtnJump = 5;

		// Token: 0x0402736C RID: 160620
		public const int BtnGet = 6;

		// Token: 0x0402736D RID: 160621
		public const int DoneMaskItem = 7;

		// Token: 0x0402736E RID: 160622
		public const int TxtAddPointNum = 8;

		// Token: 0x0402736F RID: 160623
		public const int TexIcon = 9;

		// Token: 0x04027370 RID: 160624
		public const int TagRoot = 10;

		// Token: 0x04027371 RID: 160625
		public const int ItemNavigation = 11;
	}
}
