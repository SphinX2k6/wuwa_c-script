using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EE RID: 2542
	public static class ERefreshContentExtensions
	{
		// Token: 0x06003860 RID: 14432 RVA: 0x00092010 File Offset: 0x00090210
		public static string ToEnumString(this ERefreshContent value)
		{
			string result;
			if (value != ERefreshContent.All)
			{
				if (value != ERefreshContent.RandomEntity)
				{
					result = value.ToString();
				}
				else
				{
					result = "RandomEntity";
				}
			}
			else
			{
				result = "All";
			}
			return result;
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00092048 File Offset: 0x00090248
		public static ERefreshContent FromString(string name)
		{
			ERefreshContent result;
			if (!ERefreshContentExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERefreshContent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x00092071 File Offset: 0x00090271
		public static bool TryFromString(string name, out ERefreshContent value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERefreshContent.All;
				return false;
			}
			if (name == "All")
			{
				value = ERefreshContent.All;
				return true;
			}
			if (!(name == "RandomEntity"))
			{
				value = ERefreshContent.All;
				return false;
			}
			value = ERefreshContent.RandomEntity;
			return true;
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x000920AA File Offset: 0x000902AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"All",
				"RandomEntity"
			};
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x000920C2 File Offset: 0x000902C2
		public static ERefreshContent[] GetValues()
		{
			return new ERefreshContent[]
			{
				ERefreshContent.All,
				ERefreshContent.RandomEntity
			};
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x000920CE File Offset: 0x000902CE
		public static string[] GetNames()
		{
			return new string[]
			{
				"All",
				"RandomEntity"
			};
		}
	}
}
