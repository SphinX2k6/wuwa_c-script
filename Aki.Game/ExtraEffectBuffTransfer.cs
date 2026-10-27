using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CombatMessage;
using UnrealEngine;

// Token: 0x02002F27 RID: 12071
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectBuffTransfer : BuffEffect
{
	// Token: 0x06019B87 RID: 105351 RVA: 0x006B24DC File Offset: 0x006B06DC
	public ExtraEffectBuffTransfer(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019B88 RID: 105352 RVA: 0x006B253C File Offset: 0x006B073C
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		this.BuffIds = new long[array.Length];
		this.BuffStack = new int[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.BuffIds[i] = long.Parse(array[i]);
		}
		this.RecordDuration = (int)(double.Parse(extraEffectParameters_[1]) * 1000.0);
		this.EffectInternal = (int)(double.Parse(extraEffectParameters_[2]) * 1000.0);
		this.AbnormalMessageId = CombatMessageModel.Instance.GenMessageId();
		this.AbnormalDamageType = ConfigCommonParamById.GetIntConfig("AbnormalDamageType").GetValueOrDefault(-1);
	}

	// Token: 0x06019B89 RID: 105353 RVA: 0x006B25F4 File Offset: 0x006B07F4
	public override void OnCreated()
	{
		Entity ownerEntity = base.OwnerEntity;
		if (ownerEntity != null && !EventSystem.Instance.HasWithTarget(ownerEntity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnDamageEvent)))
		{
			EventSystem.Instance.AddWithTarget(ownerEntity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnDamageEvent));
		}
		if (ownerEntity != null && !EventSystem.Instance.HasWithTarget(ownerEntity, EEventName.CharKillTarget, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnKillEvent)))
		{
			EventSystem.Instance.AddWithTarget(ownerEntity, EEventName.CharKillTarget, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnKillEvent));
		}
	}

	// Token: 0x06019B8A RID: 105354 RVA: 0x006B2678 File Offset: 0x006B0878
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"SkillMessageId",
		"BulletMessageId",
		"IsAbnormalDamage"
	})]
	protected ValueTuple<long?, long?, bool> GetEffectiveMessageIds([Nullable(1)] RequirementPayload req)
	{
		if (req.SkillMessageId != null && req.BulletMessageId != null)
		{
			return new ValueTuple<long?, long?, bool>(req.SkillMessageId, req.BulletMessageId, false);
		}
		int? damageType = req.DamageType;
		int abnormalDamageType = this.AbnormalDamageType;
		if (damageType.GetValueOrDefault() == abnormalDamageType & damageType != null)
		{
			return new ValueTuple<long?, long?, bool>(new long?(this.AbnormalMessageId), new long?(this.AbnormalMessageId), true);
		}
		return new ValueTuple<long?, long?, bool>(null, null, false);
	}

	// Token: 0x06019B8B RID: 105355 RVA: 0x006B270C File Offset: 0x006B090C
	protected void AddBuff(BaseBuffComponent buffComp, BuffTransferRecord record)
	{
		int[] buffStack = record.BuffStack;
		if (record.TransferEntity.Contains(buffComp.Entity.Id))
		{
			return;
		}
		for (int i = 0; i < this.BuffIds.Length; i++)
		{
			if (buffStack[i] > 0)
			{
				buffComp.AddIterativeBuff(this.BuffIds[i], base.Buff, new int?(buffStack[i]), true, "buff的82额外效果:Buff转移", null, null);
			}
		}
		record.TransferEntity.Add(buffComp.Entity.Id);
	}

	// Token: 0x06019B8C RID: 105356 RVA: 0x006B2798 File Offset: 0x006B0998
	protected bool GetBuffStack(BaseBuffComponent buffComp)
	{
		bool flag = false;
		for (int i = 0; i < this.BuffIds.Length; i++)
		{
			int buffTotalStackById = buffComp.GetBuffTotalStackById(this.BuffIds[i], false);
			flag = (flag || buffTotalStackById > 0);
			this.BuffStack[i] = buffTotalStackById;
		}
		return flag;
	}

	// Token: 0x06019B8D RID: 105357 RVA: 0x006B27E0 File Offset: 0x006B09E0
	protected bool UpdateMaxBuffStack(BaseBuffComponent buffComp, BuffTransferRecord record)
	{
		int[] buffStack = record.BuffStack;
		bool result = false;
		for (int i = 0; i < this.BuffIds.Length; i++)
		{
			int buffTotalStackById = buffComp.GetBuffTotalStackById(this.BuffIds[i], false);
			if (buffTotalStackById > buffStack[i])
			{
				buffStack[i] = buffTotalStackById;
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06019B8E RID: 105358 RVA: 0x006B2826 File Offset: 0x006B0A26
	protected void OnDamageEvent(Entity attacker, Entity victim, RequirementPayload req, DamageResult result, FVectorDouble damagePosition)
	{
		if (result.IsTargetKilled)
		{
			return;
		}
		this.HandleDamageOrKillEvent(attacker, victim, req, result, damagePosition);
	}

	// Token: 0x06019B8F RID: 105359 RVA: 0x006B283F File Offset: 0x006B0A3F
	protected void OnKillEvent(Entity attacker, Entity victim, RequirementPayload req, DamageResult result, FVectorDouble damagePosition)
	{
		this.HandleDamageOrKillEvent(attacker, victim, req, result, damagePosition);
	}

	// Token: 0x06019B90 RID: 105360 RVA: 0x006B2850 File Offset: 0x006B0A50
	protected void HandleDamageOrKillEvent(Entity attacker, Entity victim, RequirementPayload req, DamageResult result, FVectorDouble damagePosition)
	{
		if (!this.CheckAuthority())
		{
			return;
		}
		ValueTuple<long?, long?, bool> effectiveMessageIds = this.GetEffectiveMessageIds(req);
		long? item = effectiveMessageIds.Item1;
		long? item2 = effectiveMessageIds.Item2;
		bool item3 = effectiveMessageIds.Item3;
		if (item == null || item2 == null)
		{
			return;
		}
		BaseBuffComponent component = victim.GetComponent<BaseBuffComponent>();
		if (component == null)
		{
			return;
		}
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < this.BuffTransferRecords.Count; i++)
		{
			BuffTransferRecord buffTransferRecord = this.BuffTransferRecords[i];
			if (num == -1 && buffTransferRecord.RecordSkillMessageId == item.Value)
			{
				num = i;
			}
			if (num2 == -1 && buffTransferRecord.TargetSkillMessageId == item.Value)
			{
				num2 = i;
			}
		}
		if (num2 != -1 && num2 == this.BuffTransferRecords.Count - 1)
		{
			this.AddBuff(component, this.BuffTransferRecords[num2]);
			return;
		}
		if (num != -1 || num2 != -1)
		{
			return;
		}
		if (this.KillRecord == null || Time.Instance.FlowTime > this.RecordValidTime)
		{
			if (this.NextExecutionTime > Time.Instance.FlowTime || !result.IsTargetKilled)
			{
				return;
			}
			if (!this.GetBuffStack(component))
			{
				return;
			}
			int[] array = new int[this.BuffStack.Length];
			for (int j = 0; j < this.BuffStack.Length; j++)
			{
				array[j] = this.BuffStack[j];
			}
			this.KillRecord = new BuffTransferRecord
			{
				BulletMessageId = item2.Value,
				RecordSkillMessageId = item.Value,
				BuffStack = array,
				TargetSkillMessageId = 0L,
				TransferEntity = new HashSet<int>(),
				IsAbnormalDamage = item3,
				VictimEntityId = victim.Id
			};
			this.RecordValidTime = Time.Instance.FlowTime + (double)this.RecordDuration;
			return;
		}
		else
		{
			if ((this.KillRecord.RecordSkillMessageId == item.Value && this.KillRecord.BulletMessageId == item2.Value) || item3)
			{
				if (result.IsTargetKilled)
				{
					if (this.UpdateMaxBuffStack(component, this.KillRecord))
					{
						this.RecordValidTime = Time.Instance.FlowTime + (double)this.RecordDuration;
					}
					this.KillRecord.IsAbnormalDamage = (this.KillRecord.IsAbnormalDamage || item3);
				}
				return;
			}
			if (this.KillRecord.VictimEntityId == victim.Id)
			{
				return;
			}
			this.AddBuff(component, this.KillRecord);
			this.NextExecutionTime = Time.Instance.FlowTime + (double)this.EffectInternal;
			this.KillRecord.TargetSkillMessageId = item.Value;
			this.BuffTransferRecords.Add(this.KillRecord);
			if (this.KillRecord.IsAbnormalDamage)
			{
				this.AbnormalMessageId = CombatMessageModel.Instance.GenMessageId();
			}
			this.KillRecord = null;
			if (this.BuffTransferRecords.Count > ExtraEffectBuffTransfer.MaxRecordCount)
			{
				this.BuffTransferRecords.RemoveAt(0);
			}
			return;
		}
	}

	// Token: 0x06019B91 RID: 105361 RVA: 0x006B2B30 File Offset: 0x006B0D30
	public override void OnRemoved(bool bPremature)
	{
		Entity ownerEntity = base.OwnerEntity;
		if (ownerEntity != null && EventSystem.Instance.HasWithTarget(ownerEntity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnDamageEvent)))
		{
			EventSystem.Instance.RemoveWithTarget(ownerEntity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnDamageEvent));
		}
		if (ownerEntity != null && EventSystem.Instance.HasWithTarget(ownerEntity, EEventName.CharKillTarget, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnKillEvent)))
		{
			EventSystem.Instance.RemoveWithTarget(ownerEntity, EEventName.CharKillTarget, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnKillEvent));
		}
	}

	// Token: 0x06019B92 RID: 105362 RVA: 0x006B2BB4 File Offset: 0x006B0DB4
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019B93 RID: 105363 RVA: 0x006B2BB7 File Offset: 0x006B0DB7
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C1CF RID: 49615
	protected static readonly int MaxRecordCount = 5;

	// Token: 0x0400C1D0 RID: 49616
	protected int AbnormalDamageType = -1;

	// Token: 0x0400C1D1 RID: 49617
	protected long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C1D2 RID: 49618
	protected int RecordDuration;

	// Token: 0x0400C1D3 RID: 49619
	protected int EffectInternal;

	// Token: 0x0400C1D4 RID: 49620
	protected List<BuffTransferRecord> BuffTransferRecords = new List<BuffTransferRecord>();

	// Token: 0x0400C1D5 RID: 49621
	[Nullable(2)]
	protected BuffTransferRecord KillRecord;

	// Token: 0x0400C1D6 RID: 49622
	protected double NextExecutionTime = -1.0;

	// Token: 0x0400C1D7 RID: 49623
	protected double RecordValidTime = -1.0;

	// Token: 0x0400C1D8 RID: 49624
	protected int[] BuffStack = Array.Empty<int>();

	// Token: 0x0400C1D9 RID: 49625
	protected long AbnormalMessageId;
}
