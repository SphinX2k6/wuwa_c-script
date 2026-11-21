using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D79 RID: 23929
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMotorcycleDevelop : OpenSystemBase
	{
		// Token: 0x0603A56C RID: 238956 RVA: 0x0107BD4C File Offset: 0x01079F4C
		public OpenSystemMotorcycleDevelop(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A56D RID: 238957 RVA: 0x0107BD58 File Offset: 0x01079F58
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMotorcycleDevelop.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMotorcycleDevelop.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A56E RID: 238958 RVA: 0x0107BD93 File Offset: 0x01079F93
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MotorcycleRootView);
		}
	}
}
