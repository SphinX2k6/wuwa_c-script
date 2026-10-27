using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using Google.Protobuf.Collections;

// Token: 0x020028E7 RID: 10471
[NullableContext(2)]
[Nullable(0)]
public class TrialRoleGroupData
{
	// Token: 0x17001D01 RID: 7425
	// (get) Token: 0x060159D9 RID: 88537 RVA: 0x005749CC File Offset: 0x00572BCC
	public int RealRoleId
	{
		get
		{
			if (this.ActivatedRoleConfigInternal == null)
			{
				return 0;
			}
			return this.ActivatedRoleConfigInternal.GetValueOrDefault().ParentId;
		}
	}

	// Token: 0x17001D02 RID: 7426
	// (get) Token: 0x060159DA RID: 88538 RVA: 0x005749F8 File Offset: 0x00572BF8
	public int TrialRoleId
	{
		get
		{
			if (this.ActivatedRoleConfigInternal == null)
			{
				return 0;
			}
			return this.ActivatedRoleConfigInternal.GetValueOrDefault().Id;
		}
	}

	// Token: 0x17001D03 RID: 7427
	// (get) Token: 0x060159DB RID: 88539 RVA: 0x00574A24 File Offset: 0x00572C24
	public int TrialRoleGroupId
	{
		get
		{
			if (this.ActivatedRoleConfigInternal == null)
			{
				return 0;
			}
			return this.ActivatedRoleConfigInternal.GetValueOrDefault().GroupId;
		}
	}

	// Token: 0x17001D04 RID: 7428
	// (get) Token: 0x060159DC RID: 88540 RVA: 0x00574A4F File Offset: 0x00572C4F
	public ETrialRoleStatus Status
	{
		get
		{
			return this.StatusInternal;
		}
	}

	// Token: 0x17001D05 RID: 7429
	// (get) Token: 0x060159DD RID: 88541 RVA: 0x00574A57 File Offset: 0x00572C57
	public TrialRoleInfo TrialRoleConfig
	{
		get
		{
			return this.ActivatedRoleConfigInternal.Value;
		}
	}

	// Token: 0x17001D06 RID: 7430
	// (get) Token: 0x060159DE RID: 88542 RVA: 0x00574A64 File Offset: 0x00572C64
	public RoleSpecialRobotData TrialRoleData
	{
		get
		{
			return this.ActivatedRoleDataInternal;
		}
	}

	// Token: 0x17001D07 RID: 7431
	// (get) Token: 0x060159DF RID: 88543 RVA: 0x00574A6C File Offset: 0x00572C6C
	public ETrialRoleType TrialRoleType
	{
		get
		{
			return (ETrialRoleType)this.ActivatedRoleConfigInternal.Value.Type;
		}
	}

	// Token: 0x060159E0 RID: 88544 RVA: 0x00574A8C File Offset: 0x00572C8C
	public TrialRoleGroupData(int trialRoleId)
	{
		TrialRoleConfig instance = CSharpScript.Game.Module.RoleUi.TrialRoleConfig.Instance;
		this.ActivatedRoleConfigInternal = ((instance != null) ? instance.GetTrialRoleConfig(trialRoleId) : null);
		if (this.ActivatedRoleConfigInternal != null)
		{
			TrialRoleConfig instance2 = CSharpScript.Game.Module.RoleUi.TrialRoleConfig.Instance;
			IReadOnlyList<TrialRoleInfo> readonlyArray = (instance2 != null) ? instance2.GetTrialRoleConfigsByGroupId(this.ActivatedRoleConfigInternal.Value.GroupId) : null;
			this.TrialRoleGroupConfigs = ConfigCommon.ToList<TrialRoleInfo>(readonlyArray);
			List<TrialRoleInfo> trialRoleGroupConfigs = this.TrialRoleGroupConfigs;
			if (trialRoleGroupConfigs == null)
			{
				return;
			}
			trialRoleGroupConfigs.Sort((TrialRoleInfo a, TrialRoleInfo b) => a.WorldLevel - b.WorldLevel);
		}
	}

