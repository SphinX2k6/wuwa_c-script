using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x020023F3 RID: 9203
[NullableContext(2)]
[Nullable(0)]
public class CharacterAttributeComponent : BaseAttributeComponent
{
	// Token: 0x170023BF RID: 9151
	// (get) Token: 0x060170C0 RID: 94400 RVA: 0x006BAED0 File Offset: 0x006B90D0
	protected new CharacterBuffComponent BuffComponent
	{
		get
		{
			return this.BuffComponent as CharacterBuffComponent;
		}
	}

	// Token: 0x060170C1 RID: 94401 RVA: 0x006BAEE0 File Offset: 0x006B90E0
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.InitFromPbData();
		base.AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnLifeChanged), null);
		base.AddListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnLifeMaxChanged), null);
		base.AddListeners(CharacterAttributeTypes.energyAttrIds, new Action<EAttributeType, float, float>(this.OnSpecialEnergyChanged), null);
		base.AddGeneralListener(new Action<EAttributeType, float, float>(this.OnAnyCurrentValueChange));
		return true;
	}

	// Token: 0x060170C2 RID: 94402 RVA: 0x006BAF46 File Offset: 0x006B9146
	protected override void OnActivate()
	{
		this.InitFromPbData();
	}

	// Token: 0x060170C3 RID: 94403 RVA: 0x006BAF50 File Offset: 0x006B9150
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

	// Token: 0x060170C4 RID: 94404 RVA: 0x006BB1A8 File Offset: 0x006B93A8
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

	// Token: 0x060170C5 RID: 94405 RVA: 0x006BB24C File Offset: 0x006B944C
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

	// Token: 0x060170C6 RID: 94406 RVA: 0x006BB2BC File Offset: 0x006B94BC
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

	// Token: 0x060170C7 RID: 94407 RVA: 0x006BB36C File Offset: 0x006B956C
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

	// Token: 0x060170C8 RID: 94408 RVA: 0x006BB3F8 File Offset: 0x006B95F8
	protected override bool OnInit()
	{
		base.OnInit();
		this.BuffComponent = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		return true;
	}

	// Token: 0x060170C9 RID: 94409 RVA: 0x006BB414 File Offset: 0x006B9614
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

	// Token: 0x060170CA RID: 94410 RVA: 0x006BB500 File Offset: 0x006B9700
	protected override bool OnEnd()
	{
		base.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnLifeChanged));
		base.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnLifeMaxChanged));
		base.RemoveListeners(CharacterAttributeTypes.energyAttrIds, new Action<EAttributeType, float, float>(this.OnSpecialEnergyChanged));
		base.RemoveGeneralListener(new Action<EAttributeType, float, float>(this.OnAnyCurrentValueChange));
		return true;
	}

	// Token: 0x060170CB RID: 94411 RVA: 0x006BB55F File Offset: 0x006B975F
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x060170CC RID: 94412 RVA: 0x006BB564 File Offset: 0x006B9764
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

	// Token: 0x060170CD RID: 94413 RVA: 0x006BB5D0 File Offset: 0x006B97D0
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

	// Token: 0x060170CE RID: 94414 RVA: 0x006BB5EE File Offset: 0x006B97EE
	protected override void DispatchCurrentValueEventImplement(EAttributeType attrId, float newValue, float oldValue)
	{
		base.DispatchCurrentValueEventImplement(attrId, newValue, oldValue);
		SceneTeamController.Instance.EmitAbilityEvent<EAttributeType, Entity, float, float>(base.Entity, EAbilityEventName.OnAttributeChange, (long)attrId, attrId, base.Entity, newValue, oldValue);
	}

	// Token: 0x060170CF RID: 94415 RVA: 0x006BB615 File Offset: 0x006B9815
	private void OnLifeChanged(EAttributeType attrId, float newValue, float oldValue)
	{
		EventSystem.Instance.Emit<int, float, float>(EEventName.CharOnHealthChanged, base.Entity.Id, newValue, oldValue);
	}

	// Token: 0x060170D0 RID: 94416 RVA: 0x006BB634 File Offset: 0x006B9834
	private void OnLifeMaxChanged(EAttributeType attrId, float newValue, float oldValue)
	{
		EventSystem.Instance.Emit<int, float, float>(EEventName.CharOnHealthMaxChanged, base.Entity.Id, newValue, oldValue);
	}

	// Token: 0x060170D1 RID: 94417 RVA: 0x006BB653 File Offset: 0x006B9853
	private void OnSpecialEnergyChanged(EAttributeType attribute, float newValue, float oldValue)
	{
		EventSystem.Instance.EmitWithTarget<EAttributeType, float, float>(base.Entity, EEventName.CharOnEnergyChanged, attribute, newValue, oldValue);
	}

	// Token: 0x060170D2 RID: 94418 RVA: 0x006BB670 File Offset: 0x006B9870
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterAttributeComponent characterAttributeComponent = (CharacterAttributeComponent)componentTemplate;
		this.InitializeGASAttributes = characterAttributeComponent.InitializeGASAttributes;
		if (characterAttributeComponent.TsAbilitySystemComponent == null)
		{
			this.TsAbilitySystemComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TsAbilitySystemComponent), "TsAbilitySystemComponent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170023C0 RID: 9152
	// (get) Token: 0x060170D3 RID: 94419 RVA: 0x006BB6C7 File Offset: 0x006B98C7
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023C1 RID: 9153
	// (get) Token: 0x060170D4 RID: 94420 RVA: 0x006BB6CA File Offset: 0x006B98CA
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023C2 RID: 9154
	// (get) Token: 0x060170D5 RID: 94421 RVA: 0x006BB6CD File Offset: 0x006B98CD
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023C3 RID: 9155
	// (get) Token: 0x060170D6 RID: 94422 RVA: 0x006BB6D0 File Offset: 0x006B98D0
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023C4 RID: 9156
	// (get) Token: 0x060170D7 RID: 94423 RVA: 0x006BB6D3 File Offset: 0x006B98D3
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023C5 RID: 9157
	// (get) Token: 0x060170D8 RID: 94424 RVA: 0x006BB6D6 File Offset: 0x006B98D6
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023C6 RID: 9158
	// (get) Token: 0x060170D9 RID: 94425 RVA: 0x006BB6D9 File Offset: 0x006B98D9
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C1D0 RID: 49616
	protected bool InitializeGASAttributes = true;

	// Token: 0x0400C1D1 RID: 49617
	private UBaseAbilitySystemComponent TsAbilitySystemComponent;
}
