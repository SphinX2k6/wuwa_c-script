using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Controller
{
	// Token: 0x0200558F RID: 21903
	[NullableContext(2)]
	[Nullable(0)]
	internal class LineTraceSaver
	{
		// Token: 0x06037D09 RID: 228617 RVA: 0x00D39A2C File Offset: 0x00D37C2C
		protected void InitTrackInfo()
		{
			this.LineTrace = new UTraceLineElement();
			this.LineTrace.WorldContextObject = GlobalData.World;
			this.LineTrace.bIsSingle = true;
			this.LineTrace.bIgnoreSelf = true;
			this.LineTrace.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		}

		// Token: 0x06037D0A RID: 228618 RVA: 0x00D39A7C File Offset: 0x00D37C7C
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

		// Token: 0x06037D0B RID: 228619 RVA: 0x00D39B38 File Offset: 0x00D37D38
		public void OnClear()
		{
			this.LineTrace = null;
		}

		// Token: 0x0401D564 RID: 120164
		private UTraceLineElement LineTrace;
	}
}
