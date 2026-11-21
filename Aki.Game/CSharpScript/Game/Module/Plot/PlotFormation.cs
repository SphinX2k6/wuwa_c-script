using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FBE RID: 16318
	public class PlotFormation
	{
		// Token: 0x06029457 RID: 169047 RVA: 0x00B979E8 File Offset: 0x00B95BE8
		public void ChangeFormation()
		{
			Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[剧情加载等待] 剧情切编队-开始", default(ReadOnlySpan<ValueTuple<string, object>>));
			PlotModel.Instance.InSeamlessFormation = true;
		}

		// Token: 0x06029458 RID: 169048 RVA: 0x00B97A1C File Offset: 0x00B95C1C
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
