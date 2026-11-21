using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200426B RID: 17003
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardTaskData
	{
		// Token: 0x17005668 RID: 22120
		// (get) Token: 0x0602B06F RID: 176239 RVA: 0x00C19BC1 File Offset: 0x00C17DC1
		// (set) Token: 0x0602B070 RID: 176240 RVA: 0x00C19BC9 File Offset: 0x00C17DC9
		public bool IsOwn { get; private set; }

		// Token: 0x0602B071 RID: 176241 RVA: 0x00C19BD2 File Offset: 0x00C17DD2
		public PhantomArenaCardTaskData(bool isOwn)
		{
			this.IsOwn = isOwn;
		}

		// Token: 0x17005669 RID: 22121
		// (get) Token: 0x0602B072 RID: 176242 RVA: 0x00C19BEC File Offset: 0x00C17DEC
		public bool IsAllFinish
		{
			get
			{
				return this.IsAllFinishInternal;
			}
		}

		// Token: 0x1700566A RID: 22122
		// (get) Token: 0x0602B073 RID: 176243 RVA: 0x00C19BF4 File Offset: 0x00C17DF4
		public int AllTaskNum
		{
			get
			{
				return this.TaskInfoList.Count;
			}
		}

		// Token: 0x0602B074 RID: 176244 RVA: 0x00C19C04 File Offset: 0x00C17E04
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

		// Token: 0x0602B075 RID: 176245 RVA: 0x00C19CAC File Offset: 0x00C17EAC
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

		// Token: 0x04017456 RID: 95318
		private List<PhantomBattleFourTaskInfo> TaskInfoList = new List<PhantomBattleFourTaskInfo>();

		// Token: 0x04017457 RID: 95319
		private bool IsAllFinishInternal;

		// Token: 0x04017458 RID: 95320
		public int FinishTaskNum;

		// Token: 0x04017459 RID: 95321
		public bool IsExecuteFourCostLogic;

		// Token: 0x0401745A RID: 95322
		public int TaskCardConfigId;
	}
}
