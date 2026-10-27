using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248B RID: 9355
	public static class ETuningStandGridTypeExtensions
	{
		// Token: 0x0600CAF0 RID: 51952 RVA: 0x001DDFA0 File Offset: 0x001DC1A0
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

		// Token: 0x0600CAF1 RID: 51953 RVA: 0x001DE030 File Offset: 0x001DC230
		public static ETuningStandGridType FromString(string name)
		{
			ETuningStandGridType result;
			if (!ETuningStandGridTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETuningStandGridType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAF2 RID: 51954 RVA: 0x001DE05C File Offset: 0x001DC25C
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

		// Token: 0x0600CAF3 RID: 51955 RVA: 0x001DE1B8 File Offset: 0x001DC3B8
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

		// Token: 0x0600CAF4 RID: 51956 RVA: 0x001DE214 File Offset: 0x001DC414
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

		// Token: 0x0600CAF5 RID: 51957 RVA: 0x001DE228 File Offset: 0x001DC428
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
