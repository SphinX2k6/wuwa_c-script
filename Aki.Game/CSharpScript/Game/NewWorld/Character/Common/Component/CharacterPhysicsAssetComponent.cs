using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070D2 RID: 28882
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterPhysicsAssetComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009CAF RID: 40111
		// (get) Token: 0x06046791 RID: 288657 RVA: 0x011B234F File Offset: 0x011B054F
		public static Type[] Dependencies
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

		// Token: 0x06046792 RID: 288658 RVA: 0x011B237E File Offset: 0x011B057E
		private void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
		{
			other.GetComponent<CharacterPhysicsAssetComponent>().PhysicsStateInstance.ClearAnimState();
		}

		// Token: 0x06046793 RID: 288659 RVA: 0x011B2390 File Offset: 0x011B0590
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.PhysicsStateInstance = new PhysicsState();
			this.PhysicsLoader = new PhysicsAssetLoader();
			return true;
		}

		// Token: 0x06046794 RID: 288660 RVA: 0x011B23AC File Offset: 0x011B05AC
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

		// Token: 0x06046795 RID: 288661 RVA: 0x011B2580 File Offset: 0x011B0780
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

		// Token: 0x06046796 RID: 288662 RVA: 0x011B2614 File Offset: 0x011B0814
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

		// Token: 0x06046797 RID: 288663 RVA: 0x011B2650 File Offset: 0x011B0850
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

		// Token: 0x06046798 RID: 288664 RVA: 0x011B28F0 File Offset: 0x011B0AF0
		public bool GetRagRollQuitState()
		{
			bool quitCache = this.PhysicsStateInstance.QuitCache;
			this.PhysicsStateInstance.QuitCache = false;
			return quitCache;
		}

		// Token: 0x06046799 RID: 288665 RVA: 0x011B290C File Offset: 0x011B0B0C
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

		// Token: 0x0604679A RID: 288666 RVA: 0x011B29D4 File Offset: 0x011B0BD4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterPhysicsAssetComponent characterPhysicsAssetComponent = (CharacterPhysicsAssetComponent)componentTemplate;
			if (base.CanResetComponentProperty("IsStart"))
			{
				this.IsStart = characterPhysicsAssetComponent.IsStart;
			}
			if (base.CanResetComponentProperty("PhysicsStateInstance"))
			{
				if (characterPhysicsAssetComponent.PhysicsStateInstance == null)
				{
					this.PhysicsStateInstance = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PhysicsState>(this.PhysicsStateInstance), "PhysicsStateInstance"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PhysicsLoader"))
			{
				if (characterPhysicsAssetComponent.PhysicsLoader == null)
				{
					this.PhysicsLoader = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PhysicsAssetLoader>(this.PhysicsLoader), "PhysicsLoader"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterPhysicsAssetComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (characterPhysicsAssetComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AnimComp"))
			{
				if (characterPhysicsAssetComponent.AnimComp == null)
				{
					this.AnimComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagListeners") && characterPhysicsAssetComponent.TagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.TagListeners), "TagListeners"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ListenedTagsCount"))
			{
				this.ListenedTagsCount = characterPhysicsAssetComponent.ListenedTagsCount;
			}
			if (base.CanResetComponentProperty("IsDebug"))
			{
				this.IsDebug = characterPhysicsAssetComponent.IsDebug;
			}
			return true;
		}

		// Token: 0x04024F01 RID: 151297
		[StaticVariableRuleIgnore]
		private static readonly FName RagDoll = new FName("RagDoll");

		// Token: 0x04024F02 RID: 151298
		private bool IsStart;

		// Token: 0x04024F03 RID: 151299
		[Nullable(2)]
		private PhysicsState PhysicsStateInstance;

		// Token: 0x04024F04 RID: 151300
		[Nullable(2)]
		private PhysicsAssetLoader PhysicsLoader;

		// Token: 0x04024F05 RID: 151301
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04024F06 RID: 151302
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04024F07 RID: 151303
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04024F08 RID: 151304
		private readonly List<ITagTask> TagListeners = new List<ITagTask>();

		// Token: 0x04024F09 RID: 151305
		[StaticVariableRuleIgnore]
		private static readonly int[] ListenedTags = new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"]
		};

		// Token: 0x04024F0A RID: 151306
		private int ListenedTagsCount;

		// Token: 0x04024F0B RID: 151307
		private bool IsDebug;
	}
}
