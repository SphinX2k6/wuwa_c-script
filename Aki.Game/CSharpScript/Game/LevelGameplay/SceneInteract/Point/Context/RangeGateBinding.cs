using System;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02005BEB RID: 23531
	public class RangeGateBinding
	{
		// Token: 0x06039CC6 RID: 236742 RVA: 0x0103B947 File Offset: 0x01039B47
		public RangeGateBinding(int EnableRangeId, int DisableRangeId)
		{
			this.EnableRangeId = EnableRangeId;
			this.DisableRangeId = DisableRangeId;
			InteractBoxQueryManager.Instance.AddRef(EnableRangeId);
			InteractBoxQueryManager.Instance.AddRef(DisableRangeId);
		}

		// Token: 0x06039CC7 RID: 236743 RVA: 0x0103B973 File Offset: 0x01039B73
		public void Dispose()
		{
			if (this.Disposed)
			{
				return;
			}
			this.Disposed = true;
			InteractBoxQueryManager.Instance.Release(this.EnableRangeId);
			InteractBoxQueryManager.Instance.Release(this.DisableRangeId);
		}

		// Token: 0x0401E88E RID: 125070
		private bool Disposed;

		// Token: 0x0401E88F RID: 125071
		public readonly int EnableRangeId;

		// Token: 0x0401E890 RID: 125072
		public readonly int DisableRangeId;
	}
}
