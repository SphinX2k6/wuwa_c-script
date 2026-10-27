using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E6D RID: 7789
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemCollectionData
{
	// Token: 0x0600ED2E RID: 60718 RVA: 0x003883AA File Offset: 0x003865AA
	public HonamiStoryItemCollectionData(HonamiStoryItemCollection config)
	{
		this.Config = config;
	}

	// Token: 0x0600ED2F RID: 60719 RVA: 0x003883B9 File Offset: 0x003865B9
	public void UpdateData(HonamiStoryItemCollectionInfo areaSecretInfo)
	{
		this.StateInternal = (EHonamiStoryCollectState)areaSecretInfo.Status;
	}

	// Token: 0x0600ED30 RID: 60720 RVA: 0x003883C7 File Offset: 0x003865C7
	public void UpdateState(EHonamiStoryCollectState state)
	{
		this.StateInternal = state;
	}

	// Token: 0x170012A5 RID: 4773
	// (get) Token: 0x0600ED31 RID: 60721 RVA: 0x003883D0 File Offset: 0x003865D0
	public EHonamiStoryCollectState State
	{
		get
		{
			return this.StateInternal;
		}
	}

	// Token: 0x170012A6 RID: 4774
	// (get) Token: 0x0600ED32 RID: 60722 RVA: 0x003883D8 File Offset: 0x003865D8
	public int Id
	{
		get
		{
			return this.Config.ItemId;
		}
	}

	// Token: 0x170012A7 RID: 4775
	// (get) Token: 0x0600ED33 RID: 60723 RVA: 0x003883F4 File Offset: 0x003865F4
	public string Name
	{
		get
		{
			return this.Config.Name;
		}
	}

	// Token: 0x170012A8 RID: 4776
	// (get) Token: 0x0600ED34 RID: 60724 RVA: 0x00388410 File Offset: 0x00386610
	public string Desc
	{
		get
		{
			return this.Config.Desc;
		}
	}

	// Token: 0x170012A9 RID: 4777
	// (get) Token: 0x0600ED35 RID: 60725 RVA: 0x0038842C File Offset: 0x0038662C
	public int DropId
	{
		get
		{
			return this.Config.DropId;
		}
	}

	// Token: 0x170012AA RID: 4778
	// (get) Token: 0x0600ED36 RID: 60726 RVA: 0x00388447 File Offset: 0x00386647
	public HonamiStoryItemCollection GetConfig
	{
		get
		{
			return this.Config;
		}
	}

	// Token: 0x04006E1E RID: 28190
	private readonly HonamiStoryItemCollection Config;

	// Token: 0x04006E1F RID: 28191
	private EHonamiStoryCollectState StateInternal;
}
