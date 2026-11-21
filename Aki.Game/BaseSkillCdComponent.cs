using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;

// Token: 0x0200268E RID: 9870
[NullableContext(1)]
[Nullable(0)]
public class BaseSkillCdComponent : EntityComponent
{
	// Token: 0x06018B7C RID: 101244 RVA: 0x00780EC4 File Offset: 0x0077F0C4
	protected override bool OnInit()
	{
		this.BuffComp = base.Entity.CheckGetComponent<BaseBuffComponent>();
		this.PassiveSkillCdInfoMap = new Dictionary<long, PassiveSkillCdInfo>();
		this.CurWorldPassiveSkillCdData = SkillCdModel.Instance.GetCurWorldPassiveSkillCdData();
		return true;
	}

	// Token: 0x06018B7D RID: 101245 RVA: 0x00780EF3 File Offset: 0x0077F0F3
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

	// Token: 0x06018B7E RID: 101246 RVA: 0x00780F20 File Offset: 0x0077F120
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

	// Token: 0x06018B7F RID: 101247 RVA: 0x00780FB0 File Offset: 0x0077F1B0
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

	// Token: 0x06018B80 RID: 101248 RVA: 0x00780FFC File Offset: 0x0077F1FC
	public bool IsPassiveSkillInCd(long skillId, int entityId)
	{
		PassiveSkillCdInfo passiveSkillCdInfo;
		return this.PassiveSkillCdInfoMap.TryGetValue(skillId, out passiveSkillCdInfo) && passiveSkillCdInfo.IsInCd(entityId);
	}

	// Token: 0x06018B81 RID: 101249 RVA: 0x00781024 File Offset: 0x0077F224
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

	// Token: 0x06018B82 RID: 101250 RVA: 0x00781053 File Offset: 0x0077F253
	public PassiveSkillCdInfo GetPassiveSkillCdInfo(long skillId)
	{
		return this.PassiveSkillCdInfoMap[skillId];
	}

	// Token: 0x06018B83 RID: 101251 RVA: 0x00781064 File Offset: 0x0077F264
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseSkillCdComponent baseSkillCdComponent = (BaseSkillCdComponent)componentTemplate;
		if (baseSkillCdComponent.BuffComp == null)
		{
			this.BuffComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComp), "BuffComp"))
		{
			return false;
		}
		this.HasModifyCdEffect = baseSkillCdComponent.HasModifyCdEffect;
		if (baseSkillCdComponent.PassiveSkillCdInfoMap == null)
		{
			this.PassiveSkillCdInfoMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PassiveSkillCdInfoMap), "PassiveSkillCdInfoMap"))
		{
			return false;
		}
		if (baseSkillCdComponent.CurWorldPassiveSkillCdData == null)
		{
			this.CurWorldPassiveSkillCdData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurWorldPassiveSkillCdData), "CurWorldPassiveSkillCdData"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002723 RID: 10019
	// (get) Token: 0x06018B84 RID: 101252 RVA: 0x00781111 File Offset: 0x0077F311
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002724 RID: 10020
	// (get) Token: 0x06018B85 RID: 101253 RVA: 0x00781114 File Offset: 0x0077F314
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D6B4 RID: 54964
	[Nullable(2)]
	protected BaseBuffComponent BuffComp;

	// Token: 0x0400D6B5 RID: 54965
	public bool HasModifyCdEffect;

	// Token: 0x0400D6B6 RID: 54966
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, PassiveSkillCdInfo> PassiveSkillCdInfoMap;

	// Token: 0x0400D6B7 RID: 54967
	[Nullable(2)]
	private WorldPassiveSkillCdData CurWorldPassiveSkillCdData;
}
