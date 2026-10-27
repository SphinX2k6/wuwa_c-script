using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002EA0 RID: 11936
[NullableContext(2)]
[Nullable(0)]
public class CharacterAttributeComponent : BaseAttributeComponent
{
	// Token: 0x17002330 RID: 9008
	// (get) Token: 0x060197E7 RID: 104423 RVA: 0x00694AFD File Offset: 0x00692CFD
	protected new CharacterBuffComponent BuffComponent
	{
		get
		{
			return this.BuffComponent as CharacterBuffComponent;
		}
	}

	// Token: 0x060197E8 RID: 104424 RVA: 0x00694B0C File Offset: 0x00692D0C
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.InitFromPbData();
		base.AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnLifeChanged), null);
		base.AddListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnLifeMaxChanged), null);
		base.AddListeners(CharacterAttributeTypes.energyAttrIds, new Action<EAttributeType, float, float>(this.OnSpecialEnergyChanged), null);
		base.AddGeneralListener(new Action<EAttributeType, float, float>(this.OnAnyCurrentValueChange));
		return true;
	}

	// Token: 0x060197E9 RID: 104425 RVA: 0x00694B72 File Offset: 0x00692D72
	protected override void OnActivate()
	{
		this.InitFromPbData();
	}

	// Token: 0x060197EA RID: 104426 RVA: 0x00694B7C File Offset: 0x00692D7C
	private unsafe void InitFromPbData()
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		EntityComponentPb entityComponentPb;
		RepeatedField<WhiteGreenPropData> repeatedField;
		if (creatureDataComponent == null || !creatureDataComponent.ComponentDataMap.TryGetValue("AttributeComponent", out entityComponentPb))
		{
			repeatedField = null;
		}
		else if (entityComponentPb == null)
		{
			repeatedField = null;
		}
		else
		{
			AttributeComponentPb attributeComponent = entityComponentPb.AttributeComponent;
			repeatedField = ((attributeComponent != null) ? attributeComponent.WhiteGreenProps : null);
		}
		RepeatedField<WhiteGreenPropData> repeatedField2 = repeatedField;
		if (repeatedField2 == null)
		{
			return;
		}
		List<EAttributeType> list = new List<EAttributeType>();
		bool flag = base.Init();
		foreach (WhiteGreenPropData whiteGreenPropData in repeatedField2)
		{
			int attributeType = whiteGreenPropData.AttributeType;
			int whiteValue = whiteGreenPropData.WhiteValue;
			int greenValue = whiteGreenPropData.GreenValue;
			int currentValue = whiteGreenPropData.CurrentValue;
			if (attributeType < 0 || attributeType >= 143)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.ZFJ;
				string message = "[属性初始化]服务端下发越界属性Id，已跳过";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AttributeType", attributeType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("WhiteValue", whiteValue);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("GreenValue", greenValue);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Max", 143);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
			else
			{
				if (greenValue == 0)
				{
					list.Add((EAttributeType)attributeType);
				}
				this.BaseValues[attributeType] = (float)whiteValue;
				this.CurrentValues[attributeType] = (float)currentValue;
			}
		}
		if (flag)
		{
			foreach (EAttributeType attrId in list)
			{
				this.UpdateCurrentValue(attrId);
			}
		}
	}

	// Token: 0x060197EB RID: 104427 RVA: 0x00694DD4 File Offset: 0x00692FD4
	public override void SeamlessTravelingRefresh()
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		EntityComponentPb entityComponentPb;
		RepeatedField<WhiteGreenPropData> repeatedField;
		if (creatureDataComponent == null || !creatureDataComponent.ComponentDataMap.TryGetValue("AttributeComponent", out entityComponentPb))
		{
			repeatedField = null;
		}
		else if (entityComponentPb == null)
		{
			repeatedField = null;
		}
		else
		{
			AttributeComponentPb attributeComponent = entityComponentPb.AttributeComponent;
			repeatedField = ((attributeComponent != null) ? attributeComponent.WhiteGreenProps : null);
		}
		RepeatedField<WhiteGreenPropData> repeatedField2 = repeatedField;
		if (repeatedField2 == null)
		{
			return;
		}
		foreach (WhiteGreenPropData whiteGreenPropData in repeatedField2)
		{
			int whiteValue = whiteGreenPropData.WhiteValue;
			base.SyncValueFromServer((EAttributeType)whiteGreenPropData.AttributeType, (float)whiteValue, (float)whiteGreenPropData.CurrentValue);
		}
	}

	// Token: 0x060197EC RID: 104428 RVA: 0x00694E78 File Offset: 0x00693078
	private void OnAnyCurrentValueChange(EAttributeType attrId, float newValue, float oldValue)
	{
		bool flag = false;
		using (Dictionary<EAttributeType, EAttributeType>.ValueCollection.Enumerator enumerator = CharacterAttributeTypes.attributeIdsWithMax.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == attrId)
				{
					flag = true;
					break;
				}
			}
		}
		if (CharacterAttributeTypes.stateAttributeIds.Contains(attrId) || flag)
		{
			this.ApplyModToAttributeToAbilitySystem((int)attrId, EGameplayModOp.Override, newValue);
		}
	}

	// Token: 0x060197ED RID: 104429 RVA: 0x00694EE8 File Offset: 0x006930E8
	[CombatListen(ENotifyMessageId.AttributeChangedNotify, true, false)]
	public static void AttributeChangedNotify(Entity entity, [Nullable(1)] AttributeChangedNotify data, CombatCommon combatCommon = null)
	{
		BaseAttributeComponent baseAttributeComponent = (entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null;
		if (baseAttributeComponent == null)
		{
			return;
		}
		foreach (GameplayAttributeData gameplayAttributeData in data.Attributes)
		{
			if (CharacterAttributeTypes.stateAttributeIds.Contains((EAttributeType)gameplayAttributeData.AttributeType))
			{
				gameplayAttributeData.CurrentValue = gameplayAttributeData.BaseValue;
			}
			if (gameplayAttributeData.AttributeType != 0)
			{
				baseAttributeComponent.SyncValueFromServer((EAttributeType)gameplayAttributeData.AttributeType, (float)gameplayAttributeData.BaseValue, (float)gameplayAttributeData.CurrentValue);
			}
		}
		EventSystem.Instance.Emit<int, AttributeChangedNotify>(EEventName.OnServerAttributeChange, entity.Id, data);
	}

	// Token: 0x060197EE RID: 104430 RVA: 0x00694F98 File Offset: 0x00693198
	[CombatListen(ENotifyMessageId.RecoverPropChangedNotify, true, false)]
	public static void RecoverPropChangedNotify(Entity entity, [Nullable(1)] RecoverPropChangedNotify data, CombatCommon combatCommon = null)
	{
		BaseAttributeComponent baseAttributeComponent = (entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null;
		if (baseAttributeComponent == null)
		{
			return;
		}
		double deltaTime = Time.Instance.ServerCombatStopTime - (double)data.CurTime;
		foreach (RecoverAttr recoverAttr in data.Attributes)
		{
			baseAttributeComponent.SyncRecoverPropFromServer((EAttributeType)recoverAttr.AttrId, (float)recoverAttr.CurrentValue, (float)recoverAttr.MaxValue, (float)recoverAttr.Ratio, deltaTime);
		}
	}

	// Token: 0x060197EF RID: 104431 RVA: 0x00695024 File Offset: 0x00693224
	protected override bool OnInit()
	{
		base.OnInit();
		this.BuffComponent = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		return true;
	}

	// Token: 0x060197F0 RID: 104432 RVA: 0x00695040 File Offset: 0x00693240
	protected override bool OnStart()
	{
		this.InitFromPbData();
		BaseActorComponent baseActorComponent = base.Entity.CheckGetComponent<BaseActorComponent>();
		ABaseCharacter abaseCharacter = ((baseActorComponent != null) ? baseActorComponent.Owner : null) as ABaseCharacter;
		if (abaseCharacter != null)
		{
			this.TsAbilitySystemComponent = abaseCharacter.AbilitySystemComponent;
			this.InitializeGASAttributes = abaseCharacter.bInitializeAttributes;
		}
		foreach (EAttributeType eattributeType in CharacterAttributeTypes.attributeIdsWithMax.Values)
		{
			this.ApplyModToAttributeToAbilitySystem((int)eattributeType, EGameplayModOp.Override, base.GetCurrentValue(eattributeType));
		}
		foreach (EAttributeType eattributeType2 in CharacterAttributeTypes.stateAttributeIds)
		{
			this.ApplyModToAttributeToAbilitySystem((int)eattributeType2, EGameplayModOp.Override, base.GetCurrentValue(eattributeType2));
		}
		return true;
	}

	// Token: 0x060197F1 RID: 104433 RVA: 0x0069512C File Offset: 0x0069332C
	protected override bool OnEnd()
	{
		base.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnLifeChanged));
		base.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnLifeMaxChanged));
		base.RemoveListeners(CharacterAttributeTypes.energyAttrIds, new Action<EAttributeType, float, float>(this.OnSpecialEnergyChanged));
		base.RemoveGeneralListener(new Action<EAttributeType, float, float>(this.OnAnyCurrentValueChange));
		return true;
	}

	// Token: 0x060197F2 RID: 104434 RVA: 0x0069518B File Offset: 0x0069338B
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x060197F3 RID: 104435 RVA: 0x00695190 File Offset: 0x00693390
	public override void ClearSpecialEnergy()
	{
		CharacterBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent != null && buffComponent.HasBuffAuthority())
		{
			foreach (EAttributeType attrId in CharacterAttributeTypes.specialEnergyIds)
			{
				base.SetBaseValue(attrId, 0f);
			}
		}
	}

	// Token: 0x060197F4 RID: 104436 RVA: 0x006951FC File Offset: 0x006933FC
	public void ApplyModToAttributeToAbilitySystem(int attributeId, EGameplayModOp modifierOp, float modifierMagnitude)
	{
		if (!this.InitializeGASAttributes)
		{
			return;
		}
		UBaseAbilitySystemComponent tsAbilitySystemComponent = this.TsAbilitySystemComponent;
		if (tsAbilitySystemComponent == null)
		{
			return;
		}
		tsAbilitySystemComponent.InternalApplyModToAttribute(attributeId, modifierOp, modifierMagnitude);
	}

	// Token: 0x060197F5 RID: 104437 RVA: 0x0069521A File Offset: 0x0069341A
	protected override void DispatchCurrentValueEventImplement(EAttributeType attrId, float newValue, float oldValue)
	{
		base.DispatchCurrentValueEventImplement(attrId, newValue, oldValue);
		SceneTeamController.Instance.EmitAbilityEvent<EAttributeType, Entity, float, float>(base.Entity, EAbilityEventName.OnAttributeChange, (long)attrId, attrId, base.Entity, newValue, oldValue);
	}

	// Token: 0x060197F6 RID: 104438 RVA: 0x00695241 File Offset: 0x00693441
	private void OnLifeChanged(EAttributeType attrId, float newValue, float oldValue)
	{
		EventSystem.Instance.Emit<int, float, float>(EEventName.CharOnHealthChanged, base.Entity.Id, newValue, oldValue);
	}

	// Token: 0x060197F7 RID: 104439 RVA: 0x00695260 File Offset: 0x00693460
	private void OnLifeMaxChanged(EAttributeType attrId, float newValue, float oldValue)
	{
		EventSystem.Instance.Emit<int, float, float>(EEventName.CharOnHealthMaxChanged, base.Entity.Id, newValue, oldValue);
	}

	// Token: 0x060197F8 RID: 104440 RVA: 0x0069527F File Offset: 0x0069347F
	private void OnSpecialEnergyChanged(EAttributeType attribute, float newValue, float oldValue)
	{
		EventSystem.Instance.EmitWithTarget<EAttributeType, float, float>(base.Entity, EEventName.CharOnEnergyChanged, attribute, newValue, oldValue);
	}

	// Token: 0x060197F9 RID: 104441 RVA: 0x0069529C File Offset: 0x0069349C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterAttributeComponent characterAttributeComponent = (CharacterAttributeComponent)componentTemplate;
		if (base.CanResetComponentProperty("InitializeGASAttributes"))
		{
			this.InitializeGASAttributes = characterAttributeComponent.InitializeGASAttributes;
		}
		if (base.CanResetComponentProperty("TsAbilitySystemComponent"))
		{
			if (characterAttributeComponent.TsAbilitySystemComponent == null)
			{
				this.TsAbilitySystemComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UBaseAbilitySystemComponent>(this.TsAbilitySystemComponent), "TsAbilitySystemComponent"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400BE35 RID: 48693
	protected bool InitializeGASAttributes = true;

	// Token: 0x0400BE36 RID: 48694
	private UBaseAbilitySystemComponent TsAbilitySystemComponent;
}
