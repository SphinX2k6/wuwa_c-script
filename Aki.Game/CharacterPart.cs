using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200307D RID: 12413
[NullableContext(2)]
[Nullable(0)]
public class CharacterPart
{
	// Token: 0x0601A834 RID: 108596 RVA: 0x0071800C File Offset: 0x0071620C
	[NullableContext(1)]
	public CharacterPart(Entity baseEntity, int index, SCharacterPart table)
	{
		this.BaseEntity = baseEntity;
		this.ActorComp = baseEntity.GetComponent<CharacterActorComponent>();
		this.TagComponent = baseEntity.GetComponent<BaseTagComponent>();
		this.AttributeComp = baseEntity.GetComponent<BaseAttributeComponent>();
		this.Index = index;
		FGameplayTag fgameplayTag = table.部位标签;
		this.PartTag = GameplayTagUtils.GetGameplayTagByName(fgameplayTag.TagName.ToString());
		fgameplayTag = table.部位激活标签;
		this.ActiveTag = GameplayTagUtils.GetGameplayTagByName(fgameplayTag.TagName.ToString());
		this.IsWeakness = table.是否弱点;
		this.WeaknessAngle = table.弱点受击角度;
		this.PreciseWeaknessAngle = table.精准弱点受击角度判定;
		this.BoneName = FNameUtil.GetDynamicFName(table.部位名);
		this.SeparateDamage = table.是否独立承伤;
		this.InheritLife = (table.继承生命值比例 > 0f);
		this.WeaknessTypeSet = new HashSet<global::EBulletType>();
		this.PartSocketName = new FName?(table.部位状态条骨骼插槽);
		this.IsPartStateVisible = table.是否在目标创建时显示部位状态条;
		this.HitPartStateVisibleDuration = (this.IsPartStateVisible ? table.受击后血条显示时长 : 0f);
		this.IsShield = table.是否盾牌;
		this.IsTransferDamage = table.是否传递伤害;
		this.BlockAngle = table.格挡判定角度;
		this.AttributeBuffList = new long[0];
		this.ScanEffect = table.被扫描播放特效.AssetPathName.ToString();
		this.ScanEffectSocketName = FNameUtil.GetDynamicFName(table.扫描特效绑定骨骼名);
		this.ScanMaterialEffect = table.扫描材质特效;
		this.CombinePartSocketName = new FName?(table.合体骨骼名);
		for (int i = 0; i < table.弱点攻击类型.Num(); i++)
		{
			this.WeaknessTypeSet.Add((global::EBulletType)table.弱点攻击类型.GetElement(i));
		}
		List<long> list = new List<long>();
		for (int j = 0; j < table.属性快照Buff列表.Num(); j++)
		{
			list.Add(table.属性快照Buff列表.Get(j));
		}
		this.AttributeBuffList = list.ToArray();
		if (this.InheritLife)
		{
			this.LifeMax = this.AttributeComp.GetCurrentValue(EAttributeType.LifeMax) * table.继承生命值比例;
		}
		else
		{
			this.LifeMax = -1f;
		}
		this.Life = this.LifeMax;
	}

	// Token: 0x0601A835 RID: 108597 RVA: 0x0071826F File Offset: 0x0071646F
	public void SetActive(bool active)
	{
		this.Active = active;
	}

	// Token: 0x0601A836 RID: 108598 RVA: 0x00718278 File Offset: 0x00716478
	private void HandleSetActive(bool active)
	{
		if (this.Active == active)
		{
			return;
		}
		this.Active = active;
		if (this.Active)
		{
			this.TagComponent.AddTag(new int?((this.ActiveTag != null) ? this.ActiveTag.GetValueOrDefault().TagId() : 0));
			return;
		}
		this.TagComponent.RemoveTag((this.ActiveTag != null) ? new int?(this.ActiveTag.GetValueOrDefault().TagId()) : null);
	}

	// Token: 0x0601A837 RID: 108599 RVA: 0x00718300 File Offset: 0x00716500
	[NullableContext(1)]
	public unsafe void UpdatePartInfo(PartInformation data, bool triggerEvent = true)
	{
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Part;
		Entity baseEntity = this.BaseEntity;
		string message = "UpdatePartInfo";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TagName", (this.PartTag != null) ? new FName?(this.PartTag.GetValueOrDefault().TagName) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Activated", data.Activated);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("LifeValue", data.LifeValue);
		instance.Info(flag, baseEntity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		this.HandleSetActive(data.Activated);
		this.LifeMax = data.LifeMax;
		this.HandleChangeLife(data.LifeValue, triggerEvent);
	}

