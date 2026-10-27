using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000003 RID: 3
[NullableContext(1)]
[Nullable(0)]
public static class ActorPoolGuard
{
	// Token: 0x06000006 RID: 6 RVA: 0x00002058 File Offset: 0x00000258
	public static bool CleanActorBeforeEnPool(AActor actor, [Nullable(2)] TClearFunction clearFunc = null)
	{
		if (clearFunc != null)
		{
			clearFunc(actor);
		}
		else
		{
			ALevelSequenceActor alevelSequenceActor = actor as ALevelSequenceActor;
			if (alevelSequenceActor != null)
			{
				ActorPoolGuard.ClearSequenceActor(alevelSequenceActor);
			}
			else
			{
				FTransformDouble ftransformDouble = new FTransformDouble();
				actor.D_K2_SetActorTransform(ftransformDouble, false, null, true);
				UKuroActorManager.ClearAcquiredComponents(actor);
				UKuroActorManager.ResetDelegates(actor);
				actor.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
				actor.SetActorHiddenInGame(true);
				TArray<UActorComponent> tarray = actor.K2_GetComponentsByClass(UActorComponent.StaticClass());
				for (int i = 0; i < tarray.Num(); i++)
				{
					if (!tarray.Get(i).IsValid())
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Log;
						ELogAuthor author = ELogAuthor.FJH;
						string message = "ActorPoolGuard.CleanActorBeforeEnPool: component is invalid";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actor", actor.GetName());
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else
					{
						UKuroActorManager.UnregisterComponent(tarray.Get(i));
					}
				}
				actor.SetActorTickEnabled(false);
				actor.SetActorEnableCollision(false);
			}
		}
		return true;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002136 File Offset: 0x00000336
	public static bool PrepareActorBeforeDePool(AActor actor)
	{
		if (!UKuroActorManager.ResetActorToDefault(actor))
		{
			return false;
		}
		actor.SetActorEnableCollision(true);
		UKuroActorManager.ResetUberGraph(actor);
		return true;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002150 File Offset: 0x00000350
	public static void ClearSequenceActor(ALevelSequenceActor actor)
	{
		actor.PlaybackSettings = new FMovieSceneSequencePlaybackSettings();
		actor.ResetBindings();
		actor.SequencePlayer.OnFinished.Clear();
		actor.SequencePlayer.OnPlay.Clear();
		actor.SequencePlayer.OnStop.Clear();
		actor.SequencePlayer.OnPause.Clear();
		actor.SequencePlayer.OnPlayReverse.Clear();
		actor.SequencePlayer.OnCameraCut.Clear();
		actor.bOverrideInstanceData = false;
		UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = actor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
		if (udefaultLevelSequenceInstanceData != null)
		{
			udefaultLevelSequenceInstanceData.TransformOrigin = new FTransform();
			udefaultLevelSequenceInstanceData.TransformOriginActor = null;
		}
		actor.SetSequence(UKuroActorManager.GetDummySequence());
	}
}
