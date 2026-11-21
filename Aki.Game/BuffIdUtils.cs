using System;
using System.Reflection;

// Token: 0x02002403 RID: 9219
public static class BuffIdUtils
{
	// Token: 0x06017154 RID: 94548 RVA: 0x006BF890 File Offset: 0x006BDA90
	public static bool CheckBuffInSpecialList(long checkBuffId)
	{
		if (Array.IndexOf<long>(SpecialIgnoreBuff.Values, checkBuffId) >= 0)
		{
			return true;
		}
		if (Array.IndexOf<long>(SpecialIgnoreGaBuff.Values, checkBuffId) >= 0)
		{
			return true;
		}
		if (NoBroadCastBuff.Values.Contains(checkBuffId))
		{
			return true;
		}
		if (Array.IndexOf<long>(new long[]
		{
			1900000014L,
			1900000015L,
			1900000017L
		}, checkBuffId) >= 0)
		{
			return true;
		}
		foreach (FieldInfo fieldInfo in typeof(BuffId).GetFields())
		{
			if (fieldInfo.IsLiteral && !fieldInfo.IsInitOnly && Convert.ToInt64(fieldInfo.GetValue(null)) == checkBuffId)
			{
				return true;
			}
		}
		return false;
	}
}
