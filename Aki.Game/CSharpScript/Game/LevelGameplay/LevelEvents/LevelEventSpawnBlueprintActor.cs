using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CFE RID: 23806
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventSpawnBlueprintActor : LevelEventBase
	{
		// Token: 0x0603A3C8 RID: 238536 RVA: 0x010749B5 File Offset: 0x01072BB5
		public LevelEventSpawnBlueprintActor(int id) : base(id)
		{
		}

		// Token: 0x0603A3C9 RID: 238537 RVA: 0x010749BE File Offset: 0x01072BBE
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			LevelEventSpawnBlueprintActor.ExecuteNewManually(inParams, context);
		}

		// Token: 0x0603A3CA RID: 238538 RVA: 0x010749C8 File Offset: 0x01072BC8
		public unsafe static void ExecuteNewManually(ActionParams inParams, [Nullable(2)] GeneralContext context = null)
		{
			ActionSpawnBlueprintActor actionSpawnBlueprintActor = inParams as ActionSpawnBlueprintActor;
			if (actionSpawnBlueprintActor != null)
			{
				if (actionSpawnBlueprintActor.SpawnBlueprintParam == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "[LevelEventSpawnBlueprintActor] 无效参数";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("inParams", inParams);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("context", context);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				if (actionSpawnBlueprintActor.SpawnBlueprintParam.Type == ELevelEventBlueprintToSpawnType.DestructibleStoneTrackTargetWhileRotate)
				{
					LevelEventSpawnBlueprintActor.SpawnDestructibleStoneTrackTargetWhileRotate(actionSpawnBlueprintActor.SpawnBlueprintParam);
				}
			}
		}

		// Token: 0x0603A3CB RID: 238539 RVA: 0x01074A54 File Offset: 0x01072C54
		private static UniTask LoadTypeAsync(EBpTypeName name)
		{
			LevelEventSpawnBlueprintActor.<LoadTypeAsync>d__3 <LoadTypeAsync>d__;
			<LoadTypeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTypeAsync>d__.name = name;
			<LoadTypeAsync>d__.<>1__state = -1;
			<LoadTypeAsync>d__.<>t__builder.Start<LevelEventSpawnBlueprintActor.<LoadTypeAsync>d__3>(ref <LoadTypeAsync>d__);
			return <LoadTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3CC RID: 238540 RVA: 0x01074A98 File Offset: 0x01072C98
		private static void ApplyRotateParam([Nullable(2)] UKuroFauxPhysicsRotateComponentBase baseRotateComponent, IFauxPhysicsRotateParam rotateParam)
		{
			if (baseRotateComponent != null && baseRotateComponent.IsValid())
			{
				baseRotateComponent.ResetInternalState();
				FVector? fvector = null;
				if (rotateParam.RelativeOffset != null)
				{
					FVector fvector2 = baseRotateComponent.K2_GetComponentLocation();
					FVector? relativeOffset = rotateParam.RelativeOffset;
					FVector? fvector3;
					if (relativeOffset == null)
					{
						fvector3 = null;
					}
					else
					{
						FVector fvector4 = relativeOffset.GetValueOrDefault();
						fvector3 = new FVector?(fvector2 + fvector4);
					}
					fvector = fvector3;
				}
				if (rotateParam.Origin != null)
				{
					fvector = rotateParam.Origin;
				}
				if (fvector != null)
				{
					if (rotateParam.Impulse != null)
					{
						FVector fvector4 = fvector.Value;
						FVector fvector2 = rotateParam.Impulse.Value;
						baseRotateComponent.ApplyImpulse(fvector4, fvector2);
					}
					if (rotateParam.Force != null)
					{
						FVector fvector4 = fvector.Value;
						FVector fvector2 = rotateParam.Force.Value;
						baseRotateComponent.ApplyForce(fvector4, fvector2);
					}
					if (rotateParam.Movement != null)
					{
						FVector fvector4 = fvector.Value;
						FVector fvector2 = rotateParam.Movement.Value;
						baseRotateComponent.ApplyMovement(fvector4, fvector2);
					}
				}
			}
		}

		// Token: 0x0603A3CD RID: 238541 RVA: 0x01074BC8 File Offset: 0x01072DC8
		private static UniTask SpawnDestructibleStoneTrackTargetWhileRotate(ISpawnDestructibleStoneTrackTargetWhileRotate inParams)
		{
			LevelEventSpawnBlueprintActor.<SpawnDestructibleStoneTrackTargetWhileRotate>d__5 <SpawnDestructibleStoneTrackTargetWhileRotate>d__;
			<SpawnDestructibleStoneTrackTargetWhileRotate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SpawnDestructibleStoneTrackTargetWhileRotate>d__.inParams = inParams;
			<SpawnDestructibleStoneTrackTargetWhileRotate>d__.<>1__state = -1;
			<SpawnDestructibleStoneTrackTargetWhileRotate>d__.<>t__builder.Start<LevelEventSpawnBlueprintActor.<SpawnDestructibleStoneTrackTargetWhileRotate>d__5>(ref <SpawnDestructibleStoneTrackTargetWhileRotate>d__);
			return <SpawnDestructibleStoneTrackTargetWhileRotate>d__.<>t__builder.Task;
		}
	}
}
