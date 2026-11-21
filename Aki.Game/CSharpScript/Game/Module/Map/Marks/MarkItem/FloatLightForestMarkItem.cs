using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044B9 RID: 17593
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatLightForestMarkItem : ConfigMarkItem
	{
		// Token: 0x170058D0 RID: 22736
		// (get) Token: 0x0602C6A3 RID: 181923 RVA: 0x00C7C19F File Offset: 0x00C7A39F
		// (set) Token: 0x0602C6A4 RID: 181924 RVA: 0x00C7C1A7 File Offset: 0x00C7A3A7
		public override bool IsStreaming { get; set; }

		// Token: 0x0602C6A5 RID: 181925 RVA: 0x00C7C1B0 File Offset: 0x00C7A3B0
		public FloatLightForestMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x0602C6A6 RID: 181926 RVA: 0x00C7C1C1 File Offset: 0x00C7A3C1
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.FloatLightForestMarkItemView;
		}

		// Token: 0x0602C6A7 RID: 181927 RVA: 0x00C7C1C5 File Offset: 0x00C7A3C5
		[PreserveBaseOverrides]
		protected new virtual FloatLightForestMarkItemView CreateView()
		{
			return new FloatLightForestMarkItemView(this);
		}

		// Token: 0x0602C6A8 RID: 181928 RVA: 0x00C7C1CD File Offset: 0x00C7A3CD
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
