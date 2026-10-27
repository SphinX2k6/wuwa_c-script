using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie
{
	// Token: 0x02007103 RID: 28931
	[NullableContext(1)]
	[Nullable(0)]
	public class SelfieLogic
	{
		// Token: 0x06046A09 RID: 289289 RVA: 0x011C61FC File Offset: 0x011C43FC
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

		// Token: 0x06046A0A RID: 289290 RVA: 0x011C62CC File Offset: 0x011C44CC
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

		// Token: 0x06046A0B RID: 289291 RVA: 0x011C635D File Offset: 0x011C455D
		public bool IsInSelfie()
		{
			return this.InState;
		}

		// Token: 0x06046A0C RID: 289292 RVA: 0x011C6365 File Offset: 0x011C4565
		public void UpdateSelfieSightLimit(float[] pitchLimit, float[] yawLimit)
		{
			if (!this.InState || this.AnimComp == null || this.LastSightLimit == null)
			{
				return;
			}
			this.ApplySelfieSightLimit(pitchLimit, yawLimit);
		}

		// Token: 0x06046A0D RID: 289293 RVA: 0x011C6388 File Offset: 0x011C4588
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

		// Token: 0x06046A0E RID: 289294 RVA: 0x011C63B4 File Offset: 0x011C45B4
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

		// Token: 0x06046A0F RID: 289295 RVA: 0x011C6560 File Offset: 0x011C4760
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

		// Token: 0x06046A10 RID: 289296 RVA: 0x011C65C5 File Offset: 0x011C47C5
		public void ClearSight()
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null)
			{
				return;
			}
			animComp.ClearSelfieCameraWorldLocation();
		}

		// Token: 0x06046A11 RID: 289297 RVA: 0x011C65D8 File Offset: 0x011C47D8
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

		// Token: 0x06046A12 RID: 289298 RVA: 0x011C6744 File Offset: 0x011C4944
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

		// Token: 0x06046A13 RID: 289299 RVA: 0x011C6774 File Offset: 0x011C4974
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

		// Token: 0x06046A14 RID: 289300 RVA: 0x011C67D8 File Offset: 0x011C49D8
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

		// Token: 0x06046A15 RID: 289301 RVA: 0x011C6800 File Offset: 0x011C4A00
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

		// Token: 0x06046A16 RID: 289302 RVA: 0x011C6834 File Offset: 0x011C4A34
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

		// Token: 0x06046A17 RID: 289303 RVA: 0x011C68D0 File Offset: 0x011C4AD0
		private void CancelAllMontageSlots(float blendOutTime = -1f)
		{
			foreach (SelfieMontageSlot slot in this.MontageSlots.Values)
			{
				this.CancelMontageSlot(slot, blendOutTime);
			}
		}

		// Token: 0x06046A18 RID: 289304 RVA: 0x011C692C File Offset: 0x011C4B2C
		public void Dispose()
		{
			this.LeaveSelfie();
		}

		// Token: 0x06046A19 RID: 289305 RVA: 0x011C6934 File Offset: 0x011C4B34
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

		// Token: 0x06046A1A RID: 289306 RVA: 0x011C6988 File Offset: 0x011C4B88
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

		// Token: 0x06046A1B RID: 289307 RVA: 0x011C6A14 File Offset: 0x011C4C14
		private void InitComponents(Entity entity)
		{
			this.Entity = entity;
			this.MoveComp = entity.GetComponent<BaseMoveComponent>();
			this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
			this.TagComp = entity.GetComponent<BaseTagComponent>();
		}

		// Token: 0x06046A1C RID: 289308 RVA: 0x011C6A44 File Offset: 0x011C4C44
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

		// Token: 0x06046A1D RID: 289309 RVA: 0x011C6AC0 File Offset: 0x011C4CC0
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

		// Token: 0x06046A1E RID: 289310 RVA: 0x011C6B90 File Offset: 0x011C4D90
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

		// Token: 0x06046A1F RID: 289311 RVA: 0x011C6C3B File Offset: 0x011C4E3B
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

		// Token: 0x06046A20 RID: 289312 RVA: 0x011C6C58 File Offset: 0x011C4E58
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

		// Token: 0x06046A21 RID: 289313 RVA: 0x011C6D14 File Offset: 0x011C4F14
		private void ApplySelfieMoveSpeed(float moveSpeed)
		{
			if (moveSpeed <= 0f || this.MoveComp == null)
			{
				return;
			}
			this.HasOverrideMoveSpeed = true;
			this.MoveComp.SetOverrideMaxSpeed(moveSpeed);
		}

		// Token: 0x06046A22 RID: 289314 RVA: 0x011C6D3C File Offset: 0x011C4F3C
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

		// Token: 0x06046A23 RID: 289315 RVA: 0x011C6DAB File Offset: 0x011C4FAB
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

		// Token: 0x06046A24 RID: 289316 RVA: 0x011C6DCF File Offset: 0x011C4FCF
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

		// Token: 0x06046A25 RID: 289317 RVA: 0x011C6DF4 File Offset: 0x011C4FF4
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

		// Token: 0x06046A26 RID: 289318 RVA: 0x011C6E28 File Offset: 0x011C5028
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

		// Token: 0x06046A27 RID: 289319 RVA: 0x011C6E78 File Offset: 0x011C5078
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

		// Token: 0x04025113 RID: 151827
		public const string SELFIE_MONTAGE_DT_PATH = "/Game/Aki/Character/Role/Common/Data/DT/DT_SelfieMontageConfig.DT_SelfieMontageConfig";

		// Token: 0x04025114 RID: 151828
		[StaticVariableRuleIgnore]
		private static readonly int SELFIE_TAG_ID = GameplayTagDefine.EGameplayTagId["角色.Common.地区运动状态.自拍"];

		// Token: 0x04025115 RID: 151829
		[StaticVariableRuleIgnore]
		private static readonly int SELFIE_FORBID_CLIMB_TAG_ID = GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止攀爬"];

		// Token: 0x04025116 RID: 151830
		[StaticVariableRuleIgnore]
		public static readonly FName SELFIE_ABP_CLASS_NAME = new FName("ABP_BaseRole_Gameplay_Selfie_C");

		// Token: 0x04025117 RID: 151831
		private const float SELFIE_DEBUG_ARROW_LENGTH = 100f;

		// Token: 0x04025118 RID: 151832
		private const float SELFIE_DEBUG_ARROW_SIZE = 20f;

		// Token: 0x04025119 RID: 151833
		private const float SELFIE_DEBUG_ARROW_THICKNESS = 2f;

		// Token: 0x0402511A RID: 151834
		private const float SELFIE_DEBUG_IK_SPHERE_RADIUS = 4f;

		// Token: 0x0402511B RID: 151835
		private const int SELFIE_DEBUG_IK_SPHERE_SEGMENTS = 6;

		// Token: 0x0402511C RID: 151836
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor SelfieDebugSightColor = new FLinearColor(1f, 0f, 0f, 1f);

		// Token: 0x0402511D RID: 151837
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor SelfieDebugCameraColor = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x0402511E RID: 151838
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor SelfieDebugIkColor = new FLinearColor(0f, 0f, 1f, 1f);

		// Token: 0x0402511F RID: 151839
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x04025120 RID: 151840
		[Nullable(2)]
		private BaseMoveComponent MoveComp;

		// Token: 0x04025121 RID: 151841
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04025122 RID: 151842
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04025123 RID: 151843
		private readonly IkTarget LeftHandIkTarget = new IkTarget(null, null, null);

		// Token: 0x04025124 RID: 151844
		private readonly FIKTarget LeftHandIkTargetUe = new FIKTarget();

		// Token: 0x04025125 RID: 151845
		private readonly Transform RootTransform = Transform.Create();

		// Token: 0x04025126 RID: 151846
		private readonly Vector HandWorldTarget = Vector.Create();

		// Token: 0x04025127 RID: 151847
		private readonly bool DebugDraw;

		// Token: 0x04025128 RID: 151848
		private readonly bool DebugDrawIk;

		// Token: 0x04025129 RID: 151849
		private readonly Vector DebugSightDir = Vector.Create();

		// Token: 0x0402512A RID: 151850
		private readonly Vector DebugArrowStart = Vector.Create();

		// Token: 0x0402512B RID: 151851
		private readonly Vector DebugArrowEnd = Vector.Create();

		// Token: 0x0402512C RID: 151852
		private bool InState;

		// Token: 0x0402512D RID: 151853
		private bool LastEnableSightDirect;

		// Token: 0x0402512E RID: 151854
		[Nullable(2)]
		private SelfieSightLimitSnapshot LastSightLimit;

		// Token: 0x0402512F RID: 151855
		private bool HadSelfieTag;

		// Token: 0x04025130 RID: 151856
		private bool HadForbiddenClimbTag;

		// Token: 0x04025131 RID: 151857
		private bool HasOverrideMoveSpeed;

		// Token: 0x04025132 RID: 151858
		private readonly Dictionary<ESelfieMontageType, SelfieMontageSlot> MontageSlots = new Dictionary<ESelfieMontageType, SelfieMontageSlot>();

		// Token: 0x04025133 RID: 151859
		private string MontageCachePath = "";

		// Token: 0x04025134 RID: 151860
		private bool MontageCacheInited;

		// Token: 0x04025135 RID: 151861
		private readonly Dictionary<int, SelfieMontageData> UpperPerformMontageMap = new Dictionary<int, SelfieMontageData>();

		// Token: 0x04025136 RID: 151862
		private readonly Dictionary<int, SelfieMontageData> FacePerformMontageMap = new Dictionary<int, SelfieMontageData>();
	}
}
