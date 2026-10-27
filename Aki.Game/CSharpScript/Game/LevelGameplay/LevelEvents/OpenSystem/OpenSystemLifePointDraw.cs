using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BF9 RID: 27641
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemLifePointDraw : OpenSystemBase
	{
		// Token: 0x060443FF RID: 279551 RVA: 0x010D1B22 File Offset: 0x010CFD22
		public OpenSystemLifePointDraw(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044400 RID: 279552 RVA: 0x010D1B2C File Offset: 0x010CFD2C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemLifePointDraw.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemLifePointDraw.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044401 RID: 279553 RVA: 0x010D1B67 File Offset: 0x010CFD67
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.LifePointDrawEntranceView);
		}
	}
}
