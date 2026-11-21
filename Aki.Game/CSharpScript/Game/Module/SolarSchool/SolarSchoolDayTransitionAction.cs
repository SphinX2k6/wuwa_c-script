using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B2 RID: 22706
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolDayTransitionAction : SolarSchoolActionBase
	{
		// Token: 0x06037EDE RID: 229086 RVA: 0x00FA1FD5 File Offset: 0x00FA01D5
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.TransitionType = (ESolarSchoolTimeTransition)ActivityActionBase.GetParamInt(parameters, "SolarSchoolDayTransitionType", (int)this.TransitionType);
		}

		// Token: 0x06037EDF RID: 229087 RVA: 0x00FA1FF0 File Offset: 0x00FA01F0
		protected override void OnStart()
		{
			if (this.TransitionType == ESolarSchoolTimeTransition.None)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] DayTransitionAction 缺少有效 TransitionType", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.MarkFailed();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 跨天动效开始";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("transitionType", this.TransitionType);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.PlayAsync().Forget();
		}

		// Token: 0x06037EE0 RID: 229088 RVA: 0x00FA206C File Offset: 0x00FA026C
		private UniTask PlayAsync()
		{
			SolarSchoolDayTransitionAction.<PlayAsync>d__4 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<SolarSchoolDayTransitionAction.<PlayAsync>d__4>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037EE1 RID: 229089 RVA: 0x00FA20AF File Offset: 0x00FA02AF
		private void OnPlayFinish()
		{
			base.MarkDone();
		}

		// Token: 0x06037EE2 RID: 229090 RVA: 0x00FA20B7 File Offset: 0x00FA02B7
		protected override void OnDelete()
		{
			SolarSchoolRootViewModel rootViewModel = SolarSchoolGamePlayModel.Instance.RootViewModel;
			if (rootViewModel == null)
			{
				return;
			}
			Action stopDayTransition = rootViewModel.StopDayTransition;
			if (stopDayTransition == null)
			{
				return;
			}
			stopDayTransition();
		}

		// Token: 0x0401D80B RID: 120843
		public const string ParamKeyType = "SolarSchoolDayTransitionType";

		// Token: 0x0401D80C RID: 120844
		private ESolarSchoolTimeTransition TransitionType;
	}
}
