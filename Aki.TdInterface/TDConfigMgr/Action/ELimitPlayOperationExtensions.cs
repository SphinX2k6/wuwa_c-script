using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002371 RID: 9073
	public static class ELimitPlayOperationExtensions
	{
		// Token: 0x0600C5FB RID: 50683 RVA: 0x001D0080 File Offset: 0x001CE280
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

		// Token: 0x0600C5FC RID: 50684 RVA: 0x001D00F8 File Offset: 0x001CE2F8
		public static ELimitPlayOperation FromString(string name)
		{
			ELimitPlayOperation result;
			if (!ELimitPlayOperationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELimitPlayOperation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x001D0124 File Offset: 0x001CE324
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

		// Token: 0x0600C5FE RID: 50686 RVA: 0x001D0215 File Offset: 0x001CE415
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

		// Token: 0x0600C5FF RID: 50687 RVA: 0x001D0255 File Offset: 0x001CE455
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

		// Token: 0x0600C600 RID: 50688 RVA: 0x001D0268 File Offset: 0x001CE468
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
