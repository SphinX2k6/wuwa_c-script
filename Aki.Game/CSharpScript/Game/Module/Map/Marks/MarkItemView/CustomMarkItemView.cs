using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005505 RID: 21765
	public class CustomMarkItemView : ServerMarkItemView
	{
		// Token: 0x060379A2 RID: 227746 RVA: 0x00D33691 File Offset: 0x00D31891
		[NullableContext(1)]
		public CustomMarkItemView(CustomMarkItem holder) : base(holder)
		{
		}

		// Token: 0x060379A3 RID: 227747 RVA: 0x00D3369A File Offset: 0x00D3189A
		public override bool GetInteractiveFlag()
		{
			CustomMarkItem customMarkItem = this.Holder as CustomMarkItem;
			return (customMarkItem == null || !customMarkItem.IsNewCustomMarkItem) && base.GetInteractiveFlag();
		}
	}
}
