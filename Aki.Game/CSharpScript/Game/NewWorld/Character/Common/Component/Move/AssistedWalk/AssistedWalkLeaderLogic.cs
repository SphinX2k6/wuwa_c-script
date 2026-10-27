using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AssistedWalk;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk
{
	// Token: 0x0200710C RID: 28940
	[NullableContext(1)]
	[Nullable(0)]
	public class AssistedWalkLeaderLogic : AttachMoveLogic
	{
		// Token: 0x17009D0C RID: 40204
		// (get) Token: 0x06046A59 RID: 289369 RVA: 0x011C82EB File Offset: 0x011C64EB
		// (set) Token: 0x06046A5A RID: 289370 RVA: 0x011C82F8 File Offset: 0x011C64F8
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

		// Token: 0x06046A5B RID: 289371 RVA: 0x011C8304 File Offset: 0x011C6504
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

		// Token: 0x06046A5C RID: 289372 RVA: 0x011C8438 File Offset: 0x011C6638
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

		// Token: 0x06046A5D RID: 289373 RVA: 0x011C85E0 File Offset: 0x011C67E0
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

		// Token: 0x06046A5E RID: 289374 RVA: 0x011C8672 File Offset: 0x011C6872
		public override bool IsMoving()
		{
			return this.InState;
		}

		// Token: 0x06046A5F RID: 289375 RVA: 0x011C867A File Offset: 0x011C687A
		public override void Dispose()
		{
			this.StopMove();
		}

		// Token: 0x06046A60 RID: 289376 RVA: 0x011C8682 File Offset: 0x011C6882
		public override void StartAssistedWalk()
		{
			this.StartLeaderPositionCorrectionByNotify();
			this.ActorComp.Actor.SetAnimRootMotionTranslationScale(0f);
		}

		// Token: 0x06046A61 RID: 289377 RVA: 0x011C869F File Offset: 0x011C689F
		public override void EnterAssistedWalkIdle()
		{
			this.ExecuteFollowerAttachByNotify();
			this.ActorComp.Actor.SetAnimRootMotionTranslationScale(1f);
		}

		// Token: 0x06046A62 RID: 289378 RVA: 0x011C86BC File Offset: 0x011C68BC
		public override void EnterAssistedWalking()
		{
			if (!this.InState)
			{
				return;
			}
			this.AnimInAssistedWalking = true;
		}

		// Token: 0x06046A63 RID: 289379 RVA: 0x011C86CE File Offset: 0x011C68CE
		public override void LeftAssistedWalking()
		{
			if (!this.InState)
			{
				return;
			}
			this.AnimInAssistedWalking = false;
			this.HasLastInput = false;
		}

		// Token: 0x06046A64 RID: 289380 RVA: 0x011C86E8 File Offset: 0x011C68E8
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

		// Token: 0x06046A65 RID: 289381 RVA: 0x011C87B4 File Offset: 0x011C69B4
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

		// Token: 0x06046A66 RID: 289382 RVA: 0x011C8840 File Offset: 0x011C6A40
		private void ResetLeaderState()
		{
			if (this.MoveComp != null)
			{
				this.MoveComp.ResetMaxSpeed(null);
				this.MoveComp.ResetTurnRate();
			}
		}

		// Token: 0x06046A67 RID: 289383 RVA: 0x011C8874 File Offset: 0x011C6A74
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

		// Token: 0x06046A68 RID: 289384 RVA: 0x011C88F0 File Offset: 0x011C6AF0
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

		// Token: 0x06046A69 RID: 289385 RVA: 0x011C89A0 File Offset: 0x011C6BA0
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

		// Token: 0x06046A6A RID: 289386 RVA: 0x011C8B08 File Offset: 0x011C6D08
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

		// Token: 0x06046A6B RID: 289387 RVA: 0x011C8C78 File Offset: 0x011C6E78
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

		// Token: 0x06046A6C RID: 289388 RVA: 0x011C8D18 File Offset: 0x011C6F18
		private void CacheFollowerAnimInstance()
		{
			if (this.FollowerAnimInstance != null || this.FollowerEntity == null)
			{
				return;
			}
			CharacterAnimationComponent component = this.FollowerEntity.GetComponent<CharacterAnimationComponent>();
			this.FollowerAnimInstance = (((component != null) ? component.MainAnimInstance : null) as UKuroAnimInstanceChar);
		}

		// Token: 0x06046A6D RID: 289389 RVA: 0x011C8D5C File Offset: 0x011C6F5C
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

		// Token: 0x06046A6E RID: 289390 RVA: 0x011C8DE7 File Offset: 0x011C6FE7
		private void TryCacheFollowerContextSilently()
		{
			this.ResolveFollowerContext();
		}

		// Token: 0x06046A6F RID: 289391 RVA: 0x011C8DF0 File Offset: 0x011C6FF0
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

		// Token: 0x06046A70 RID: 289392 RVA: 0x011C8E34 File Offset: 0x011C7034
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

		// Token: 0x06046A71 RID: 289393 RVA: 0x011C8E5C File Offset: 0x011C705C
		private void DetachFollowerFromLeader()
		{
			FollowerAttachHelper followerAttachHelper = this.FollowerAttachHelper;
			if (followerAttachHelper != null)
			{
				followerAttachHelper.DetachFromLeader();
			}
			this.FollowerAttachHelper = null;
		}

		// Token: 0x06046A72 RID: 289394 RVA: 0x011C8E78 File Offset: 0x011C7078
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

		// Token: 0x06046A73 RID: 289395 RVA: 0x011C8EF4 File Offset: 0x011C70F4
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

		// Token: 0x06046A74 RID: 289396 RVA: 0x011C9014 File Offset: 0x011C7214
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

		// Token: 0x06046A75 RID: 289397 RVA: 0x011C90D8 File Offset: 0x011C72D8
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

		// Token: 0x06046A76 RID: 289398 RVA: 0x011C913C File Offset: 0x011C733C
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

		// Token: 0x06046A77 RID: 289399 RVA: 0x011C91A8 File Offset: 0x011C73A8
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

		// Token: 0x06046A78 RID: 289400 RVA: 0x011C920C File Offset: 0x011C740C
		private bool IsActivelyAssistedWalking()
		{
			return this.InState && this.ActorComp != null && this.ActorComp.InputDirectProxy.SizeSquared2D() > 1E-08;
		}

		// Token: 0x17009D0D RID: 40205
		// (get) Token: 0x06046A79 RID: 289401 RVA: 0x011C923B File Offset: 0x011C743B
		private AssistedWalkParams AssistedWalkParams
		{
			get
			{
				return this.Params ?? AssistedWalkParams.Default;
			}
		}

		// Token: 0x06046A7A RID: 289402 RVA: 0x011C924C File Offset: 0x011C744C
		private void InitComponents(Entity entity)
		{
			this.ActorComp = entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = entity.GetComponent<BaseMoveComponent>();
			this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
			this.TagComp = entity.GetComponent<BaseTagComponent>();
			this.UeMovementComp = entity.GetComponent<UeMovementTickManageComponent>();
		}

		// Token: 0x06046A7B RID: 289403 RVA: 0x011C928A File Offset: 0x011C748A
		private void ClearLeaderAssistedWalkTag()
		{
			if (this.AssistedWalkTagId == 0)
			{
				return;
			}
			base.SetOnlyTag(this.TagComp, this.AssistedWalkTagId, false, "[AttachMove][AssistedWalk][Leader] StopMove");
			this.AssistedWalkTagId = 0;
		}

		// Token: 0x06046A7C RID: 289404 RVA: 0x011C92B4 File Offset: 0x011C74B4
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

		// Token: 0x06046A7D RID: 289405 RVA: 0x011C9304 File Offset: 0x011C7504
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

		// Token: 0x0402515F RID: 151903
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04025160 RID: 151904
		[Nullable(2)]
		private BaseMoveComponent MoveComp;

		// Token: 0x04025161 RID: 151905
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04025162 RID: 151906
		[Nullable(2)]
		private UeMovementTickManageComponent UeMovementComp;

		// Token: 0x04025163 RID: 151907
		[Nullable(2)]
		private UKuroAnimInstanceChar AnimInstance;

		// Token: 0x04025164 RID: 151908
		private int AssistedWalkTagId;

		// Token: 0x04025165 RID: 151909
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04025166 RID: 151910
		private float LastMoveSpeed2D;

		// Token: 0x04025167 RID: 151911
		private bool HasLastInput;

		// Token: 0x04025168 RID: 151912
		private bool AnimInAssistedWalking;

		// Token: 0x04025169 RID: 151913
		[Nullable(2)]
		private FollowerAttachHelper FollowerAttachHelper;

		// Token: 0x0402516A RID: 151914
		[Nullable(2)]
		private Entity FollowerEntity;

		// Token: 0x0402516B RID: 151915
		[Nullable(2)]
		private CharacterActorComponent FollowerActorComp;

		// Token: 0x0402516C RID: 151916
		[Nullable(2)]
		private UKuroAnimInstanceChar FollowerAnimInstance;

		// Token: 0x0402516D RID: 151917
		private bool IsCorrectingLeaderPos;

		// Token: 0x0402516E RID: 151918
		private float CorrectionElapsed;

		// Token: 0x0402516F RID: 151919
		private readonly Vector CorrectionStartPos = Vector.Create();

		// Token: 0x04025170 RID: 151920
		private bool HasLoggedCorrectionDone;

		// Token: 0x04025171 RID: 151921
		private readonly Vector CorrectionTmpVec = Vector.Create();

		// Token: 0x04025172 RID: 151922
		private double FollowerCorrectionStartZ;

		// Token: 0x04025173 RID: 151923
		private FName? FollowerCorrectionSocketName;

		// Token: 0x04025174 RID: 151924
		private readonly Vector FollowerPreAttachTmpVec = Vector.Create();

		// Token: 0x04025175 RID: 151925
		private readonly Transform FollowerSocketTransformInActor = Transform.Create();

		// Token: 0x04025176 RID: 151926
		private readonly Transform FollowerLeaderWorldTransform = Transform.Create();

		// Token: 0x04025177 RID: 151927
		private readonly Transform FollowerSocketWorldTransform = Transform.Create();

		// Token: 0x04025178 RID: 151928
		private readonly Transform FollowerTargetWorldTransform = Transform.Create();

		// Token: 0x04025179 RID: 151929
		[Nullable(2)]
		private CharacterActorComponent CapsuleModifiedLeader;

		// Token: 0x0402517A RID: 151930
		private float OriginalLeaderRadius;

		// Token: 0x0402517B RID: 151931
		private readonly Vector CapsuleLocalOffset = Vector.Create();

		// Token: 0x0402517C RID: 151932
		private SightLockMode LastSightLockMode;
	}
}
