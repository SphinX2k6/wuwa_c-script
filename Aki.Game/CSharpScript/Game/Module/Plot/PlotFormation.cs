using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FF4 RID: 20468
	public class PlotFormation
	{
		// Token: 0x060345CC RID: 214476 RVA: 0x00C4D988 File Offset: 0x00C4BB88
		public void ChangeFormation()
		{
			Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[剧情加载等待] 剧情切编队-开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			PlotModel.Instance.InSeamlessFormation = true;
		}

		// Token: 0x060345CD RID: 214477 RVA: 0x00C4D9BC File Offset: 0x00C4BBBC
		public UniTask CheckFormationPromise()
		{
			PlotFormation.<CheckFormationPromise>d__1 <CheckFormationPromise>d__;
			<CheckFormationPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckFormationPromise>d__.<>1__state = -1;
			<CheckFormationPromise>d__.<>t__builder.Start<PlotFormation.<CheckFormationPromise>d__1>(ref <CheckFormationPromise>d__);
			return <CheckFormationPromise>d__.<>t__builder.Task;
		}
	}
}
