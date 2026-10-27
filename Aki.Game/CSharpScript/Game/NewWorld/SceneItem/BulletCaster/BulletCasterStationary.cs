using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x02007230 RID: 29232
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletCasterStationary : BulletCasterCommon
	{
		// Token: 0x06047A56 RID: 293462 RVA: 0x0125502F File Offset: 0x0125322F
		public BulletCasterStationary(BulletCasterInitParam bulletCasterInitParam) : base(bulletCasterInitParam)
		{
		}

		// Token: 0x06047A57 RID: 293463 RVA: 0x01255038 File Offset: 0x01253238
		protected override void OnStart()
		{
		}

		// Token: 0x06047A58 RID: 293464 RVA: 0x0125503C File Offset: 0x0125323C
		protected unsafe override void SetEffectParam(int effectHandleId)
		{
			EffectParameterNiagara effectParameterNiagara = new EffectParameterNiagara();
			int num = 1;
			List<ValueTuple<FName, float>> list = new List<ValueTuple<FName, float>>(num);
			CollectionsMarshal.SetCount<ValueTuple<FName, float>>(list, num);
			Span<ValueTuple<FName, float>> span = CollectionsMarshal.AsSpan<ValueTuple<FName, float>>(list);
			int index = 0;
			*span[index] = new ValueTuple<FName, float>(FNameUtil.GetDynamicFName("radius").Value, (float)this.CasterConfig.WarningWidth);
			effectParameterNiagara.UserParameterFloat = list;
			EffectParameterNiagara parameter = effectParameterNiagara;
			EffectSystem.Instance.SetEffectParameterNiagara(effectHandleId, parameter);
		}

		// Token: 0x06047A59 RID: 293465 RVA: 0x012550AC File Offset: 0x012532AC
		protected override void StartImmediately()
		{
			int warningEffectHandle = base.PlayWarningEffect();
			if (EffectSystem.Instance.IsValid(warningEffectHandle))
			{
				this.WarningEffectHandles.Add(warningEffectHandle);
			}
			TimerHandle waitWarningTimer = null;
			waitWarningTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (EffectSystem.Instance.IsValid(warningEffectHandle))
				{
					EffectSystem.Instance.StopEffectById(warningEffectHandle, "[BulletCaster] WarnEnd", false, null);
				}
				this.WarningEffectHandles.Remove(warningEffectHandle);
				this.BulletWaitWarningTimers.Remove(waitWarningTimer);
				this.FireBullet();
			}, (float)this.CasterConfig.WarningTime, null, null, true, 1f);
			if (waitWarningTimer != null)
			{
				this.BulletWaitWarningTimers.Add(waitWarningTimer);
			}
			this.SetTimeDilationRespectOwnerEntity();
		}

		// Token: 0x06047A5A RID: 293466 RVA: 0x01255150 File Offset: 0x01253350
		private unsafe int FireBullet()
		{
			FTransformDouble actorTransform = this.OwnerEntity.GetComponent<BaseActorComponent>().ActorTransform;
			FTransformDouble ftransformDouble = this.CasterRelTransform.ToUeTransform();
			FTransformDouble value = ftransformDouble * actorTransform;
			EntityHandle sceneBulletOwner = BulletController.Instance.GetSceneBulletOwner();
			if (sceneBulletOwner == null || !sceneBulletOwner.IsInit)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "Bullet生成错误, 找场景子弹owner还未初始化";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OwnerEntityId", this.OwnerEntity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sceneBulletOwner", sceneBulletOwner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MovementType", EBatchBulletMovementType.Stationary);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return -1;
			}
			BulletEntity bulletEntity = BulletController.Instance.CreateBulletCustomTarget(sceneBulletOwner.Entity, this.CasterConfig.BulletType.ToString(), new FTransformDouble?(value), new BulletController.BulletCreateParams
			{
				InitTargetLocation = new FVectorDouble?(value.GetLocation())
			}, new long?(this.BulletContextId), EBulletCreateSource.Others);
			if (bulletEntity == null || !bulletEntity.Valid)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.XDW;
				string message2 = "Bullet生成错误";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("OwnerEntityId", this.OwnerEntity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("BulletContextId", this.BulletContextId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("MovementType", EBatchBulletMovementType.Stationary);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return -1;
			}
			int bulletId = bulletEntity.Id;
			BulletController.Instance.SetBulletSpeedRatio(bulletId, 0f);
			TimerHandle timerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.DestroyBulletTimers.Remove(bulletId);
				BulletController.Instance.DestroyBullet(bulletId, false, EBulletDestroyReason.Normal, false);
			}, (float)this.CasterConfig.FlyTime, null, null, true, 1f);
			if (timerHandle != null)
			{
				this.DestroyBulletTimers[bulletId] = timerHandle;
			}
			return bulletId;
		}

		// Token: 0x04025B1F RID: 154399
		private const string WARNING_EFFECT_USER_PARAM_NAME = "radius";
	}
}
