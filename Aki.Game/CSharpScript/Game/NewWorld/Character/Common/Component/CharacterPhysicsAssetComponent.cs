using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006336 RID: 25398
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterPhysicsAssetComponent : EntityComponent
	{
		// Token: 0x170074CA RID: 29898
		// (get) Token: 0x0603D88F RID: 252047 RVA: 0x011D1527 File Offset: 0x011CF727
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

		// Token: 0x0603D890 RID: 252048 RVA: 0x011D1556 File Offset: 0x011CF756
		private void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
		{
			other.GetComponent<CharacterPhysicsAssetComponent>().PhysicsStateInstance.ClearAnimState();
		}

		// Token: 0x0603D891 RID: 252049 RVA: 0x011D1568 File Offset: 0x011CF768
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.PhysicsStateInstance = new PhysicsState();
			this.PhysicsLoader = new PhysicsAssetLoader();
			return true;
		}

		// Token: 0x0603D892 RID: 252050 RVA: 0x011D1584 File Offset: 0x011CF784
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			if (this.ActorComp.CreatureData.GetEntityType() != EEntityType.Player || !this.ActorComp.IsAutonomousProxy)
			{
				this.IsStart = false;
				this.ActorComp = null;
				return true;
			}
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
			string roleBody = this.ActorComp.CreatureData.GetRoleConfig().Value.RoleBody;
			PhysicsAssetConfig? physicsAssetConfigByRoleBody = EntityPhysicsAssetConfig.Instance.GetPhysicsAssetConfigByRoleBody(roleBody);
			foreach (int tagId in CharacterPhysicsAssetComponent.ListenedTags)
			{
				if (this.TagComp.HasTag(tagId))
				{
					this.ListenedTagsCount++;
				}
			}
			this.PhysicsStateInstance.InitBaseState(this.ListenedTagsCount > 0);
			this.IsStart = this.PhysicsLoader.SetDataAndLoadAsset(this.ActorComp, physicsAssetConfigByRoleBody.Value, delegate
			{
				this.SetPhysicsState(this.PhysicsStateInstance.Active, true);
			});
			if (!this.IsStart)
			{
				return true;
			}
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null && tagComp.Valid)
			{
				foreach (int num in CharacterPhysicsAssetComponent.ListenedTags)
				{
					if (this.TagComp.HasTag(num))
					{
						this.ListenedTagsCount++;
					}
					ITagTask tagTask = this.TagComp.ListenForTagAddOrRemove(new int?(num), new BaseTagComponent.TTagSwitchedCallback(this.OnListenedTagChanged), null);
					if (tagTask != null)
					{
						this.TagListeners.Add(tagTask);
					}
				}
			}
			EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
			return true;
		}

		// Token: 0x0603D893 RID: 252051 RVA: 0x011D1758 File Offset: 0x011CF958
		protected override bool OnClear()
		{
			foreach (ITagTask tagTask in this.TagListeners)
			{
				tagTask.EndTask();
			}
			this.TagListeners.Clear();
			this.PhysicsLoader.ClearData();
			if (!this.IsStart)
			{
				return true;
			}
			EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
			return true;
		}

		// Token: 0x0603D894 RID: 252052 RVA: 0x011D17EC File Offset: 0x011CF9EC
		private void OnListenedTagChanged(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				this.ListenedTagsCount++;
			}
			else
			{
				this.ListenedTagsCount--;
			}
			if (this.ListenedTagsCount == 0)
			{
				this.SetPhysicsState(false, false);
				return;
			}
			this.SetPhysicsState(true, false);
		}

		// Token: 0x0603D895 RID: 252053 RVA: 0x011D1828 File Offset: 0x011CFA28
		private void SetPhysicsState(bool active, bool force = false)
		{
			if (this.PhysicsStateInstance.Active == active && !force)
			{
				return;
			}
			if (!this.PhysicsLoader.LoadSuccess)
			{
				return;
			}
			bool flag = true;
			if (active)
			{
				if (!this.ActorComp.SetMeshCollisionEnabled(ECollisionEnabled.PhysicsOnly, "布娃娃效果"))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "角色物理资产模拟设置CollisionEnable失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", base.Entity.Id);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (!this.ActorComp.SetMeshCollisionObjectType(ECollisionChannel.ECC_PhysicsBody, "布娃娃效果"))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Character;
					ELogAuthor author2 = ELogAuthor.LJM;
					string message2 = "角色物理资产模拟设置CollisionObjectType失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Entity", base.Entity.Id);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				this.ActorComp.Actor.Mesh.bEnableShearAnim = false;
				foreach (string key in this.PhysicsLoader.BoneNames)
				{
					USkeletalMeshComponent mesh = this.ActorComp.Actor.Mesh;
					FName fname = FNameUtil.GetDynamicFName(key) ?? FName.NAME_None;
					mesh.SetAllBodiesBelowSimulatePhysics(fname, true, false);
				}
				if (this.IsDebug)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Character;
					ELogAuthor author3 = ELogAuthor.LJM;
					string message3 = "角色开启物理资产模拟";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Entity", base.Entity.Id);
					instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}
			}
			else
			{
				flag = (flag && this.ActorComp.SetMeshCollisionEnabled(ECollisionEnabled.NoCollision, "布娃娃效果"));
				if (!flag || !this.ActorComp.SetMeshCollisionObjectType(ECollisionChannel.ECC_Pawn, "布娃娃效果"))
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Character;
					ELogAuthor author4 = ELogAuthor.LJM;
					string message4 = "角色物理资产模拟重新设置Collision失败";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("Entity", base.Entity.Id);
					instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					return;
				}
				this.ActorComp.Actor.Mesh.SetSimulatePhysics(false);
				this.ActorComp.Actor.Mesh.bEnableShearAnim = true;
				if (this.IsDebug)
				{
					Log instance5 = Log.Instance;
					ELogModule module5 = ELogModule.Character;
					ELogAuthor author5 = ELogAuthor.LJM;
					string message5 = "角色关闭物理资产模拟";
					ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("Entity", base.Entity.Id);
					instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
				}
				this.AnimComp.MainAnimInstance.SavePoseSnapshot(CharacterPhysicsAssetComponent.RagDoll);
			}
			this.PhysicsStateInstance.SetNewState(active);
		}

		// Token: 0x0603D896 RID: 252054 RVA: 0x011D1AC8 File Offset: 0x011CFCC8
		public bool GetRagRollQuitState()
		{
			bool quitCache = this.PhysicsStateInstance.QuitCache;
			this.PhysicsStateInstance.QuitCache = false;
			return quitCache;
		}

		// Token: 0x0603D897 RID: 252055 RVA: 0x011D1AE4 File Offset: 0x011CFCE4
		public void SetDebug(bool debug)
		{
			this.IsDebug = debug;
			if (this.IsDebug)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(248, 3);
				defaultInterpolatedStringHandler.AppendLiteral("\r\n            ------------------------角色物理资产管理组件开启Debug----------------------\r\n            -物理资产: ");
				defaultInterpolatedStringHandler.AppendFormatted<UPhysicsAsset>(this.ActorComp.Actor.Mesh.PhysicsAssetOverride);
				defaultInterpolatedStringHandler.AppendLiteral("\r\n            -驱动骨骼：");
				defaultInterpolatedStringHandler.AppendFormatted(string.Join(", ", this.PhysicsLoader.BoneNames));
				defaultInterpolatedStringHandler.AppendLiteral("\r\n            -脚本组件管理状态 是否激活：");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(this.PhysicsStateInstance.Active);
				defaultInterpolatedStringHandler.AppendLiteral("\r\n            -------------------------------------------------------------------------\r\n            ");
				string message = defaultInterpolatedStringHandler.ToStringAndClear();
				Log.Instance.Info(ELogModule.Character, ELogAuthor.LJM, message, default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0603D898 RID: 252056 RVA: 0x011D1BAC File Offset: 0x011CFDAC
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterPhysicsAssetComponent characterPhysicsAssetComponent = (CharacterPhysicsAssetComponent)componentTemplate;
			this.IsStart = characterPhysicsAssetComponent.IsStart;
			if (characterPhysicsAssetComponent.PhysicsStateInstance == null)
			{
				this.PhysicsStateInstance = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PhysicsStateInstance), "PhysicsStateInstance"))
			{
				return false;
			}
			if (characterPhysicsAssetComponent.PhysicsLoader == null)
			{
				this.PhysicsLoader = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PhysicsLoader), "PhysicsLoader"))
			{
				return false;
			}
			if (characterPhysicsAssetComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterPhysicsAssetComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (characterPhysicsAssetComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
			{
				return false;
			}
			if (characterPhysicsAssetComponent.TagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagListeners), "TagListeners"))
			{
				return false;
			}
			this.ListenedTagsCount = characterPhysicsAssetComponent.ListenedTagsCount;
			this.IsDebug = characterPhysicsAssetComponent.IsDebug;
			return true;
		}

		// Token: 0x170074CB RID: 29899
		// (get) Token: 0x0603D899 RID: 252057 RVA: 0x011D1CE9 File Offset: 0x011CFEE9
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074CC RID: 29900
		// (get) Token: 0x0603D89A RID: 252058 RVA: 0x011D1CEC File Offset: 0x011CFEEC
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020A40 RID: 133696
		[StaticVariableRuleIgnore]
		private static readonly FName RagDoll = new FName("RagDoll");

		// Token: 0x04020A41 RID: 133697
		private bool IsStart;

		// Token: 0x04020A42 RID: 133698
		[Nullable(2)]
		private PhysicsState PhysicsStateInstance;

		// Token: 0x04020A43 RID: 133699
		[Nullable(2)]
		private PhysicsAssetLoader PhysicsLoader;

		// Token: 0x04020A44 RID: 133700
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04020A45 RID: 133701
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04020A46 RID: 133702
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04020A47 RID: 133703
		private readonly List<ITagTask> TagListeners = new List<ITagTask>();

		// Token: 0x04020A48 RID: 133704
		[StaticVariableRuleIgnore]
		private static readonly int[] ListenedTags = new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"]
		};

		// Token: 0x04020A49 RID: 133705
		private int ListenedTagsCount;

		// Token: 0x04020A4A RID: 133706
		private bool IsDebug;
	}
}
