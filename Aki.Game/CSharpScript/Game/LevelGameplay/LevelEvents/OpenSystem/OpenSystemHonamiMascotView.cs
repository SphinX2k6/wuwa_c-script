using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BF0 RID: 27632
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiMascotView : OpenSystemBase
	{
		// Token: 0x060443E4 RID: 279524 RVA: 0x010D1673 File Offset: 0x010CF873
		public OpenSystemHonamiMascotView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443E5 RID: 279525 RVA: 0x010D167C File Offset: 0x010CF87C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiMascotView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiMascotView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443E6 RID: 279526 RVA: 0x010D16BF File Offset: 0x010CF8BF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryMascotCollectBookView);
		}
	}
}
