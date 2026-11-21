using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Area.AreaFunction
{
	// Token: 0x02004E8C RID: 20108
	[NullableContext(1)]
	public interface IAreaFunctionInstance
	{
		// Token: 0x06032A1A RID: 207386
		void OnEnter();

		// Token: 0x06032A1B RID: 207387
		void OnTick(double deltaMs);

		// Token: 0x06032A1C RID: 207388
		void OnLeave(string reason);
	}
}
