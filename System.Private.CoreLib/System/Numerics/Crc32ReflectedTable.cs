using System;

namespace System.Numerics
{
	// Token: 0x0200029C RID: 668
	internal static class Crc32ReflectedTable
	{
		// Token: 0x060032BD RID: 12989 RVA: 0x000A2BA8 File Offset: 0x000A0DA8
		internal static uint[] Generate(uint reflectedPolynomial)
		{
			uint[] array = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 0U)
					{
						num >>= 1;
					}
					else
					{
						num = (num >> 1 ^ reflectedPolynomial);
					}
				}
				array[i] = num;
			}
			return array;
		}
	}
}
