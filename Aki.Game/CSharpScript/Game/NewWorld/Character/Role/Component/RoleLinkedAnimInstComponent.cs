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
	// Token: 0x020062F5 RID: 25333
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleLinkedAnimInstComponent : CharacterLinkedAnimInstComponent
	{
		// Token: 0x170073FE RID: 29694
		// (get) Token: 0x0603D452 RID: 250962 RVA: 0x011B1AAE File Offset: 0x011AFCAE
		[Nullable(1)]
		public override Type[] Dependencies
		{
			[NullableContext(1)]
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

		// Token: 0x0603D453 RID: 250963 RVA: 0x011B1AE0 File Offset: 0x011AFCE0
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

		// Token: 0x0603D454 RID: 250964 RVA: 0x011B1C34 File Offset: 0x011AFE34
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

		// Token: 0x0603D455 RID: 250965 RVA: 0x011B1E40 File Offset: 0x011B0040
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

		// Token: 0x0603D456 RID: 250966 RVA: 0x011B1EE8 File Offset: 0x011B00E8
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

		// Token: 0x0603D457 RID: 250967 RVA: 0x011B20D0 File Offset: 0x011B02D0
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

		// Token: 0x0603D458 RID: 250968 RVA: 0x011B21C4 File Offset: 0x011B03C4
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

		// Token: 0x0603D459 RID: 250969 RVA: 0x011B2214 File Offset: 0x011B0414
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			RoleLinkedAnimInstComponent roleLinkedAnimInstComponent = (RoleLinkedAnimInstComponent)componentTemplate;
			if (roleLinkedAnimInstComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (roleLinkedAnimInstComponent.MorphComp == null)
			{
				this.MorphComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphComp), "MorphComp"))
			{
				return false;
			}
			this.CurrentPreload = roleLinkedAnimInstComponent.CurrentPreload;
			this.NextValidPreload = roleLinkedAnimInstComponent.NextValidPreload;
			if (roleLinkedAnimInstComponent.LoadedClass == null)
			{
				this.LoadedClass = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LoadedClass), "LoadedClass"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170073FF RID: 29695
		// (get) Token: 0x0603D45A RID: 250970 RVA: 0x011B22CD File Offset: 0x011B04CD
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007400 RID: 29696
		// (get) Token: 0x0603D45B RID: 250971 RVA: 0x011B22D0 File Offset: 0x011B04D0
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040207D4 RID: 133076
		public BaseTagComponent TagComp;

		// Token: 0x040207D5 RID: 133077
		public CharacterMorphComponent MorphComp;

		// Token: 0x040207D6 RID: 133078
		[StaticVariableRuleIgnore]
		private static bool GameplayABPMapInited;

		// Token: 0x040207D7 RID: 133079
		[StaticVariableRuleIgnore]
		public static Dictionary<int, EGameplayABPType> PreloadMap;

		// Token: 0x040207D8 RID: 133080
		[StaticVariableRuleIgnore]
		public static Dictionary<int, EGameplayABPType> ActivateMap;

		// Token: 0x040207D9 RID: 133081
		private EGameplayABPType CurrentPreload;

		// Token: 0x040207DA RID: 133082
		private EGameplayABPType NextValidPreload;

		// Token: 0x040207DB RID: 133083
		private UClass LoadedClass;
	}
}
