using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x020060E7 RID: 24807
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class LevelFlowController : ControllerBase
	{
		// Token: 0x0603B7AB RID: 243627 RVA: 0x010D680D File Offset: 0x010D4A0D
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnTimeDilationChange));
			return true;
		}

		// Token: 0x0603B7AC RID: 243628 RVA: 0x010D6829 File Offset: 0x010D4A29
		public void InitTaskTreeInfo(long treeIncId, int nodeId)
		{
			LevelFlowModel.Instance.InitTaskTreeInfo(treeIncId, nodeId);
		}

		// Token: 0x0603B7AD RID: 243629 RVA: 0x010D6837 File Offset: 0x010D4A37
		public void StartLevelFlow(int index = 0)
		{
			LevelFlowModel.Instance.InitTiTanLevelFlowInfo();
			LevelFlowModel.Instance.StartLevelFlow(index);
		}

		// Token: 0x0603B7AE RID: 243630 RVA: 0x010D684E File Offset: 0x010D4A4E
		public void ResetLevelFlow(bool isEnd = false)
		{
			LevelFlowModel.Instance.ResetLevelFlow(isEnd);
		}

		// Token: 0x0603B7AF RID: 243631 RVA: 0x010D685B File Offset: 0x010D4A5B
		protected override void OnTick(float delta)
		{
			LevelFlowModel.Instance.OnTick(delta);
			LevelFlowResourceManager.OnTick(delta);
		}

		// Token: 0x0603B7B0 RID: 243632 RVA: 0x010D686E File Offset: 0x010D4A6E
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTimeDilationChange));
			return true;
		}

		// Token: 0x0603B7B1 RID: 243633 RVA: 0x010D688A File Offset: 0x010D4A8A
		private void OnTimeDilationChange()
		{
			LevelFlowResourceManager.OnTimeDilationChange();
		}

		// Token: 0x0603B7B2 RID: 243634 RVA: 0x010D6894 File Offset: 0x010D4A94
		public void LevelFlowTeleportRequest(int targetEntityId, Action<bool> callback)
		{
			AtomicProcessTeleportRequest atomicProcessTeleportRequest = AtomicProcessTeleportRequest.Create();
			atomicProcessTeleportRequest.TreeOwnerId = PlayerInfoModel.Instance.GetId().Value;
			atomicProcessTeleportRequest.TreeIncId = MathUtils.Instance.BigIntToLong(LevelFlowModel.Instance.TreeIncId);
			atomicProcessTeleportRequest.NodeId = LevelFlowModel.Instance.TreeNodeId;
			atomicProcessTeleportRequest.SplineEntityId = targetEntityId;
			Net.Instance.Call(ERequestMessageId.AtomicProcessTeleportRequest, atomicProcessTeleportRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				AtomicProcessTeleportResponse atomicProcessTeleportResponse = (AtomicProcessTeleportResponse)msg;
				if (atomicProcessTeleportResponse == null)
				{
					callback(false);
					return;
				}
				if (atomicProcessTeleportResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(atomicProcessTeleportResponse.ErrorId, 27008, null, true, true);
					callback(false);
					return;
				}
				callback(true);
			}, 0);
		}

		// Token: 0x0603B7B3 RID: 243635 RVA: 0x010D691C File Offset: 0x010D4B1C
		public void LevelFlowAddBuffRequest(List<long> buffIdList)
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				return;
			}
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(LevelFlowModel.Instance.TreeIncId), false);
			if (behaviorTree == null)
			{
				return;
			}
			Blackboard blackBoard = behaviorTree.GetBlackBoard();
			if (blackBoard == null)
			{
				return;
			}
			if (blackBoard.ContainTag(EBehaviorTreeTag.RollbackWaiting) || blackBoard.ContainTag(EBehaviorTreeTag.Suspending) || blackBoard.ContainTag(EBehaviorTreeTag.SuspendingCanShow))
			{
				return;
			}
			AtomicProcessAddBuffRequest atomicProcessAddBuffRequest = AtomicProcessAddBuffRequest.Create();
			atomicProcessAddBuffRequest.TreeOwnerId = PlayerInfoModel.Instance.GetId().Value;
			atomicProcessAddBuffRequest.TreeIncId = MathUtils.Instance.BigIntToLong(LevelFlowModel.Instance.TreeIncId);
			atomicProcessAddBuffRequest.NodeId = LevelFlowModel.Instance.TreeNodeId;
			atomicProcessAddBuffRequest.BuffIds.AddRange(buffIdList);
			Net.Instance.Call(ERequestMessageId.AtomicProcessAddBuffRequest, atomicProcessAddBuffRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				AtomicProcessAddBuffResponse atomicProcessAddBuffResponse = (AtomicProcessAddBuffResponse)msg;
				if (atomicProcessAddBuffResponse == null)
				{
					return;
				}
				if (atomicProcessAddBuffResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(atomicProcessAddBuffResponse.ErrorId, 15504, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0603B7B4 RID: 243636 RVA: 0x010D6A04 File Offset: 0x010D4C04
		public void LevelFlowRemoveBuffRequest(List<long> buffIdList)
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				return;
			}
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(LevelFlowModel.Instance.TreeIncId), false);
			if (behaviorTree == null)
			{
				return;
			}
			Blackboard blackBoard = behaviorTree.GetBlackBoard();
			if (blackBoard == null)
			{
				return;
			}
			if (blackBoard.ContainTag(EBehaviorTreeTag.RollbackWaiting) || blackBoard.ContainTag(EBehaviorTreeTag.Suspending) || blackBoard.ContainTag(EBehaviorTreeTag.SuspendingCanShow))
			{
				return;
			}
			AtomicProcessRemoveBuffRequest atomicProcessRemoveBuffRequest = AtomicProcessRemoveBuffRequest.Create();
			atomicProcessRemoveBuffRequest.TreeOwnerId = PlayerInfoModel.Instance.GetId().Value;
			atomicProcessRemoveBuffRequest.TreeIncId = MathUtils.Instance.BigIntToLong(LevelFlowModel.Instance.TreeIncId);
			atomicProcessRemoveBuffRequest.NodeId = LevelFlowModel.Instance.TreeNodeId;
			atomicProcessRemoveBuffRequest.BuffIds.AddRange(buffIdList);
			Net.Instance.Call(ERequestMessageId.AtomicProcessRemoveBuffRequest, atomicProcessRemoveBuffRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				AtomicProcessRemoveBuffResponse atomicProcessRemoveBuffResponse = (AtomicProcessRemoveBuffResponse)msg;
				if (atomicProcessRemoveBuffResponse == null)
				{
					return;
				}
				if (atomicProcessRemoveBuffResponse.ErrorId != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(atomicProcessRemoveBuffResponse.ErrorId, 24883, null, true, true);
				}
			}, 0);
		}

		// Token: 0x170070A1 RID: 28833
		// (get) Token: 0x0603B7B5 RID: 243637 RVA: 0x010D6AEA File Offset: 0x010D4CEA
		public static LevelFlowController Instance
		{
			get
			{
				return LevelFlowController._Instance;
			}
		}

		// Token: 0x0603B7B6 RID: 243638 RVA: 0x010D6AF1 File Offset: 0x010D4CF1
		public static LevelFlowController GetOrCreateInstance()
		{
			if (LevelFlowController._Instance == null)
			{
				LevelFlowController.CreateInstance();
			}
			return LevelFlowController._Instance;
		}

		// Token: 0x0603B7B7 RID: 243639 RVA: 0x010D6B05 File Offset: 0x010D4D05
		public static bool CreateInstance()
		{
			if (LevelFlowController._Instance != null)
			{
				return true;
			}
			LevelFlowController._Instance = new LevelFlowController();
			return true;
		}

		// Token: 0x0603B7B8 RID: 243640 RVA: 0x010D6B1B File Offset: 0x010D4D1B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B7B9 RID: 243641 RVA: 0x010D6B1D File Offset: 0x010D4D1D
		public static void ResetStaticDefaultValue()
		{
			LevelFlowController._Instance = null;
		}

		// Token: 0x0603B7BA RID: 243642 RVA: 0x010D6B25 File Offset: 0x010D4D25
		static LevelFlowController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowController.CreateStaticDefaultValue), new Action(LevelFlowController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F5CF RID: 128463
		[Nullable(2)]
		private static LevelFlowController _Instance;
	}
}
