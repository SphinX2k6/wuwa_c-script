using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Module.MonsterGroup
{
	// Token: 0x020053C3 RID: 21443
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterGroupEcologyInfo
	{
		// Token: 0x06036C86 RID: 224390 RVA: 0x00CF739C File Offset: 0x00CF559C
		public MonsterGroupEcologyInfo(int groupId)
		{
			this.GroupId = groupId;
		}

		// Token: 0x170083B7 RID: 33719
		// (get) Token: 0x06036C87 RID: 224391 RVA: 0x00CF740D File Offset: 0x00CF560D
		public int GroupMemberCount
		{
			get
			{
				return this.GroupInfo.Count;
			}
		}

		// Token: 0x170083B8 RID: 33720
		// (get) Token: 0x06036C88 RID: 224392 RVA: 0x00CF741C File Offset: 0x00CF561C
		[Nullable(2)]
		public MonsterEcologyInfo CaptainInfo
		{
			[NullableContext(2)]
			get
			{
				MonsterEcologyInfo result;
				this.GroupInfo.TryGetValue(this.CaptainId, out result);
				return result;
			}
		}

		// Token: 0x06036C89 RID: 224393 RVA: 0x00CF7440 File Offset: 0x00CF5640
		public bool Init(GroupAiComponent groupComp, IReadOnlyList<int> initialPbDataIds)
		{
			if (groupComp.Option.Type != EGroupAiMode.MonsterEcology)
			{
				return true;
			}
			this.LeaderPbDataId = (groupComp.Option as IGroupAiMonsterEcology).Leader;
			foreach (int pbDataId in initialPbDataIds)
			{
				this.TryAddMember(pbDataId);
			}
			return this.GroupInfo.Count > 0;
		}

		// Token: 0x06036C8A RID: 224394 RVA: 0x00CF74C0 File Offset: 0x00CF56C0
		public bool TryAddMember(int pbDataId)
		{
			CharacterActorComponent characterActorComponent = MonsterGroupEcologyInfo.TryResolveActorComp(pbDataId);
			if (characterActorComponent == null)
			{
				return false;
			}
			int id = characterActorComponent.Entity.Id;
			if (this.GroupInfo.ContainsKey(id))
			{
				return false;
			}
			bool flag = pbDataId == this.LeaderPbDataId;
			MonsterEcologyInfo value = new MonsterEcologyInfo(pbDataId, characterActorComponent, this, flag);
			this.GroupInfo[id] = value;
			if (flag)
			{
				this.CaptainId = id;
			}
			return true;
		}

		// Token: 0x06036C8B RID: 224395 RVA: 0x00CF7524 File Offset: 0x00CF5724
		public bool HasMemberByPbDataId(int pbDataId)
		{
			foreach (KeyValuePair<int, MonsterEcologyInfo> keyValuePair in this.GroupInfo)
			{
				if (keyValuePair.Value.PbDataId == pbDataId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06036C8C RID: 224396 RVA: 0x00CF7588 File Offset: 0x00CF5788
		public bool RemoveMemberByEntityId(int entityId)
		{
			MonsterEcologyInfo monsterEcologyInfo;
			if (!this.GroupInfo.TryGetValue(entityId, out monsterEcologyInfo))
			{
				return false;
			}
			bool flag = monsterEcologyInfo.IsCaptain || this.CaptainId == entityId;
			this.GroupInfo.Remove(entityId);
			if (flag)
			{
				this.CaptainId = -1;
			}
			return true;
		}

		// Token: 0x06036C8D RID: 224397 RVA: 0x00CF75D4 File Offset: 0x00CF57D4
		public void CheckMembersValid()
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, MonsterEcologyInfo> keyValuePair in this.GroupInfo)
			{
				MonsterEcologyInfo value = keyValuePair.Value;
				if (value.ActorComp == null || !value.ActorComp.Valid || value.MoveComp == null || !value.MoveComp.Valid)
				{
					list.Add(value.EntityId);
				}
			}
			foreach (int entityId in list)
			{
				this.RemoveMemberByEntityId(entityId);
			}
		}

		// Token: 0x06036C8E RID: 224398 RVA: 0x00CF76A8 File Offset: 0x00CF58A8
		public bool HasAnyInState(EGroupEcologyState state)
		{
			foreach (KeyValuePair<int, MonsterEcologyInfo> keyValuePair in this.GroupInfo)
			{
				if (keyValuePair.Value.GroupEcologyState == state)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06036C8F RID: 224399 RVA: 0x00CF770C File Offset: 0x00CF590C
		public bool IsAllInState(EGroupEcologyState state)
		{
			if (this.GroupInfo.Count == 0)
			{
				return false;
			}
			foreach (KeyValuePair<int, MonsterEcologyInfo> keyValuePair in this.GroupInfo)
			{
				if (keyValuePair.Value.GroupEcologyState != state)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06036C90 RID: 224400 RVA: 0x00CF7780 File Offset: 0x00CF5980
		public void Tick()
		{
			if (this.InGroupEcologyPerform && !this.IsAllInState(EGroupEcologyState.Ecology))
			{
				this.InGroupEcologyPerform = false;
				foreach (KeyValuePair<int, MonsterEcologyInfo> keyValuePair in this.GroupInfo)
				{
					MonsterEcologyInfo value = keyValuePair.Value;
					if (value.GroupEcologyState == EGroupEcologyState.Ecology)
					{
						value.GroupEcologyState = EGroupEcologyState.Ready;
					}
				}
			}
			if (this.HasAnyInState(EGroupEcologyState.Ready))
			{
				this.MoveAllReadyMembersToTarget();
			}
			if (!this.InGroupEcologyPerform && this.IsAllInState(EGroupEcologyState.Ecology))
			{
				this.InGroupEcologyPerform = true;
				this.OnGroupEcologyPerform();
			}
		}

		// Token: 0x06036C91 RID: 224401 RVA: 0x00CF782C File Offset: 0x00CF5A2C
		protected virtual void OnGroupEcologyPerform()
		{
			foreach (KeyValuePair<int, MonsterEcologyInfo> keyValuePair in this.GroupInfo)
			{
				BaseGroupAiComponent groupAiComp = keyValuePair.Value.GroupAiComp;
				if (groupAiComp != null)
				{
					groupAiComp.RunEcologyAction();
				}
			}
		}

		// Token: 0x06036C92 RID: 224402 RVA: 0x00CF7890 File Offset: 0x00CF5A90
		[return: Nullable(2)]
		protected virtual Vector GetMemberTargetLocation(MonsterEcologyInfo info)
		{
			MonsterEcologyInfo captainInfo = this.CaptainInfo;
			CharacterActorComponent characterActorComponent = (captainInfo != null) ? captainInfo.ActorComp : null;
			if (characterActorComponent == null)
			{
				return null;
			}
			BaseGroupAiComponent groupAiComp = info.GroupAiComp;
			Transform transform = (groupAiComp != null) ? groupAiComp.GetEcologyRelativeTransform() : null;
			if (transform == null)
			{
				return null;
			}
			this.TmpCaptainQuat.FromUeQuat(characterActorComponent.ActorRotationProxy.Quaternion(null));
			this.TmpCaptainQuat.RotateVector(transform.GetLocation(), this.TmpMemberTargetLocation);
			this.TmpMemberTargetLocation.AdditionEqual(characterActorComponent.ActorLocationProxy);
			return this.TmpMemberTargetLocation;
		}

		// Token: 0x06036C93 RID: 224403 RVA: 0x00CF7914 File Offset: 0x00CF5B14
		[return: Nullable(2)]
		protected virtual Rotator GetMemberTargetRotation(MonsterEcologyInfo info)
		{
			BaseGroupAiComponent groupAiComp = info.GroupAiComp;
			Transform transform = (groupAiComp != null) ? groupAiComp.GetEcologyRelativeTransform() : null;
			MonsterEcologyInfo captainInfo = this.CaptainInfo;
			CharacterActorComponent characterActorComponent = (captainInfo != null) ? captainInfo.ActorComp : null;
			if (transform == null || characterActorComponent == null)
			{
				return null;
			}
			this.TmpCaptainQuat.FromUeQuat(characterActorComponent.ActorRotationProxy.Quaternion(null));
			this.TmpCaptainQuat.Multiply(transform.GetRotation(), this.TmpCaptainQuat);
			this.TmpCaptainQuat.Rotator(this.TmpMemberTargetRotation);
			return this.TmpMemberTargetRotation;
		}

		// Token: 0x06036C94 RID: 224404 RVA: 0x00CF7998 File Offset: 0x00CF5B98
		private void MoveAllReadyMembersToTarget()
		{
			foreach (KeyValuePair<int, MonsterEcologyInfo> keyValuePair in this.GroupInfo)
			{
				MonsterEcologyInfo value = keyValuePair.Value;
				if (value.GroupEcologyState == EGroupEcologyState.Ready && (value.MoveComp == null || !value.MoveComp.MoveController.IsMoving()))
				{
					this.MoveMemberToTarget(value);
				}
			}
		}

		// Token: 0x06036C95 RID: 224405 RVA: 0x00CF7A18 File Offset: 0x00CF5C18
		private void MoveMemberToTarget(MonsterEcologyInfo info)
		{
			BaseMoveComponent moveComp = info.MoveComp;
			if (moveComp == null || !moveComp.Active)
			{
				return;
			}
			Vector memberTargetLocation = this.GetMemberTargetLocation(info);
			if (memberTargetLocation == null)
			{
				return;
			}
			info.TargetLocation.DeepCopy(memberTargetLocation);
			float num = Math.Max(30f, info.ActorComp.Radius);
			MoveToPointConfigImpl moveConfig = new MoveToPointConfigImpl
			{
				Position = info.TargetLocation,
				CallbackList = new List<Action<ELevelEventState>>
				{
					delegate(ELevelEventState result)
					{
						this.OnMoveToTargetCallback(result, info);
					}
				},
				Distance = new double?((double)(30f + num)),
				MoveState = new ECharMoveState?(ECharMoveState.Walk),
				ReturnTimeoutFailed = new float?(3f)
			};
			moveComp.MoveController.NavigateMoveToLocation(moveConfig, new bool?(false), true, "MonsterGroupEcologyInfo.MoveMemberToTarget");
		}

		// Token: 0x06036C96 RID: 224406 RVA: 0x00CF7B0C File Offset: 0x00CF5D0C
		private unsafe void OnMoveToTargetCallback(ELevelEventState result, MonsterEcologyInfo info)
		{
			if (info.ActorComp == null || !this.GroupInfo.ContainsKey(info.EntityId))
			{
				return;
			}
			Rotator memberTargetRotation = this.GetMemberTargetRotation(info);
			if (memberTargetRotation != null)
			{
				info.TargetRotator.DeepCopy(memberTargetRotation);
			}
			else
			{
				info.TargetRotator.DeepCopy(info.ActorComp.ActorRotationProxy);
			}
			if (result != ELevelEventState.Success)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[GroupAi.Ecology] MoveMemberToTarget 移动失败，强行设置坐标进入生态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", info.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", info.PbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Result", result);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				CharacterAnimationComponent component = info.ActorComp.Entity.GetComponent<CharacterAnimationComponent>();
				FTransformDouble? ftransformDouble = (component != null) ? new FTransformDouble?(component.GetMeshTransform()) : null;
				CharacterActorComponent actorComp = info.ActorComp;
				if (actorComp != null)
				{
					actorComp.SetActorLocationAndRotation(info.TargetLocation.ToUeVector(false), info.TargetRotator.ToUeRotator(), "MoveToInitLocationCallback", false, null);
				}
				if (ftransformDouble != null && component != null)
				{
					component.SetModelBuffer(ftransformDouble.Value, 200f);
				}
			}
			else
			{
				CharacterAnimationComponent component2 = info.ActorComp.Entity.GetComponent<CharacterAnimationComponent>();
				FTransformDouble? ftransformDouble2 = (component2 != null) ? new FTransformDouble?(component2.GetMeshTransform()) : null;
				CharacterActorComponent actorComp2 = info.ActorComp;
				if (actorComp2 != null)
				{
					actorComp2.SetActorRotation(info.TargetRotator.ToUeRotator(), "MoveToInitLocationCallback", false);
				}
				if (ftransformDouble2 != null && component2 != null)
				{
					component2.SetModelBuffer(ftransformDouble2.Value, 200f);
				}
			}
			if (MoveToLocationController.DebugDraw)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, info.TargetLocation.ToUeVector(false), 30f, 10, new FLinearColor?(ColorUtils.LinearCyan), 5f, 0f);
			}
			info.GroupEcologyState = EGroupEcologyState.Ecology;
		}

		// Token: 0x06036C97 RID: 224407 RVA: 0x00CF7D2C File Offset: 0x00CF5F2C
		public bool ShouldRemove()
		{
			return this.GroupInfo.Count == 0;
		}

		// Token: 0x06036C98 RID: 224408 RVA: 0x00CF7D3C File Offset: 0x00CF5F3C
		public void Clear()
		{
			foreach (KeyValuePair<int, MonsterEcologyInfo> keyValuePair in this.GroupInfo)
			{
				MonsterEcologyInfo value = keyValuePair.Value;
				if (value.GroupEcologyState == EGroupEcologyState.Ecology)
				{
					value.GroupEcologyState = EGroupEcologyState.None;
				}
			}
			this.GroupInfo.Clear();
			this.InGroupEcologyPerform = false;
		}

		// Token: 0x06036C99 RID: 224409 RVA: 0x00CF7DB4 File Offset: 0x00CF5FB4
		[NullableContext(2)]
		private static CharacterActorComponent TryResolveActorComp(int pbDataId)
		{
			List<EntityHandle> list = new List<EntityHandle>();
			CreatureModel.Instance.GetEntitiesWithPbDataId(pbDataId, ref list);
			if (list.Count == 0)
			{
				return null;
			}
			WorldEntity entity = list[0].Entity;
			if (entity == null)
			{
				return null;
			}
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			BaseMoveComponent component2 = entity.GetComponent<BaseMoveComponent>();
			if (component == null || !component.Active || component2 == null || !component2.Active)
			{
				return null;
			}
			return component;
		}

		// Token: 0x0401CEA6 RID: 118438
		private const float TARGET_END_DISTANCE = 30f;

		// Token: 0x0401CEA7 RID: 118439
		private const float TARGET_RETURN_TIMEOUT_FAILED = 3f;

		// Token: 0x0401CEA8 RID: 118440
		private const float SET_ACTOR_ROTATION = 200f;

		// Token: 0x0401CEA9 RID: 118441
		public readonly int GroupId;

		// Token: 0x0401CEAA RID: 118442
		public Dictionary<int, MonsterEcologyInfo> GroupInfo = new Dictionary<int, MonsterEcologyInfo>();

		// Token: 0x0401CEAB RID: 118443
		private int CaptainId = -1;

		// Token: 0x0401CEAC RID: 118444
		private int LeaderPbDataId;

		// Token: 0x0401CEAD RID: 118445
		private bool InGroupEcologyPerform;

		// Token: 0x0401CEAE RID: 118446
		private readonly Vector TmpMemberTargetLocation = Vector.Create();

		// Token: 0x0401CEAF RID: 118447
		private readonly Rotator TmpMemberTargetRotation = Rotator.Create();

		// Token: 0x0401CEB0 RID: 118448
		private readonly Quat TmpCaptainQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
