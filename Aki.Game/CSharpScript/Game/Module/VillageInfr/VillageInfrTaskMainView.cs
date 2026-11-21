using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037FC RID: 14332
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrTaskMainView : UiViewBase
	{
		// Token: 0x06025435 RID: 152629 RVA: 0x00A829AB File Offset: 0x00A80BAB
		public VillageInfrTaskMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06025436 RID: 152630 RVA: 0x00A829CC File Offset: 0x00A80BCC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x06025437 RID: 152631 RVA: 0x00A82A94 File Offset: 0x00A80C94
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.VillageInfrActivityTaskDataUpdate, new Action(this.OnTaskDataUpdate));
			EventSystem.Instance.Add(EEventName.VillageInfrScoreRewardDataUpdate, new Action(this.OnScoreRewardDataUpdate));
		}

		// Token: 0x06025438 RID: 152632 RVA: 0x00A82ACE File Offset: 0x00A80CCE
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.VillageInfrActivityTaskDataUpdate, new Action(this.OnTaskDataUpdate));
			EventSystem.Instance.Remove(EEventName.VillageInfrScoreRewardDataUpdate, new Action(this.OnScoreRewardDataUpdate));
		}

		// Token: 0x06025439 RID: 152633 RVA: 0x00A82B08 File Offset: 0x00A80D08
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrTaskMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrTaskMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602543A RID: 152634 RVA: 0x00A82B4C File Offset: 0x00A80D4C
		private UniTask CreateCaption()
		{
			VillageInfrTaskMainView.<CreateCaption>d__8 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<VillageInfrTaskMainView.<CreateCaption>d__8>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602543B RID: 152635 RVA: 0x00A82B90 File Offset: 0x00A80D90
		private UniTask CreateBottomPanel()
		{
			VillageInfrTaskMainView.<CreateBottomPanel>d__9 <CreateBottomPanel>d__;
			<CreateBottomPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBottomPanel>d__.<>4__this = this;
			<CreateBottomPanel>d__.<>1__state = -1;
			<CreateBottomPanel>d__.<>t__builder.Start<VillageInfrTaskMainView.<CreateBottomPanel>d__9>(ref <CreateBottomPanel>d__);
			return <CreateBottomPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602543C RID: 152636 RVA: 0x00A82BD3 File Offset: 0x00A80DD3
		private void CreateTaskScroll()
		{
			this.TaskScroll = new GenericScrollViewNew<VillageTaskItem, VillageInfrLimitTaskData>(base.GetScrollViewWithScrollbar(5), delegate()
			{
				VillageTaskItem villageTaskItem = new VillageTaskItem();
				villageTaskItem.SetOnClickConfirm(new Action<VillageInfrLimitTaskData>(this.OnClickConfirm));
				return villageTaskItem;
			}, null, false, null);
		}

		// Token: 0x0602543D RID: 152637 RVA: 0x00A82BF6 File Offset: 0x00A80DF6
		protected override void OnStart()
		{
			this.RefreshTaskList();
		}

		// Token: 0x0602543E RID: 152638 RVA: 0x00A82C00 File Offset: 0x00A80E00
		private void RefreshTaskList()
		{
			List<VillageInfrLimitTaskData> activityTaskDataList = VillageInfrModel.Instance.GetActivityTaskDataList();
			this.TaskScroll.RefreshByData(activityTaskDataList, null, true);
		}

		// Token: 0x0602543F RID: 152639 RVA: 0x00A82C26 File Offset: 0x00A80E26
		private void RefreshBottomPanel()
		{
			this.BottomPanel.Refresh();
		}

		// Token: 0x06025440 RID: 152640 RVA: 0x00A82C33 File Offset: 0x00A80E33
		private void OnTaskDataUpdate()
		{
			this.RefreshTaskList();
			this.RefreshBottomPanel();
		}

		// Token: 0x06025441 RID: 152641 RVA: 0x00A82C41 File Offset: 0x00A80E41
		private void OnScoreRewardDataUpdate()
		{
			this.RefreshTaskList();
			this.RefreshBottomPanel();
		}

		// Token: 0x06025442 RID: 152642 RVA: 0x00A82C50 File Offset: 0x00A80E50
		private void OnClickConfirm(VillageInfrLimitTaskData data)
		{
			List<int> list = new List<int>();
			foreach (VillageInfrLimitTaskData villageInfrLimitTaskData in VillageInfrModel.Instance.GetActivityTaskDataList())
			{
				if (villageInfrLimitTaskData.CanReceive())
				{
					list.Add(villageInfrLimitTaskData.ConfigId);
				}
			}
			if (list.Count > 0)
			{
				VillageInfrController.Instance.RequestInfrV2TaskReward(list).Forget<bool>();
			}
		}

		// Token: 0x04014A03 RID: 84483
		private readonly PopupCaptionItem CaptionItem = new PopupCaptionItem(null);

		// Token: 0x04014A04 RID: 84484
		private readonly VillageInfrTaskBottomPanel BottomPanel = new VillageInfrTaskBottomPanel();

		// Token: 0x04014A05 RID: 84485
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<VillageTaskItem, VillageInfrLimitTaskData> TaskScroll;
	}
}
