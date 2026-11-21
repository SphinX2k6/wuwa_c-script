using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform
{
	// Token: 0x02005B61 RID: 23393
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritEffectPerform : SunSpiritBasePerform, ISunSpiritScenePerform
	{
		// Token: 0x06039869 RID: 235625 RVA: 0x01026E94 File Offset: 0x01025094
		public SunSpiritEffectPerform(SunSpiritData sunSpiritData, Transform initTransform) : base(sunSpiritData)
		{
			this.InitTransform.Set(initTransform.GetLocation(), initTransform.GetRotation(), initTransform.GetScale3D());
		}

		// Token: 0x0603986A RID: 235626 RVA: 0x01026ED0 File Offset: 0x010250D0
		protected override bool OnInit()
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			this.EffectPath = ((instance != null) ? instance.GetSunSpiritConfig().FlyingEffectDaPath : null);
			return this.GenerateSunSpiritEffectOwner(this.InitTransform) && this.GenerateSunSpiritEffect();
		}

		// Token: 0x0603986B RID: 235627 RVA: 0x01026F04 File Offset: 0x01025104
		protected override void OnDestroy()
		{
			this.DestroySunSpiritEffect("SunSpiritEffectPerform.OnDestroy");
			this.DestroySunSpiritEffectOwner("SunSpiritEffectPerform.OnDestroy");
		}

		// Token: 0x0603986C RID: 235628 RVA: 0x01026F1C File Offset: 0x0102511C
		public bool GetTransform(Transform outTransform)
		{
			AActor effectOwner = this.EffectOwner;
			if (effectOwner == null || !effectOwner.IsValid())
			{
				return false;
			}
			FTransformDouble ftransformDouble = this.EffectOwner.D_GetTransform();
			outTransform.FromUeTransform(ftransformDouble);
			return true;
		}

		// Token: 0x0603986D RID: 235629 RVA: 0x01026F58 File Offset: 0x01025158
		[NullableContext(2)]
		public bool GetTransformData(Vector outLocation = null, object outRotation = null, Vector outScale = null)
		{
			AActor effectOwner = this.EffectOwner;
			if (effectOwner == null || !effectOwner.IsValid())
			{
				return false;
			}
			if (outLocation != null)
			{
				FVectorDouble fvectorDouble = this.EffectOwner.D_K2_GetActorLocation();
				outLocation.FromUeVector(fvectorDouble);
			}
			Quat quat = outRotation as Quat;
			if (quat != null)
			{
				quat.FromUeQuat(this.EffectOwner.K2_GetActorQuaternion());
			}
			else
			{
				Rotator rotator = outRotation as Rotator;
				if (rotator != null)
				{
					Rotator rotator2 = rotator;
					FRotator frotator = this.EffectOwner.K2_GetActorRotation();
					rotator2.FromUeRotator(frotator);
				}
			}
			if (outScale != null)
			{
				FVectorDouble fvectorDouble = this.EffectOwner.D_GetActorScale3D();
				outScale.FromUeVector(fvectorDouble);
			}
			return true;
		}

		// Token: 0x0603986E RID: 235630 RVA: 0x01026FE8 File Offset: 0x010251E8
		public bool SetTransform(Transform inTransform)
		{
			AActor effectOwner = this.EffectOwner;
			if (effectOwner == null || !effectOwner.IsValid())
			{
				return false;
			}
			AActor effectOwner2 = this.EffectOwner;
			FTransformDouble ftransformDouble = inTransform.ToUeTransform();
			effectOwner2.D_K2_SetActorTransform(ftransformDouble, false, null, true);
			return true;
		}

		// Token: 0x0603986F RID: 235631 RVA: 0x01027028 File Offset: 0x01025228
		[NullableContext(2)]
		public bool SetTransformData(Vector inLocation = null, object inRotation = null, Vector inScale = null)
		{
			AActor effectOwner = this.EffectOwner;
			if (effectOwner == null || !effectOwner.IsValid())
			{
				return false;
			}
			if (inLocation != null && inRotation != null && inScale != null)
			{
				Transform tempTransform = this.TempTransform;
				Quat quat = inRotation as Quat;
				tempTransform.Set(inLocation, (quat != null) ? quat : ((Rotator)inRotation).Quaternion(MathUtils.Instance.CommonTempQuat), inScale);
				AActor effectOwner2 = this.EffectOwner;
				FTransformDouble ftransformDouble = this.TempTransform.ToUeTransform();
				effectOwner2.D_K2_SetActorTransform(ftransformDouble, false, null, true);
			}
			else if (inLocation != null && inRotation != null)
			{
				AActor effectOwner3 = this.EffectOwner;
				FVectorDouble newLocation = inLocation.ToUeVector(false);
				Quat quat2 = inRotation as Quat;
				effectOwner3.D_K2_SetActorLocationAndRotation(newLocation, (quat2 != null) ? quat2.Rotator(MathUtils.Instance.CommonTempRotator).ToUeRotator() : ((Rotator)inRotation).ToUeRotator(), false, ref WorldGlobal.SweepHitResult, true);
			}
			else
			{
				if (inLocation != null)
				{
					this.EffectOwner.D_K2_SetActorLocation(inLocation.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, true);
				}
				Quat quat3 = inRotation as Quat;
				if (quat3 != null)
				{
					this.EffectOwner.K2_SetActorRotation(quat3.Rotator(MathUtils.Instance.CommonTempRotator).ToUeRotator(), false);
				}
				else
				{
					Rotator rotator = inRotation as Rotator;
					if (rotator != null)
					{
						this.EffectOwner.K2_SetActorRotation(rotator.ToUeRotator(), false);
					}
				}
				if (inScale != null)
				{
					this.EffectOwner.D_SetActorScale3D(inScale.ToUeVector(false));
				}
			}
			return true;
		}

		// Token: 0x06039870 RID: 235632 RVA: 0x0102717C File Offset: 0x0102537C
		[NullableContext(2)]
		private bool GenerateSunSpiritEffectOwner(Transform transform = null)
		{
			AActor effectOwner = this.EffectOwner;
			if (effectOwner != null && effectOwner.IsValid())
			{
				return true;
			}
			AActor aactor = ActorSystem.Instance.Get(AActor.StaticClass(), (transform != null) ? transform.ToUeTransform() : FTransformDouble.Identity, null, true);
			if (aactor == null)
			{
				return false;
			}
			if (aactor.GetComponentByClass(USceneComponent.StaticClass()) == null)
			{
				aactor.AddComponentByClass(USceneComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName));
			}
			if (transform != null)
			{
				AActor actor = aactor;
				FTransformDouble ftransformDouble = transform.ToUeTransform();
				actor.D_K2_SetActorTransform(ftransformDouble, false, null, true);
			}
			this.EffectOwner = aactor;
			return true;
		}

		// Token: 0x06039871 RID: 235633 RVA: 0x0102721C File Offset: 0x0102541C
		private void DestroySunSpiritEffectOwner(string reason)
		{
			AActor effectOwner = this.EffectOwner;
			if (effectOwner != null && effectOwner.IsValid())
			{
				ActorSystem.Instance.Put(reason, this.EffectOwner, null);
			}
			this.EffectOwner = null;
		}

		// Token: 0x06039872 RID: 235634 RVA: 0x0102724C File Offset: 0x0102544C
		private bool GenerateSunSpiritEffect()
		{
			AActor effectOwner = this.EffectOwner;
			if (effectOwner == null || !effectOwner.IsValid())
			{
				return false;
			}
			if (this.EffectPath == null || this.EffectPath.Length <= 0)
			{
				return false;
			}
			if (this.FlyingEffectHandle == 0 || !EffectSystem.Instance.IsValid(this.FlyingEffectHandle))
			{
				EffectSystem instance = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
				this.FlyingEffectHandle = instance.SpawnEffect(world, ftransformDouble, this.EffectPath, "SunSpiritEffectPerform", new EffectContext(null, this.EffectOwner, false), EEffectType.Scene, null, null, null, false, false);
			}
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.FlyingEffectHandle);
			if (!effectActor.HasValue)
			{
				return false;
			}
			OneOf<KuroEffectActorHandle, AActor> self = effectActor;
			AActor effectOwner2 = this.EffectOwner;
			FName? fname = null;
			self.K2_AttachToActor(effectOwner2, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
			return true;
		}

		// Token: 0x06039873 RID: 235635 RVA: 0x01027328 File Offset: 0x01025528
		private void DestroySunSpiritEffect(string reason)
		{
			if (this.FlyingEffectHandle != 0 && EffectSystem.Instance.IsValid(this.FlyingEffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.FlyingEffectHandle, reason, false, null);
			}
			this.FlyingEffectHandle = 0;
		}

		// Token: 0x0401E5C8 RID: 124360
		[Nullable(2)]
		private AActor EffectOwner;

		// Token: 0x0401E5C9 RID: 124361
		private int FlyingEffectHandle;

		// Token: 0x0401E5CA RID: 124362
		[Nullable(2)]
		private string EffectPath;

		// Token: 0x0401E5CB RID: 124363
		private readonly Transform InitTransform = Transform.Create();

		// Token: 0x0401E5CC RID: 124364
		private readonly Transform TempTransform = Transform.Create();
	}
}
