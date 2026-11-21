using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Game.Common;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02004064 RID: 16484
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowConfig : ConfigBase
	{
		// Token: 0x17005442 RID: 21570
		// (get) Token: 0x06029CA9 RID: 171177 RVA: 0x00BCEE34 File Offset: 0x00BCD034
		private CacheLru<string, FlowConfig.FlowListFbIndex> FlowListFbLru
		{
			get
			{
				CacheLru<string, FlowConfig.FlowListFbIndex> result;
				if ((result = this.FlowListFbLruInternal) == null)
				{
					result = (this.FlowListFbLruInternal = new CacheLru<string, FlowConfig.FlowListFbIndex>(20, new Func<string, FlowConfig.FlowListFbIndex>(this.LoadFlowListFromFb)));
				}
				return result;
			}
		}

		// Token: 0x06029CAA RID: 171178 RVA: 0x00BCEE67 File Offset: 0x00BCD067
		protected override bool OnInit()
		{
			this.CacheFlowListMap = new Dictionary<string, FlowListData>();
			return true;
		}

		// Token: 0x06029CAB RID: 171179 RVA: 0x00BCEE75 File Offset: 0x00BCD075
		protected override bool OnClear()
		{
			this.CacheFlowListMap = null;
			FlowListData.AudioCache = null;
			return true;
		}

		// Token: 0x06029CAC RID: 171180 RVA: 0x00BCEE88 File Offset: 0x00BCD088
		[return: Nullable(2)]
		private unsafe FlowConfig.FlowListFbIndex LoadFlowListFromFb(string flowListName)
		{
			string text = this.FlowListFbPath + flowListName + ".bytes";
			ByteBuffer byteBuffer = FbFileLoader.LoadBytes(text);
			if (byteBuffer == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "LoadFlowListFromFb的剧情配置不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("filePath", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("flowListName", flowListName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			Aki.TDConfigMgr.Action.IFlowListInfo flowListInfo = Aki.TDConfigMgr.Action.IFlowListInfo.Create(Aki.TDConfigMgr.Action.Fb.IFlowListInfo.Create(new Aki.UniverseEditor.Interface.Fbs.Action.IFlowListInfo?(Aki.UniverseEditor.Interface.Fbs.Action.IFlowListInfo.GetRootAsIFlowListInfo(byteBuffer))));
			if (flowListInfo != null)
			{
				return new FlowConfig.FlowListFbIndex(flowListInfo);
			}
			return null;
		}

		// Token: 0x06029CAD RID: 171181 RVA: 0x00BCEF28 File Offset: 0x00BCD128
		[return: Nullable(2)]
		private unsafe Aki.TDConfigMgr.Action.IFlowInfo GetFbFlowInfo(string flowListName, int flowId)
		{
			FlowConfig.FlowListFbIndex flowListFbIndex = this.FlowListFbLru.Get(flowListName);
			Aki.TDConfigMgr.Action.IFlowInfo flowInfo = (flowListFbIndex != null) ? flowListFbIndex.GetFlow(flowId) : null;
			if (flowInfo == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "找不到剧情配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("flowListName", flowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("flowId", flowId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return flowInfo;
		}

		// Token: 0x06029CAE RID: 171182 RVA: 0x00BCEFAC File Offset: 0x00BCD1AC
		[return: Nullable(2)]
		private unsafe Aki.TDConfigMgr.Action.IStateInfo GetFbFlowState(string flowListName, int flowId, int stateId)
		{
			FlowConfig.FlowListFbIndex flowListFbIndex = this.FlowListFbLru.Get(flowListName);
			Aki.TDConfigMgr.Action.IStateInfo stateInfo = (flowListFbIndex != null) ? flowListFbIndex.GetState(flowId, stateId) : null;
			if (stateInfo == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "无法找到对应剧情的状态";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowId", flowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StateId", stateId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return stateInfo;
		}

		// Token: 0x06029CAF RID: 171183 RVA: 0x00BCF034 File Offset: 0x00BCD234
		[NullableContext(2)]
		public unsafe Aki.TDConfigMgr.Action.ShowTalk GetRandomFlow([Nullable(1)] string flowListName, int flowId, string ownerName, int? flowState = null)
		{
			List<Aki.TDConfigMgr.Action.ActionInfo> list = null;
			if (flowState != null)
			{
				int? num = flowState;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					list = this.GetFlowStateActions(flowListName, flowId, flowState.Value);
				}
			}
			if (list == null)
			{
				list = this.GetRandomStateActions(flowListName, flowId, ownerName);
			}
			if (list == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "找不到剧情配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("flowListName", flowListName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("flowId", flowId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			Aki.TDConfigMgr.Action.ActionInfo actionInfo = list.Find((Aki.TDConfigMgr.Action.ActionInfo action) => action.Name == Aki.TDConfigMgr.Action.EAction.ShowTalk);
			return ((actionInfo != null) ? actionInfo.Params : null) as Aki.TDConfigMgr.Action.ShowTalk;
		}

		// Token: 0x06029CB0 RID: 171184 RVA: 0x00BCF118 File Offset: 0x00BCD318
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<Aki.TDConfigMgr.Action.ActionInfo> GetFlowStateActions(string flowListName, int flowId, int stateId)
		{
			Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
			if (fbFlowState == null)
			{
				return null;
			}
			return fbFlowState.Actions;
		}

		// Token: 0x06029CB1 RID: 171185 RVA: 0x00BCF13C File Offset: 0x00BCD33C
		public bool? GetFlowNeedLoad(string flowListName, int flowId, int stateId)
		{
			Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
			if (fbFlowState == null)
			{
				return null;
			}
			return fbFlowState.IsPreloadFlow;
		}

		// Token: 0x06029CB2 RID: 171186 RVA: 0x00BCF168 File Offset: 0x00BCD368
		public bool? GetFlowStateKeepMusic(string flowListName, int flowId, int stateId)
		{
			Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
			return new bool?(((fbFlowState != null) ? fbFlowState.KeepBgm : null).GetValueOrDefault());
		}

		// Token: 0x06029CB3 RID: 171187 RVA: 0x00BCF1A0 File Offset: 0x00BCD3A0
		public bool GetFlowIsClientFlow(string flowListName, int flowId, int stateId)
		{
			Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
			return ((fbFlowState != null) ? fbFlowState.IsClientFlow : null).GetValueOrDefault();
		}

		// Token: 0x06029CB4 RID: 171188 RVA: 0x00BCF1D4 File Offset: 0x00BCD3D4
		[return: Nullable(2)]
		public Aki.TDConfigMgr.Action.IStateProgramSpecialProcessChangeTeamOptimization GetFlowProgramSpecialProcess(string flowListName, int flowId, int stateId)
		{
			Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
			if (fbFlowState == null)
			{
				return null;
			}
			return fbFlowState.ProgramSpecialProcess;
		}

		// Token: 0x06029CB5 RID: 171189 RVA: 0x00BCF1F8 File Offset: 0x00BCD3F8
		private FlowState? GetDbStateInfo(string flowListName, int flowId, int stateId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(flowListName);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(flowId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(stateId);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			FlowState? config = ConfigFlowStateByStateKey.GetConfig(text, true);
			if (config == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "无法找到对应剧情配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stateKey", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06029CB6 RID: 171190 RVA: 0x00BCF280 File Offset: 0x00BCD480
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> GetRandomStateActions(string flowListName, int flowId, [Nullable(2)] string ownerName)
		{
			Aki.TDConfigMgr.Action.IFlowInfo fbFlowInfo = this.GetFbFlowInfo(flowListName, flowId);
			if (((fbFlowInfo != null) ? fbFlowInfo.States : null) == null || fbFlowInfo.States.Count == 0)
			{
				return null;
			}
			Aki.TDConfigMgr.Action.IStateInfo randomArrayItem = ObjectUtils.GetRandomArrayItem<Aki.TDConfigMgr.Action.IStateInfo>(fbFlowInfo.States);
			if (randomArrayItem == null)
			{
				return null;
			}
			return randomArrayItem.Actions;
		}

		// Token: 0x06029CB7 RID: 171191 RVA: 0x00BCF2D0 File Offset: 0x00BCD4D0
		[NullableContext(2)]
		private unsafe Aki.TDConfigMgr.Action.IStateInfo GetJsonStateInfo([Nullable(1)] string flowListName, int flowId, int stateId, string ownerName = null)
		{
			Aki.TDConfigMgr.Action.IFlowInfo flowInfo = this.GetFlowInfo(flowListName, flowId, ownerName);
			if (flowInfo == null)
			{
				return null;
			}
			Aki.TDConfigMgr.Action.IStateInfo stateInfo = null;
			if (flowInfo.States != null)
			{
				foreach (Aki.TDConfigMgr.Action.IStateInfo stateInfo2 in flowInfo.States)
				{
					if (stateInfo2.Id == stateId)
					{
						stateInfo = stateInfo2;
						break;
					}
				}
			}
			if (stateInfo == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[StartFlow] 无法找到对应剧情的状态";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FlowId", flowId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StateId", stateId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return stateInfo;
		}

		// Token: 0x06029CB8 RID: 171192 RVA: 0x00BCF3A8 File Offset: 0x00BCD5A8
		[NullableContext(2)]
		private unsafe FlowListData GetFlowListData([Nullable(1)] string flowListName, string ownerName = null)
		{
			if (this.CacheFlowListMap == null)
			{
				this.CacheFlowListMap = new Dictionary<string, FlowListData>();
			}
			FlowListData flowListData;
			if (!this.CacheFlowListMap.TryGetValue(flowListName, out flowListData))
			{
				Aki.TDConfigMgr.Action.IFlowListInfo flowListInfo = PublicUtil.Instance.GetFlowListInfo(flowListName);
				if (flowListInfo == null || flowListInfo.Flows == null || flowListInfo.Flows.Count == 0)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Level;
					ELogAuthor author = ELogAuthor.CJH;
					string message = "FlowListName配置错误";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Value", flowListName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Name", ownerName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return null;
				}
				flowListData = new FlowListData();
				flowListData.Init(flowListInfo);
				this.CacheFlowListMap[flowListName] = flowListData;
				PublicUtil.Instance.RegisterFlowTextLocalConfig(flowListName);
			}
			flowListData.UpdateTime();
			return flowListData;
		}

		// Token: 0x06029CB9 RID: 171193 RVA: 0x00BCF480 File Offset: 0x00BCD680
		[NullableContext(2)]
		private Aki.TDConfigMgr.Action.IFlowInfo GetFlowInfo([Nullable(1)] string flowListName, int flowId, string ownerName = null)
		{
			FlowListData flowListData = this.GetFlowListData(flowListName, ownerName);
			if (flowListData == null)
			{
				return null;
			}
			Aki.TDConfigMgr.Action.IFlowInfo flowInfo = flowListData.GetFlowInfo(flowId);
			if (flowInfo == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "[PlotController.StartPlotNetwork] 无法找到对应剧情";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlotName", flowId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return flowInfo;
		}

		// Token: 0x06029CBA RID: 171194 RVA: 0x00BCF4D0 File Offset: 0x00BCD6D0
		private void ReadAudioConfig()
		{
			bool isPlayInEditor = GlobalData.IsPlayInEditor;
		}

		// Token: 0x06029CBB RID: 171195 RVA: 0x00BCF4D8 File Offset: 0x00BCD6D8
		public void ResetLocalFlowConfig()
		{
			Dictionary<string, FlowListData> cacheFlowListMap = this.CacheFlowListMap;
			if (cacheFlowListMap == null)
			{
				return;
			}
			cacheFlowListMap.Clear();
		}

		// Token: 0x17005443 RID: 21571
		// (get) Token: 0x06029CBC RID: 171196 RVA: 0x00BCF4EA File Offset: 0x00BCD6EA
		public static FlowConfig Instance
		{
			get
			{
				return FlowConfig._Instance;
			}
		}

		// Token: 0x06029CBD RID: 171197 RVA: 0x00BCF4F1 File Offset: 0x00BCD6F1
		public static FlowConfig GetOrCreateInstance()
		{
			if (FlowConfig._Instance == null)
			{
				FlowConfig.CreateInstance();
			}
			return FlowConfig._Instance;
		}

		// Token: 0x06029CBE RID: 171198 RVA: 0x00BCF505 File Offset: 0x00BCD705
		public static bool CreateInstance()
		{
			if (FlowConfig._Instance != null)
			{
				return true;
			}
			FlowConfig._Instance = new FlowConfig();
			return true;
		}

		// Token: 0x06029CBF RID: 171199 RVA: 0x00BCF51B File Offset: 0x00BCD71B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029CC0 RID: 171200 RVA: 0x00BCF51D File Offset: 0x00BCD71D
		public static void ResetStaticDefaultValue()
		{
			FlowConfig._Instance = null;
		}

		// Token: 0x06029CC1 RID: 171201 RVA: 0x00BCF525 File Offset: 0x00BCD725
		static FlowConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowConfig.CreateStaticDefaultValue), new Action(FlowConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04016CB0 RID: 93360
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, FlowListData> CacheFlowListMap;

		// Token: 0x04016CB1 RID: 93361
		private string FlowListFbPath = UBlueprintPathsLibrary.ProjectContentDir() + "Aki/Config/UniverseEditorConfig/FlowLists/";

		// Token: 0x04016CB2 RID: 93362
		private const int FLOW_LIST_FB_LRU_CAPACITY = 20;

		// Token: 0x04016CB3 RID: 93363
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private CacheLru<string, FlowConfig.FlowListFbIndex> FlowListFbLruInternal;

		// Token: 0x04016CB4 RID: 93364
		[Nullable(2)]
		private static FlowConfig _Instance;

		// Token: 0x02009C5B RID: 40027
		[Nullable(0)]
		private sealed class FlowListFbIndex
		{
			// Token: 0x06044DD8 RID: 282072 RVA: 0x0149124C File Offset: 0x0148F44C
			public FlowListFbIndex(Aki.TDConfigMgr.Action.IFlowListInfo flowList)
			{
				if (flowList.Flows == null)
				{
					return;
				}
				foreach (Aki.TDConfigMgr.Action.IFlowInfo flowInfo in flowList.Flows)
				{
					this._flowMap[flowInfo.Id] = flowInfo;
					Dictionary<int, Aki.TDConfigMgr.Action.IStateInfo> dictionary = new Dictionary<int, Aki.TDConfigMgr.Action.IStateInfo>();
					if (flowInfo.States != null)
					{
						foreach (Aki.TDConfigMgr.Action.IStateInfo stateInfo in flowInfo.States)
						{
							dictionary[stateInfo.Id] = stateInfo;
						}
					}
					this._stateMapByFlow[flowInfo.Id] = dictionary;
				}
			}

			// Token: 0x06044DD9 RID: 282073 RVA: 0x01491340 File Offset: 0x0148F540
			[NullableContext(2)]
			public Aki.TDConfigMgr.Action.IFlowInfo GetFlow(int flowId)
			{
				Aki.TDConfigMgr.Action.IFlowInfo result;
				if (!this._flowMap.TryGetValue(flowId, out result))
				{
					return null;
				}
				return result;
			}

			// Token: 0x06044DDA RID: 282074 RVA: 0x01491360 File Offset: 0x0148F560
			[NullableContext(2)]
			public Aki.TDConfigMgr.Action.IStateInfo GetState(int flowId, int stateId)
			{
				Dictionary<int, Aki.TDConfigMgr.Action.IStateInfo> dictionary;
				Aki.TDConfigMgr.Action.IStateInfo result;
				if (!this._stateMapByFlow.TryGetValue(flowId, out dictionary) || !dictionary.TryGetValue(stateId, out result))
				{
					return null;
				}
				return result;
			}

			// Token: 0x04030AA3 RID: 199331
			private readonly Dictionary<int, Aki.TDConfigMgr.Action.IFlowInfo> _flowMap = new Dictionary<int, Aki.TDConfigMgr.Action.IFlowInfo>();

			// Token: 0x04030AA4 RID: 199332
			private readonly Dictionary<int, Dictionary<int, Aki.TDConfigMgr.Action.IStateInfo>> _stateMapByFlow = new Dictionary<int, Dictionary<int, Aki.TDConfigMgr.Action.IStateInfo>>();
		}
	}
}
