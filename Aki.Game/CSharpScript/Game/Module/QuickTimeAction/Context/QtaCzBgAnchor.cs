using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02003F12 RID: 16146
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCzBgAnchor
	{
		// Token: 0x06028F15 RID: 167701 RVA: 0x00B7DDE8 File Offset: 0x00B7BFE8
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

		// Token: 0x06028F16 RID: 167702 RVA: 0x00B7DEEC File Offset: 0x00B7C0EC
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

		// Token: 0x04016419 RID: 91161
		private List<float> Segments = new List<float>();

		// Token: 0x0401641A RID: 91162
		private float BgPctMax;

		// Token: 0x0401641B RID: 91163
		private readonly float BgOffset = 0.25f;

		// Token: 0x0401641C RID: 91164
		private float AngleOffset;

		// Token: 0x0401641D RID: 91165
		private float AngleScale = 1f;
	}
}
