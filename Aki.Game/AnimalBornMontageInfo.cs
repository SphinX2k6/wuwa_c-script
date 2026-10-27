using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002E27 RID: 11815
[NullableContext(1)]
[Nullable(0)]
public class AnimalBornMontageInfo
{
	// Token: 0x06018E38 RID: 101944 RVA: 0x00669E7C File Offset: 0x0066807C
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

	// Token: 0x06018E39 RID: 101945 RVA: 0x00669F76 File Offset: 0x00668176
	[NullableContext(2)]
	protected bool IsPathValid(string path)
	{
		return path != null && path != "" && path != "None";
	}

	// Token: 0x06018E3A RID: 101946 RVA: 0x00669F95 File Offset: 0x00668195
	public bool IsAssetReady()
	{
		return this.StartReady && this.LoopReady && this.BranchReady && this.EndReady;
	}

	// Token: 0x06018E3B RID: 101947 RVA: 0x00669FB8 File Offset: 0x006681B8
	public bool IsConfigValid()
	{
		bool flag = this.StartPath != "" && this.StartPath != "None";
		bool flag2 = this.LoopPath != "" && this.LoopPath != "None";
		return flag || flag2;
	}

	// Token: 0x06018E3C RID: 101948 RVA: 0x0066A012 File Offset: 0x00668212
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

	// Token: 0x0400BABE RID: 47806
	[Nullable(2)]
	public UAnimMontage Start;

	// Token: 0x0400BABF RID: 47807
	[Nullable(2)]
	public UAnimMontage Loop;

	// Token: 0x0400BAC0 RID: 47808
	[Nullable(2)]
	public UAnimMontage Branch;

	// Token: 0x0400BAC1 RID: 47809
	[Nullable(2)]
	public UAnimMontage End;

	// Token: 0x0400BAC2 RID: 47810
	public List<UAnimMontage> BranchList = new List<UAnimMontage>();

	// Token: 0x0400BAC3 RID: 47811
	public string StartPath = "";

	// Token: 0x0400BAC4 RID: 47812
	public string LoopPath = "";

	// Token: 0x0400BAC5 RID: 47813
	public string EndPath = "";

	// Token: 0x0400BAC6 RID: 47814
	public string BranchPath = "";

	// Token: 0x0400BAC7 RID: 47815
	public int BranchLoadedCount;

	// Token: 0x0400BAC8 RID: 47816
	public List<string> BranchPathList = new List<string>();

	// Token: 0x0400BAC9 RID: 47817
	public bool StartReady;

	// Token: 0x0400BACA RID: 47818
	public bool LoopReady;

	// Token: 0x0400BACB RID: 47819
	public bool BranchReady;

	// Token: 0x0400BACC RID: 47820
	public bool EndReady;
}
