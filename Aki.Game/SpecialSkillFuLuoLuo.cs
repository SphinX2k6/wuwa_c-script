using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;
using CSharpScript.Game.Common.Event;

// Token: 0x020026FE RID: 9982
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillFuLuoLuo : SpecialSkillBase
{
	// Token: 0x06019026 RID: 102438 RVA: 0x0079D454 File Offset: 0x0079B654
	[NullableContext(1)]
	public SpecialSkillFuLuoLuo(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06019027 RID: 102439 RVA: 0x0079D474 File Offset: 0x0079B674
	public override void OnStart()
	{
		this.EntityRef = this.SpecialSkillComponent.Entity;
		this.AttributeComponent = this.EntityRef.GetComponent<BaseAttributeComponent>();
		this.TagComponent = this.EntityRef.GetComponent<RoleTagComponent>();
		this.ActorComponent = this.EntityRef.CheckGetComponent<CharacterActorComponent>();
		RoleEnergyComponent component = this.EntityRef.GetComponent<RoleEnergyComponent>();
		if (component != null)
		{
			component.SetEnableRefreshStarScarByEnergy(false);
		}
		CreatureDataComponent component2 = this.EntityRef.GetComponent<CreatureDataComponent>();
		this.IsAutonomous = (CreatureModel.Instance.GetPlayerId() == component2.GetPlayerId());
		this.InitSpecialEnergy();
		this.RefreshStarScarMaterial();
		if (this.IsAutonomous)
		{
			EventSystem.Instance.AddWithTarget<int, int, bool>(this.EntityRef, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharSkillBegin));
			EventSystem.Instance.AddWithTarget<int, int>(this.EntityRef, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnBeforeChangeRole, new Action<EntityHandle, EntityHandle>(this.OnBeforeChangeRole));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnBeforeUpdateSceneTeam, new Action<EntityHandle, EntityHandle>(this.OnBeforeUpdateSceneTeam));
			if (this.AttributeComponent != null)
			{
				this.AttributeComponent.AddListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttributeChanged), null);
				this.AttributeComponent.AddListener(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty), null);
				return;
			}
		}
		else
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			attributeComponent.AddListener(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty), null);
		}
	}

	// Token: 0x06019028 RID: 102440 RVA: 0x0079D5EC File Offset: 0x0079B7EC
	public override void OnEnd()
	{
		if (this.IsAutonomous)
		{
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnBeforeChangeRole, new Action<EntityHandle, EntityHandle>(this.OnBeforeChangeRole));
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnBeforeUpdateSceneTeam, new Action<EntityHandle, EntityHandle>(this.OnBeforeUpdateSceneTeam));
			if (this.EntityRef != null)
			{
				EventSystem.Instance.RemoveWithTarget<int, int, bool>(this.EntityRef, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharSkillBegin));
				EventSystem.Instance.RemoveWithTarget<int, int>(this.EntityRef, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
				this.EntityRef = null;
			}
			if (this.AttributeComponent != null)
			{
				this.AttributeComponent.RemoveListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
				this.AttributeComponent.RemoveListener(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty));
				return;
			}
		}
		else
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			attributeComponent.RemoveListener(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty));
		}
	}

	// Token: 0x06019029 RID: 102441 RVA: 0x0079D6E8 File Offset: 0x0079B8E8
	private void InitSpecialEnergy()
	{
		this.SpecialEnergyTypeList.Clear();
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		int num = (int)((attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1) : 0f);
		for (int i = 0; i < 6; i++)
		{
			int num2 = (6 - i - 1) * 2;
			int num3 = (num & 3 << num2) >> num2;
			if (num3 > 0)
			{
				this.SpecialEnergyTypeList.Add(num3);
			}
		}
	}

	// Token: 0x0601902A RID: 102442 RVA: 0x0079D74C File Offset: 0x0079B94C
	public int GetSpecialEnergyType(int index)
	{
		if (index < 0 || index >= this.SpecialEnergyTypeList.Count)
		{
			return 0;
		}
		return this.SpecialEnergyTypeList[index];
	}

	// Token: 0x0601902B RID: 102443 RVA: 0x0079D770 File Offset: 0x0079B970
	public void AddSpecialEnergy(int type)
	{
		if (this.SpecialEnergyTypeList.Count < 6)
		{
			this.SpecialEnergyTypeList.Add(type);
			this.SaveSpecialEnergy();
			return;
		}
		RoleTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.乐谱锁定"]))
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < 6; i++)
		{
			if (!flag && this.SpecialEnergyTypeList[i] != 3)
			{
				flag = true;
			}
			if (flag && i != 5)
			{
				this.SpecialEnergyTypeList[i] = this.SpecialEnergyTypeList[i + 1];
			}
		}
		if (flag)
		{
			this.SpecialEnergyTypeList[5] = type;
			if (this.AttributeComponent != null)
			{
				float baseValue = this.AttributeComponent.GetBaseValue(EAttributeType.SpecialEnergy1);
				this.SaveSpecialEnergy();
				if (baseValue == this.AttributeComponent.GetBaseValue(EAttributeType.SpecialEnergy1))
				{
					EventSystem instance = EventSystem.Instance;
					EEventName name = EEventName.FuLuoLuoAddDuplicatedEnergy;
					Entity entityRef = this.EntityRef;
					instance.Emit<int>(name, (entityRef != null) ? entityRef.Id : 0);
				}
			}
		}
	}

	// Token: 0x0601902C RID: 102444 RVA: 0x0079D85E File Offset: 0x0079BA5E
	public void RemoveSpecialEnergy()
	{
		if (this.SpecialEnergyTypeList.Count <= 0)
		{
			return;
		}
		this.SpecialEnergyTypeList.RemoveAt(0);
		this.SaveSpecialEnergy();
	}

	// Token: 0x0601902D RID: 102445 RVA: 0x0079D884 File Offset: 0x0079BA84
	private void SaveSpecialEnergy()
	{
		int num = 0;
		foreach (int num2 in this.SpecialEnergyTypeList)
		{
			num <<= 2;
			num += num2;
		}
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent == null)
		{
			return;
		}
		attributeComponent.SetBaseValue(EAttributeType.SpecialEnergy1, (float)num);
	}

	// Token: 0x0601902E RID: 102446 RVA: 0x0079D8F0 File Offset: 0x0079BAF0
	private void OnAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		if (newValue == 0f && this.SpecialEnergyTypeList.Count != 0)
		{
			this.SpecialEnergyTypeList.Clear();
		}
	}

	// Token: 0x0601902F RID: 102447 RVA: 0x0079D914 File Offset: 0x0079BB14
	public override void OnTick(float delta)
	{
		if (!this.InBurstState || this.SummonedEntity == null || this.EntityRef == null)
		{
			return;
		}
		BaseActorComponent component = this.EntityRef.GetComponent<BaseActorComponent>();
		global::Vector vector = (component != null) ? component.ActorLocationProxy : null;
		BaseActorComponent component2 = this.SummonedEntity.GetComponent<BaseActorComponent>();
		global::Vector vector2 = (component2 != null) ? component2.ActorLocationProxy : null;
		if (vector == null || vector2 == null || component2 == null)
		{
			return;
		}
		if (global::Vector.DistSquaredXY(vector, vector2) > 9000000.0)
		{
			vector2.Subtraction(vector, this.TmpVector);
			this.TmpVector.Normalize(9.99999993922529E-09);
			this.TmpVector.MultiplyEqual(3000.0);
			this.TmpVector.AdditionEqual(vector);
			component2.SetActorLocation(this.TmpVector.ToUeVector(false), "弗洛洛大招移动范围限制", false);
		}
		if (Math.Abs(vector.Z - vector2.Z) > 1500.0)
		{
			this.TmpVector.X = vector.X;
			this.TmpVector.Y = vector.Y;
			this.TmpVector.Z = vector.Z - 200.0;
			component2.SetActorLocation(this.TmpVector.ToUeVector(false), "弗洛洛大招Z超范围", false);
			CharacterSkillComponent component3 = this.SummonedEntity.GetComponent<CharacterSkillComponent>();
			if (component3 == null)
			{
				return;
			}
			component3.BeginSkill(1608942, null);
		}
	}

	// Token: 0x06019030 RID: 102448 RVA: 0x0079DA74 File Offset: 0x0079BC74
	private void SetBurstSpecialMove(bool isOpen)
	{
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(this.EntityRef, ESummonType.ConcomitantCustom, 2);
		WorldEntity worldEntity = (summonedEntity != null) ? summonedEntity.Entity : null;
		if (worldEntity == null)
		{
			this.SummonedEntity = null;
			return;
		}
		this.SummonedEntity = worldEntity;
		CharacterMoveComponent component = worldEntity.GetComponent<CharacterMoveComponent>();
		if (component != null)
		{
			component.SetWalkOffLedgeRecord(!isOpen);
		}
		this.InBurstState = isOpen;
	}

	// Token: 0x06019031 RID: 102449 RVA: 0x0079DAC9 File Offset: 0x0079BCC9
	private void RefreshStarScarMaterialProperty(EAttributeType attribute, float newValue, float oldValue)
	{
		this.RefreshStarScarMaterial();
	}

	// Token: 0x06019032 RID: 102450 RVA: 0x0079DAD4 File Offset: 0x0079BCD4
	public void RefreshStarScarMaterial()
	{
		if (this.AttributeComponent == null)
		{
			return;
		}
		float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2);
		float currentValue2 = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max);
		CharacterActorComponent actorComponent = this.ActorComponent;
		if (actorComponent == null)
		{
			return;
		}
		TsBaseCharacter actor = actorComponent.Actor;
		if (actor == null)
		{
			return;
		}
		CharRenderingComponent charRenderingComponent = actor.CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return;
		}
		charRenderingComponent.SetStarScarEnergy(currentValue / currentValue2);
	}

	// Token: 0x06019033 RID: 102451 RVA: 0x0079DB2D File Offset: 0x0079BD2D
	private void OnCharSkillBegin(int charId, int skillId, bool isAutonomousProxy)
	{
		if (1608301L == (long)skillId)
		{
			this.SetBurstSpecialMove(true);
		}
	}

	// Token: 0x06019034 RID: 102452 RVA: 0x0079DB40 File Offset: 0x0079BD40
	private void OnCharSkillEnd(int entityId, int skillId)
	{
		if (1608301L == (long)skillId)
		{
			this.SetBurstSpecialMove(false);
		}
	}

	// Token: 0x06019035 RID: 102453 RVA: 0x0079DB53 File Offset: 0x0079BD53
	[NullableContext(1)]
	private void OnBeforeChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (newEntity == oldEntity)
		{
			return;
		}
		this.StopUltraSkillBeforeChangeRole(newEntity);
	}

	// Token: 0x06019036 RID: 102454 RVA: 0x0079DB61 File Offset: 0x0079BD61
	private void OnBeforeUpdateSceneTeam(EntityHandle newEntity, EntityHandle oldEntity)
	{
		if (newEntity == oldEntity)
		{
			return;
		}
		this.StopUltraSkillBeforeChangeRole(newEntity);
	}

	// Token: 0x06019037 RID: 102455 RVA: 0x0079DB6F File Offset: 0x0079BD6F
	private void StopUltraSkillBeforeChangeRole(EntityHandle newEntity)
	{
		if (!this.InBurstState)
		{
			return;
		}
		if (((newEntity != null) ? newEntity.Entity : null) == this.EntityRef)
		{
			Entity entityRef = this.EntityRef;
			if (entityRef == null)
			{
				return;
			}
			RoleTeamComponent component = entityRef.GetComponent<RoleTeamComponent>();
			if (component == null)
			{
				return;
			}
			component.DisableRoleWithoutEffect();
		}
	}

	// Token: 0x0400D9FD RID: 55805
	private const int SPECIAL_ENERGY_COUNT = 6;

	// Token: 0x0400D9FE RID: 55806
	private const long SPECIAL_SKILL_ID = 1608301L;

	// Token: 0x0400D9FF RID: 55807
	private const double DISTANCE_XY = 3000.0;

	// Token: 0x0400DA00 RID: 55808
	private const double DISTANCE_Z = 1500.0;

	// Token: 0x0400DA01 RID: 55809
	private const double DISTANCE_Z_DELTA = 200.0;

	// Token: 0x0400DA02 RID: 55810
	private const int RESET_SKILL = 1608942;

	// Token: 0x0400DA03 RID: 55811
	private Entity EntityRef;

	// Token: 0x0400DA04 RID: 55812
	private Entity SummonedEntity;

	// Token: 0x0400DA05 RID: 55813
	private bool InBurstState;

	// Token: 0x0400DA06 RID: 55814
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DA07 RID: 55815
	private RoleTagComponent TagComponent;

	// Token: 0x0400DA08 RID: 55816
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DA09 RID: 55817
	[Nullable(1)]
	private readonly List<int> SpecialEnergyTypeList = new List<int>();

	// Token: 0x0400DA0A RID: 55818
	[Nullable(1)]
	private readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400DA0B RID: 55819
	private bool IsAutonomous;
}
