using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using FilterDefine;

// Token: 0x02001829 RID: 6185
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FilterSortController : UiControllerBase
{
	// Token: 0x0600B578 RID: 46456 RVA: 0x0028FB58 File Offset: 0x0028DD58
	public void OpenFilterView(FilterViewData viewData)
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(viewData.UniqueId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId);
		if (filterConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FilterSortView;
			ELogAuthor author = ELogAuthor.CB;
			string message = "找不到筛选配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId:", filterResultData.ConfigId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (filterConfig.Value.DataType == 2 || filterConfig.Value.DataType == 4)
		{
			UiManager.Instance.OpenView(EUiViewName.VisionFilterView, viewData, null);
			return;
		}
		if (filterConfig.Value.DataType == 22 || filterConfig.Value.DataType == 21 || filterConfig.Value.DataType == 23)
		{
			UiManager.Instance.OpenView(EUiViewName.PinballFilterView, viewData, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.FilterView, viewData, null);
	}

	// Token: 0x0600B579 RID: 46457 RVA: 0x0028FC57 File Offset: 0x0028DE57
	public void OpenPhantomFilterView(PhantomFilterViewData<IPhantomFilterData> viewData)
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomFilterPopupView, viewData, null);
	}

	// Token: 0x0600B57A RID: 46458 RVA: 0x0028FC6A File Offset: 0x0028DE6A
	public void OpenSortView(SortViewData viewData)
	{
		UiManager.Instance.OpenView(EUiViewName.SortView, viewData, null);
	}

	// Token: 0x17000F2B RID: 3883
	// (get) Token: 0x0600B57B RID: 46459 RVA: 0x0028FC7D File Offset: 0x0028DE7D
	public static FilterSortController Instance
	{
		get
		{
			return FilterSortController._Instance;
		}
	}

	// Token: 0x0600B57C RID: 46460 RVA: 0x0028FC84 File Offset: 0x0028DE84
	public static FilterSortController GetOrCreateInstance()
	{
		if (FilterSortController._Instance == null)
		{
			FilterSortController.CreateInstance();
		}
		return FilterSortController._Instance;
	}

	// Token: 0x0600B57D RID: 46461 RVA: 0x0028FC98 File Offset: 0x0028DE98
	public static bool CreateInstance()
	{
		if (FilterSortController._Instance != null)
		{
			return true;
		}
		FilterSortController._Instance = new FilterSortController();
		return true;
	}

	// Token: 0x0600B57E RID: 46462 RVA: 0x0028FCAE File Offset: 0x0028DEAE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B57F RID: 46463 RVA: 0x0028FCB0 File Offset: 0x0028DEB0
	public static void ResetStaticDefaultValue()
	{
		FilterSortController._Instance = null;
	}

	// Token: 0x0600B580 RID: 46464 RVA: 0x0028FCB8 File Offset: 0x0028DEB8
	static FilterSortController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterSortController.CreateStaticDefaultValue), new Action(FilterSortController.ResetStaticDefaultValue));
	}

	// Token: 0x04005206 RID: 20998
	[Nullable(2)]
	private static FilterSortController _Instance;
}
