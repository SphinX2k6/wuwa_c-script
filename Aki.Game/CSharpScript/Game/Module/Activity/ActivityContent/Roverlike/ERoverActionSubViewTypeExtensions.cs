using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005128 RID: 20776
	public static class ERoverActionSubViewTypeExtensions
	{
		// Token: 0x06033F13 RID: 212755 RVA: 0x00E8808C File Offset: 0x00E8628C
		public static string ToEnumString(this ERoverActionSubViewType value)
		{
			string result;
			switch (value)
			{
			case ERoverActionSubViewType.None:
				result = "None";
				break;
			case ERoverActionSubViewType.BlessingSuitPreview:
				result = "BlessingSuitPreview";
				break;
			case ERoverActionSubViewType.BlessingSuitSelect:
				result = "BlessingSuitSelect";
				break;
			case ERoverActionSubViewType.SelectBlessing:
				result = "SelectBlessing";
				break;
			case ERoverActionSubViewType.SelectReinforcement:
				result = "SelectReinforcement";
				break;
			case ERoverActionSubViewType.SelectEvent:
				result = "SelectEvent";
				break;
			case ERoverActionSubViewType.BlessingReinforcement:
				result = "BlessingReinforcement";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06033F14 RID: 212756 RVA: 0x00E88104 File Offset: 0x00E86304
		public static ERoverActionSubViewType FromString(string name)
		{
			ERoverActionSubViewType result;
			if (!ERoverActionSubViewTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoverActionSubViewType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06033F15 RID: 212757 RVA: 0x00E88130 File Offset: 0x00E86330
		public static bool TryFromString(string name, out ERoverActionSubViewType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoverActionSubViewType.None;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length <= 11)
				{
					if (length != 4)
					{
						if (length == 11)
						{
							if (name == "SelectEvent")
							{
								value = ERoverActionSubViewType.SelectEvent;
								return true;
							}
						}
					}
					else if (name == "None")
					{
						value = ERoverActionSubViewType.None;
						return true;
					}
				}
				else if (length != 14)
				{
					switch (length)
					{
					case 18:
						if (name == "BlessingSuitSelect")
						{
							value = ERoverActionSubViewType.BlessingSuitSelect;
							return true;
						}
						break;
					case 19:
					{
						char c = name[0];
						if (c != 'B')
						{
							if (c == 'S')
							{
								if (name == "SelectReinforcement")
								{
									value = ERoverActionSubViewType.SelectReinforcement;
									return true;
								}
							}
						}
						else if (name == "BlessingSuitPreview")
						{
							value = ERoverActionSubViewType.BlessingSuitPreview;
							return true;
						}
						break;
					}
					case 21:
						if (name == "BlessingReinforcement")
						{
							value = ERoverActionSubViewType.BlessingReinforcement;
							return true;
						}
						break;
					}
				}
				else if (name == "SelectBlessing")
				{
					value = ERoverActionSubViewType.SelectBlessing;
					return true;
				}
			}
			value = ERoverActionSubViewType.None;
			return false;
		}

		// Token: 0x06033F16 RID: 212758 RVA: 0x00E88237 File Offset: 0x00E86437
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"None",
				"BlessingSuitPreview",
				"BlessingSuitSelect",
				"SelectBlessing",
				"SelectReinforcement",
				"SelectEvent",
				"BlessingReinforcement"
			};
		}

		// Token: 0x06033F17 RID: 212759 RVA: 0x00E88277 File Offset: 0x00E86477
		public static ERoverActionSubViewType[] GetValues()
		{
			return new ERoverActionSubViewType[]
			{
				ERoverActionSubViewType.None,
				ERoverActionSubViewType.BlessingSuitPreview,
				ERoverActionSubViewType.BlessingSuitSelect,
				ERoverActionSubViewType.SelectBlessing,
				ERoverActionSubViewType.SelectReinforcement,
				ERoverActionSubViewType.SelectEvent,
				ERoverActionSubViewType.BlessingReinforcement
			};
		}

		// Token: 0x06033F18 RID: 212760 RVA: 0x00E8828A File Offset: 0x00E8648A
		public static string[] GetNames()
		{
			return new string[]
			{
				"None",
				"BlessingSuitPreview",
				"BlessingSuitSelect",
				"SelectBlessing",
				"SelectReinforcement",
				"SelectEvent",
				"BlessingReinforcement"
			};
		}
	}
}
