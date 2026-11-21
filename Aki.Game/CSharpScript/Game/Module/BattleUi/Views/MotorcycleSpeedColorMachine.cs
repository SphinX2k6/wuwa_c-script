using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D86 RID: 19846
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleSpeedColorMachine
	{
		// Token: 0x06031D48 RID: 204104 RVA: 0x00DEFA74 File Offset: 0x00DEDC74
		public void Init(string color, int? duration = null)
		{
			this.TargetColor = color;
			this.ParseColorValues(color, this.TargetColorValues);
			for (int i = 0; i < 4; i++)
			{
				this.CurrentColorValues[i] = this.TargetColorValues[i];
			}
			if (duration != null)
			{
				this.Duration = duration.Value;
				for (int j = 0; j < 4; j++)
				{
					this.Speed[j] = 0.0;
				}
			}
			this.IsLerpFinish = true;
			this.UpdateColorByCurrentColor();
		}

		// Token: 0x06031D49 RID: 204105 RVA: 0x00DEFAF4 File Offset: 0x00DEDCF4
		private void UpdateColorByCurrentColor()
		{
			this.Color.R = (float)(this.CurrentColorValues[0] / 255.0);
			this.Color.G = (float)(this.CurrentColorValues[1] / 255.0);
			this.Color.B = (float)(this.CurrentColorValues[2] / 255.0);
			this.Color.A = (float)(this.CurrentColorValues[3] / 255.0);
		}

		// Token: 0x06031D4A RID: 204106 RVA: 0x00DEFB7C File Offset: 0x00DEDD7C
		private void ParseColorValues(string color, double[] outValues)
		{
			for (int i = 0; i < 4; i++)
			{
				int num = i * 2;
				if (num + 2 <= color.Length)
				{
					outValues[i] = (double)int.Parse(color.Substring(num, 2), NumberStyles.HexNumber);
				}
				else
				{
					outValues[i] = 255.0;
				}
			}
		}

		// Token: 0x06031D4B RID: 204107 RVA: 0x00DEFBC8 File Offset: 0x00DEDDC8
		public void SetTargetColor(string color)
		{
			if (color == this.TargetColor)
			{
				return;
			}
			this.TargetColor = color;
			this.ParseColorValues(color, this.TargetColorValues);
			for (int i = 0; i < 4; i++)
			{
				this.Speed[i] = (this.TargetColorValues[i] - this.CurrentColorValues[i]) / (double)this.Duration;
			}
			this.IsLerpFinish = false;
		}

		// Token: 0x06031D4C RID: 204108 RVA: 0x00DEFC2C File Offset: 0x00DEDE2C
		public bool Update(double delta)
		{
			if (this.IsLerpFinish)
			{
				return false;
			}
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				double num2 = this.Speed[i];
				if (num2 == 0.0)
				{
					num++;
				}
				else
				{
					this.CurrentColorValues[i] += num2 * delta;
					if (num2 > 0.0)
					{
						if (this.CurrentColorValues[i] >= this.TargetColorValues[i])
						{
							this.CurrentColorValues[i] = this.TargetColorValues[i];
							this.Speed[i] = 0.0;
							num++;
						}
					}
					else if (this.CurrentColorValues[i] <= this.TargetColorValues[i])
					{
						this.CurrentColorValues[i] = this.TargetColorValues[i];
						this.Speed[i] = 0.0;
						num++;
					}
				}
			}
			this.UpdateColorByCurrentColor();
			if (num == 4)
			{
				this.IsLerpFinish = true;
			}
			return true;
		}

		// Token: 0x06031D4D RID: 204109 RVA: 0x00DEFD16 File Offset: 0x00DEDF16
		public FLinearColor GetColor()
		{
			return this.Color;
		}

		// Token: 0x0401A603 RID: 108035
		private const int COLOR_NUM = 4;

		// Token: 0x0401A604 RID: 108036
		private const int DURATION = 350;

		// Token: 0x0401A605 RID: 108037
		private readonly double[] CurrentColorValues = new double[4];

		// Token: 0x0401A606 RID: 108038
		private readonly double[] TargetColorValues = new double[4];

		// Token: 0x0401A607 RID: 108039
		private readonly double[] Speed = new double[4];

		// Token: 0x0401A608 RID: 108040
		private string TargetColor = string.Empty;

		// Token: 0x0401A609 RID: 108041
		private FLinearColor Color;

		// Token: 0x0401A60A RID: 108042
		private bool IsLerpFinish;

		// Token: 0x0401A60B RID: 108043
		public int Duration = 350;
	}
}
