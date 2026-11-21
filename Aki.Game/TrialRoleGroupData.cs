using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using Google.Protobuf.Collections;

// Token: 0x02001E62 RID: 7778
[NullableContext(2)]
[Nullable(0)]
public class TrialRoleGroupData
{
	// Token: 0x17001D5B RID: 7515
	// (get) Token: 0x060133DD RID: 78813 RVA: 0x0059F894 File Offset: 0x0059DA94
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

	// Token: 0x17001D5C RID: 7516
	// (get) Token: 0x060133DE RID: 78814 RVA: 0x0059F8C0 File Offset: 0x0059DAC0
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

	// Token: 0x17001D5D RID: 7517
	// (get) Token: 0x060133DF RID: 78815 RVA: 0x0059F8EC File Offset: 0x0059DAEC
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

	// Token: 0x17001D5E RID: 7518
	// (get) Token: 0x060133E0 RID: 78816 RVA: 0x0059F917 File Offset: 0x0059DB17
	public ETrialRoleStatus Status
	{
		get
		{
			return this.StatusInternal;
		}
	}

	// Token: 0x17001D5F RID: 7519
	// (get) Token: 0x060133E1 RID: 78817 RVA: 0x0059F91F File Offset: 0x0059DB1F
	public TrialRoleInfo TrialRoleConfig
	{
		get
		{
			return this.ActivatedRoleConfigInternal.Value;
		}
	}

	// Token: 0x17001D60 RID: 7520
	// (get) Token: 0x060133E2 RID: 78818 RVA: 0x0059F92C File Offset: 0x0059DB2C
	public RoleSpecialRobotData TrialRoleData
	{
		get
		{
			return this.ActivatedRoleDataInternal;
		}
	}

	// Token: 0x17001D61 RID: 7521
	// (get) Token: 0x060133E3 RID: 78819 RVA: 0x0059F934 File Offset: 0x0059DB34
	public ETrialRoleType TrialRoleType
	{
		get
		{
			return (ETrialRoleType)this.ActivatedRoleConfigInternal.Value.Type;
		}
	}

	// Token: 0x060133E4 RID: 78820 RVA: 0x0059F954 File Offset: 0x0059DB54
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

	// Token: 0x060133E5 RID: 78821 RVA: 0x0059F9F4 File Offset: 0x0059DBF4
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

	// Token: 0x060133E6 RID: 78822 RVA: 0x0059FAA3 File Offset: 0x0059DCA3
	public void SetIsVisibleInFormation(bool isVisible)
	{
		if (this.ActivatedRoleDataInternal == null)
		{
			this.VisibleInFormationHandle = new bool?(isVisible);
			return;
		}
		this.ActivatedRoleDataInternal.SetIsVisibleInFormation(isVisible);
	}

	// Token: 0x060133E7 RID: 78823 RVA: 0x0059FAC6 File Offset: 0x0059DCC6
	public void SetIsVisibleInRoleSystem(bool isVisible)
	{
		RoleSpecialRobotData activatedRoleDataInternal = this.ActivatedRoleDataInternal;
		if (activatedRoleDataInternal == null)
		{
			return;
		}
		activatedRoleDataInternal.SetIsVisibleInRoleSystem(isVisible);
	}

	// Token: 0x060133E8 RID: 78824 RVA: 0x0059FADC File Offset: 0x0059DCDC
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

	// Token: 0x060133E9 RID: 78825 RVA: 0x0059FB48 File Offset: 0x0059DD48
	public bool IsLocked()
	{
		return this.StatusInternal == ETrialRoleStatus.Locked;
	}

	// Token: 0x060133EA RID: 78826 RVA: 0x0059FB53 File Offset: 0x0059DD53
	public bool IsUnlocked()
	{
		return this.StatusInternal == ETrialRoleStatus.Unlocked;
	}

	// Token: 0x060133EB RID: 78827 RVA: 0x0059FB5E File Offset: 0x0059DD5E
	public bool CanUpgrade()
	{
		return this.IsUnlocked() && this.IsReachUpgradeCondition();
	}

	// Token: 0x060133EC RID: 78828 RVA: 0x0059FB70 File Offset: 0x0059DD70
	public int GetCurWorldLevel()
	{
		if (this.ActivatedRoleConfigInternal == null)
		{
			return 0;
		}
		return this.ActivatedRoleConfigInternal.GetValueOrDefault().WorldLevel;
	}

	// Token: 0x060133ED RID: 78829 RVA: 0x0059FB9C File Offset: 0x0059DD9C
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

	// Token: 0x060133EE RID: 78830 RVA: 0x0059FC1B File Offset: 0x0059DE1B
	public bool IsMaxLevel()
	{
		return this.GetNextWorldLevel() < 0;
	}

	// Token: 0x060133EF RID: 78831 RVA: 0x0059FC28 File Offset: 0x0059DE28
	public bool IsReachUpgradeCondition()
	{
		if (this.IsMaxLevel())
		{
			return false;
		}
		int nextWorldLevel = this.GetNextWorldLevel();
		return nextWorldLevel >= 0 && WorldLevelModel.Instance.OriginWorldLevel >= nextWorldLevel;
	}

	// Token: 0x060133F0 RID: 78832 RVA: 0x0059FC5C File Offset: 0x0059DE5C
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

	// Token: 0x060133F1 RID: 78833 RVA: 0x0059FCE8 File Offset: 0x0059DEE8
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

	// Token: 0x0400A4BA RID: 42170
	private TrialRoleInfo? ActivatedRoleConfigInternal;

	// Token: 0x0400A4BB RID: 42171
	private RoleSpecialRobotData ActivatedRoleDataInternal;

	// Token: 0x0400A4BC RID: 42172
	private ETrialRoleStatus StatusInternal;

	// Token: 0x0400A4BD RID: 42173
	private readonly List<TrialRoleInfo> TrialRoleGroupConfigs;

	// Token: 0x0400A4BE RID: 42174
	private bool? VisibleInFormationHandle;
}
