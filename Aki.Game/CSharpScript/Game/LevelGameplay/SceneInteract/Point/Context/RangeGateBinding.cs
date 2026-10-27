using System;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02006A8E RID: 27278
	public class RangeGateBinding
	{
		// Token: 0x06043C78 RID: 277624 RVA: 0x010970F3 File Offset: 0x010952F3
		public RangeGateBinding(int EnableRangeId, int DisableRangeId)
		{
			this.EnableRangeId = EnableRangeId;
			this.DisableRangeId = DisableRangeId;
			InteractBoxQueryManager.Instance.AddRef(EnableRangeId);
			InteractBoxQueryManager.Instance.AddRef(DisableRangeId);
		}

		// Token: 0x06043C79 RID: 277625 RVA: 0x0109711F File Offset: 0x0109531F
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

		// Token: 0x0402369C RID: 145052
		private bool Disposed;

		// Token: 0x0402369D RID: 145053
		public readonly int EnableRangeId;

		// Token: 0x0402369E RID: 145054
		public readonly int DisableRangeId;
	}
}
