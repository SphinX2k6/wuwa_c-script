using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x0200722F RID: 29231
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletCasterSprint : BulletCasterCommon
	{
		// Token: 0x06047A52 RID: 293458 RVA: 0x01254C79 File Offset: 0x01252E79
		public BulletCasterSprint(BulletCasterInitParam bulletCasterInitParam) : base(bulletCasterInitParam)
		{
		}

		// Token: 0x06047A53 RID: 293459 RVA: 0x01254C82 File Offset: 0x01252E82
		protected override void OnStart()
		{
		}

		// Token: 0x06047A54 RID: 293460 RVA: 0x01254C84 File Offset: 0x01252E84
		protected override void StartImmediately()
		{
			if (this.CasterConfig.FlyTime < 20)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "Bullet飞行时间<=0";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("OwnerEntityId", this.OwnerEntity.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			FTransformDouble actorTransform = this.OwnerEntity.GetComponent<BaseActorComponent>().ActorTransform;
			FTransformDouble ftransformDouble = this.CasterRelTransform.ToUeTransform();
			FTransformDouble value = ftransformDouble * actorTransform;
			Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			this.CasterRelTransform.GetRotation().GetForwardVector(commonTempVector).GetSafeNormal(commonTempVector, 1E-08);
			commonTempVector.MultiplyEqual((double)this.CasterConfig.FlyDistance);
			FVectorDouble fvectorDouble = commonTempVector.ToUeVector(false);
			FVectorDouble fvectorDouble2 = actorTransform.TransformVector(fvectorDouble);
			EntityHandle sceneBulletOwner = BulletController.Instance.GetSceneBulletOwner();
			if (sceneBulletOwner == null || !sceneBulletOwner.IsInit)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "Bullet生成错误, 找不到场景子弹owner";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("OwnerEntityId", this.OwnerEntity.Id);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			fvectorDouble = value.GetLocation();
			FVectorDouble value2 = fvectorDouble + fvectorDouble2;
			BulletEntity bulletEntity = BulletController.Instance.CreateBulletCustomTarget(sceneBulletOwner.Entity, this.CasterConfig.BulletType.ToString(), new FTransformDouble?(value), new BulletController.BulletCreateParams
			{
				InitTargetLocation = new FVectorDouble?(value2)
			}, new long?(this.BulletContextId), EBulletCreateSource.Others);
			if (bulletEntity == null || !bulletEntity.Valid)
			{
				return;
			}
			int bulletId = bulletEntity.Id;
			TimerHandle timerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.DestroyBulletTimers.Remove(bulletId);
				BulletController.Instance.DestroyBullet(bulletId, false, EBulletDestroyReason.Normal, false);
			}, (float)(this.CasterConfig.WarningTime + this.CasterConfig.FlyTime), null, null, true, 1f);
			if (timerHandle != null)
			{
				this.DestroyBulletTimers[bulletId] = timerHandle;
			}
			float bulletSpeed = (float)this.CasterConfig.FlyDistance / ((float)this.CasterConfig.FlyTime * 0.001f);
			if (this.CasterConfig.WarningTime < 20)
			{
				BulletController.Instance.SetBulletSpeedRatio(bulletId, bulletSpeed);
			}
			else
			{
				int warningEffectHandle = base.PlayWarningEffect();
				if (EffectSystem.Instance.IsValid(warningEffectHandle))
				{
					this.WarningEffectHandles.Add(warningEffectHandle);
				}
				BulletController.Instance.SetBulletSpeedRatio(bulletId, 0f);
				TimerHandle waitWarningTimer = null;
				waitWarningTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					if (EffectSystem.Instance.IsValid(warningEffectHandle))
					{
						EffectSystem.Instance.StopEffectById(warningEffectHandle, "[BulletCaster] WarnEnd", false, null);
					}
					this.WarningEffectHandles.Remove(warningEffectHandle);
					this.BulletWaitWarningTimers.Remove(waitWarningTimer);
					BulletController.Instance.SetBulletSpeedRatio(bulletId, bulletSpeed);
				}, (float)this.CasterConfig.WarningTime, null, null, true, 1f);
				if (waitWarningTimer != null)
				{
					this.BulletWaitWarningTimers.Add(waitWarningTimer);
				}
			}
			this.SetTimeDilationRespectOwnerEntity();
		}

		// Token: 0x06047A55 RID: 293461 RVA: 0x01254F8C File Offset: 0x0125318C
		protected unsafe override void SetEffectParam(int effectHandleId)
		{
			EffectParameterNiagara effectParameterNiagara = new EffectParameterNiagara();
			int num = 2;
			List<ValueTuple<FName, float>> list = new List<ValueTuple<FName, float>>(num);
			CollectionsMarshal.SetCount<ValueTuple<FName, float>>(list, num);
			Span<ValueTuple<FName, float>> span = CollectionsMarshal.AsSpan<ValueTuple<FName, float>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("length").Value, (float)this.CasterConfig.FlyDistance);
			num2++;
			*span[num2] = new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("width").Value, (float)this.CasterConfig.WarningWidth);
			effectParameterNiagara.UserParameterFloat = list;
			EffectParameterNiagara parameter = effectParameterNiagara;
			EffectSystem.Instance.SetEffectParameterNiagara(effectHandleId, parameter);
		}

		// Token: 0x04025B1D RID: 154397
		private const string WARNING_EFFECT_LENGTH_KEY = "length";

		// Token: 0x04025B1E RID: 154398
		private const string WARNING_EFFECT_WIDTH_KEY = "width";
	}
}
