using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E6A RID: 7786
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryAreaData
{
	// Token: 0x0600ECF3 RID: 60659 RVA: 0x00387550 File Offset: 0x00385750
	public HonamiStoryAreaData(int areaId)
	{
		this.AreaId = areaId;
		this.AreaStateInternal = EHonamiStoryAreaState.Lock;
	}

	// Token: 0x0600ECF4 RID: 60660 RVA: 0x00387568 File Offset: 0x00385768
	public void UpdateData(HonamiStoryAreaInfo areaInfo)
	{
		this.SecretStateInternal = (EHonamiStoryCollectState)areaInfo.SecreteStatus;
		EHonamiStoryAreaState status = (EHonamiStoryAreaState)areaInfo.Status;
		if (this.AreaStateInternal == EHonamiStoryAreaState.Lock && status == EHonamiStoryAreaState.UnLock)
		{
			int areaId = this.AreaId;
			if (this.Config.Value.UnLockTips.Length > 0)
			{
				Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.HonamiStorySelectLvAreaUnLockTips, new Dictionary<int, bool>());
				if (!player.ContainsKey(areaId))
				{
					player[areaId] = true;
					LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.HonamiStorySelectLvAreaUnLockTips, player);
				}
			}
		}
		this.AreaStateInternal = status;
	}

	// Token: 0x0600ECF5 RID: 60661 RVA: 0x003875F1 File Offset: 0x003857F1
	public void UpdateCollectMascotState(EHonamiStoryCollectState state)
	{
		this.SecretStateInternal = state;
	}

	// Token: 0x17001298 RID: 4760
	// (get) Token: 0x0600ECF6 RID: 60662 RVA: 0x003875FA File Offset: 0x003857FA
	public EHonamiStoryCollectState CollectMascotState
	{
		get
		{
			return this.SecretStateInternal;
		}
	}

	// Token: 0x17001299 RID: 4761
	// (get) Token: 0x0600ECF7 RID: 60663 RVA: 0x00387602 File Offset: 0x00385802
	public HonamiStoryArea? Config
	{
		get
		{
			return HonamiStoryConfig.Instance.GetHonamiStoryAreaConfig(this.AreaId);
		}
	}

	// Token: 0x1700129A RID: 4762
	// (get) Token: 0x0600ECF8 RID: 60664 RVA: 0x00387614 File Offset: 0x00385814
	public int Id
	{
		get
		{
			return this.AreaId;
		}
	}

	// Token: 0x1700129B RID: 4763
	// (get) Token: 0x0600ECF9 RID: 60665 RVA: 0x0038761C File Offset: 0x0038581C
	public string Name
	{
		get
		{
			return this.Config.Value.Name;
		}
	}

	// Token: 0x1700129C RID: 4764
	// (get) Token: 0x0600ECFA RID: 60666 RVA: 0x00387640 File Offset: 0x00385840
	public string Desc
	{
		get
		{
			return this.Config.Value.Desc;
		}
	}

	// Token: 0x1700129D RID: 4765
	// (get) Token: 0x0600ECFB RID: 60667 RVA: 0x00387664 File Offset: 0x00385864
	public int DropId
	{
		get
		{
			return this.Config.Value.DropId;
		}
	}

	// Token: 0x1700129E RID: 4766
	// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x00387687 File Offset: 0x00385887
	public bool IsAreaUnlock
	{
		get
		{
			return this.AreaStateInternal > EHonamiStoryAreaState.Lock;
		}
	}

	// Token: 0x1700129F RID: 4767
	// (get) Token: 0x0600ECFD RID: 60669 RVA: 0x00387692 File Offset: 0x00385892
	public EHonamiStoryAreaState GetAreaState
	{
		get
		{
			return this.AreaStateInternal;
		}
	}

	// Token: 0x170012A0 RID: 4768
	// (get) Token: 0x0600ECFE RID: 60670 RVA: 0x0038769A File Offset: 0x0038589A
	public bool IsAreaCanEnter
	{
		get
		{
			return this.AreaStateInternal > EHonamiStoryAreaState.Lock;
		}
	}

	// Token: 0x170012A1 RID: 4769
	// (get) Token: 0x0600ECFF RID: 60671 RVA: 0x003876A5 File Offset: 0x003858A5
	public bool IsSecretFinished
	{
		get
		{
			return this.SecretStateInternal == EHonamiStoryCollectState.Finished;
		}
	}

	// Token: 0x170012A2 RID: 4770
	// (get) Token: 0x0600ED00 RID: 60672 RVA: 0x003876B0 File Offset: 0x003858B0
	public int LevelPlayId
	{
		get
		{
			return this.Config.Value.MainBTId;
		}
	}

	// Token: 0x04006E09 RID: 28169
	private readonly int AreaId;

	// Token: 0x04006E0A RID: 28170
	private EHonamiStoryCollectState SecretStateInternal;

	// Token: 0x04006E0B RID: 28171
	private EHonamiStoryAreaState AreaStateInternal;
}
