using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002594 RID: 9620
	public static class EEntityDecorationTypeExtensions
	{
		// Token: 0x0600D074 RID: 53364 RVA: 0x001E3194 File Offset: 0x001E1394
		public static string ToEnumString(this EEntityDecorationType value)
		{
			string result;
			if (value != EEntityDecorationType.Add)
			{
				if (value != EEntityDecorationType.Remove)
				{
					result = value.ToString();
				}
				else
				{
					result = "Remove";
				}
			}
			else
			{
				result = "Add";
			}
			return result;
		}

		// Token: 0x0600D075 RID: 53365 RVA: 0x001E31CC File Offset: 0x001E13CC
		public static EEntityDecorationType FromString(string name)
		{
			EEntityDecorationType result;
			if (!EEntityDecorationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityDecorationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D076 RID: 53366 RVA: 0x001E31F5 File Offset: 0x001E13F5
		public static bool TryFromString(string name, out EEntityDecorationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEntityDecorationType.Add;
				return false;
			}
			if (name == "Add")
			{
				value = EEntityDecorationType.Add;
				return true;
			}
			if (!(name == "Remove"))
			{
				value = EEntityDecorationType.Add;
				return false;
			}
			value = EEntityDecorationType.Remove;
			return true;
		}

		// Token: 0x0600D077 RID: 53367 RVA: 0x001E322E File Offset: 0x001E142E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Add",
				"Remove"
			};
		}

		// Token: 0x0600D078 RID: 53368 RVA: 0x001E3246 File Offset: 0x001E1446
		public static EEntityDecorationType[] GetValues()
		{
			return new EEntityDecorationType[]
			{
				EEntityDecorationType.Add,
				EEntityDecorationType.Remove
			};
		}

		// Token: 0x0600D079 RID: 53369 RVA: 0x001E3252 File Offset: 0x001E1452
		public static string[] GetNames()
		{
			return new string[]
			{
				"Add",
				"Remove"
			};
		}
	}
}
