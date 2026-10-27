using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x020062C5 RID: 25285
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballTaskData
	{
		// Token: 0x1700927A RID: 37498
		// (get) Token: 0x0603F960 RID: 260448 RVA: 0x00F61946 File Offset: 0x00F5FB46
		// (set) Token: 0x0603F961 RID: 260449 RVA: 0x00F6194E File Offset: 0x00F5FB4E
		[Nullable(2)]
		public ConditionTask Data { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700927B RID: 37499
		// (get) Token: 0x0603F962 RID: 260450 RVA: 0x00F61957 File Offset: 0x00F5FB57
		// (set) Token: 0x0603F963 RID: 260451 RVA: 0x00F6195F File Offset: 0x00F5FB5F
		public EPinballTaskState Status { get; set; }

		// Token: 0x1700927C RID: 37500
		// (get) Token: 0x0603F964 RID: 260452 RVA: 0x00F61968 File Offset: 0x00F5FB68
		// (set) Token: 0x0603F965 RID: 260453 RVA: 0x00F61970 File Offset: 0x00F5FB70
		public List<TItem> RewardList { get; set; } = new List<TItem>();

		// Token: 0x1700927D RID: 37501
		// (get) Token: 0x0603F966 RID: 260454 RVA: 0x00F61979 File Offset: 0x00F5FB79
		// (set) Token: 0x0603F967 RID: 260455 RVA: 0x00F61981 File Offset: 0x00F5FB81
		public int Current { get; set; }

		// Token: 0x1700927E RID: 37502
		// (get) Token: 0x0603F968 RID: 260456 RVA: 0x00F6198A File Offset: 0x00F5FB8A
		// (set) Token: 0x0603F969 RID: 260457 RVA: 0x00F61992 File Offset: 0x00F5FB92
		public int Target { get; set; } = 1;

		// Token: 0x1700927F RID: 37503
		// (get) Token: 0x0603F96A RID: 260458 RVA: 0x00F6199B File Offset: 0x00F5FB9B
		// (set) Token: 0x0603F96B RID: 260459 RVA: 0x00F619A3 File Offset: 0x00F5FBA3
		public string QuestName { get; set; } = "";

		// Token: 0x17009280 RID: 37504
		// (get) Token: 0x0603F96C RID: 260460 RVA: 0x00F619AC File Offset: 0x00F5FBAC
		// (set) Token: 0x0603F96D RID: 260461 RVA: 0x00F619B4 File Offset: 0x00F5FBB4
		[Nullable(2)]
		public string QuestNameTextKey { [NullableContext(2)] get; [NullableContext(2)] set; } = "";

		// Token: 0x17009281 RID: 37505
		// (get) Token: 0x0603F96E RID: 260462 RVA: 0x00F619BD File Offset: 0x00F5FBBD
		// (set) Token: 0x0603F96F RID: 260463 RVA: 0x00F619C5 File Offset: 0x00F5FBC5
		public int DropId { get; set; }

		// Token: 0x17009282 RID: 37506
		// (get) Token: 0x0603F970 RID: 260464 RVA: 0x00F619CE File Offset: 0x00F5FBCE
		// (set) Token: 0x0603F971 RID: 260465 RVA: 0x00F619D6 File Offset: 0x00F5FBD6
		public EPinballTaskTab TaskTab { get; set; }

		// Token: 0x0603F972 RID: 260466 RVA: 0x00F619E0 File Offset: 0x00F5FBE0
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

		// Token: 0x0603F973 RID: 260467 RVA: 0x00F61A6C File Offset: 0x00F5FC6C
		public void UpdateTaskData(ConditionTask taskData)
		{
			this.Data = taskData;
			this.Status = PinballTaskData.ConvertTaskState(taskData.Status);
			this.Current = taskData.Current;
			this.Target = taskData.Target;
		}

		// Token: 0x0603F974 RID: 260468 RVA: 0x00F61AA0 File Offset: 0x00F5FCA0
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

		// Token: 0x0603F975 RID: 260469 RVA: 0x00F61B58 File Offset: 0x00F5FD58
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

		// Token: 0x17009283 RID: 37507
		// (get) Token: 0x0603F976 RID: 260470 RVA: 0x00F61B75 File Offset: 0x00F5FD75
		public bool IsDoing
		{
			get
			{
				return this.Status == EPinballTaskState.UnLock;
			}
		}

		// Token: 0x17009284 RID: 37508
		// (get) Token: 0x0603F977 RID: 260471 RVA: 0x00F61B80 File Offset: 0x00F5FD80
		public bool IsUnclaimed
		{
			get
			{
				return this.Status == EPinballTaskState.Claimable;
			}
		}

		// Token: 0x17009285 RID: 37509
		// (get) Token: 0x0603F978 RID: 260472 RVA: 0x00F61B8B File Offset: 0x00F5FD8B
		public bool IsFinished
		{
			get
			{
				return this.Status == EPinballTaskState.Finished;
			}
		}
	}
}
