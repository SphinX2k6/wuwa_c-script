using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BB2 RID: 23474
	[NullableContext(1)]
	public interface ICiacconaGalConfigQuery
	{
		// Token: 0x0603B60D RID: 243213
		void Init();

		// Token: 0x0603B60E RID: 243214
		object GetConfig(int id, bool useCache);
	}
}
