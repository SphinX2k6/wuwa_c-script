using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001332 RID: 4914
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMascotData
{
	// Token: 0x0600C186 RID: 49542 RVA: 0x0039476B File Offset: 0x0039296B
	public HonamiStoryMascotData(int configId)
	{
		this.IdInternal = configId;
	}

	// Token: 0x170012DA RID: 4826
	// (get) Token: 0x0600C187 RID: 49543 RVA: 0x0039477A File Offset: 0x0039297A
	public HonamiStoryMascot? Config
	{
		get
		{
			return HonamiStoryConfig.Instance.GetHonamiStoryMascotConfig(this.IdInternal);
		}
	}

	// Token: 0x0600C188 RID: 49544 RVA: 0x0039478C File Offset: 0x0039298C
	public void UpdateState(EHonamiStoryCollectState state)
	{
		this.StateInternal = state;
	}

	// Token: 0x170012DB RID: 4827
	// (get) Token: 0x0600C189 RID: 49545 RVA: 0x00394795 File Offset: 0x00392995
	public EHonamiStoryCollectState State
	{
		get
		{
			return this.StateInternal;
		}
	}

	// Token: 0x170012DC RID: 4828
	// (get) Token: 0x0600C18A RID: 49546 RVA: 0x0039479D File Offset: 0x0039299D
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x170012DD RID: 4829
	// (get) Token: 0x0600C18B RID: 49547 RVA: 0x003947A8 File Offset: 0x003929A8
	public string Name
	{
		get
		{
			return this.Config.Value.Name;
		}
	}

	// Token: 0x170012DE RID: 4830
	// (get) Token: 0x0600C18C RID: 49548 RVA: 0x003947CC File Offset: 0x003929CC
	public string FeatureDesc
	{
		get
		{
			return this.Config.Value.FeatureDesc;
		}
	}

	// Token: 0x170012DF RID: 4831
	// (get) Token: 0x0600C18D RID: 49549 RVA: 0x003947F0 File Offset: 0x003929F0
	public string ClueDesc
	{
		get
		{
			return this.Config.Value.ClueDesc;
		}
	}

	// Token: 0x170012E0 RID: 4832
	// (get) Token: 0x0600C18E RID: 49550 RVA: 0x00394814 File Offset: 0x00392A14
	public int DropId
	{
		get
		{
			return this.Config.Value.DropId;
		}
	}

	// Token: 0x170012E1 RID: 4833
	// (get) Token: 0x0600C18F RID: 49551 RVA: 0x00394838 File Offset: 0x00392A38
	public int AreaId
	{
		get
		{
			return this.Config.Value.AreaId;
		}
	}

	// Token: 0x04006F16 RID: 28438
	private readonly int IdInternal;

	// Token: 0x04006F17 RID: 28439
	private EHonamiStoryCollectState StateInternal;
}
