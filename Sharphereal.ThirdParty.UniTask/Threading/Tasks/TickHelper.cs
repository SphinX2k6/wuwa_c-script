using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Sharphereal.Core;
using Sharphereal.UniTaskExtensions.Threading.Tasks.Internal;
using UnrealEngine;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks
{
	// Token: 0x02000005 RID: 5
	[NullableContext(1)]
	[Nullable(0)]
	public static class TickHelper
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000221D File Offset: 0x0000041D
		public static int MainThreadId
		{
			get
			{
				return TickHelper.mainThreadId;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002224 File Offset: 0x00000424
		public static bool IsMainThread
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId == TickHelper.mainThreadId;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002237 File Offset: 0x00000437
		private static void Init()
		{
			TickHelper.mainThreadId = Thread.CurrentThread.ManagedThreadId;
			if (TickHelper.runners != null)
			{
				return;
			}
			TickHelper.Initialize();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002255 File Offset: 0x00000455
		private static void Destroy()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002257 File Offset: 0x00000457
		private static void InsertLoop(PlayerLoopTiming targetTiming)
		{
			TickHelper.yielders[(int)targetTiming] = new ContinuationQueue(targetTiming);
			TickHelper.runners[(int)targetTiming] = new PlayerLoopRunner(targetTiming);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002274 File Offset: 0x00000474
		public static void Initialize()
		{
			SynchronizationContext.SetSynchronizationContext(new UniTaskSynchronizationContext());
			TickHelper.yielders = new ContinuationQueue[7];
			TickHelper.runners = new PlayerLoopRunner[7];
			TickHelper.InsertLoop(PlayerLoopTiming.PrePhysics);
			TickHelper.InsertLoop(PlayerLoopTiming.StartPhysics);
			TickHelper.InsertLoop(PlayerLoopTiming.DuringPhysics);
			TickHelper.InsertLoop(PlayerLoopTiming.EndPhysics);
			TickHelper.InsertLoop(PlayerLoopTiming.PostPhysics);
			TickHelper.InsertLoop(PlayerLoopTiming.PostUpdateWork);
			TickHelper.InsertLoop(PlayerLoopTiming.LastDemotable);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022CB File Offset: 0x000004CB
		public static void AddContinuation(PlayerLoopTiming timing, Action continuation)
		{
			ContinuationQueue continuationQueue = TickHelper.yielders[(int)timing];
			if (continuationQueue == null)
			{
				throw new InvalidOperationException("Target playerLoopTiming is not injected. Please check PlayerLoopHelper.Initialize. PlayerLoopTiming:" + timing.ToString());
			}
			continuationQueue.Enqueue(continuation);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022FA File Offset: 0x000004FA
		public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action)
		{
			PlayerLoopRunner playerLoopRunner = TickHelper.runners[(int)timing];
			if (playerLoopRunner == null)
			{
				throw new InvalidOperationException("Target playerLoopTiming is not injected. Please check PlayerLoopHelper.Initialize. PlayerLoopTiming:" + timing.ToString());
			}
			playerLoopRunner.AddAction(action);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002329 File Offset: 0x00000529
		private static void Tick(ETickingGroup tickingGroup, float deltaTime, float unscaledDeltaTime)
		{
			if (tickingGroup == ETickingGroup.TG_NewlySpawned)
			{
				return;
			}
			if (tickingGroup == ETickingGroup.TG_PrePhysics)
			{
				Time.Tick(deltaTime, unscaledDeltaTime);
			}
			UniTaskSynchronizationContext.Run();
			ContinuationQueue continuationQueue = TickHelper.yielders[(int)tickingGroup];
			if (continuationQueue != null)
			{
				continuationQueue.Run();
			}
			PlayerLoopRunner playerLoopRunner = TickHelper.runners[(int)tickingGroup];
			if (playerLoopRunner == null)
			{
				return;
			}
			playerLoopRunner.Run();
		}

		// Token: 0x0400000B RID: 11
		private static int mainThreadId;

		// Token: 0x0400000C RID: 12
		[Nullable(2)]
		private static ContinuationQueue[] yielders;

		// Token: 0x0400000D RID: 13
		[Nullable(2)]
		private static PlayerLoopRunner[] runners;
	}
}
