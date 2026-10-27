using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform
{
	// Token: 0x02006A04 RID: 27140
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritEffectPerform : SunSpiritBasePerform, ISunSpiritScenePerform
	{
		// Token: 0x0604381D RID: 276509 RVA: 0x01082870 File Offset: 0x01080A70
		public SunSpiritEffectPerform(SunSpiritData sunSpiritData, Transform initTransform) : base(sunSpiritData)
		{
			this.InitTransform.Set(initTransform.GetLocation(), initTransform.GetRotation(), initTransform.GetScale3D());
		}

		// Token: 0x0604381E RID: 276510 RVA: 0x010828AC File Offset: 0x01080AAC
		protected override bool OnInit()
		{
			SunSpiritModel instance = SunSpiritModel.Instance;
			this.EffectPath = ((instance != null) ? instance.GetSunSpiritConfig().FlyingEffectDaPath : null);
			return this.GenerateSunSpiritEffectOwner(this.InitTransform) && this.GenerateSunSpiritEffect();
		}

		// Token: 0x0604381F RID: 276511 RVA: 0x010828E0 File Offset: 0x01080AE0
		protected override void OnDestroy()
		{
			this.DestroySunSpiritEffect("SunSpiritEffectPerform.OnDestroy");
			this.DestroySunSpiritEffectOwner("SunSpiritEffectPerform.OnDestroy");
		}

		// Token: 0x06043820 RID: 276512 RVA: 0x010828F8 File Offset: 0x01080AF8
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

		// Token: 0x06043821 RID: 276513 RVA: 0x01082934 File Offset: 0x01080B34
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

		// Token: 0x06043822 RID: 276514 RVA: 0x010829C4 File Offset: 0x01080BC4
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

		// Token: 0x06043823 RID: 276515 RVA: 0x01082A04 File Offset: 0x01080C04
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

		// Token: 0x06043824 RID: 276516 RVA: 0x01082B58 File Offset: 0x01080D58
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

		// Token: 0x06043825 RID: 276517 RVA: 0x01082BF8 File Offset: 0x01080DF8
		private void DestroySunSpiritEffectOwner(string reason)
		{
			AActor effectOwner = this.EffectOwner;
			if (effectOwner != null && effectOwner.IsValid())
			{
				ActorSystem.Instance.Put(reason, this.EffectOwner, null);
			}
			this.EffectOwner = null;
		}

		// Token: 0x06043826 RID: 276518 RVA: 0x01082C28 File Offset: 0x01080E28
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

		// Token: 0x06043827 RID: 276519 RVA: 0x01082D04 File Offset: 0x01080F04
		private void DestroySunSpiritEffect(string reason)
		{
			if (this.FlyingEffectHandle != 0 && EffectSystem.Instance.IsValid(this.FlyingEffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.FlyingEffectHandle, reason, false, null);
			}
			this.FlyingEffectHandle = 0;
		}

		// Token: 0x040233D6 RID: 144342
		[Nullable(2)]
		private AActor EffectOwner;

		// Token: 0x040233D7 RID: 144343
		private int FlyingEffectHandle;

		// Token: 0x040233D8 RID: 144344
		[Nullable(2)]
		private string EffectPath;

		// Token: 0x040233D9 RID: 144345
		private readonly Transform InitTransform = Transform.Create();

		// Token: 0x040233DA RID: 144346
		private readonly Transform TempTransform = Transform.Create();
	}
}
