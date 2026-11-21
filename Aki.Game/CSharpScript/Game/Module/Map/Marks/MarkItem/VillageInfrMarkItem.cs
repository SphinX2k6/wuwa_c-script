using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044D3 RID: 17619
	public class VillageInfrMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C851 RID: 182353 RVA: 0x00C80EEE File Offset: 0x00C7F0EE
		[NullableContext(1)]
		public VillageInfrMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}
	}
}
