using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Area.AreaFunction
{
	// Token: 0x02005EA7 RID: 24231
	[NullableContext(1)]
	public interface IAreaFunctionInstance
	{
		// Token: 0x0603DA8A RID: 252554
		void OnEnter();

		// Token: 0x0603DA8B RID: 252555
		void OnTick(double deltaMs);

		// Token: 0x0603DA8C RID: 252556
		void OnLeave(string reason);
	}
}
