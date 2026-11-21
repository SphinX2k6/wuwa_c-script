using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200597B RID: 22907
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SolarSchoolModel : ModelBase
	{
		// Token: 0x06038735 RID: 231221 RVA: 0x00FC9BA4 File Offset: 0x00FC7DA4
		public void SetLoadingPhaseFinish(ESolarSchoolLoadingPhase phase)
		{
			this.LoadingPhaseFinishSet.Add(phase);
			if (!this.LoadingPhaseFinishSet.Contains(this.CurrentPhase))
			{
				return;
			}
			ESolarSchoolLoadingPhase esolarSchoolLoadingPhase = ESolarSchoolLoadingPhase.Finish;
			foreach (ESolarSchoolLoadingPhase esolarSchoolLoadingPhase2 in Enum.GetValues<ESolarSchoolLoadingPhase>())
			{
				if (this.CurrentPhase < esolarSchoolLoadingPhase2 && esolarSchoolLoadingPhase2 < esolarSchoolLoadingPhase && !this.LoadingPhaseFinishSet.Contains(esolarSchoolLoadingPhase2))
				{
					esolarSchoolLoadingPhase = esolarSchoolLoadingPhase2;
				}
			}
			this.CurrentPhase = esolarSchoolLoadingPhase;
		}

		// Token: 0x17006C0E RID: 27662
		// (get) Token: 0x06038736 RID: 231222 RVA: 0x00FC9C11 File Offset: 0x00FC7E11
		public bool IsFirstScreenReady
		{
			get
			{
				return this.LoadingPhaseFinishSet.Contains(ESolarSchoolLoadingPhase.FirstScreenReady);
			}
		}

		// Token: 0x06038737 RID: 231223 RVA: 0x00FC9C20 File Offset: 0x00FC7E20
		public bool OpenLoadingView()
		{
			if (this.IsLoadingViewOpen())
			{
				return false;
			}
			this.CurrentProgress = 0f;
			this.CurrentPhase = ESolarSchoolLoadingPhase.Start;
			this.LoadingPhaseFinishSet.Clear();
			this.SetLoadingPhaseFinish(ESolarSchoolLoadingPhase.Start);
			this.LoadingClosedSource = new UniTaskCompletionSource();
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolLoadingView, null, null);
			return true;
		}

		// Token: 0x06038738 RID: 231224 RVA: 0x00FC9C78 File Offset: 0x00FC7E78
		public void OpenExitLoadingView()
		{
			if (!this.OpenLoadingView())
			{
				return;
			}
			this.FinishAllLoadingPhases();
		}

		// Token: 0x06038739 RID: 231225 RVA: 0x00FC9C8C File Offset: 0x00FC7E8C
		public void FinishAllLoadingPhases()
		{
			foreach (ESolarSchoolLoadingPhase loadingPhaseFinish in Enum.GetValues<ESolarSchoolLoadingPhase>())
			{
				this.SetLoadingPhaseFinish(loadingPhaseFinish);
			}
		}

		// Token: 0x0603873A RID: 231226 RVA: 0x00FC9CB8 File Offset: 0x00FC7EB8
		public void CloseLoadingView()
		{
			UiManager.Instance.CloseView(EUiViewName.SolarSchoolLoadingView, null);
		}

		// Token: 0x0603873B RID: 231227 RVA: 0x00FC9CCA File Offset: 0x00FC7ECA
		public bool IsLoadingViewOpen()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.SolarSchoolLoadingView) != null;
		}

		// Token: 0x0603873C RID: 231228 RVA: 0x00FC9CDE File Offset: 0x00FC7EDE
		public void OnLoadingViewHidden()
		{
			UniTaskCompletionSource loadingClosedSource = this.LoadingClosedSource;
			if (loadingClosedSource != null)
			{
				loadingClosedSource.TrySetResult();
			}
			this.LoadingClosedSource = null;
		}

		// Token: 0x0603873D RID: 231229 RVA: 0x00FC9CF9 File Offset: 0x00FC7EF9
		public void BeginDayChangeLoading()
		{
			this.LoadingPhaseFinishSet.Remove(ESolarSchoolLoadingPhase.FirstScreenReady);
			this.CurrentPhase = ESolarSchoolLoadingPhase.FirstScreenReady;
			this.LoadingClosedSource = new UniTaskCompletionSource();
		}

		// Token: 0x0603873E RID: 231230 RVA: 0x00FC9D1C File Offset: 0x00FC7F1C
		public void SetFirstScreenReadyIfNoPreparer(IEnumerable<SolarSchoolActionBase> actions)
		{
			using (IEnumerator<SolarSchoolActionBase> enumerator = actions.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.NeedPrepareFirstScreen)
					{
						return;
					}
				}
			}
			this.SetLoadingPhaseFinish(ESolarSchoolLoadingPhase.FirstScreenReady);
		}

		// Token: 0x0603873F RID: 231231 RVA: 0x00FC9D70 File Offset: 0x00FC7F70
		public UniTask WaitLoadingClosedAsync()
		{
			UniTaskCompletionSource loadingClosedSource = this.LoadingClosedSource;
			if (loadingClosedSource == null)
			{
				return UniTask.CompletedTask;
			}
			return loadingClosedSource.Task;
		}

		// Token: 0x06038740 RID: 231232 RVA: 0x00FC9D88 File Offset: 0x00FC7F88
		public void ShowSettingView()
		{
			UiViewBase uiViewBase = this.FindSettingView();
			if (uiViewBase == null)
			{
				UiManager.Instance.OpenView(EUiViewName.SolarSchoolSettingView, null, null);
				return;
			}
			uiViewBase.Show(null);
		}

		// Token: 0x06038741 RID: 231233 RVA: 0x00FC9DB8 File Offset: 0x00FC7FB8
		public void CloseSettingView()
		{
			UiViewBase uiViewBase = this.FindSettingView();
			if (uiViewBase == null)
			{
				return;
			}
			uiViewBase.Destroy(null);
		}

		// Token: 0x06038742 RID: 231234 RVA: 0x00FC9DCC File Offset: 0x00FC7FCC
		[NullableContext(2)]
		private UiViewBase FindSettingView()
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.SolarSchoolSettingView);
			if (viewByName == null || viewByName.IsDestroyOrDestroying || viewByName.WaitToDestroy)
			{
				return null;
			}
			return viewByName;
		}

		// Token: 0x06038743 RID: 231235 RVA: 0x00FC9DFF File Offset: 0x00FC7FFF
		[NullableContext(2)]
		public SolarSchoolActivityData GetActivityData(int activityId)
		{
			return ActivityModel.Instance.GetActivityById(activityId) as SolarSchoolActivityData;
		}

		// Token: 0x06038744 RID: 231236 RVA: 0x00FC9E14 File Offset: 0x00FC8014
		[NullableContext(2)]
		public SolarSchoolActivityData GetCurrentActivityData()
		{
			List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(117);
			if (activitiesByType.Count <= 0)
			{
				return null;
			}
			return activitiesByType[0] as SolarSchoolActivityData;
		}

		// Token: 0x06038745 RID: 231237 RVA: 0x00FC9E48 File Offset: 0x00FC8048
		public void SetFlowData(IEnumerable<SolarSchoolFlowPb> flowData)
		{
			this.FlowDataMap.Clear();
			int num = 0;
			foreach (SolarSchoolFlowPb solarSchoolFlowPb in flowData)
			{
				this.FlowDataMap[solarSchoolFlowPb.SolarSchoolFlowId] = solarSchoolFlowPb;
				num++;
			}
		}

		// Token: 0x06038746 RID: 231238 RVA: 0x00FC9EAC File Offset: 0x00FC80AC
		public IReadOnlyList<int> GetReadPlotIds(int flowId)
		{
			SolarSchoolFlowPb solarSchoolFlowPb;
			if (!this.FlowDataMap.TryGetValue(flowId, out solarSchoolFlowPb))
			{
				return Array.Empty<int>();
			}
			List<int> list = new List<int>();
			for (int i = 1; i < solarSchoolFlowPb.ReadPlotFlatBit.Count * 8 * 8; i++)
			{
				if (SolarSchoolUtils.GetSaveBit(solarSchoolFlowPb.ReadPlotFlatBit, i))
				{
					list.Add(i);
				}
			}
			return list;
		}

		// Token: 0x06038747 RID: 231239 RVA: 0x00FC9F08 File Offset: 0x00FC8108
		public void RecordReadPlot(int flowId, int plotId)
		{
			SolarSchoolFlowPb solarSchoolFlowPb;
			if (!this.FlowDataMap.TryGetValue(flowId, out solarSchoolFlowPb))
			{
				solarSchoolFlowPb = SolarSchoolFlowPb.Create();
				solarSchoolFlowPb.SolarSchoolFlowId = flowId;
				this.FlowDataMap[flowId] = solarSchoolFlowPb;
			}
			SolarSchoolUtils.SetSaveBit(solarSchoolFlowPb.ReadPlotFlatBit, plotId);
		}

		// Token: 0x17006C0F RID: 27663
		// (get) Token: 0x06038748 RID: 231240 RVA: 0x00FC9F4B File Offset: 0x00FC814B
		public static SolarSchoolModel Instance
		{
			get
			{
				return SolarSchoolModel._Instance;
			}
		}

		// Token: 0x06038749 RID: 231241 RVA: 0x00FC9F52 File Offset: 0x00FC8152
		public static SolarSchoolModel GetOrCreateInstance()
		{
			if (SolarSchoolModel._Instance == null)
			{
				SolarSchoolModel.CreateInstance();
			}
			return SolarSchoolModel._Instance;
		}

		// Token: 0x0603874A RID: 231242 RVA: 0x00FC9F66 File Offset: 0x00FC8166
		public static bool CreateInstance()
		{
			if (SolarSchoolModel._Instance != null)
			{
				return true;
			}
			SolarSchoolModel._Instance = new SolarSchoolModel();
			return true;
		}

		// Token: 0x0603874B RID: 231243 RVA: 0x00FC9F7C File Offset: 0x00FC817C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603874C RID: 231244 RVA: 0x00FC9F7E File Offset: 0x00FC817E
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolModel._Instance = null;
		}

		// Token: 0x0603874D RID: 231245 RVA: 0x00FC9F86 File Offset: 0x00FC8186
		static SolarSchoolModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolModel.CreateStaticDefaultValue), new Action(SolarSchoolModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DC2C RID: 121900
		private readonly Dictionary<int, SolarSchoolFlowPb> FlowDataMap = new Dictionary<int, SolarSchoolFlowPb>();

		// Token: 0x0401DC2D RID: 121901
		public bool VisualNovelAutoPlayEnabled;

		// Token: 0x0401DC2E RID: 121902
		public float CurrentProgress;

		// Token: 0x0401DC2F RID: 121903
		public ESolarSchoolLoadingPhase CurrentPhase;

		// Token: 0x0401DC30 RID: 121904
		private readonly HashSet<ESolarSchoolLoadingPhase> LoadingPhaseFinishSet = new HashSet<ESolarSchoolLoadingPhase>();

		// Token: 0x0401DC31 RID: 121905
		[Nullable(2)]
		private UniTaskCompletionSource LoadingClosedSource;

		// Token: 0x0401DC32 RID: 121906
		[Nullable(2)]
		private static SolarSchoolModel _Instance;
	}
}
