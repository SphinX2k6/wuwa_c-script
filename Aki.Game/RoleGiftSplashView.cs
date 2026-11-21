using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200096F RID: 2415
public class RoleGiftSplashView : UiViewBase
{
	// Token: 0x06006A01 RID: 27137 RVA: 0x00210A84 File Offset: 0x0020EC84
	[NullableContext(1)]
	public RoleGiftSplashView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006A02 RID: 27138 RVA: 0x00210A90 File Offset: 0x0020EC90
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006A03 RID: 27139 RVA: 0x00210B36 File Offset: 0x0020ED36
	protected override void OnBeforeShow()
	{
		this.FinishRoleGiftSplashScreenTask();
	}

	// Token: 0x06006A04 RID: 27140 RVA: 0x00210B3E File Offset: 0x0020ED3E
	private void FinishRoleGiftSplashScreenTask()
	{
		if (this.SplashScreenTaskFinished)
		{
			return;
		}
		this.SplashScreenTaskFinished = true;
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.RoleGiftActivity);
	}

	// Token: 0x06006A05 RID: 27141 RVA: 0x00210B5C File Offset: 0x0020ED5C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleGiftSplashView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleGiftSplashView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006A06 RID: 27142 RVA: 0x00210B9F File Offset: 0x0020ED9F
	protected override void OnStart()
	{
		this.RefreshRoleDesc();
	}

	// Token: 0x06006A07 RID: 27143 RVA: 0x00210BA8 File Offset: 0x0020EDA8
	private unsafe void RefreshRoleDesc()
	{
		RoleGiftData roleGiftDataCached = this.RoleGiftDataCached;
		if (roleGiftDataCached == null)
		{
			return;
		}
		int roleId = roleGiftDataCached.GetRoleId();
		if (roleId > 0)
		{
			RoleDescribeComponent descComponent = this.DescComponent;
			if (descComponent == null)
			{
				return;
			}
			descComponent.Update(roleId, false);
			return;
		}
		else
		{
			string message = "RoleGiftSplashView";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", "invalid_role_id");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("activityId", this.ActivityIdCached);
			RoleGiftUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06006A08 RID: 27144 RVA: 0x00210C48 File Offset: 0x0020EE48
	private unsafe void OnClickLook()
	{
		RoleGiftData roleGiftDataCached = this.RoleGiftDataCached;
		if (roleGiftDataCached == null)
		{
			string message = "RoleGiftSplashView OnClickLook";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", "no_gift_data");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("activityId", this.ActivityIdCached);
			RoleGiftUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		int roleTrialId = roleGiftDataCached.GetRoleTrialId();
		if (roleTrialId == 0)
		{
			string message2 = "RoleGiftSplashView OnClickLook";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("reason", "no_role_trial_id");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("activityId", roleGiftDataCached.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("roleId", roleGiftDataCached.GetRoleId());
			RoleGiftUtil.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return;
		}
		RoleController instance = RoleController.Instance;
		ERoleAgentType agentType = ERoleAgentType.Preview;
		int selectRoleId = 0;
		int num = 1;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int index = 0;
		*span[index] = roleTrialId;
		instance.OpenRoleMainView(agentType, selectRoleId, list, null, null);
	}

	// Token: 0x06006A09 RID: 27145 RVA: 0x00210D7C File Offset: 0x0020EF7C
	private void OnBtnConfirmClick()
	{
		int activityIdCached = this.ActivityIdCached;
		if (activityIdCached <= 0)
		{
			return;
		}
		this.FinishRoleGiftSplashScreenTask();
		SkipTaskManager.Run(ESkipName.SkipToActivity, new object[]
		{
			activityIdCached
		});
		base.CloseMe(null);
	}

	// Token: 0x040042FB RID: 17147
	private int ActivityIdCached;

	// Token: 0x040042FC RID: 17148
	[Nullable(2)]
	private RoleGiftData RoleGiftDataCached;

	// Token: 0x040042FD RID: 17149
	[Nullable(2)]
	private RoleDescribeComponent DescComponent;

	// Token: 0x040042FE RID: 17150
	private bool SplashScreenTaskFinished;

	// Token: 0x02006C77 RID: 27767
	private enum ENode
	{
		// Token: 0x04023A34 RID: 145972
		ItemRoleDesc,
		// Token: 0x04023A35 RID: 145973
		BtnConfirm
	}
}
