using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;
using CSharpScript.Game.Common.Event;

// Token: 0x02003191 RID: 12689
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillFuLuoLuo : SpecialSkillBase
{
	// Token: 0x0601B522 RID: 111906 RVA: 0x00775ADC File Offset: 0x00773CDC
	[NullableContext(1)]
	public SpecialSkillFuLuoLuo(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B523 RID: 111907 RVA: 0x00775AFC File Offset: 0x00773CFC
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

	// Token: 0x0601B524 RID: 111908 RVA: 0x00775C74 File Offset: 0x00773E74
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

	// Token: 0x0601B525 RID: 111909 RVA: 0x00775D70 File Offset: 0x00773F70
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

	// Token: 0x0601B526 RID: 111910 RVA: 0x00775DD4 File Offset: 0x00773FD4
	public int GetSpecialEnergyType(int index)
	{
		if (index < 0 || index >= this.SpecialEnergyTypeList.Count)
		{
			return 0;
		}
		return this.SpecialEnergyTypeList[index];
	}

	// Token: 0x0601B527 RID: 111911 RVA: 0x00775DF8 File Offset: 0x00773FF8
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

	// Token: 0x0601B528 RID: 111912 RVA: 0x00775EE6 File Offset: 0x007740E6
	public void RemoveSpecialEnergy()
	{
		if (this.SpecialEnergyTypeList.Count <= 0)
		{
			return;
		}
		this.SpecialEnergyTypeList.RemoveAt(0);
		this.SaveSpecialEnergy();
	}

	// Token: 0x0601B529 RID: 111913 RVA: 0x00775F0C File Offset: 0x0077410C
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

	// Token: 0x0601B52A RID: 111914 RVA: 0x00775F78 File Offset: 0x00774178
	private void OnAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		if (newValue == 0f && this.SpecialEnergyTypeList.Count != 0)
		{
			this.SpecialEnergyTypeList.Clear();
		}
	}

	// Token: 0x0601B52B RID: 111915 RVA: 0x00775F9C File Offset: 0x0077419C
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

	// Token: 0x0601B52C RID: 111916 RVA: 0x007760FC File Offset: 0x007742FC
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

	// Token: 0x0601B52D RID: 111917 RVA: 0x00776151 File Offset: 0x00774351
	private void RefreshStarScarMaterialProperty(EAttributeType attribute, float newValue, float oldValue)
	{
		this.RefreshStarScarMaterial();
	}

	// Token: 0x0601B52E RID: 111918 RVA: 0x0077615C File Offset: 0x0077435C
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

	// Token: 0x0601B52F RID: 111919 RVA: 0x007761B5 File Offset: 0x007743B5
	private void OnCharSkillBegin(int charId, int skillId, bool isAutonomousProxy)
	{
		if (1608301L == (long)skillId)
		{
			this.SetBurstSpecialMove(true);
		}
	}

	// Token: 0x0601B530 RID: 111920 RVA: 0x007761C8 File Offset: 0x007743C8
	private void OnCharSkillEnd(int entityId, int skillId)
	{
		if (1608301L == (long)skillId)
		{
			this.SetBurstSpecialMove(false);
		}
	}

	// Token: 0x0601B531 RID: 111921 RVA: 0x007761DB File Offset: 0x007743DB
	[NullableContext(1)]
	private void OnBeforeChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (newEntity == oldEntity)
		{
			return;
		}
		this.StopUltraSkillBeforeChangeRole(newEntity);
	}

	// Token: 0x0601B532 RID: 111922 RVA: 0x007761E9 File Offset: 0x007743E9
	private void OnBeforeUpdateSceneTeam(EntityHandle newEntity, EntityHandle oldEntity)
	{
		if (newEntity == oldEntity)
		{
			return;
		}
		this.StopUltraSkillBeforeChangeRole(newEntity);
	}

	// Token: 0x0601B533 RID: 111923 RVA: 0x007761F7 File Offset: 0x007743F7
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

	// Token: 0x0400D59A RID: 54682
	private const int SPECIAL_ENERGY_COUNT = 6;

	// Token: 0x0400D59B RID: 54683
	private const long SPECIAL_SKILL_ID = 1608301L;

	// Token: 0x0400D59C RID: 54684
	private const double DISTANCE_XY = 3000.0;

	// Token: 0x0400D59D RID: 54685
	private const double DISTANCE_Z = 1500.0;

	// Token: 0x0400D59E RID: 54686
	private const double DISTANCE_Z_DELTA = 200.0;

	// Token: 0x0400D59F RID: 54687
	private const int RESET_SKILL = 1608942;

	// Token: 0x0400D5A0 RID: 54688
	private Entity EntityRef;

	// Token: 0x0400D5A1 RID: 54689
	private Entity SummonedEntity;

	// Token: 0x0400D5A2 RID: 54690
	private bool InBurstState;

	// Token: 0x0400D5A3 RID: 54691
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400D5A4 RID: 54692
	private RoleTagComponent TagComponent;

	// Token: 0x0400D5A5 RID: 54693
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400D5A6 RID: 54694
	[Nullable(1)]
	private readonly List<int> SpecialEnergyTypeList = new List<int>();

	// Token: 0x0400D5A7 RID: 54695
	[Nullable(1)]
	private readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400D5A8 RID: 54696
	private bool IsAutonomous;
}
