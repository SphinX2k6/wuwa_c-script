using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB3 RID: 2739
	public static class ERefreshContentExtensions
	{
		// Token: 0x06003C38 RID: 15416 RVA: 0x0009A8D0 File Offset: 0x00098AD0
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

		// Token: 0x06003C39 RID: 15417 RVA: 0x0009A908 File Offset: 0x00098B08
		public static ERefreshContent FromString(string name)
		{
			ERefreshContent result;
			if (!ERefreshContentExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERefreshContent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x0009A931 File Offset: 0x00098B31
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

		// Token: 0x06003C3B RID: 15419 RVA: 0x0009A96A File Offset: 0x00098B6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"All",
				"RandomEntity"
			};
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x0009A982 File Offset: 0x00098B82
		public static ERefreshContent[] GetValues()
		{
			return new ERefreshContent[]
			{
				ERefreshContent.All,
				ERefreshContent.RandomEntity
			};
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x0009A98E File Offset: 0x00098B8E
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
