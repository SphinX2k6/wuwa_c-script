using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Module.MonsterGroup
{
	// Token: 0x020043A6 RID: 17318
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterGroupEcologyInfo
	{
		// Token: 0x0602BBCC RID: 179148 RVA: 0x00C46444 File Offset: 0x00C44644
		public MonsterGroupEcologyInfo(int groupId)
		{
			this.GroupId = groupId;
		}

		// Token: 0x17005783 RID: 22403
		// (get) Token: 0x0602BBCD RID: 179149 RVA: 0x00C464B5 File Offset: 0x00C446B5
		public int GroupMemberCount
		{
			get
			{
				return this.GroupInfo.Count;
			}
		}

		// Token: 0x17005784 RID: 22404
		// (get) Token: 0x0602BBCE RID: 179150 RVA: 0x00C464C4 File Offset: 0x00C446C4
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

		// Token: 0x0602BBCF RID: 179151 RVA: 0x00C464E8 File Offset: 0x00C446E8
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

		// Token: 0x0602BBD0 RID: 179152 RVA: 0x00C46568 File Offset: 0x00C44768
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

		// Token: 0x0602BBD1 RID: 179153 RVA: 0x00C465CC File Offset: 0x00C447CC
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

		// Token: 0x0602BBD2 RID: 179154 RVA: 0x00C46630 File Offset: 0x00C44830
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

		// Token: 0x0602BBD3 RID: 179155 RVA: 0x00C4667C File Offset: 0x00C4487C
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

		// Token: 0x0602BBD4 RID: 179156 RVA: 0x00C46750 File Offset: 0x00C44950
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

		// Token: 0x0602BBD5 RID: 179157 RVA: 0x00C467B4 File Offset: 0x00C449B4
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

		// Token: 0x0602BBD6 RID: 179158 RVA: 0x00C46828 File Offset: 0x00C44A28
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

		// Token: 0x0602BBD7 RID: 179159 RVA: 0x00C468D4 File Offset: 0x00C44AD4
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

		// Token: 0x0602BBD8 RID: 179160 RVA: 0x00C46938 File Offset: 0x00C44B38
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

		// Token: 0x0602BBD9 RID: 179161 RVA: 0x00C469BC File Offset: 0x00C44BBC
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

		// Token: 0x0602BBDA RID: 179162 RVA: 0x00C46A40 File Offset: 0x00C44C40
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

		// Token: 0x0602BBDB RID: 179163 RVA: 0x00C46AC0 File Offset: 0x00C44CC0
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

		// Token: 0x0602BBDC RID: 179164 RVA: 0x00C46BB4 File Offset: 0x00C44DB4
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

		// Token: 0x0602BBDD RID: 179165 RVA: 0x00C46DD4 File Offset: 0x00C44FD4
		public bool ShouldRemove()
		{
			return this.GroupInfo.Count == 0;
		}

		// Token: 0x0602BBDE RID: 179166 RVA: 0x00C46DE4 File Offset: 0x00C44FE4
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

		// Token: 0x0602BBDF RID: 179167 RVA: 0x00C46E5C File Offset: 0x00C4505C
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

		// Token: 0x0401793E RID: 96574
		private const float TARGET_END_DISTANCE = 30f;

		// Token: 0x0401793F RID: 96575
		private const float TARGET_RETURN_TIMEOUT_FAILED = 3f;

		// Token: 0x04017940 RID: 96576
		private const float SET_ACTOR_ROTATION = 200f;

		// Token: 0x04017941 RID: 96577
		public readonly int GroupId;

		// Token: 0x04017942 RID: 96578
		public Dictionary<int, MonsterEcologyInfo> GroupInfo = new Dictionary<int, MonsterEcologyInfo>();

		// Token: 0x04017943 RID: 96579
		private int CaptainId = -1;

		// Token: 0x04017944 RID: 96580
		private int LeaderPbDataId;

		// Token: 0x04017945 RID: 96581
		private bool InGroupEcologyPerform;

		// Token: 0x04017946 RID: 96582
		private readonly Vector TmpMemberTargetLocation = Vector.Create();

		// Token: 0x04017947 RID: 96583
		private readonly Rotator TmpMemberTargetRotation = Rotator.Create();

		// Token: 0x04017948 RID: 96584
		private readonly Quat TmpCaptainQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
