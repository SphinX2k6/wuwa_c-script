using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D93 RID: 19859
	[NullableContext(2)]
	[Nullable(0)]
	public class ElementInfo
	{
		// Token: 0x06033500 RID: 210176 RVA: 0x00BFA0A8 File Offset: 0x00BF82A8
		public ElementInfo(int elementId, int count, string name = null)
		{
			this.ElementId = elementId;
			this.Count = count;
			this.Name = name;
			this.IsPreview = false;
		}

		// Token: 0x0401B3E0 RID: 111584
		public int ElementId;

		// Token: 0x0401B3E1 RID: 111585
		public int Count;

		// Token: 0x0401B3E2 RID: 111586
		public string Name;

		// Token: 0x0401B3E3 RID: 111587
		public bool IsPreview;
	}
}
