using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x02005243 RID: 21059
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballTaskData
	{
		// Token: 0x170065DC RID: 26076
		// (get) Token: 0x06034621 RID: 214561 RVA: 0x00EA88A2 File Offset: 0x00EA6AA2
		// (set) Token: 0x06034622 RID: 214562 RVA: 0x00EA88AA File Offset: 0x00EA6AAA
		[Nullable(2)]
		public ConditionTask Data { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170065DD RID: 26077
		// (get) Token: 0x06034623 RID: 214563 RVA: 0x00EA88B3 File Offset: 0x00EA6AB3
		// (set) Token: 0x06034624 RID: 214564 RVA: 0x00EA88BB File Offset: 0x00EA6ABB
		public EPinballTaskState Status { get; set; }

		// Token: 0x170065DE RID: 26078
		// (get) Token: 0x06034625 RID: 214565 RVA: 0x00EA88C4 File Offset: 0x00EA6AC4
		// (set) Token: 0x06034626 RID: 214566 RVA: 0x00EA88CC File Offset: 0x00EA6ACC
		public List<TItem> RewardList { get; set; } = new List<TItem>();

		// Token: 0x170065DF RID: 26079
		// (get) Token: 0x06034627 RID: 214567 RVA: 0x00EA88D5 File Offset: 0x00EA6AD5
		// (set) Token: 0x06034628 RID: 214568 RVA: 0x00EA88DD File Offset: 0x00EA6ADD
		public int Current { get; set; }

		// Token: 0x170065E0 RID: 26080
		// (get) Token: 0x06034629 RID: 214569 RVA: 0x00EA88E6 File Offset: 0x00EA6AE6
		// (set) Token: 0x0603462A RID: 214570 RVA: 0x00EA88EE File Offset: 0x00EA6AEE
		public int Target { get; set; } = 1;

		// Token: 0x170065E1 RID: 26081
		// (get) Token: 0x0603462B RID: 214571 RVA: 0x00EA88F7 File Offset: 0x00EA6AF7
		// (set) Token: 0x0603462C RID: 214572 RVA: 0x00EA88FF File Offset: 0x00EA6AFF
		public string QuestName { get; set; } = "";

		// Token: 0x170065E2 RID: 26082
		// (get) Token: 0x0603462D RID: 214573 RVA: 0x00EA8908 File Offset: 0x00EA6B08
		// (set) Token: 0x0603462E RID: 214574 RVA: 0x00EA8910 File Offset: 0x00EA6B10
		[Nullable(2)]
		public string QuestNameTextKey { [NullableContext(2)] get; [NullableContext(2)] set; } = "";

		// Token: 0x170065E3 RID: 26083
		// (get) Token: 0x0603462F RID: 214575 RVA: 0x00EA8919 File Offset: 0x00EA6B19
		// (set) Token: 0x06034630 RID: 214576 RVA: 0x00EA8921 File Offset: 0x00EA6B21
		public int DropId { get; set; }

		// Token: 0x170065E4 RID: 26084
		// (get) Token: 0x06034631 RID: 214577 RVA: 0x00EA892A File Offset: 0x00EA6B2A
		// (set) Token: 0x06034632 RID: 214578 RVA: 0x00EA8932 File Offset: 0x00EA6B32
		public EPinballTaskTab TaskTab { get; set; }

		// Token: 0x06034633 RID: 214579 RVA: 0x00EA893C File Offset: 0x00EA6B3C
		public PinballTaskData(ConditionTask taskData)
		{
			this.Data = taskData;
			this.Status = PinballTaskData.ConvertTaskState(taskData.Status);
			this.Current = taskData.Current;
			this.Target = taskData.Target;
			this.QuestName = "";
			this.QuestNameTextKey = "";
			this.RewardList = new List<TItem>();
		}

		// Token: 0x06034634 RID: 214580 RVA: 0x00EA89C8 File Offset: 0x00EA6BC8
		public void UpdateTaskData(ConditionTask taskData)
		{
			this.Data = taskData;
			this.Status = PinballTaskData.ConvertTaskState(taskData.Status);
			this.Current = taskData.Current;
			this.Target = taskData.Target;
		}

		// Token: 0x06034635 RID: 214581 RVA: 0x00EA89FC File Offset: 0x00EA6BFC
		public void SetRewardList(int dropId)
		{
			this.DropId = dropId;
			this.RewardList = new List<TItem>();
			if (dropId == 0)
			{
				return;
			}
			DropPackage? config = ConfigDropPackageById.GetConfig(dropId, true);
			if (config == null || config.Value.DropPreviewLength == 0)
			{
				return;
			}
			for (int i = 0; i < config.Value.DropPreviewLength; i++)
			{
				DicIntInt? dicIntInt = config.Value.DropPreview(i);
				if (dicIntInt != null)
				{
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					this.RewardList.Add(new TItem(new InventoryDefine.GetItemData(key, 0), value));
				}
			}
		}

		// Token: 0x06034636 RID: 214582 RVA: 0x00EA8AB4 File Offset: 0x00EA6CB4
		private static EPinballTaskState ConvertTaskState(ConditionTaskState state)
		{
			switch (state)
			{
			case ConditionTaskState.ConditionTaskRunning:
				return EPinballTaskState.UnLock;
			case ConditionTaskState.ConditionTaskFinish:
				return EPinballTaskState.Claimable;
			case ConditionTaskState.ConditionTaskTaken:
				return EPinballTaskState.Finished;
			default:
				return EPinballTaskState.UnLock;
			}
		}

		// Token: 0x170065E5 RID: 26085
		// (get) Token: 0x06034637 RID: 214583 RVA: 0x00EA8AD1 File Offset: 0x00EA6CD1
		public bool IsDoing
		{
			get
			{
				return this.Status == EPinballTaskState.UnLock;
			}
		}

		// Token: 0x170065E6 RID: 26086
		// (get) Token: 0x06034638 RID: 214584 RVA: 0x00EA8ADC File Offset: 0x00EA6CDC
		public bool IsUnclaimed
		{
			get
			{
				return this.Status == EPinballTaskState.Claimable;
			}
		}

		// Token: 0x170065E7 RID: 26087
		// (get) Token: 0x06034639 RID: 214585 RVA: 0x00EA8AE7 File Offset: 0x00EA6CE7
		public bool IsFinished
		{
			get
			{
				return this.Status == EPinballTaskState.Finished;
			}
		}
	}
}
