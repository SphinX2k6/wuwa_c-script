using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044DA RID: 17626
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicConfigMarkItemView : MarkItemView
	{
		// Token: 0x0602C873 RID: 182387 RVA: 0x00C815B0 File Offset: 0x00C7F7B0
		public DynamicConfigMarkItemView(DynamicConfigMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C874 RID: 182388 RVA: 0x00C815BC File Offset: 0x00C7F7BC
		public override void OnIconPathChanged(string iconPath)
		{
			UUISprite sprite = base.GetSprite(1);
			base.LoadIcon(sprite, iconPath);
		}
	}
}
