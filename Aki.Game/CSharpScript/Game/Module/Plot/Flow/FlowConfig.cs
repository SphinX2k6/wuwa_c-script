using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Wrapper.Out;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02005094 RID: 20628
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowConfig : ConfigBase
	{
		// Token: 0x17008082 RID: 32898
		// (get) Token: 0x06034DB0 RID: 216496 RVA: 0x00C81868 File Offset: 0x00C7FA68
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

		// Token: 0x06034DB1 RID: 216497 RVA: 0x00C8189B File Offset: 0x00C7FA9B
		protected override bool OnInit()
		{
			this.CacheFlowListMap = new Dictionary<string, FlowListData>();
			if (!PublicUtil.Instance.UseDbConfig())
			{
				FlowListData.AudioCache = new HashSet<string>();
				this.ReadAudioConfig();
			}
			return true;
		}

		// Token: 0x06034DB2 RID: 216498 RVA: 0x00C818C5 File Offset: 0x00C7FAC5
		protected override bool OnClear()
		{
			this.CacheFlowListMap = null;
			FlowListData.AudioCache = null;
			return true;
		}

		// Token: 0x06034DB3 RID: 216499 RVA: 0x00C818D8 File Offset: 0x00C7FAD8
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

		// Token: 0x06034DB4 RID: 216500 RVA: 0x00C81978 File Offset: 0x00C7FB78
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

		// Token: 0x06034DB5 RID: 216501 RVA: 0x00C819FC File Offset: 0x00C7FBFC
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

		// Token: 0x06034DB6 RID: 216502 RVA: 0x00C81A84 File Offset: 0x00C7FC84
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

		// Token: 0x06034DB7 RID: 216503 RVA: 0x00C81B68 File Offset: 0x00C7FD68
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<Aki.TDConfigMgr.Action.ActionInfo> GetFlowStateActions(string flowListName, int flowId, int stateId)
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				if (WrapperSetting.UseFb)
				{
					Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
					if (fbFlowState == null)
					{
						return null;
					}
					return fbFlowState.Actions;
				}
				else
				{
					FlowState? dbStateInfo = this.GetDbStateInfo(flowListName, flowId, stateId);
					if (dbStateInfo == null)
					{
						return null;
					}
					return Json.Parse<List<Aki.TDConfigMgr.Action.ActionInfo>>(dbStateInfo.Value.Actions, null);
				}
			}
			else
			{
				Aki.TDConfigMgr.Action.IStateInfo jsonStateInfo = this.GetJsonStateInfo(flowListName, flowId, stateId, null);
				if (jsonStateInfo == null)
				{
					return null;
				}
				return jsonStateInfo.Actions;
			}
		}

		// Token: 0x06034DB8 RID: 216504 RVA: 0x00C81BE0 File Offset: 0x00C7FDE0
		public bool? GetFlowNeedLoad(string flowListName, int flowId, int stateId)
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				if (!WrapperSetting.UseFb)
				{
					return new bool?(this.GetDbStateInfo(flowListName, flowId, stateId).Value.IsPreloadFlow);
				}
				Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
				if (fbFlowState == null)
				{
					return null;
				}
				return fbFlowState.IsPreloadFlow;
			}
			else
			{
				Aki.TDConfigMgr.Action.IStateInfo jsonStateInfo = this.GetJsonStateInfo(flowListName, flowId, stateId, null);
				if (jsonStateInfo == null)
				{
					return null;
				}
				return jsonStateInfo.IsPreloadFlow;
			}
		}

		// Token: 0x06034DB9 RID: 216505 RVA: 0x00C81C5C File Offset: 0x00C7FE5C
		public bool? GetFlowStateKeepMusic(string flowListName, int flowId, int stateId)
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				if (WrapperSetting.UseFb)
				{
					Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
					return new bool?(((fbFlowState != null) ? fbFlowState.KeepBgm : null).GetValueOrDefault());
				}
				FlowState? dbStateInfo = this.GetDbStateInfo(flowListName, flowId, stateId);
				if (dbStateInfo == null)
				{
					return new bool?(false);
				}
				return new bool?(dbStateInfo.Value.KeepBgm);
			}
			else
			{
				Aki.TDConfigMgr.Action.IStateInfo jsonStateInfo = this.GetJsonStateInfo(flowListName, flowId, stateId, null);
				if (jsonStateInfo == null)
				{
					return new bool?(false);
				}
				return jsonStateInfo.KeepBgm;
			}
		}

		// Token: 0x06034DBA RID: 216506 RVA: 0x00C81CF4 File Offset: 0x00C7FEF4
		public bool GetFlowIsClientFlow(string flowListName, int flowId, int stateId)
		{
			if (!PublicUtil.Instance.UseDbConfig())
			{
				Aki.TDConfigMgr.Action.IStateInfo jsonStateInfo = this.GetJsonStateInfo(flowListName, flowId, stateId, null);
				return ((jsonStateInfo != null) ? jsonStateInfo.IsClientFlow : null).GetValueOrDefault();
			}
			if (WrapperSetting.UseFb)
			{
				Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
				return ((fbFlowState != null) ? fbFlowState.IsClientFlow : null).GetValueOrDefault();
			}
			FlowState? dbStateInfo = this.GetDbStateInfo(flowListName, flowId, stateId);
			return dbStateInfo != null && dbStateInfo.GetValueOrDefault().IsClientFlow;
		}

		// Token: 0x06034DBB RID: 216507 RVA: 0x00C81D88 File Offset: 0x00C7FF88
		[return: Nullable(2)]
		public Aki.TDConfigMgr.Action.IStateProgramSpecialProcessChangeTeamOptimization GetFlowProgramSpecialProcess(string flowListName, int flowId, int stateId)
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				if (WrapperSetting.UseFb)
				{
					Aki.TDConfigMgr.Action.IStateInfo fbFlowState = this.GetFbFlowState(flowListName, flowId, stateId);
					if (fbFlowState == null)
					{
						return null;
					}
					return fbFlowState.ProgramSpecialProcess;
				}
				else
				{
					FlowState? dbStateInfo = this.GetDbStateInfo(flowListName, flowId, stateId);
					string text = (dbStateInfo != null) ? dbStateInfo.GetValueOrDefault().ProgramSpecialProcess : null;
					if (string.IsNullOrEmpty(text))
					{
						return null;
					}
					return Json.Parse<Aki.TDConfigMgr.Action.IStateProgramSpecialProcessChangeTeamOptimization>(text, null);
				}
			}
			else
			{
				Aki.TDConfigMgr.Action.IStateInfo jsonStateInfo = this.GetJsonStateInfo(flowListName, flowId, stateId, null);
				if (jsonStateInfo == null)
				{
					return null;
				}
				return jsonStateInfo.ProgramSpecialProcess;
			}
		}

		// Token: 0x06034DBC RID: 216508 RVA: 0x00C81E0C File Offset: 0x00C8000C
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

		// Token: 0x06034DBD RID: 216509 RVA: 0x00C81E94 File Offset: 0x00C80094
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private unsafe List<Aki.TDConfigMgr.Action.ActionInfo> GetRandomStateActions(string flowListName, int flowId, [Nullable(2)] string ownerName)
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				if (WrapperSetting.UseFb)
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
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted(flowListName);
					defaultInterpolatedStringHandler.AppendLiteral("_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(flowId);
					Flow? config = ConfigFlowById.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear(), true);
					if (config == null)
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
					int? randomStructArrayItem = ObjectUtils.GetRandomStructArrayItem<int>(config.Value.GetStatesArray());
					if (randomStructArrayItem == null)
					{
						return null;
					}
					return this.GetFlowStateActions(flowListName, flowId, randomStructArrayItem.Value);
				}
			}
			else
			{
				Aki.TDConfigMgr.Action.IFlowInfo flowInfo = this.GetFlowInfo(flowListName, flowId, ownerName);
				if (flowInfo == null || flowInfo.States == null || flowInfo.States.Count == 0)
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Level;
					ELogAuthor author2 = ELogAuthor.CJH;
					string message2 = "找不到剧情配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("flowListName", flowListName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("flowId", flowId);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return null;
				}
				Aki.TDConfigMgr.Action.IStateInfo randomArrayItem2 = ObjectUtils.GetRandomArrayItem<Aki.TDConfigMgr.Action.IStateInfo>(flowInfo.States);
				if (randomArrayItem2 == null)
				{
					global::Log instance3 = global::Log.Instance;
					ELogModule module3 = ELogModule.Plot;
					ELogAuthor author3 = ELogAuthor.YSQ;
					string message3 = "剧情状态为空";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("flowListName", flowListName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("flowId", flowId);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					return null;
				}
				return randomArrayItem2.Actions;
			}
		}

		// Token: 0x06034DBE RID: 216510 RVA: 0x00C820B0 File Offset: 0x00C802B0
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

		// Token: 0x06034DBF RID: 216511 RVA: 0x00C82188 File Offset: 0x00C80388
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

		// Token: 0x06034DC0 RID: 216512 RVA: 0x00C82260 File Offset: 0x00C80460
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

		// Token: 0x06034DC1 RID: 216513 RVA: 0x00C822B0 File Offset: 0x00C804B0
		private void ReadAudioConfig()
		{
			bool isPlayInEditor = GlobalData.IsPlayInEditor;
		}

		// Token: 0x06034DC2 RID: 216514 RVA: 0x00C822B8 File Offset: 0x00C804B8
		public void ResetLocalFlowConfig()
		{
			Dictionary<string, FlowListData> cacheFlowListMap = this.CacheFlowListMap;
			if (cacheFlowListMap == null)
			{
				return;
			}
			cacheFlowListMap.Clear();
		}

		// Token: 0x17008083 RID: 32899
		// (get) Token: 0x06034DC3 RID: 216515 RVA: 0x00C822CA File Offset: 0x00C804CA
		public static FlowConfig Instance
		{
			get
			{
				return FlowConfig._Instance;
			}
		}

		// Token: 0x06034DC4 RID: 216516 RVA: 0x00C822D1 File Offset: 0x00C804D1
		public static FlowConfig GetOrCreateInstance()
		{
			if (FlowConfig._Instance == null)
			{
				FlowConfig.CreateInstance();
			}
			return FlowConfig._Instance;
		}

		// Token: 0x06034DC5 RID: 216517 RVA: 0x00C822E5 File Offset: 0x00C804E5
		public static bool CreateInstance()
		{
			if (FlowConfig._Instance != null)
			{
				return true;
			}
			FlowConfig._Instance = new FlowConfig();
			return true;
		}

		// Token: 0x06034DC6 RID: 216518 RVA: 0x00C822FB File Offset: 0x00C804FB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034DC7 RID: 216519 RVA: 0x00C822FD File Offset: 0x00C804FD
		public static void ResetStaticDefaultValue()
		{
			FlowConfig._Instance = null;
		}

		// Token: 0x06034DC8 RID: 216520 RVA: 0x00C82305 File Offset: 0x00C80505
		static FlowConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowConfig.CreateStaticDefaultValue), new Action(FlowConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C281 RID: 115329
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, FlowListData> CacheFlowListMap;

		// Token: 0x0401C282 RID: 115330
		private string FlowListFbPath = UBlueprintPathsLibrary.ProjectContentDir() + "Aki/Config/UniverseEditorConfig/FlowLists/";

		// Token: 0x0401C283 RID: 115331
		private const int FLOW_LIST_FB_LRU_CAPACITY = 20;

		// Token: 0x0401C284 RID: 115332
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private CacheLru<string, FlowConfig.FlowListFbIndex> FlowListFbLruInternal;

		// Token: 0x0401C285 RID: 115333
		[Nullable(2)]
		private static FlowConfig _Instance;

		// Token: 0x0200B222 RID: 45602
		[Nullable(0)]
		private sealed class FlowListFbIndex
		{
			// Token: 0x0604E7CE RID: 321486 RVA: 0x014D794C File Offset: 0x014D5B4C
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

			// Token: 0x0604E7CF RID: 321487 RVA: 0x014D7A40 File Offset: 0x014D5C40
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

			// Token: 0x0604E7D0 RID: 321488 RVA: 0x014D7A60 File Offset: 0x014D5C60
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

			// Token: 0x0403604F RID: 221263
			private readonly Dictionary<int, Aki.TDConfigMgr.Action.IFlowInfo> _flowMap = new Dictionary<int, Aki.TDConfigMgr.Action.IFlowInfo>();

			// Token: 0x04036050 RID: 221264
			private readonly Dictionary<int, Dictionary<int, Aki.TDConfigMgr.Action.IStateInfo>> _stateMapByFlow = new Dictionary<int, Dictionary<int, Aki.TDConfigMgr.Action.IStateInfo>>();
		}
	}
}
