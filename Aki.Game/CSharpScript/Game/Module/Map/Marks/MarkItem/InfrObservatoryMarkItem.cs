using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054EA RID: 21738
	public class InfrObservatoryMarkItem : ConfigMarkItem
	{
		// Token: 0x06037811 RID: 227345 RVA: 0x00D2E632 File Offset: 0x00D2C832
		[NullableContext(1)]
		public InfrObservatoryMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0401D3A7 RID: 119719
		[Nullable(2)]
		public InfrObservatoryMarkItemView InnerView;
	}
}
