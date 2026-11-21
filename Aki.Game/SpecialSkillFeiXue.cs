using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020026FD RID: 9981
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillFeiXue : SpecialSkillBase
{
	// Token: 0x0601901C RID: 102428 RVA: 0x0079D175 File Offset: 0x0079B375
	[NullableContext(1)]
	public SpecialSkillFeiXue(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601901D RID: 102429 RVA: 0x0079D18C File Offset: 0x0079B38C
	public override void OnStart()
	{
		this.Entity = this.SpecialSkillComponent.Entity;
		this.AttributeComponent = this.Entity.GetComponent<BaseAttributeComponent>();
		this.TagComponent = this.Entity.GetComponent<RoleTagComponent>();
		this.ActorComponent = this.Entity.CheckGetComponent<CharacterActorComponent>();
		RoleEnergyComponent component = this.Entity.GetComponent<RoleEnergyComponent>();
		if (component != null)
		{
			component.SetEnableRefreshStarScarByEnergy(false);
		}
		RoleTagComponent tagComponent = this.TagComponent;
		this.HasMorphTag = (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.状态标识.神刀解放"]));
		RoleTagComponent tagComponent2 = this.TagComponent;
		this.HasEnableMorphTag = (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.状态标识.拔刀解禁"]));
		this.RefreshStarScarMaterial();
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.AddListener(EAttributeType.Energy, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty), null);
		}
		BaseAttributeComponent attributeComponent2 = this.AttributeComponent;
		if (attributeComponent2 != null)
		{
			attributeComponent2.AddListener(EAttributeType.EnergyMax, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty), null);
		}
		this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.状态标识.神刀解放"], new BaseTagComponent.TTagSwitchedCallback(this.OnMorphTagChange));
		this.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.状态标识.拔刀解禁"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnableMorphTagChange));
	}

	// Token: 0x0601901E RID: 102430 RVA: 0x0079D2CC File Offset: 0x0079B4CC
	public override void OnEnd()
	{
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.RemoveListener(EAttributeType.Energy, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty));
		}
		BaseAttributeComponent attributeComponent2 = this.AttributeComponent;
		if (attributeComponent2 != null)
		{
			attributeComponent2.RemoveListener(EAttributeType.EnergyMax, new Action<EAttributeType, float, float>(this.RefreshStarScarMaterialProperty));
		}
		this.ClearAllTagTask();
	}

	// Token: 0x0601901F RID: 102431 RVA: 0x0079D320 File Offset: 0x0079B520
	[NullableContext(1)]
	protected void ListenForTagAddOrRemove(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
	{
		RoleTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		ITagTask item = tagComponent.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null);
		this.TagTaskList.Add(item);
	}

	// Token: 0x06019020 RID: 102432 RVA: 0x0079D354 File Offset: 0x0079B554
	protected void ClearAllTagTask()
	{
		if (this.TagTaskList != null)
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}
	}

	// Token: 0x06019021 RID: 102433 RVA: 0x0079D3B8 File Offset: 0x0079B5B8
	private void RefreshStarScarMaterialProperty(EAttributeType attribute, float newValue, float oldValue)
	{
		this.RefreshStarScarMaterial();
	}

	// Token: 0x06019022 RID: 102434 RVA: 0x0079D3C0 File Offset: 0x0079B5C0
	public void RefreshStarScarMaterial()
	{
		if (this.AttributeComponent == null)
		{
			return;
		}
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
		actor.CharRenderingComponent.SetStarScarEnergy(this.GetEnergyPercent());
	}

	// Token: 0x06019023 RID: 102435 RVA: 0x0079D3F0 File Offset: 0x0079B5F0
	private float GetEnergyPercent()
	{
		if (this.HasMorphTag)
		{
			float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.Energy);
			float currentValue2 = this.AttributeComponent.GetCurrentValue(EAttributeType.EnergyMax);
			return currentValue / currentValue2;
		}
		if (this.HasEnableMorphTag)
		{
			return 1f;
		}
		return 0f;
	}

	// Token: 0x06019024 RID: 102436 RVA: 0x0079D436 File Offset: 0x0079B636
	private void OnMorphTagChange(int tagId, bool tagExist)
	{
		this.HasMorphTag = tagExist;
		this.RefreshStarScarMaterial();
	}

	// Token: 0x06019025 RID: 102437 RVA: 0x0079D445 File Offset: 0x0079B645
	private void OnEnableMorphTagChange(int tagId, bool tagExist)
	{
		this.HasEnableMorphTag = tagExist;
		this.RefreshStarScarMaterial();
	}

	// Token: 0x0400D9F6 RID: 55798
	private Entity Entity;

	// Token: 0x0400D9F7 RID: 55799
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400D9F8 RID: 55800
	private RoleTagComponent TagComponent;

	// Token: 0x0400D9F9 RID: 55801
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400D9FA RID: 55802
	[Nullable(1)]
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400D9FB RID: 55803
	private bool HasMorphTag;

	// Token: 0x0400D9FC RID: 55804
	private bool HasEnableMorphTag;
}
