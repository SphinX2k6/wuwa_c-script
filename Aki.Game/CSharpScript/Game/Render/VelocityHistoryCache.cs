using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x0200350A RID: 13578
	[NullableContext(1)]
	[Nullable(0)]
	public class VelocityHistoryCache
	{
		// Token: 0x060228F9 RID: 141561 RVA: 0x009D22EC File Offset: 0x009D04EC
		public void Initialize(int size)
		{
			this.VelocityHistory.Clear();
			for (int i = 0; i < size; i++)
			{
				this.VelocityHistory.Add(Vector.Create(0.0, 0.0, 0.0));
			}
		}

		// Token: 0x060228FA RID: 141562 RVA: 0x009D233C File Offset: 0x009D053C
		public void AddVelocity(Vector velocity)
		{
			this.VelocityHistory[this.VelocityHistoryArrayPtr].Set(velocity.X, velocity.Y, velocity.Z);
			this.VelocityHistoryArrayPtr = (this.VelocityHistoryArrayPtr + 1) % this.VelocityHistory.Count;
		}

		// Token: 0x060228FB RID: 141563 RVA: 0x009D238C File Offset: 0x009D058C
		public double GetMaxVelocityDirection(Vector direction)
		{
			double num = 0.0;
			foreach (Vector vector in this.VelocityHistory)
			{
				num = Math.Max(num, vector.DotProduct(direction));
			}
			return num;
		}

		// Token: 0x060228FC RID: 141564 RVA: 0x009D23F4 File Offset: 0x009D05F4
		public double GetMaxVelocity()
		{
			double num = 0.0;
			foreach (Vector vector in this.VelocityHistory)
			{
				num = Math.Max(num, vector.Size());
			}
			return num;
		}

		// Token: 0x04013213 RID: 78355
		protected List<Vector> VelocityHistory = new List<Vector>();

		// Token: 0x04013214 RID: 78356
		protected int VelocityHistoryArrayPtr;
	}
}
