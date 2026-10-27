using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BDA RID: 27610
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDrinksGamePlayView : OpenSystemBase
	{
		// Token: 0x060443A3 RID: 279459 RVA: 0x010D0EE4 File Offset: 0x010CF0E4
		public OpenSystemDrinksGamePlayView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443A4 RID: 279460 RVA: 0x010D0EF0 File Offset: 0x010CF0F0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDrinksGamePlayView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDrinksGamePlayView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443A5 RID: 279461 RVA: 0x010D0F2C File Offset: 0x010CF12C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
