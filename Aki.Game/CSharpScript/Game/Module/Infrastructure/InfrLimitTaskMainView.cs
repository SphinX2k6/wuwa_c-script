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
	// Token: 0x0200590F RID: 22799
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrLimitTaskMainView : UiViewBase
	{
		// Token: 0x06039E50 RID: 237136 RVA: 0x00DC068F File Offset: 0x00DBE88F
		public InfrLimitTaskMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06039E51 RID: 237137 RVA: 0x00DC06A4 File Offset: 0x00DBE8A4
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

		// Token: 0x06039E52 RID: 237138 RVA: 0x00DC07B2 File Offset: 0x00DBE9B2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.InfrastructureActivityTaskDataUpdate, new Action(this.OnInfrastructureActivityTaskDataUpdate));
		}

		// Token: 0x06039E53 RID: 237139 RVA: 0x00DC07D0 File Offset: 0x00DBE9D0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.InfrastructureActivityTaskDataUpdate, new Action(this.OnInfrastructureActivityTaskDataUpdate));
		}

		// Token: 0x06039E54 RID: 237140 RVA: 0x00DC07F0 File Offset: 0x00DBE9F0
		protected override UniTask OnBeforeStartAsync()
		{
			InfrLimitTaskMainView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrLimitTaskMainView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039E55 RID: 237141 RVA: 0x00DC0833 File Offset: 0x00DBEA33
		private InfrLimitTaskItem CreateTaskItem()
		{
			InfrLimitTaskItem infrLimitTaskItem = new InfrLimitTaskItem();
			infrLimitTaskItem.SetOnClickRewardCb(new Action(this.OnClickGetTaskReward));
			return infrLimitTaskItem;
		}

		// Token: 0x06039E56 RID: 237142 RVA: 0x00DC084C File Offset: 0x00DBEA4C
		private UniTask CreateTaskScroll()
		{
			InfrLimitTaskMainView.<CreateTaskScroll>d__8 <CreateTaskScroll>d__;
			<CreateTaskScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTaskScroll>d__.<>4__this = this;
			<CreateTaskScroll>d__.<>1__state = -1;
			<CreateTaskScroll>d__.<>t__builder.Start<InfrLimitTaskMainView.<CreateTaskScroll>d__8>(ref <CreateTaskScroll>d__);
			return <CreateTaskScroll>d__.<>t__builder.Task;
		}

		// Token: 0x06039E57 RID: 237143 RVA: 0x00DC088F File Offset: 0x00DBEA8F
		protected override void OnStart()
		{
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCloseBtn));
			this.RefreshTime();
		}

		// Token: 0x06039E58 RID: 237144 RVA: 0x00DC08C8 File Offset: 0x00DBEAC8
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

		// Token: 0x06039E59 RID: 237145 RVA: 0x00DC0920 File Offset: 0x00DBEB20
		private void OnInfrastructureActivityTaskDataUpdate()
		{
			InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			this.TaskScroll.RefreshByData(activityData.GetActivityTaskDataList(), false, null, false);
		}

		// Token: 0x06039E5A RID: 237146 RVA: 0x00DC0950 File Offset: 0x00DBEB50
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

		// Token: 0x06039E5B RID: 237147 RVA: 0x00DC09BC File Offset: 0x00DBEBBC
		private void OnClickHelpBtn()
		{
			int helpIdActivity = InfrastructureConfig.Instance.GetHelpIdActivity();
			HelpController.Instance.OpenHelpById(helpIdActivity);
		}

		// Token: 0x06039E5C RID: 237148 RVA: 0x00DC09DF File Offset: 0x00DBEBDF
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401E318 RID: 123672
		private readonly PopupCaptionItem CaptionItem = new PopupCaptionItem(null);

		// Token: 0x0401E319 RID: 123673
		private LoopScrollView<InfrLimitTaskItem, InfrastructureLimitTaskData> TaskScroll;

		// Token: 0x0200BB7E RID: 47998
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038983 RID: 231811
			public const int CaptionItem = 0;

			// Token: 0x04038984 RID: 231812
			public const int TextTitle = 1;

			// Token: 0x04038985 RID: 231813
			public const int TextDesc = 2;

			// Token: 0x04038986 RID: 231814
			public const int LoopScrollViewReward = 3;

			// Token: 0x04038987 RID: 231815
			public const int PanelReward = 4;

			// Token: 0x04038988 RID: 231816
			public const int TextTime = 5;

			// Token: 0x04038989 RID: 231817
			public const int PanelTime = 6;
		}
	}
}
