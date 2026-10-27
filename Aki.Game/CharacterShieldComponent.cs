using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

// Token: 0x02003086 RID: 12422
[NullableContext(2)]
[Nullable(0)]
public class CharacterShieldComponent : EntityComponent
{
	// Token: 0x17002488 RID: 9352
	// (get) Token: 0x0601A88B RID: 108683 RVA: 0x0071A905 File Offset: 0x00718B05
	public float ShieldTotal
	{
		get
		{
			return this.ShieldTotalInternal;
		}
	}

	// Token: 0x0601A88C RID: 108684 RVA: 0x0071A90D File Offset: 0x00718B0D
	protected override bool OnStart()
	{
		this.BuffComponent = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		return true;
	}

	// Token: 0x0601A88D RID: 108685 RVA: 0x0071A934 File Offset: 0x00718B34
	protected override void OnActivate()
	{
		this.ShieldMap.Clear();
		this.ShieldTotalInternal = 0f;
		EntityComponentPb valueOrDefault = base.Entity.GetComponent<CreatureDataComponent>().ComponentDataMap.GetValueOrDefault("ShieldComponentPb");
		RepeatedField<ShieldInfoPb> repeatedField;
		if (valueOrDefault == null)
		{
			repeatedField = null;
		}
		else
		{
			ShieldComponentPb shieldComponentPb = valueOrDefault.ShieldComponentPb;
			repeatedField = ((shieldComponentPb != null) ? shieldComponentPb.ShieldInfoPbList : null);
		}
		RepeatedField<ShieldInfoPb> repeatedField2 = repeatedField;
		if (repeatedField2 == null)
		{
			return;
		}
		foreach (ShieldInfoPb shieldInfoPb in repeatedField2)
		{
			this.Add(shieldInfoPb.Handle, shieldInfoPb.ConfigId, (float)shieldInfoPb.ShieldValue, global::EShieldUpdateType.Add);
		}
	}

	// Token: 0x0601A88E RID: 108686 RVA: 0x0071A9DC File Offset: 0x00718BDC
	private void AddShieldTotal(float value)
	{
		if (this.ShieldTotalInternal == 0f && value > 0f)
		{
			this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.持有护盾"]));
		}
		else if (this.ShieldTotalInternal > 0f && this.ShieldTotalInternal + value <= 0f)
		{
			this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.持有护盾"]));
		}
		this.ShieldTotalInternal += value;
		EventSystem.Instance.EmitWithTarget<float>(base.Entity, EEventName.CharShieldChange, this.ShieldTotalInternal);
	}

	// Token: 0x0601A88F RID: 108687 RVA: 0x0071AA84 File Offset: 0x00718C84
	public void Add(int handleId, int templateId, float value, global::EShieldUpdateType updateType = global::EShieldUpdateType.Add)
	{
		if (this.ShieldMap.ContainsKey(handleId))
		{
			this.ChangeValue(handleId, templateId, value, updateType);
		}
		else
		{
			CharacterShield characterShield = new CharacterShield(handleId, templateId, value);
			this.ShieldMap.Add(handleId, characterShield);
			this.AddShieldTotal(characterShield.ShieldValue);
			this.TriggerAbilityEvent(0f, value, updateType, templateId);
		}
		this.BuffComponent.TriggerEvents(EBuffTriggerType.ForWhenAppendShield, this.BuffComponent, new Partial_RequirementPayload());
	}

	// Token: 0x0601A890 RID: 108688 RVA: 0x0071AAF4 File Offset: 0x00718CF4
	public void Remove(int handleId, int templateId, global::EShieldUpdateType updateType = global::EShieldUpdateType.Remove)
	{
		CharacterShield characterShield;
		if (this.ShieldMap.Remove(handleId, out characterShield))
		{
			this.AddShieldTotal(-characterShield.ShieldValue);
			this.OnShieldInvalid();
			this.TriggerAbilityEvent(characterShield.ShieldValue, 0f, updateType, templateId);
		}
	}

	// Token: 0x0601A891 RID: 108689 RVA: 0x0071AB38 File Offset: 0x00718D38
	public void ChangeValue(int handleId, int templateId, float value, global::EShieldUpdateType updateType = global::EShieldUpdateType.Modify)
	{
		CharacterShield characterShield;
		if (this.ShieldMap.TryGetValue(handleId, out characterShield))
		{
			float shieldValue = characterShield.ShieldValue;
			characterShield.ShieldValue = value;
			this.AddShieldTotal(value - shieldValue);
			this.TriggerAbilityEvent(shieldValue, value, updateType, templateId);
			return;
		}
		this.Add(handleId, templateId, value, global::EShieldUpdateType.Add);
	}

