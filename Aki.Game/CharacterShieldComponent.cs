using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

// Token: 0x020025DD RID: 9693
[NullableContext(2)]
[Nullable(0)]
public class CharacterShieldComponent : EntityComponent
{
	// Token: 0x170025DF RID: 9695
	// (get) Token: 0x0601826E RID: 98926 RVA: 0x00740D99 File Offset: 0x0073EF99
	public float ShieldTotal
	{
		get
		{
			return this.ShieldTotalInternal;
		}
	}

	// Token: 0x0601826F RID: 98927 RVA: 0x00740DA1 File Offset: 0x0073EFA1
	protected override bool OnStart()
	{
		this.BuffComponent = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		this.TagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		return true;
	}

	// Token: 0x06018270 RID: 98928 RVA: 0x00740DC8 File Offset: 0x0073EFC8
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

	// Token: 0x06018271 RID: 98929 RVA: 0x00740E70 File Offset: 0x0073F070
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

	// Token: 0x06018272 RID: 98930 RVA: 0x00740F18 File Offset: 0x0073F118
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

	// Token: 0x06018273 RID: 98931 RVA: 0x00740F88 File Offset: 0x0073F188
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

	// Token: 0x06018274 RID: 98932 RVA: 0x00740FCC File Offset: 0x0073F1CC
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

	// Token: 0x06018275 RID: 98933 RVA: 0x00741018 File Offset: 0x0073F218
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

	// Token: 0x06018276 RID: 98934 RVA: 0x00741118 File Offset: 0x0073F318
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

	// Token: 0x06018277 RID: 98935 RVA: 0x0074118C File Offset: 0x0073F38C
	private void OnShieldInvalid()
	{
		this.BuffComponent.TriggerEvents(EBuffTriggerType.ForWhenRemoveShield, this.BuffComponent, new Partial_RequirementPayload());
	}

	// Token: 0x06018278 RID: 98936 RVA: 0x007411A8 File Offset: 0x0073F3A8
	private void TriggerAbilityEvent(float oldShieldValue, float newShieldValue, global::EShieldUpdateType updateType, int shieldId)
	{
		SceneTeamController.Instance.EmitAbilityEvent<Entity, float, float, int, int>(base.Entity, EAbilityEventName.ShieldChange, 0L, base.Entity, oldShieldValue, newShieldValue, (int)updateType, shieldId);
	}

	// Token: 0x06018279 RID: 98937 RVA: 0x007411D3 File Offset: 0x0073F3D3
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

	// Token: 0x0601827A RID: 98938 RVA: 0x007411DC File Offset: 0x0073F3DC
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterShieldComponent characterShieldComponent = (CharacterShieldComponent)componentTemplate;
		if (characterShieldComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		if (characterShieldComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (characterShieldComponent.ShieldMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ShieldMap), "ShieldMap"))
		{
			return false;
		}
		this.ShieldTotalInternal = characterShieldComponent.ShieldTotalInternal;
		return true;
	}

	// Token: 0x170025E0 RID: 9696
	// (get) Token: 0x0601827B RID: 98939 RVA: 0x00741280 File Offset: 0x0073F480
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025E1 RID: 9697
	// (get) Token: 0x0601827C RID: 98940 RVA: 0x00741283 File Offset: 0x0073F483
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CFB7 RID: 53175
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400CFB8 RID: 53176
	private BaseTagComponent TagComponent;

	// Token: 0x0400CFB9 RID: 53177
	[Nullable(1)]
	private readonly Dictionary<int, CharacterShield> ShieldMap = new Dictionary<int, CharacterShield>();

	// Token: 0x0400CFBA RID: 53178
	private float ShieldTotalInternal;
}
