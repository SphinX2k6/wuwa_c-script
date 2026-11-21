using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048E8 RID: 18664
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrLimitTaskMainView : UiViewBase
	{
		// Token: 0x0602ED73 RID: 191859 RVA: 0x00D0F987 File Offset: 0x00D0DB87
		public InfrLimitTaskMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602ED74 RID: 191860 RVA: 0x00D0F99C File Offset: 0x00D0DB9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602ED75 RID: 191861 RVA: 0x00D0FAAA File Offset: 0x00D0DCAA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.InfrastructureActivityTaskDataUpdate, new Action(this.OnInfrastructureActivityTaskDataUpdate));
		}

		// Token: 0x0602ED76 RID: 191862 RVA: 0x00D0FAC8 File Offset: 0x00D0DCC8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.InfrastructureActivityTaskDataUpdate, new Action(this.OnInfrastructureActivityTaskDataUpdate));
		}

		// Token: 0x0602ED77 RID: 191863 RVA: 0x00D0FAE8 File Offset: 0x00D0DCE8
		protected override UniTask OnBeforeStartAsync()
		{
			InfrLimitTaskMainView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrLimitTaskMainView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED78 RID: 191864 RVA: 0x00D0FB2B File Offset: 0x00D0DD2B
		private InfrLimitTaskItem CreateTaskItem()
		{
			InfrLimitTaskItem infrLimitTaskItem = new InfrLimitTaskItem();
			infrLimitTaskItem.SetOnClickRewardCb(new Action(this.OnClickGetTaskReward));
			return infrLimitTaskItem;
		}

		// Token: 0x0602ED79 RID: 191865 RVA: 0x00D0FB44 File Offset: 0x00D0DD44
		private UniTask CreateTaskScroll()
		{
			InfrLimitTaskMainView.<CreateTaskScroll>d__8 <CreateTaskScroll>d__;
			<CreateTaskScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTaskScroll>d__.<>4__this = this;
			<CreateTaskScroll>d__.<>1__state = -1;
			<CreateTaskScroll>d__.<>t__builder.Start<InfrLimitTaskMainView.<CreateTaskScroll>d__8>(ref <CreateTaskScroll>d__);
			return <CreateTaskScroll>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED7A RID: 191866 RVA: 0x00D0FB87 File Offset: 0x00D0DD87
		protected override void OnStart()
		{
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseBtn));
			this.RefreshTime();
		}

		// Token: 0x0602ED7B RID: 191867 RVA: 0x00D0FBC0 File Offset: 0x00D0DDC0
		private void RefreshTime()
		{
			InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			CommonDefine.ICountDown activityCountDownData = activityData.GetActivityCountDownData();
			base.GetText(5).SetText(activityCountDownData.CountDownText ?? "", true);
			if (activityData.EndOpenTime <= 0L)
			{
				base.GetItem(6).SetUIActive(false);
			}
		}

		// Token: 0x0602ED7C RID: 191868 RVA: 0x00D0FC18 File Offset: 0x00D0DE18
		private void OnInfrastructureActivityTaskDataUpdate()
		{
			InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			this.TaskScroll.RefreshByData(activityData.GetActivityTaskDataList(), false, null, false);
		}

		// Token: 0x0602ED7D RID: 191869 RVA: 0x00D0FC48 File Offset: 0x00D0DE48
		private void OnClickGetTaskReward()
		{
			InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			List<InfrastructureLimitTaskData> activityTaskDataListByStatus = activityData.GetActivityTaskDataListByStatus(ActivityTaskState.ActivityTaskFinish);
			if (activityTaskDataListByStatus.Count == 0)
			{
				return;
			}
			InfrastructureController.Instance.RequestInfrLimitTaskRewardRequest(activityData.Id, activityTaskDataListByStatus.ConvertAll<int>((InfrastructureLimitTaskData task) => task.ConfigId).ToArray()).Forget<bool>();
		}

		// Token: 0x0602ED7E RID: 191870 RVA: 0x00D0FCB4 File Offset: 0x00D0DEB4
		private void OnClickHelpBtn()
		{
			int helpIdActivity = InfrastructureConfig.Instance.GetHelpIdActivity();
			HelpController.Instance.OpenHelpById(helpIdActivity);
		}

		// Token: 0x0602ED7F RID: 191871 RVA: 0x00D0FCD7 File Offset: 0x00D0DED7
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x04018DB5 RID: 101813
		private readonly PopupCaptionItem CaptionItem = new PopupCaptionItem(null);

		// Token: 0x04018DB6 RID: 101814
		private LoopScrollView<InfrLimitTaskItem, InfrastructureLimitTaskData> TaskScroll;

		// Token: 0x0200A58E RID: 42382
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403336B RID: 209771
			public const int CaptionItem = 0;

			// Token: 0x0403336C RID: 209772
			public const int TextTitle = 1;

			// Token: 0x0403336D RID: 209773
			public const int TextDesc = 2;

			// Token: 0x0403336E RID: 209774
			public const int LoopScrollViewReward = 3;

			// Token: 0x0403336F RID: 209775
			public const int PanelReward = 4;

			// Token: 0x04033370 RID: 209776
			public const int TextTime = 5;

			// Token: 0x04033371 RID: 209777
			public const int PanelTime = 6;
		}
	}
}
