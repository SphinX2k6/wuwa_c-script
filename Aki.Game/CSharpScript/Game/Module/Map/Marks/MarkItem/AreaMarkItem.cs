using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054D7 RID: 21719
	[NullableContext(1)]
	[Nullable(0)]
	public class AreaMarkItem : ConfigMarkItem
	{
		// Token: 0x06037735 RID: 227125 RVA: 0x00D2C021 File Offset: 0x00D2A221
		public AreaMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x06037736 RID: 227126 RVA: 0x00D2C032 File Offset: 0x00D2A232
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.AreaMarkItemView;
		}

		// Token: 0x06037737 RID: 227127 RVA: 0x00D2C035 File Offset: 0x00D2A235
		protected override MarkItemView CreateView()
		{
			return new AreaMarkItemView(this);
		}

		// Token: 0x06037738 RID: 227128 RVA: 0x00D2C03D File Offset: 0x00D2A23D
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
