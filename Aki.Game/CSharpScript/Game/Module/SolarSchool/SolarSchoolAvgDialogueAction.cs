using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityAction;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058AF RID: 22703
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolAvgDialogueAction : SolarSchoolActionBase
	{
		// Token: 0x06037ECC RID: 229068 RVA: 0x00FA19E4 File Offset: 0x00F9FBE4
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.FlowId = ActivityActionBase.GetParamInt(parameters, "SolarSchoolFlow", this.FlowId);
		}

		// Token: 0x06037ECD RID: 229069 RVA: 0x00FA1A00 File Offset: 0x00F9FC00
		protected unsafe override void OnStart()
		{
			SolarSchoolFlow? flow = SolarSchoolConfig.Instance.GetFlow(this.FlowId);
			if (flow == null)
			{
				base.MarkFailed();
				return;
			}
			SolarSchoolFlow value = flow.Value;
			string flowListName = value.FlowListName;
			if (string.IsNullOrEmpty(flowListName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] AvgDialogueAction Flow 配置缺少 FlowListName";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("flowId", this.FlowId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.MarkFailed();
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "[SolarSchool] AvgDialogueAction 播放";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("flowId", this.FlowId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("flowListName", flowListName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("innerFlowId", value.FlowId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("stateId", value.StateId);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.PlayAsync(flowListName, value.FlowId, value.StateId, this.FlowId).Forget();
		}

		// Token: 0x06037ECE RID: 229070 RVA: 0x00FA1B48 File Offset: 0x00F9FD48
		private UniTask PlayAsync(string flowListName, int flowId, int stateId, int solarSchoolFlowId)
		{
			SolarSchoolAvgDialogueAction.<PlayAsync>d__3 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.flowListName = flowListName;
			<PlayAsync>d__.flowId = flowId;
			<PlayAsync>d__.stateId = stateId;
			<PlayAsync>d__.solarSchoolFlowId = solarSchoolFlowId;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<SolarSchoolAvgDialogueAction.<PlayAsync>d__3>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401D804 RID: 120836
		private int FlowId;
	}
}
