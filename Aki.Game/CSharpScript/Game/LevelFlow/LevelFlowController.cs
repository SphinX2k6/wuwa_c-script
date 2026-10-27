using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x02006F66 RID: 28518
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class LevelFlowController : ControllerBase
	{
		// Token: 0x060455FD RID: 284157 RVA: 0x0112CA09 File Offset: 0x0112AC09
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnTimeDilationChange));
			return true;
		}

		// Token: 0x060455FE RID: 284158 RVA: 0x0112CA25 File Offset: 0x0112AC25
		public void InitTaskTreeInfo(long treeIncId, int nodeId)
		{
			LevelFlowModel.Instance.InitTaskTreeInfo(treeIncId, nodeId);
		}

		// Token: 0x060455FF RID: 284159 RVA: 0x0112CA33 File Offset: 0x0112AC33
		public void StartLevelFlow(int index = 0)
		{
			LevelFlowModel.Instance.InitTiTanLevelFlowInfo();
			LevelFlowModel.Instance.StartLevelFlow(index);
		}

		// Token: 0x06045600 RID: 284160 RVA: 0x0112CA4A File Offset: 0x0112AC4A
		public void ResetLevelFlow(bool isEnd = false)
		{
			LevelFlowModel.Instance.ResetLevelFlow(isEnd);
		}

		// Token: 0x06045601 RID: 284161 RVA: 0x0112CA57 File Offset: 0x0112AC57
		protected override void OnTick(float delta)
		{
			LevelFlowModel.Instance.OnTick(delta);
			LevelFlowResourceManager.OnTick(delta);
		}

		// Token: 0x06045602 RID: 284162 RVA: 0x0112CA6A File Offset: 0x0112AC6A
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTimeDilationChange));
			return true;
		}

		// Token: 0x06045603 RID: 284163 RVA: 0x0112CA86 File Offset: 0x0112AC86
		private void OnTimeDilationChange()
		{
			LevelFlowResourceManager.OnTimeDilationChange();
		}

		// Token: 0x06045604 RID: 284164 RVA: 0x0112CA90 File Offset: 0x0112AC90
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(atomicProcessTeleportResponse.ErrorId, 27447, null, true, true);
					callback(false);
					return;
				}
				callback(true);
			}, 0);
		}

		// Token: 0x06045605 RID: 284165 RVA: 0x0112CB18 File Offset: 0x0112AD18
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(atomicProcessAddBuffResponse.ErrorId, 19678, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06045606 RID: 284166 RVA: 0x0112CC00 File Offset: 0x0112AE00
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(atomicProcessRemoveBuffResponse.ErrorId, 23095, null, true, true);
				}
			}, 0);
		}

		// Token: 0x17009B62 RID: 39778
		// (get) Token: 0x06045607 RID: 284167 RVA: 0x0112CCE6 File Offset: 0x0112AEE6
		public static LevelFlowController Instance
		{
			get
			{
				return LevelFlowController._Instance;
			}
		}

		// Token: 0x06045608 RID: 284168 RVA: 0x0112CCED File Offset: 0x0112AEED
		public static LevelFlowController GetOrCreateInstance()
		{
			if (LevelFlowController._Instance == null)
			{
				LevelFlowController.CreateInstance();
			}
			return LevelFlowController._Instance;
		}

		// Token: 0x06045609 RID: 284169 RVA: 0x0112CD01 File Offset: 0x0112AF01
		public static bool CreateInstance()
		{
			if (LevelFlowController._Instance != null)
			{
				return true;
			}
			LevelFlowController._Instance = new LevelFlowController();
			return true;
		}

		// Token: 0x0604560A RID: 284170 RVA: 0x0112CD17 File Offset: 0x0112AF17
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604560B RID: 284171 RVA: 0x0112CD19 File Offset: 0x0112AF19
		public static void ResetStaticDefaultValue()
		{
			LevelFlowController._Instance = null;
		}

		// Token: 0x0604560C RID: 284172 RVA: 0x0112CD21 File Offset: 0x0112AF21
		static LevelFlowController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowController.CreateStaticDefaultValue), new Action(LevelFlowController.ResetStaticDefaultValue));
		}

		// Token: 0x0402431A RID: 148250
		[Nullable(2)]
		private static LevelFlowController _Instance;
	}
}
