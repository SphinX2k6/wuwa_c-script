using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E70 RID: 7792
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMascotData
{
	// Token: 0x0600ED67 RID: 60775 RVA: 0x00388B5F File Offset: 0x00386D5F
	public HonamiStoryMascotData(int configId)
	{
		this.IdInternal = configId;
	}

	// Token: 0x170012B0 RID: 4784
	// (get) Token: 0x0600ED68 RID: 60776 RVA: 0x00388B6E File Offset: 0x00386D6E
	public HonamiStoryMascot? Config
	{
		get
		{
			return HonamiStoryConfig.Instance.GetHonamiStoryMascotConfig(this.IdInternal);
		}
	}

	// Token: 0x0600ED69 RID: 60777 RVA: 0x00388B80 File Offset: 0x00386D80
	public void UpdateState(EHonamiStoryCollectState state)
	{
		this.StateInternal = state;
	}

	// Token: 0x170012B1 RID: 4785
	// (get) Token: 0x0600ED6A RID: 60778 RVA: 0x00388B89 File Offset: 0x00386D89
	public EHonamiStoryCollectState State
	{
		get
		{
			return this.StateInternal;
		}
	}

	// Token: 0x170012B2 RID: 4786
	// (get) Token: 0x0600ED6B RID: 60779 RVA: 0x00388B91 File Offset: 0x00386D91
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x170012B3 RID: 4787
	// (get) Token: 0x0600ED6C RID: 60780 RVA: 0x00388B9C File Offset: 0x00386D9C
	public string Name
	{
		get
		{
			return this.Config.Value.Name;
		}
	}

	// Token: 0x170012B4 RID: 4788
	// (get) Token: 0x0600ED6D RID: 60781 RVA: 0x00388BC0 File Offset: 0x00386DC0
	public string FeatureDesc
	{
		get
		{
			return this.Config.Value.FeatureDesc;
		}
	}

	// Token: 0x170012B5 RID: 4789
	// (get) Token: 0x0600ED6E RID: 60782 RVA: 0x00388BE4 File Offset: 0x00386DE4
	public string ClueDesc
	{
		get
		{
			return this.Config.Value.ClueDesc;
		}
	}

	// Token: 0x170012B6 RID: 4790
	// (get) Token: 0x0600ED6F RID: 60783 RVA: 0x00388C08 File Offset: 0x00386E08
	public int DropId
	{
		get
		{
			return this.Config.Value.DropId;
		}
	}

	// Token: 0x170012B7 RID: 4791
	// (get) Token: 0x0600ED70 RID: 60784 RVA: 0x00388C2C File Offset: 0x00386E2C
	public int AreaId
	{
		get
		{
			return this.Config.Value.AreaId;
		}
	}

	// Token: 0x04006E35 RID: 28213
	private readonly int IdInternal;

	// Token: 0x04006E36 RID: 28214
	private EHonamiStoryCollectState StateInternal;
}
