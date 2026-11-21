using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D9 RID: 22745
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolQuestNodeData
	{
		// Token: 0x06038074 RID: 229492 RVA: 0x00FA9C99 File Offset: 0x00FA7E99
		public SolarSchoolQuestNodeData(int nodeId, int questId)
		{
			this.NodeId = nodeId;
			this.QuestId = questId;
		}

		// Token: 0x17006B6F RID: 27503
		// (get) Token: 0x06038075 RID: 229493 RVA: 0x00FA9CAF File Offset: 0x00FA7EAF
		public int NodeId { get; }

		// Token: 0x17006B70 RID: 27504
		// (get) Token: 0x06038076 RID: 229494 RVA: 0x00FA9CB7 File Offset: 0x00FA7EB7
		public int QuestId { get; }

		// Token: 0x17006B71 RID: 27505
		// (get) Token: 0x06038077 RID: 229495 RVA: 0x00FA9CBF File Offset: 0x00FA7EBF
		// (set) Token: 0x06038078 RID: 229496 RVA: 0x00FA9CC7 File Offset: 0x00FA7EC7
		public bool Completed { get; private set; }

		// Token: 0x17006B72 RID: 27506
		// (get) Token: 0x06038079 RID: 229497 RVA: 0x00FA9CD0 File Offset: 0x00FA7ED0
		// (set) Token: 0x0603807A RID: 229498 RVA: 0x00FA9CD8 File Offset: 0x00FA7ED8
		public bool IsActionRunning { get; private set; }

		// Token: 0x17006B73 RID: 27507
		// (get) Token: 0x0603807B RID: 229499 RVA: 0x00FA9CE1 File Offset: 0x00FA7EE1
		public bool IsPending
		{
			get
			{
				return SolarSchoolGamePlayModel.Instance.QuestData.IsNodePending(this.NodeId);
			}
		}

		// Token: 0x17006B74 RID: 27508
		// (get) Token: 0x0603807C RID: 229500 RVA: 0x00FA9CF8 File Offset: 0x00FA7EF8
		public int PreNodeId
		{
			get
			{
				if (SolarSchoolConfig.Instance.GetQuestNode(this.NodeId) == null)
				{
					return 0;
				}
				SolarSchoolQuestNode? solarSchoolQuestNode;
				return solarSchoolQuestNode.GetValueOrDefault().PreNodeId;
			}
		}

		// Token: 0x17006B75 RID: 27509
		// (get) Token: 0x0603807D RID: 229501 RVA: 0x00FA9D30 File Offset: 0x00FA7F30
		public ESolarSchoolTriggerTiming TriggerTiming
		{
			get
			{
				if (SolarSchoolConfig.Instance.GetQuestNode(this.NodeId) == null)
				{
					return ESolarSchoolTriggerTiming.Immediate;
				}
				SolarSchoolQuestNode? solarSchoolQuestNode;
				return (ESolarSchoolTriggerTiming)solarSchoolQuestNode.GetValueOrDefault().TriggerTiming;
			}
		}

		// Token: 0x0603807E RID: 229502 RVA: 0x00FA9D68 File Offset: 0x00FA7F68
		public unsafe bool TryStartListening(Action onHit)
		{
			ActivityConditionBase activityConditionBase;
			if (ActivityConditionCenter.Instance.TryGetCondition(this.ConditionHandleId, out activityConditionBase) || this.Completed || this.IsPending)
			{
				return false;
			}
			SolarSchoolQuestNode? questNode = SolarSchoolConfig.Instance.GetQuestNode(this.NodeId);
			if (questNode == null)
			{
				return false;
			}
			int unlockConditionGroupId = questNode.Value.UnlockConditionGroupId;
			if (unlockConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(unlockConditionGroupId))
			{
				onHit();
				return false;
			}
			long num = ActivityConditionCenter.Instance.RegisterGroup(unlockConditionGroupId, delegate
			{
				this.OnConditionReached(onHit);
			});
			if (num == 0L)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] QuestNode 注册监听失败，请检查条件是否可监听及条件构建日志";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nodeId", this.NodeId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("questId", this.QuestId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("unlockConditionGroupId", unlockConditionGroupId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			this.ConditionHandleId = num;
			return true;
		}

		// Token: 0x0603807F RID: 229503 RVA: 0x00FA9EA8 File Offset: 0x00FA80A8
		private void OnConditionReached(Action onHit)
		{
			this.ConditionHandleId = 0L;
			onHit();
		}

		// Token: 0x06038080 RID: 229504 RVA: 0x00FA9EB8 File Offset: 0x00FA80B8
		public void StopListening()
		{
			if (this.ConditionHandleId == 0L)
			{
				return;
			}
			ActivityConditionCenter.Instance.Unregister(this.ConditionHandleId);
			this.ConditionHandleId = 0L;
		}

		// Token: 0x06038081 RID: 229505 RVA: 0x00FA9EDB File Offset: 0x00FA80DB
		public void MarkCompleted()
		{
			if (this.Completed)
			{
				return;
			}
			this.Completed = true;
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolQuestNodeStateChanged, this.NodeId);
		}

		// Token: 0x06038082 RID: 229506 RVA: 0x00FA9F03 File Offset: 0x00FA8103
		public void SetActionRunning(bool running)
		{
			this.IsActionRunning = running;
		}

		// Token: 0x06038083 RID: 229507 RVA: 0x00FA9F0C File Offset: 0x00FA810C
		public void ResetProgress()
		{
			this.StopListening();
			this.Completed = false;
			this.IsActionRunning = false;
		}

		// Token: 0x06038084 RID: 229508 RVA: 0x00FA9F22 File Offset: 0x00FA8122
		public void RestoreCompleted(bool completed)
		{
			this.Completed = completed;
		}

		// Token: 0x0401D89E RID: 120990
		private long ConditionHandleId;
	}
}
