using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002383 RID: 9091
[NullableContext(1)]
[Nullable(0)]
public class AnimalBornMontageInfo
{
	// Token: 0x06016705 RID: 91909 RVA: 0x0068FD6C File Offset: 0x0068DF6C
	public void Init(AnimalStandbyMontage config)
	{
		this.StartPath = (this.IsPathValid(config.MontageStart) ? config.MontageStart : "");
		this.LoopPath = (this.IsPathValid(config.MontageLoop) ? config.MontageLoop : "");
		this.EndPath = (this.IsPathValid(config.MontageEnd) ? config.MontageEnd : "");
		if (this.IsPathValid(config.MontageBranch1))
		{
			this.BranchPathList.Add(config.MontageBranch1);
		}
		if (this.IsPathValid(config.MontageBranch2))
		{
			this.BranchPathList.Add(config.MontageBranch2);
		}
		if (this.IsPathValid(config.MontageBranch3))
		{
			this.BranchPathList.Add(config.MontageBranch3);
		}
		if (this.IsPathValid(config.MontageBranch4))
		{
			this.BranchPathList.Add(config.MontageBranch4);
		}
	}

	// Token: 0x06016706 RID: 91910 RVA: 0x0068FE66 File Offset: 0x0068E066
	[NullableContext(2)]
	protected bool IsPathValid(string path)
	{
		return path != null && path != "" && path != "None";
	}

	// Token: 0x06016707 RID: 91911 RVA: 0x0068FE85 File Offset: 0x0068E085
	public bool IsAssetReady()
	{
		return this.StartReady && this.LoopReady && this.BranchReady && this.EndReady;
	}

	// Token: 0x06016708 RID: 91912 RVA: 0x0068FEA8 File Offset: 0x0068E0A8
	public bool IsConfigValid()
	{
		bool flag = this.StartPath != "" && this.StartPath != "None";
		bool flag2 = this.LoopPath != "" && this.LoopPath != "None";
		return flag || flag2;
	}

	// Token: 0x06016709 RID: 91913 RVA: 0x0068FF02 File Offset: 0x0068E102
	[NullableContext(2)]
	public UAnimMontage GetStartMontage()
	{
		UAnimMontage start = this.Start;
		if (start == null || !start.IsValid())
		{
			return this.Loop;
		}
		return this.Start;
	}

	// Token: 0x0400BE4C RID: 48716
	[Nullable(2)]
	public UAnimMontage Start;

	// Token: 0x0400BE4D RID: 48717
	[Nullable(2)]
	public UAnimMontage Loop;

	// Token: 0x0400BE4E RID: 48718
	[Nullable(2)]
	public UAnimMontage Branch;

	// Token: 0x0400BE4F RID: 48719
	[Nullable(2)]
	public UAnimMontage End;

	// Token: 0x0400BE50 RID: 48720
	public List<UAnimMontage> BranchList = new List<UAnimMontage>();

	// Token: 0x0400BE51 RID: 48721
	public string StartPath = "";

	// Token: 0x0400BE52 RID: 48722
	public string LoopPath = "";

	// Token: 0x0400BE53 RID: 48723
	public string EndPath = "";

	// Token: 0x0400BE54 RID: 48724
	public string BranchPath = "";

	// Token: 0x0400BE55 RID: 48725
	public int BranchLoadedCount;

	// Token: 0x0400BE56 RID: 48726
	public List<string> BranchPathList = new List<string>();

	// Token: 0x0400BE57 RID: 48727
	public bool StartReady;

	// Token: 0x0400BE58 RID: 48728
	public bool LoopReady;

	// Token: 0x0400BE59 RID: 48729
	public bool BranchReady;

	// Token: 0x0400BE5A RID: 48730
	public bool EndReady;
}
