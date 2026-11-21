using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058EA RID: 22762
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolFreeActionTask : SolarSchoolTaskBase
	{
		// Token: 0x17006BAD RID: 27565
		// (get) Token: 0x060381D4 RID: 229844 RVA: 0x00FAECFD File Offset: 0x00FACEFD
		// (set) Token: 0x060381D5 RID: 229845 RVA: 0x00FAED05 File Offset: 0x00FACF05
		public bool StartAtHome { get; set; }

		// Token: 0x17006BAE RID: 27566
		// (get) Token: 0x060381D6 RID: 229846 RVA: 0x00FAED0E File Offset: 0x00FACF0E
		// (set) Token: 0x060381D7 RID: 229847 RVA: 0x00FAED16 File Offset: 0x00FACF16
		public bool IsFatigueBlocked { get; set; }

		// Token: 0x17006BAF RID: 27567
		// (get) Token: 0x060381D8 RID: 229848 RVA: 0x00FAED1F File Offset: 0x00FACF1F
		public bool IsActionPointConsumed
		{
			get
			{
				return this.ActionPointConsumed;
			}
		}

		// Token: 0x17006BB0 RID: 27568
		// (get) Token: 0x060381D9 RID: 229849 RVA: 0x00FAED27 File Offset: 0x00FACF27
		public bool CanChoose
		{
			get
			{
				return this.FixedFinished && !this.ActionPointConsumed;
			}
		}

		// Token: 0x060381DA RID: 229850 RVA: 0x00FAED3C File Offset: 0x00FACF3C
		public SolarSchoolFreeActionTask([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<SolarSchoolActionBase> fixedActions = null)
		{
			if (fixedActions != null)
			{
				this.FixedActions.AddRange(fixedActions);
			}
		}

		// Token: 0x060381DB RID: 229851 RVA: 0x00FAED60 File Offset: 0x00FACF60
		protected override void OnExecute()
		{
			this.FixedFinished = false;
			this.ExitOpened = false;
			this.ActionPointConsumed = false;
			this.PendingEnterLocationId = 0;
			this.PendingOpenLocationId = 0;
			foreach (SolarSchoolActionBase action in this.FixedActions)
			{
				base.PushAction(action);
			}
			this.FixedActions.Clear();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 自由行动点进入";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("slot", base.SlotTag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060381DC RID: 229852 RVA: 0x00FAEE18 File Offset: 0x00FAD018
		protected override void OnTick(float deltaTime)
		{
			if (base.HandlerHasWork)
			{
				return;
			}
			if (this.PendingEnterLocationId != 0)
			{
				int pendingEnterLocationId = this.PendingEnterLocationId;
				this.PendingEnterLocationId = 0;
				SolarSchoolGamePlayModel.Instance.MapData.SetCurrentLocation(pendingEnterLocationId);
				this.OpenMapWaitPlayer();
				return;
			}
			if (this.PendingOpenLocationId != 0)
			{
				int pendingOpenLocationId = this.PendingOpenLocationId;
				this.PendingOpenLocationId = 0;
				this.ExitOpened = true;
				SolarSchoolGamePlayModel.Instance.OpenLocationViewAsync(pendingOpenLocationId).Forget();
				return;
			}
			if (!this.FixedFinished)
			{
				this.FixedFinished = true;
				this.OpenFirstExit();
				return;
			}
			if (this.ActionPointConsumed)
			{
				base.Complete(null);
				return;
			}
			if (!this.ExitOpened)
			{
				this.OpenMapWaitPlayer();
			}
		}

		// Token: 0x060381DD RID: 229853 RVA: 0x00FAEEC0 File Offset: 0x00FAD0C0
		private unsafe void OpenFirstExit()
		{
			if (this.IsFatigueBlocked)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Tired_4", Array.Empty<object>());
			}
			if (!this.StartAtHome)
			{
				this.OpenMapWaitPlayer();
				return;
			}
			this.StartAtHome = false;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolLocation? activityHomeLocation = SolarSchoolConfig.Instance.GetActivityHomeLocation(instance.ActivityId);
			if (activityHomeLocation == null)
			{
				this.OpenMapWaitPlayer();
				return;
			}
			this.ExitOpened = true;
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 自由行动点：白天格空，出口开在家";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("slot", base.SlotTag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("locationId", activityHomeLocation.Value.Id);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			instance.OpenLocationViewAsync(activityHomeLocation.Value.Id).Forget();
		}

		// Token: 0x060381DE RID: 229854 RVA: 0x00FAEFBC File Offset: 0x00FAD1BC
		private void OpenMapWaitPlayer()
		{
			this.ExitOpened = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 自由行动点：打开地图";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("slot", base.SlotTag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			SolarSchoolGamePlayModel.Instance.OpenMapView(null);
		}

		// Token: 0x060381DF RID: 229855 RVA: 0x00FAF010 File Offset: 0x00FAD210
		public unsafe void OnClickMapLocation(int locationId)
		{
			if (!this.CanPlayerChoose())
			{
				return;
			}
			int num;
			SolarSchoolActionBase solarSchoolActionBase;
			if (SolarSchoolQuestCenter.Instance.TryTakePendingNode(ESolarSchoolTriggerTiming.AtLocationAffinity, locationId, out num, out solarSchoolActionBase) && solarSchoolActionBase != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 进入地点触发事件剧情，播完回地图";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nodeId", num);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.PendingEnterLocationId = locationId;
				this.ExitOpened = false;
				base.PushAction(solarSchoolActionBase);
				return;
			}
			SolarSchoolActionBase solarSchoolActionBase2;
			if (SolarSchoolQuestCenter.Instance.TryTakePendingNode(ESolarSchoolTriggerTiming.AtLocationFirst, locationId, out num, out solarSchoolActionBase2) && solarSchoolActionBase2 != null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 首次进入地点剧情，播完进地点";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("nodeId", num);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				this.PendingOpenLocationId = locationId;
				this.ExitOpened = false;
				base.PushAction(solarSchoolActionBase2);
				return;
			}
			SolarSchoolGamePlayModel.Instance.OpenLocationViewAsync(locationId).Forget();
		}

		// Token: 0x060381E0 RID: 229856 RVA: 0x00FAF14C File Offset: 0x00FAD34C
		public void OnPlayerChooseOption(int locationId, int optionId)
		{
			if (!this.CanPlayerChoose())
			{
				return;
			}
			SolarSchoolActionBase solarSchoolActionBase;
			if (!SolarSchoolGamePlayModel.Instance.TryGetOptionAction(locationId, optionId, out solarSchoolActionBase) || solarSchoolActionBase == null)
			{
				return;
			}
			this.RunAction(solarSchoolActionBase);
		}

		// Token: 0x060381E1 RID: 229857 RVA: 0x00FAF180 File Offset: 0x00FAD380
		public void OnPlayerChooseRoleOption(int roleId, int optionId)
		{
			if (!this.CanPlayerChoose())
			{
				return;
			}
			SolarSchoolActionBase solarSchoolActionBase;
			if (!SolarSchoolGamePlayModel.Instance.TryGetRoleOptionAction(roleId, optionId, out solarSchoolActionBase) || solarSchoolActionBase == null)
			{
				return;
			}
			this.RunAction(solarSchoolActionBase);
		}

		// Token: 0x060381E2 RID: 229858 RVA: 0x00FAF1B4 File Offset: 0x00FAD3B4
		public void OnPlayerChooseBehavior(int behaviorId)
		{
			if (!this.CanPlayerChoose())
			{
				return;
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			List<SolarSchoolActionBase> list = instance.CreateBehaviorActionSequence(behaviorId);
			if (list.Count == 0)
			{
				return;
			}
			instance.MarkCurrentLocationPresentFinished();
			this.RunActions(list);
		}

		// Token: 0x060381E3 RID: 229859 RVA: 0x00FAF1F0 File Offset: 0x00FAD3F0
		public unsafe void OnClickGoOut()
		{
			if (!this.CanPlayerChoose())
			{
				return;
			}
			int num = this.IsFatigueBlocked ? 0 : SolarSchoolGamePlayModel.Instance.GetBehaviorIdBySlot(base.SlotTag);
			if (num != 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 自由行动点：检出本格补排的行为，直接执行";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("slot", base.SlotTag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("behaviorId", num);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.RunActions(SolarSchoolGamePlayModel.Instance.CreateBehaviorActionSequence(num));
				return;
			}
			this.OpenMapWaitPlayer();
		}

		// Token: 0x060381E4 RID: 229860 RVA: 0x00FAF2A4 File Offset: 0x00FAD4A4
		private bool CanPlayerChoose()
		{
			if (base.HandlerHasWork)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前有 action 执行中，忽略本次自由选择";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("slot", base.SlotTag);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (!this.FixedFinished)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 固定剧情未播完，暂不能交互", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (this.ActionPointConsumed)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 行动点已耗尽，不能再自由选择", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x060381E5 RID: 229861 RVA: 0x00FAF342 File Offset: 0x00FAD542
		private void RunAction(SolarSchoolActionBase action)
		{
			if (action.ConsumesActionPoint)
			{
				this.ActionPointConsumed = true;
			}
			base.PushAction(action);
		}

		// Token: 0x060381E6 RID: 229862 RVA: 0x00FAF35C File Offset: 0x00FAD55C
		private void RunActions(IReadOnlyList<SolarSchoolActionBase> actions)
		{
			foreach (SolarSchoolActionBase action in actions)
			{
				this.RunAction(action);
			}
		}

		// Token: 0x060381E7 RID: 229863 RVA: 0x00FAF3A4 File Offset: 0x00FAD5A4
		protected override void OnComplete()
		{
		}

		// Token: 0x060381E8 RID: 229864 RVA: 0x00FAF3A6 File Offset: 0x00FAD5A6
		public override bool TryPushAction(SolarSchoolActionBase action)
		{
			if (!base.IsExecuting || action == null)
			{
				return false;
			}
			this.RunAction(action);
			return true;
		}

		// Token: 0x0401D8EB RID: 121067
		private readonly List<SolarSchoolActionBase> FixedActions = new List<SolarSchoolActionBase>();

		// Token: 0x0401D8EC RID: 121068
		private bool FixedFinished;

		// Token: 0x0401D8ED RID: 121069
		private bool ExitOpened;

		// Token: 0x0401D8EE RID: 121070
		private bool ActionPointConsumed;

		// Token: 0x0401D8EF RID: 121071
		private int PendingEnterLocationId;

		// Token: 0x0401D8F0 RID: 121072
		private int PendingOpenLocationId;
	}
}
