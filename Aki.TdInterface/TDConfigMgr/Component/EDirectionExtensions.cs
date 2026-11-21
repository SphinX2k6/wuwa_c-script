using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CF RID: 2511
	public static class EDirectionExtensions
	{
		// Token: 0x06003836 RID: 14390 RVA: 0x00091C94 File Offset: 0x0008FE94
		public static string ToEnumString(this EDirection value)
		{
			string result;
			if (value != EDirection.Right)
			{
				if (value != EDirection.Left)
				{
					result = value.ToString();
				}
				else
				{
					result = "Left";
				}
			}
			else
			{
				result = "Right";
			}
			return result;
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00091CCC File Offset: 0x0008FECC
		public static EDirection FromString(string name)
		{
			EDirection result;
			if (!EDirectionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDirection 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00091CF5 File Offset: 0x0008FEF5
		public static bool TryFromString(string name, out EDirection value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDirection.Right;
				return false;
			}
			if (name == "Right")
			{
				value = EDirection.Right;
				return true;
			}
			if (!(name == "Left"))
			{
				value = EDirection.Right;
				return false;
			}
			value = EDirection.Left;
			return true;
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00091D2E File Offset: 0x0008FF2E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Right",
				"Left"
			};
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00091D46 File Offset: 0x0008FF46
		public static EDirection[] GetValues()
		{
			return new EDirection[]
			{
				EDirection.Right,
				EDirection.Left
			};
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00091D52 File Offset: 0x0008FF52
		public static string[] GetNames()
		{
			return new string[]
			{
				"Right",
				"Left"
			};
		}
	}
}
