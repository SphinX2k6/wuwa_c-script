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
	// Token: 0x02003622 RID: 13858
	[NullableContext(1)]
	[Nullable(0)]
	public class FlySceneInteract : IStaticVariableResetter
	{
		// Token: 0x06023FB6 RID: 147382 RVA: 0x00A3237C File Offset: 0x00A3057C
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

		// Token: 0x06023FB7 RID: 147383 RVA: 0x00A323FA File Offset: 0x00A305FA
		public void Destroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
			this.RemoveEntityEvents();
			SceneBattleInteractModel.Instance.DestroySceneBattleInteract(this.HandleId);
			this.HandleId = 0;
		}

		// Token: 0x06023FB8 RID: 147384 RVA: 0x00A32435 File Offset: 0x00A30635
		private void OnChangeRole(int newEntityId, int oldEntityId)
		{
			this.RemoveEntityEvents();
			this.AddEntityEvents();
		}

		// Token: 0x06023FB9 RID: 147385 RVA: 0x00A32444 File Offset: 0x00A30644
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

		// Token: 0x06023FBA RID: 147386 RVA: 0x00A324E8 File Offset: 0x00A306E8
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

		// Token: 0x06023FBB RID: 147387 RVA: 0x00A32580 File Offset: 0x00A30780
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

		// Token: 0x06023FBC RID: 147388 RVA: 0x00A325CF File Offset: 0x00A307CF
		private void OnFlyTagChanged(int tagId, bool tagExist)
		{
			this.Refresh(tagExist);
		}

		// Token: 0x06023FBD RID: 147389 RVA: 0x00A325D8 File Offset: 0x00A307D8
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (this.CurrentEntity != handle)
			{
				return;
			}
			this.RemoveEntityEvents();
		}

		// Token: 0x06023FBE RID: 147390 RVA: 0x00A325EC File Offset: 0x00A307EC
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

		// Token: 0x06023FBF RID: 147391 RVA: 0x00A3264C File Offset: 0x00A3084C
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

		// Token: 0x06023FC0 RID: 147392 RVA: 0x00A326BB File Offset: 0x00A308BB
		static FlySceneInteract()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlySceneInteract.CreateStaticDefaultValue), new Action(FlySceneInteract.ResetStaticDefaultValue));
		}

		// Token: 0x06023FC1 RID: 147393 RVA: 0x00A326DA File Offset: 0x00A308DA
		public static void CreateStaticDefaultValue()
		{
			FlySceneInteract.ListenTagStat = Stat.Create("[StrengthHandle]ListenTag", "", "");
		}

		// Token: 0x06023FC2 RID: 147394 RVA: 0x00A326F5 File Offset: 0x00A308F5
		public static void ResetStaticDefaultValue()
		{
			FlySceneInteract.ListenTagStat = null;
		}

		// Token: 0x0401412C RID: 82220
		[Nullable(2)]
		private static Stat ListenTagStat;

		// Token: 0x0401412D RID: 82221
		private bool IsFlying;

		// Token: 0x0401412E RID: 82222
		private int HandleId;

		// Token: 0x0401412F RID: 82223
		private readonly global::Vector TmpVector = global::Vector.Create();

		// Token: 0x04014130 RID: 82224
		[Nullable(2)]
		private EntityHandle CurrentEntity;

		// Token: 0x04014131 RID: 82225
		[Nullable(2)]
		private BaseActorComponent ActorComp;

		// Token: 0x04014132 RID: 82226
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();
	}
}
