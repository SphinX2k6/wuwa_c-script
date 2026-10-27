using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005507 RID: 21767
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicConfigMarkItemView : MarkItemView
	{
		// Token: 0x060379A5 RID: 227749 RVA: 0x00D336C6 File Offset: 0x00D318C6
		public DynamicConfigMarkItemView(DynamicConfigMarkItem holder) : base(holder)
		{
		}

		// Token: 0x060379A6 RID: 227750 RVA: 0x00D336D0 File Offset: 0x00D318D0
		public override void OnIconPathChanged(string iconPath)
		{
			UUISprite sprite = base.GetSprite(1);
			base.LoadIcon(sprite, iconPath);
		}
	}
}
