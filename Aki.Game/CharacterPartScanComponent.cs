using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x0200307F RID: 12415
[NullableContext(2)]
[Nullable(0)]
public class CharacterPartScanComponent : EntityComponent
{
	// Token: 0x0601A84D RID: 108621 RVA: 0x007190CD File Offset: 0x007172CD
	protected override bool OnInit()
	{
		this.PartComponent = base.Entity.GetComponent<CharacterPartComponent>();
		this.ActorComponent = base.Entity.GetComponent<CharacterActorComponent>();
		this.RenderingComponent = this.ActorComponent.Actor.CharRenderingComponent;
		return true;
	}

	// Token: 0x0601A84E RID: 108622 RVA: 0x00719108 File Offset: 0x00717308
	public void ShowScanEffect()
	{
		if (!this.PartComponent.IsMultiPart)
		{
			return;
		}
		foreach (CharacterPart characterPart in this.PartComponent.Parts)
		{
			if (characterPart != null && characterPart.ScanEffect != null && ((characterPart != null) ? characterPart.ScanEffect : null) != "None")
			{
				EffectSystem instance = EffectSystem.Instance;
				UObject gameInstance = GlobalData.GameInstance;
				FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble());
				int id = instance.SpawnEffect(gameInstance, ftransformDouble, characterPart.ScanEffect, "[CharacterPartScanComponent.ShowScanEffect]", new EffectContext(new int?(base.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
				if (EffectSystem.Instance.IsValid(id))
				{
					OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(id);
					if (effectActor.IsValid())
					{
						effectActor.K2_AttachToComponent(this.ActorComponent.Actor.Mesh, characterPart.ScanEffectSocketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
					}
				}
			}
			if (characterPart.ScanMaterialEffect != null && this.RenderingComponent != null && this.RenderingComponent.CheckInit())
			{
				this.RenderingComponent.AddMaterialControllerData(characterPart.ScanMaterialEffect);
			}
		}
	}

	// Token: 0x0601A84F RID: 108623 RVA: 0x0071922C File Offset: 0x0071742C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterPartScanComponent characterPartScanComponent = (CharacterPartScanComponent)componentTemplate;
		if (base.CanResetComponentProperty("PartComponent"))
		{
			if (characterPartScanComponent.PartComponent == null)
			{
				this.PartComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterPartComponent>(this.PartComponent), "PartComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComponent"))
		{
			if (characterPartScanComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("RenderingComponent"))
		{
			if (characterPartScanComponent.RenderingComponent == null)
			{
				this.RenderingComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharRenderingComponent>(this.RenderingComponent), "RenderingComponent"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CB9E RID: 52126
	private CharacterPartComponent PartComponent;

	// Token: 0x0400CB9F RID: 52127
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400CBA0 RID: 52128
	private CharRenderingComponent RenderingComponent;
}
