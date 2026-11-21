using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200272E RID: 10030
	public static class ETuningStandGridTypeExtensions
	{
		// Token: 0x0600D7A9 RID: 55209 RVA: 0x001F8168 File Offset: 0x001F6368
		public static string ToEnumString(this ETuningStandGridType value)
		{
			string result;
			switch (value)
			{
			case ETuningStandGridType.Empty:
				result = "Empty";
				break;
			case ETuningStandGridType.Start1:
				result = "Start1";
				break;
			case ETuningStandGridType.End1:
				result = "End1";
				break;
			case ETuningStandGridType.Start2:
				result = "Start2";
				break;
			case ETuningStandGridType.End2:
				result = "End2";
				break;
			case ETuningStandGridType.Number1:
				result = "Number1";
				break;
			case ETuningStandGridType.Number2:
				result = "Number2";
				break;
			case ETuningStandGridType.Number3:
				result = "Number3";
				break;
			case ETuningStandGridType.Number4:
				result = "Number4";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D7AA RID: 55210 RVA: 0x001F81F8 File Offset: 0x001F63F8
		public static ETuningStandGridType FromString(string name)
		{
			ETuningStandGridType result;
			if (!ETuningStandGridTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETuningStandGridType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7AB RID: 55211 RVA: 0x001F8224 File Offset: 0x001F6424
		public static bool TryFromString(string name, out ETuningStandGridType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETuningStandGridType.Empty;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
				{
					char c = name[3];
					if (c != '1')
					{
						if (c == '2')
						{
							if (name == "End2")
							{
								value = ETuningStandGridType.End2;
								return true;
							}
						}
					}
					else if (name == "End1")
					{
						value = ETuningStandGridType.End1;
						return true;
					}
					break;
				}
				case 5:
					if (name == "Empty")
					{
						value = ETuningStandGridType.Empty;
						return true;
					}
					break;
				case 6:
				{
					char c = name[5];
					if (c != '1')
					{
						if (c == '2')
						{
							if (name == "Start2")
							{
								value = ETuningStandGridType.Start2;
								return true;
							}
						}
					}
					else if (name == "Start1")
					{
						value = ETuningStandGridType.Start1;
						return true;
					}
					break;
				}
				case 7:
					switch (name[6])
					{
					case '1':
						if (name == "Number1")
						{
							value = ETuningStandGridType.Number1;
							return true;
						}
						break;
					case '2':
						if (name == "Number2")
						{
							value = ETuningStandGridType.Number2;
							return true;
						}
						break;
					case '3':
						if (name == "Number3")
						{
							value = ETuningStandGridType.Number3;
							return true;
						}
						break;
					case '4':
						if (name == "Number4")
						{
							value = ETuningStandGridType.Number4;
							return true;
						}
						break;
					}
					break;
				}
			}
			value = ETuningStandGridType.Empty;
			return false;
		}

		// Token: 0x0600D7AC RID: 55212 RVA: 0x001F8380 File Offset: 0x001F6580
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Empty",
				"Start1",
				"End1",
				"Start2",
				"End2",
				"Number1",
				"Number2",
				"Number3",
				"Number4"
			};
		}

		// Token: 0x0600D7AD RID: 55213 RVA: 0x001F83DC File Offset: 0x001F65DC
		public static ETuningStandGridType[] GetValues()
		{
			return new ETuningStandGridType[]
			{
				ETuningStandGridType.Empty,
				ETuningStandGridType.Start1,
				ETuningStandGridType.End1,
				ETuningStandGridType.Start2,
				ETuningStandGridType.End2,
				ETuningStandGridType.Number1,
				ETuningStandGridType.Number2,
				ETuningStandGridType.Number3,
				ETuningStandGridType.Number4
			};
		}

		// Token: 0x0600D7AE RID: 55214 RVA: 0x001F83F0 File Offset: 0x001F65F0
		public static string[] GetNames()
		{
			return new string[]
			{
				"Empty",
				"Start1",
				"End1",
				"Start2",
				"End2",
				"Number1",
				"Number2",
				"Number3",
				"Number4"
			};
		}
	}
}
