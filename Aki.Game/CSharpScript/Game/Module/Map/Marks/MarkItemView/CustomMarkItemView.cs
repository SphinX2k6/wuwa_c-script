using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044D8 RID: 17624
	public class CustomMarkItemView : ServerMarkItemView
	{
		// Token: 0x0602C870 RID: 182384 RVA: 0x00C8157B File Offset: 0x00C7F77B
		[NullableContext(1)]
		public CustomMarkItemView(CustomMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C871 RID: 182385 RVA: 0x00C81584 File Offset: 0x00C7F784
		public override bool GetInteractiveFlag()
		{
			CustomMarkItem customMarkItem = this.Holder as CustomMarkItem;
			return (customMarkItem == null || !customMarkItem.IsNewCustomMarkItem) && base.GetInteractiveFlag();
		}
	}
}
