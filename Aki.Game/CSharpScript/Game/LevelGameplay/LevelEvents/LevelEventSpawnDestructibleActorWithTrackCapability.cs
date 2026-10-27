using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B87 RID: 27527
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventSpawnDestructibleActorWithTrackCapability : LevelEventBase
	{
		// Token: 0x0604427C RID: 279164 RVA: 0x010CAF73 File Offset: 0x010C9173
		public LevelEventSpawnDestructibleActorWithTrackCapability(int id) : base(id)
		{
		}

		// Token: 0x0604427D RID: 279165 RVA: 0x010CAF7C File Offset: 0x010C917C
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionSpawnDestructibleActorWithTrackCapability actionSpawnDestructibleActorWithTrackCapability = inParams as ActionSpawnDestructibleActorWithTrackCapability;
			if (actionSpawnDestructibleActorWithTrackCapability != null)
			{
				this.ExecuteNewManually(actionSpawnDestructibleActorWithTrackCapability);
			}
		}

		// Token: 0x0604427E RID: 279166 RVA: 0x010CAF9C File Offset: 0x010C919C
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

		// Token: 0x0604427F RID: 279167 RVA: 0x010CAFE8 File Offset: 0x010C91E8
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

		// Token: 0x06044280 RID: 279168 RVA: 0x010CB112 File Offset: 0x010C9312
		private void ResetResource()
		{
			this.KuroDestructibleAsset = null;
			this.KuroDestructibleDestructionAsset = null;
			this.KuroDestructibleActor = null;
			this.TrackTargetWhileRotateActor = null;
		}

		// Token: 0x06044281 RID: 279169 RVA: 0x010CB130 File Offset: 0x010C9330
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

		// Token: 0x06044282 RID: 279170 RVA: 0x010CB17C File Offset: 0x010C937C
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

		// Token: 0x06044283 RID: 279171 RVA: 0x010CB1C8 File Offset: 0x010C93C8
		private static UniTask LoadTypeAsync()
		{
			LevelEventSpawnDestructibleActorWithTrackCapability.<LoadTypeAsync>d__16 <LoadTypeAsync>d__;
			<LoadTypeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTypeAsync>d__.<>1__state = -1;
			<LoadTypeAsync>d__.<>t__builder.Start<LevelEventSpawnDestructibleActorWithTrackCapability.<LoadTypeAsync>d__16>(ref <LoadTypeAsync>d__);
			return <LoadTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06044284 RID: 279172 RVA: 0x010CB204 File Offset: 0x010C9404
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

		// Token: 0x04023957 RID: 145751
		[Nullable(2)]
		private UKuroDestructibleAsset KuroDestructibleAsset;

		// Token: 0x04023958 RID: 145752
		[Nullable(2)]
		private UKuroDestructibleDestructionAsset KuroDestructibleDestructionAsset;

		// Token: 0x04023959 RID: 145753
		[Nullable(2)]
		private AKuroDestructibleActor KuroDestructibleActor;

		// Token: 0x0402395A RID: 145754
		[Nullable(2)]
		private AActor TrackTargetWhileRotateActor;

		// Token: 0x0402395B RID: 145755
		private const string KuroDestructibleAssetName = "KuroDestructibleAsset";

		// Token: 0x0402395C RID: 145756
		private const string KuroDestructibleDestructionAssetName = "KuroDestructibleDestructionAsset";

		// Token: 0x0402395D RID: 145757
		private const string SpawnKuroDestructibleActorFunc = "SpawnKuroDestructibleActor";

		// Token: 0x0402395E RID: 145758
		private const string LoadKuroTrackTargetWhileRotateType = "LoadKuroTrackTargetWhileRotateType";

		// Token: 0x0402395F RID: 145759
		private const string SpawnTrackTargetWhileRotate = "SpawnTrackTargetWhileRotate";

		// Token: 0x0200CC0F RID: 52239
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403D98C RID: 252300
			[Nullable(0)]
			public static Func<UniTask> <0>__LoadTypeAsync;
		}
	}
}
