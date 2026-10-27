using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000922 RID: 2338
	public static class EDirectionExtensions
	{
		// Token: 0x060034CA RID: 13514 RVA: 0x0008A114 File Offset: 0x00088314
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

		// Token: 0x060034CB RID: 13515 RVA: 0x0008A14C File Offset: 0x0008834C
		public static EDirection FromString(string name)
		{
			EDirection result;
			if (!EDirectionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDirection 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x0008A175 File Offset: 0x00088375
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

		// Token: 0x060034CD RID: 13517 RVA: 0x0008A1AE File Offset: 0x000883AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Right",
				"Left"
			};
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x0008A1C6 File Offset: 0x000883C6
		public static EDirection[] GetValues()
		{
			return new EDirection[]
			{
				EDirection.Right,
				EDirection.Left
			};
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x0008A1D2 File Offset: 0x000883D2
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
