using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003641 RID: 13889
	[NullableContext(1)]
	public interface IExecutableUnit
	{
		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x0602408B RID: 147595
		bool IsExecute { get; }

		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x0602408C RID: 147596
		int Id { get; }

		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x0602408D RID: 147597
		Enum Type { get; }

		// Token: 0x0602408E RID: 147598
		UniTask ExecuteAction();

		// Token: 0x0602408F RID: 147599
		void OnTick(float delta);
	}
}
