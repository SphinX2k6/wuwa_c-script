using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048CB RID: 18635
	[NullableContext(2)]
	[Nullable(0)]
	public class LayoutItem<TLayoutItemItem> : ILayoutItem<TLayoutItemItem>
	{
		// Token: 0x17007988 RID: 31112
		// (get) Token: 0x06030B75 RID: 199541 RVA: 0x00B4FB97 File Offset: 0x00B4DD97
		// (set) Token: 0x06030B76 RID: 199542 RVA: 0x00B4FB9F File Offset: 0x00B4DD9F
		[Nullable(1)]
		public object Key { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007989 RID: 31113
		// (get) Token: 0x06030B77 RID: 199543 RVA: 0x00B4FBA8 File Offset: 0x00B4DDA8
		// (set) Token: 0x06030B78 RID: 199544 RVA: 0x00B4FBB0 File Offset: 0x00B4DDB0
		public TLayoutItemItem Value { get; set; }
	}
}
