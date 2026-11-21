using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02003F75 RID: 16245
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineAnimationSequencer
	{
		// Token: 0x1700532E RID: 21294
		// (get) Token: 0x060291CD RID: 168397 RVA: 0x00B8AE0D File Offset: 0x00B8900D
		public bool IsPlaying
		{
			get
			{
				return this.Playing;
			}
		}

		// Token: 0x060291CE RID: 168398 RVA: 0x00B8AE15 File Offset: 0x00B89015
		public void Stop()
		{
			if (!this.Playing)
			{
				return;
			}
			this.StopRequested = true;
			CustomPromise stopPromise = this.StopPromise;
			if (stopPromise == null)
			{
				return;
			}
			stopPromise.SetResult();
		}

		// Token: 0x060291CF RID: 168399 RVA: 0x00B8AE38 File Offset: 0x00B89038
		public UniTask PlayAsync(QuestMultiLineTimePointData timePoint, IAnimationSequencerContext context)
		{
			QuestMultiLineAnimationSequencer.<PlayAsync>d__6 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.timePoint = timePoint;
			<PlayAsync>d__.context = context;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<QuestMultiLineAnimationSequencer.<PlayAsync>d__6>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060291D0 RID: 168400 RVA: 0x00B8AE8C File Offset: 0x00B8908C
		public UniTask PlayBranchSelectAsync(IReadOnlyList<QuestMultiLineComponentData> components, IReadOnlyList<int> fightAreas, IAnimationSequencerContext context)
		{
			QuestMultiLineAnimationSequencer.<PlayBranchSelectAsync>d__7 <PlayBranchSelectAsync>d__;
			<PlayBranchSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBranchSelectAsync>d__.<>4__this = this;
			<PlayBranchSelectAsync>d__.components = components;
			<PlayBranchSelectAsync>d__.fightAreas = fightAreas;
			<PlayBranchSelectAsync>d__.context = context;
			<PlayBranchSelectAsync>d__.<>1__state = -1;
			<PlayBranchSelectAsync>d__.<>t__builder.Start<QuestMultiLineAnimationSequencer.<PlayBranchSelectAsync>d__7>(ref <PlayBranchSelectAsync>d__);
			return <PlayBranchSelectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060291D1 RID: 168401 RVA: 0x00B8AEE8 File Offset: 0x00B890E8
		private UniTask RunAsync(QuestMultiLineTimePointData timePoint, IAnimationSequencerContext context)
		{
			QuestMultiLineAnimationSequencer.<RunAsync>d__8 <RunAsync>d__;
			<RunAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunAsync>d__.<>4__this = this;
			<RunAsync>d__.timePoint = timePoint;
			<RunAsync>d__.context = context;
			<RunAsync>d__.<>1__state = -1;
			<RunAsync>d__.<>t__builder.Start<QuestMultiLineAnimationSequencer.<RunAsync>d__8>(ref <RunAsync>d__);
			return <RunAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060291D2 RID: 168402 RVA: 0x00B8AF3B File Offset: 0x00B8913B
		private List<int> GetSortedUnlockedGroupIds(QuestMultiLineTimePointData timePoint)
		{
			List<int> list = this.ExtractGroupIds(timePoint);
			list.Sort((int a, int b) => a - b);
			return list;
		}

		// Token: 0x060291D3 RID: 168403 RVA: 0x00B8AF6C File Offset: 0x00B8916C
		private List<int> ExtractGroupIds(QuestMultiLineTimePointData timePoint)
		{
			List<int> list = new List<int>();
			Dictionary<int, QuestMultiLineComponentData> unlockComponent = timePoint.UnlockComponent;
			foreach (int num in timePoint.ComponentGroup)
			{
				QuestBranchComponentGroup? branchComponentGroupConfig = QuestMultiLineConfig.GetBranchComponentGroupConfig(num);
				if (branchComponentGroupConfig != null)
				{
					bool flag = false;
					foreach (int key in branchComponentGroupConfig.Value.BranchComponents())
					{
						if (unlockComponent.ContainsKey(key))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						list.Add(num);
					}
				}
			}
			return list;
		}

		// Token: 0x060291D4 RID: 168404 RVA: 0x00B8B000 File Offset: 0x00B89200
		private UniTask RaceEachWithStop<[Nullable(2)] T>(IReadOnlyList<T> items, Func<T, UniTask> run, int index = 0)
		{
			QuestMultiLineAnimationSequencer.<RaceEachWithStop>d__11<T> <RaceEachWithStop>d__;
			<RaceEachWithStop>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RaceEachWithStop>d__.<>4__this = this;
			<RaceEachWithStop>d__.items = items;
			<RaceEachWithStop>d__.run = run;
			<RaceEachWithStop>d__.index = index;
			<RaceEachWithStop>d__.<>1__state = -1;
			<RaceEachWithStop>d__.<>t__builder.Start<QuestMultiLineAnimationSequencer.<RaceEachWithStop>d__11<T>>(ref <RaceEachWithStop>d__);
			return <RaceEachWithStop>d__.<>t__builder.Task;
		}

		// Token: 0x060291D5 RID: 168405 RVA: 0x00B8B05C File Offset: 0x00B8925C
		private UniTask RunOneGroupAnimations(int groupId, QuestMultiLineTimePointData timePoint, IAnimationSequencerContext context)
		{
			QuestMultiLineAnimationSequencer.<RunOneGroupAnimations>d__12 <RunOneGroupAnimations>d__;
			<RunOneGroupAnimations>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunOneGroupAnimations>d__.<>4__this = this;
			<RunOneGroupAnimations>d__.groupId = groupId;
			<RunOneGroupAnimations>d__.timePoint = timePoint;
			<RunOneGroupAnimations>d__.context = context;
			<RunOneGroupAnimations>d__.<>1__state = -1;
			<RunOneGroupAnimations>d__.<>t__builder.Start<QuestMultiLineAnimationSequencer.<RunOneGroupAnimations>d__12>(ref <RunOneGroupAnimations>d__);
			return <RunOneGroupAnimations>d__.<>t__builder.Task;
		}

		// Token: 0x060291D6 RID: 168406 RVA: 0x00B8B0B8 File Offset: 0x00B892B8
		private UniTask RunGroupsSequentially(QuestMultiLineTimePointData timePoint, IAnimationSequencerContext context, IReadOnlyList<int> groupIds, int index)
		{
			QuestMultiLineAnimationSequencer.<RunGroupsSequentially>d__13 <RunGroupsSequentially>d__;
			<RunGroupsSequentially>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunGroupsSequentially>d__.<>4__this = this;
			<RunGroupsSequentially>d__.timePoint = timePoint;
			<RunGroupsSequentially>d__.context = context;
			<RunGroupsSequentially>d__.groupIds = groupIds;
			<RunGroupsSequentially>d__.index = index;
			<RunGroupsSequentially>d__.<>1__state = -1;
			<RunGroupsSequentially>d__.<>t__builder.Start<QuestMultiLineAnimationSequencer.<RunGroupsSequentially>d__13>(ref <RunGroupsSequentially>d__);
			return <RunGroupsSequentially>d__.<>t__builder.Task;
		}

		// Token: 0x060291D7 RID: 168407 RVA: 0x00B8B11C File Offset: 0x00B8931C
		private UniTask RunBranchSelectAsync(IReadOnlyList<QuestMultiLineComponentData> components, IReadOnlyList<int> fightAreas, IAnimationSequencerContext context)
		{
			QuestMultiLineAnimationSequencer.<RunBranchSelectAsync>d__14 <RunBranchSelectAsync>d__;
			<RunBranchSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunBranchSelectAsync>d__.<>4__this = this;
			<RunBranchSelectAsync>d__.components = components;
			<RunBranchSelectAsync>d__.fightAreas = fightAreas;
			<RunBranchSelectAsync>d__.context = context;
			<RunBranchSelectAsync>d__.<>1__state = -1;
			<RunBranchSelectAsync>d__.<>t__builder.Start<QuestMultiLineAnimationSequencer.<RunBranchSelectAsync>d__14>(ref <RunBranchSelectAsync>d__);
			return <RunBranchSelectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060291D8 RID: 168408 RVA: 0x00B8B178 File Offset: 0x00B89378
		private List<QuestMultiLineComponentData> BuildComponentsOfGroup(int[] componentIds, Dictionary<int, QuestMultiLineComponentData> unlockMap)
		{
			List<QuestMultiLineComponentData> list = new List<QuestMultiLineComponentData>();
			foreach (int key in componentIds)
			{
				QuestMultiLineComponentData item;
				if (unlockMap.TryGetValue(key, out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060291D9 RID: 168409 RVA: 0x00B8B1B4 File Offset: 0x00B893B4
		private UniTask RaceWithStop(UniTask p)
		{
			QuestMultiLineAnimationSequencer.<RaceWithStop>d__16 <RaceWithStop>d__;
			<RaceWithStop>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RaceWithStop>d__.<>4__this = this;
			<RaceWithStop>d__.p = p;
			<RaceWithStop>d__.<>1__state = -1;
			<RaceWithStop>d__.<>t__builder.Start<QuestMultiLineAnimationSequencer.<RaceWithStop>d__16>(ref <RaceWithStop>d__);
			return <RaceWithStop>d__.<>t__builder.Task;
		}

		// Token: 0x040165FF RID: 91647
		private bool Playing;

		// Token: 0x04016600 RID: 91648
		private bool StopRequested;

		// Token: 0x04016601 RID: 91649
		[Nullable(2)]
		private CustomPromise StopPromise;
	}
}
