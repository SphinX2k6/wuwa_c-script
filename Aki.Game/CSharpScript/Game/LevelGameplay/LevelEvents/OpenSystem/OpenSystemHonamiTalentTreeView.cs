using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BF2 RID: 27634
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiTalentTreeView : OpenSystemBase
	{
		// Token: 0x060443EA RID: 279530 RVA: 0x010D1723 File Offset: 0x010CF923
		public OpenSystemHonamiTalentTreeView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443EB RID: 279531 RVA: 0x010D172C File Offset: 0x010CF92C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiTalentTreeView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiTalentTreeView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443EC RID: 279532 RVA: 0x010D1767 File Offset: 0x010CF967
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryTechnologyView);
		}
	}
}
