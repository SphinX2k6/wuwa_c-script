using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200347E RID: 13438
	[NullableContext(1)]
	[Nullable(0)]
	public class TraceUtils
	{
		// Token: 0x06022492 RID: 140434 RVA: 0x009B75DC File Offset: 0x009B57DC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ValueTuple<bool, UKuroHitResult> LineTraceWithLocation(Vector location, float startOffset, float endOffset)
		{
			Vector commonStartLocation = TraceElementModel.Instance.CommonStartLocation;
			commonStartLocation.Set(location.X, location.Y, location.Z + (double)startOffset);
			Vector commonEndLocation = TraceElementModel.Instance.CommonEndLocation;
			commonEndLocation.Set(location.X, location.Y, location.Z + (double)endOffset);
			UTraceLineElement lineTrace = TraceElementModel.Instance.GetLineTrace();
			lineTrace.WorldContextObject = GlobalData.World;
			lineTrace.ActorsToIgnore.Empty(true);
			TraceElementCommon.Instance.SetStartLocation(lineTrace, commonStartLocation);
			TraceElementCommon.Instance.SetEndLocation(lineTrace, commonEndLocation);
			bool item = TraceElementCommon.Instance.LineTrace(lineTrace, "TraceUtil");
			UKuroHitResult hitResult = lineTrace.HitResult;
			lineTrace.ClearCacheData(false);
			return new ValueTuple<bool, UKuroHitResult>(item, hitResult);
		}

		// Token: 0x04012E24 RID: 77348
		private const string PROFILE_KEY = "TraceUtil";
	}
}
