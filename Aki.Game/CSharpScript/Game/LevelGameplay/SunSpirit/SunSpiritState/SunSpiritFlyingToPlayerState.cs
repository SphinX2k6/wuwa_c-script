using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x02005B5A RID: 23386
	[NullableContext(2)]
	[Nullable(0)]
	public class SunSpiritFlyingToPlayerState : SunSpiritFlyingEffectState
	{
		// Token: 0x0603983F RID: 235583 RVA: 0x01025C17 File Offset: 0x01023E17
		[NullableContext(1)]
		public SunSpiritFlyingToPlayerState(SunSpiritData sunSpiritData, float waitBeforeFlyDuration, float flyingDuration, int gearConfigId, int gearSocketIndex, [Nullable(2)] Action flyingEndCallback) : base(ESunSpiritStateType.FlyingToPlayer, sunSpiritData, waitBeforeFlyDuration, flyingDuration)
		{
			this.GearConfigId = gearConfigId;
			this.GearSocketIndex = gearSocketIndex;
			this.FlyingFinishCallback = flyingEndCallback;
			this.FlyingInterruptCallback = flyingEndCallback;
			this.FlyingTargetGetter = delegate(Vector outPos, Quat outRot)
			{
				if (!this.CheckFlyingTargetCacheNotExpired())
				{
					this.UpdateFlyingTargetCache();
				}
				if (this.FlyingTargetPosCache == null || this.FlyingTargetRotCache == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SunSpirit;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "日灵: SunSpiritFlyingToPlayerState.FlyingTargetGetter缓存的目标位置为空";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigId", this.SunSpiritData.ConfigId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				outPos.DeepCopy(this.FlyingTargetPosCache);
				outRot.DeepCopy(this.FlyingTargetRotCache);
				return true;
			};
		}

		// Token: 0x06039840 RID: 235584 RVA: 0x01025C58 File Offset: 0x01023E58
		private bool CheckFlyingTargetCacheNotExpired()
		{
			if (this.FlyingTargetPosCache == null || this.FlyingTargetRotCache == null)
			{
				return false;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (characterActorComponent == null)
			{
				return false;
			}
			if (this.FlyingTargetPosCache.IsZero() || characterActorComponent.ActorLocationProxy.IsZero())
			{
				return false;
			}
			if (MathUtils.Instance.VectorDistanceSquared(this.FlyingTargetPosCache, characterActorComponent.ActorLocationProxy) > (double)this.MaxOffsetSquaredForReQueryTargetLoc)
			{
				return false;
			}
			UKuroCrowdAiSubsystem crowdAiSubsystem = CrowdAiController.Instance.CrowdAiSubsystem;
			SunSpiritModel instance = SunSpiritModel.Instance;
			SunSpiritConfig sunSpiritConfig = (instance != null) ? instance.GetSunSpiritConfig() : null;
			if (crowdAiSubsystem != null && sunSpiritConfig != null)
			{
				UKuroCrowdAiSubsystem ukuroCrowdAiSubsystem = crowdAiSubsystem;
				FVector fvector = this.FlyingTargetPosCache.ToUeVectorOld();
				if (ukuroCrowdAiSubsystem.QueryUsablePositionForBoid(fvector, 0f, sunSpiritConfig.AroundPlayerPosQueryBoidRadius, 1).IsZero())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06039841 RID: 235585 RVA: 0x01025D1C File Offset: 0x01023F1C
		private unsafe void UpdateFlyingTargetCache()
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			SunSpiritConfig sunSpiritConfig = (instance != null) ? instance.GetSunSpiritConfig() : null;
			if (sunSpiritConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: SunSpiritFlyingToPlayerState.UpdateFlyingTargetCache 更新目标位置失败，配置获取失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigId", this.SunSpiritData.ConfigId);
				instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.FlyingTargetPosCache = null;
				this.FlyingTargetRotCache = null;
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (characterActorComponent == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SunSpirit;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "日灵: SunSpiritFlyingToPlayerState.UpdateFlyingTargetCache 更新目标位置失败，找不到目标角色";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("SpiritConfigId", this.SunSpiritData.ConfigId);
				instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.FlyingTargetPosCache = null;
				this.FlyingTargetRotCache = null;
				return;
			}
			UKuroCrowdAiSubsystem crowdAiSubsystem = CrowdAiController.Instance.CrowdAiSubsystem;
			if (crowdAiSubsystem != null)
			{
				UKuroCrowdAiSubsystem ukuroCrowdAiSubsystem = crowdAiSubsystem;
				FVector fvector = characterActorComponent.ActorLocationProxy.ToUeVectorOld();
				FVector fvector2 = ukuroCrowdAiSubsystem.QueryUsablePositionForBoid(fvector, sunSpiritConfig.AroundPlayerPosQueryRadius, sunSpiritConfig.AroundPlayerPosQueryBoidRadius, sunSpiritConfig.AroundPlayerPosQueryMaxTryCount);
				if (!fvector2.IsZero())
				{
					if (this.FlyingTargetPosCache == null || this.FlyingTargetRotCache == null)
					{
						this.FlyingTargetPosCache = Vector.Create();
						this.FlyingTargetRotCache = Quat.Create(0.0, 0.0, 0.0, 1.0);
					}
					Vector flyingTargetPosCache = this.FlyingTargetPosCache;
					FVectorDouble fvectorDouble = fvector2;
					flyingTargetPosCache.DeepCopy(fvectorDouble);
					this.FlyingTargetRotCache.FromUeQuat(characterActorComponent.ActorQuatProxy);
					return;
				}
			}
			Log instance4 = Log.Instance;
			ELogModule module3 = ELogModule.SunSpirit;
			ELogAuthor author3 = ELogAuthor.ZYL;
			string message3 = "日灵: SunSpiritFlyingToPlayerState.UpdateFlyingTargetCache 查找角色附近的可用位置失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SpiritConfigId", this.SunSpiritData.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetLocation", characterActorComponent.ActorLocationProxy);
			instance4.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.FlyingTargetPosCache = null;
			this.FlyingTargetRotCache = null;
		}

		// Token: 0x06039842 RID: 235586 RVA: 0x01025F10 File Offset: 0x01024110
		protected override void OnSunSpiritFlyToTargetEnd(bool bKeepEffect = false, bool bIsInterrupt = false)
		{
			base.OnSunSpiritFlyToTargetEnd(bKeepEffect, bIsInterrupt);
			this.SunSpiritData.StopAllAndSetNextSunSpiritState(new SunSpiritOccupiedByPlayerState(this.SunSpiritData), false);
		}

		// Token: 0x06039843 RID: 235587 RVA: 0x01025F34 File Offset: 0x01024134
		protected override bool OnEnter()
		{
			base.OnEnter();
			SunSpiritModel instance = SunSpiritModel.Instance;
			SunSpiritConfig sunSpiritConfig = (instance != null) ? instance.GetSunSpiritConfig() : null;
			if (sunSpiritConfig == null)
			{
				return false;
			}
			this.MaxOffsetSquaredForReQueryTargetLoc = sunSpiritConfig.FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc * sunSpiritConfig.FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc;
			if (this.SunSpiritData.Transform == null || this.SunSpiritData.Transform.GetLocation().IsZero())
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: SunSpiritFlyingToPlayerState.OnEnter 找不到已有位置，重设飞行起点";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigId", this.SunSpiritData.ConfigId);
				instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				Vector vector = Vector.Create();
				Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
				CreatureModel instance3 = CreatureModel.Instance;
				object obj;
				if (instance3 == null)
				{
					obj = null;
				}
				else
				{
					EntityHandle entityByPbDataId = instance3.GetEntityByPbDataId(this.GearConfigId);
					if (entityByPbDataId == null)
					{
						obj = null;
					}
					else
					{
						WorldEntity entity = entityByPbDataId.Entity;
						obj = ((entity != null) ? entity.GetComponent<SceneItemSunSpiritGearComponent>() : null);
					}
				}
				object obj2 = obj;
				if (obj2 == null || !obj2.GetSunSpiritSocketLocAndRot(this.GearSocketIndex, vector, quat))
				{
					Log instance4 = Log.Instance;
					ELogModule module2 = ELogModule.SunSpirit;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "日灵: SunSpiritFlyingToPlayerState.OnEnter 重设飞行起点位置失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("SpiritConfigId", this.SunSpiritData.ConfigId);
					instance4.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return false;
				}
				this.SunSpiritData.SetLocationAndRotation(vector, quat);
			}
			return true;
		}

		// Token: 0x17006D71 RID: 28017
		// (get) Token: 0x06039844 RID: 235588 RVA: 0x01026095 File Offset: 0x01024295
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401E5BA RID: 124346
		private float MaxOffsetSquaredForReQueryTargetLoc;

		// Token: 0x0401E5BB RID: 124347
		public readonly int GearConfigId;

		// Token: 0x0401E5BC RID: 124348
		public readonly int GearSocketIndex;

		// Token: 0x0401E5BD RID: 124349
		private Vector FlyingTargetPosCache;

		// Token: 0x0401E5BE RID: 124350
		private Quat FlyingTargetRotCache;
	}
}
