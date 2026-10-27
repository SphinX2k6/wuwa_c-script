using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;

// Token: 0x02003132 RID: 12594
[NullableContext(1)]
[Nullable(0)]
public class BaseSkillCdComponent : EntityComponent
{
	// Token: 0x0601B112 RID: 110866 RVA: 0x0075AB32 File Offset: 0x00758D32
	protected override bool OnInit()
	{
		this.BuffComp = base.Entity.CheckGetComponent<BaseBuffComponent>();
		this.PassiveSkillCdInfoMap = new Dictionary<long, PassiveSkillCdInfo>();
		this.CurWorldPassiveSkillCdData = SkillCdModel.Instance.GetCurWorldPassiveSkillCdData();
		return true;
	}

	// Token: 0x0601B113 RID: 110867 RVA: 0x0075AB61 File Offset: 0x00758D61
	protected override bool OnEnd()
	{
		base.OnEnd();
		if (this.CurWorldPassiveSkillCdData != null)
		{
			this.CurWorldPassiveSkillCdData.RemoveEntity(base.Entity);
			this.CurWorldPassiveSkillCdData = null;
		}
		return true;
	}

	// Token: 0x0601B114 RID: 110868 RVA: 0x0075AB8C File Offset: 0x00758D8C
	public void UpdateModifyCdEffect(bool bAdd, ModifyCd modifyCdEffect)
	{
		if (this.BuffComp == null)
		{
			this.HasModifyCdEffect = false;
			return;
		}
		if (bAdd)
		{
			this.HasModifyCdEffect = true;
			return;
		}
		foreach (ModifyCd modifyCd in this.BuffComp.BuffEffectManager.FilterById<ModifyCd>(EExtraEffectId.ModifyCd, null))
		{
			if (modifyCdEffect != modifyCd && modifyCd.SkillIdOrGenres.Count > 0)
			{
				this.HasModifyCdEffect = true;
				return;
			}
		}
		this.HasModifyCdEffect = false;
	}

	// Token: 0x0601B115 RID: 110869 RVA: 0x0075AC1C File Offset: 0x00758E1C
	public PassiveSkillCdInfo InitPassiveSkill(PassiveSkill passiveSkill)
	{
		long id = passiveSkill.Id;
		PassiveSkillCdInfo passiveSkillCdInfo;
		if (this.PassiveSkillCdInfoMap.TryGetValue(id, out passiveSkillCdInfo))
		{
			return passiveSkillCdInfo;
		}
		passiveSkillCdInfo = this.CurWorldPassiveSkillCdData.InitPassiveSkillCd(base.Entity, passiveSkill);
		this.PassiveSkillCdInfoMap.Add(id, passiveSkillCdInfo);
		return passiveSkillCdInfo;
	}

	// Token: 0x0601B116 RID: 110870 RVA: 0x0075AC68 File Offset: 0x00758E68
	public bool IsPassiveSkillInCd(long skillId, int entityId)
	{
		PassiveSkillCdInfo passiveSkillCdInfo;
		return this.PassiveSkillCdInfoMap.TryGetValue(skillId, out passiveSkillCdInfo) && passiveSkillCdInfo.IsInCd(entityId);
	}

	// Token: 0x0601B117 RID: 110871 RVA: 0x0075AC90 File Offset: 0x00758E90
	public bool StartPassiveCd(long skillId, int entityId, float cdTime = -1f)
	{
		PassiveSkillCdInfo passiveSkillCdInfo;
		if (!this.PassiveSkillCdInfoMap.TryGetValue(skillId, out passiveSkillCdInfo))
		{
			return false;
		}
		passiveSkillCdInfo.StartCd(passiveSkillCdInfo.SkillId, entityId, cdTime);
		return true;
	}

	// Token: 0x0601B118 RID: 110872 RVA: 0x0075ACBF File Offset: 0x00758EBF
	public PassiveSkillCdInfo GetPassiveSkillCdInfo(long skillId)
	{
		return this.PassiveSkillCdInfoMap[skillId];
	}

	// Token: 0x0601B119 RID: 110873 RVA: 0x0075ACD0 File Offset: 0x00758ED0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseSkillCdComponent baseSkillCdComponent = (BaseSkillCdComponent)componentTemplate;
		if (base.CanResetComponentProperty("BuffComp"))
		{
			if (baseSkillCdComponent.BuffComp == null)
			{
				this.BuffComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseBuffComponent>(this.BuffComp), "BuffComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HasModifyCdEffect"))
		{
			this.HasModifyCdEffect = baseSkillCdComponent.HasModifyCdEffect;
		}
		if (base.CanResetComponentProperty("PassiveSkillCdInfoMap"))
		{
			if (baseSkillCdComponent.PassiveSkillCdInfoMap == null)
			{
				this.PassiveSkillCdInfoMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, PassiveSkillCdInfo>>(this.PassiveSkillCdInfoMap), "PassiveSkillCdInfoMap"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurWorldPassiveSkillCdData"))
		{
			if (baseSkillCdComponent.CurWorldPassiveSkillCdData == null)
			{
				this.CurWorldPassiveSkillCdData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<WorldPassiveSkillCdData>(this.CurWorldPassiveSkillCdData), "CurWorldPassiveSkillCdData"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400D28A RID: 53898
	[Nullable(2)]
	protected BaseBuffComponent BuffComp;

	// Token: 0x0400D28B RID: 53899
	public bool HasModifyCdEffect;

	// Token: 0x0400D28C RID: 53900
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, PassiveSkillCdInfo> PassiveSkillCdInfoMap;

	// Token: 0x0400D28D RID: 53901
	[Nullable(2)]
	private WorldPassiveSkillCdData CurWorldPassiveSkillCdData;
}
