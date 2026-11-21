using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044BD RID: 17597
	public class InfrObservatoryMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C6CD RID: 181965 RVA: 0x00C7C72A File Offset: 0x00C7A92A
		[NullableContext(1)]
		public InfrObservatoryMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}
	}
}
