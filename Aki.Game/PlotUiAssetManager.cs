using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200331D RID: 13085
[NullableContext(1)]
[Nullable(0)]
public class PlotUiAssetManager
{
	// Token: 0x0601C7FE RID: 116734 RVA: 0x007FE857 File Offset: 0x007FCA57
	public void Init()
	{
		EventSystem.Instance.Add(EEventName.RestartHangingPreloadTask, new Action(this.RestartHangingPreloadTask));
	}

	// Token: 0x0601C7FF RID: 116735 RVA: 0x007FE878 File Offset: 0x007FCA78
	[return: Nullable(2)]
	public PlotUiAsset GetPlotUiAsset(string plotId)
	{
		PlotUiAsset result;
		if (this.PlotIdUiAssetMap.TryGetValue(plotId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601C800 RID: 116736 RVA: 0x007FE898 File Offset: 0x007FCA98
	public void Clear()
	{
		this.PlotIdUiAssetMap.Clear();
		this.HangingPlotIdSet.Clear();
		EventSystem.Instance.Remove(EEventName.RestartHangingPreloadTask, new Action(this.RestartHangingPreloadTask));
	}

	// Token: 0x0601C801 RID: 116737 RVA: 0x007FE8CC File Offset: 0x007FCACC
	public UniTask PreloadPlotUiAssetAsync(string flowListName, int flowId, int stateId)
	{
		PlotUiAssetManager.<PreloadPlotUiAssetAsync>d__5 <PreloadPlotUiAssetAsync>d__;
		<PreloadPlotUiAssetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadPlotUiAssetAsync>d__.<>4__this = this;
		<PreloadPlotUiAssetAsync>d__.flowListName = flowListName;
		<PreloadPlotUiAssetAsync>d__.flowId = flowId;
		<PreloadPlotUiAssetAsync>d__.stateId = stateId;
		<PreloadPlotUiAssetAsync>d__.<>1__state = -1;
		<PreloadPlotUiAssetAsync>d__.<>t__builder.Start<PlotUiAssetManager.<PreloadPlotUiAssetAsync>d__5>(ref <PreloadPlotUiAssetAsync>d__);
		return <PreloadPlotUiAssetAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601C802 RID: 116738 RVA: 0x007FE928 File Offset: 0x007FCB28
	public void RemovePlotUiAsset(string plotId)
	{
		foreach (KeyValuePair<string, PlotUiAsset> keyValuePair in this.PlotIdUiAssetMap)
		{
			string text;
			PlotUiAsset plotUiAsset;
			keyValuePair.Deconstruct(out text, out plotUiAsset);
			string a = text;
			PlotUiAsset plotUiAsset2 = plotUiAsset;
			if (a == plotId)
			{
				if (plotUiAsset2.IsLoading())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Preload;
					ELogAuthor author = ELogAuthor.HYF;
					string message = "[预加载][Plot] PlotUiAsset被移除时尚未加载完毕";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlotId", plotId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				plotUiAsset2.Clear();
				break;
			}
		}
		this.PlotIdUiAssetMap.Remove(plotId);
		CommonQteController.Instance.ClearPreloadQteRes();
	}

	// Token: 0x0601C803 RID: 116739 RVA: 0x007FE9DC File Offset: 0x007FCBDC
	public UniTask WaitForPlotUiAsset(string plotId)
	{
		PlotUiAssetManager.<WaitForPlotUiAsset>d__7 <WaitForPlotUiAsset>d__;
		<WaitForPlotUiAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForPlotUiAsset>d__.<>4__this = this;
		<WaitForPlotUiAsset>d__.plotId = plotId;
		<WaitForPlotUiAsset>d__.<>1__state = -1;
		<WaitForPlotUiAsset>d__.<>t__builder.Start<PlotUiAssetManager.<WaitForPlotUiAsset>d__7>(ref <WaitForPlotUiAsset>d__);
		return <WaitForPlotUiAsset>d__.<>t__builder.Task;
	}

	// Token: 0x0601C804 RID: 116740 RVA: 0x007FEA28 File Offset: 0x007FCC28
	public bool IsLoading(string plotId)
	{
		PlotUiAsset plotUiAsset;
		return this.PlotIdUiAssetMap.TryGetValue(plotId, out plotUiAsset) && plotUiAsset.IsLoading();
	}

	// Token: 0x0601C805 RID: 116741 RVA: 0x007FEA4D File Offset: 0x007FCC4D
	public bool IsHanging(string plotId)
	{
		return this.HangingPlotIdSet.Contains(plotId);
	}

	// Token: 0x0601C806 RID: 116742 RVA: 0x007FEA5C File Offset: 0x007FCC5C
	public bool HasPreloadQte(List<int> qteIds)
	{
		using (Dictionary<string, PlotUiAsset>.ValueCollection.Enumerator enumerator = this.PlotIdUiAssetMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.HasPreloadQte(qteIds))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0601C807 RID: 116743 RVA: 0x007FEABC File Offset: 0x007FCCBC
	public void CancelHangingTask(string plotId)
	{
		if (this.IsHanging(plotId))
		{
			this.HangingPlotIdSet.Remove(plotId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[预加载][Plot] 挂起的剧情预加载任务取消";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlotId", plotId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0601C808 RID: 116744 RVA: 0x007FEB08 File Offset: 0x007FCD08
	private void RestartHangingPreloadTask()
	{
		List<UniTask> list = new List<UniTask>();
		foreach (string text in this.HangingPlotIdSet)
		{
			string[] array = text.Split(',', StringSplitOptions.None);
			list.Add(this.PreloadPlotUiAssetAsync(array[0], int.Parse(array[1]), int.Parse(array[2])));
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[预加载][Plot] 场景加载完成，重启挂起的剧情预加载任务";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlotId", text);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.HangingPlotIdSet.Clear();
		UniTask.WhenAll(list).Forget();
	}

	// Token: 0x0400E272 RID: 57970
	private readonly Dictionary<string, PlotUiAsset> PlotIdUiAssetMap = new Dictionary<string, PlotUiAsset>();

	// Token: 0x0400E273 RID: 57971
	private readonly HashSet<string> HangingPlotIdSet = new HashSet<string>();
}
