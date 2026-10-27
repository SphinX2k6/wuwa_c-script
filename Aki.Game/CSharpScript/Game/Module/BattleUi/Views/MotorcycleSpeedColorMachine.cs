using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DA4 RID: 23972
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleSpeedColorMachine
	{
		// Token: 0x0603CDEB RID: 249323 RVA: 0x00E9F1BC File Offset: 0x00E9D3BC
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

		// Token: 0x0603CDEC RID: 249324 RVA: 0x00E9F23C File Offset: 0x00E9D43C
		private void UpdateColorByCurrentColor()
		{
			this.Color.R = (float)(this.CurrentColorValues[0] / 255.0);
			this.Color.G = (float)(this.CurrentColorValues[1] / 255.0);
			this.Color.B = (float)(this.CurrentColorValues[2] / 255.0);
			this.Color.A = (float)(this.CurrentColorValues[3] / 255.0);
		}

		// Token: 0x0603CDED RID: 249325 RVA: 0x00E9F2C4 File Offset: 0x00E9D4C4
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

		// Token: 0x0603CDEE RID: 249326 RVA: 0x00E9F310 File Offset: 0x00E9D510
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

		// Token: 0x0603CDEF RID: 249327 RVA: 0x00E9F374 File Offset: 0x00E9D574
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

		// Token: 0x0603CDF0 RID: 249328 RVA: 0x00E9F45E File Offset: 0x00E9D65E
		public FLinearColor GetColor()
		{
			return this.Color;
		}

		// Token: 0x0401FB4B RID: 129867
		private const int COLOR_NUM = 4;

		// Token: 0x0401FB4C RID: 129868
		private const int DURATION = 350;

		// Token: 0x0401FB4D RID: 129869
		private readonly double[] CurrentColorValues = new double[4];

		// Token: 0x0401FB4E RID: 129870
		private readonly double[] TargetColorValues = new double[4];

		// Token: 0x0401FB4F RID: 129871
		private readonly double[] Speed = new double[4];

		// Token: 0x0401FB50 RID: 129872
		private string TargetColor = string.Empty;

		// Token: 0x0401FB51 RID: 129873
		private FLinearColor Color;

		// Token: 0x0401FB52 RID: 129874
		private bool IsLerpFinish;

		// Token: 0x0401FB53 RID: 129875
		public int Duration = 350;
	}
}