	// Token: 0x060159E1 RID: 88545 RVA: 0x00574B2C File Offset: 0x00572D2C
	public void SetIsUnlocked(bool isUnlocked)
	{
		this.StatusInternal = (isUnlocked ? ETrialRoleStatus.Unlocked : ETrialRoleStatus.Locked);
		if (isUnlocked && this.ActivatedRoleDataInternal == null)
		{
			RoleModel instance = RoleModel.Instance;
			this.ActivatedRoleDataInternal = (((instance != null) ? instance.GetRoleDataById(this.TrialRoleId, true) : null) as RoleSpecialRobotData);
			if (this.ActivatedRoleDataInternal != null)
			{
				this.ActivatedRoleDataInternal.SetIsVisibleInFormation(false);
				this.ActivatedRoleDataInternal.SetIsVisibleInRoleSystem(false);
			}
		}
		RoleSpecialRobotData activatedRoleDataInternal = this.ActivatedRoleDataInternal;
		if (activatedRoleDataInternal != null)
		{
			activatedRoleDataInternal.SetIsUnlock(isUnlocked);
		}
		if (this.VisibleInFormationHandle != null)
		{
			RoleSpecialRobotData activatedRoleDataInternal2 = this.ActivatedRoleDataInternal;
			if (activatedRoleDataInternal2 != null)
			{
				activatedRoleDataInternal2.SetIsVisibleInFormation(this.VisibleInFormationHandle.Value);
			}
			this.VisibleInFormationHandle = null;
		}
	}

	// Token: 0x060159E2 RID: 88546 RVA: 0x00574BDB File Offset: 0x00572DDB
	public void SetIsVisibleInFormation(bool isVisible)
	{
		if (this.ActivatedRoleDataInternal == null)
		{
			this.VisibleInFormationHandle = new bool?(isVisible);
			return;
		}
		this.ActivatedRoleDataInternal.SetIsVisibleInFormation(isVisible);
	}

	// Token: 0x060159E3 RID: 88547 RVA: 0x00574BFE File Offset: 0x00572DFE
	public void SetIsVisibleInRoleSystem(bool isVisible)
	{
		RoleSpecialRobotData activatedRoleDataInternal = this.ActivatedRoleDataInternal;
		if (activatedRoleDataInternal == null)
		{
			return;
		}
		activatedRoleDataInternal.SetIsVisibleInRoleSystem(isVisible);
	}

	// Token: 0x060159E4 RID: 88548 RVA: 0x00574C14 File Offset: 0x00572E14
	public void SetActivatedTrialRoleId(int trialRoleId)
	{
		RoleSpecialRobotData activatedRoleDataInternal = this.ActivatedRoleDataInternal;
		TrialRoleConfig instance = CSharpScript.Game.Module.RoleUi.TrialRoleConfig.Instance;
		this.ActivatedRoleConfigInternal = ((instance != null) ? instance.GetTrialRoleConfig(trialRoleId) : null);
		RoleModel instance2 = RoleModel.Instance;
		this.ActivatedRoleDataInternal = (((instance2 != null) ? instance2.GetRoleDataById(trialRoleId, true) : null) as RoleSpecialRobotData);
		if (activatedRoleDataInternal != null && activatedRoleDataInternal != this.ActivatedRoleDataInternal)
		{
			activatedRoleDataInternal.SetIsVisibleInFormation(false);
			activatedRoleDataInternal.SetIsVisibleInRoleSystem(false);
		}
	}

	// Token: 0x060159E5 RID: 88549 RVA: 0x00574C80 File Offset: 0x00572E80
	public bool IsLocked()
	{
		return this.StatusInternal == ETrialRoleStatus.Locked;
	}

	// Token: 0x060159E6 RID: 88550 RVA: 0x00574C8B File Offset: 0x00572E8B
	public bool IsUnlocked()
	{
		return this.StatusInternal == ETrialRoleStatus.Unlocked;
	}

