using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// Token: 0x02002EB0 RID: 11952
public static class BuffIdUtils
{
	// Token: 0x0601986E RID: 104558 RVA: 0x0069958C File Offset: 0x0069778C
	public static bool CheckBuffInSpecialList(long checkBuffId)
	{
		if (SpecialIgnoreBuff.Values.Contains(checkBuffId))
		{
			return true;
		}
		if (SpecialIgnoreGaBuff.Values.Contains(checkBuffId))
		{
			return true;
		}
		if (NoBroadCastBuff.Values.Contains(checkBuffId))
		{
			return true;
		}
		if (new long[]
		{
			1900000014L,
			1900000015L,
			1900000017L
		}.Contains(checkBuffId))
		{
			return true;
		}
		using (IEnumerator<long> enumerator = (from f in typeof(BuffId).GetFields()
		where f.IsLiteral && !f.IsInitOnly
		select Convert.ToInt64(f.GetValue(null))).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == checkBuffId)
				{
					return true;
				}
			}
		}
		return false;
	}
}
