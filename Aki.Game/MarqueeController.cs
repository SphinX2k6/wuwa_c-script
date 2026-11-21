using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x020016E1 RID: 5857
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MarqueeController : UiControllerBase
{
	// Token: 0x0600E34D RID: 58189 RVA: 0x0042A76C File Offset: 0x0042896C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.LocalStorageInitPlayerId, new Action(this.InitScrollingTimeMap));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.LaunchMarquee));
		EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.CancelCurrentTimer));
	}

	// Token: 0x0600E34E RID: 58190 RVA: 0x0042A7D0 File Offset: 0x004289D0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.LocalStorageInitPlayerId, new Action(this.InitScrollingTimeMap));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.LaunchMarquee));
		EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.CancelCurrentTimer));
	}

	// Token: 0x0600E34F RID: 58191 RVA: 0x0042A831 File Offset: 0x00428A31
	private void InitScrollingTimeMap()
	{
		MarqueeModel.Instance.InitMarqueeStorageDataMap();
	}

	// Token: 0x0600E350 RID: 58192 RVA: 0x0042A83D File Offset: 0x00428A3D
	private void CancelCurrentTimer()
	{
		if (MarqueeModel.Instance.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(MarqueeModel.Instance.TimerId);
			MarqueeModel.Instance.TimerId = null;
		}
	}

	// Token: 0x0600E351 RID: 58193 RVA: 0x0042A86C File Offset: 0x00428A6C
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

	// Token: 0x0600E352 RID: 58194 RVA: 0x0042A8F8 File Offset: 0x00428AF8
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

	// Token: 0x0600E353 RID: 58195 RVA: 0x0042A960 File Offset: 0x00428B60
	public void TestMarquee(string id)
	{
		string text = "[{\"contents\":[{\"language\":\"zh-Hans\",\"content\":\"10047跑马灯已上架\"},{\"language\":\"en\",\"content\":\"10047跑马灯已上架\"},{\"language\":\"ja\",\"content\":\"\"},{\"language\":\"ko\",\"content\":\"\"},{\"language\":\"ru\",\"content\":\"\"},{\"language\":\"zh-Hant\",\"content\":\"\"},{\"language\":\"de\",\"content\":\"\"},{\"language\":\"es\",\"content\":\"\"},{\"language\":\"pt\",\"content\":\"\"},{\"language\":\"id\",\"content\":\"\"},{\"language\":\"fr\",\"content\":\"\"},{\"language\":\"vi\",\"content\":\"\"},{\"language\":\"th\",\"content\":\"\"}],\"id\":10048,\"startTimeMs\":1698313421000,\"endTimeMs\":1703148916000,\"timeInterval\":0,\"times\":999,\"platform\":[1,2,3],\"channel\":[\"0\",\"18\"]},{\"contents\":[{\"language\":\"zh-Hans\",\"content\":\"第二条跑马灯5444545454545445454545454\"},{\"language\":\"en\",\"content\":\"en 第二条跑马灯\"},{\"language\":\"ja\",\"content\":\"\"},{\"language\":\"ko\",\"content\":\"\"},{\"language\":\"ru\",\"content\":\"\"},{\"language\":\"zh-Hant\",\"content\":\"\"},{\"language\":\"de\",\"content\":\"\"},{\"language\":\"es\",\"content\":\"\"},{\"language\":\"pt\",\"content\":\"\"},{\"language\":\"id\",\"content\":\"\"},{\"language\":\"fr\",\"content\":\"\"},{\"language\":\"vi\",\"content\":\"\"},{\"language\":\"th\",\"content\":\"\"}],\"id\":{0},\"startTimeMs\":1701846026000,\"endTimeMs\":1708142026000,\"timeInterval\":10,\"times\":2,\"platform\":[1,3],\"channel\":[]}]";
		text = text.Replace("{0}", id);
		this.HandleHttpData(200, text);
		this.CloseMarqueeView(true);
	}

	// Token: 0x0600E354 RID: 58196 RVA: 0x0042A994 File Offset: 0x00428B94
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

	// Token: 0x0600E355 RID: 58197 RVA: 0x0042AA39 File Offset: 0x00428C39
	public void AddClientMarqueeData(MarqueeData data)
	{
		if (!data.IsClientMarquee)
		{
			return;
		}
		MarqueeModel.Instance.AddOrUpdateMarqueeDate(data);
		this.CheckMarquee();
	}

	// Token: 0x0600E356 RID: 58198 RVA: 0x0042AA55 File Offset: 0x00428C55
	private void RemoveServerMarqueeData()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.MarqueeView))
		{
			UiManager.Instance.CloseView(EUiViewName.MarqueeView, null);
		}
		MarqueeModel.Instance.RemoveServerMarqueeData();
	}

	// Token: 0x0600E357 RID: 58199 RVA: 0x0042AA84 File Offset: 0x00428C84
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

	// Token: 0x0600E358 RID: 58200 RVA: 0x0042AB5C File Offset: 0x00428D5C
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

	// Token: 0x0600E359 RID: 58201 RVA: 0x0042AC64 File Offset: 0x00428E64
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

	// Token: 0x170015B5 RID: 5557
	// (get) Token: 0x0600E35A RID: 58202 RVA: 0x0042ACAB File Offset: 0x00428EAB
	public static MarqueeController Instance
	{
		get
		{
			return MarqueeController._Instance;
		}
	}

	// Token: 0x0600E35B RID: 58203 RVA: 0x0042ACB2 File Offset: 0x00428EB2
	public static MarqueeController GetOrCreateInstance()
	{
		if (MarqueeController._Instance == null)
		{
			MarqueeController.CreateInstance();
		}
		return MarqueeController._Instance;
	}

	// Token: 0x0600E35C RID: 58204 RVA: 0x0042ACC6 File Offset: 0x00428EC6
	public static bool CreateInstance()
	{
		if (MarqueeController._Instance != null)
		{
			return true;
		}
		MarqueeController._Instance = new MarqueeController();
		return true;
	}

	// Token: 0x0600E35D RID: 58205 RVA: 0x0042ACDC File Offset: 0x00428EDC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E35E RID: 58206 RVA: 0x0042ACDE File Offset: 0x00428EDE
	public static void ResetStaticDefaultValue()
	{
		MarqueeController._Instance = null;
	}

	// Token: 0x0600E35F RID: 58207 RVA: 0x0042ACE6 File Offset: 0x00428EE6
	static MarqueeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MarqueeController.CreateStaticDefaultValue), new Action(MarqueeController.ResetStaticDefaultValue));
	}

	// Token: 0x040081D9 RID: 33241
	private const int INTERVAL_OFFSET = 5;

	// Token: 0x040081DA RID: 33242
	[Nullable(2)]
	private static MarqueeController _Instance;
}
