using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x02001B04 RID: 6916
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTaskData
{
	// Token: 0x0600CD5A RID: 52570 RVA: 0x002ECF3A File Offset: 0x002EB13A
	public FloroRanchTaskData(FloroRanchTask config)
	{
		this.Config = config;
		this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.DropId);
	}

	// Token: 0x0600CD5B RID: 52571 RVA: 0x002ECF79 File Offset: 0x002EB179
	public void UpdateUnLockState(bool isUnLock)
	{
		this.IsUnLockInternal = isUnLock;
	}

	// Token: 0x1700111A RID: 4378
	// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x002ECF82 File Offset: 0x002EB182
	public bool IsUnLock
	{
		get
		{
			return this.IsUnLockInternal;
		}
	}

	// Token: 0x1700111B RID: 4379
	// (get) Token: 0x0600CD5D RID: 52573 RVA: 0x002ECF8C File Offset: 0x002EB18C
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x1700111C RID: 4380
	// (get) Token: 0x0600CD5E RID: 52574 RVA: 0x002ECFA8 File Offset: 0x002EB1A8
	public bool IsLimitTime
	{
		get
		{
			return this.Config.LimitTime;
		}
	}

	// Token: 0x1700111D RID: 4381
	// (get) Token: 0x0600CD5F RID: 52575 RVA: 0x002ECFC4 File Offset: 0x002EB1C4
	public EFloroRanchTaskTabType TabType
	{
		get
		{
			return (EFloroRanchTaskTabType)this.Config.PageType;
		}
	}

	// Token: 0x1700111E RID: 4382
	// (get) Token: 0x0600CD60 RID: 52576 RVA: 0x002ECFE0 File Offset: 0x002EB1E0
	public string TaskName
	{
		get
		{
			return this.Config.RewardName;
		}
	}

	// Token: 0x1700111F RID: 4383
	// (get) Token: 0x0600CD61 RID: 52577 RVA: 0x002ECFFC File Offset: 0x002EB1FC
	public int JumpId
	{
		get
		{
			return this.Config.JumpId;
		}
	}

	// Token: 0x04005E2E RID: 24110
	private readonly FloroRanchTask Config;

	// Token: 0x04005E2F RID: 24111
	public EActivityTaskState Status = EActivityTaskState.Active;

	// Token: 0x04005E30 RID: 24112
	private bool IsUnLockInternal = true;

	// Token: 0x04005E31 RID: 24113
	public int Current;

	// Token: 0x04005E32 RID: 24114
	public int Target;

	// Token: 0x04005E33 RID: 24115
	public List<TItem> RewardList = new List<TItem>();

	// Token: 0x04005E34 RID: 24116
	[Nullable(2)]
	public FloroRanchTaskData.TReceive ReceiveDelegate;

	// Token: 0x02008055 RID: 32853
	// (Invoke) Token: 0x06049EFC RID: 302844
	[NullableContext(0)]
	public delegate void TReceive(int taskId);
}
