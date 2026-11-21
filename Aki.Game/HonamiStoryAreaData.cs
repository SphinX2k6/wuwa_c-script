using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x0200132C RID: 4908
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryAreaData
{
	// Token: 0x0600C112 RID: 49426 RVA: 0x0039317C File Offset: 0x0039137C
	public HonamiStoryAreaData(int areaId)
	{
		this.AreaId = areaId;
		this.AreaStateInternal = EHonamiStoryAreaState.Lock;
	}

	// Token: 0x0600C113 RID: 49427 RVA: 0x00393194 File Offset: 0x00391394
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

	// Token: 0x0600C114 RID: 49428 RVA: 0x0039321D File Offset: 0x0039141D
	public void UpdateCollectMascotState(EHonamiStoryCollectState state)
	{
		this.SecretStateInternal = state;
	}

	// Token: 0x170012C2 RID: 4802
	// (get) Token: 0x0600C115 RID: 49429 RVA: 0x00393226 File Offset: 0x00391426
	public EHonamiStoryCollectState CollectMascotState
	{
		get
		{
			return this.SecretStateInternal;
		}
	}

	// Token: 0x170012C3 RID: 4803
	// (get) Token: 0x0600C116 RID: 49430 RVA: 0x0039322E File Offset: 0x0039142E
	public HonamiStoryArea? Config
	{
		get
		{
			return HonamiStoryConfig.Instance.GetHonamiStoryAreaConfig(this.AreaId);
		}
	}

	// Token: 0x170012C4 RID: 4804
	// (get) Token: 0x0600C117 RID: 49431 RVA: 0x00393240 File Offset: 0x00391440
	public int Id
	{
		get
		{
			return this.AreaId;
		}
	}

	// Token: 0x170012C5 RID: 4805
	// (get) Token: 0x0600C118 RID: 49432 RVA: 0x00393248 File Offset: 0x00391448
	public string Name
	{
		get
		{
			return this.Config.Value.Name;
		}
	}

	// Token: 0x170012C6 RID: 4806
	// (get) Token: 0x0600C119 RID: 49433 RVA: 0x0039326C File Offset: 0x0039146C
	public string Desc
	{
		get
		{
			return this.Config.Value.Desc;
		}
	}

	// Token: 0x170012C7 RID: 4807
	// (get) Token: 0x0600C11A RID: 49434 RVA: 0x00393290 File Offset: 0x00391490
	public int DropId
	{
		get
		{
			return this.Config.Value.DropId;
		}
	}

	// Token: 0x170012C8 RID: 4808
	// (get) Token: 0x0600C11B RID: 49435 RVA: 0x003932B3 File Offset: 0x003914B3
	public bool IsAreaUnlock
	{
		get
		{
			return this.AreaStateInternal > EHonamiStoryAreaState.Lock;
		}
	}

	// Token: 0x170012C9 RID: 4809
	// (get) Token: 0x0600C11C RID: 49436 RVA: 0x003932BE File Offset: 0x003914BE
	public EHonamiStoryAreaState GetAreaState
	{
		get
		{
			return this.AreaStateInternal;
		}
	}

	// Token: 0x170012CA RID: 4810
	// (get) Token: 0x0600C11D RID: 49437 RVA: 0x003932C6 File Offset: 0x003914C6
	public bool IsAreaCanEnter
	{
		get
		{
			return this.AreaStateInternal > EHonamiStoryAreaState.Lock;
		}
	}

	// Token: 0x170012CB RID: 4811
	// (get) Token: 0x0600C11E RID: 49438 RVA: 0x003932D1 File Offset: 0x003914D1
	public bool IsSecretFinished
	{
		get
		{
			return this.SecretStateInternal == EHonamiStoryCollectState.Finished;
		}
	}

	// Token: 0x170012CC RID: 4812
	// (get) Token: 0x0600C11F RID: 49439 RVA: 0x003932DC File Offset: 0x003914DC
	public int LevelPlayId
	{
		get
		{
			return this.Config.Value.MainBTId;
		}
	}

	// Token: 0x04006EEA RID: 28394
	private readonly int AreaId;

	// Token: 0x04006EEB RID: 28395
	private EHonamiStoryCollectState SecretStateInternal;

	// Token: 0x04006EEC RID: 28396
	private EHonamiStoryAreaState AreaStateInternal;
}
