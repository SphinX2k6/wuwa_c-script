using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044BF RID: 17599
	[NullableContext(1)]
	[Nullable(0)]
	public class LandscapeMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C6D2 RID: 181970 RVA: 0x00C7C7A9 File Offset: 0x00C7A9A9
		public LandscapeMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C6D3 RID: 181971 RVA: 0x00C7C7BF File Offset: 0x00C7A9BF
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.LandscapeMarkItemView;
		}

		// Token: 0x0602C6D4 RID: 181972 RVA: 0x00C7C7C3 File Offset: 0x00C7A9C3
		[PreserveBaseOverrides]
		protected new virtual LandscapeMarkItemView CreateView()
		{
			return new LandscapeMarkItemView(this);
		}

		// Token: 0x0602C6D5 RID: 181973 RVA: 0x00C7C7CB File Offset: 0x00C7A9CB
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
