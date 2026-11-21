using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E6 RID: 9702
	public static class ELimitPlayOperationExtensions
	{
		// Token: 0x0600D1E5 RID: 53733 RVA: 0x001E8360 File Offset: 0x001E6560
		public static string ToEnumString(this ELimitPlayOperation value)
		{
			string result;
			switch (value)
			{
			case ELimitPlayOperation.AllowCamera:
				result = "AllowCamera";
				break;
			case ELimitPlayOperation.AllowAction:
				result = "AllowAction";
				break;
			case ELimitPlayOperation.AllowMove:
				result = "AllowMove";
				break;
			case ELimitPlayOperation.AllowMoveNew:
				result = "AllowMoveNew";
				break;
			case ELimitPlayOperation.AllowUi:
				result = "AllowUi";
				break;
			case ELimitPlayOperation.AllowMouse:
				result = "AllowMouse";
				break;
			case ELimitPlayOperation.BlockAll:
				result = "BlockAll";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D1E6 RID: 53734 RVA: 0x001E83D8 File Offset: 0x001E65D8
		public static ELimitPlayOperation FromString(string name)
		{
			ELimitPlayOperation result;
			if (!ELimitPlayOperationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELimitPlayOperation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1E7 RID: 53735 RVA: 0x001E8404 File Offset: 0x001E6604
		public static bool TryFromString(string name, out ELimitPlayOperation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELimitPlayOperation.AllowCamera;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 7:
					if (name == "AllowUi")
					{
						value = ELimitPlayOperation.AllowUi;
						return true;
					}
					break;
				case 8:
					if (name == "BlockAll")
					{
						value = ELimitPlayOperation.BlockAll;
						return true;
					}
					break;
				case 9:
					if (name == "AllowMove")
					{
						value = ELimitPlayOperation.AllowMove;
						return true;
					}
					break;
				case 10:
					if (name == "AllowMouse")
					{
						value = ELimitPlayOperation.AllowMouse;
						return true;
					}
					break;
				case 11:
				{
					char c = name[5];
					if (c != 'A')
					{
						if (c == 'C')
						{
							if (name == "AllowCamera")
							{
								value = ELimitPlayOperation.AllowCamera;
								return true;
							}
						}
					}
					else if (name == "AllowAction")
					{
						value = ELimitPlayOperation.AllowAction;
						return true;
					}
					break;
				}
				case 12:
					if (name == "AllowMoveNew")
					{
						value = ELimitPlayOperation.AllowMoveNew;
						return true;
					}
					break;
				}
			}
			value = ELimitPlayOperation.AllowCamera;
			return false;
		}

		// Token: 0x0600D1E8 RID: 53736 RVA: 0x001E84F5 File Offset: 0x001E66F5
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AllowCamera",
				"AllowAction",
				"AllowMove",
				"AllowMoveNew",
				"AllowUi",
				"AllowMouse",
				"BlockAll"
			};
		}

		// Token: 0x0600D1E9 RID: 53737 RVA: 0x001E8535 File Offset: 0x001E6735
		public static ELimitPlayOperation[] GetValues()
		{
			return new ELimitPlayOperation[]
			{
				ELimitPlayOperation.AllowCamera,
				ELimitPlayOperation.AllowAction,
				ELimitPlayOperation.AllowMove,
				ELimitPlayOperation.AllowMoveNew,
				ELimitPlayOperation.AllowUi,
				ELimitPlayOperation.AllowMouse,
				ELimitPlayOperation.BlockAll
			};
		}

		// Token: 0x0600D1EA RID: 53738 RVA: 0x001E8548 File Offset: 0x001E6748
		public static string[] GetNames()
		{
			return new string[]
			{
				"AllowCamera",
				"AllowAction",
				"AllowMove",
				"AllowMoveNew",
				"AllowUi",
				"AllowMouse",
				"BlockAll"
			};
		}
	}
}
