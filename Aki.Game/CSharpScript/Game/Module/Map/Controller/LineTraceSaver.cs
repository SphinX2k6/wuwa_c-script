using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Controller
{
	// Token: 0x02004565 RID: 17765
	[NullableContext(2)]
	[Nullable(0)]
	internal class LineTraceSaver
	{
		// Token: 0x0602CC07 RID: 183303 RVA: 0x00C876F4 File Offset: 0x00C858F4
		protected void InitTrackInfo()
		{
			this.LineTrace = new UTraceLineElement();
			this.LineTrace.WorldContextObject = GlobalData.World;
			this.LineTrace.bIsSingle = true;
			this.LineTrace.bIgnoreSelf = true;
			this.LineTrace.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		}

		// Token: 0x0602CC08 RID: 183304 RVA: 0x00C87744 File Offset: 0x00C85944
		public Vector GetMarkPosition(double x, double y)
		{
			if (this.LineTrace == null)
			{
				this.InitTrackInfo();
			}
			Vector result = null;
			this.LineTrace.SetStartLocation(x * 100.0, y * 100.0, 1000000.0);
			this.LineTrace.SetEndLocation(x * 100.0, y * 100.0, -1000000.0);
			bool flag = TraceElementCommon.Instance.LineTrace(this.LineTrace, "WorldMapView_CreateNewCustomMarkItem");
			UKuroHitResult hitResult = this.LineTrace.HitResult;
			if (flag && hitResult.bBlockingHit)
			{
				float num = hitResult.LocationZ_Array.Get(0);
				num /= 100f;
				result = Vector.Create(x, y, (double)num);
			}
			return result;
		}

		// Token: 0x0602CC09 RID: 183305 RVA: 0x00C87800 File Offset: 0x00C85A00
		public void OnClear()
		{
			this.LineTrace = null;
		}

		// Token: 0x04017FEF RID: 98287
		private UTraceLineElement LineTrace;
	}
}
