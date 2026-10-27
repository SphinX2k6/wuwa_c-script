using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020000D0 RID: 208
[NullableContext(1)]
[Nullable(0)]
public class TickSystem : Singleton
{
	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000674 RID: 1652 RVA: 0x00022745 File Offset: 0x00020945
	// (set) Token: 0x06000675 RID: 1653 RVA: 0x00022763 File Offset: 0x00020963
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

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000676 RID: 1654 RVA: 0x0002277F File Offset: 0x0002097F
	public bool IsSetPaused
	{
		get
		{
			return this.IsPausedInternal;
		}
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00022787 File Offset: 0x00020987
	public void Initialize(UGameInstance gameInstance)
	{
		this.KuroTickManager = new UKuroTickManager(gameInstance, null, EObjectFlags.RF_NoFlags);
		this.Tickers.Clear();
		this.Groups.Clear();
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x000227B0 File Offset: 0x000209B0
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

	// Token: 0x06000679 RID: 1657 RVA: 0x00022818 File Offset: 0x00020A18
	public bool Has(int id)
	{
		return id > 0 && this.Tickers.ContainsKey(id);
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0002282C File Offset: 0x00020A2C
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

	// Token: 0x0600067B RID: 1659 RVA: 0x00022994 File Offset: 0x00020B94
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

	// Token: 0x0600067C RID: 1660 RVA: 0x00022BB4 File Offset: 0x00020DB4
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

	// Token: 0x0600067D RID: 1661 RVA: 0x00022C08 File Offset: 0x00020E08
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

	// Token: 0x0600067E RID: 1662 RVA: 0x00022C5C File Offset: 0x00020E5C
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

	// Token: 0x0600067F RID: 1663 RVA: 0x00022E54 File Offset: 0x00021054
	public void AddTickPrerequisiteActor(ETickingGroup group, AActor actor, int priority)
	{
		this.KuroTickManager.AddPrerequisiteActor(group, actor, priority);
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00022E64 File Offset: 0x00021064
	public void RemoveTickPrerequisiteActor(ETickingGroup group, AActor actor, int priority)
	{
		this.KuroTickManager.RemovePrerequisiteActor(group, actor, priority);
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00022E74 File Offset: 0x00021074
	public void AddTickPrerequisiteActorComp(ETickingGroup group, UActorComponent comp, int priority)
	{
		this.KuroTickManager.AddPrerequisiteActorComponent(group, comp, priority);
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00022E84 File Offset: 0x00021084
	public void RemoveTickPrerequisiteActorComp(ETickingGroup group, UActorComponent comp, int priority)
	{
		this.KuroTickManager.RemovePrerequisiteActorComponent(group, comp, priority);
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00022E94 File Offset: 0x00021094
	public void SetSkeletalMeshProxyTickFunction(ETickingGroup group, USkeletalMeshComponent comp, int priority)
	{
		this.KuroTickManager.SetSkeletalMeshProxyTickFunction(group, comp, priority);
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00022EA4 File Offset: 0x000210A4
	public void CleanSkeletalMeshProxyTickFunction(USkeletalMeshComponent comp)
	{
		this.KuroTickManager.CleanSkeletalMeshProxyTickFunction(comp);
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00022EB2 File Offset: 0x000210B2
	public void SetMovementProxyTickFunction(ETickingGroup group, UCharacterMovementComponent comp, int priority)
	{
		this.KuroTickManager.SetCharacterMovementProxyTickFunction(group, comp, priority);
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00022EC2 File Offset: 0x000210C2
	public void CleanMovementProxyTickFunction(UCharacterMovementComponent comp)
	{
		this.KuroTickManager.CleanCharacterMovementProxyTickFunction(comp);
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00022ED0 File Offset: 0x000210D0
	public void SetTickFunctionCompletionCallbackInMainThread(ETickingGroup group, int priority)
	{
		this.KuroTickManager.SetTickFunctionCompletionCallbackInMainThread(group, priority);
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00022EDF File Offset: 0x000210DF
	public void SetGamePrerequisiteTickFunction(ETickingGroup group, int priority)
	{
		this.KuroTickManager.SetGamePrerequisiteTickFunction(group, priority);
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000689 RID: 1673 RVA: 0x00022EEE File Offset: 0x000210EE
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

	// Token: 0x0600068A RID: 1674 RVA: 0x00022F11 File Offset: 0x00021111
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00022F13 File Offset: 0x00021113
	public static void ResetStaticDefaultValue()
	{
		TickSystem instance = TickSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TickSystem._instance = null;
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00022F2C File Offset: 0x0002112C
	static TickSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TickSystem.CreateStaticDefaultValue), new Action(TickSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0400053B RID: 1339
	private const int SECOND_TO_MILLISECOND = 1000;

	// Token: 0x0400053C RID: 1340
	public const int InvalidId = -1;

	// Token: 0x0400053D RID: 1341
	private bool IsPausedInternal;

	// Token: 0x0400053E RID: 1342
	public int PausedFrame = -1;

	// Token: 0x0400053F RID: 1343
	private int Increment;

	// Token: 0x04000540 RID: 1344
	[Nullable(2)]
	private UKuroTickManager KuroTickManager;

	// Token: 0x04000541 RID: 1345
	private readonly Dictionary<int, Ticker> Tickers = new Dictionary<int, Ticker>();

	// Token: 0x04000542 RID: 1346
	private readonly Dictionary<ETickingGroup, Action<float>> Delegates = new Dictionary<ETickingGroup, Action<float>>();

	// Token: 0x04000543 RID: 1347
	[Nullable(new byte[]
	{
		1,
		1,
		2,
		1
	})]
	private readonly Dictionary<ETickingGroup, List<List<Ticker>>> Groups = new Dictionary<ETickingGroup, List<List<Ticker>>>();

	// Token: 0x04000544 RID: 1348
	private readonly HashSet<int> PendingRemoveIds = new HashSet<int>();

	// Token: 0x04000545 RID: 1349
	private bool IsIterating;

	// Token: 0x04000546 RID: 1350
	private ETickingGroup IteratingGroup;

	// Token: 0x04000547 RID: 1351
	private int IteratingPriority;

	// Token: 0x04000548 RID: 1352
	[Nullable(2)]
	private static TickSystem _instance;
}
