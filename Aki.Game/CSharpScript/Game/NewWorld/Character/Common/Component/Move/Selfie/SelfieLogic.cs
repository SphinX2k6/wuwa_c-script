using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie
{
	// Token: 0x020063B3 RID: 25523
	[NullableContext(1)]
	[Nullable(0)]
	public class SelfieLogic
	{
		// Token: 0x0603DE08 RID: 253448 RVA: 0x011F521C File Offset: 0x011F341C
		public bool EnterSelfie(Entity entity, float[] pitchLimit, float[] yawLimit, float moveSpeed)
		{
			if (this.InState)
			{
				this.LeaveSelfie();
			}
			this.InitComponents(entity);
			if (this.MoveComp == null || this.AnimComp == null || this.TagComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[Selfie] Enter 组件无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entity.Id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ClearComponents();
				return false;
			}
			this.InState = true;
			this.SaveState();
			this.AnimComp.EnableSelfieSight();
			this.ApplyEnterState(pitchLimit, yawLimit, moveSpeed);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PhotoCamera;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[Selfie] Enter";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", entity.Id);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return true;
		}

		// Token: 0x0603DE09 RID: 253449 RVA: 0x011F52EC File Offset: 0x011F34EC
		public void LeaveSelfie()
		{
			if (!this.InState)
			{
				this.ClearComponents();
				return;
			}
			this.CancelAllMontageSlots(-1f);
			this.ClearLeftHandIk();
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null)
			{
				animComp.DisableSelfieSight();
			}
			this.RestoreState();
			this.InState = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[Selfie] Leave";
			string item = "EntityId";
			Entity entity = this.Entity;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (entity != null) ? entity.Id : 0);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ClearComponents();
		}

		// Token: 0x0603DE0A RID: 253450 RVA: 0x011F537D File Offset: 0x011F357D
		public bool IsInSelfie()
		{
			return this.InState;
		}

		// Token: 0x0603DE0B RID: 253451 RVA: 0x011F5385 File Offset: 0x011F3585
		public void UpdateSelfieSightLimit(float[] pitchLimit, float[] yawLimit)
		{
			if (!this.InState || this.AnimComp == null || this.LastSightLimit == null)
			{
				return;
			}
			this.ApplySelfieSightLimit(pitchLimit, yawLimit);
		}

		// Token: 0x0603DE0C RID: 253452 RVA: 0x011F53A8 File Offset: 0x011F35A8
		public void SetSightByCameraLocation(Vector cameraWorldLocation)
		{
			if (!this.InState)
			{
				return;
			}
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null)
			{
				animComp.SetSelfieCameraWorldLocation(cameraWorldLocation);
			}
			if (this.DebugDraw)
			{
				this.DrawSightDebug(cameraWorldLocation);
			}
		}

		// Token: 0x0603DE0D RID: 253453 RVA: 0x011F53D4 File Offset: 0x011F35D4
		public void SetLeftHandIkByCameraPose(Vector ikPointWorldLocation, Quat handWorldRotation, float cameraPitchInGravity)
		{
			if (!this.InState)
			{
				return;
			}
			CharacterAnimationComponent animComp = this.AnimComp;
			UKuroAnimInstanceChar ukuroAnimInstanceChar = ((animComp != null) ? animComp.MainAnimInstance : null) as UKuroAnimInstanceChar;
			UAbpLogicParams uabpLogicParams = (ukuroAnimInstanceChar != null) ? ukuroAnimInstanceChar.LogicParams : null;
			CharacterAnimationComponent animComp2 = this.AnimComp;
			USkeletalMeshComponent uskeletalMeshComponent;
			if (animComp2 == null)
			{
				uskeletalMeshComponent = null;
			}
			else
			{
				TsBaseCharacter actor = animComp2.Actor;
				uskeletalMeshComponent = ((actor != null) ? actor.Mesh : null);
			}
			USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
			if (ukuroAnimInstanceChar == null || uabpLogicParams == null || uskeletalMeshComponent2 == null)
			{
				return;
			}
			Transform rootTransform = this.RootTransform;
			FTransformDouble ftransformDouble = uskeletalMeshComponent2.D_GetSocketTransform(CharacterNameDefines.Instance.ROOT, ERelativeTransformSpace.RTS_World);
			rootTransform.FromUeTransform(ftransformDouble);
			this.HandWorldTarget.DeepCopy(ikPointWorldLocation);
			this.RootTransform.InverseTransformPosition(this.HandWorldTarget, this.LeftHandIkTarget.Location);
			this.RootTransform.InverseTransformRotation(handWorldRotation, this.LeftHandIkTarget.Rotation);
			this.LeftHandIkTargetUe.Location = this.LeftHandIkTarget.Location.ToUeVectorOld();
			this.LeftHandIkTargetUe.Rotation = this.LeftHandIkTarget.Rotation.ToUeQuat();
			this.LeftHandIkTargetUe.Alpha = 1f;
			uabpLogicParams.LeftHandIKTargetCS = this.LeftHandIkTargetUe;
			uabpLogicParams.SelfiePhotoArmAngle = -cameraPitchInGravity;
			if (this.DebugDrawIk)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, ikPointWorldLocation.ToUeVector(false), 4f, 6, new FLinearColor?(SelfieLogic.SelfieDebugIkColor), 0f, 2f);
				this.RootTransform.TransformPosition(this.LeftHandIkTarget.Location, this.HandWorldTarget);
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, ikPointWorldLocation.ToUeVector(false), 4f, 6, new FLinearColor?(new FLinearColor(0f, 1f, 1f, 1f)), 0f, 2f);
			}
		}

		// Token: 0x0603DE0E RID: 253454 RVA: 0x011F5580 File Offset: 0x011F3780
		public void ClearLeftHandIk()
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			UKuroAnimInstanceChar ukuroAnimInstanceChar = ((animComp != null) ? animComp.MainAnimInstance : null) as UKuroAnimInstanceChar;
			UAbpLogicParams uabpLogicParams = (ukuroAnimInstanceChar != null) ? ukuroAnimInstanceChar.LogicParams : null;
			if (uabpLogicParams == null)
			{
				return;
			}
			this.LeftHandIkTarget.Alpha = 0.0;
			this.LeftHandIkTargetUe.Alpha = 0f;
			uabpLogicParams.LeftHandIKTargetCS = this.LeftHandIkTargetUe;
		}

		// Token: 0x0603DE0F RID: 253455 RVA: 0x011F55E5 File Offset: 0x011F37E5
		public void ClearSight()
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null)
			{
				return;
			}
			animComp.ClearSelfieCameraWorldLocation();
		}

		// Token: 0x0603DE10 RID: 253456 RVA: 0x011F55F8 File Offset: 0x011F37F8
		public bool PlaySelfieMontageByConfigId(int configId, ESelfieMontageType montageType, string dtPath = "/Game/Aki/Character/Role/Common/Data/DT/DT_SelfieMontageConfig.DT_SelfieMontageConfig")
		{
			SelfieLogic.<>c__DisplayClass44_0 CS$<>8__locals1 = new SelfieLogic.<>c__DisplayClass44_0();
			CS$<>8__locals1.<>4__this = this;
			if (!this.InState || this.Entity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[Selfie] 未进入自拍，跳过播放蒙太奇";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", configId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			SelfieMontageData selfieMontageConfig = this.GetSelfieMontageConfig(configId, montageType, dtPath);
			if (selfieMontageConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PhotoCamera;
				ELogAuthor author2 = ELogAuthor.ZJL;
				string message2 = "[Selfie] 蒙太奇配置不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ConfigId", configId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			SelfieLogic.<>c__DisplayClass44_0 CS$<>8__locals2 = CS$<>8__locals1;
			TSoftObjectPtr<UAnimMontage> montageRef = selfieMontageConfig.MontageRef;
			CS$<>8__locals2.montagePath = ((montageRef != null) ? montageRef.ToAssetPathName() : null);
			if (string.IsNullOrEmpty(CS$<>8__locals1.montagePath))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.PhotoCamera;
				ELogAuthor author3 = ELogAuthor.ZJL;
				string message3 = "[Selfie] 蒙太奇软引用为空";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("ConfigId", configId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			CS$<>8__locals1.slot = this.GetOrCreateMontageSlot(montageType);
			this.CancelMontageSlot(CS$<>8__locals1.slot, -1f);
			CS$<>8__locals1.slot.ConfigId = configId;
			CS$<>8__locals1.slot.DataTablePath = dtPath;
			SelfieLogic.<>c__DisplayClass44_0 CS$<>8__locals3 = CS$<>8__locals1;
			SelfieMontageSlot slot = CS$<>8__locals1.slot;
			int num = slot.Token + 1;
			slot.Token = num;
			CS$<>8__locals3.montageToken = num;
			ResourceSystem.Instance.LoadAsync<UAnimMontage>(CS$<>8__locals1.montagePath, delegate([Nullable(2)] UAnimMontage montage, string _)
			{
				if (!CS$<>8__locals1.<>4__this.InState || CS$<>8__locals1.montageToken != CS$<>8__locals1.slot.Token)
				{
					return;
				}
				if (montage == null || !montage.IsValid())
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.PhotoCamera;
					ELogAuthor author4 = ELogAuthor.ZJL;
					string message4 = "[Selfie] 蒙太奇加载失败";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("path", CS$<>8__locals1.montagePath);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					CS$<>8__locals1.slot.Clear();
					return;
				}
				UAnimInstance gameplayAnimInstance = CS$<>8__locals1.<>4__this.GetGameplayAnimInstance();
				if (gameplayAnimInstance == null)
				{
					Log instance5 = Log.Instance;
					ELogModule module5 = ELogModule.PhotoCamera;
					ELogAuthor author5 = ELogAuthor.ZJL;
					string message5 = "[Selfie] 获取 GameplayABP 实例失败";
					string item = "EntityId";
					Entity entity = CS$<>8__locals1.<>4__this.Entity;
					ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>(item, (entity != null) ? entity.Id : 0);
					instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
					CS$<>8__locals1.slot.Clear();
					return;
				}
				if (gameplayAnimInstance.Montage_Play(montage, 1f, EMontagePlayReturnType.MontageLength, 0f, false) <= 0f)
				{
					Log instance6 = Log.Instance;
					ELogModule module6 = ELogModule.PhotoCamera;
					ELogAuthor author6 = ELogAuthor.ZJL;
					string message6 = "[Selfie] 蒙太奇播放失败";
					ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("path", CS$<>8__locals1.montagePath);
					instance6.Error(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
					CS$<>8__locals1.slot.Clear();
					return;
				}
				CS$<>8__locals1.slot.Montage = montage;
				CS$<>8__locals1.slot.AnimInstance = gameplayAnimInstance;
			}, 100, "js_undefined");
			return true;
		}

		// Token: 0x0603DE11 RID: 253457 RVA: 0x011F5764 File Offset: 0x011F3964
		[return: Nullable(2)]
		public SelfieMontageData GetSelfieMontageConfig(int configId, ESelfieMontageType montageType, string dtPath = "/Game/Aki/Character/Role/Common/Data/DT/DT_SelfieMontageConfig.DT_SelfieMontageConfig")
		{
			if (!this.EnsureSelfieMontageCache(dtPath))
			{
				return null;
			}
			Dictionary<int, SelfieMontageData> selfieMontageMap = this.GetSelfieMontageMap(montageType);
			if (selfieMontageMap == null)
			{
				return null;
			}
			SelfieMontageData result;
			selfieMontageMap.TryGetValue(configId, out result);
			return result;
		}

		// Token: 0x0603DE12 RID: 253458 RVA: 0x011F5794 File Offset: 0x011F3994
		public bool CancelSelfieMontageByConfigId(int configId, ESelfieMontageType montageType, string dtPath = "/Game/Aki/Character/Role/Common/Data/DT/DT_SelfieMontageConfig.DT_SelfieMontageConfig", float blendOutTime = -1f)
		{
			SelfieMontageSlot selfieMontageSlot;
			if (!this.MontageSlots.TryGetValue(montageType, out selfieMontageSlot) || !selfieMontageSlot.IsCurrent(configId, dtPath))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[Selfie] 取消的蒙太奇不是当前播放目标";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", configId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.CancelMontageSlot(selfieMontageSlot, blendOutTime);
			return true;
		}

		// Token: 0x0603DE13 RID: 253459 RVA: 0x011F57F8 File Offset: 0x011F39F8
		public bool CancelSelfieMontageByType(ESelfieMontageType montageType, float blendOutTime = -1f)
		{
			SelfieMontageSlot slot;
			if (!this.MontageSlots.TryGetValue(montageType, out slot))
			{
				return true;
			}
			this.CancelMontageSlot(slot, blendOutTime);
			return true;
		}

		// Token: 0x0603DE14 RID: 253460 RVA: 0x011F5820 File Offset: 0x011F3A20
		private SelfieMontageSlot GetOrCreateMontageSlot(ESelfieMontageType montageType)
		{
			SelfieMontageSlot selfieMontageSlot;
			if (!this.MontageSlots.TryGetValue(montageType, out selfieMontageSlot))
			{
				selfieMontageSlot = new SelfieMontageSlot();
				this.MontageSlots[montageType] = selfieMontageSlot;
			}
			return selfieMontageSlot;
		}

		// Token: 0x0603DE15 RID: 253461 RVA: 0x011F5854 File Offset: 0x011F3A54
		private void CancelMontageSlot(SelfieMontageSlot slot, float blendOutTime = -1f)
		{
			slot.Token++;
			UAnimInstance animInstance = slot.AnimInstance;
			UAnimMontage montage = slot.Montage;
			if (montage != null && montage.IsValid())
			{
				if (animInstance != null && animInstance.IsValid())
				{
					blendOutTime = ((blendOutTime < 0f) ? montage.BlendOut.BlendTime : blendOutTime);
					animInstance.Montage_Stop(blendOutTime, montage);
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PhotoCamera;
					ELogAuthor author = ELogAuthor.ZJL;
					string message = "[Selfie] GameplayABP 实例已失效，蒙太奇可能未正常停止";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", slot.ConfigId);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			slot.Clear();
		}

		// Token: 0x0603DE16 RID: 253462 RVA: 0x011F58F0 File Offset: 0x011F3AF0
		private void CancelAllMontageSlots(float blendOutTime = -1f)
		{
			foreach (SelfieMontageSlot slot in this.MontageSlots.Values)
			{
				this.CancelMontageSlot(slot, blendOutTime);
			}
		}

		// Token: 0x0603DE17 RID: 253463 RVA: 0x011F594C File Offset: 0x011F3B4C
		public void Dispose()
		{
			this.LeaveSelfie();
		}

		// Token: 0x0603DE18 RID: 253464 RVA: 0x011F5954 File Offset: 0x011F3B54
		private void ApplyEnterState(float[] pitchLimit, float[] yawLimit, float moveSpeed)
		{
			if (!this.HadSelfieTag)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.AddTag(new int?(SelfieLogic.SELFIE_TAG_ID));
				}
			}
			this.AnimComp.EnableSightDirect = true;
			this.ApplySelfieSightLimit(pitchLimit, yawLimit);
			this.ApplySelfieClimbForbidden();
			this.ApplySelfieMoveSpeed(moveSpeed);
		}

		// Token: 0x0603DE19 RID: 253465 RVA: 0x011F59A8 File Offset: 0x011F3BA8
		private void RestoreState()
		{
			BaseMoveComponent moveComp = this.MoveComp;
			bool flag;
			if (moveComp == null)
			{
				flag = (null != null);
			}
			else
			{
				CharacterActorComponent actorComp = moveComp.ActorComp;
				flag = (((actorComp != null) ? actorComp.Owner : null) != null);
			}
			if (flag)
			{
				this.RestoreSelfieMoveSpeed();
			}
			this.RestoreSelfieClimbForbidden();
			if (!this.HadSelfieTag)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.RemoveTag(new int?(SelfieLogic.SELFIE_TAG_ID));
				}
			}
			if (this.AnimComp != null)
			{
				this.AnimComp.EnableSightDirect = this.LastEnableSightDirect;
				SelfieSightLimitSnapshot lastSightLimit = this.LastSightLimit;
				if (lastSightLimit == null)
				{
					return;
				}
				lastSightLimit.Restore(this.AnimComp);
			}
		}

		// Token: 0x0603DE1A RID: 253466 RVA: 0x011F5A34 File Offset: 0x011F3C34
		private void InitComponents(Entity entity)
		{
			this.Entity = entity;
			this.MoveComp = entity.GetComponent<BaseMoveComponent>();
			this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
			this.TagComp = entity.GetComponent<BaseTagComponent>();
		}

		// Token: 0x0603DE1B RID: 253467 RVA: 0x011F5A64 File Offset: 0x011F3C64
		private void SaveState()
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			this.LastEnableSightDirect = (animComp != null && animComp.EnableSightDirect);
			this.LastSightLimit = ((this.AnimComp != null) ? new SelfieSightLimitSnapshot(this.AnimComp) : null);
			BaseTagComponent tagComp = this.TagComp;
			this.HadSelfieTag = (tagComp != null && tagComp.HasTag(SelfieLogic.SELFIE_TAG_ID));
			BaseTagComponent tagComp2 = this.TagComp;
			this.HadForbiddenClimbTag = (tagComp2 != null && tagComp2.HasTag(SelfieLogic.SELFIE_FORBID_CLIMB_TAG_ID));
		}

		// Token: 0x0603DE1C RID: 253468 RVA: 0x011F5AE0 File Offset: 0x011F3CE0
		private bool EnsureSelfieMontageCache(string dtPath)
		{
			if (this.MontageCacheInited && this.MontageCachePath == dtPath)
			{
				return true;
			}
			UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>(dtPath, "js_undefined");
			if (udataTable == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[Selfie] 蒙太奇配置表加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", dtPath);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.UpperPerformMontageMap.Clear();
			this.FacePerformMontageMap.Clear();
			foreach (SSelfieMontage row in DataTableUtil.GetDataTableAllRowFromTable<SSelfieMontage>(udataTable))
			{
				this.CacheSelfieMontageRow(row);
			}
			this.MontageCachePath = dtPath;
			this.MontageCacheInited = true;
			return true;
		}

		// Token: 0x0603DE1D RID: 253469 RVA: 0x011F5BB0 File Offset: 0x011F3DB0
		private void CacheSelfieMontageRow(SSelfieMontage row)
		{
			Dictionary<int, SelfieMontageData> selfieMontageMap = this.GetSelfieMontageMap(row.MontageType);
			if (selfieMontageMap == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "[Selfie] 未支持的自拍蒙太奇类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MontageType", row.MontageType);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (selfieMontageMap.ContainsKey(row.ConfigId))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PhotoCamera;
				ELogAuthor author2 = ELogAuthor.ZJL;
				string message2 = "[Selfie] 重复的自拍蒙太奇配置";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ConfigId", row.ConfigId);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			selfieMontageMap[row.ConfigId] = new SelfieMontageData(row);
		}

		// Token: 0x0603DE1E RID: 253470 RVA: 0x011F5C5B File Offset: 0x011F3E5B
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, SelfieMontageData> GetSelfieMontageMap(ESelfieMontageType montageType)
		{
			if (montageType == ESelfieMontageType.UpperPerform)
			{
				return this.UpperPerformMontageMap;
			}
			if (montageType != ESelfieMontageType.FacePerform)
			{
				return null;
			}
			return this.FacePerformMontageMap;
		}

		// Token: 0x0603DE1F RID: 253471 RVA: 0x011F5C78 File Offset: 0x011F3E78
		private void ApplySelfieSightLimit(float[] pitchLimit, float[] yawLimit)
		{
			if (this.AnimComp == null || this.LastSightLimit == null)
			{
				return;
			}
			CharacterAnimationComponent animComp = this.AnimComp;
			UAnimInstance uanimInstance;
			if (animComp == null)
			{
				uanimInstance = null;
			}
			else
			{
				TsBaseCharacter actor = animComp.Actor;
				if (actor == null)
				{
					uanimInstance = null;
				}
				else
				{
					USkeletalMeshComponent mesh = actor.Mesh;
					uanimInstance = ((mesh != null) ? mesh.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY) : null);
				}
			}
			UAnimInstance uanimInstance2 = uanimInstance;
			if (uanimInstance2 == null || !UKuroStaticLibrary.IsObjectClassByName(uanimInstance2, SelfieLogic.SELFIE_ABP_CLASS_NAME))
			{
				this.LastSightLimit.ApplyLimit(this.AnimComp, pitchLimit, yawLimit, null, null);
				return;
			}
			this.LastSightLimit.ApplyLimit(this.AnimComp, pitchLimit, yawLimit, new FVector?((uanimInstance2 as ABP_BaseRole_Gameplay_Selfie_C).SightDirectInSightBone), new FVector?((uanimInstance2 as ABP_BaseRole_Gameplay_Selfie_C).UpAxisInSightBone));
		}

		// Token: 0x0603DE20 RID: 253472 RVA: 0x011F5D34 File Offset: 0x011F3F34
		private void ApplySelfieMoveSpeed(float moveSpeed)
		{
			if (moveSpeed <= 0f || this.MoveComp == null)
			{
				return;
			}
			this.HasOverrideMoveSpeed = true;
			this.MoveComp.SetOverrideMaxSpeed(moveSpeed);
		}

		// Token: 0x0603DE21 RID: 253473 RVA: 0x011F5D5C File Offset: 0x011F3F5C
		private void RestoreSelfieMoveSpeed()
		{
			if (!this.HasOverrideMoveSpeed)
			{
				return;
			}
			this.HasOverrideMoveSpeed = false;
			if (this.MoveComp == null)
			{
				return;
			}
			this.MoveComp.ResetOverrideMaxSpeed();
			BaseMoveComponent moveComp = this.MoveComp;
			Entity entity = this.Entity;
			ECharMoveState? newMoveState;
			if (entity == null)
			{
				newMoveState = null;
			}
			else
			{
				BaseUnifiedStateComponent component = entity.GetComponent<BaseUnifiedStateComponent>();
				newMoveState = ((component != null) ? new ECharMoveState?(component.MoveState) : null);
			}
			moveComp.ResetMaxSpeed(newMoveState);
		}

		// Token: 0x0603DE22 RID: 253474 RVA: 0x011F5DCB File Offset: 0x011F3FCB
		private void ApplySelfieClimbForbidden()
		{
			if (!this.HadForbiddenClimbTag)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null)
				{
					return;
				}
				tagComp.AddTag(new int?(SelfieLogic.SELFIE_FORBID_CLIMB_TAG_ID));
			}
		}

		// Token: 0x0603DE23 RID: 253475 RVA: 0x011F5DEF File Offset: 0x011F3FEF
		private void RestoreSelfieClimbForbidden()
		{
			if (!this.HadForbiddenClimbTag)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null)
				{
					return;
				}
				tagComp.RemoveTag(new int?(SelfieLogic.SELFIE_FORBID_CLIMB_TAG_ID));
			}
		}

		// Token: 0x0603DE24 RID: 253476 RVA: 0x011F5E14 File Offset: 0x011F4014
		[NullableContext(2)]
		private UAnimInstance GetGameplayAnimInstance()
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null)
			{
				return null;
			}
			TsBaseCharacter actor = animComp.Actor;
			if (actor == null)
			{
				return null;
			}
			USkeletalMeshComponent mesh = actor.Mesh;
			if (mesh == null)
			{
				return null;
			}
			return mesh.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_GAMEPLAY);
		}

		// Token: 0x0603DE25 RID: 253477 RVA: 0x011F5E48 File Offset: 0x011F4048
		private void ClearComponents()
		{
			this.Entity = null;
			this.MoveComp = null;
			this.AnimComp = null;
			this.TagComp = null;
			this.LastSightLimit = null;
			this.HadSelfieTag = false;
			this.HadForbiddenClimbTag = false;
			this.HasOverrideMoveSpeed = false;
			this.MontageSlots.Clear();
		}

		// Token: 0x0603DE26 RID: 253478 RVA: 0x011F5E98 File Offset: 0x011F4098
		private void DrawSightDebug(Vector cameraWorldLocation)
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
			UWorld world = GlobalData.World;
			if (uskeletalMeshComponent2 == null || world == null)
			{
				return;
			}
			Vector debugArrowStart = this.DebugArrowStart;
			FVectorDouble fvectorDouble = uskeletalMeshComponent2.D_GetSocketLocation(CharacterNameDefines.Instance.BIP_001_HEAD);
			debugArrowStart.FromUeVector(fvectorDouble);
			this.AnimComp.GetWorldSightDirect(this.DebugSightDir);
			this.DebugSightDir.MultiplyEqual(100.0);
			this.DebugArrowStart.Addition(this.DebugSightDir, this.DebugArrowEnd);
			UKismetSystemLibrary.D_DrawDebugArrow(world, this.DebugArrowStart.ToUeVector(false), this.DebugArrowEnd.ToUeVector(false), 20f, SelfieLogic.SelfieDebugSightColor, 0f, 2f);
			cameraWorldLocation.Subtraction(this.DebugArrowStart, this.DebugSightDir);
			this.DebugSightDir.Normalize(9.99999993922529E-09);
			this.DebugSightDir.MultiplyEqual(100.0);
			this.DebugArrowStart.Addition(this.DebugSightDir, this.DebugArrowEnd);
			UKismetSystemLibrary.D_DrawDebugArrow(world, this.DebugArrowStart.ToUeVector(false), this.DebugArrowEnd.ToUeVector(false), 20f, SelfieLogic.SelfieDebugCameraColor, 0f, 2f);
		}

		// Token: 0x04020DA8 RID: 134568
		public const string SELFIE_MONTAGE_DT_PATH = "/Game/Aki/Character/Role/Common/Data/DT/DT_SelfieMontageConfig.DT_SelfieMontageConfig";

		// Token: 0x04020DA9 RID: 134569
		[StaticVariableRuleIgnore]
		private static readonly int SELFIE_TAG_ID = GameplayTagDefine.EGameplayTagId["角色.Common.地区运动状态.自拍"];

		// Token: 0x04020DAA RID: 134570
		[StaticVariableRuleIgnore]
		private static readonly int SELFIE_FORBID_CLIMB_TAG_ID = GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止攀爬"];

		// Token: 0x04020DAB RID: 134571
		[StaticVariableRuleIgnore]
		public static readonly FName SELFIE_ABP_CLASS_NAME = new FName("ABP_BaseRole_Gameplay_Selfie_C");

		// Token: 0x04020DAC RID: 134572
		private const float SELFIE_DEBUG_ARROW_LENGTH = 100f;

		// Token: 0x04020DAD RID: 134573
		private const float SELFIE_DEBUG_ARROW_SIZE = 20f;

		// Token: 0x04020DAE RID: 134574
		private const float SELFIE_DEBUG_ARROW_THICKNESS = 2f;

		// Token: 0x04020DAF RID: 134575
		private const float SELFIE_DEBUG_IK_SPHERE_RADIUS = 4f;

		// Token: 0x04020DB0 RID: 134576
		private const int SELFIE_DEBUG_IK_SPHERE_SEGMENTS = 6;

		// Token: 0x04020DB1 RID: 134577
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor SelfieDebugSightColor = new FLinearColor(1f, 0f, 0f, 1f);

		// Token: 0x04020DB2 RID: 134578
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor SelfieDebugCameraColor = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x04020DB3 RID: 134579
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor SelfieDebugIkColor = new FLinearColor(0f, 0f, 1f, 1f);

		// Token: 0x04020DB4 RID: 134580
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x04020DB5 RID: 134581
		[Nullable(2)]
		private BaseMoveComponent MoveComp;

		// Token: 0x04020DB6 RID: 134582
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04020DB7 RID: 134583
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04020DB8 RID: 134584
		private readonly IkTarget LeftHandIkTarget = new IkTarget(null, null, null);

		// Token: 0x04020DB9 RID: 134585
		private readonly FIKTarget LeftHandIkTargetUe = new FIKTarget();

		// Token: 0x04020DBA RID: 134586
		private readonly Transform RootTransform = Transform.Create();

		// Token: 0x04020DBB RID: 134587
		private readonly Vector HandWorldTarget = Vector.Create();

		// Token: 0x04020DBC RID: 134588
		private readonly bool DebugDraw;

		// Token: 0x04020DBD RID: 134589
		private readonly bool DebugDrawIk;

		// Token: 0x04020DBE RID: 134590
		private readonly Vector DebugSightDir = Vector.Create();

		// Token: 0x04020DBF RID: 134591
		private readonly Vector DebugArrowStart = Vector.Create();

		// Token: 0x04020DC0 RID: 134592
		private readonly Vector DebugArrowEnd = Vector.Create();

		// Token: 0x04020DC1 RID: 134593
		private bool InState;

		// Token: 0x04020DC2 RID: 134594
		private bool LastEnableSightDirect;

		// Token: 0x04020DC3 RID: 134595
		[Nullable(2)]
		private SelfieSightLimitSnapshot LastSightLimit;

		// Token: 0x04020DC4 RID: 134596
		private bool HadSelfieTag;

		// Token: 0x04020DC5 RID: 134597
		private bool HadForbiddenClimbTag;

		// Token: 0x04020DC6 RID: 134598
		private bool HasOverrideMoveSpeed;

		// Token: 0x04020DC7 RID: 134599
		private readonly Dictionary<ESelfieMontageType, SelfieMontageSlot> MontageSlots = new Dictionary<ESelfieMontageType, SelfieMontageSlot>();

		// Token: 0x04020DC8 RID: 134600
		private string MontageCachePath = "";

		// Token: 0x04020DC9 RID: 134601
		private bool MontageCacheInited;

		// Token: 0x04020DCA RID: 134602
		private readonly Dictionary<int, SelfieMontageData> UpperPerformMontageMap = new Dictionary<int, SelfieMontageData>();

		// Token: 0x04020DCB RID: 134603
		private readonly Dictionary<int, SelfieMontageData> FacePerformMontageMap = new Dictionary<int, SelfieMontageData>();
	}
}
