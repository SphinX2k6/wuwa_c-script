using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.GameplayABP;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Role.Component
{
	// Token: 0x02007090 RID: 28816
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleLinkedAnimInstComponent : CharacterLinkedAnimInstComponent, IComponentDependency
	{
		// Token: 0x17009C21 RID: 39969
		// (get) Token: 0x0604636C RID: 287596 RVA: 0x0118E7D7 File Offset: 0x0118C9D7
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

		// Token: 0x0604636D RID: 287597 RVA: 0x0118E808 File Offset: 0x0118CA08
		protected unsafe void OnPrevTagChanged(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				return;
			}
			EGameplayABPType gameplayABPType = RoleLinkedAnimInstComponent.PreloadMap[tagId];
			if (this.CurrentActivate != EGameplayABPType.None || this.CurrentPreload == gameplayABPType)
			{
				if (this.CurrentActivate != EGameplayABPType.None && this.CurrentActivate != gameplayABPType)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Role;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "LinkedAnim: OnPrevTagChanged 与当前激活不同";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentActivate", this.CurrentActivate);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("name", gameplayABPType);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
					string item = "Actor";
					CharacterAnimationComponent animComp = this.AnimComp;
					object item2;
					if (animComp == null)
					{
						item2 = null;
					}
					else
					{
						TsBaseCharacter actor = animComp.Actor;
						item2 = ((actor != null) ? actor.GetName() : null);
					}
					ptr = new ValueTuple<string, object>(item, item2);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				return;
			}
			string path = base.GetGameplayABPAssetPath(gameplayABPType);
			if (path == "")
			{
				return;
			}
			this.NextValidPreload = gameplayABPType;
			ResourceSystem.Instance.LoadAsync<UClass>(path, delegate([Nullable(2)] UClass generatedAnimClass, string _)
			{
				if (generatedAnimClass == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Role;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "Invalid LinkedAnim";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("path", path);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
					string item3 = "Actor";
					CharacterAnimationComponent animComp2 = this.AnimComp;
					object item4;
					if (animComp2 == null)
					{
						item4 = null;
					}
					else
					{
						TsBaseCharacter actor2 = animComp2.Actor;
						item4 = ((actor2 != null) ? actor2.GetName() : null);
					}
					ptr2 = new ValueTuple<string, object>(item3, item4);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return;
				}
				if (this.CurrentActivate != EGameplayABPType.None)
				{
					return;
				}
				if (this.NextValidPreload != gameplayABPType)
				{
					return;
				}
				this.LoadedClass = generatedAnimClass;
				this.CurrentPreload = gameplayABPType;
				CharacterAnimationComponent animComp3 = this.AnimComp;
				USkeletalMeshComponent uskeletalMeshComponent;
				if (animComp3 == null)
				{
					uskeletalMeshComponent = null;
				}
				else
				{
					TsBaseCharacter actor3 = animComp3.Actor;
					uskeletalMeshComponent = ((actor3 != null) ? actor3.Mesh : null);
				}
				USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
				if (uskeletalMeshComponent2 != null)
				{
					uskeletalMeshComponent2.LinkAnimGraphByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY, generatedAnimClass);
					EventSystem.Instance.EmitWithTarget<UAnimInstance>(this.Entity, EEventName.OnRoleGameplayAnimInstChanged, uskeletalMeshComponent2.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY));
				}
			}, 100, "js_undefined");
		}

		// Token: 0x0604636E RID: 287598 RVA: 0x0118E95C File Offset: 0x0118CB5C
		protected unsafe void OnActivateTagChanged(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				this.CurrentActivate = EGameplayABPType.None;
				return;
			}
			EGameplayABPType egameplayABPType = RoleLinkedAnimInstComponent.ActivateMap[tagId];
			if (this.CurrentActivate == egameplayABPType)
			{
				return;
			}
			if (this.CurrentPreload == egameplayABPType)
			{
				this.CurrentActivate = egameplayABPType;
				return;
			}
			if (this.CurrentPreload != EGameplayABPType.None)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Role;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "LinkedAnim: OnActivateTagChanged 没有预加载就使用";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentPreload", this.CurrentPreload);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("name", egameplayABPType);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "Actor";
				CharacterAnimationComponent animComp = this.AnimComp;
				object item2;
				if (animComp == null)
				{
					item2 = null;
				}
				else
				{
					TsBaseCharacter actor = animComp.Actor;
					item2 = ((actor != null) ? actor.GetName() : null);
				}
				ptr = new ValueTuple<string, object>(item, item2);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			this.CurrentActivate = egameplayABPType;
			this.CurrentPreload = egameplayABPType;
			string gameplayABPAssetPath = base.GetGameplayABPAssetPath(this.CurrentActivate);
			if (gameplayABPAssetPath == "")
			{
				return;
			}
			UClass uclass = ResourceSystem.Instance.Load<UClass>(gameplayABPAssetPath, "js_undefined");
			this.LoadedClass = uclass;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Role;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "LinkedAnim: OnActivateTagChanged 没有预加载";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("tag", GameplayTagUtils.GetNameByTagId(tagId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Path", gameplayABPAssetPath);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
			string item3 = "Actor";
			CharacterAnimationComponent animComp2 = this.AnimComp;
			object item4;
			if (animComp2 == null)
			{
				item4 = null;
			}
			else
			{
				TsBaseCharacter actor2 = animComp2.Actor;
				item4 = ((actor2 != null) ? actor2.GetName() : null);
			}
			ptr2 = new ValueTuple<string, object>(item3, item4);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			CharacterAnimationComponent animComp3 = this.AnimComp;
			USkeletalMeshComponent uskeletalMeshComponent;
			if (animComp3 == null)
			{
				uskeletalMeshComponent = null;
			}
			else
			{
				TsBaseCharacter actor3 = animComp3.Actor;
				uskeletalMeshComponent = ((actor3 != null) ? actor3.Mesh : null);
			}
			USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
			if (uskeletalMeshComponent2 != null)
			{
				uskeletalMeshComponent2.LinkAnimGraphByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY, uclass);
				EventSystem.Instance.EmitWithTarget<UAnimInstance>(base.Entity, EEventName.OnRoleGameplayAnimInstChanged, uskeletalMeshComponent2.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY));
			}
		}

		// Token: 0x0604636F RID: 287599 RVA: 0x0118EB68 File Offset: 0x0118CD68
		[NullableContext(1)]
		private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
		{
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
			if (uskeletalMeshComponent2 == null)
			{
				return;
			}
			if (this.LoadedClass != null)
			{
				CharacterMorphComponent morphComp = this.MorphComp;
				if (morphComp != null && morphComp.Valid)
				{
					if (this.MorphComp.GetMorphType() == EMorphType.默认形态)
					{
						UAnimInstance linkedAnimGraphInstanceByTag = uskeletalMeshComponent2.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY);
						if (linkedAnimGraphInstanceByTag != null && linkedAnimGraphInstanceByTag.GetClass() == this.LoadedClass)
						{
							return;
						}
						uskeletalMeshComponent2.LinkAnimGraphByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY, this.LoadedClass);
					}
					return;
				}
			}
		}

		// Token: 0x06046370 RID: 287600 RVA: 0x0118EC10 File Offset: 0x0118CE10
		protected override bool OnStart()
		{
			base.OnStart();
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			this.MorphComp = base.Entity.GetComponent<CharacterMorphComponent>();
			if (!RoleLinkedAnimInstComponent.GameplayABPMapInited)
			{
				RoleLinkedAnimInstComponent.GameplayABPMapInited = true;
				RoleLinkedAnimInstComponent.PreloadMap = new Dictionary<int, EGameplayABPType>();
				RoleLinkedAnimInstComponent.ActivateMap = new Dictionary<int, EGameplayABPType>();
				List<SGameplayABPConfig> dataTableAllRow = DataTableUtil.GetDataTableAllRow<SGameplayABPConfig>(EDataTable.GameplayABP);
				if (dataTableAllRow != null)
				{
					foreach (SGameplayABPConfig sgameplayABPConfig in dataTableAllRow)
					{
						if (GameplayTagUtils.IsValidTag(new FGameplayTag?(sgameplayABPConfig.PreloadTag)))
						{
							RoleLinkedAnimInstComponent.PreloadMap[sgameplayABPConfig.PreloadTag.TagId()] = sgameplayABPConfig.Type;
						}
						if (GameplayTagUtils.IsValidTag(new FGameplayTag?(sgameplayABPConfig.ActiveTag)))
						{
							RoleLinkedAnimInstComponent.ActivateMap[sgameplayABPConfig.ActiveTag.TagId()] = sgameplayABPConfig.Type;
						}
					}
				}
			}
			if (this.TagComp != null)
			{
				foreach (KeyValuePair<int, EGameplayABPType> keyValuePair in RoleLinkedAnimInstComponent.PreloadMap)
				{
					this.TagComp.AddTagAddOrRemoveListener(keyValuePair.Key, new BaseTagComponent.TTagSwitchedCallback(this.OnPrevTagChanged), null);
				}
				foreach (KeyValuePair<int, EGameplayABPType> keyValuePair2 in RoleLinkedAnimInstComponent.ActivateMap)
				{
					this.TagComp.AddTagAddOrRemoveListener(keyValuePair2.Key, new BaseTagComponent.TTagSwitchedCallback(this.OnActivateTagChanged), null);
				}
			}
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
			return true;
		}

		// Token: 0x06046371 RID: 287601 RVA: 0x0118EDF8 File Offset: 0x0118CFF8
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
			if (this.TagComp != null)
			{
				foreach (KeyValuePair<int, EGameplayABPType> keyValuePair in RoleLinkedAnimInstComponent.PreloadMap)
				{
					this.TagComp.RemoveTagAddOrRemoveListener(keyValuePair.Key, new BaseTagComponent.TTagSwitchedCallback(this.OnPrevTagChanged));
				}
				foreach (KeyValuePair<int, EGameplayABPType> keyValuePair2 in RoleLinkedAnimInstComponent.ActivateMap)
				{
					this.TagComp.RemoveTagAddOrRemoveListener(keyValuePair2.Key, new BaseTagComponent.TTagSwitchedCallback(this.OnActivateTagChanged));
				}
			}
			return base.OnEnd();
		}

		// Token: 0x06046372 RID: 287602 RVA: 0x0118EEEC File Offset: 0x0118D0EC
		public override bool SyncLinkGameplayAnimBlueprint(EGameplayABPType gameplayType)
		{
			if (base.SyncLinkGameplayAnimBlueprint(gameplayType))
			{
				USkeletalMeshComponent mesh = this.AnimComp.Actor.Mesh;
				EventSystem.Instance.EmitWithTarget<UAnimInstance>(base.Entity, EEventName.OnRoleGameplayAnimInstChanged, mesh.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY));
				return true;
			}
			return false;
		}

		// Token: 0x06046373 RID: 287603 RVA: 0x0118EF3C File Offset: 0x0118D13C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			RoleLinkedAnimInstComponent roleLinkedAnimInstComponent = (RoleLinkedAnimInstComponent)componentTemplate;
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (roleLinkedAnimInstComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MorphComp"))
			{
				if (roleLinkedAnimInstComponent.MorphComp == null)
				{
					this.MorphComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMorphComponent>(this.MorphComp), "MorphComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentPreload"))
			{
				this.CurrentPreload = roleLinkedAnimInstComponent.CurrentPreload;
			}
			if (base.CanResetComponentProperty("NextValidPreload"))
			{
				this.NextValidPreload = roleLinkedAnimInstComponent.NextValidPreload;
			}
			if (base.CanResetComponentProperty("LoadedClass"))
			{
				if (roleLinkedAnimInstComponent.LoadedClass == null)
				{
					this.LoadedClass = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UClass>(this.LoadedClass), "LoadedClass"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024C82 RID: 150658
		public BaseTagComponent TagComp;

		// Token: 0x04024C83 RID: 150659
		public CharacterMorphComponent MorphComp;

		// Token: 0x04024C84 RID: 150660
		[StaticVariableRuleIgnore]
		private static bool GameplayABPMapInited;

		// Token: 0x04024C85 RID: 150661
		[StaticVariableRuleIgnore]
		public static Dictionary<int, EGameplayABPType> PreloadMap;

		// Token: 0x04024C86 RID: 150662
		[StaticVariableRuleIgnore]
		public static Dictionary<int, EGameplayABPType> ActivateMap;

		// Token: 0x04024C87 RID: 150663
		private EGameplayABPType CurrentPreload;

		// Token: 0x04024C88 RID: 150664
		private EGameplayABPType NextValidPreload;

		// Token: 0x04024C89 RID: 150665
		private UClass LoadedClass;
	}
}
