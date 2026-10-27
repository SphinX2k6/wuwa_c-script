using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045E1 RID: 17889
	[NullableContext(1)]
	[Nullable(0)]
	public class VelocityHistoryCache
	{
		// Token: 0x0602E205 RID: 188933 RVA: 0x00AA5C10 File Offset: 0x00AA3E10
		public void Initialize(int size)
		{
			this.VelocityHistory.Clear();
			for (int i = 0; i < size; i++)
			{
				this.VelocityHistory.Add(Vector.Create(0.0, 0.0, 0.0));
			}
		}

		// Token: 0x0602E206 RID: 188934 RVA: 0x00AA5C60 File Offset: 0x00AA3E60
		public void AddVelocity(Vector velocity)
		{
			this.VelocityHistory[this.VelocityHistoryArrayPtr].Set(velocity.X, velocity.Y, velocity.Z);
			this.VelocityHistoryArrayPtr = (this.VelocityHistoryArrayPtr + 1) % this.VelocityHistory.Count;
		}

		// Token: 0x0602E207 RID: 188935 RVA: 0x00AA5CB0 File Offset: 0x00AA3EB0
		public double GetMaxVelocityDirection(Vector direction)
		{
			double num = 0.0;
			foreach (Vector vector in this.VelocityHistory)
			{
				num = Math.Max(num, vector.DotProduct(direction));
			}
			return num;
		}

		// Token: 0x0602E208 RID: 188936 RVA: 0x00AA5D18 File Offset: 0x00AA3F18
		public double GetMaxVelocity()
		{
			double num = 0.0;
			foreach (Vector vector in this.VelocityHistory)
			{
				num = Math.Max(num, vector.Size());
			}
			return num;
		}

		// Token: 0x04018BD5 RID: 101333
		protected List<Vector> VelocityHistory = new List<Vector>();

		// Token: 0x04018BD6 RID: 101334
		protected int VelocityHistoryArrayPtr;
	}
}
