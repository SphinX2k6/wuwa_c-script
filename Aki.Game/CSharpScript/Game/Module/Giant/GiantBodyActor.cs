using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.FemaleXL.Xinyuehu.R2T1XinMd10011;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004932 RID: 18738
	[NullableContext(2)]
	[Nullable(0)]
	public class GiantBodyActor : IStaticVariableResetter
	{
		// Token: 0x0602EF9C RID: 192412 RVA: 0x00D1A450 File Offset: 0x00D18650
		static GiantBodyActor()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GiantBodyActor.CreateStaticDefaultValue), new Action(GiantBodyActor.ResetStaticDefaultValue));
		}

		// Token: 0x0602EF9D RID: 192413 RVA: 0x00D1A488 File Offset: 0x00D18688
		public static void CreateStaticDefaultValue()
		{
			GiantBodyActor.Actor = null;
			GiantBodyActor.GhostTitanAnim = null;
			GiantBodyActor.CurrentMontage = null;
			GiantBodyActor.CurrentMontageBlendOutCallback = null;
		}

		// Token: 0x0602EF9E RID: 192414 RVA: 0x00D1A4A2 File Offset: 0x00D186A2
		public static void ResetStaticDefaultValue()
		{
			GiantBodyActor.Actor = null;
			GiantBodyActor.GhostTitanAnim = null;
			GiantBodyActor.CurrentMontage = null;
			GiantBodyActor.CurrentMontageBlendOutCallback = null;
		}

		// Token: 0x0602EF9F RID: 192415 RVA: 0x00D1A4BC File Offset: 0x00D186BC
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

		// Token: 0x0602EFA0 RID: 192416 RVA: 0x00D1A50C File Offset: 0x00D1870C
		public static void SetBodyVisible(bool visible)
		{
			AActor actor = GiantBodyActor.Actor;
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			actor.SetActorHiddenInGame(!visible);
		}

		// Token: 0x0602EFA1 RID: 192417 RVA: 0x00D1A53B File Offset: 0x00D1873B
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

		// Token: 0x0602EFA2 RID: 192418 RVA: 0x00D1A577 File Offset: 0x00D18777
		public static bool IsSpawned()
		{
			AActor actor = GiantBodyActor.Actor;
			return actor != null && actor.IsValid();
		}

		// Token: 0x0602EFA3 RID: 192419 RVA: 0x00D1A589 File Offset: 0x00D18789
		public static AActor GetActor()
		{
			return GiantBodyActor.Actor;
		}

		// Token: 0x0602EFA4 RID: 192420 RVA: 0x00D1A590 File Offset: 0x00D18790
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

		// Token: 0x0602EFA5 RID: 192421 RVA: 0x00D1A5CC File Offset: 0x00D187CC
		public static void SetRestVariantIsA(bool value)
		{
			ABP_GhostTitan_C ghostTitanAnim = GiantBodyActor.GetGhostTitanAnim();
			if (ghostTitanAnim == null)
			{
				return;
			}
			ghostTitanAnim.RestVariantIsA = value;
		}

		// Token: 0x0602EFA6 RID: 192422 RVA: 0x00D1A5EC File Offset: 0x00D187EC
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

		// Token: 0x0602EFA7 RID: 192423 RVA: 0x00D1A628 File Offset: 0x00D18828
		public static void SetSightPlayingSpecial(bool value)
		{
			ABP_GhostTitan_C ghostTitanAnim = GiantBodyActor.GetGhostTitanAnim();
			if (ghostTitanAnim == null)
			{
				return;
			}
			ghostTitanAnim.IsPlayingSpecial = value;
		}

		// Token: 0x0602EFA8 RID: 192424 RVA: 0x00D1A648 File Offset: 0x00D18848
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

		// Token: 0x0602EFA9 RID: 192425 RVA: 0x00D1A68C File Offset: 0x00D1888C
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

		// Token: 0x0602EFAA RID: 192426 RVA: 0x00D1A6B8 File Offset: 0x00D188B8
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

		// Token: 0x0602EFAB RID: 192427 RVA: 0x00D1A6D8 File Offset: 0x00D188D8
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

		// Token: 0x0602EFAC RID: 192428 RVA: 0x00D1A720 File Offset: 0x00D18920
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

		// Token: 0x0602EFAD RID: 192429 RVA: 0x00D1A76A File Offset: 0x00D1896A
		private static UAnimInstance GetAnimInstance()
		{
			USkeletalMeshComponent skeletalMesh = GiantBodyActor.GetSkeletalMesh();
			if (skeletalMesh == null)
			{
				return null;
			}
			return skeletalMesh.GetAnimInstance();
		}

		// Token: 0x0602EFAE RID: 192430 RVA: 0x00D1A77C File Offset: 0x00D1897C
		public static USkeletalMeshComponent GetSkeletalMesh()
		{
			AActor actor = GiantBodyActor.Actor;
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			return actor.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent;
		}

		// Token: 0x04018EF6 RID: 102134
		private static AActor Actor;

		// Token: 0x04018EF7 RID: 102135
		private static ABP_GhostTitan_C GhostTitanAnim;

		// Token: 0x04018EF8 RID: 102136
		[StaticVariableRuleIgnore]
		private static readonly FVector SightTargetVector = new FVector(0f, 0f, 0f);

		// Token: 0x04018EF9 RID: 102137
		private static UAnimMontage CurrentMontage;

		// Token: 0x04018EFA RID: 102138
		private static Action CurrentMontageBlendOutCallback;

		// Token: 0x0200A5F4 RID: 42484
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04033594 RID: 210324
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<UAnimMontage, bool> <0>__OnMontageBlendingOut;
		}
	}
}
