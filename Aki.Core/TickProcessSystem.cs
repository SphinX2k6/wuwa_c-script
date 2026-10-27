using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000CE RID: 206
[NullableContext(1)]
[Nullable(0)]
public class TickProcessSystem : Singleton
{
	// Token: 0x0600065D RID: 1629 RVA: 0x000220BC File Offset: 0x000202BC
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

	// Token: 0x0600065E RID: 1630 RVA: 0x00022230 File Offset: 0x00020430
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

	// Token: 0x0600065F RID: 1631 RVA: 0x0002226F File Offset: 0x0002046F
	private void TickPrePhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_PrePhysics);
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00022279 File Offset: 0x00020479
	private void TickStartPhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_StartPhysics);
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00022283 File Offset: 0x00020483
	private void TickDuringPhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_DuringPhysics);
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0002228D File Offset: 0x0002048D
	private void TickEndPhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_EndPhysics);
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00022297 File Offset: 0x00020497
	private void TickPostPhysics(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_PostPhysics);
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x000222A1 File Offset: 0x000204A1
	private void TickPostUpdateWork(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_PostUpdateWork);
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x000222AB File Offset: 0x000204AB
	private void TickLastDemotable(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_LastDemotable);
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x000222B5 File Offset: 0x000204B5
	private void TickNewlySpawned(float deltaTime)
	{
		this.Tick(deltaTime, ETickingGroup.TG_NewlySpawned);
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x000222C0 File Offset: 0x000204C0
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
		if (this.RemoveProcessSet.Count > 0)
		{
			foreach (int processId in this.RemoveProcessSet)
			{
				this.UnregisterTickProcess(processId);
			}
			this.RemoveProcessSet.Clear();
		}
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x000223B4 File Offset: 0x000205B4
	public void Initialize()
	{
		this.TickerMap.Clear();
		this.RemoveProcessSet.Clear();
		this.IsTicking = false;
		this.TickProcessGroupMap.Clear();
		this.TickProcessMap.Clear();
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x000223EC File Offset: 0x000205EC
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
		if (this.TickProcessGroupMap.TryGetValue(group, out hashSet))
		{
			hashSet.Add(tickProcess);
		}
		this.TickProcessMap[tickProcess.Id] = tickProcess;
		return tickProcess.Id;
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00022468 File Offset: 0x00020668
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
		if (this.TickProcessGroupMap.TryGetValue(group, out hashSet))
		{
			hashSet.Add(tickProcess);
		}
		this.TickProcessMap[tickProcess.Id] = tickProcess;
		return tickProcess.Id;
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x000224E4 File Offset: 0x000206E4
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
		if (this.TickProcessGroupMap.TryGetValue(group, out hashSet))
		{
			hashSet.Add(tickProcess);
		}
		this.TickProcessMap[tickProcess.Id] = tickProcess;
		return tickProcess.Id;
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x0002255C File Offset: 0x0002075C
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

	// Token: 0x0600066D RID: 1645 RVA: 0x000225C0 File Offset: 0x000207C0
	public void Clear()
	{
		foreach (ETickingGroup group in this.TickProcessGroupMap.Keys)
		{
			this.RemoveFromTickSystem(group);
		}
		this.TickProcessMap.Clear();
		this.TickProcessGroupMap.Clear();
		this.RemoveProcessSet.Clear();
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x0600066E RID: 1646 RVA: 0x0002263C File Offset: 0x0002083C
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

	// Token: 0x0600066F RID: 1647 RVA: 0x0002265F File Offset: 0x0002085F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00022661 File Offset: 0x00020861
	public static void ResetStaticDefaultValue()
	{
		TickProcessSystem instance = TickProcessSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TickProcessSystem._instance = null;
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x0002267A File Offset: 0x0002087A
	static TickProcessSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TickProcessSystem.CreateStaticDefaultValue), new Action(TickProcessSystem.ResetStaticDefaultValue));
	}

	// Token: 0x04000528 RID: 1320
	private readonly Dictionary<ETickingGroup, Ticker> TickerMap = new Dictionary<ETickingGroup, Ticker>();

	// Token: 0x04000529 RID: 1321
	private readonly HashSet<int> RemoveProcessSet = new HashSet<int>();

	// Token: 0x0400052A RID: 1322
	private bool IsTicking;

	// Token: 0x0400052B RID: 1323
	private readonly Dictionary<ETickingGroup, HashSet<TickProcess>> TickProcessGroupMap = new Dictionary<ETickingGroup, HashSet<TickProcess>>();

	// Token: 0x0400052C RID: 1324
	private readonly Dictionary<int, TickProcess> TickProcessMap = new Dictionary<int, TickProcess>();

	// Token: 0x0400052D RID: 1325
	[Nullable(2)]
	private static TickProcessSystem _instance;
}
