using System;
using Aki.Config;

// Token: 0x02001344 RID: 4932
public class HonamiStoryTechNodeData
{
	// Token: 0x0600C225 RID: 49701 RVA: 0x00397ED2 File Offset: 0x003960D2
	public HonamiStoryTechNodeData(HonamiStoryTalent config)
	{
		this.Config = config;
	}

	// Token: 0x0600C226 RID: 49702 RVA: 0x00397EE1 File Offset: 0x003960E1
	public void SetNodeStatus(int status)
	{
		if (status == 1)
		{
			this.NodeStatus = ENodeStatus.CanActive;
			return;
		}
		if (status == 2)
		{
			this.NodeStatus = ENodeStatus.IsActive;
		}
	}

	// Token: 0x170012F4 RID: 4852
	// (get) Token: 0x0600C227 RID: 49703 RVA: 0x00397EFA File Offset: 0x003960FA
	public ENodeStatus GetNodeStatus
	{
		get
		{
			return this.NodeStatus;
		}
	}

	// Token: 0x170012F5 RID: 4853
	// (get) Token: 0x0600C228 RID: 49704 RVA: 0x00397F04 File Offset: 0x00396104
	public bool PreNodeIsActive
	{
		get
		{
			foreach (int id in this.Config.PreId())
			{
				HonamiStoryTechNodeData techNodeData = HonamiStoryModel.Instance.GetTechNodeData(id);
				if (techNodeData == null || techNodeData.GetNodeStatus != ENodeStatus.IsActive)
				{
					return false;
				}
			}
			return true;
		}
	}

	// Token: 0x170012F6 RID: 4854
	// (get) Token: 0x0600C229 RID: 49705 RVA: 0x00397F4A File Offset: 0x0039614A
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170012F7 RID: 4855
	// (get) Token: 0x0600C22A RID: 49706 RVA: 0x00397F57 File Offset: 0x00396157
	public HonamiStoryTalent GetConfig
	{
		get
		{
			return this.Config;
		}
	}

	// Token: 0x04006F54 RID: 28500
	private HonamiStoryTalent Config;

	// Token: 0x04006F55 RID: 28501
	private ENodeStatus NodeStatus;
}
