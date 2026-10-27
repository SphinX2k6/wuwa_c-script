using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061AA RID: 25002
	public static class ERoverActionSubViewTypeExtensions
	{
		// Token: 0x0603F253 RID: 258643 RVA: 0x00F411C4 File Offset: 0x00F3F3C4
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

		// Token: 0x0603F254 RID: 258644 RVA: 0x00F4123C File Offset: 0x00F3F43C
		public static ERoverActionSubViewType FromString(string name)
		{
			ERoverActionSubViewType result;
			if (!ERoverActionSubViewTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoverActionSubViewType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603F255 RID: 258645 RVA: 0x00F41268 File Offset: 0x00F3F468
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

		// Token: 0x0603F256 RID: 258646 RVA: 0x00F4136F File Offset: 0x00F3F56F
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

		// Token: 0x0603F257 RID: 258647 RVA: 0x00F413AF File Offset: 0x00F3F5AF
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

		// Token: 0x0603F258 RID: 258648 RVA: 0x00F413C2 File Offset: 0x00F3F5C2
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
