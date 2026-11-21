using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B7 RID: 22711
	public class SolarSchoolFullScreenDayTransitionAction : SolarSchoolActionBase
	{
		// Token: 0x06037EFD RID: 229117 RVA: 0x00FA2A57 File Offset: 0x00FA0C57
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.StartDayIndex = ActivityActionBase.GetParamInt(parameters, "DayTransitionStartDayIndex", 0);
			this.TargetDayIndex = ActivityActionBase.GetParamInt(parameters, "DayTransitionTargetDayIndex", 0);
		}

		// Token: 0x06037EFE RID: 229118 RVA: 0x00FA2A7D File Offset: 0x00FA0C7D
		protected override void OnStart()
		{
			this.PlayAsync().Forget();
		}

		// Token: 0x06037EFF RID: 229119 RVA: 0x00FA2A8C File Offset: 0x00FA0C8C
		private UniTask PlayAsync()
		{
			SolarSchoolFullScreenDayTransitionAction.<PlayAsync>d__4 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<SolarSchoolFullScreenDayTransitionAction.<PlayAsync>d__4>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037F00 RID: 229120 RVA: 0x00FA2ACF File Offset: 0x00FA0CCF
		protected override void OnDelete()
		{
			SolarSchoolModel.Instance.OnLoadingViewHidden();
			UiManager.Instance.CloseView(EUiViewName.SolarSchoolDayChangeLoadingView, null);
		}

		// Token: 0x0401D818 RID: 120856
		private int StartDayIndex;

		// Token: 0x0401D819 RID: 120857
		private int TargetDayIndex;
	}
}
