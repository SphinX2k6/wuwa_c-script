using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02004F49 RID: 20297
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCzBgAnchor
	{
		// Token: 0x060340A7 RID: 213159 RVA: 0x00C34648 File Offset: 0x00C32848
		public void InitParam(QtaCzBgBarValue bgValue, float angleScale = 1f)
		{
			List<float> list = new List<float>
			{
				bgValue.Anchor.Value.R,
				bgValue.Anchor.Value.G,
				bgValue.Anchor.Value.B,
				bgValue.Anchor.Value.A
			};
			float num = 0f;
			for (int i = 0; i < list.Count - 1; i++)
			{
				num = Math.Max(Math.Abs(list[i] - list[i + 1]) * 0.5f, num);
			}
			num = Math.Max(list[0] * 0.5f, num);
			num = Math.Max((1f - list[list.Count - 1]) * 0.5f, num);
			this.BgPctMax = num;
			this.Segments = list;
			this.AngleOffset = bgValue.Angle % 360f;
			this.AngleScale = angleScale;
		}

		// Token: 0x060340A8 RID: 213160 RVA: 0x00C3474C File Offset: 0x00C3294C
		public bool CheckIsValid(float mainPct, float bgPct)
		{
			if (bgPct >= 1f)
			{
				return true;
			}
			float num = mainPct - this.AngleOffset * this.AngleScale;
			foreach (float num2 in this.Segments)
			{
				float num3 = num2 - this.BgPctMax * bgPct;
				float num4 = num2 + this.BgPctMax * bgPct;
				num3 = (num3 + this.BgOffset) % 1f;
				num4 = (num4 + this.BgOffset) % 1f;
				if ((num3 <= num && num <= num4) || (num4 < num3 && (num >= num3 || num <= num4)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0401BA44 RID: 113220
		private List<float> Segments = new List<float>();

		// Token: 0x0401BA45 RID: 113221
		private float BgPctMax;

		// Token: 0x0401BA46 RID: 113222
		private readonly float BgOffset = 0.25f;

		// Token: 0x0401BA47 RID: 113223
		private float AngleOffset;

		// Token: 0x0401BA48 RID: 113224
		private float AngleScale = 1f;
	}
}
