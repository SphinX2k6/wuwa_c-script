using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CFF RID: 23807
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventSpawnDestructibleActorWithTrackCapability : LevelEventBase
	{
		// Token: 0x0603A3CE RID: 238542 RVA: 0x01074C0B File Offset: 0x01072E0B
		public LevelEventSpawnDestructibleActorWithTrackCapability(int id) : base(id)
		{
		}

		// Token: 0x0603A3CF RID: 238543 RVA: 0x01074C14 File Offset: 0x01072E14
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionSpawnDestructibleActorWithTrackCapability actionSpawnDestructibleActorWithTrackCapability = inParams as ActionSpawnDestructibleActorWithTrackCapability;
			if (actionSpawnDestructibleActorWithTrackCapability != null)
			{
				this.ExecuteNewManually(actionSpawnDestructibleActorWithTrackCapability);
			}
		}

		// Token: 0x0603A3D0 RID: 238544 RVA: 0x01074C34 File Offset: 0x01072E34
		[NullableContext(0)]
		public UniTask<bool> ExecuteNewManually([Nullable(1)] ActionSpawnDestructibleActorWithTrackCapability inParams)
		{
			LevelEventSpawnDestructibleActorWithTrackCapability.<ExecuteNewManually>d__11 <ExecuteNewManually>d__;
			<ExecuteNewManually>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteNewManually>d__.<>4__this = this;
			<ExecuteNewManually>d__.inParams = inParams;
			<ExecuteNewManually>d__.<>1__state = -1;
			<ExecuteNewManually>d__.<>t__builder.Start<LevelEventSpawnDestructibleActorWithTrackCapability.<ExecuteNewManually>d__11>(ref <ExecuteNewManually>d__);
			return <ExecuteNewManually>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3D1 RID: 238545 RVA: 0x01074C80 File Offset: 0x01072E80
		private TaskGraph LoadTypeAndResourceThenSpawnActor(SpawnDestructibleActorWithTrackCapability @params)
		{
			LevelEventSpawnDestructibleActorWithTrackCapability.<>c__DisplayClass12_0 CS$<>8__locals1 = new LevelEventSpawnDestructibleActorWithTrackCapability.<>c__DisplayClass12_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.@params = @params;
			Dictionary<string, IGraphNode> dictionary = new Dictionary<string, IGraphNode>();
			string key = "LoadKuroTrackTargetWhileRotateType";
			GraphNodeImpl graphNodeImpl = new GraphNodeImpl();
			Func<UniTask> run;
			if ((run = LevelEventSpawnDestructibleActorWithTrackCapability.<>O.<0>__LoadTypeAsync) == null)
			{
				run = (LevelEventSpawnDestructibleActorWithTrackCapability.<>O.<0>__LoadTypeAsync = new Func<UniTask>(LevelEventSpawnDestructibleActorWithTrackCapability.LoadTypeAsync));
			}
			graphNodeImpl.Run = run;
			dictionary[key] = graphNodeImpl;
			dictionary["SpawnTrackTargetWhileRotate"] = new GraphNodeImpl
			{
				Run = delegate
				{
					LevelEventSpawnDestructibleActorWithTrackCapability.<>c__DisplayClass12_0.<<LoadTypeAndResourceThenSpawnActor>b__0>d <<LoadTypeAndResourceThenSpawnActor>b__0>d;
					<<LoadTypeAndResourceThenSpawnActor>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
					<<LoadTypeAndResourceThenSpawnActor>b__0>d.<>4__this = CS$<>8__locals1;
					<<LoadTypeAndResourceThenSpawnActor>b__0>d.<>1__state = -1;
					<<LoadTypeAndResourceThenSpawnActor>b__0>d.<>t__builder.Start<LevelEventSpawnDestructibleActorWithTrackCapability.<>c__DisplayClass12_0.<<LoadTypeAndResourceThenSpawnActor>b__0>d>(ref <<LoadTypeAndResourceThenSpawnActor>b__0>d);
					return <<LoadTypeAndResourceThenSpawnActor>b__0>d.<>t__builder.Task;
				}
			};
			dictionary["KuroDestructibleAsset"] = new GraphNodeImpl
			{
				Run = (() => CS$<>8__locals1.<>4__this.LoadKuroDestructibleAsset(CS$<>8__locals1.@params.KuroDestructibleAsset, typeof(UKuroDestructibleAsset)))
			};
			dictionary["SpawnKuroDestructibleActor"] = new GraphNodeImpl
			{
				Run = (() => CS$<>8__locals1.<>4__this.SpawnKuroDestructibleActor(CS$<>8__locals1.@params.StartTransform))
			};
			dictionary["KuroDestructibleDestructionAsset"] = new GraphNodeImpl
			{
				Run = (() => CS$<>8__locals1.<>4__this.LoadKuroDestructibleDestructionAssetName(CS$<>8__locals1.@params.KuroDestructibleDestructionAsset, typeof(UKuroDestructibleDestructionAsset)))
			};
			List<ValueTuple<string, string>> dependencies = new List<ValueTuple<string, string>>
			{
				new ValueTuple<string, string>("KuroDestructibleAsset", "SpawnKuroDestructibleActor"),
				new ValueTuple<string, string>("KuroDestructibleDestructionAsset", "SpawnKuroDestructibleActor"),
				new ValueTuple<string, string>("LoadKuroTrackTargetWhileRotateType", "SpawnTrackTargetWhileRotate")
			};
			return new TaskGraph(dictionary, dependencies);
		}

		// Token: 0x0603A3D2 RID: 238546 RVA: 0x01074DAA File Offset: 0x01072FAA
		private void ResetResource()
		{
			this.KuroDestructibleAsset = null;
			this.KuroDestructibleDestructionAsset = null;
			this.KuroDestructibleActor = null;
			this.TrackTargetWhileRotateActor = null;
		}

		// Token: 0x0603A3D3 RID: 238547 RVA: 0x01074DC8 File Offset: 0x01072FC8
		private UniTask LoadKuroDestructibleAsset(string path, Type type)
		{
			LevelEventSpawnDestructibleActorWithTrackCapability.<LoadKuroDestructibleAsset>d__14 <LoadKuroDestructibleAsset>d__;
			<LoadKuroDestructibleAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadKuroDestructibleAsset>d__.<>4__this = this;
			<LoadKuroDestructibleAsset>d__.path = path;
			<LoadKuroDestructibleAsset>d__.<>1__state = -1;
			<LoadKuroDestructibleAsset>d__.<>t__builder.Start<LevelEventSpawnDestructibleActorWithTrackCapability.<LoadKuroDestructibleAsset>d__14>(ref <LoadKuroDestructibleAsset>d__);
			return <LoadKuroDestructibleAsset>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3D4 RID: 238548 RVA: 0x01074E14 File Offset: 0x01073014
		private UniTask LoadKuroDestructibleDestructionAssetName(string path, Type type)
		{
			LevelEventSpawnDestructibleActorWithTrackCapability.<LoadKuroDestructibleDestructionAssetName>d__15 <LoadKuroDestructibleDestructionAssetName>d__;
			<LoadKuroDestructibleDestructionAssetName>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadKuroDestructibleDestructionAssetName>d__.<>4__this = this;
			<LoadKuroDestructibleDestructionAssetName>d__.path = path;
			<LoadKuroDestructibleDestructionAssetName>d__.<>1__state = -1;
			<LoadKuroDestructibleDestructionAssetName>d__.<>t__builder.Start<LevelEventSpawnDestructibleActorWithTrackCapability.<LoadKuroDestructibleDestructionAssetName>d__15>(ref <LoadKuroDestructibleDestructionAssetName>d__);
			return <LoadKuroDestructibleDestructionAssetName>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3D5 RID: 238549 RVA: 0x01074E60 File Offset: 0x01073060
		private static UniTask LoadTypeAsync()
		{
			LevelEventSpawnDestructibleActorWithTrackCapability.<LoadTypeAsync>d__16 <LoadTypeAsync>d__;
			<LoadTypeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTypeAsync>d__.<>1__state = -1;
			<LoadTypeAsync>d__.<>t__builder.Start<LevelEventSpawnDestructibleActorWithTrackCapability.<LoadTypeAsync>d__16>(ref <LoadTypeAsync>d__);
			return <LoadTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3D6 RID: 238550 RVA: 0x01074E9C File Offset: 0x0107309C
		private UniTask SpawnKuroDestructibleActor(FTransformDouble spawnTransform)
		{
			UKuroDestructibleAsset kuroDestructibleAsset = this.KuroDestructibleAsset;
			if (kuroDestructibleAsset != null && kuroDestructibleAsset.IsValid())
			{
				UKuroDestructibleDestructionAsset kuroDestructibleDestructionAsset = this.KuroDestructibleDestructionAsset;
				if (kuroDestructibleDestructionAsset != null && kuroDestructibleDestructionAsset.IsValid())
				{
					this.KuroDestructibleActor = (UGameplayStatics.D_BeginDeferredActorSpawnFromClass(Global.BaseCharacter, AKuroDestructibleActor.StaticClass(), spawnTransform, ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn, null) as AKuroDestructibleActor);
					AKuroDestructibleActor kuroDestructibleActor = this.KuroDestructibleActor;
					if (kuroDestructibleActor == null || !kuroDestructibleActor.IsValid())
					{
						return UniTask.CompletedTask;
					}
					this.KuroDestructibleActor.KuroDestructibleAsset = this.KuroDestructibleAsset;
					this.KuroDestructibleActor.KuroDestructibleDestructionAsset = this.KuroDestructibleDestructionAsset;
					UGameplayStatics.D_FinishSpawningActor(this.KuroDestructibleActor, spawnTransform);
					return UniTask.CompletedTask;
				}
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x0401EBF9 RID: 125945
		[Nullable(2)]
		private UKuroDestructibleAsset KuroDestructibleAsset;

		// Token: 0x0401EBFA RID: 125946
		[Nullable(2)]
		private UKuroDestructibleDestructionAsset KuroDestructibleDestructionAsset;

		// Token: 0x0401EBFB RID: 125947
		[Nullable(2)]
		private AKuroDestructibleActor KuroDestructibleActor;

		// Token: 0x0401EBFC RID: 125948
		[Nullable(2)]
		private AActor TrackTargetWhileRotateActor;

		// Token: 0x0401EBFD RID: 125949
		private const string KuroDestructibleAssetName = "KuroDestructibleAsset";

		// Token: 0x0401EBFE RID: 125950
		private const string KuroDestructibleDestructionAssetName = "KuroDestructibleDestructionAsset";

		// Token: 0x0401EBFF RID: 125951
		private const string SpawnKuroDestructibleActorFunc = "SpawnKuroDestructibleActor";

		// Token: 0x0401EC00 RID: 125952
		private const string LoadKuroTrackTargetWhileRotateType = "LoadKuroTrackTargetWhileRotateType";

		// Token: 0x0401EC01 RID: 125953
		private const string SpawnTrackTargetWhileRotate = "SpawnTrackTargetWhileRotate";

		// Token: 0x0200B7FF RID: 47103
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04038DAE RID: 232878
			[Nullable(0)]
			public static Func<UniTask> <0>__LoadTypeAsync;
		}
	}
}
