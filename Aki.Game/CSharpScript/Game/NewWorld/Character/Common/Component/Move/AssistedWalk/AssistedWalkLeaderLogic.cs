using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk
{
	// Token: 0x020063BC RID: 25532
	[NullableContext(1)]
	[Nullable(0)]
	public class AssistedWalkLeaderLogic : AttachMoveLogic
	{
		// Token: 0x1700759B RID: 30107
		// (get) Token: 0x0603DE58 RID: 253528 RVA: 0x011F730B File Offset: 0x011F550B
		// (set) Token: 0x0603DE59 RID: 253529 RVA: 0x011F7318 File Offset: 0x011F5518
		[Nullable(2)]
		protected new AssistedWalkParams Params
		{
			[NullableContext(2)]
			get
			{
				return this.Params as AssistedWalkParams;
			}
			[NullableContext(2)]
			set
			{
				this.Params = value;
			}
		}

		// Token: 0x0603DE5A RID: 253530 RVA: 0x011F7324 File Offset: 0x011F5524
		public override void StopMove()
		{
			Action exitCallback = this.ExitCallback;
			this.ExitCallback = null;
			if (!this.InState)
			{
				this.ClearLeaderAssistedWalkTag();
				this.ClearLeaderComponents();
				if (exitCallback != null)
				{
					exitCallback();
				}
				return;
			}
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ClearInput(false, true);
			}
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				TsBaseCharacter actor = actorComp2.Actor;
				if (actor != null)
				{
					actor.SetAnimRootMotionTranslationScale(1f);
				}
			}
			if (this.ArePartnerComponentsAlive())
			{
				this.ResetLeaderState();
				this.WriteAnimLogicParams(false, true);
			}
			this.AnimInstance = null;
			AssistedWalkUtils.Instance.RestoreSightLockMode(this.ActorComp, this.LastSightLockMode);
			this.ClearLeaderAssistedWalkTag();
			BaseTagComponent tagComp = this.TagComp;
			AssistedWalkParams @params = this.Params;
			base.RemoveTags(tagComp, (@params != null) ? @params.LeaderGameplayTagList : null);
			this.DetachFollowerFromLeader();
			this.RestoreLeaderCapsule();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[AttachMove][AssistedWalk][Leader] StopMove";
			string item = "PbDataId";
			CharacterActorComponent actorComp3 = this.ActorComp;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp3 != null) ? new int?(actorComp3.CreatureData.GetPbDataId()) : null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.StopMove();
			this.ClearLeaderComponents();
			if (exitCallback != null)
			{
				exitCallback();
			}
		}

		// Token: 0x0603DE5B RID: 253531 RVA: 0x011F7458 File Offset: 0x011F5658
		public void StartLeaderAssistedWalkWithData(Entity entity, BP_AssistedWalkConfig_C data, [Nullable(2)] Action endCallback = null, bool waitAnim = true)
		{
			if (this.InState)
			{
				this.StopMove();
			}
			this.InitComponents(entity);
			if (this.MoveComp == null || this.AnimComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove][AssistedWalk][Leader] Start 组件无效";
				string item = "PbDataId";
				CharacterActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			base.PrepareAttachMove(entity, data, endCallback);
			this.Params = new AssistedWalkParams(data);
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				actorComp2.ClearInput(false, true);
			}
			this.AnimInstance = (this.AnimComp.MainAnimInstance as UKuroAnimInstanceChar);
			this.WriteAnimLogicParams(true, waitAnim);
			this.AssistedWalkTagId = GameplayTagDefine.EGameplayTagId["角色.Common.地区运动状态.搀扶行走"];
			base.SetOnlyTag(this.TagComp, this.AssistedWalkTagId, true, "[AttachMove][AssistedWalk][Leader] Start");
			base.AddTags(this.TagComp, this.Params.LeaderGameplayTagList);
			this.MoveComp.SetMaxSpeed(this.Params.BaseMoveSpeed);
			this.LastMoveSpeed2D = 0f;
			this.HasLastInput = false;
			this.AnimInAssistedWalking = false;
			this.ClearLeaderDrivenFollowerState();
			this.LastSightLockMode = AssistedWalkUtils.Instance.SaveAndDisableSightLockMode(this.ActorComp);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[AttachMove][AssistedWalk][Leader] StartMove";
			string item2 = "PbDataId";
			CharacterActorComponent actorComp3 = this.ActorComp;
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (actorComp3 != null) ? new int?(actorComp3.CreatureData.GetPbDataId()) : null);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x0603DE5C RID: 253532 RVA: 0x011F7600 File Offset: 0x011F5800
		public override void UpdateMove(float deltaSeconds)
		{
			if (!this.InState)
			{
				return;
			}
			if (this.MoveComp == null || this.AnimComp == null || this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove][AssistedWalk][Leader] UpdateMove 组件无效";
				string item = "PbDataId";
				CharacterActorComponent actorComp = this.ActorComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.UpdateLeaderMove(deltaSeconds);
			this.UpdateLeaderPositionCorrection(deltaSeconds);
			this.WriteAnimLogicParamsPerFrame();
		}

		// Token: 0x0603DE5D RID: 253533 RVA: 0x011F7692 File Offset: 0x011F5892
		public override bool IsMoving()
		{
			return this.InState;
		}

		// Token: 0x0603DE5E RID: 253534 RVA: 0x011F769A File Offset: 0x011F589A
		public override void Dispose()
		{
			this.StopMove();
		}

		// Token: 0x0603DE5F RID: 253535 RVA: 0x011F76A2 File Offset: 0x011F58A2
		public override void StartAssistedWalk()
		{
			this.StartLeaderPositionCorrectionByNotify();
			this.ActorComp.Actor.SetAnimRootMotionTranslationScale(0f);
		}

		// Token: 0x0603DE60 RID: 253536 RVA: 0x011F76BF File Offset: 0x011F58BF
		public override void EnterAssistedWalkIdle()
		{
			this.ExecuteFollowerAttachByNotify();
			this.ActorComp.Actor.SetAnimRootMotionTranslationScale(1f);
		}

		// Token: 0x0603DE61 RID: 253537 RVA: 0x011F76DC File Offset: 0x011F58DC
		public override void EnterAssistedWalking()
		{
			if (!this.InState)
			{
				return;
			}
			this.AnimInAssistedWalking = true;
		}

		// Token: 0x0603DE62 RID: 253538 RVA: 0x011F76EE File Offset: 0x011F58EE
		public override void LeftAssistedWalking()
		{
			if (!this.InState)
			{
				return;
			}
			this.AnimInAssistedWalking = false;
			this.HasLastInput = false;
		}

		// Token: 0x0603DE63 RID: 253539 RVA: 0x011F7708 File Offset: 0x011F5908
		private void UpdateLeaderMove(float deltaSeconds)
		{
			float maxDeltaSeconds = Math.Min(deltaSeconds * 1000f * CharacterModel.Instance.InverseSelfCenteredTimeDilation, 166f) * 0.001f;
			this.ActorComp.SetOverrideTurnSpeed(new float?(this.AssistedWalkParams.LeaderTurnSpeed));
			this.LastMoveSpeed2D = 0f;
			Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
			UAnimInstance shellAnimInstance = this.AnimComp.ShellAnimInstance;
			if (shellAnimInstance != null && shellAnimInstance.HasKuroRootMotionAnim())
			{
				return;
			}
			if (this.ActorComp.InputDirectProxy.SizeSquared2D() > 1E-08)
			{
				this.HasLastInput = true;
				this.MoveForwardOnce(actorForwardProxy, maxDeltaSeconds, "[AttachMove][AssistedWalk][Leader] Move");
				return;
			}
			if (this.AnimInAssistedWalking && this.HasLastInput)
			{
				this.MoveForwardOnce(actorForwardProxy, maxDeltaSeconds, "[AttachMove][AssistedWalk][Leader] HoldLastInput Move");
			}
		}

		// Token: 0x0603DE64 RID: 253540 RVA: 0x011F77D4 File Offset: 0x011F59D4
		private void MoveForwardOnce(Vector forward, float maxDeltaSeconds, string reason)
		{
			float baseMoveSpeed = this.AssistedWalkParams.BaseMoveSpeed;
			this.TempVector.DeepCopy(forward);
			this.TempVector.MultiplyEqual((double)(maxDeltaSeconds * baseMoveSpeed));
			Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			double x = actorLocationProxy.X;
			double y = actorLocationProxy.Y;
			this.MoveComp.MoveCharacter(this.TempVector, maxDeltaSeconds, reason);
			double num = actorLocationProxy.X - x;
			double num2 = actorLocationProxy.Y - y;
			this.LastMoveSpeed2D = (float)Math.Sqrt(num * num + num2 * num2) / maxDeltaSeconds;
		}

		// Token: 0x0603DE65 RID: 253541 RVA: 0x011F7860 File Offset: 0x011F5A60
		private void ResetLeaderState()
		{
			if (this.MoveComp != null)
			{
				this.MoveComp.ResetMaxSpeed(null);
				this.MoveComp.ResetTurnRate();
			}
		}

		// Token: 0x0603DE66 RID: 253542 RVA: 0x011F7894 File Offset: 0x011F5A94
		private void StartLeaderPositionCorrectionByNotify()
		{
			if (!this.EnsureFollowerContext("StartAssistedWalk"))
			{
				return;
			}
			this.IsCorrectingLeaderPos = true;
			this.CorrectionElapsed = 0f;
			this.HasLoggedCorrectionDone = false;
			this.CorrectionStartPos.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.FollowerCorrectionStartZ = this.FollowerActorComp.ActorLocationProxy.Z;
			this.FollowerCorrectionSocketName = new FName?(new FName(this.AssistedWalkParams.AttachSocket));
		}

		// Token: 0x0603DE67 RID: 253543 RVA: 0x011F7910 File Offset: 0x011F5B10
		private void ExecuteFollowerAttachByNotify()
		{
			this.IsCorrectingLeaderPos = false;
			if (!this.EnsureFollowerContext("EnterAssistedWalkIdle"))
			{
				return;
			}
			Entity followerEntity = this.FollowerEntity;
			CharacterActorComponent followerActorComp = this.FollowerActorComp;
			CharacterActorComponent actorComp = this.ActorComp;
			this.FollowerAttachHelper = new FollowerAttachHelper();
			this.FollowerAttachHelper.Init(followerEntity);
			if (!this.FollowerAttachHelper.AttachToLeader(actorComp, this.AssistedWalkParams.AttachSocket, this.AssistedWalkParams.AttachTransform))
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.CWZ, "[AttachMove][AssistedWalk][Leader] EnterAssistedWalkIdle: Attach 失败，终止搀扶", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.FollowerAttachHelper = null;
				this.ReleaseLeaderInputControl();
				this.StopRelationAfterAttachFailed();
				return;
			}
			this.ApplyLeaderCapsuleExpansion(actorComp, followerEntity);
			this.ReleaseLeaderInputControl();
		}

		// Token: 0x0603DE68 RID: 253544 RVA: 0x011F79C0 File Offset: 0x011F5BC0
		private void UpdateLeaderPositionCorrection(float deltaSeconds)
		{
			if (!this.IsCorrectingLeaderPos)
			{
				return;
			}
			if (this.ActorComp == null || this.FollowerActorComp == null)
			{
				this.IsCorrectingLeaderPos = false;
				return;
			}
			ValueTuple<Transform, float>? valueTuple = AttachMoveUtils.Instance.PreviewLeaderTransform(this.ActorComp, this.FollowerActorComp, this.AssistedWalkParams.AttachSocket, this.AssistedWalkParams.AttachTransform);
			if (valueTuple == null)
			{
				return;
			}
			Vector location = valueTuple.Value.Item1.GetLocation();
			this.CorrectionElapsed += deltaSeconds;
			float num = 1f;
			float num2 = Math.Min(this.CorrectionElapsed / num, 1f);
			Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			this.CorrectionTmpVec.DeepCopy(location);
			this.CorrectionTmpVec.SubtractionEqual(this.CorrectionStartPos);
			this.CorrectionTmpVec.MultiplyEqual((double)num2);
			this.CorrectionTmpVec.AdditionEqual(this.CorrectionStartPos);
			this.CorrectionTmpVec.Z = actorLocationProxy.Z;
			this.CorrectionTmpVec.SubtractionEqual(actorLocationProxy);
			if (!this.CorrectionTmpVec.IsNearlyZero(9.999999747378752E-05))
			{
				this.TempVector.DeepCopy(this.CorrectionTmpVec);
				this.MoveComp.MoveCharacter(this.TempVector, deltaSeconds, "[AttachMove][AssistedWalk][Leader] PosCorrection");
			}
			this.UpdateFollowerPreAttachZ(num2);
			if (num2 >= 1f && !this.HasLoggedCorrectionDone)
			{
				this.HasLoggedCorrectionDone = true;
			}
		}

		// Token: 0x0603DE69 RID: 253545 RVA: 0x011F7B28 File Offset: 0x011F5D28
		private void UpdateFollowerPreAttachZ(float alpha)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			bool flag;
			if (actorComp == null)
			{
				flag = true;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				bool? flag2;
				if (actor == null)
				{
					flag2 = null;
				}
				else
				{
					USkeletalMeshComponent mesh = actor.Mesh;
					flag2 = ((mesh != null) ? new bool?(mesh.IsValid()) : null);
				}
				bool? flag3 = flag2;
				flag = !flag3.GetValueOrDefault();
			}
			if (flag || this.FollowerActorComp == null)
			{
				return;
			}
			FName? followerCorrectionSocketName = this.FollowerCorrectionSocketName;
			if (followerCorrectionSocketName == null)
			{
				return;
			}
			Transform followerSocketTransformInActor = this.FollowerSocketTransformInActor;
			FTransformDouble ftransformDouble = this.ActorComp.Actor.Mesh.D_GetSocketTransform(followerCorrectionSocketName.Value, ERelativeTransformSpace.RTS_Actor);
			followerSocketTransformInActor.FromUeTransform(ftransformDouble);
			Transform followerLeaderWorldTransform = this.FollowerLeaderWorldTransform;
			ftransformDouble = this.ActorComp.ActorTransform;
			followerLeaderWorldTransform.FromUeTransform(ftransformDouble);
			this.FollowerSocketTransformInActor.ComposeTransforms(this.FollowerLeaderWorldTransform, this.FollowerSocketWorldTransform);
			this.AssistedWalkParams.AttachTransform.ComposeTransforms(this.FollowerSocketWorldTransform, this.FollowerTargetWorldTransform);
			double z = this.FollowerTargetWorldTransform.GetLocation().Z;
			Vector actorLocationProxy = this.FollowerActorComp.ActorLocationProxy;
			double num = MathUtils.Instance.Lerp(this.FollowerCorrectionStartZ, z, (double)alpha);
			if (Math.Abs(actorLocationProxy.Z - num) <= 1E-08)
			{
				return;
			}
			this.FollowerPreAttachTmpVec.DeepCopy(actorLocationProxy);
			this.FollowerPreAttachTmpVec.Z = num;
			this.FollowerActorComp.SetActorLocation(this.FollowerPreAttachTmpVec.ToUeVector(false), "[AttachMove][AssistedWalk][Follower] PreAttachZCorrection", false);
		}

		// Token: 0x0603DE6A RID: 253546 RVA: 0x011F7C98 File Offset: 0x011F5E98
		private unsafe bool EnsureFollowerContext(string context)
		{
			bool flag = this.FollowerEntity != null && this.FollowerActorComp != null;
			if (!this.ResolveFollowerContext())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[AttachMove][AssistedWalk][Leader] 获取 Follower 上下文失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Context", context);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "LeaderEntityId";
				BaseTagComponent tagComp = this.TagComp;
				ptr = new ValueTuple<string, object>(item, (tagComp != null) ? tagComp.Entity.Id : 0);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			return true;
		}

		// Token: 0x0603DE6B RID: 253547 RVA: 0x011F7D38 File Offset: 0x011F5F38
		private void CacheFollowerAnimInstance()
		{
			if (this.FollowerAnimInstance != null || this.FollowerEntity == null)
			{
				return;
			}
			CharacterAnimationComponent component = this.FollowerEntity.GetComponent<CharacterAnimationComponent>();
			this.FollowerAnimInstance = (((component != null) ? component.MainAnimInstance : null) as UKuroAnimInstanceChar);
		}

		// Token: 0x0603DE6C RID: 253548 RVA: 0x011F7D7C File Offset: 0x011F5F7C
		private bool ResolveFollowerContext()
		{
			if (this.FollowerEntity != null && this.FollowerActorComp != null)
			{
				this.CacheFollowerAnimInstance();
				return true;
			}
			BaseTagComponent tagComp = this.TagComp;
			int entityId = (tagComp != null) ? tagComp.Entity.Id : 0;
			AttachMoveRelation relationByEntityId = AttachMoveUtils.Instance.GetRelationByEntityId(entityId);
			Entity entity;
			if (relationByEntityId == null)
			{
				entity = null;
			}
			else
			{
				BaseActorComponent followerActor = relationByEntityId.FollowerActor;
				entity = ((followerActor != null) ? followerActor.Entity : null);
			}
			Entity entity2 = entity;
			CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
			if (entity2 == null || characterActorComponent == null)
			{
				return false;
			}
			this.FollowerEntity = entity2;
			this.FollowerActorComp = characterActorComponent;
			this.CacheFollowerAnimInstance();
			return true;
		}

		// Token: 0x0603DE6D RID: 253549 RVA: 0x011F7E07 File Offset: 0x011F6007
		private void TryCacheFollowerContextSilently()
		{
			this.ResolveFollowerContext();
		}

		// Token: 0x0603DE6E RID: 253550 RVA: 0x011F7E10 File Offset: 0x011F6010
		private void StopRelationAfterAttachFailed()
		{
			BaseTagComponent tagComp = this.TagComp;
			int entityId = (tagComp != null) ? tagComp.Entity.Id : 0;
			AttachMoveRelation relationByEntityId = AttachMoveUtils.Instance.GetRelationByEntityId(entityId);
			if (relationByEntityId == null)
			{
				return;
			}
			Action stopFn = relationByEntityId.StopFn;
			if (stopFn == null)
			{
				return;
			}
			stopFn();
		}

		// Token: 0x0603DE6F RID: 253551 RVA: 0x011F7E54 File Offset: 0x011F6054
		private void ReleaseLeaderInputControl()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			Entity entity = actorComp.Entity;
			if (entity == null)
			{
				return;
			}
			CharacterCustomActionComponent component = entity.GetComponent<CharacterCustomActionComponent>();
			if (component == null)
			{
				return;
			}
			component.AddCustomSetPlayerControl(false, null);
		}

		// Token: 0x0603DE70 RID: 253552 RVA: 0x011F7E7C File Offset: 0x011F607C
		private void DetachFollowerFromLeader()
		{
			FollowerAttachHelper followerAttachHelper = this.FollowerAttachHelper;
			if (followerAttachHelper != null)
			{
				followerAttachHelper.DetachFromLeader();
			}
			this.FollowerAttachHelper = null;
		}

		// Token: 0x0603DE71 RID: 253553 RVA: 0x011F7E98 File Offset: 0x011F6098
		private void ClearLeaderDrivenFollowerState()
		{
			this.FollowerAttachHelper = null;
			this.FollowerEntity = null;
			this.FollowerActorComp = null;
			this.FollowerAnimInstance = null;
			this.IsCorrectingLeaderPos = false;
			this.CorrectionElapsed = 0f;
			this.HasLoggedCorrectionDone = false;
			this.FollowerCorrectionStartZ = 0.0;
			this.FollowerCorrectionSocketName = null;
			this.CapsuleModifiedLeader = null;
			this.OriginalLeaderRadius = 0f;
			this.CapsuleLocalOffset.Reset();
		}

		// Token: 0x0603DE72 RID: 253554 RVA: 0x011F7F14 File Offset: 0x011F6114
		private void ApplyLeaderCapsuleExpansion(CharacterActorComponent leader, Entity followerEntity)
		{
			CharacterActorComponent component = followerEntity.GetComponent<CharacterActorComponent>();
			if (component != null)
			{
				TsBaseCharacter actor = leader.Actor;
				bool flag;
				if (actor == null)
				{
					flag = true;
				}
				else
				{
					UCapsuleComponent capsuleComponent = actor.CapsuleComponent;
					flag = !((capsuleComponent != null) ? new bool?(capsuleComponent.IsValid()) : null).GetValueOrDefault();
				}
				if (!flag)
				{
					float scaledRadius = leader.ScaledRadius;
					float scaledRadius2 = component.ScaledRadius;
					Vector actorLocationProxy = leader.ActorLocationProxy;
					Vector actorLocationProxy2 = component.ActorLocationProxy;
					Vector correctionTmpVec = this.CorrectionTmpVec;
					correctionTmpVec.DeepCopy(actorLocationProxy2);
					correctionTmpVec.SubtractionEqual(actorLocationProxy);
					correctionTmpVec.Z = 0.0;
					double num = correctionTmpVec.Size2D();
					if (num < 1E-08)
					{
						return;
					}
					correctionTmpVec.MultiplyEqual((double)scaledRadius / num);
					leader.ActorQuatProxy.UnRotateVector(correctionTmpVec, this.CapsuleLocalOffset);
					correctionTmpVec.AdditionEqual(actorLocationProxy);
					leader.SetActorLocationAndRotationExceptMesh(correctionTmpVec.ToUeVector(false), leader.ActorRotation, "AssistedWalk.CapsuleExpand", true, null);
					this.OriginalLeaderRadius = scaledRadius;
					this.CapsuleModifiedLeader = leader;
					leader.SetRadiusAndHalfHeight(scaledRadius + scaledRadius2, leader.ScaledHalfHeight, false, false);
					return;
				}
			}
		}

		// Token: 0x0603DE73 RID: 253555 RVA: 0x011F8034 File Offset: 0x011F6234
		private void RestoreLeaderCapsule()
		{
			CharacterActorComponent capsuleModifiedLeader = this.CapsuleModifiedLeader;
			bool flag;
			if (capsuleModifiedLeader == null)
			{
				flag = true;
			}
			else
			{
				TsBaseCharacter actor = capsuleModifiedLeader.Actor;
				flag = !((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				this.CapsuleModifiedLeader = null;
				return;
			}
			Vector correctionTmpVec = this.CorrectionTmpVec;
			capsuleModifiedLeader.ActorQuatProxy.RotateVector(this.CapsuleLocalOffset, correctionTmpVec);
			correctionTmpVec.MultiplyEqual(-1.0);
			correctionTmpVec.AdditionEqual(capsuleModifiedLeader.ActorLocationProxy);
			capsuleModifiedLeader.SetActorLocationAndRotationExceptMesh(correctionTmpVec.ToUeVector(false), capsuleModifiedLeader.ActorRotation, "AssistedWalk.CapsuleRestore", false, null);
			capsuleModifiedLeader.SetRadiusAndHalfHeight(this.OriginalLeaderRadius, capsuleModifiedLeader.HalfHeight, false, false);
			this.CapsuleModifiedLeader = null;
		}

		// Token: 0x0603DE74 RID: 253556 RVA: 0x011F80F8 File Offset: 0x011F62F8
		private void WriteAnimLogicParams(bool entering, bool waitAnim = true)
		{
			UKuroAnimInstanceChar animInstance = this.AnimInstance;
			UAbpLogicParams uabpLogicParams = (animInstance != null) ? animInstance.LogicParams : null;
			if (uabpLogicParams == null)
			{
				return;
			}
			uabpLogicParams.bHelpedAssistedWalk = false;
			uabpLogicParams.bSkipEnterAssistedWalkAnim = (entering && !waitAnim);
			uabpLogicParams.AssistedWalkAnimRate = (entering ? this.GetAnimRate() : ((float)this.AssistedWalkParams.AnimSpeedRateRange.X));
			uabpLogicParams.bInAssistedWalking = false;
		}

		// Token: 0x0603DE75 RID: 253557 RVA: 0x011F815C File Offset: 0x011F635C
		private void WriteAnimLogicParamsPerFrame()
		{
			float animRate = this.GetAnimRate();
			bool bInAssistedWalking = this.IsActivelyAssistedWalking();
			UKuroAnimInstanceChar animInstance = this.AnimInstance;
			UAbpLogicParams uabpLogicParams = (animInstance != null) ? animInstance.LogicParams : null;
			if (uabpLogicParams != null)
			{
				uabpLogicParams.AssistedWalkAnimRate = animRate;
				uabpLogicParams.bInAssistedWalking = bInAssistedWalking;
			}
			this.TryCacheFollowerContextSilently();
			UKuroAnimInstanceChar followerAnimInstance = this.FollowerAnimInstance;
			UAbpLogicParams uabpLogicParams2 = (followerAnimInstance != null) ? followerAnimInstance.LogicParams : null;
			if (uabpLogicParams2 != null)
			{
				uabpLogicParams2.AssistedWalkAnimRate = animRate;
				uabpLogicParams2.bInAssistedWalking = bInAssistedWalking;
			}
		}

		// Token: 0x0603DE76 RID: 253558 RVA: 0x011F81C8 File Offset: 0x011F63C8
		private float GetAnimRate()
		{
			AssistedWalkParams assistedWalkParams = this.AssistedWalkParams;
			Vector2D animSpeedRateRange = assistedWalkParams.AnimSpeedRateRange;
			if (!this.InState || (double)assistedWalkParams.BaseMoveSpeed <= 1E-08)
			{
				return (float)animSpeedRateRange.X;
			}
			float currentValue = this.LastMoveSpeed2D / assistedWalkParams.BaseMoveSpeed;
			return MathUtils.Instance.Clamp(currentValue, (float)animSpeedRateRange.X, (float)animSpeedRateRange.Y);
		}

		// Token: 0x0603DE77 RID: 253559 RVA: 0x011F822C File Offset: 0x011F642C
		private bool IsActivelyAssistedWalking()
		{
			return this.InState && this.ActorComp != null && this.ActorComp.InputDirectProxy.SizeSquared2D() > 1E-08;
		}

		// Token: 0x1700759C RID: 30108
		// (get) Token: 0x0603DE78 RID: 253560 RVA: 0x011F825B File Offset: 0x011F645B
		private AssistedWalkParams AssistedWalkParams
		{
			get
			{
				return this.Params ?? AssistedWalkParams.Default;
			}
		}

		// Token: 0x0603DE79 RID: 253561 RVA: 0x011F826C File Offset: 0x011F646C
		private void InitComponents(Entity entity)
		{
			this.ActorComp = entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = entity.GetComponent<BaseMoveComponent>();
			this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
			this.TagComp = entity.GetComponent<BaseTagComponent>();
			this.UeMovementComp = entity.GetComponent<UeMovementTickManageComponent>();
		}

		// Token: 0x0603DE7A RID: 253562 RVA: 0x011F82AA File Offset: 0x011F64AA
		private void ClearLeaderAssistedWalkTag()
		{
			if (this.AssistedWalkTagId == 0)
			{
				return;
			}
			base.SetOnlyTag(this.TagComp, this.AssistedWalkTagId, false, "[AttachMove][AssistedWalk][Leader] StopMove");
			this.AssistedWalkTagId = 0;
		}

		// Token: 0x0603DE7B RID: 253563 RVA: 0x011F82D4 File Offset: 0x011F64D4
		private void ClearLeaderComponents()
		{
			this.ActorComp = null;
			this.MoveComp = null;
			this.AnimComp = null;
			this.UeMovementComp = null;
			this.AnimInstance = null;
			this.AnimInAssistedWalking = false;
			this.LastMoveSpeed2D = 0f;
			this.HasLastInput = false;
			this.ClearLeaderDrivenFollowerState();
		}

		// Token: 0x0603DE7C RID: 253564 RVA: 0x011F8324 File Offset: 0x011F6524
		private bool ArePartnerComponentsAlive()
		{
			AssistedWalkUtils instance = AssistedWalkUtils.Instance;
			string logTag = "[AttachMove][AssistedWalk][Leader] 兄弟组件已销毁，跳过状态恢复";
			CharacterActorComponent actorComp = this.ActorComp;
			bool[] array = new bool[4];
			int num = 0;
			UeMovementTickManageComponent ueMovementComp = this.UeMovementComp;
			array[num] = (ueMovementComp == null || ueMovementComp.Valid);
			int num2 = 1;
			BaseMoveComponent moveComp = this.MoveComp;
			array[num2] = (moveComp == null || moveComp.Valid);
			int num3 = 2;
			CharacterAnimationComponent animComp = this.AnimComp;
			array[num3] = (animComp == null || animComp.Valid);
			int num4 = 3;
			BaseTagComponent tagComp = this.TagComp;
			array[num4] = (tagComp == null || tagComp.Valid);
			return instance.ArePartnerComponentsAlive(logTag, actorComp, array);
		}

		// Token: 0x04020DF4 RID: 134644
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04020DF5 RID: 134645
		[Nullable(2)]
		private BaseMoveComponent MoveComp;

		// Token: 0x04020DF6 RID: 134646
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04020DF7 RID: 134647
		[Nullable(2)]
		private UeMovementTickManageComponent UeMovementComp;

		// Token: 0x04020DF8 RID: 134648
		[Nullable(2)]
		private UKuroAnimInstanceChar AnimInstance;

		// Token: 0x04020DF9 RID: 134649
		private int AssistedWalkTagId;

		// Token: 0x04020DFA RID: 134650
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04020DFB RID: 134651
		private float LastMoveSpeed2D;

		// Token: 0x04020DFC RID: 134652
		private bool HasLastInput;

		// Token: 0x04020DFD RID: 134653
		private bool AnimInAssistedWalking;

		// Token: 0x04020DFE RID: 134654
		[Nullable(2)]
		private FollowerAttachHelper FollowerAttachHelper;

		// Token: 0x04020DFF RID: 134655
		[Nullable(2)]
		private Entity FollowerEntity;

		// Token: 0x04020E00 RID: 134656
		[Nullable(2)]
		private CharacterActorComponent FollowerActorComp;

		// Token: 0x04020E01 RID: 134657
		[Nullable(2)]
		private UKuroAnimInstanceChar FollowerAnimInstance;

		// Token: 0x04020E02 RID: 134658
		private bool IsCorrectingLeaderPos;

		// Token: 0x04020E03 RID: 134659
		private float CorrectionElapsed;

		// Token: 0x04020E04 RID: 134660
		private readonly Vector CorrectionStartPos = Vector.Create();

		// Token: 0x04020E05 RID: 134661
		private bool HasLoggedCorrectionDone;

		// Token: 0x04020E06 RID: 134662
		private readonly Vector CorrectionTmpVec = Vector.Create();

		// Token: 0x04020E07 RID: 134663
		private double FollowerCorrectionStartZ;

		// Token: 0x04020E08 RID: 134664
		private FName? FollowerCorrectionSocketName;

		// Token: 0x04020E09 RID: 134665
		private readonly Vector FollowerPreAttachTmpVec = Vector.Create();

		// Token: 0x04020E0A RID: 134666
		private readonly Transform FollowerSocketTransformInActor = Transform.Create();

		// Token: 0x04020E0B RID: 134667
		private readonly Transform FollowerLeaderWorldTransform = Transform.Create();

		// Token: 0x04020E0C RID: 134668
		private readonly Transform FollowerSocketWorldTransform = Transform.Create();

		// Token: 0x04020E0D RID: 134669
		private readonly Transform FollowerTargetWorldTransform = Transform.Create();

		// Token: 0x04020E0E RID: 134670
		[Nullable(2)]
		private CharacterActorComponent CapsuleModifiedLeader;

		// Token: 0x04020E0F RID: 134671
		private float OriginalLeaderRadius;

		// Token: 0x04020E10 RID: 134672
		private readonly Vector CapsuleLocalOffset = Vector.Create();

		// Token: 0x04020E11 RID: 134673
		private SightLockMode LastSightLockMode;
	}
}
