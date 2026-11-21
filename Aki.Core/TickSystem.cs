using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000D2 RID: 210
[NullableContext(1)]
[Nullable(0)]
public class TickSystem : Singleton
{
	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00022D15 File Offset: 0x00020F15
	// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00022D33 File Offset: 0x00020F33
	public bool IsPaused
	{
		get
		{
			return this.IsPausedInternal && Time.Instance.Frame > this.PausedFrame;
		}
		set
		{
			this.IsPausedInternal = value;
			if (value)
			{
				this.PausedFrame = Time.Instance.Frame;
			}
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00022D4F File Offset: 0x00020F4F
	public bool IsSetPaused
	{
		get
		{
			return this.IsPausedInternal;
		}
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00022D57 File Offset: 0x00020F57
	public void Initialize(UGameInstance gameInstance)
	{
		this.KuroTickManager = new UKuroTickManager(gameInstance, null, EObjectFlags.RF_NoFlags);
		this.Tickers.Clear();
		this.Groups.Clear();
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00022D80 File Offset: 0x00020F80
	public void Destroy()
	{
		foreach (KeyValuePair<ETickingGroup, Action<float>> keyValuePair in this.Delegates)
		{
			ETickingGroup etickingGroup;
			Action<float> callBack;
			keyValuePair.Deconstruct(out etickingGroup, out callBack);
			DelegateUtils.ReleaseManualReleaseDelegate(callBack);
		}
		this.KuroTickManager.ClearTick();
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00022DE8 File Offset: 0x00020FE8
	public bool Has(int id)
	{
		return id > 0 && this.Tickers.ContainsKey(id);
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00022DFC File Offset: 0x00020FFC
	[NullableContext(2)]
	public Ticker Add(Action<float> handle, [Nullable(1)] string name, ETickingGroup group = ETickingGroup.TG_PrePhysics, bool tickEvenPaused = false, int priority = 0, bool ignoreSelfCenterMode = false)
	{
		if (handle == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Tick;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "处理方法不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", handle);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		int num = this.Increment + 1;
		this.Increment = num;
		int num2 = num;
		Ticker ticker = new Ticker(num2, handle, group, priority, name, 0, tickEvenPaused, ignoreSelfCenterMode);
		this.Tickers[num2] = ticker;
		List<List<Ticker>> list;
		this.Groups.TryGetValue(group, out list);
		if (list == null)
		{
			list = new List<List<Ticker>>();
			this.Groups[group] = list;
		}
		while (list.Count <= priority)
		{
			list.Add(null);
		}
		List<Ticker> set = list[priority];
		if (set != null)
		{
			set.Add(ticker);
			return ticker;
		}
		set = new List<Ticker>();
		set.Add(ticker);
		list[priority] = set;
		Action<float> action = delegate(float delta)
		{
			this.IsIterating = true;
			this.IteratingGroup = group;
			this.IteratingPriority = priority;
			float num3 = delta * 1000f;
			for (int i = 0; i < set.Count; i++)
			{
				Ticker ticker2 = set[i];
				if (!ticker2.PendingRemove && (!this.IsPaused || ticker2.TickEvenPaused))
				{
					float delta2 = ticker2.IgnoreSelfCenterMode ? (num3 * Time.Instance.InverseSelfCenteredTimeDilation) : num3;
					this.Handle(ticker2, delta2);
				}
			}
			this.IsIterating = false;
			foreach (int id in this.PendingRemoveIds)
			{
				this.Remove(id);
			}
			this.PendingRemoveIds.Clear();
		};
		this.Delegates[group] = action;
		this.KuroTickManager.AddTick(group, DelegateUtils.ToManualReleaseDelegate<FTickHandler>(action), priority);
		return ticker;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00022F64 File Offset: 0x00021164
	public unsafe bool Remove(int id)
	{
		Ticker ticker;
		this.Tickers.TryGetValue(id, out ticker);
		if (ticker == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Tick;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "编号不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (this.IsIterating && this.IteratingGroup == ticker.Group && this.IteratingPriority == ticker.Priority)
		{
			ticker.PendingRemove = true;
			this.PendingRemoveIds.Add(id);
			return true;
		}
		this.Tickers.Remove(id);
		List<List<Ticker>> list;
		this.Groups.TryGetValue(ticker.Group, out list);
		if (list == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Tick;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "分组不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("group", ticker.Group);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (list.Count <= ticker.Priority || list[ticker.Priority] == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Tick;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "优先级不存在";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("id", id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("group", ticker.Group);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("priority", ticker.Priority);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		List<Ticker> list2 = list[ticker.Priority];
		list2.Remove(ticker);
		if (list2.Count == 0)
		{
			this.Groups.Remove(ticker.Group);
			Action<float> callBack;
			this.Delegates.TryGetValue(ticker.Group, out callBack);
			this.Delegates.Remove(ticker.Group);
			this.KuroTickManager.RemoveTick(ticker.Group);
			DelegateUtils.ReleaseManualReleaseDelegate(callBack);
		}
		return true;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00023184 File Offset: 0x00021384
	public bool Pause(int id)
	{
		Ticker ticker;
		this.Tickers.TryGetValue(id, out ticker);
		if (ticker == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Tick;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "编号不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		ticker.Pause = true;
		return true;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x000231D8 File Offset: 0x000213D8
	public bool Resume(int id)
	{
		Ticker ticker;
		this.Tickers.TryGetValue(id, out ticker);
		if (ticker == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Tick;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "编号不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		ticker.Pause = false;
		return true;
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x0002322C File Offset: 0x0002142C
	private unsafe void Handle(Ticker ticker, float delta)
	{
		if (ticker.Pause)
		{
			return;
		}
		float obj = delta;
		if (ticker.TickIntervalMs > 0)
		{
			ticker.CoolDown += delta;
			if (ticker.CoolDown < (float)ticker.TickIntervalMs)
			{
				return;
			}
			float num = ticker.CoolDown % (float)ticker.TickIntervalMs;
			obj = ticker.CoolDown - num;
			ticker.CoolDown = num;
		}
		ticker.Count++;
		double milliseconds = KuroTime.GetMilliseconds64();
		try
		{
			ticker.Handle(obj);
		}
		catch (Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Tick;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "处理方法执行异常";
			Exception error = ex;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", ticker.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (PerfSight.Instance.IsEnable && ticker.Group == ETickingGroup.TG_PrePhysics)
		{
			int maxFps = UKuroRenderingRuntimeBPPluginBPLibrary.GetMaxFps();
			double num2 = 1000.0 / (double)maxFps;
			float gameThreadTime = UKuroRenderingRuntimeBPPluginBPLibrary.GetGameThreadTime();
			float renderThreadTime = UKuroRenderingRuntimeBPPluginBPLibrary.GetRenderThreadTime();
			if ((double)gameThreadTime > num2 * 2.0 || (double)renderThreadTime > num2 * 2.0)
			{
				double num3 = KuroTime.GetMilliseconds64() - milliseconds;
				if (ticker.Name == "Core")
				{
					FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "[PrePhysics]TickSystem_Core", (float)num3);
					return;
				}
				if (ticker.Name == "Game")
				{
					FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "[PrePhysics]TickSystem_Game", (float)num3);
					FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "[PrePhysics]TickSystem_GameThreadTime", gameThreadTime);
					FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "[PrePhysics]TickSystem_RenderThreadTime", renderThreadTime);
					FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "[PrePhysics]TickSystem_RHIThreadTime", UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIThreadTime());
					FKuroPerfSightHelper.PostValueFloat1("CustomPerformance", "[PrePhysics]TickSystem_PresentTime", UKuroRenderingRuntimeBPPluginBPLibrary.GetSwapBufferTime());
				}
			}
		}
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00023424 File Offset: 0x00021624
	public void AddTickPrerequisiteActor(ETickingGroup group, AActor actor, int priority)
	{
		this.KuroTickManager.AddPrerequisiteActor(group, actor, priority);
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00023434 File Offset: 0x00021634
	public void RemoveTickPrerequisiteActor(ETickingGroup group, AActor actor, int priority)
	{
		this.KuroTickManager.RemovePrerequisiteActor(group, actor, priority);
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00023444 File Offset: 0x00021644
	public void AddTickPrerequisiteActorComp(ETickingGroup group, UActorComponent comp, int priority)
	{
		this.KuroTickManager.AddPrerequisiteActorComponent(group, comp, priority);
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00023454 File Offset: 0x00021654
	public void RemoveTickPrerequisiteActorComp(ETickingGroup group, UActorComponent comp, int priority)
	{
		this.KuroTickManager.RemovePrerequisiteActorComponent(group, comp, priority);
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00023464 File Offset: 0x00021664
	public void SetSkeletalMeshProxyTickFunction(ETickingGroup group, USkeletalMeshComponent comp, int priority)
	{
		this.KuroTickManager.SetSkeletalMeshProxyTickFunction(group, comp, priority);
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00023474 File Offset: 0x00021674
	public void CleanSkeletalMeshProxyTickFunction(USkeletalMeshComponent comp)
	{
		this.KuroTickManager.CleanSkeletalMeshProxyTickFunction(comp);
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00023482 File Offset: 0x00021682
	public void SetMovementProxyTickFunction(ETickingGroup group, UCharacterMovementComponent comp, int priority)
	{
		this.KuroTickManager.SetCharacterMovementProxyTickFunction(group, comp, priority);
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00023492 File Offset: 0x00021692
	public void CleanMovementProxyTickFunction(UCharacterMovementComponent comp)
	{
		this.KuroTickManager.CleanCharacterMovementProxyTickFunction(comp);
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x000234A0 File Offset: 0x000216A0
	public void SetTickFunctionCompletionCallbackInMainThread(ETickingGroup group, int priority)
	{
		this.KuroTickManager.SetTickFunctionCompletionCallbackInMainThread(group, priority);
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x000234AF File Offset: 0x000216AF
	public void SetGamePrerequisiteTickFunction(ETickingGroup group, int priority)
	{
		this.KuroTickManager.SetGamePrerequisiteTickFunction(group, priority);
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060006CA RID: 1738 RVA: 0x000234BE File Offset: 0x000216BE
	public static TickSystem Instance
	{
		get
		{
			if (TickSystem._instance == null)
			{
				TickSystem._instance = new TickSystem();
				TickSystem._instance.OnInit();
			}
			return TickSystem._instance;
		}
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x000234E1 File Offset: 0x000216E1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x000234E3 File Offset: 0x000216E3
	public static void ResetStaticDefaultValue()
	{
		TickSystem instance = TickSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TickSystem._instance = null;
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x000234FC File Offset: 0x000216FC
	static TickSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TickSystem.CreateStaticDefaultValue), new Action(TickSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0400054A RID: 1354
	private const int SECOND_TO_MILLISECOND = 1000;

	// Token: 0x0400054B RID: 1355
	public const int InvalidId = -1;

	// Token: 0x0400054C RID: 1356
	private bool IsPausedInternal;

	// Token: 0x0400054D RID: 1357
	public int PausedFrame = -1;

	// Token: 0x0400054E RID: 1358
	private int Increment;

	// Token: 0x0400054F RID: 1359
	[Nullable(2)]
	private UKuroTickManager KuroTickManager;

	// Token: 0x04000550 RID: 1360
	private readonly Dictionary<int, Ticker> Tickers = new Dictionary<int, Ticker>();

	// Token: 0x04000551 RID: 1361
	private readonly Dictionary<ETickingGroup, Action<float>> Delegates = new Dictionary<ETickingGroup, Action<float>>();

	// Token: 0x04000552 RID: 1362
	[Nullable(new byte[]
	{
		1,
		1,
		2,
		1
	})]
	private readonly Dictionary<ETickingGroup, List<List<Ticker>>> Groups = new Dictionary<ETickingGroup, List<List<Ticker>>>();

	// Token: 0x04000553 RID: 1363
	private readonly HashSet<int> PendingRemoveIds = new HashSet<int>();

	// Token: 0x04000554 RID: 1364
	private bool IsIterating;

	// Token: 0x04000555 RID: 1365
	private ETickingGroup IteratingGroup;

	// Token: 0x04000556 RID: 1366
	private int IteratingPriority;

	// Token: 0x04000557 RID: 1367
	[Nullable(2)]
	private static TickSystem _instance;
}
