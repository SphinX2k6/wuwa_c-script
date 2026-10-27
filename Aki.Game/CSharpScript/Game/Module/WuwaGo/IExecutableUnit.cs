using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004711 RID: 18193
	[NullableContext(1)]
	public interface IExecutableUnit
	{
		// Token: 0x170076E4 RID: 30436
		// (get) Token: 0x0602F8C5 RID: 194757
		bool IsExecute { get; }

		// Token: 0x170076E5 RID: 30437
		// (get) Token: 0x0602F8C6 RID: 194758
		int Id { get; }

		// Token: 0x170076E6 RID: 30438
		// (get) Token: 0x0602F8C7 RID: 194759
		Enum Type { get; }

		// Token: 0x0602F8C8 RID: 194760
		UniTask ExecuteAction();

		// Token: 0x0602F8C9 RID: 194761
		void OnTick(float delta);
	}
}
