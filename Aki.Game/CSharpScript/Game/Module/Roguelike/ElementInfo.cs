using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D5C RID: 15708
	[NullableContext(2)]
	[Nullable(0)]
	public class ElementInfo
	{
		// Token: 0x0602836D RID: 164717 RVA: 0x00B436A4 File Offset: 0x00B418A4
		public ElementInfo(int elementId, int count, string name = null)
		{
			this.ElementId = elementId;
			this.Count = count;
			this.Name = name;
			this.IsPreview = false;
		}

		// Token: 0x04015DB3 RID: 89523
		public int ElementId;

		// Token: 0x04015DB4 RID: 89524
		public int Count;

		// Token: 0x04015DB5 RID: 89525
		public string Name;

		// Token: 0x04015DB6 RID: 89526
		public bool IsPreview;
	}
}
