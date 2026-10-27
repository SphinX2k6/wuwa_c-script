using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054EC RID: 21740
	[NullableContext(1)]
	[Nullable(0)]
	public class LandscapeMarkItem : ConfigMarkItem
	{
		// Token: 0x06037818 RID: 227352 RVA: 0x00D2E6DB File Offset: 0x00D2C8DB
		public LandscapeMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x06037819 RID: 227353 RVA: 0x00D2E6F1 File Offset: 0x00D2C8F1
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.LandscapeMarkItemView;
		}

		// Token: 0x0603781A RID: 227354 RVA: 0x00D2E6F5 File Offset: 0x00D2C8F5
		[PreserveBaseOverrides]
		protected new virtual LandscapeMarkItemView CreateView()
		{
			return new LandscapeMarkItemView(this);
		}

		// Token: 0x0603781B RID: 227355 RVA: 0x00D2E6FD File Offset: 0x00D2C8FD
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
