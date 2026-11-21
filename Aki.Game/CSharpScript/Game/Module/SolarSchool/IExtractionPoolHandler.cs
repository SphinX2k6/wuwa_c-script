using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005948 RID: 22856
	[NullableContext(1)]
	public interface IExtractionPoolHandler<[Nullable(2)] TItem>
	{
		// Token: 0x06038517 RID: 230679
		bool HasItem();

		// Token: 0x06038518 RID: 230680
		TItem GetItem();

		// Token: 0x06038519 RID: 230681
		void PutItem(TItem item);

		// Token: 0x0603851A RID: 230682
		void Clear();
	}
}
