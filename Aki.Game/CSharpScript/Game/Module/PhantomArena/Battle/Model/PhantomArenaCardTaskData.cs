using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200529B RID: 21147
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardTaskData
	{
		// Token: 0x170082A8 RID: 33448
		// (get) Token: 0x06036174 RID: 221556 RVA: 0x00CCC48D File Offset: 0x00CCA68D
		// (set) Token: 0x06036175 RID: 221557 RVA: 0x00CCC495 File Offset: 0x00CCA695
		public bool IsOwn { get; private set; }

		// Token: 0x06036176 RID: 221558 RVA: 0x00CCC49E File Offset: 0x00CCA69E
		public PhantomArenaCardTaskData(bool isOwn)
		{
			this.IsOwn = isOwn;
		}

		// Token: 0x170082A9 RID: 33449
		// (get) Token: 0x06036177 RID: 221559 RVA: 0x00CCC4B8 File Offset: 0x00CCA6B8
		public bool IsAllFinish
		{
			get
			{
				return this.IsAllFinishInternal;
			}
		}

		// Token: 0x170082AA RID: 33450
		// (get) Token: 0x06036178 RID: 221560 RVA: 0x00CCC4C0 File Offset: 0x00CCA6C0
		public int AllTaskNum
		{
			get
			{
				return this.TaskInfoList.Count;
			}
		}

		// Token: 0x06036179 RID: 221561 RVA: 0x00CCC4D0 File Offset: 0x00CCA6D0
		public void SetTaskData(PhantomBattleGamerFourCTaskInfo data)
		{
			this.TaskInfoList = new List<PhantomBattleFourTaskInfo>(data.PhantomBattleFourTaskInfos);
			this.IsAllFinishInternal = data.IsFinish;
			this.TaskCardConfigId = data.CardConfId;
			this.FinishTaskNum = 0;
			using (List<PhantomBattleFourTaskInfo>.Enumerator enumerator = this.TaskInfoList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsFinish)
					{
						this.FinishTaskNum++;
					}
				}
			}
			EventSystem.Instance.Emit<bool>(EEventName.NotifyCardTaskData, this.IsOwn);
		}

		// Token: 0x0603617A RID: 221562 RVA: 0x00CCC578 File Offset: 0x00CCA778
		public int GetConditionDescCurrentProgress(int conditionId)
		{
			int result = 0;
			foreach (PhantomBattleFourTaskInfo phantomBattleFourTaskInfo in this.TaskInfoList)
			{
				if (phantomBattleFourTaskInfo.ConditionId == conditionId)
				{
					result = phantomBattleFourTaskInfo.CurProgress;
				}
			}
			return result;
		}

		// Token: 0x0401CA21 RID: 117281
		private List<PhantomBattleFourTaskInfo> TaskInfoList = new List<PhantomBattleFourTaskInfo>();

		// Token: 0x0401CA22 RID: 117282
		private bool IsAllFinishInternal;

		// Token: 0x0401CA23 RID: 117283
		public int FinishTaskNum;

		// Token: 0x0401CA24 RID: 117284
		public bool IsExecuteFourCostLogic;

		// Token: 0x0401CA25 RID: 117285
		public int TaskCardConfigId;
	}
}
