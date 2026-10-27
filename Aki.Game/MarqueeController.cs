using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x020021FD RID: 8701
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MarqueeController : UiControllerBase
{
	// Token: 0x06010EBA RID: 69306 RVA: 0x0041DDC8 File Offset: 0x0041BFC8
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(this.InitScrollingTimeMap));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.LaunchMarquee));
		EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.CancelCurrentTimer));
	}

	// Token: 0x06010EBB RID: 69307 RVA: 0x0041DE2C File Offset: 0x0041C02C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(this.InitScrollingTimeMap));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.LaunchMarquee));
		EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.CancelCurrentTimer));
	}

	// Token: 0x06010EBC RID: 69308 RVA: 0x0041DE8D File Offset: 0x0041C08D
	private void InitScrollingTimeMap()
	{
		MarqueeModel.Instance.InitMarqueeStorageDataMap();
	}

	// Token: 0x06010EBD RID: 69309 RVA: 0x0041DE99 File Offset: 0x0041C099
	private void CancelCurrentTimer()
	{
		if (MarqueeModel.Instance.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(MarqueeModel.Instance.TimerId);
			MarqueeModel.Instance.TimerId = null;
		}
	}

	// Token: 0x06010EBE RID: 69310 RVA: 0x0041DEC8 File Offset: 0x0041C0C8
	private void LaunchMarquee()
	{
		if (!LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.EnterGameRet))
		{
			return;
		}
		if (MarqueeModel.Instance.TimerId != null)
		{
			return;
		}
		MarqueeModel.Instance.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.GetMarqueeFromUrl), (float)((int)(TimeUtil.Instance.Minute * (double)TimeUtil.Instance.InverseMillisecond - new Random().NextDouble() * 5.0 * (double)TimeUtil.Instance.InverseMillisecond)), 1f, null, null, true);
	}

	// Token: 0x06010EBF RID: 69311 RVA: 0x0041DF54 File Offset: 0x0041C154
	private void GetMarqueeFromUrl(float delta)
	{
		string currentLoginServerId = LoginServerModel.Instance.GetCurrentLoginServerId();
		if (StringUtils.IsEmpty(currentLoginServerId))
		{
			return;
		}
		string text = PublicUtil.Instance.GetMarqueeUrl2(PublicUtil.Instance.GetGameId(), currentLoginServerId);
		text = CdnServerDebugConfig.Instance.TryGetMarqueeDebugUrl(text);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		Http.Get(text, null, delegate(bool success, int code, string data)
		{
			this.HandleHttpData(code, data);
			this.CheckMarquee();
		}, null);
	}

	// Token: 0x06010EC0 RID: 69312 RVA: 0x0041DFBC File Offset: 0x0041C1BC
	public void TestMarquee(string id)
	{
		string text = "[{\"contents\":[{\"language\":\"zh-Hans\",\"content\":\"10047跑马灯已上架\"},{\"language\":\"en\",\"content\":\"10047跑马灯已上架\"},{\"language\":\"ja\",\"content\":\"\"},{\"language\":\"ko\",\"content\":\"\"},{\"language\":\"ru\",\"content\":\"\"},{\"language\":\"zh-Hant\",\"content\":\"\"},{\"language\":\"de\",\"content\":\"\"},{\"language\":\"es\",\"content\":\"\"},{\"language\":\"pt\",\"content\":\"\"},{\"language\":\"id\",\"content\":\"\"},{\"language\":\"fr\",\"content\":\"\"},{\"language\":\"vi\",\"content\":\"\"},{\"language\":\"th\",\"content\":\"\"}],\"id\":10048,\"startTimeMs\":1698313421000,\"endTimeMs\":1703148916000,\"timeInterval\":0,\"times\":999,\"platform\":[1,2,3],\"channel\":[\"0\",\"18\"]},{\"contents\":[{\"language\":\"zh-Hans\",\"content\":\"第二条跑马灯5444545454545445454545454\"},{\"language\":\"en\",\"content\":\"en 第二条跑马灯\"},{\"language\":\"ja\",\"content\":\"\"},{\"language\":\"ko\",\"content\":\"\"},{\"language\":\"ru\",\"content\":\"\"},{\"language\":\"zh-Hant\",\"content\":\"\"},{\"language\":\"de\",\"content\":\"\"},{\"language\":\"es\",\"content\":\"\"},{\"language\":\"pt\",\"content\":\"\"},{\"language\":\"id\",\"content\":\"\"},{\"language\":\"fr\",\"content\":\"\"},{\"language\":\"vi\",\"content\":\"\"},{\"language\":\"th\",\"content\":\"\"}],\"id\":{0},\"startTimeMs\":1701846026000,\"endTimeMs\":1708142026000,\"timeInterval\":10,\"times\":2,\"platform\":[1,3],\"channel\":[]}]";
		text = text.Replace("{0}", id);
		this.HandleHttpData(200, text);
		this.CloseMarqueeView(true);
	}

	// Token: 0x06010EC1 RID: 69313 RVA: 0x0041DFF0 File Offset: 0x0041C1F0
	private void HandleHttpData(int code, string data)
	{
		MarqueeModel instance = MarqueeModel.Instance;
		if (code != 200 && code == 404)
		{
			this.RemoveServerMarqueeData();
			return;
		}
		if (string.IsNullOrEmpty(data) || !data.Contains("contents"))
		{
			return;
		}
		MarqueeDataEx[] array = Json.Parse<MarqueeDataEx[]>(data, null);
		if (array == null)
		{
			this.RemoveServerMarqueeData();
			return;
		}
		foreach (MarqueeDataEx data2 in array)
		{
			MarqueeData marqueeData = new MarqueeData();
			marqueeData.Phrase(data2);
			instance.AddOrUpdateMarqueeDate(marqueeData);
		}
		if (instance.CurMarquee != null && !PublicUtil.Instance.IsInIpWhiteList(instance.CurMarquee.WhiteLists))
		{
			this.CloseMarqueeView(false);
		}
	}

	// Token: 0x06010EC2 RID: 69314 RVA: 0x0041E095 File Offset: 0x0041C295
	public void AddClientMarqueeData(MarqueeData data)
	{
		if (!data.IsClientMarquee)
		{
			return;
		}
		MarqueeModel.Instance.AddOrUpdateMarqueeDate(data);
		this.CheckMarquee();
	}

	// Token: 0x06010EC3 RID: 69315 RVA: 0x0041E0B1 File Offset: 0x0041C2B1
	private void RemoveServerMarqueeData()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.MarqueeView))
		{
			UiManager.Instance.CloseView(EUiViewName.MarqueeView, null);
		}
		MarqueeModel.Instance.RemoveServerMarqueeData();
	}

	// Token: 0x06010EC4 RID: 69316 RVA: 0x0041E0E0 File Offset: 0x0041C2E0
	public void CloseMarqueeView(bool checkMarquee = true)
	{
		MarqueeData curMarquee = MarqueeModel.Instance.CurMarquee;
		if (MarqueeModel.Instance.RemoveMarqueeData((curMarquee != null) ? curMarquee.Id : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Marquee;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "跑马灯数据异常, 数据重复删除";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("incId", (curMarquee != null) ? curMarquee.Id : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		MarqueeModel.Instance.CurMarquee = null;
		if (UiManager.Instance.IsViewShow(EUiViewName.MarqueeView))
		{
			UiManager.Instance.CloseView(EUiViewName.MarqueeView, delegate(bool _)
			{
				if (checkMarquee)
				{
					Log.Instance.Info(ELogModule.Marquee, ELogAuthor.YZY, "关闭跑马灯检查下一个跑马灯", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.CheckMarquee();
				}
			});
			return;
		}
		if (checkMarquee)
		{
			Log.Instance.Info(ELogModule.Marquee, ELogAuthor.YZY, "检查下一个跑马灯", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CheckMarquee();
		}
	}

	// Token: 0x06010EC5 RID: 69317 RVA: 0x0041E1B8 File Offset: 0x0041C3B8
	private unsafe void CheckMarquee()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.MarqueeView) || UiManager.Instance.IsViewOpen(EUiViewName.MarqueeView))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Marquee;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "CheckMarquee";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsViewShow", UiManager.Instance.IsViewShow(EUiViewName.MarqueeView));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsViewOpen", UiManager.Instance.IsViewOpen(EUiViewName.MarqueeView));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		MarqueeModel.Instance.SortMarqueeQueue();
		MarqueeData marqueeData = MarqueeModel.Instance.PeekMarqueeData();
		if (marqueeData == null)
		{
			return;
		}
		if (!this.CheckCurMarqueeValid(marqueeData) || !PublicUtil.Instance.IsInIpWhiteList(marqueeData.WhiteLists))
		{
			MarqueeModel.Instance.RemoveMarqueeData(marqueeData.Id);
			this.CheckMarquee();
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.MarqueeView, null, null);
	}

	// Token: 0x06010EC6 RID: 69318 RVA: 0x0041E2C0 File Offset: 0x0041C4C0
	[NullableContext(2)]
	public bool CheckCurMarqueeValid(MarqueeData marqueeData)
	{
		if (marqueeData == null)
		{
			return false;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		int scrollingTime = MarqueeModel.Instance.GetScrollingTime(marqueeData);
		return serverTime <= marqueeData.EndTime && serverTime >= marqueeData.BeginTime && scrollingTime < marqueeData.ScrollTimes;
	}

	// Token: 0x1700157E RID: 5502
	// (get) Token: 0x06010EC7 RID: 69319 RVA: 0x0041E307 File Offset: 0x0041C507
	public static MarqueeController Instance
	{
		get
		{
			return MarqueeController._Instance;
		}
	}

	// Token: 0x06010EC8 RID: 69320 RVA: 0x0041E30E File Offset: 0x0041C50E
	public static MarqueeController GetOrCreateInstance()
	{
		if (MarqueeController._Instance == null)
		{
			MarqueeController.CreateInstance();
		}
		return MarqueeController._Instance;
	}

	// Token: 0x06010EC9 RID: 69321 RVA: 0x0041E322 File Offset: 0x0041C522
	public static bool CreateInstance()
	{
		if (MarqueeController._Instance != null)
		{
			return true;
		}
		MarqueeController._Instance = new MarqueeController();
		return true;
	}

	// Token: 0x06010ECA RID: 69322 RVA: 0x0041E338 File Offset: 0x0041C538
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010ECB RID: 69323 RVA: 0x0041E33A File Offset: 0x0041C53A
	public static void ResetStaticDefaultValue()
	{
		MarqueeController._Instance = null;
	}

	// Token: 0x06010ECC RID: 69324 RVA: 0x0041E342 File Offset: 0x0041C542
	static MarqueeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MarqueeController.CreateStaticDefaultValue), new Action(MarqueeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400809B RID: 32923
	private const int INTERVAL_OFFSET = 5;

	// Token: 0x0400809C RID: 32924
	[Nullable(2)]
	private static MarqueeController _Instance;
}
