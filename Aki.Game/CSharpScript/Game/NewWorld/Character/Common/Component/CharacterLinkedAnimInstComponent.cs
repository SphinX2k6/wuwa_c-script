using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070C5 RID: 28869
	public class CharacterLinkedAnimInstComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009C8E RID: 40078
		// (get) Token: 0x06046677 RID: 288375 RVA: 0x011A8430 File Offset: 0x011A6630
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Type[] Dependencies
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
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

		// Token: 0x06046678 RID: 288376 RVA: 0x011A845F File Offset: 0x011A665F
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
			return true;
		}

		// Token: 0x06046679 RID: 288377 RVA: 0x011A8484 File Offset: 0x011A6684
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

		// Token: 0x0604667A RID: 288378 RVA: 0x011A8510 File Offset: 0x011A6710
		[NullableContext(1)]
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

		// Token: 0x0604667B RID: 288379 RVA: 0x011A85B8 File Offset: 0x011A67B8
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterLinkedAnimInstComponent characterLinkedAnimInstComponent = (CharacterLinkedAnimInstComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterLinkedAnimInstComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AnimComp"))
			{
				if (characterLinkedAnimInstComponent.AnimComp == null)
				{
					this.AnimComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentActivate"))
			{
				this.CurrentActivate = characterLinkedAnimInstComponent.CurrentActivate;
			}
			return true;
		}

		// Token: 0x04024E4A RID: 151114
		[Nullable(2)]
		public CharacterActorComponent ActorComp;

		// Token: 0x04024E4B RID: 151115
		[Nullable(2)]
		public CharacterAnimationComponent AnimComp;

		// Token: 0x04024E4C RID: 151116
		protected EGameplayABPType CurrentActivate;
	}
}
