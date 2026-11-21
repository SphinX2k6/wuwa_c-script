using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x020025D6 RID: 9686
[NullableContext(2)]
[Nullable(0)]
public class CharacterPartScanComponent : EntityComponent
{
	// Token: 0x06018226 RID: 98854 RVA: 0x0073F6E4 File Offset: 0x0073D8E4
	protected override bool OnInit()
	{
		this.PartComponent = base.Entity.GetComponent<CharacterPartComponent>();
		this.ActorComponent = base.Entity.GetComponent<CharacterActorComponent>();
		this.RenderingComponent = this.ActorComponent.Actor.CharRenderingComponent;
		return true;
	}

	// Token: 0x06018227 RID: 98855 RVA: 0x0073F720 File Offset: 0x0073D920
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

	// Token: 0x06018228 RID: 98856 RVA: 0x0073F844 File Offset: 0x0073DA44
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterPartScanComponent characterPartScanComponent = (CharacterPartScanComponent)componentTemplate;
		if (characterPartScanComponent.PartComponent == null)
		{
			this.PartComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PartComponent), "PartComponent"))
		{
			return false;
		}
		if (characterPartScanComponent.ActorComponent == null)
		{
			this.ActorComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
		{
			return false;
		}
		if (characterPartScanComponent.RenderingComponent == null)
		{
			this.RenderingComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RenderingComponent), "RenderingComponent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170025C9 RID: 9673
	// (get) Token: 0x06018229 RID: 98857 RVA: 0x0073F8E5 File Offset: 0x0073DAE5
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CF81 RID: 53121
	private CharacterPartComponent PartComponent;

	// Token: 0x0400CF82 RID: 53122
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400CF83 RID: 53123
	private CharRenderingComponent RenderingComponent;
}