	// Token: 0x0601A892 RID: 108690 RVA: 0x0071AB84 File Offset: 0x00718D84
	[CombatListen(ENotifyMessageId.ShieldUpdateNotify, false, false)]
	public static void OnShieldUpdateNotify(Entity entity, [Nullable(1)] ShieldUpdateNotify data, CombatCommon combatCommon = null)
	{
		CharacterShieldComponent characterShieldComponent = (entity != null) ? entity.GetComponent<CharacterShieldComponent>() : null;
		if (characterShieldComponent == null)
		{
			return;
		}
		foreach (ShieldUpdateInfo shieldUpdateInfo in data.Shields)
		{
			Aki.Protocol.EShieldUpdateType updateType = shieldUpdateInfo.UpdateType;
			if (updateType == Aki.Protocol.EShieldUpdateType.Add && shieldUpdateInfo.ShieldValue > 0)
			{
				characterShieldComponent.Add(shieldUpdateInfo.Handle, shieldUpdateInfo.ConfigId, (float)shieldUpdateInfo.ShieldValue, global::EShieldUpdateType.Add);
			}
			else if (updateType == Aki.Protocol.EShieldUpdateType.Del && shieldUpdateInfo.ShieldValue == 0)
			{
				characterShieldComponent.Remove(shieldUpdateInfo.Handle, shieldUpdateInfo.ConfigId, global::EShieldUpdateType.Remove);
			}
			else if (updateType == Aki.Protocol.EShieldUpdateType.Modify && shieldUpdateInfo.ShieldValue > 0)
			{
				characterShieldComponent.ChangeValue(shieldUpdateInfo.Handle, shieldUpdateInfo.ConfigId, (float)shieldUpdateInfo.ShieldValue, global::EShieldUpdateType.Modify);
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.ZFJ;
				string message = "护盾更新错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("shield", shieldUpdateInfo);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0601A893 RID: 108691 RVA: 0x0071AC84 File Offset: 0x00718E84
	public float GetShieldValue(int shieldCid)
	{
		if (shieldCid == 0)
		{
			return this.ShieldTotal;
		}
		float num = 0f;
		foreach (CharacterShield characterShield in this.ShieldMap.Values)
		{
			if (characterShield.TemplateId == shieldCid)
			{
				num += characterShield.ShieldValue;
			}
		}
		return num;
	}

	// Token: 0x0601A894 RID: 108692 RVA: 0x0071ACF8 File Offset: 0x00718EF8
	private void OnShieldInvalid()
	{
		this.BuffComponent.TriggerEvents(EBuffTriggerType.ForWhenRemoveShield, this.BuffComponent, new Partial_RequirementPayload());
	}

	// Token: 0x0601A895 RID: 108693 RVA: 0x0071AD14 File Offset: 0x00718F14
	private void TriggerAbilityEvent(float oldShieldValue, float newShieldValue, global::EShieldUpdateType updateType, int shieldId)
	{
		SceneTeamController.Instance.EmitAbilityEvent<Entity, float, float, int, int>(base.Entity, EAbilityEventName.ShieldChange, 0L, base.Entity, oldShieldValue, newShieldValue, (int)updateType, shieldId);
	}

	// Token: 0x0601A896 RID: 108694 RVA: 0x0071AD3F File Offset: 0x00718F3F
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public IEnumerable<KeyValuePair<int, CharacterShield>> GetDebugShieldInfo()
	{
		return this.ShieldMap;
	}

	// Token: 0x0601A897 RID: 108695 RVA: 0x0071AD48 File Offset: 0x00718F48
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterShieldComponent characterShieldComponent = (CharacterShieldComponent)componentTemplate;
		if (base.CanResetComponentProperty("BuffComponent"))
		{
			if (characterShieldComponent.BuffComponent == null)
			{
				this.BuffComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.BuffComponent), "BuffComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (characterShieldComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ShieldMap") && characterShieldComponent.ShieldMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, CharacterShield>>(this.ShieldMap), "ShieldMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ShieldTotalInternal"))
		{
			this.ShieldTotalInternal = characterShieldComponent.ShieldTotalInternal;
		}
		return true;
	}

	// Token: 0x0400CBD4 RID: 52180
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400CBD5 RID: 52181
	private BaseTagComponent TagComponent;

	// Token: 0x0400CBD6 RID: 52182
	[Nullable(1)]
	private readonly Dictionary<int, CharacterShield> ShieldMap = new Dictionary<int, CharacterShield>();

	// Token: 0x0400CBD7 RID: 52183
	private float ShieldTotalInternal;
}
