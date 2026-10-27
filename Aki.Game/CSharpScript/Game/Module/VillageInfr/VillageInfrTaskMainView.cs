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
	// Token: 0x02004885 RID: 18565
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrTaskMainView : UiViewBase
	{
		// Token: 0x06030909 RID: 198921 RVA: 0x00B47BD6 File Offset: 0x00B45DD6
		public VillageInfrTaskMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603090A RID: 198922 RVA: 0x00B47BF8 File Offset: 0x00B45DF8
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

		// Token: 0x0603090B RID: 198923 RVA: 0x00B47CC0 File Offset: 0x00B45EC0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.VillageInfrActivityTaskDataUpdate, new Action(this.OnTaskDataUpdate));
			EventSystem.Instance.Add(EEventName.VillageInfrScoreRewardDataUpdate, new Action(this.OnScoreRewardDataUpdate));
		}

		// Token: 0x0603090C RID: 198924 RVA: 0x00B47CFA File Offset: 0x00B45EFA
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.VillageInfrActivityTaskDataUpdate, new Action(this.OnTaskDataUpdate));
			EventSystem.Instance.Remove(EEventName.VillageInfrScoreRewardDataUpdate, new Action(this.OnScoreRewardDataUpdate));
		}

		// Token: 0x0603090D RID: 198925 RVA: 0x00B47D34 File Offset: 0x00B45F34
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrTaskMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrTaskMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603090E RID: 198926 RVA: 0x00B47D78 File Offset: 0x00B45F78
		private UniTask CreateCaption()
		{
			VillageInfrTaskMainView.<CreateCaption>d__8 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<VillageInfrTaskMainView.<CreateCaption>d__8>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0603090F RID: 198927 RVA: 0x00B47DBC File Offset: 0x00B45FBC
		private UniTask CreateBottomPanel()
		{
			VillageInfrTaskMainView.<CreateBottomPanel>d__9 <CreateBottomPanel>d__;
			<CreateBottomPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBottomPanel>d__.<>4__this = this;
			<CreateBottomPanel>d__.<>1__state = -1;
			<CreateBottomPanel>d__.<>t__builder.Start<VillageInfrTaskMainView.<CreateBottomPanel>d__9>(ref <CreateBottomPanel>d__);
			return <CreateBottomPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06030910 RID: 198928 RVA: 0x00B47DFF File Offset: 0x00B45FFF
		private void CreateTaskScroll()
		{
			this.TaskScroll = new GenericScrollViewNew<VillageTaskItem, VillageInfrLimitTaskData>(base.GetScrollViewWithScrollbar(5), delegate()
			{
				VillageTaskItem villageTaskItem = new VillageTaskItem();
				villageTaskItem.SetOnClickConfirm(new Action<VillageInfrLimitTaskData>(this.OnClickConfirm));
				return villageTaskItem;
			}, null, false, null);
		}

		// Token: 0x06030911 RID: 198929 RVA: 0x00B47E22 File Offset: 0x00B46022
		protected override void OnStart()
		{
			this.RefreshTaskList();
		}

		// Token: 0x06030912 RID: 198930 RVA: 0x00B47E2C File Offset: 0x00B4602C
		private void RefreshTaskList()
		{
			List<VillageInfrLimitTaskData> activityTaskDataList = VillageInfrModel.Instance.GetActivityTaskDataList();
			this.TaskScroll.RefreshByData(activityTaskDataList, null, true);
		}

		// Token: 0x06030913 RID: 198931 RVA: 0x00B47E52 File Offset: 0x00B46052
		private void RefreshBottomPanel()
		{
			this.BottomPanel.Refresh();
		}

		// Token: 0x06030914 RID: 198932 RVA: 0x00B47E5F File Offset: 0x00B4605F
		private void OnTaskDataUpdate()
		{
			this.RefreshTaskList();
			this.RefreshBottomPanel();
		}

		// Token: 0x06030915 RID: 198933 RVA: 0x00B47E6D File Offset: 0x00B4606D
		private void OnScoreRewardDataUpdate()
		{
			this.RefreshTaskList();
			this.RefreshBottomPanel();
		}

		// Token: 0x06030916 RID: 198934 RVA: 0x00B47E7C File Offset: 0x00B4607C
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

		// Token: 0x0401A190 RID: 106896
		private readonly PopupCaptionItem CaptionItem = new PopupCaptionItem(null);

		// Token: 0x0401A191 RID: 106897
		private readonly VillageInfrTaskBottomPanel BottomPanel = new VillageInfrTaskBottomPanel();

		// Token: 0x0401A192 RID: 106898
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<VillageTaskItem, VillageInfrLimitTaskData> TaskScroll;
	}
}
