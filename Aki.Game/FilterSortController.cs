using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using FilterDefine;

// Token: 0x02000CE2 RID: 3298
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FilterSortController : UiControllerBase
{
	// Token: 0x06008963 RID: 35171 RVA: 0x0029A278 File Offset: 0x00298478
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

	// Token: 0x06008964 RID: 35172 RVA: 0x0029A377 File Offset: 0x00298577
	public void OpenPhantomFilterView(PhantomFilterViewData<IPhantomFilterData> viewData)
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomFilterPopupView, viewData, null);
	}

	// Token: 0x06008965 RID: 35173 RVA: 0x0029A38A File Offset: 0x0029858A
	public void OpenSortView(SortViewData viewData)
	{
		UiManager.Instance.OpenView(EUiViewName.SortView, viewData, null);
	}

	// Token: 0x17000F4E RID: 3918
	// (get) Token: 0x06008966 RID: 35174 RVA: 0x0029A39D File Offset: 0x0029859D
	public static FilterSortController Instance
	{
		get
		{
			return FilterSortController._Instance;
		}
	}

	// Token: 0x06008967 RID: 35175 RVA: 0x0029A3A4 File Offset: 0x002985A4
	public static FilterSortController GetOrCreateInstance()
	{
		if (FilterSortController._Instance == null)
		{
			FilterSortController.CreateInstance();
		}
		return FilterSortController._Instance;
	}

	// Token: 0x06008968 RID: 35176 RVA: 0x0029A3B8 File Offset: 0x002985B8
	public static bool CreateInstance()
	{
		if (FilterSortController._Instance != null)
		{
			return true;
		}
		FilterSortController._Instance = new FilterSortController();
		return true;
	}

	// Token: 0x06008969 RID: 35177 RVA: 0x0029A3CE File Offset: 0x002985CE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600896A RID: 35178 RVA: 0x0029A3D0 File Offset: 0x002985D0
	public static void ResetStaticDefaultValue()
	{
		FilterSortController._Instance = null;
	}

	// Token: 0x0600896B RID: 35179 RVA: 0x0029A3D8 File Offset: 0x002985D8
	static FilterSortController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterSortController.CreateStaticDefaultValue), new Action(FilterSortController.ResetStaticDefaultValue));
	}

	// Token: 0x040052B1 RID: 21169
	[Nullable(2)]
	private static FilterSortController _Instance;
}
