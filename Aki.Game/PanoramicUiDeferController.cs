using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002312 RID: 8978
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PanoramicUiDeferController : ControllerBase
{
	// Token: 0x06011BCF RID: 72655 RVA: 0x0045DC00 File Offset: 0x0045BE00
	public void StartDefer()
	{
		if (this.Registered)
		{
			return;
		}
		this.Registered = true;
		this.ReplayWhiteSet.Clear();
		foreach (string text in CommonConfig.Instance.GetPanoramicUiDeferWhiteList())
		{
			EUiViewName euiViewName = (EUiViewName)text;
			if (UiConfig.Instance.TryGetViewInfo(euiViewName) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Panoramic;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[环视] 重放白名单配置了无效界面名";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", text);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				this.ReplayWhiteSet.Add(euiViewName);
			}
		}
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "环视期间延迟打开界面");
		Log.Instance.Info(ELogModule.Panoramic, ELogAuthor.HYF, "[环视] 开始拦截并延迟其他UI的打开", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06011BD0 RID: 72656 RVA: 0x0045DCF4 File Offset: 0x0045BEF4
	public void StopDeferAndReplay()
	{
		if (!this.Registered)
		{
			return;
		}
		this.Registered = false;
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
		ValueTuple<EUiViewName, object>[] array = this.DeferredQueue.ToArray();
		this.DeferredQueue.Clear();
		this.DeferredNameSet.Clear();
		foreach (ValueTuple<EUiViewName, object> valueTuple in array)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Panoramic;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[环视] 重放延迟打开的UI";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", valueTuple.Item1);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			UiManager.Instance.OpenView(valueTuple.Item1, valueTuple.Item2, null);
		}
	}

	// Token: 0x06011BD1 RID: 72657 RVA: 0x0045DDB0 File Offset: 0x0045BFB0
	public void ClearWithoutReplay()
	{
		if (this.Registered)
		{
			this.Registered = false;
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			Log.Instance.Info(ELogModule.Panoramic, ELogAuthor.HYF, "[环视] 清理延迟队列(不重放)", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.DeferredQueue.Clear();
		this.DeferredNameSet.Clear();
	}

	// Token: 0x06011BD2 RID: 72658 RVA: 0x0045DE1C File Offset: 0x0045C01C
	protected override bool OnClear()
	{
		this.ClearWithoutReplay();
		return base.OnClear();
	}

	// Token: 0x06011BD3 RID: 72659 RVA: 0x0045DE2A File Offset: 0x0045C02A
	protected override bool OnLeaveLevel()
	{
		this.ClearWithoutReplay();
		return base.OnLeaveLevel();
	}

	// Token: 0x06011BD4 RID: 72660 RVA: 0x0045DE38 File Offset: 0x0045C038
	[NullableContext(2)]
	private bool CheckCanOpen(EUiViewName viewName, object param)
	{
		if (this.WhiteList.Contains(viewName))
		{
			return true;
		}
		UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
		if (uiViewInfo == null)
		{
			return true;
		}
		if (uiViewInfo.Type != ELayerType.Normal && uiViewInfo.TimeDilation == 1f)
		{
			return true;
		}
		if (!this.ReplayWhiteSet.Contains(viewName))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Panoramic;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[环视] 拦截UI(不在重放白名单, 不重放)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", viewName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (!this.DeferredNameSet.Contains(viewName))
		{
			this.DeferredNameSet.Add(viewName);
			this.DeferredQueue.Add(new ValueTuple<EUiViewName, object>(viewName, param));
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Panoramic;
		ELogAuthor author2 = ELogAuthor.HYF;
		string message2 = "[环视] 拦截UI并加入延迟队列";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", viewName);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		return false;
	}

	// Token: 0x170016AF RID: 5807
	// (get) Token: 0x06011BD5 RID: 72661 RVA: 0x0045DF22 File Offset: 0x0045C122
	public static PanoramicUiDeferController Instance
	{
		get
		{
			return PanoramicUiDeferController._Instance;
		}
	}

	// Token: 0x06011BD6 RID: 72662 RVA: 0x0045DF29 File Offset: 0x0045C129
	public static PanoramicUiDeferController GetOrCreateInstance()
	{
		if (PanoramicUiDeferController._Instance == null)
		{
			PanoramicUiDeferController.CreateInstance();
		}
		return PanoramicUiDeferController._Instance;
	}

	// Token: 0x06011BD7 RID: 72663 RVA: 0x0045DF3D File Offset: 0x0045C13D
	public static bool CreateInstance()
	{
		if (PanoramicUiDeferController._Instance != null)
		{
			return true;
		}
		PanoramicUiDeferController._Instance = new PanoramicUiDeferController();
		return true;
	}

	// Token: 0x06011BD8 RID: 72664 RVA: 0x0045DF53 File Offset: 0x0045C153
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011BD9 RID: 72665 RVA: 0x0045DF55 File Offset: 0x0045C155
	public static void ResetStaticDefaultValue()
	{
		PanoramicUiDeferController._Instance = null;
	}

	// Token: 0x06011BDA RID: 72666 RVA: 0x0045DF5D File Offset: 0x0045C15D
	static PanoramicUiDeferController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PanoramicUiDeferController.CreateStaticDefaultValue), new Action(PanoramicUiDeferController.ResetStaticDefaultValue));
	}

	// Token: 0x0400869F RID: 34463
	private readonly HashSet<EUiViewName> WhiteList = new HashSet<EUiViewName>
	{
		EUiViewName.PlotViewHUD
	};

	// Token: 0x040086A0 RID: 34464
	[TupleElementNames(new string[]
	{
		"Name",
		"Param"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		2
	})]
	private readonly List<ValueTuple<EUiViewName, object>> DeferredQueue = new List<ValueTuple<EUiViewName, object>>();

	// Token: 0x040086A1 RID: 34465
	private readonly HashSet<EUiViewName> DeferredNameSet = new HashSet<EUiViewName>();

	// Token: 0x040086A2 RID: 34466
	private readonly HashSet<EUiViewName> ReplayWhiteSet = new HashSet<EUiViewName>();

	// Token: 0x040086A3 RID: 34467
	private bool Registered;

	// Token: 0x040086A4 RID: 34468
	[Nullable(2)]
	private static PanoramicUiDeferController _Instance;
}
