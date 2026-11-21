using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x02000FC3 RID: 4035
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTaskData
{
	// Token: 0x0600A16B RID: 41323 RVA: 0x002F8026 File Offset: 0x002F6226
	public FloroRanchTaskData(FloroRanchTask config)
	{
		this.Config = config;
		this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.DropId);
	}

	// Token: 0x0600A16C RID: 41324 RVA: 0x002F8065 File Offset: 0x002F6265
	public void UpdateUnLockState(bool isUnLock)
	{
		this.IsUnLockInternal = isUnLock;
	}

	// Token: 0x1700113F RID: 4415
	// (get) Token: 0x0600A16D RID: 41325 RVA: 0x002F806E File Offset: 0x002F626E
	public bool IsUnLock
	{
		get
		{
			return this.IsUnLockInternal;
		}
	}

	// Token: 0x17001140 RID: 4416
	// (get) Token: 0x0600A16E RID: 41326 RVA: 0x002F8078 File Offset: 0x002F6278
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17001141 RID: 4417
	// (get) Token: 0x0600A16F RID: 41327 RVA: 0x002F8094 File Offset: 0x002F6294
	public bool IsLimitTime
	{
		get
		{
			return this.Config.LimitTime;
		}
	}

	// Token: 0x17001142 RID: 4418
	// (get) Token: 0x0600A170 RID: 41328 RVA: 0x002F80B0 File Offset: 0x002F62B0
	public EFloroRanchTaskTabType TabType
	{
		get
		{
			return (EFloroRanchTaskTabType)this.Config.PageType;
		}
	}

	// Token: 0x17001143 RID: 4419
	// (get) Token: 0x0600A171 RID: 41329 RVA: 0x002F80CC File Offset: 0x002F62CC
	public string TaskName
	{
		get
		{
			return this.Config.RewardName;
		}
	}

	// Token: 0x17001144 RID: 4420
	// (get) Token: 0x0600A172 RID: 41330 RVA: 0x002F80E8 File Offset: 0x002F62E8
	public int JumpId
	{
		get
		{
			return this.Config.JumpId;
		}
	}

	// Token: 0x04005EFD RID: 24317
	private readonly FloroRanchTask Config;

	// Token: 0x04005EFE RID: 24318
	public EActivityTaskState Status = EActivityTaskState.Active;

	// Token: 0x04005EFF RID: 24319
	private bool IsUnLockInternal = true;

	// Token: 0x04005F00 RID: 24320
	public int Current;

	// Token: 0x04005F01 RID: 24321
	public int Target;

	// Token: 0x04005F02 RID: 24322
	public List<TItem> RewardList = new List<TItem>();

	// Token: 0x04005F03 RID: 24323
	[Nullable(2)]
	public FloroRanchTaskData.TReceive ReceiveDelegate;

	// Token: 0x020071E3 RID: 29155
	// (Invoke) Token: 0x06040311 RID: 262929
	[NullableContext(0)]
	public delegate void TReceive(int taskId);
}
