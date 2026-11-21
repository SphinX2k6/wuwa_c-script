using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004B92 RID: 19346
	[NullableContext(1)]
	public interface ICiacconaGalConfigQuery
	{
		// Token: 0x0603055A RID: 197978
		void Init();

		// Token: 0x0603055B RID: 197979
		object GetConfig(int id, bool useCache);
	}
}
