using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054E6 RID: 21734
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatLightForestMarkItem : ConfigMarkItem
	{
		// Token: 0x17008541 RID: 34113
		// (get) Token: 0x060377E6 RID: 227302 RVA: 0x00D2E0AC File Offset: 0x00D2C2AC
		// (set) Token: 0x060377E7 RID: 227303 RVA: 0x00D2E0B4 File Offset: 0x00D2C2B4
		public override bool IsStreaming { get; set; }

		// Token: 0x060377E8 RID: 227304 RVA: 0x00D2E0BD File Offset: 0x00D2C2BD
		public FloatLightForestMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x060377E9 RID: 227305 RVA: 0x00D2E0CE File Offset: 0x00D2C2CE
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.FloatLightForestMarkItemView;
		}

		// Token: 0x060377EA RID: 227306 RVA: 0x00D2E0D2 File Offset: 0x00D2C2D2
		[PreserveBaseOverrides]
		protected new virtual FloatLightForestMarkItemView CreateView()
		{
			return new FloatLightForestMarkItemView(this);
		}

		// Token: 0x060377EB RID: 227307 RVA: 0x00D2E0DA File Offset: 0x00D2C2DA
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
