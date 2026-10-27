using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component
{
	// Token: 0x02006895 RID: 26773
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlActorComponent : ActivityGameplayComponentBase<IDangoBrawlEntityData>
	{
		// Token: 0x170097B9 RID: 38841
		// (get) Token: 0x06042D16 RID: 273686 RVA: 0x01043AAE File Offset: 0x01041CAE
		[Nullable(1)]
		public new static List<Type> Dependencies
		{
			[NullableContext(1)]
			get
			{
				return new List<Type>
				{
					typeof(DangoBrawlDataComponent)
				};
			}
		}

		// Token: 0x170097BA RID: 38842
		// (get) Token: 0x06042D17 RID: 273687 RVA: 0x01043AC5 File Offset: 0x01041CC5
		public ACharacter SpawnedActor
		{
			get
			{
				return this.Actor;
			}
		}

		// Token: 0x170097BB RID: 38843
		// (get) Token: 0x06042D18 RID: 273688 RVA: 0x01043ACD File Offset: 0x01041CCD
		// (set) Token: 0x06042D19 RID: 273689 RVA: 0x01043AD5 File Offset: 0x01041CD5
		public bool IsAnimationReady { get; private set; }

		// Token: 0x06042D1A RID: 273690 RVA: 0x01043ADE File Offset: 0x01041CDE
		public USkeletalMeshComponent GetBodyMesh()
		{
			ACharacter actor = this.Actor;
			if (actor == null)
			{
				return null;
			}
			return actor.Mesh;
		}

		// Token: 0x06042D1B RID: 273691 RVA: 0x01043AF1 File Offset: 0x01041CF1
		public double GetBornLocationZ()
		{
			return this.BornLocationZ;
		}

		// Token: 0x06042D1C RID: 273692 RVA: 0x01043AF9 File Offset: 0x01041CF9
		public double GetActorLocationZ()
		{
			if (this.Actor == null)
			{
				return this.BornLocationZ;
			}
			return this.Actor.D_K2_GetActorLocation().Z;
		}

		// Token: 0x06042D1D RID: 273693 RVA: 0x01043B1C File Offset: 0x01041D1C
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

		// Token: 0x06042D1E RID: 273694 RVA: 0x01043B6C File Offset: 0x01041D6C
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

		// Token: 0x06042D1F RID: 273695 RVA: 0x01043BAC File Offset: 0x01041DAC
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

		// Token: 0x06042D20 RID: 273696 RVA: 0x01043BF8 File Offset: 0x01041DF8
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

		// Token: 0x06042D21 RID: 273697 RVA: 0x01043C4C File Offset: 0x01041E4C
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

		// Token: 0x06042D22 RID: 273698 RVA: 0x01043F85 File Offset: 0x01042185
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

		// Token: 0x04022C4A RID: 142410
		private ACharacter Actor;

		// Token: 0x04022C4B RID: 142411
		private UniTaskCompletionSource SpawnSource;

		// Token: 0x04022C4C RID: 142412
		private bool IsDisposed;

		// Token: 0x04022C4D RID: 142413
		private CharRenderingComponent RenderComp;

		// Token: 0x04022C4E RID: 142414
		private double BornLocationZ;
	}
}
