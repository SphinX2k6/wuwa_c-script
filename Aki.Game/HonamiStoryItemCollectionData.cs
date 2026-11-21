using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x0200132F RID: 4911
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemCollectionData
{
	// Token: 0x0600C14D RID: 49485 RVA: 0x00393FB6 File Offset: 0x003921B6
	public HonamiStoryItemCollectionData(HonamiStoryItemCollection config)
	{
		this.Config = config;
	}

	// Token: 0x0600C14E RID: 49486 RVA: 0x00393FC5 File Offset: 0x003921C5
	public void UpdateData(HonamiStoryItemCollectionInfo areaSecretInfo)
	{
		this.StateInternal = (EHonamiStoryCollectState)areaSecretInfo.Status;
	}

	// Token: 0x0600C14F RID: 49487 RVA: 0x00393FD3 File Offset: 0x003921D3
	public void UpdateState(EHonamiStoryCollectState state)
	{
		this.StateInternal = state;
	}

	// Token: 0x170012CF RID: 4815
	// (get) Token: 0x0600C150 RID: 49488 RVA: 0x00393FDC File Offset: 0x003921DC
	public EHonamiStoryCollectState State
	{
		get
		{
			return this.StateInternal;
		}
	}

	// Token: 0x170012D0 RID: 4816
	// (get) Token: 0x0600C151 RID: 49489 RVA: 0x00393FE4 File Offset: 0x003921E4
	public int Id
	{
		get
		{
			return this.Config.ItemId;
		}
	}

	// Token: 0x170012D1 RID: 4817
	// (get) Token: 0x0600C152 RID: 49490 RVA: 0x00394000 File Offset: 0x00392200
	public string Name
	{
		get
		{
			return this.Config.Name;
		}
	}

	// Token: 0x170012D2 RID: 4818
	// (get) Token: 0x0600C153 RID: 49491 RVA: 0x0039401C File Offset: 0x0039221C
	public string Desc
	{
		get
		{
			return this.Config.Desc;
		}
	}

	// Token: 0x170012D3 RID: 4819
	// (get) Token: 0x0600C154 RID: 49492 RVA: 0x00394038 File Offset: 0x00392238
	public int DropId
	{
		get
		{
			return this.Config.DropId;
		}
	}

	// Token: 0x170012D4 RID: 4820
	// (get) Token: 0x0600C155 RID: 49493 RVA: 0x00394053 File Offset: 0x00392253
	public HonamiStoryItemCollection GetConfig
	{
		get
		{
			return this.Config;
		}
	}

	// Token: 0x04006EFF RID: 28415
	private readonly HonamiStoryItemCollection Config;

	// Token: 0x04006F00 RID: 28416
	private EHonamiStoryCollectState StateInternal;
}
