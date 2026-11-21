using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020025D4 RID: 9684
[NullableContext(2)]
[Nullable(0)]
public class CharacterPart
{
	// Token: 0x0601820A RID: 98826 RVA: 0x0073E6D0 File Offset: 0x0073C8D0
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

	// Token: 0x0601820B RID: 98827 RVA: 0x0073E933 File Offset: 0x0073CB33
	public void SetActive(bool active)
	{
		this.Active = active;
	}

	// Token: 0x0601820C RID: 98828 RVA: 0x0073E93C File Offset: 0x0073CB3C
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

	// Token: 0x0601820D RID: 98829 RVA: 0x0073E9C4 File Offset: 0x0073CBC4
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

	// Token: 0x0601820E RID: 98830 RVA: 0x0073EAA8 File Offset: 0x0073CCA8
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

	// Token: 0x0601820F RID: 98831 RVA: 0x0073EB58 File Offset: 0x0073CD58
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

	// Token: 0x06018210 RID: 98832 RVA: 0x0073EBD1 File Offset: 0x0073CDD1
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

	// Token: 0x06018211 RID: 98833 RVA: 0x0073EBFA File Offset: 0x0073CDFA
	public float RemainedLifeRate()
	{
		if (!this.InheritLife)
		{
			return -1f;
		}
		return this.RemainedLife() / this.LifeMax;
	}

	// Token: 0x06018212 RID: 98834 RVA: 0x0073EC17 File Offset: 0x0073CE17
	public void ResetLife()
	{
	}

	// Token: 0x0400CF55 RID: 53077
	public Entity BaseEntity;

	// Token: 0x0400CF56 RID: 53078
	public CharacterActorComponent ActorComp;

	// Token: 0x0400CF57 RID: 53079
	public BaseTagComponent TagComponent;

	// Token: 0x0400CF58 RID: 53080
	public BaseAttributeComponent AttributeComp;

	// Token: 0x0400CF59 RID: 53081
	public int Index;

	// Token: 0x0400CF5A RID: 53082
	public FGameplayTag? PartTag;

	// Token: 0x0400CF5B RID: 53083
	public FGameplayTag? ActiveTag;

	// Token: 0x0400CF5C RID: 53084
	public FName? BoneName;

	// Token: 0x0400CF5D RID: 53085
	public bool SeparateDamage;

	// Token: 0x0400CF5E RID: 53086
	public bool IsWeakness;

	// Token: 0x0400CF5F RID: 53087
	public HashSet<global::EBulletType> WeaknessTypeSet;

	// Token: 0x0400CF60 RID: 53088
	public float WeaknessAngle;

	// Token: 0x0400CF61 RID: 53089
	public bool PreciseWeaknessAngle;

	// Token: 0x0400CF62 RID: 53090
	public bool InheritLife;

	// Token: 0x0400CF63 RID: 53091
	public float LifeMax;

	// Token: 0x0400CF64 RID: 53092
	public float Life;

	// Token: 0x0400CF65 RID: 53093
	public bool Active;

	// Token: 0x0400CF66 RID: 53094
	public FName? PartSocketName;

	// Token: 0x0400CF67 RID: 53095
	public bool IsPartStateVisible;

	// Token: 0x0400CF68 RID: 53096
	public float HitPartStateVisibleDuration;

	// Token: 0x0400CF69 RID: 53097
	public bool IsShield;

	// Token: 0x0400CF6A RID: 53098
	public bool IsTransferDamage;

	// Token: 0x0400CF6B RID: 53099
	public float BlockAngle;

	// Token: 0x0400CF6C RID: 53100
	public long[] AttributeBuffList;

	// Token: 0x0400CF6D RID: 53101
	[Nullable(1)]
	public string ScanEffect = "";

	// Token: 0x0400CF6E RID: 53102
	public FName? ScanEffectSocketName;

	// Token: 0x0400CF6F RID: 53103
	public PD_CharacterControllerData_C ScanMaterialEffect;

	// Token: 0x0400CF70 RID: 53104
	public FName? CombinePartSocketName;

	// Token: 0x0400CF71 RID: 53105
	public bool IsWeaknessHit;

	// Token: 0x0400CF72 RID: 53106
	[Nullable(1)]
	public string HitBoneName = "";
}
