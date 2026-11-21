using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003841 RID: 14401
	[NullableContext(2)]
	public interface ILayoutItem<TILayoutItemItem>
	{
		// Token: 0x17004CEE RID: 19694
		// (get) Token: 0x0602569D RID: 153245
		// (set) Token: 0x0602569E RID: 153246
		[Nullable(1)]
		object Key { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004CEF RID: 19695
		// (get) Token: 0x0602569F RID: 153247
		// (set) Token: 0x060256A0 RID: 153248
		TILayoutItemItem Value { get; set; }
	}
}
