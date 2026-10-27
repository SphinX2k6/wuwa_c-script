using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200534B RID: 21323
	public static class ERogueResMainSpineTypeExtensions
	{
		// Token: 0x0603679D RID: 223133 RVA: 0x00CE68E0 File Offset: 0x00CE4AE0
		public static string ToEnumString(this ERogueResMainSpineType value)
		{
			string result;
			if (value != ERogueResMainSpineType.Female)
			{
				if (value != ERogueResMainSpineType.Male)
				{
					result = value.ToString();
				}
				else
				{
					result = "Male";
				}
			}
			else
			{
				result = "Female";
			}
			return result;
		}

		// Token: 0x0603679E RID: 223134 RVA: 0x00CE6918 File Offset: 0x00CE4B18
		public static ERogueResMainSpineType FromString(string name)
		{
			ERogueResMainSpineType result;
			if (!ERogueResMainSpineTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERogueResMainSpineType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603679F RID: 223135 RVA: 0x00CE6941 File Offset: 0x00CE4B41
		public static bool TryFromString(string name, out ERogueResMainSpineType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERogueResMainSpineType.Female;
				return false;
			}
			if (name == "Female")
			{
				value = ERogueResMainSpineType.Female;
				return true;
			}
			if (!(name == "Male"))
			{
				value = ERogueResMainSpineType.Female;
				return false;
			}
			value = ERogueResMainSpineType.Male;
			return true;
		}

		// Token: 0x060367A0 RID: 223136 RVA: 0x00CE697A File Offset: 0x00CE4B7A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Female",
				"Male"
			};
		}

		// Token: 0x060367A1 RID: 223137 RVA: 0x00CE6992 File Offset: 0x00CE4B92
		public static ERogueResMainSpineType[] GetValues()
		{
			return new ERogueResMainSpineType[]
			{
				ERogueResMainSpineType.Female,
				ERogueResMainSpineType.Male
			};
		}

		// Token: 0x060367A2 RID: 223138 RVA: 0x00CE699E File Offset: 0x00CE4B9E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Female",
				"Male"
			};
		}
	}
}
