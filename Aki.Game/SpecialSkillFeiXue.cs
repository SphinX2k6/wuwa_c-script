using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02003190 RID: 12688
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillFeiXue : SpecialSkillBase
{
	// Token: 0x0601B518 RID: 111896 RVA: 0x007757FD File Offset: 0x007739FD
	[NullableContext(1)]
	public SpecialSkillFeiXue(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B519 RID: 111897 RVA: 0x00775814 File Offset: 0x00773A14
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

	// Token: 0x0601B51A RID: 111898 RVA: 0x00775954 File Offset: 0x00773B54
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

	// Token: 0x0601B51B RID: 111899 RVA: 0x007759A8 File Offset: 0x00773BA8
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

	// Token: 0x0601B51C RID: 111900 RVA: 0x007759DC File Offset: 0x00773BDC
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

	// Token: 0x0601B51D RID: 111901 RVA: 0x00775A40 File Offset: 0x00773C40
	private void RefreshStarScarMaterialProperty(EAttributeType attribute, float newValue, float oldValue)
	{
		this.RefreshStarScarMaterial();
	}

	// Token: 0x0601B51E RID: 111902 RVA: 0x00775A48 File Offset: 0x00773C48
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

	// Token: 0x0601B51F RID: 111903 RVA: 0x00775A78 File Offset: 0x00773C78
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

	// Token: 0x0601B520 RID: 111904 RVA: 0x00775ABE File Offset: 0x00773CBE
	private void OnMorphTagChange(int tagId, bool tagExist)
	{
		this.HasMorphTag = tagExist;
		this.RefreshStarScarMaterial();
	}

	// Token: 0x0601B521 RID: 111905 RVA: 0x00775ACD File Offset: 0x00773CCD
	private void OnEnableMorphTagChange(int tagId, bool tagExist)
	{
		this.HasEnableMorphTag = tagExist;
		this.RefreshStarScarMaterial();
	}

	// Token: 0x0400D593 RID: 54675
	private Entity Entity;

	// Token: 0x0400D594 RID: 54676
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400D595 RID: 54677
	private RoleTagComponent TagComponent;

	// Token: 0x0400D596 RID: 54678
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400D597 RID: 54679
	[Nullable(1)]
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400D598 RID: 54680
	private bool HasMorphTag;

	// Token: 0x0400D599 RID: 54681
	private bool HasEnableMorphTag;
}