	// Token: 0x060159E7 RID: 88551 RVA: 0x00574C96 File Offset: 0x00572E96
	public bool CanUpgrade()
	{
		return this.IsUnlocked() && this.IsReachUpgradeCondition();
	}

	// Token: 0x060159E8 RID: 88552 RVA: 0x00574CA8 File Offset: 0x00572EA8
	public int GetCurWorldLevel()
	{
		if (this.ActivatedRoleConfigInternal == null)
		{
			return 0;
		}
		return this.ActivatedRoleConfigInternal.GetValueOrDefault().WorldLevel;
	}

	// Token: 0x060159E9 RID: 88553 RVA: 0x00574CD4 File Offset: 0x00572ED4
	public int GetNextWorldLevel()
	{
		if (this.TrialRoleGroupConfigs == null)
		{
			return -1;
		}
		int num = -1;
		for (int i = 0; i < this.TrialRoleGroupConfigs.Count; i++)
		{
			if (this.TrialRoleGroupConfigs[i].Id == this.TrialRoleId)
			{
				num = i;
				break;
			}
		}
		if (num >= 0 && num + 1 < this.TrialRoleGroupConfigs.Count)
		{
			return this.TrialRoleGroupConfigs[num + 1].WorldLevel;
		}
		return -1;
	}

	// Token: 0x060159EA RID: 88554 RVA: 0x00574D53 File Offset: 0x00572F53
	public bool IsMaxLevel()
	{
		return this.GetNextWorldLevel() < 0;
	}

	// Token: 0x060159EB RID: 88555 RVA: 0x00574D60 File Offset: 0x00572F60
	public bool IsReachUpgradeCondition()
	{
		if (this.IsMaxLevel())
		{
			return false;
		}
		int nextWorldLevel = this.GetNextWorldLevel();
		return nextWorldLevel >= 0 && WorldLevelModel.Instance.OriginWorldLevel >= nextWorldLevel;
	}

	// Token: 0x060159EC RID: 88556 RVA: 0x00574D94 File Offset: 0x00572F94
	public int GetPreviewTrialRoleId()
	{
		if (this.IsUnlocked())
		{
			return this.TrialRoleId;
		}
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		int result = this.TrialRoleId;
		if (this.TrialRoleGroupConfigs != null)
		{
			foreach (TrialRoleInfo trialRoleInfo in this.TrialRoleGroupConfigs)
			{
				if (trialRoleInfo.WorldLevel > originWorldLevel)
				{
					break;
				}
				result = trialRoleInfo.Id;
			}
		}
		return result;
	}

	// Token: 0x060159ED RID: 88557 RVA: 0x00574E20 File Offset: 0x00573020
	[NullableContext(1)]
	public void SetActivatedRoleAttr(RepeatedField<ArrayIntInt> baseAttr, RepeatedField<ArrayIntInt> addAttr)
	{
		if (this.ActivatedRoleDataInternal == null)
		{
			return;
		}
		RoleAttributeData attributeData = this.ActivatedRoleDataInternal.GetAttributeData();
		attributeData.ClearRoleBaseAttr();
		foreach (ArrayIntInt arrayIntInt in baseAttr)
		{
			attributeData.SetRoleBaseAttr(arrayIntInt.Key, arrayIntInt.Value);
		}
		attributeData.ClearRoleAddAttr();
		foreach (ArrayIntInt arrayIntInt2 in addAttr)
		{
			attributeData.SetRoleAddAttr(arrayIntInt2.Key, arrayIntInt2.Value);
		}
	}

	// Token: 0x0400A0D0 RID: 41168
	private TrialRoleInfo? ActivatedRoleConfigInternal;

	// Token: 0x0400A0D1 RID: 41169
	private RoleSpecialRobotData ActivatedRoleDataInternal;

	// Token: 0x0400A0D2 RID: 41170
	private ETrialRoleStatus StatusInternal;

	// Token: 0x0400A0D3 RID: 41171
	private readonly List<TrialRoleInfo> TrialRoleGroupConfigs;

	// Token: 0x0400A0D4 RID: 41172
	private bool? VisibleInFormationHandle;
}