	// Token: 0x0601A838 RID: 108600 RVA: 0x007183E4 File Offset: 0x007165E4
	[NullableContext(1)]
	public bool OnDamage(float damage, bool hitWeakness, Entity attacker, bool deductLife = true)
	{
		bool result = false;
		TsBaseCharacter actor = this.ActorComp.Actor;
		float num = this.RemainedLifeRate();
		if (deductLife)
		{
			this.Life -= damage;
			float num2 = this.RemainedLifeRate();
			GlobalData.BpEventManager.角色部位血量变化时.Broadcast(actor, this.PartTag.Value, num, num2);
			EventSystem.Instance.EmitWithTarget<float, CharacterPart>(this.BaseEntity, EEventName.CharPartDamage, damage, this);
			if (num > 0f && num2 <= 0f)
			{
				result = true;
			}
		}
		if (hitWeakness)
		{
			TsBaseCharacter actor2 = attacker.GetComponent<CharacterActorComponent>().Actor;
			GlobalData.BpEventManager.角色部位弱点打击时.Broadcast(actor, this.PartTag.Value, actor2);
		}
		return result;
	}

	// Token: 0x0601A839 RID: 108601 RVA: 0x00718494 File Offset: 0x00716694
	public void HandleChangeLife(float value, bool triggerEvent = true)
	{
		float num = this.Life - value;
		if (num == 0f)
		{
			return;
		}
		float num2 = this.RemainedLifeRate();
		this.Life = value;
		if (triggerEvent)
		{
			float num3 = this.RemainedLifeRate();
			if (num2 != num3)
			{
				TsBaseCharacter actor = this.ActorComp.Actor;
				GlobalData.BpEventManager.角色部位血量变化时.Broadcast(actor, this.PartTag.Value, num2, num3);
			}
			EventSystem.Instance.EmitWithTarget<float, CharacterPart>(this.BaseEntity, EEventName.CharPartDamage, num, this);
		}
	}

	// Token: 0x0601A83A RID: 108602 RVA: 0x0071850D File Offset: 0x0071670D
	public float RemainedLife()
	{
		if (!this.InheritLife)
		{
			return -1f;
		}
		if (this.Life < 0f)
		{
			return 0f;
		}
		return this.Life;
	}

	// Token: 0x0601A83B RID: 108603 RVA: 0x00718536 File Offset: 0x00716736
	public float RemainedLifeRate()
	{
		if (!this.InheritLife)
		{
			return -1f;
		}
		return this.RemainedLife() / this.LifeMax;
	}

	// Token: 0x0601A83C RID: 108604 RVA: 0x00718553 File Offset: 0x00716753
	public void ResetLife()
	{
	}

	// Token: 0x0400CB72 RID: 52082
	public Entity BaseEntity;

	// Token: 0x0400CB73 RID: 52083
	public CharacterActorComponent ActorComp;

	// Token: 0x0400CB74 RID: 52084
	public BaseTagComponent TagComponent;

	// Token: 0x0400CB75 RID: 52085
	public BaseAttributeComponent AttributeComp;

	// Token: 0x0400CB76 RID: 52086
	public int Index;

	// Token: 0x0400CB77 RID: 52087
	public FGameplayTag? PartTag;

	// Token: 0x0400CB78 RID: 52088
	public FGameplayTag? ActiveTag;

	// Token: 0x0400CB79 RID: 52089
	public FName? BoneName;

	// Token: 0x0400CB7A RID: 52090
	public bool SeparateDamage;

	// Token: 0x0400CB7B RID: 52091
	public bool IsWeakness;

	// Token: 0x0400CB7C RID: 52092
	public HashSet<global::EBulletType> WeaknessTypeSet;

	// Token: 0x0400CB7D RID: 52093
	public float WeaknessAngle;

	// Token: 0x0400CB7E RID: 52094
	public bool PreciseWeaknessAngle;

	// Token: 0x0400CB7F RID: 52095
	public bool InheritLife;

	// Token: 0x0400CB80 RID: 52096
	public float LifeMax;

	// Token: 0x0400CB81 RID: 52097
	public float Life;

	// Token: 0x0400CB82 RID: 52098
	public bool Active;

	// Token: 0x0400CB83 RID: 52099
	public FName? PartSocketName;

	// Token: 0x0400CB84 RID: 52100
	public bool IsPartStateVisible;

	// Token: 0x0400CB85 RID: 52101
	public float HitPartStateVisibleDuration;

	// Token: 0x0400CB86 RID: 52102
	public bool IsShield;

	// Token: 0x0400CB87 RID: 52103
	public bool IsTransferDamage;

	// Token: 0x0400CB88 RID: 52104
	public float BlockAngle;

	// Token: 0x0400CB89 RID: 52105
	public long[] AttributeBuffList;

	// Token: 0x0400CB8A RID: 52106
	[Nullable(1)]
	public string ScanEffect = "";

	// Token: 0x0400CB8B RID: 52107
	public FName? ScanEffectSocketName;

	// Token: 0x0400CB8C RID: 52108
	public PD_CharacterControllerData_C ScanMaterialEffect;

	// Token: 0x0400CB8D RID: 52109
	public FName? CombinePartSocketName;

	// Token: 0x0400CB8E RID: 52110
	public bool IsWeaknessHit;

	// Token: 0x0400CB8F RID: 52111
	[Nullable(1)]
	public string HitBoneName = "";
}
