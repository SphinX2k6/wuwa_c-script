using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200488D RID: 18573
	[Controller(0)]
	public class VillageInfrController : ActivityControllerBase
	{
		// Token: 0x0603094F RID: 198991 RVA: 0x00B489C0 File Offset: 0x00B46BC0
		[NullableContext(1)]
		protected override void OnOpenView(ActivityBaseData data)
		{
			List<int> list = ((data != null) ? data.GetPreGuideQuestIds() : null) ?? new List<int>();
			if (list.Count <= 0)
			{
				this.OpenVillageInfrMainView(null).Forget<int?>();
				return;
			}
			int num = list[0];
			if (QuestNewModel.Instance.CheckQuestFinished(num))
			{
				this.OpenVillageInfrMainView(null).Forget<int?>();
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, num, null);
		}

		// Token: 0x06030950 RID: 198992 RVA: 0x00B48A31 File Offset: 0x00B46C31
		[NullableContext(1)]
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_VillageInfrActivityMain";
		}

		// Token: 0x06030951 RID: 198993 RVA: 0x00B48A38 File Offset: 0x00B46C38
		[NullableContext(1)]
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new VillageInfrActivityMainView();
		}

		// Token: 0x06030952 RID: 198994 RVA: 0x00B48A3F File Offset: 0x00B46C3F
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06030953 RID: 198995 RVA: 0x00B48A44 File Offset: 0x00B46C44
		[NullableContext(1)]
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			VillageInfrActivityData villageInfrActivityData = new VillageInfrActivityData();
			VillageInfrModel.Instance.SetActivityData(villageInfrActivityData);
			return villageInfrActivityData;
		}

		// Token: 0x06030954 RID: 198996 RVA: 0x00B48A64 File Offset: 0x00B46C64
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.InfrV2TaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskUpdate));
			Net.Instance.Register(ENotifyMessageId.InfrV2TreeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTreeUpdate));
			Net.Instance.Register(ENotifyMessageId.InfrV2FireUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnVillageUpdate));
			Net.Instance.Register(ENotifyMessageId.InfrV2TreeFinishCondUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFinishConditionUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.InfrV2InfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrV2InfoNotify));
		}

		// Token: 0x06030955 RID: 198997 RVA: 0x00B48B00 File Offset: 0x00B46D00
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2TaskDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2TreeUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2FireUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2TreeFinishCondUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2InfoNotify);
		}

		// Token: 0x06030956 RID: 198998 RVA: 0x00B48B5D File Offset: 0x00B46D5D
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<IProto_NormalItem, bool>(EEventName.OnAddCommonItem, new Action<IProto_NormalItem, bool>(this.OnAddCommonItem));
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06030957 RID: 198999 RVA: 0x00B48B97 File Offset: 0x00B46D97
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAddCommonItem, new Action<IProto_NormalItem, bool>(this.OnAddCommonItem));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06030958 RID: 199000 RVA: 0x00B48BD4 File Offset: 0x00B46DD4
		public UniTask<bool> RequestInfrV2Info()
		{
			VillageInfrController.<RequestInfrV2Info>d__9 <RequestInfrV2Info>d__;
			<RequestInfrV2Info>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2Info>d__.<>1__state = -1;
			<RequestInfrV2Info>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2Info>d__9>(ref <RequestInfrV2Info>d__);
			return <RequestInfrV2Info>d__.<>t__builder.Task;
		}

		// Token: 0x06030959 RID: 199001 RVA: 0x00B48C10 File Offset: 0x00B46E10
		public UniTask<bool> RequestInfrV2LevelUp()
		{
			VillageInfrController.<RequestInfrV2LevelUp>d__10 <RequestInfrV2LevelUp>d__;
			<RequestInfrV2LevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2LevelUp>d__.<>1__state = -1;
			<RequestInfrV2LevelUp>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2LevelUp>d__10>(ref <RequestInfrV2LevelUp>d__);
			return <RequestInfrV2LevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x0603095A RID: 199002 RVA: 0x00B48C4C File Offset: 0x00B46E4C
		public UniTask<bool> RequestInfrV2TreeBuild(int treeId)
		{
			VillageInfrController.<RequestInfrV2TreeBuild>d__11 <RequestInfrV2TreeBuild>d__;
			<RequestInfrV2TreeBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2TreeBuild>d__.treeId = treeId;
			<RequestInfrV2TreeBuild>d__.<>1__state = -1;
			<RequestInfrV2TreeBuild>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2TreeBuild>d__11>(ref <RequestInfrV2TreeBuild>d__);
			return <RequestInfrV2TreeBuild>d__.<>t__builder.Task;
		}

		// Token: 0x0603095B RID: 199003 RVA: 0x00B48C90 File Offset: 0x00B46E90
		public UniTask<bool> RequestInfrV2ManualSwitchTraceTree(int treeId)
		{
			VillageInfrController.<RequestInfrV2ManualSwitchTraceTree>d__12 <RequestInfrV2ManualSwitchTraceTree>d__;
			<RequestInfrV2ManualSwitchTraceTree>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2ManualSwitchTraceTree>d__.treeId = treeId;
			<RequestInfrV2ManualSwitchTraceTree>d__.<>1__state = -1;
			<RequestInfrV2ManualSwitchTraceTree>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2ManualSwitchTraceTree>d__12>(ref <RequestInfrV2ManualSwitchTraceTree>d__);
			return <RequestInfrV2ManualSwitchTraceTree>d__.<>t__builder.Task;
		}

		// Token: 0x0603095C RID: 199004 RVA: 0x00B48CD4 File Offset: 0x00B46ED4
		public UniTask<bool> RequestInfrV2ManualCancelTraceTree()
		{
			VillageInfrController.<RequestInfrV2ManualCancelTraceTree>d__13 <RequestInfrV2ManualCancelTraceTree>d__;
			<RequestInfrV2ManualCancelTraceTree>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2ManualCancelTraceTree>d__.<>1__state = -1;
			<RequestInfrV2ManualCancelTraceTree>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2ManualCancelTraceTree>d__13>(ref <RequestInfrV2ManualCancelTraceTree>d__);
			return <RequestInfrV2ManualCancelTraceTree>d__.<>t__builder.Task;
		}

		// Token: 0x0603095D RID: 199005 RVA: 0x00B48D10 File Offset: 0x00B46F10
		public UniTask<bool> RequestInfrV2ScoreReward()
		{
			VillageInfrController.<RequestInfrV2ScoreReward>d__14 <RequestInfrV2ScoreReward>d__;
			<RequestInfrV2ScoreReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2ScoreReward>d__.<>1__state = -1;
			<RequestInfrV2ScoreReward>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2ScoreReward>d__14>(ref <RequestInfrV2ScoreReward>d__);
			return <RequestInfrV2ScoreReward>d__.<>t__builder.Task;
		}

		// Token: 0x0603095E RID: 199006 RVA: 0x00B48D4C File Offset: 0x00B46F4C
		public UniTask<bool> RequestInfrV2TaskReward([Nullable(1)] List<int> taskIds)
		{
			VillageInfrController.<RequestInfrV2TaskReward>d__15 <RequestInfrV2TaskReward>d__;
			<RequestInfrV2TaskReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2TaskReward>d__.taskIds = taskIds;
			<RequestInfrV2TaskReward>d__.<>1__state = -1;
			<RequestInfrV2TaskReward>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2TaskReward>d__15>(ref <RequestInfrV2TaskReward>d__);
			return <RequestInfrV2TaskReward>d__.<>t__builder.Task;
		}

		// Token: 0x0603095F RID: 199007 RVA: 0x00B48D90 File Offset: 0x00B46F90
		[NullableContext(2)]
		private void OnInfrV2InfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2InfoNotify infrV2InfoNotify = (InfrV2InfoNotify)msg;
			VillageInfrModel.Instance.SetData(infrV2InfoNotify.InfrInfo);
		}

		// Token: 0x06030960 RID: 199008 RVA: 0x00B48DB4 File Offset: 0x00B46FB4
		[NullableContext(2)]
		private void OnTaskUpdate(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2TaskDataUpdateNotify infrV2TaskDataUpdateNotify = (InfrV2TaskDataUpdateNotify)msg;
			VillageInfrModel.Instance.UpdateActivityTask(infrV2TaskDataUpdateNotify.Task);
		}

		// Token: 0x06030961 RID: 199009 RVA: 0x00B48DD8 File Offset: 0x00B46FD8
		[NullableContext(2)]
		private void OnTreeUpdate(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2TreeUpdateNotify infrV2TreeUpdateNotify = (InfrV2TreeUpdateNotify)msg;
			VillageInfrModel.Instance.SetAllTreeData(infrV2TreeUpdateNotify.TreeInfo);
		}

		// Token: 0x06030962 RID: 199010 RVA: 0x00B48DFC File Offset: 0x00B46FFC
		[NullableContext(2)]
		private void OnVillageUpdate(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2FireUpdateNotify infrV2FireUpdateNotify = (InfrV2FireUpdateNotify)msg;
			VillageInfrModel.Instance.SetVillageData(infrV2FireUpdateNotify.FireInfo);
		}

		// Token: 0x06030963 RID: 199011 RVA: 0x00B48E20 File Offset: 0x00B47020
		[NullableContext(2)]
		private void OnFinishConditionUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2TreeFinishCondUpdateNotify infrV2TreeFinishCondUpdateNotify = (InfrV2TreeFinishCondUpdateNotify)msg;
			VillageInfrModel.Instance.SetAllTreeFinishConditionData(infrV2TreeFinishCondUpdateNotify.Cond);
		}

		// Token: 0x06030964 RID: 199012 RVA: 0x00B48E44 File Offset: 0x00B47044
		[NullableContext(1)]
		private void OnAddCommonItem(IProto_NormalItem normalItem, bool isShowNewTips)
		{
			if (VillageInfrModel.Instance.CanShowNewTip(normalItem.Id, normalItem.Count))
			{
				int value = VillageInfrConfig.Instance.GetTreeIdByItemId(normalItem.Id).Value;
				ItemModel.Instance.PushWaitVillageInfrTree(value);
			}
		}

		// Token: 0x06030965 RID: 199013 RVA: 0x00B48E90 File Offset: 0x00B47090
		[NullableContext(1)]
		private void OnCommonItemCountAnyChange(IProto_NormalItem normalItem, int count, int lastCount)
		{
			if (VillageInfrModel.Instance.CanShowNewTip(normalItem.Id, count - lastCount))
			{
				int value = VillageInfrConfig.Instance.GetTreeIdByItemId(normalItem.Id).Value;
				ItemModel.Instance.PushWaitVillageInfrTree(value);
			}
		}

		// Token: 0x06030966 RID: 199014 RVA: 0x00B48ED8 File Offset: 0x00B470D8
		public UniTask<int?> OpenVillageInfrMainView([Nullable(2)] IVillageInfrMainParam param = null)
		{
			VillageInfrController.<OpenVillageInfrMainView>d__23 <OpenVillageInfrMainView>d__;
			<OpenVillageInfrMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenVillageInfrMainView>d__.param = param;
			<OpenVillageInfrMainView>d__.<>1__state = -1;
			<OpenVillageInfrMainView>d__.<>t__builder.Start<VillageInfrController.<OpenVillageInfrMainView>d__23>(ref <OpenVillageInfrMainView>d__);
			return <OpenVillageInfrMainView>d__.<>t__builder.Task;
		}

		// Token: 0x06030967 RID: 199015 RVA: 0x00B48F1C File Offset: 0x00B4711C
		public UniTask<int?> OpenVillageInfrWorldBuildViewAsync(EVillageInfrSelectType selectType, int selectId, [Nullable(1)] string uiCameraName)
		{
			VillageInfrController.<OpenVillageInfrWorldBuildViewAsync>d__24 <OpenVillageInfrWorldBuildViewAsync>d__;
			<OpenVillageInfrWorldBuildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenVillageInfrWorldBuildViewAsync>d__.selectType = selectType;
			<OpenVillageInfrWorldBuildViewAsync>d__.selectId = selectId;
			<OpenVillageInfrWorldBuildViewAsync>d__.uiCameraName = uiCameraName;
			<OpenVillageInfrWorldBuildViewAsync>d__.<>1__state = -1;
			<OpenVillageInfrWorldBuildViewAsync>d__.<>t__builder.Start<VillageInfrController.<OpenVillageInfrWorldBuildViewAsync>d__24>(ref <OpenVillageInfrWorldBuildViewAsync>d__);
			return <OpenVillageInfrWorldBuildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700792F RID: 31023
		// (get) Token: 0x06030968 RID: 199016 RVA: 0x00B48F6F File Offset: 0x00B4716F
		[Nullable(1)]
		public static VillageInfrController Instance
		{
			[NullableContext(1)]
			get
			{
				return VillageInfrController._Instance;
			}
		}

		// Token: 0x06030969 RID: 199017 RVA: 0x00B48F76 File Offset: 0x00B47176
		[NullableContext(1)]
		public static VillageInfrController GetOrCreateInstance()
		{
			if (VillageInfrController._Instance == null)
			{
				VillageInfrController.CreateInstance();
			}
			return VillageInfrController._Instance;
		}

		// Token: 0x0603096A RID: 199018 RVA: 0x00B48F8A File Offset: 0x00B4718A
		public static bool CreateInstance()
		{
			if (VillageInfrController._Instance != null)
			{
				return true;
			}
			VillageInfrController._Instance = new VillageInfrController();
			return true;
		}

		// Token: 0x0603096B RID: 199019 RVA: 0x00B48FA0 File Offset: 0x00B471A0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603096C RID: 199020 RVA: 0x00B48FA2 File Offset: 0x00B471A2
		public static void ResetStaticDefaultValue()
		{
			VillageInfrController._Instance = null;
		}

		// Token: 0x0603096D RID: 199021 RVA: 0x00B48FAA File Offset: 0x00B471AA
		static VillageInfrController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VillageInfrController.CreateStaticDefaultValue), new Action(VillageInfrController.ResetStaticDefaultValue));
		}

		// Token: 0x0401A1B2 RID: 106930
		[Nullable(2)]
		private static VillageInfrController _Instance;
	}
}
