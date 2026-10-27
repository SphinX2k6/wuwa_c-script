using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x02005500 RID: 21760
	public class VillageInfrMarkItem : ConfigMarkItem
	{
		// Token: 0x06037980 RID: 227712 RVA: 0x00D32F36 File Offset: 0x00D31136
		[NullableContext(1)]
		public VillageInfrMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0401D404 RID: 119812
		[Nullable(2)]
		public VillageInfrMarkItemView InnerView;
	}
}
