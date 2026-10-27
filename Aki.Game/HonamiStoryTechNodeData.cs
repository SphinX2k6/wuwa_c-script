using System;
using Aki.Config;

// Token: 0x02001E82 RID: 7810
public class HonamiStoryTechNodeData
{
	// Token: 0x0600EE06 RID: 60934 RVA: 0x0038C2E2 File Offset: 0x0038A4E2
	public HonamiStoryTechNodeData(HonamiStoryTalent config)
	{
		this.Config = config;
	}

	// Token: 0x0600EE07 RID: 60935 RVA: 0x0038C2F1 File Offset: 0x0038A4F1
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

	// Token: 0x170012CA RID: 4810
	// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x0038C30A File Offset: 0x0038A50A
	public ENodeStatus GetNodeStatus
	{
		get
		{
			return this.NodeStatus;
		}
	}

	// Token: 0x170012CB RID: 4811
	// (get) Token: 0x0600EE09 RID: 60937 RVA: 0x0038C314 File Offset: 0x0038A514
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

	// Token: 0x170012CC RID: 4812
	// (get) Token: 0x0600EE0A RID: 60938 RVA: 0x0038C35A File Offset: 0x0038A55A
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170012CD RID: 4813
	// (get) Token: 0x0600EE0B RID: 60939 RVA: 0x0038C367 File Offset: 0x0038A567
	public HonamiStoryTalent GetConfig
	{
		get
		{
			return this.Config;
		}
	}

	// Token: 0x04006E73 RID: 28275
	private HonamiStoryTalent Config;

	// Token: 0x04006E74 RID: 28276
	private ENodeStatus NodeStatus;
}
