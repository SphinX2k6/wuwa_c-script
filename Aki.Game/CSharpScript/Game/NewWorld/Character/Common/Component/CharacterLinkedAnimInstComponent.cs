using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006329 RID: 25385
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterLinkedAnimInstComponent : EntityComponent
	{
		// Token: 0x17007493 RID: 29843
		// (get) Token: 0x0603D75D RID: 251741 RVA: 0x011C7A93 File Offset: 0x011C5C93
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterActorComponent),
					typeof(BaseTagComponent),
					typeof(CharacterAnimationComponent)
				};
			}
		}

		// Token: 0x0603D75E RID: 251742 RVA: 0x011C7AC2 File Offset: 0x011C5CC2
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
			return true;
		}

		// Token: 0x0603D75F RID: 251743 RVA: 0x011C7AE8 File Offset: 0x011C5CE8
		public virtual bool SyncLinkGameplayAnimBlueprint(EGameplayABPType gameplayType)
		{
			if (this.CurrentActivate == gameplayType)
			{
				return false;
			}
			this.CurrentActivate = gameplayType;
			string gameplayABPAssetPath = this.GetGameplayABPAssetPath(gameplayType);
			if (gameplayABPAssetPath == "")
			{
				return false;
			}
			UClass classPtr = ResourceSystem.Instance.Load<UClass>(gameplayABPAssetPath, "js_undefined");
			CharacterAnimationComponent animComp = this.AnimComp;
			USkeletalMeshComponent uskeletalMeshComponent;
			if (animComp == null)
			{
				uskeletalMeshComponent = null;
			}
			else
			{
				TsBaseCharacter actor = animComp.Actor;
				uskeletalMeshComponent = ((actor != null) ? actor.Mesh : null);
			}
			USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
			if (uskeletalMeshComponent2 != null)
			{
				uskeletalMeshComponent2.LinkAnimGraphByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY, classPtr);
			}
			return uskeletalMeshComponent2 != null && uskeletalMeshComponent2.IsValid();
		}

		// Token: 0x0603D760 RID: 251744 RVA: 0x011C7B74 File Offset: 0x011C5D74
		protected string GetGameplayABPAssetPath(EGameplayABPType gameplayABPType)
		{
			if (gameplayABPType == EGameplayABPType.None)
			{
				return "";
			}
			UDataTable dtGameplayAbpConfig = this.ActorComp.Actor.DtGameplayAbpConfig;
			if (dtGameplayAbpConfig == null)
			{
				return "";
			}
			foreach (SGameplayABPAssetConfig sgameplayABPAssetConfig in DataTableUtil.GetDataTableAllRowFromTable<SGameplayABPAssetConfig>(dtGameplayAbpConfig))
			{
				if (sgameplayABPAssetConfig.Type == gameplayABPType)
				{
					TSoftClassPtr<UKuroAnimInstance> animInstance = sgameplayABPAssetConfig.AnimInstance;
					return ((animInstance != null) ? animInstance.ToAssetPathName() : null) ?? "";
				}
			}
			return "";
		}

		// Token: 0x0603D761 RID: 251745 RVA: 0x011C7C1C File Offset: 0x011C5E1C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterLinkedAnimInstComponent characterLinkedAnimInstComponent = (CharacterLinkedAnimInstComponent)componentTemplate;
			if (characterLinkedAnimInstComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterLinkedAnimInstComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
			{
				return false;
			}
			this.CurrentActivate = characterLinkedAnimInstComponent.CurrentActivate;
			return true;
		}

		// Token: 0x17007494 RID: 29844
		// (get) Token: 0x0603D762 RID: 251746 RVA: 0x011C7C9E File Offset: 0x011C5E9E
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020988 RID: 133512
		[Nullable(2)]
		public CharacterActorComponent ActorComp;

		// Token: 0x04020989 RID: 133513
		[Nullable(2)]
		public CharacterAnimationComponent AnimComp;

		// Token: 0x0402098A RID: 133514
		protected EGameplayABPType CurrentActivate;
	}
}
