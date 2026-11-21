using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component
{
	// Token: 0x020057E5 RID: 22501
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlActorComponent : ActivityGameplayComponentBase<IDangoBrawlEntityData>
	{
		// Token: 0x17006AF9 RID: 27385
		// (get) Token: 0x0603786E RID: 227438 RVA: 0x00F8502C File Offset: 0x00F8322C
		[Nullable(1)]
		public override Type[] Dependencies
		{
			[NullableContext(1)]
			get
			{
				return new Type[]
				{
					typeof(DangoBrawlDataComponent)
				};
			}
		}

		// Token: 0x17006AFA RID: 27386
		// (get) Token: 0x0603786F RID: 227439 RVA: 0x00F85041 File Offset: 0x00F83241
		public ACharacter SpawnedActor
		{
			get
			{
				return this.Actor;
			}
		}

		// Token: 0x17006AFB RID: 27387
		// (get) Token: 0x06037870 RID: 227440 RVA: 0x00F85049 File Offset: 0x00F83249
		// (set) Token: 0x06037871 RID: 227441 RVA: 0x00F85051 File Offset: 0x00F83251
		public bool IsAnimationReady { get; private set; }

		// Token: 0x06037872 RID: 227442 RVA: 0x00F8505A File Offset: 0x00F8325A
		public USkeletalMeshComponent GetBodyMesh()
		{
			ACharacter actor = this.Actor;
			if (actor == null)
			{
				return null;
			}
			return actor.Mesh;
		}

		// Token: 0x06037873 RID: 227443 RVA: 0x00F8506D File Offset: 0x00F8326D
		public double GetBornLocationZ()
		{
			return this.BornLocationZ;
		}

		// Token: 0x06037874 RID: 227444 RVA: 0x00F85075 File Offset: 0x00F83275
		public double GetActorLocationZ()
		{
			if (this.Actor == null)
			{
				return this.BornLocationZ;
			}
			return this.Actor.D_K2_GetActorLocation().Z;
		}

		// Token: 0x06037875 RID: 227445 RVA: 0x00F85098 File Offset: 0x00F83298
		public FVectorDouble GetActorWorldLocation(double zOffset = 0.0)
		{
			if (this.Actor == null)
			{
				return new FVectorDouble(0.0, 0.0, this.BornLocationZ + zOffset);
			}
			FVectorDouble result = this.Actor.D_K2_GetActorLocation();
			result.Z += zOffset;
			return result;
		}

		// Token: 0x06037876 RID: 227446 RVA: 0x00F850E8 File Offset: 0x00F832E8
		public void SetActorLocationZ(double z)
		{
			if (this.Actor == null)
			{
				return;
			}
			FVectorDouble newLocation = this.Actor.D_K2_GetActorLocation();
			newLocation.Z = z;
			FHitResult fhitResult = null;
			this.Actor.D_K2_SetActorLocation(newLocation, false, ref fhitResult, true);
		}

		// Token: 0x06037877 RID: 227447 RVA: 0x00F85128 File Offset: 0x00F83328
		public FTransformDouble? GetRootBoneTransform()
		{
			ACharacter actor = this.Actor;
			USkeletalMeshComponent uskeletalMeshComponent = (actor != null) ? actor.Mesh : null;
			if (uskeletalMeshComponent == null)
			{
				return null;
			}
			return new FTransformDouble?(uskeletalMeshComponent.D_GetSocketTransform(FNameUtil.GetDynamicFName("Root").Value, ERelativeTransformSpace.RTS_World));
		}

		// Token: 0x06037878 RID: 227448 RVA: 0x00F85174 File Offset: 0x00F83374
		public UAnimInstance GetAnimInstance()
		{
			if (this.Actor == null)
			{
				return null;
			}
			USkeletalMeshComponent mesh = this.Actor.Mesh;
			UAnimInstance uanimInstance = (mesh != null) ? mesh.GetAnimInstance() : null;
			if (uanimInstance == null)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "DangoBrawlActorComponent 获取 AnimInstance 失败：AnimInstance 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return uanimInstance;
		}

		// Token: 0x06037879 RID: 227449 RVA: 0x00F851C8 File Offset: 0x00F833C8
		public UniTask SpawnAsync()
		{
			DangoBrawlActorComponent.<>c__DisplayClass20_0 CS$<>8__locals1 = new DangoBrawlActorComponent.<>c__DisplayClass20_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.IsDisposed)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "DangoBrawlActorComponent 已 End，禁止 SpawnAsync", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			}
			if (this.SpawnSource != null)
			{
				return this.SpawnSource.Task;
			}
			DangoBrawlDataComponent dangoBrawlDataComponent = base.OwnerEntity.CheckGetComponent<DangoBrawlDataComponent>();
			if (dangoBrawlDataComponent == null)
			{
				return UniTask.CompletedTask;
			}
			CS$<>8__locals1.dangoId = dangoBrawlDataComponent.Data.DangoId;
			CS$<>8__locals1.actorClassPath = "";
			CS$<>8__locals1.abpPath = "";
			CS$<>8__locals1.isSelf = (dangoBrawlDataComponent.Data.Identity == EDangoBrawlSide.Self);
			if (CS$<>8__locals1.isSelf)
			{
				DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(CS$<>8__locals1.dangoId);
				CS$<>8__locals1.actorClassPath = (((roleConfigById != null) ? roleConfigById.GetValueOrDefault().BlueprintPath : null) ?? "");
				CS$<>8__locals1.abpPath = (((roleConfigById != null) ? roleConfigById.GetValueOrDefault().ABpPath : null) ?? "");
			}
			else
			{
				DangoBrawlOpponent? opponentConfigById = DangoBrawlConfig.Instance.GetOpponentConfigById(CS$<>8__locals1.dangoId);
				CS$<>8__locals1.actorClassPath = (((opponentConfigById != null) ? opponentConfigById.GetValueOrDefault().BlueprintPath : null) ?? "");
				CS$<>8__locals1.abpPath = (((opponentConfigById != null) ? opponentConfigById.GetValueOrDefault().ABpPath : null) ?? "");
			}
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(CS$<>8__locals1.isSelf ? "Born_Player" : "Born_NPC").Value, ECollectActorType.Default);
			if (actorWithTag != null)
			{
				CS$<>8__locals1.bornTransform = actorWithTag.D_GetTransformWithUpdate();
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "DangoBrawlActorComponent 找不到出生点 Actor";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("positionTag", CS$<>8__locals1.isSelf ? "Born_Player" : "Born_NPC");
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				DangoBrawlActorComponent.<>c__DisplayClass20_0 CS$<>8__locals2 = CS$<>8__locals1;
				FRotator frotator = new FRotator(0f, 0f, 0f);
				FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
				FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
				FVector fvector = fvectorDouble2;
				CS$<>8__locals2.bornTransform = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			}
			CS$<>8__locals1.tcs = new UniTaskCompletionSource();
			this.SpawnSource = CS$<>8__locals1.tcs;
			this.BornLocationZ = CS$<>8__locals1.bornTransform.GetTranslation().Z;
			if (!string.IsNullOrEmpty(CS$<>8__locals1.actorClassPath) && !CS$<>8__locals1.actorClassPath.EndsWith("_C"))
			{
				CS$<>8__locals1.actorClassPath += "_C";
			}
			if (!string.IsNullOrEmpty(CS$<>8__locals1.abpPath) && !CS$<>8__locals1.abpPath.EndsWith("_C"))
			{
				CS$<>8__locals1.abpPath += "_C";
			}
			ResourceSystem.Instance.LoadAsync<UBlueprintGeneratedClass>(CS$<>8__locals1.actorClassPath, delegate([Nullable(2)] UBlueprintGeneratedClass loadedClass, string _)
			{
				if (CS$<>8__locals1.<>4__this.IsDisposed)
				{
					CS$<>8__locals1.tcs.TrySetResult();
					return;
				}
				if (loadedClass == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.DangoBrawl;
					ELogAuthor author2 = ELogAuthor.WHJ;
					string message2 = "DangoBrawlActorComponent 加载蓝图失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("actorClassPath", CS$<>8__locals1.actorClassPath);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					CS$<>8__locals1.tcs.TrySetResult();
					return;
				}
				CS$<>8__locals1.<>4__this.Actor = (UKuroActorManager.D_SpawnActor(Info.Instance.World, loadedClass, CS$<>8__locals1.bornTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null, null, false) as ACharacter);
				if (CS$<>8__locals1.<>4__this.Actor == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.DangoBrawl;
					ELogAuthor author3 = ELogAuthor.WHJ;
					string message3 = "DangoBrawlActorComponent Spawn 失败";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("actorClassPath", CS$<>8__locals1.actorClassPath);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					CS$<>8__locals1.tcs.TrySetResult();
					return;
				}
				CS$<>8__locals1.<>4__this.RenderComp = (CS$<>8__locals1.<>4__this.Actor.GetComponentByClass(CharRenderingComponent.StaticClass()) as CharRenderingComponent);
				if (CS$<>8__locals1.<>4__this.RenderComp != null && !CS$<>8__locals1.<>4__this.RenderComp.CheckInit())
				{
					CS$<>8__locals1.<>4__this.RenderComp.Init(ECharacterRenderingType.Default);
				}
				if (string.IsNullOrEmpty(CS$<>8__locals1.abpPath))
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.DangoBrawl;
					ELogAuthor author4 = ELogAuthor.WHJ;
					string message4 = "DangoBrawlActorComponent ABpPath 为空，蒙太奇将无法播放";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("dangoId", CS$<>8__locals1.dangoId);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					CS$<>8__locals1.tcs.TrySetResult();
					return;
				}
				AudioSystem.Instance.SetRtpcValue("sys_game_3_7_tuanzi_pan", (float)(CS$<>8__locals1.isSelf ? -1 : 1), new SetRtpcValueArgs?(new SetRtpcValueArgs(null, null, CS$<>8__locals1.<>4__this.Actor)));
				ResourceSystem instance5 = ResourceSystem.Instance;
				string abpPath = CS$<>8__locals1.abpPath;
				Action<UClass, string> callback;
				if ((callback = CS$<>8__locals1.<>9__1) == null)
				{
					callback = (CS$<>8__locals1.<>9__1 = delegate([Nullable(2)] UClass animClass, string _)
					{
						if (CS$<>8__locals1.<>4__this.IsDisposed)
						{
							CS$<>8__locals1.tcs.TrySetResult();
							return;
						}
						if (animClass == null)
						{
							Log instance6 = Log.Instance;
							ELogModule module5 = ELogModule.DangoBrawl;
							ELogAuthor author5 = ELogAuthor.WHJ;
							string message5 = "DangoBrawlActorComponent 加载动画蓝图失败";
							ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("abpPath", CS$<>8__locals1.abpPath);
							instance6.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
							CS$<>8__locals1.tcs.TrySetResult();
							return;
						}
						ACharacter actor = CS$<>8__locals1.<>4__this.Actor;
						if (actor != null)
						{
							USkeletalMeshComponent mesh = actor.Mesh;
							if (mesh != null)
							{
								mesh.SetAnimClass(animClass.ClassStackOnlyPtr);
							}
						}
						UAnimInstance animInstance = CS$<>8__locals1.<>4__this.GetAnimInstance();
						CS$<>8__locals1.<>4__this.IsAnimationReady = (animInstance != null);
						CS$<>8__locals1.tcs.TrySetResult();
					});
				}
				instance5.LoadAsync<UClass>(abpPath, callback, 100, "js_undefined");
			}, 100, "js_undefined");
			return CS$<>8__locals1.tcs.Task;
		}

		// Token: 0x0603787A RID: 227450 RVA: 0x00F85501 File Offset: 0x00F83701
		protected override void OnEnd()
		{
			this.IsDisposed = true;
			this.IsAnimationReady = false;
			this.RenderComp = null;
			if (this.Actor != null)
			{
				this.Actor.K2_DestroyActor();
				this.Actor = null;
			}
		}

		// Token: 0x0401D4A6 RID: 119974
		private ACharacter Actor;

		// Token: 0x0401D4A7 RID: 119975
		private UniTaskCompletionSource SpawnSource;

		// Token: 0x0401D4A8 RID: 119976
		private bool IsDisposed;

		// Token: 0x0401D4A9 RID: 119977
		private CharRenderingComponent RenderComp;

		// Token: 0x0401D4AA RID: 119978
		private double BornLocationZ;
	}
}
