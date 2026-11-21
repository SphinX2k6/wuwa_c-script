using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Character.Role.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C3B RID: 15419
	[NullableContext(1)]
	[Nullable(0)]
	public class SeamlessTravelKeepKite
	{
		// Token: 0x1700509F RID: 20639
		// (get) Token: 0x060277E7 RID: 161767 RVA: 0x00B131D5 File Offset: 0x00B113D5
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x170050A0 RID: 20640
		// (get) Token: 0x060277E8 RID: 161768 RVA: 0x00B131DD File Offset: 0x00B113DD
		public bool IsActive
		{
			get
			{
				return this.IsActiveInternal;
			}
		}

		// Token: 0x060277E9 RID: 161769 RVA: 0x00B131E8 File Offset: 0x00B113E8
		public void Init(SeamlessTravelContext context, [Nullable(2)] Action<bool> callback = null)
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepKite] 初始化KeepKite(开始)", default(ReadOnlySpan<ValueTuple<string, object>>));
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			this.ActorComp = ((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null);
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[无缝传送KeepKite] 初始化失败，无效的ActorComp";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (this.IsInit)
			{
				if (callback != null)
				{
					callback(true);
				}
				return;
			}
			this.Context = context;
			if (this.Context == null)
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			this.BeamEffectPath = "/Game/Aki/Effect/Niagara/NI_Common/NS_Fx_Hook_Beam1.NS_Fx_Hook_Beam1";
			this.BallEffectPath = "/Game/Aki/Effect/Niagara/NI_Common/NS_Fx_Hook_Maodian.NS_Fx_Hook_Maodian";
			this.BeamOwnerSocketName = "Bip001LHand";
			this.InitCallback = callback;
			USkeletalMesh kiteMeshAsset = this.KiteMeshAsset;
			if (kiteMeshAsset == null || !kiteMeshAsset.IsValid())
			{
				ResourceSystem.Instance.LoadAsync<USkeletalMesh>("/Game/Aki/Character/NPC/AlienNPC/Level_C/SC1Fengzheng/Model/SC1Fengzheng.SC1Fengzheng", delegate([Nullable(2)] USkeletalMesh asset, string _)
				{
					if (asset == null || !asset.IsValid())
					{
						this.FailInit();
						return;
					}
					this.KiteMeshAsset = asset;
					this.CheckInitLoadFinish();
				}, 100, "SeamlessTravel");
			}
			UAnimationAsset kiteAnimAsset = this.KiteAnimAsset;
			if (kiteAnimAsset == null || !kiteAnimAsset.IsValid())
			{
				ResourceSystem.Instance.LoadAsync<UAnimationAsset>("/Game/Aki/Character/NPC/AlienNPC/Level_C/SC1Fengzheng/CommonAnim/SC1Fengzheng_State03_Montage.SC1Fengzheng_State03_Montage", delegate([Nullable(2)] UAnimationAsset asset, string _)
				{
					if (asset == null || !asset.IsValid())
					{
						this.FailInit();
						return;
					}
					this.KiteAnimAsset = asset;
					this.CheckInitLoadFinish();
				}, 100, "SeamlessTravel");
			}
			UNiagaraSystem beamEffectAsset = this.BeamEffectAsset;
			if (beamEffectAsset == null || !beamEffectAsset.IsValid())
			{
				ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(this.BeamEffectPath, delegate([Nullable(2)] UNiagaraSystem asset, string _)
				{
					if (asset == null || !asset.IsValid())
					{
						this.FailInit();
						return;
					}
					this.BeamEffectAsset = asset;
					this.CheckInitLoadFinish();
				}, 100, "SeamlessTravel");
			}
			UNiagaraSystem ballEffectAsset = this.BallEffectAsset;
			if (ballEffectAsset == null || !ballEffectAsset.IsValid())
			{
				ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(this.BallEffectPath, delegate([Nullable(2)] UNiagaraSystem asset, string _)
				{
					if (asset == null || !asset.IsValid())
					{
						this.FailInit();
						return;
					}
					this.BallEffectAsset = asset;
					this.CheckInitLoadFinish();
				}, 100, "SeamlessTravel");
			}
			this.CheckInitLoadFinish();
		}

		// Token: 0x060277EA RID: 161770 RVA: 0x00B133B1 File Offset: 0x00B115B1
		private void FailInit()
		{
			Action<bool> initCallback = this.InitCallback;
			this.InitCallback = null;
			if (initCallback == null)
			{
				return;
			}
			initCallback(false);
		}

		// Token: 0x060277EB RID: 161771 RVA: 0x00B133CB File Offset: 0x00B115CB
		private void SuccessInit()
		{
			Action<bool> initCallback = this.InitCallback;
			this.InitCallback = null;
			if (initCallback == null)
			{
				return;
			}
			initCallback(true);
		}

		// Token: 0x060277EC RID: 161772 RVA: 0x00B133E8 File Offset: 0x00B115E8
		private void CheckInitLoadFinish()
		{
			if (this.IsInit)
			{
				return;
			}
			USkeletalMesh kiteMeshAsset = this.KiteMeshAsset;
			if (kiteMeshAsset != null && kiteMeshAsset.IsValid())
			{
				UAnimationAsset kiteAnimAsset = this.KiteAnimAsset;
				if (kiteAnimAsset != null && kiteAnimAsset.IsValid())
				{
					UNiagaraSystem beamEffectAsset = this.BeamEffectAsset;
					if (beamEffectAsset != null && beamEffectAsset.IsValid())
					{
						UNiagaraSystem ballEffectAsset = this.BallEffectAsset;
						if (ballEffectAsset != null && ballEffectAsset.IsValid())
						{
							this.OnInitLoadFinish();
							return;
						}
					}
				}
			}
		}

		// Token: 0x060277ED RID: 161773 RVA: 0x00B13464 File Offset: 0x00B11664
		private void OnInitLoadFinish()
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
				flag = !((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				this.FailInit();
				return;
			}
			this.KiteActor = (ActorSystem.Instance.Get(ASkeletalMeshActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as ASkeletalMeshActor);
			this.BeamActor = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
			this.BallActor = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
			ASkeletalMeshActor kiteActor = this.KiteActor;
			if (kiteActor != null && kiteActor.IsValid())
			{
				AActor beamActor = this.BeamActor;
				if (beamActor != null && beamActor.IsValid())
				{
					AActor ballActor = this.BallActor;
					if (ballActor != null && ballActor.IsValid())
					{
						USkeletalMeshComponent skeletalMeshComponent = this.KiteActor.GetSkeletalMeshComponent();
						if (skeletalMeshComponent == null || !skeletalMeshComponent.IsValid())
						{
							this.FailInit();
							return;
						}
						skeletalMeshComponent.SetSkeletalMesh(this.KiteMeshAsset, true);
						skeletalMeshComponent.PlayAnimation(this.KiteAnimAsset, true);
						if (this.KiteAnimStartPos != 0f)
						{
							skeletalMeshComponent.SetPosition(this.KiteAnimStartPos, true);
						}
						skeletalMeshComponent.VisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones;
						this.KiteActor.SetActorHiddenInGame(true);
						this.BeamEffectNiagaraComp = (this.BeamActor.AddComponentByClass(UNiagaraComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UNiagaraComponent);
						this.BeamEffectNiagaraComp.SetAsset(this.BeamEffectAsset, true);
						TimerSystem.Instance.Next(delegate(float _)
						{
							UKuroEffectLibrary.SetNiagaraSimulationMinDeltaTime(this.BeamEffectNiagaraComp, -1f);
						}, null, null);
						this.BeamActor.K2_AttachToComponent(this.ActorComp.Actor.Mesh, FNameUtil.GetDynamicFName(this.BeamOwnerSocketName) ?? FNameUtil.NONE, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
						this.BeamActor.SetActorHiddenInGame(true);
						this.BallEffectNiagaraComp = (this.BallActor.AddComponentByClass(UNiagaraComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UNiagaraComponent);
						this.BallEffectNiagaraComp.SetAsset(this.BallEffectAsset, true);
						TimerSystem.Instance.Next(delegate(float _)
						{
							UKuroEffectLibrary.SetNiagaraSimulationMinDeltaTime(this.BallEffectNiagaraComp, -1f);
							UKuroEffectLibrary.SetNiagaraFrameDeltaTime(this.BallEffectNiagaraComp, 1f);
						}, null, null);
						this.BallActor.SetActorHiddenInGame(true);
						this.UpdateKeepKite();
						this.IsInitInternal = true;
						Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepKite] 初始化KeepKite(完成)", default(ReadOnlySpan<ValueTuple<string, object>>));
						this.SuccessInit();
						return;
					}
				}
			}
			this.FailInit();
		}

		// Token: 0x060277EE RID: 161774 RVA: 0x00B1371D File Offset: 0x00B1191D
		public void Tick(float delta)
		{
			if (!this.IsInit || !this.IsActive)
			{
				return;
			}
			this.UpdateKeepKite();
		}

		// Token: 0x060277EF RID: 161775 RVA: 0x00B13738 File Offset: 0x00B11938
		public void UpdateKeepKite()
		{
			ASkeletalMeshActor kiteActor = this.KiteActor;
			if (kiteActor != null && kiteActor.IsValid())
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null && actorComp.Actor.IsValid())
				{
					AActor kiteActor2 = this.KiteActor;
					FTransformDouble ftransformDouble = this.GetKiteTransform(this.KiteTransformCache).ToUeTransform();
					kiteActor2.D_K2_SetActorTransform(ftransformDouble, false, ref WorldGlobal.SweepHitResult, true);
				}
				Vector kiteHookLocation = this.GetKiteHookLocation(this.KiteHookLocationCache);
				UNiagaraComponent beamEffectNiagaraComp = this.BeamEffectNiagaraComp;
				if (beamEffectNiagaraComp != null && beamEffectNiagaraComp.IsValid())
				{
					FVector inValue = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, kiteHookLocation.ToUeVector(false));
					this.BeamEffectNiagaraComp.SetNiagaraVariableVec3("end", inValue);
				}
				AActor ballActor = this.BallActor;
				if (ballActor != null && ballActor.IsValid())
				{
					this.BallActor.D_K2_SetActorLocation(kiteHookLocation.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, true);
				}
			}
		}

		// Token: 0x060277F0 RID: 161776 RVA: 0x00B13810 File Offset: 0x00B11A10
		public void Destroy()
		{
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepKite] 清理KeepKite", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInitInternal = false;
			this.BeamEffectAsset = null;
			this.BeamEffectNiagaraComp = null;
			ActorSystem.Instance.Put("SeamlessTravelKeepKite.Destroy", this.BeamActor, null);
			this.BeamActor = null;
			this.BallEffectAsset = null;
			this.BallEffectNiagaraComp = null;
			ActorSystem.Instance.Put("SeamlessTravelKeepKite.Destroy", this.BallActor, null);
			this.BallActor = null;
			this.KiteMeshAsset = null;
			this.KiteAnimAsset = null;
			this.KiteAnimStartPos = 0f;
			ActorSystem.Instance.Put("SeamlessTravelKeepKite.Destroy", this.KiteActor, null);
			this.KiteActor = null;
			this.ActorComp = null;
			this.Context = null;
		}

		// Token: 0x060277F1 RID: 161777 RVA: 0x00B138E0 File Offset: 0x00B11AE0
		[NullableContext(2)]
		public void AppearEffect(Action<bool> callback = null)
		{
			if (!this.IsInit)
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (this.IsActive)
			{
				if (callback != null)
				{
					callback(true);
				}
				return;
			}
			ASkeletalMeshActor kiteActor = this.KiteActor;
			if (kiteActor != null && kiteActor.IsValid())
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null && actorComp.Actor.IsValid())
				{
					Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepKite] 显示效果", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.IsActiveInternal = true;
					RoleSceneInteractComponent component = this.ActorComp.Entity.GetComponent<RoleSceneInteractComponent>();
					if (component != null && component.GetIsHooking())
					{
						GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
						if (currentTarget != null && currentTarget.GetHookInteractType().GetValueOrDefault() == EHookInteractType.KiteHook)
						{
							WorldEntity entity = component.GetCurrentTargetEntity().Entity;
							if (entity != null)
							{
								entity.Disable("[无缝传送KeepKite] 隐藏风筝声骸");
							}
							component.SetIsHookEndByInterrupt(true);
							CharacterSkillComponent component2 = this.ActorComp.Entity.GetComponent<CharacterSkillComponent>();
							if (component2 != null)
							{
								component2.EndSkill(210130, "[无缝传送KeepKite] 停止勾风筝技能");
							}
						}
					}
					this.KiteActor.SetActorHiddenInGame(false);
					AActor beamActor = this.BeamActor;
					if (beamActor != null)
					{
						beamActor.SetActorHiddenInGame(false);
					}
					AActor ballActor = this.BallActor;
					if (ballActor != null)
					{
						ballActor.SetActorHiddenInGame(false);
					}
					USkeletalMeshComponent skeletalMesh = this.ActorComp.SkeletalMesh;
					CharacterWeaponComponent component3 = this.ActorComp.Entity.GetComponent<CharacterWeaponComponent>();
					USkeletalMeshComponent uskeletalMeshComponent = (component3 != null) ? component3.Hulu : null;
					USkeletalMeshComponent skeletalMeshComponent = this.KiteActor.SkeletalMeshComponent;
					if (skeletalMesh != null && skeletalMesh.IsValid())
					{
						this.CharaMainMeshCastHiddenShadowBeforeTravel = new bool?(skeletalMesh.bCastHiddenShadow);
						skeletalMesh.bCastHiddenShadow = true;
					}
					if (uskeletalMeshComponent != null && uskeletalMeshComponent.IsValid())
					{
						this.CharaHuluMeshCastHiddenShadowBeforeTravel = new bool?(uskeletalMeshComponent.bCastHiddenShadow);
						uskeletalMeshComponent.bCastHiddenShadow = true;
					}
					if (skeletalMeshComponent != null && skeletalMeshComponent.IsValid())
					{
						skeletalMeshComponent.bCastHiddenShadow = true;
					}
					UNiagaraComponent beamEffectNiagaraComp = this.BeamEffectNiagaraComp;
					if (beamEffectNiagaraComp != null && beamEffectNiagaraComp.IsValid())
					{
						this.BeamEffectNiagaraComp.bCastHiddenShadow = true;
					}
					UNiagaraComponent ballEffectNiagaraComp = this.BallEffectNiagaraComp;
					if (ballEffectNiagaraComp != null && ballEffectNiagaraComp.IsValid())
					{
						this.BallEffectNiagaraComp.bCastHiddenShadow = true;
					}
					if (callback != null)
					{
						callback(true);
					}
					return;
				}
			}
			if (callback != null)
			{
				callback(false);
			}
		}

		// Token: 0x060277F2 RID: 161778 RVA: 0x00B13B04 File Offset: 0x00B11D04
		[NullableContext(2)]
		public void DisappearEffect(Action<bool> callback = null)
		{
			if (!this.IsInit)
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (!this.IsActive)
			{
				if (callback != null)
				{
					callback(true);
				}
				return;
			}
			Log.Instance.Info(ELogModule.Teleport, ELogAuthor.ZYL, "[无缝传送KeepKite] 隐藏效果", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsActiveInternal = false;
			ASkeletalMeshActor kiteActor = this.KiteActor;
			if (kiteActor != null)
			{
				kiteActor.SetActorHiddenInGame(true);
			}
			AActor beamActor = this.BeamActor;
			if (beamActor != null)
			{
				beamActor.SetActorHiddenInGame(true);
			}
			AActor ballActor = this.BallActor;
			if (ballActor != null)
			{
				ballActor.SetActorHiddenInGame(true);
			}
			CharacterActorComponent actorComp = this.ActorComp;
			USkeletalMeshComponent uskeletalMeshComponent = (actorComp != null) ? actorComp.SkeletalMesh : null;
			CharacterActorComponent actorComp2 = this.ActorComp;
			USkeletalMeshComponent uskeletalMeshComponent2;
			if (actorComp2 == null)
			{
				uskeletalMeshComponent2 = null;
			}
			else
			{
				CharacterWeaponComponent component = actorComp2.Entity.GetComponent<CharacterWeaponComponent>();
				uskeletalMeshComponent2 = ((component != null) ? component.Hulu : null);
			}
			USkeletalMeshComponent uskeletalMeshComponent3 = uskeletalMeshComponent2;
			ASkeletalMeshActor kiteActor2 = this.KiteActor;
			USkeletalMeshComponent uskeletalMeshComponent4 = (kiteActor2 != null) ? kiteActor2.SkeletalMeshComponent : null;
			if (uskeletalMeshComponent != null && uskeletalMeshComponent.IsValid() && this.CharaMainMeshCastHiddenShadowBeforeTravel != null)
			{
				uskeletalMeshComponent.bCastHiddenShadow = this.CharaMainMeshCastHiddenShadowBeforeTravel.Value;
			}
			if (uskeletalMeshComponent3 != null && uskeletalMeshComponent3.IsValid() && this.CharaHuluMeshCastHiddenShadowBeforeTravel != null)
			{
				uskeletalMeshComponent3.bCastHiddenShadow = this.CharaHuluMeshCastHiddenShadowBeforeTravel.Value;
			}
			if (uskeletalMeshComponent4 != null && uskeletalMeshComponent4.IsValid())
			{
				uskeletalMeshComponent4.bCastHiddenShadow = false;
			}
			UNiagaraComponent beamEffectNiagaraComp = this.BeamEffectNiagaraComp;
			if (beamEffectNiagaraComp != null && beamEffectNiagaraComp.IsValid())
			{
				this.BeamEffectNiagaraComp.bCastHiddenShadow = false;
			}
			UNiagaraComponent ballEffectNiagaraComp = this.BallEffectNiagaraComp;
			if (ballEffectNiagaraComp != null && ballEffectNiagaraComp.IsValid())
			{
				this.BallEffectNiagaraComp.bCastHiddenShadow = false;
			}
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x060277F3 RID: 161779 RVA: 0x00B13C8C File Offset: 0x00B11E8C
		public void SetInitData(Entity kiteEntity, Entity instigatorEntity)
		{
			SceneItemActorComponent component = kiteEntity.GetComponent<SceneItemActorComponent>();
			AActor actorInSceneInteraction = component.GetActorInSceneInteraction("Fengzheng");
			AActor owner = component.Owner;
			FTransformDouble ftransformDouble = (owner != null) ? owner.D_GetTransform() : component.ActorTransform;
			FTransformDouble ftransformDouble2 = (actorInSceneInteraction != null) ? actorInSceneInteraction.D_GetTransform() : ftransformDouble;
			BaseActorComponent component2 = instigatorEntity.GetComponent<BaseActorComponent>();
			FTransformDouble actorTransform = component2.ActorTransform;
			Transform relativeTransform = this.RelativeTransform;
			FTransformDouble relativeTransform2 = ftransformDouble2.GetRelativeTransform(actorTransform);
			relativeTransform.FromUeTransform(relativeTransform2);
			this.GravityDirect.DeepCopy(component2.ActorGravityDirectProxy);
			Transform hookPointRelativeTransformToKite = this.HookPointRelativeTransformToKite;
			relativeTransform2 = ftransformDouble.GetRelativeTransform(ftransformDouble2);
			hookPointRelativeTransformToKite.FromUeTransform(relativeTransform2);
			ASkeletalMeshActor askeletalMeshActor = actorInSceneInteraction as ASkeletalMeshActor;
			if (askeletalMeshActor != null)
			{
				USkeletalMeshComponent skeletalMeshComponent = askeletalMeshActor.SkeletalMeshComponent;
				this.KiteMeshAsset = ((skeletalMeshComponent != null) ? skeletalMeshComponent.SkeletalMesh : null);
				UAnimInstance uanimInstance = (skeletalMeshComponent != null) ? skeletalMeshComponent.GetAnimInstance() : null;
				this.KiteAnimAsset = ((uanimInstance != null) ? uanimInstance.GetCurrentActiveMontage() : null);
				this.KiteAnimStartPos = ((uanimInstance != null) ? uanimInstance.Montage_GetPosition(null) : 0f);
			}
		}

		// Token: 0x060277F4 RID: 161780 RVA: 0x00B13D88 File Offset: 0x00B11F88
		private Vector GetKiteHookLocation(Vector outLocation)
		{
			ASkeletalMeshActor kiteActor = this.KiteActor;
			if (kiteActor == null || !kiteActor.IsValid())
			{
				return outLocation;
			}
			FTransformDouble ftransformDouble = this.HookPointRelativeTransformToKite.ToUeTransform();
			FTransformDouble ftransformDouble2 = this.KiteActor.D_GetTransform();
			FVectorDouble location = (ftransformDouble * ftransformDouble2).GetLocation();
			outLocation.DeepCopy(location);
			return outLocation;
		}

		// Token: 0x060277F5 RID: 161781 RVA: 0x00B13DE4 File Offset: 0x00B11FE4
		private Transform GetKiteTransform(Transform outTransform)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.Actor.IsValid())
			{
				return outTransform;
			}
			FTransformDouble ftransformDouble = this.RelativeTransform.ToUeTransform();
			FTransformDouble ftransformDouble2 = this.ActorComp.Actor.D_GetTransform();
			FTransformDouble ftransformDouble3 = ftransformDouble * ftransformDouble2;
			outTransform.FromUeTransform(ftransformDouble3);
			return outTransform;
		}

		// Token: 0x060277F6 RID: 161782 RVA: 0x00B13E3F File Offset: 0x00B1203F
		public TArray<AActor> GetSeamlessTravelActors(TArray<AActor> arr)
		{
			if (this.KiteActor != null)
			{
				arr.Add(this.KiteActor);
			}
			if (this.BeamActor != null)
			{
				arr.Add(this.BeamActor);
			}
			if (this.BallActor != null)
			{
				arr.Add(this.BallActor);
			}
			return arr;
		}

		// Token: 0x0401585B RID: 88155
		private const string DEFAULT_KITE_SKELETAL_MESH_PATH = "/Game/Aki/Character/NPC/AlienNPC/Level_C/SC1Fengzheng/Model/SC1Fengzheng.SC1Fengzheng";

		// Token: 0x0401585C RID: 88156
		private const string DEFAULT_KITE_ANIM_PATH = "/Game/Aki/Character/NPC/AlienNPC/Level_C/SC1Fengzheng/CommonAnim/SC1Fengzheng_State03_Montage.SC1Fengzheng_State03_Montage";

		// Token: 0x0401585D RID: 88157
		private const string KITE_HOOK_BEAM_EFFECT_PATH = "/Game/Aki/Effect/Niagara/NI_Common/NS_Fx_Hook_Beam1.NS_Fx_Hook_Beam1";

		// Token: 0x0401585E RID: 88158
		private const string KITE_HOOK_BALL_EFFECT_PATH = "/Game/Aki/Effect/Niagara/NI_Common/NS_Fx_Hook_Maodian.NS_Fx_Hook_Maodian";

		// Token: 0x0401585F RID: 88159
		private const string KITE_HOOK_BEAM_OWNER_SOCKET = "Bip001LHand";

		// Token: 0x04015860 RID: 88160
		private const string KITE_HOOK_BEAM_NIAGARA_ENDPOS_VAR = "end";

		// Token: 0x04015861 RID: 88161
		private const string KITE_ACTOR_REF_NAME = "Fengzheng";

		// Token: 0x04015862 RID: 88162
		private const int SKILL_ID_XA_KITE = 210130;

		// Token: 0x04015863 RID: 88163
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04015864 RID: 88164
		[Nullable(2)]
		private SeamlessTravelContext Context;

		// Token: 0x04015865 RID: 88165
		private bool IsInitInternal;

		// Token: 0x04015866 RID: 88166
		private bool IsActiveInternal;

		// Token: 0x04015867 RID: 88167
		[Nullable(2)]
		private USkeletalMesh KiteMeshAsset;

		// Token: 0x04015868 RID: 88168
		[Nullable(2)]
		private UAnimationAsset KiteAnimAsset;

		// Token: 0x04015869 RID: 88169
		private float KiteAnimStartPos;

		// Token: 0x0401586A RID: 88170
		[Nullable(2)]
		private ASkeletalMeshActor KiteActor;

		// Token: 0x0401586B RID: 88171
		[Nullable(2)]
		private UNiagaraSystem BeamEffectAsset;

		// Token: 0x0401586C RID: 88172
		[Nullable(2)]
		private UNiagaraSystem BallEffectAsset;

		// Token: 0x0401586D RID: 88173
		[Nullable(2)]
		private AActor BeamActor;

		// Token: 0x0401586E RID: 88174
		[Nullable(2)]
		private AActor BallActor;

		// Token: 0x0401586F RID: 88175
		[Nullable(2)]
		private UNiagaraComponent BeamEffectNiagaraComp;

		// Token: 0x04015870 RID: 88176
		[Nullable(2)]
		private UNiagaraComponent BallEffectNiagaraComp;

		// Token: 0x04015871 RID: 88177
		private readonly Transform RelativeTransform = Transform.Create();

		// Token: 0x04015872 RID: 88178
		private readonly Vector GravityDirect = Vector.Create();

		// Token: 0x04015873 RID: 88179
		private string BeamEffectPath = "";

		// Token: 0x04015874 RID: 88180
		private string BallEffectPath = "";

		// Token: 0x04015875 RID: 88181
		private string BeamOwnerSocketName = "";

		// Token: 0x04015876 RID: 88182
		private readonly Transform HookPointRelativeTransformToKite = Transform.Create();

		// Token: 0x04015877 RID: 88183
		private readonly Transform KiteTransformCache = Transform.Create();

		// Token: 0x04015878 RID: 88184
		private readonly Vector KiteHookLocationCache = Vector.Create();

		// Token: 0x04015879 RID: 88185
		private bool? CharaMainMeshCastHiddenShadowBeforeTravel;

		// Token: 0x0401587A RID: 88186
		private bool? CharaHuluMeshCastHiddenShadowBeforeTravel;

		// Token: 0x0401587B RID: 88187
		[Nullable(2)]
		private Action<bool> InitCallback;
	}
}
