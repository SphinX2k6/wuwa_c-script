using System;

// Token: 0x020000F7 RID: 247
public class EasingLibrary
{
	// Token: 0x060007FB RID: 2043 RVA: 0x0002BAD3 File Offset: 0x00029CD3
	public static double EaseInSine(float x)
	{
		return 1.0 - Math.Cos((double)x * 3.141592653589793 / 2.0);
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x0002BAFA File Offset: 0x00029CFA
	public static double EaseOutSine(float x)
	{
		return Math.Sin((double)x * 3.141592653589793 / 2.0);
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x0002BB17 File Offset: 0x00029D17
	public static double EaseInOutSine(float x)
	{
		return -(Math.Cos(3.141592653589793 * (double)x) - 1.0) / 2.0;
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x0002BB3F File Offset: 0x00029D3F
	public static float EaseInQuad(float x)
	{
		return x * x;
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x0002BB44 File Offset: 0x00029D44
	public static float EaseOutQuad(float x)
	{
		return 1f - (1f - x) * (1f - x);
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x0002BB5C File Offset: 0x00029D5C
	public static double EaseInOutQuad(float x)
	{
		if (x >= 0.5f)
		{
			return 1.0 - Math.Pow((double)(-2f * x + 2f), 2.0) / 2.0;
		}
		return (double)(2f * x * x);
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x0002BBAC File Offset: 0x00029DAC
	public static float EaseInCubic(float x)
	{
		return x * x * x;
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x0002BBB3 File Offset: 0x00029DB3
	public static double EaseOutCubic(float x)
	{
		return 1.0 - Math.Pow((double)(1f - x), 3.0);
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x0002BBD8 File Offset: 0x00029DD8
	public static double EaseInOutCubic(float x)
	{
		if (x >= 0.5f)
		{
			return 1.0 - Math.Pow((double)(-2f * x + 2f), 3.0) / 2.0;
		}
		return (double)(4f * x * x * x);
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x0002BC2A File Offset: 0x00029E2A
	public static float EaseInQuart(float x)
	{
		return x * x * x * x;
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x0002BC33 File Offset: 0x00029E33
	public static double EaseOutQuart(float x)
	{
		return 1.0 - Math.Pow((double)(1f - x), 4.0);
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x0002BC58 File Offset: 0x00029E58
	public static double EaseInOutQuart(float x)
	{
		if (x >= 0.5f)
		{
			return 1.0 - Math.Pow((double)(-2f * x + 2f), 4.0) / 2.0;
		}
		return (double)(8f * x * x * x * x);
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x0002BCAC File Offset: 0x00029EAC
	public static float EaseInQuint(float x)
	{
		return x * x * x * x * x;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x0002BCB7 File Offset: 0x00029EB7
	public static double EaseOutQuint(float x)
	{
		return 1.0 - Math.Pow((double)(1f - x), 5.0);
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0002BCDC File Offset: 0x00029EDC
	public static double EaseInOutQuint(float x)
	{
		if (x >= 0.5f)
		{
			return 1.0 - Math.Pow((double)(-2f * x + 2f), 5.0) / 2.0;
		}
		return (double)(16f * x * x * x * x * x);
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0002BD32 File Offset: 0x00029F32
	public static double EaseInExpo(float x)
	{
		if (x != 0f)
		{
			return Math.Pow(2.0, (double)(10f * x - 10f));
		}
		return 0.0;
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x0002BD62 File Offset: 0x00029F62
	public static double EaseOutExpo(float x)
	{
		if (x != 1f)
		{
			return 1.0 - Math.Pow(2.0, (double)(-10f * x));
		}
		return 1.0;
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x0002BD98 File Offset: 0x00029F98
	public static double EaseInOutExpo(float x)
	{
		if (x == 0f)
		{
			return 0.0;
		}
		if (x == 1f)
		{
			return 1.0;
		}
		if (x >= 0.5f)
		{
			return (2.0 - Math.Pow(2.0, (double)(-20f * x + 10f))) / 2.0;
		}
		return Math.Pow(2.0, (double)(20f * x - 10f)) / 2.0;
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x0002BE28 File Offset: 0x0002A028
	public static double EaseInCirc(float x)
	{
		return 1.0 - Math.Sqrt(1.0 - Math.Pow((double)x, 2.0));
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0002BE53 File Offset: 0x0002A053
	public static double EaseOutCirc(float x)
	{
		return Math.Sqrt(1.0 - Math.Pow((double)(x - 1f), 2.0));
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x0002BE7C File Offset: 0x0002A07C
	public static double EaseInOutCirc(float x)
	{
		if (x >= 0.5f)
		{
			return (Math.Sqrt(1.0 - Math.Pow((double)(-2f * x + 2f), 2.0)) + 1.0) / 2.0;
		}
		return (1.0 - Math.Sqrt(1.0 - Math.Pow((double)(2f * x), 2.0))) / 2.0;
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x0002BF0C File Offset: 0x0002A10C
	public static float EaseInBack(float x)
	{
		float num = 1.70158f;
		return (num + 1f) * x * x * x - num * x * x;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x0002BF34 File Offset: 0x0002A134
	public static double EaseOutBack(float x)
	{
		float num = 1.70158f;
		float num2 = num + 1f;
		return 1.0 + (double)num2 * Math.Pow((double)(x - 1f), 3.0) + (double)num * Math.Pow((double)(x - 1f), 2.0);
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x0002BF8C File Offset: 0x0002A18C
	public static double EaseInOutBack(float x)
	{
		float num = 1.70158f * 1.525f;
		if (x >= 0.5f)
		{
			return (Math.Pow((double)(2f * x - 2f), 2.0) * (double)((num + 1f) * (x * 2f - 2f) + num) + 2.0) / 2.0;
		}
		return Math.Pow((double)(2f * x), 2.0) * (double)((num + 1f) * 2f * x - num) / 2.0;
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x0002C02C File Offset: 0x0002A22C
	public static double EaseInElastic(float x)
	{
		double num = 2.0943951023931953;
		if (x == 0f)
		{
			return 0.0;
		}
		if (x != 1f)
		{
			return -Math.Pow(2.0, (double)(10f * x - 10f)) * Math.Sin((double)(x * 10f - 10.75f) * num);
		}
		return 1.0;
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0002C09C File Offset: 0x0002A29C
	public static double EaseOutElastic(float x)
	{
		double num = 2.0943951023931953;
		if (x == 0f)
		{
			return 0.0;
		}
		if (x != 1f)
		{
			return Math.Pow(2.0, (double)(-10f * x)) * Math.Sin((double)(x * 10f - 0.75f) * num) + 1.0;
		}
		return 1.0;
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0002C110 File Offset: 0x0002A310
	public static double EaseInOutElastic(float x)
	{
		double num = 1.3962634015954636;
		if (x == 0f)
		{
			return 0.0;
		}
		if (x == 1f)
		{
			return 1.0;
		}
		if (x >= 0.5f)
		{
			return Math.Pow(2.0, (double)(-20f * x + 10f)) * Math.Sin((double)(20f * x - 11.125f) * num) / 2.0 + 1.0;
		}
		return -(Math.Pow(2.0, (double)(20f * x - 10f)) * Math.Sin((double)(20f * x - 11.125f) * num)) / 2.0;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0002C1DD File Offset: 0x0002A3DD
	public static float EaseInBounce(float x)
	{
		return 1f - EasingLibrary.EaseOutBounce(1f - x);
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x0002C1F4 File Offset: 0x0002A3F4
	public static float EaseOutBounce(float x)
	{
		float num = 7.5625f;
		float num2 = 2.75f;
		if (x < 1f / num2)
		{
			return num * x * x;
		}
		if (x < 2f / num2)
		{
			float num3 = x - 1.5f / num2;
			return num * num3 * num3 + 0.75f;
		}
		if (x < 2.5f / num2)
		{
			float num4 = x - 2.25f / num2;
			return num * num4 * num4 + 0.9375f;
		}
		float num5 = x - 2.625f / num2;
		return num * num5 * num5 + 0.984375f;
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x0002C278 File Offset: 0x0002A478
	public static float EaseInOutBounce(float x)
	{
		if (x >= 0.5f)
		{
			return (1f + EasingLibrary.EaseOutBounce(2f * x - 1f)) / 2f;
		}
		return (1f - EasingLibrary.EaseOutBounce(1f - 2f * x)) / 2f;
	}
}
