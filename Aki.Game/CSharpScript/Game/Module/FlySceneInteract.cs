using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module
{
	// Token: 0x020046F2 RID: 18162
	[NullableContext(1)]
	[Nullable(0)]
	public class FlySceneInteract : IStaticVariableResetter
	{
		// Token: 0x0602F7F0 RID: 194544 RVA: 0x00B026AC File Offset: 0x00B008AC
		public void Init()
		{
			EventSystem.Instance.Add(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
			BP_SceneBattleInteract_C bp_SceneBattleInteract_C = ResourceSystem.Instance.Load<BP_SceneBattleInteract_C>("/Game/Aki/Data/Fight/DA_FlySceneInteract.DA_FlySceneInteract", "js_undefined");
			if (bp_SceneBattleInteract_C != null)
			{
				SceneBattleInteractEffect sceneBattleInteractEffect = SceneBattleInteractModel.Instance.CreateSceneBattleInteract(bp_SceneBattleInteract_C, 0f, 0f);
				if (sceneBattleInteractEffect != null)
				{
					this.HandleId = sceneBattleInteractEffect.Id;
					sceneBattleInteractEffect.SetUpdateLocationFunc(new Action<global::Vector, FVectorDouble?>(this.UpdateLocation));
				}
			}
			this.AddEntityEvents();
		}

		// Token: 0x0602F7F1 RID: 194545 RVA: 0x00B0272A File Offset: 0x00B0092A
		public void Destroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
			this.RemoveEntityEvents();
			SceneBattleInteractModel.Instance.DestroySceneBattleInteract(this.HandleId);
			this.HandleId = 0;
		}

		// Token: 0x0602F7F2 RID: 194546 RVA: 0x00B02765 File Offset: 0x00B00965
		private void OnChangeRole(int newEntityId, int oldEntityId)
		{
			this.RemoveEntityEvents();
			this.AddEntityEvents();
		}

		// Token: 0x0602F7F3 RID: 194547 RVA: 0x00B02774 File Offset: 0x00B00974
		private void AddEntityEvents()
		{
			BattleUiModel instance = BattleUiModel.Instance;
			BattleUiRoleData battleUiRoleData = (instance != null) ? instance.GetCurRoleData() : null;
			if (battleUiRoleData == null)
			{
				return;
			}
			this.CurrentEntity = battleUiRoleData.EntityHandle;
			EntityHandle currentEntity = this.CurrentEntity;
			BaseActorComponent actorComp;
			if (currentEntity == null)
			{
				actorComp = null;
			}
			else
			{
				WorldEntity entity = currentEntity.Entity;
				actorComp = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
			}
			this.ActorComp = actorComp;
			EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, this.CurrentEntity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			BaseTagComponent gameplayTagComponent = battleUiRoleData.GameplayTagComponent;
			if (gameplayTagComponent == null)
			{
				return;
			}
			this.ListenForTagAddOrRemove(gameplayTagComponent, GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"], new Action<int, bool>(this.OnFlyTagChanged), true);
		}

		// Token: 0x0602F7F4 RID: 194548 RVA: 0x00B02818 File Offset: 0x00B00A18
		private void RemoveEntityEvents()
		{
			if (this.CurrentEntity == null)
			{
				return;
			}
			EventSystem.Instance.RemoveWithTargetUseKey<ERemoveEntityType, EntityHandle>(this, this.CurrentEntity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
			this.CurrentEntity = null;
			this.ActorComp = null;
		}

		// Token: 0x0602F7F5 RID: 194549 RVA: 0x00B028B0 File Offset: 0x00B00AB0
		private void ListenForTagAddOrRemove(BaseTagComponent tagComponent, int tagId, Action<int, bool> callback, bool checkExistImmediately = false)
		{
			if (checkExistImmediately && tagComponent.HasTag(tagId))
			{
				callback(tagId, true);
			}
			ITagTask tagTask = tagComponent.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), FlySceneInteract.ListenTagStat);
			if (tagTask != null)
			{
				this.TagTaskList.Add(tagTask);
			}
		}

		// Token: 0x0602F7F6 RID: 194550 RVA: 0x00B028FF File Offset: 0x00B00AFF
		private void OnFlyTagChanged(int tagId, bool tagExist)
		{
			this.Refresh(tagExist);
		}

		// Token: 0x0602F7F7 RID: 194551 RVA: 0x00B02908 File Offset: 0x00B00B08
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (this.CurrentEntity != handle)
			{
				return;
			}
			this.RemoveEntityEvents();
		}

		// Token: 0x0602F7F8 RID: 194552 RVA: 0x00B0291C File Offset: 0x00B00B1C
		private void Refresh(bool isFlying)
		{
			if (this.IsFlying == isFlying)
			{
				return;
			}
			this.IsFlying = isFlying;
			if (this.HandleId > 0)
			{
				SceneBattleInteractEffect sceneBattleInteract = SceneBattleInteractModel.Instance.GetSceneBattleInteract(this.HandleId);
				if (sceneBattleInteract != null)
				{
					sceneBattleInteract.SetEnable(isFlying, 0f);
					if (this.ActorComp != null)
					{
						sceneBattleInteract.SetDownVector(this.ActorComp.ActorGravityDirectProxy);
					}
				}
			}
		}

		// Token: 0x0602F7F9 RID: 194553 RVA: 0x00B0297C File Offset: 0x00B00B7C
		private void UpdateLocation(global::Vector @out, FVectorDouble? offset)
		{
			if (this.ActorComp == null)
			{
				return;
			}
			if (offset == null)
			{
				@out.FromUeVector(this.ActorComp.ActorLocationProxy);
				return;
			}
			global::Vector tmpVector = this.TmpVector;
			FVectorDouble value = offset.Value;
			tmpVector.FromUeVector(value);
			this.ActorComp.ActorQuatProxy.RotateVector(this.TmpVector, @out);
			@out.AdditionEqual(this.ActorComp.ActorLocationProxy);
		}

		// Token: 0x0602F7FA RID: 194554 RVA: 0x00B029EB File Offset: 0x00B00BEB
		static FlySceneInteract()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlySceneInteract.CreateStaticDefaultValue), new Action(FlySceneInteract.ResetStaticDefaultValue));
		}

		// Token: 0x0602F7FB RID: 194555 RVA: 0x00B02A0A File Offset: 0x00B00C0A
		public static void CreateStaticDefaultValue()
		{
			FlySceneInteract.ListenTagStat = Stat.Create("[StrengthHandle]ListenTag", "", "");
		}

		// Token: 0x0602F7FC RID: 194556 RVA: 0x00B02A25 File Offset: 0x00B00C25
		public static void ResetStaticDefaultValue()
		{
			FlySceneInteract.ListenTagStat = null;
		}

		// Token: 0x04019A7D RID: 105085
		[Nullable(2)]
		private static Stat ListenTagStat;

		// Token: 0x04019A7E RID: 105086
		private bool IsFlying;

		// Token: 0x04019A7F RID: 105087
		private int HandleId;

		// Token: 0x04019A80 RID: 105088
		private readonly global::Vector TmpVector = global::Vector.Create();

		// Token: 0x04019A81 RID: 105089
		[Nullable(2)]
		private EntityHandle CurrentEntity;

		// Token: 0x04019A82 RID: 105090
		[Nullable(2)]
		private BaseActorComponent ActorComp;

		// Token: 0x04019A83 RID: 105091
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();
	}
}
