using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004556 RID: 17750
	[NullableContext(1)]
	[Nullable(0)]
	public class TraceUtils
	{
		// Token: 0x0602DDB0 RID: 187824 RVA: 0x00A8BEC4 File Offset: 0x00A8A0C4
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

		// Token: 0x040187EA RID: 100330
		private const string PROFILE_KEY = "TraceUtil";
	}
}
