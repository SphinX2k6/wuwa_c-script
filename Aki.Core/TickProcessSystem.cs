using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000D0 RID: 208
[NullableContext(1)]
[Nullable(0)]
public class TickProcessSystem : Singleton
{
	// Token: 0x0600069E RID: 1694 RVA: 0x00022594 File Offset: 0x00020794
	private void AddToTickSystem(ETickingGroup group, bool tickEvenPaused)
	{
		if (this.TickerMap.ContainsKey(group))
		{
			return;
		}
		Ticker ticker = null;
		switch (group)
		{
		case ETickingGroup.TG_PrePhysics:
			ticker = TickSystem.Instance.Add(new Action<float>(this.TickPrePhysics), "TickProcess_PrePhysics", group, tickEvenPaused, 0, false);
			break;
		case ETickingGroup.TG_StartPhysics:
			ticker = TickSystem.Instance.Add(new Action<float>(this.TickStartPhysics), "TickProcess_StartPhysics", group, tickEvenPaused, 0, false);
			break;
		case ETickingGroup.TG_DuringPhysics:
			ticker = TickSystem.Instance.Add(new Action<float>(this.TickDuringPhysics), "TickProcess_DuringPhysics", group, tickEvenPaused, 0, false);
			break;
		case ETickingGroup.TG_EndPhysics:
			ticker = TickSystem.Instance.Add(new Action<float>(this.TickEndPhysics), "TickProcess_EndPhysics", group, tickEvenPaused, 0, false);
			break;
		case ETickingGroup.TG_PostPhysics:
			ticker = TickSystem.Instance.Add(new Action<float>(this.TickPostPhysics), "TickProcess_PostPhysics", group, tickEvenPaused, 0, false);
			break;
		case ETickingGroup.TG_PostUpdateWork:
			ticker = TickSystem.Instance.Add(new Action<float>(this.TickPostUpdateWork), "TickProcess_PostUpdateWork", group, tickEvenPaused, 0, false);
			break;
		case ETickingGroup.TG_LastDemotable:
			ticker = TickSystem.Instance.Add(new Action<float>(this.TickLastDemotable), "TickProcess_LastDemotable", group, tickEvenPaused, 0, false);
			break;
		case ETickingGroup.TG_NewlySpawned:
			ticker = TickSystem.Instance.Add(new Action<float>(this.TickNewlySpawned), "TickProcess_NewlySpawned", group, tickEvenPaused, 0, false);
			break;
		}
		if (ticker != null)
		{
			this.TickerMap[group] = ticker;
		}
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00022708 File Offset: 0x00020908
	private void RemoveFromTickSystem(ETickingGroup group)
	{
		Ticker ticker;
		if (!this.TickerMap.TryGetValue(group, out ticker) || ticker == null)
		{
			return;
		}
		this.TickerMap.Remove(group);
		TickSystem.Instance.Remove(ticker.Id);
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00022747 File Offset: 0x00020947
	private void TickPrePhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_PrePhysics);
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00022751 File Offset: 0x00020951
	private void TickStartPhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_StartPhysics);
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x0002275B File Offset: 0x0002095B
	private void TickDuringPhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_DuringPhysics);
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00022765 File Offset: 0x00020965
	private void TickEndPhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_EndPhysics);
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x0002276F File Offset: 0x0002096F
	private void TickPostPhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_PostPhysics);
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00022779 File Offset: 0x00020979
	private void TickPostUpdateWork(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_PostUpdateWork);
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00022783 File Offset: 0x00020983
	private void TickLastDemotable(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_LastDemotable);
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x0002278D File Offset: 0x0002098D
	private void TickNewlySpawned(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_NewlySpawned);
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00022798 File Offset: 0x00020998
	private void Tick(float deltaTime, ETickingGroup group)
	{
		if (!this.TickProcessGroupMap.ContainsKey(group))
		{
			return;
		}
		HashSet<TickProcess> hashSet = this.TickProcessGroupMap[group];
		if (hashSet.Count < 1)
		{
			return;
		}
		this.IsTicking = true;
		foreach (TickProcess tickProcess in hashSet)
		{
			if (tickProcess.Tick(deltaTime))
			{
				this.RemoveProcessSet.Add(tickProcess.Id);
			}
		}
		this.IsTicking = false;
		if (this.AddProcessSet.Count > 0)
		{
			foreach (int key in this.AddProcessSet)
			{
				TickProcess tickProcess2;
				HashSet<TickProcess> hashSet2;
				if (this.TickProcessMap.TryGetValue(key, out tickProcess2) && tickProcess2 != null && this.TickProcessGroupMap.TryGetValue(tickProcess2.Group, out hashSet2))
				{
					hashSet2.Add(tickProcess2);
				}
			}
			this.AddProcessSet.Clear();
		}
		if (this.RemoveProcessSet.Count > 0)
		{
			foreach (int processId in this.RemoveProcessSet)
			{
				this.UnregisterTickProcess(processId);
			}
			this.RemoveProcessSet.Clear();
		}
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00022918 File Offset: 0x00020B18
	public void Initialize()
	{
		this.TickerMap.Clear();
		this.RemoveProcessSet.Clear();
		this.AddProcessSet.Clear();
		this.IsTicking = false;
		this.TickProcessGroupMap.Clear();
		this.TickProcessMap.Clear();
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00022958 File Offset: 0x00020B58
	public int RegisterTickProcess(ETickingGroup group, bool tickEvenPaused, Action<float> callback, string reason)
	{
		if (!this.TickProcessGroupMap.ContainsKey(group))
		{
			this.TickProcessGroupMap[group] = new HashSet<TickProcess>();
			this.AddToTickSystem(group, tickEvenPaused);
		}
		TickProcess tickProcess = new TickProcess();
		tickProcess.Init(callback, group, ETickProcessLifeType.Forever, 0f, reason);
		HashSet<TickProcess> hashSet;
		if (this.IsTicking)
		{
			this.AddProcessSet.Add(tickProcess.Id);
		}
		else if (this.TickProcessGroupMap.TryGetValue(group, out hashSet))
		{
			hashSet.Add(tickProcess);
		}
		this.TickProcessMap[tickProcess.Id] = tickProcess;
		return tickProcess.Id;
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x000229F0 File Offset: 0x00020BF0
	public int RegisterOnceTickProcess(ETickingGroup group, bool tickEvenPaused, Action<float> callback)
	{
		if (!this.TickProcessGroupMap.ContainsKey(group))
		{
			this.TickProcessGroupMap[group] = new HashSet<TickProcess>();
			this.AddToTickSystem(group, tickEvenPaused);
		}
		TickProcess tickProcess = new TickProcess();
		tickProcess.Init(callback, group, ETickProcessLifeType.Once, 0f, null);
		HashSet<TickProcess> hashSet;
		if (this.IsTicking)
		{
			this.AddProcessSet.Add(tickProcess.Id);
		}
		else if (this.TickProcessGroupMap.TryGetValue(group, out hashSet))
		{
			hashSet.Add(tickProcess);
		}
		this.TickProcessMap[tickProcess.Id] = tickProcess;
		return tickProcess.Id;
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00022A88 File Offset: 0x00020C88
	public int RegisterDelayTickProcess(ETickingGroup group, bool tickEvenPaused, Action<float> callback, float lifeTime)
	{
		if (!this.TickProcessGroupMap.ContainsKey(group))
		{
			this.TickProcessGroupMap[group] = new HashSet<TickProcess>();
			this.AddToTickSystem(group, tickEvenPaused);
		}
		TickProcess tickProcess = new TickProcess();
		tickProcess.Init(callback, group, ETickProcessLifeType.Delay, lifeTime, null);
		HashSet<TickProcess> hashSet;
		if (this.IsTicking)
		{
			this.AddProcessSet.Add(tickProcess.Id);
		}
		else if (this.TickProcessGroupMap.TryGetValue(group, out hashSet))
		{
			hashSet.Add(tickProcess);
		}
		this.TickProcessMap[tickProcess.Id] = tickProcess;
		return tickProcess.Id;
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00022B1C File Offset: 0x00020D1C
	public void UnregisterTickProcess(int processId)
	{
		TickProcess tickProcess;
		if (!this.TickProcessMap.TryGetValue(processId, out tickProcess) || tickProcess == null)
		{
			return;
		}
		if (this.IsTicking)
		{
			this.RemoveProcessSet.Add(processId);
			return;
		}
		this.TickProcessMap.Remove(processId);
		ETickingGroup group = tickProcess.Group;
		HashSet<TickProcess> hashSet;
		if (!this.TickProcessGroupMap.TryGetValue(group, out hashSet))
		{
			return;
		}
		hashSet.Remove(tickProcess);
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00022B80 File Offset: 0x00020D80
	public void Clear()
	{
		foreach (ETickingGroup group in this.TickProcessGroupMap.Keys)
		{
			this.RemoveFromTickSystem(group);
		}
		this.TickProcessMap.Clear();
		this.TickProcessGroupMap.Clear();
		this.RemoveProcessSet.Clear();
		this.AddProcessSet.Clear();
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060006AF RID: 1711 RVA: 0x00022C04 File Offset: 0x00020E04
	public static TickProcessSystem Instance
	{
		get
		{
			if (TickProcessSystem._instance == null)
			{
				TickProcessSystem._instance = new TickProcessSystem();
				TickProcessSystem._instance.OnInit();
			}
			return TickProcessSystem._instance;
		}
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00022C27 File Offset: 0x00020E27
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00022C29 File Offset: 0x00020E29
	public static void ResetStaticDefaultValue()
	{
		TickProcessSystem instance = TickProcessSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TickProcessSystem._instance = null;
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00022C42 File Offset: 0x00020E42
	static TickProcessSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TickProcessSystem.CreateStaticDefaultValue), new Action(TickProcessSystem.ResetStaticDefaultValue));
	}

	// Token: 0x04000536 RID: 1334
	private readonly Dictionary<ETickingGroup, Ticker> TickerMap = new Dictionary<ETickingGroup, Ticker>();

	// Token: 0x04000537 RID: 1335
	private readonly HashSet<int> RemoveProcessSet = new HashSet<int>();

	// Token: 0x04000538 RID: 1336
	private readonly HashSet<int> AddProcessSet = new HashSet<int>();

	// Token: 0x04000539 RID: 1337
	private bool IsTicking;

	// Token: 0x0400053A RID: 1338
	private readonly Dictionary<ETickingGroup, HashSet<TickProcess>> TickProcessGroupMap = new Dictionary<ETickingGroup, HashSet<TickProcess>>();

	// Token: 0x0400053B RID: 1339
	private readonly Dictionary<int, TickProcess> TickProcessMap = new Dictionary<int, TickProcess>();

	// Token: 0x0400053C RID: 1340
	[Nullable(2)]
	private static TickProcessSystem _instance;
}
