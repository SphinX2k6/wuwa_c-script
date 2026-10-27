using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.FemaleXL.Xinyuehu.R2T1XinMd10011;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02005959 RID: 22873
	[NullableContext(2)]
	[Nullable(0)]
	public class GiantBodyActor : IStaticVariableResetter
	{
		// Token: 0x0603A079 RID: 237689 RVA: 0x00DCB19C File Offset: 0x00DC939C
		static GiantBodyActor()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GiantBodyActor.CreateStaticDefaultValue), new Action(GiantBodyActor.ResetStaticDefaultValue));
		}

		// Token: 0x0603A07A RID: 237690 RVA: 0x00DCB1D4 File Offset: 0x00DC93D4
		public static void CreateStaticDefaultValue()
		{
			GiantBodyActor.Actor = null;
			GiantBodyActor.GhostTitanAnim = null;
			GiantBodyActor.CurrentMontage = null;
			GiantBodyActor.CurrentMontageBlendOutCallback = null;
		}

		// Token: 0x0603A07B RID: 237691 RVA: 0x00DCB1EE File Offset: 0x00DC93EE
		public static void ResetStaticDefaultValue()
		{
			GiantBodyActor.Actor = null;
			GiantBodyActor.GhostTitanAnim = null;
			GiantBodyActor.CurrentMontage = null;
			GiantBodyActor.CurrentMontageBlendOutCallback = null;
		}

		// Token: 0x0603A07C RID: 237692 RVA: 0x00DCB208 File Offset: 0x00DC9408
		public static void Spawn(Action onSpawned = null)
		{
			string path = GiantConfig.GetGiantBodyActorClassPath();
			if (path == null)
			{
				return;
			}
			Action<UClass, string> <>9__1;
			ResourceSystem.Instance.LoadTypeAsync(EBpTypeName.ABP_GhostTitan_C.ToEnumString(), delegate
			{
				ResourceSystem instance = ResourceSystem.Instance;
				string path = path;
				Action<UClass, string> callback;
				if ((callback = <>9__1) == null)
				{
					callback = (<>9__1 = delegate([Nullable(2)] UClass actorClass, string _)
					{
						if (actorClass == null)
						{
							Log instance2 = Log.Instance;
							ELogModule module = ELogModule.Giant;
							ELogAuthor author = ELogAuthor.YSQ;
							string message = "[GiantBodyActor] 巨人本体蓝图类加载失败";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
							instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							return;
						}
						FTransformDouble transform = GiantConfig.GetGiantBodyTransform() ?? MathUtils.Instance.DefaultTransformDouble;
						AActor aactor = ActorSystem.Instance.Get(actorClass, transform, null, true);
						if (aactor == null || !aactor.IsValid())
						{
							return;
						}
						AActor aactor2 = aactor;
						FVector scale3D = transform.GetScale3D();
						aactor2.D_SetActorScale3D(scale3D);
						GiantBodyActor.Actor = aactor;
						Action onSpawned2 = onSpawned;
						if (onSpawned2 == null)
						{
							return;
						}
						onSpawned2();
					});
				}
				instance.LoadAsync<UClass>(path, callback, 100, "js_undefined");
			}, "js_undefined");
		}

		// Token: 0x0603A07D RID: 237693 RVA: 0x00DCB258 File Offset: 0x00DC9458
		public static void SetBodyVisible(bool visible)
		{
			AActor actor = GiantBodyActor.Actor;
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			actor.SetActorHiddenInGame(!visible);
		}

		// Token: 0x0603A07E RID: 237694 RVA: 0x00DCB287 File Offset: 0x00DC9487
		public static void Destroy()
		{
			GiantBodyActor.ClearMontageBinding();
			GiantBodyActor.GhostTitanAnim = null;
			AActor actor = GiantBodyActor.Actor;
			if (actor != null && actor.IsValid())
			{
				ActorSystem.Instance.Put("GiantBodyActor.Destroy", GiantBodyActor.Actor, null);
			}
			GiantBodyActor.Actor = null;
		}

		// Token: 0x0603A07F RID: 237695 RVA: 0x00DCB2C3 File Offset: 0x00DC94C3
		public static bool IsSpawned()
		{
			AActor actor = GiantBodyActor.Actor;
			return actor != null && actor.IsValid();
		}

		// Token: 0x0603A080 RID: 237696 RVA: 0x00DCB2D5 File Offset: 0x00DC94D5
		public static AActor GetActor()
		{
			return GiantBodyActor.Actor;
		}

		// Token: 0x0603A081 RID: 237697 RVA: 0x00DCB2DC File Offset: 0x00DC94DC
		[NullableContext(1)]
		public static void SetCurrentIdleAnimKey(string idleKey)
		{
			ABP_GhostTitan_C ghostTitanAnim = GiantBodyActor.GetGhostTitanAnim();
			if (ghostTitanAnim == null)
			{
				return;
			}
			ghostTitanAnim.CurrentIdleType = (FNameUtil.GetDynamicFName(idleKey) ?? FNameUtil.NONE);
		}

		// Token: 0x0603A082 RID: 237698 RVA: 0x00DCB318 File Offset: 0x00DC9518
		public static void SetRestVariantIsA(bool value)
		{
			ABP_GhostTitan_C ghostTitanAnim = GiantBodyActor.GetGhostTitanAnim();
			if (ghostTitanAnim == null)
			{
				return;
			}
			ghostTitanAnim.RestVariantIsA = value;
		}

		// Token: 0x0603A083 RID: 237699 RVA: 0x00DCB338 File Offset: 0x00DC9538
		public static void SetSightTargetDirect(float x, float y, float z)
		{
			ABP_GhostTitan_C ghostTitanAnim = GiantBodyActor.GetGhostTitanAnim();
			if (ghostTitanAnim == null)
			{
				return;
			}
			FVector sightTargetVector = GiantBodyActor.SightTargetVector;
			sightTargetVector.X = x;
			sightTargetVector.Y = y;
			sightTargetVector.Z = z;
			ghostTitanAnim.SightTargetDirect = sightTargetVector;
		}

		// Token: 0x0603A084 RID: 237700 RVA: 0x00DCB374 File Offset: 0x00DC9574
		public static void SetSightPlayingSpecial(bool value)
		{
			ABP_GhostTitan_C ghostTitanAnim = GiantBodyActor.GetGhostTitanAnim();
			if (ghostTitanAnim == null)
			{
				return;
			}
			ghostTitanAnim.IsPlayingSpecial = value;
		}

		// Token: 0x0603A085 RID: 237701 RVA: 0x00DCB394 File Offset: 0x00DC9594
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<GiantMontagePlayHandle> PlayMontage(string montagePath)
		{
			GiantBodyActor.<PlayMontage>d__17 <PlayMontage>d__;
			<PlayMontage>d__.<>t__builder = AsyncUniTaskMethodBuilder<GiantMontagePlayHandle>.Create();
			<PlayMontage>d__.montagePath = montagePath;
			<PlayMontage>d__.<>1__state = -1;
			<PlayMontage>d__.<>t__builder.Start<GiantBodyActor.<PlayMontage>d__17>(ref <PlayMontage>d__);
			return <PlayMontage>d__.<>t__builder.Task;
		}

		// Token: 0x0603A086 RID: 237702 RVA: 0x00DCB3D8 File Offset: 0x00DC95D8
		public static void StopCurrentMontage()
		{
			UAnimInstance animInstance = GiantBodyActor.GetAnimInstance();
			UAnimMontage currentMontage = GiantBodyActor.CurrentMontage;
			if (animInstance == null || currentMontage == null)
			{
				return;
			}
			animInstance.Montage_Stop(0.25f, currentMontage);
		}

		// Token: 0x0603A087 RID: 237703 RVA: 0x00DCB404 File Offset: 0x00DC9604
		private static void OnMontageBlendingOut(UAnimMontage montage, bool bInterrupted)
		{
			if (montage != GiantBodyActor.CurrentMontage)
			{
				return;
			}
			Action currentMontageBlendOutCallback = GiantBodyActor.CurrentMontageBlendOutCallback;
			GiantBodyActor.ClearMontageBinding();
			if (currentMontageBlendOutCallback == null)
			{
				return;
			}
			currentMontageBlendOutCallback();
		}

		// Token: 0x0603A088 RID: 237704 RVA: 0x00DCB424 File Offset: 0x00DC9624
		private static void ClearMontageBinding()
		{
			UAnimInstance animInstance = GiantBodyActor.GetAnimInstance();
			if (animInstance != null)
			{
				FOnMontageBlendingOutStartedMCDelegate onMontageBlendingOut = animInstance.OnMontageBlendingOut;
				Action<UAnimMontage, bool> callback;
				if ((callback = GiantBodyActor.<>O.<0>__OnMontageBlendingOut) == null)
				{
					callback = (GiantBodyActor.<>O.<0>__OnMontageBlendingOut = new Action<UAnimMontage, bool>(GiantBodyActor.OnMontageBlendingOut));
				}
				onMontageBlendingOut.Remove(callback);
			}
			GiantBodyActor.CurrentMontage = null;
			GiantBodyActor.CurrentMontageBlendOutCallback = null;
		}

		// Token: 0x0603A089 RID: 237705 RVA: 0x00DCB46C File Offset: 0x00DC966C
		private static ABP_GhostTitan_C GetGhostTitanAnim()
		{
			ABP_GhostTitan_C ghostTitanAnim = GiantBodyActor.GhostTitanAnim;
			if (ghostTitanAnim != null && ghostTitanAnim.IsValid())
			{
				return ghostTitanAnim;
			}
			UAnimInstance animInstance = GiantBodyActor.GetAnimInstance();
			if (animInstance == null || !animInstance.IsA(ABP_GhostTitan_C.StaticClass()))
			{
				return null;
			}
			return GiantBodyActor.GhostTitanAnim = (animInstance as ABP_GhostTitan_C);
		}

		// Token: 0x0603A08A RID: 237706 RVA: 0x00DCB4B6 File Offset: 0x00DC96B6
		private static UAnimInstance GetAnimInstance()
		{
			USkeletalMeshComponent skeletalMesh = GiantBodyActor.GetSkeletalMesh();
			if (skeletalMesh == null)
			{
				return null;
			}
			return skeletalMesh.GetAnimInstance();
		}

		// Token: 0x0603A08B RID: 237707 RVA: 0x00DCB4C8 File Offset: 0x00DC96C8
		public static USkeletalMeshComponent GetSkeletalMesh()
		{
			AActor actor = GiantBodyActor.Actor;
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			return actor.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent;
		}

		// Token: 0x0401E459 RID: 123993
		private static AActor Actor;

		// Token: 0x0401E45A RID: 123994
		private static ABP_GhostTitan_C GhostTitanAnim;

		// Token: 0x0401E45B RID: 123995
		[StaticVariableRuleIgnore]
		private static readonly FVector SightTargetVector = new FVector(0f, 0f, 0f);

		// Token: 0x0401E45C RID: 123996
		private static UAnimMontage CurrentMontage;

		// Token: 0x0401E45D RID: 123997
		private static Action CurrentMontageBlendOutCallback;

		// Token: 0x0200BBE5 RID: 48101
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04038BB5 RID: 232373
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<UAnimMontage, bool> <0>__OnMontageBlendingOut;
		}
	}
}
