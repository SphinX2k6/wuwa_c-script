using System;

// Token: 0x020000F7 RID: 247
public class EasingLibrary
{
	// Token: 0x06000841 RID: 2113 RVA: 0x0002C2C7 File Offset: 0x0002A4C7
	public static double EaseInSine(float x)
	{
		return 1.0 - Math.Cos((double)x * 3.141592653589793 / 2.0);
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x0002C2EE File Offset: 0x0002A4EE
	public static double EaseOutSine(float x)
	{
		return Math.Sin((double)x * 3.141592653589793 / 2.0);
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x0002C30B File Offset: 0x0002A50B
	public static double EaseInOutSine(float x)
	{
		return -(Math.Cos(3.141592653589793 * (double)x) - 1.0) / 2.0;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x0002C333 File Offset: 0x0002A533
	public static float EaseInQuad(float x)
	{
		return x * x;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x0002C338 File Offset: 0x0002A538
	public static float EaseOutQuad(float x)
	{
		return 1f - (1f - x) * (1f - x);
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x0002C350 File Offset: 0x0002A550
	public static double EaseInOutQuad(float x)
	{
		if (x >= 0.5f)
		{
			return 1.0 - Math.Pow((double)(-2f * x + 2f), 2.0) / 2.0;
		}
		return (double)(2f * x * x);
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
	public static float EaseInCubic(float x)
	{
		return x * x * x;
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x0002C3A7 File Offset: 0x0002A5A7
	public static double EaseOutCubic(float x)
	{
		return 1.0 - Math.Pow((double)(1f - x), 3.0);
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x0002C3CC File Offset: 0x0002A5CC
	public static double EaseInOutCubic(float x)
	{
		if (x >= 0.5f)
		{
			return 1.0 - Math.Pow((double)(-2f * x + 2f), 3.0) / 2.0;
		}
		return (double)(4f * x * x * x);
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x0002C41E File Offset: 0x0002A61E
	public static float EaseInQuart(float x)
	{
		return x * x * x * x;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x0002C427 File Offset: 0x0002A627
	public static double EaseOutQuart(float x)
	{
		return 1.0 - Math.Pow((double)(1f - x), 4.0);
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x0002C44C File Offset: 0x0002A64C
	public static double EaseInOutQuart(float x)
	{
		if (x >= 0.5f)
		{
			return 1.0 - Math.Pow((double)(-2f * x + 2f), 4.0) / 2.0;
		}
		return (double)(8f * x * x * x * x);
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x0002C4A0 File Offset: 0x0002A6A0
	public static float EaseInQuint(float x)
	{
		return x * x * x * x * x;
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x0002C4AB File Offset: 0x0002A6AB
	public static double EaseOutQuint(float x)
	{
		return 1.0 - Math.Pow((double)(1f - x), 5.0);
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0002C4D0 File Offset: 0x0002A6D0
	public static double EaseInOutQuint(float x)
	{
		if (x >= 0.5f)
		{
			return 1.0 - Math.Pow((double)(-2f * x + 2f), 5.0) / 2.0;
		}
		return (double)(16f * x * x * x * x * x);
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x0002C526 File Offset: 0x0002A726
	public static double EaseInExpo(float x)
	{
		if (x != 0f)
		{
			return Math.Pow(2.0, (double)(10f * x - 10f));
		}
		return 0.0;
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x0002C556 File Offset: 0x0002A756
	public static double EaseOutExpo(float x)
	{
		if (x != 1f)
		{
			return 1.0 - Math.Pow(2.0, (double)(-10f * x));
		}
		return 1.0;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x0002C58C File Offset: 0x0002A78C
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

	// Token: 0x06000853 RID: 2131 RVA: 0x0002C61C File Offset: 0x0002A81C
	public static double EaseInCirc(float x)
	{
		return 1.0 - Math.Sqrt(1.0 - Math.Pow((double)x, 2.0));
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x0002C647 File Offset: 0x0002A847
	public static double EaseOutCirc(float x)
	{
		return Math.Sqrt(1.0 - Math.Pow((double)(x - 1f), 2.0));
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x0002C670 File Offset: 0x0002A870
	public static double EaseInOutCirc(float x)
	{
		if (x >= 0.5f)
		{
			return (Math.Sqrt(1.0 - Math.Pow((double)(-2f * x + 2f), 2.0)) + 1.0) / 2.0;
		}
		return (1.0 - Math.Sqrt(1.0 - Math.Pow((double)(2f * x), 2.0))) / 2.0;
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x0002C700 File Offset: 0x0002A900
	public static float EaseInBack(float x)
	{
		float num = 1.70158f;
		return (num + 1f) * x * x * x - num * x * x;
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x0002C728 File Offset: 0x0002A928
	public static double EaseOutBack(float x)
	{
		float num = 1.70158f;
		float num2 = num + 1f;
		return 1.0 + (double)num2 * Math.Pow((double)(x - 1f), 3.0) + (double)num * Math.Pow((double)(x - 1f), 2.0);
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x0002C780 File Offset: 0x0002A980
	public static double EaseInOutBack(float x)
	{
		float num = 1.70158f * 1.525f;
		if (x >= 0.5f)
		{
			return (Math.Pow((double)(2f * x - 2f), 2.0) * (double)((num + 1f) * (x * 2f - 2f) + num) + 2.0) / 2.0;
		}
		return Math.Pow((double)(2f * x), 2.0) * (double)((num + 1f) * 2f * x - num) / 2.0;
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0002C820 File Offset: 0x0002AA20
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

	// Token: 0x0600085A RID: 2138 RVA: 0x0002C890 File Offset: 0x0002AA90
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

	// Token: 0x0600085B RID: 2139 RVA: 0x0002C904 File Offset: 0x0002AB04
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

	// Token: 0x0600085C RID: 2140 RVA: 0x0002C9D1 File Offset: 0x0002ABD1
	public static float EaseInBounce(float x)
	{
		return 1f - EasingLibrary.EaseOutBounce(1f - x);
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
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

	// Token: 0x0600085E RID: 2142 RVA: 0x0002CA6C File Offset: 0x0002AC6C
	public static float EaseInOutBounce(float x)
	{
		if (x >= 0.5f)
		{
			return (1f + EasingLibrary.EaseOutBounce(2f * x - 1f)) / 2f;
		}
		return (1f - EasingLibrary.EaseOutBounce(1f - 2f * x)) / 2f;
	}
}
