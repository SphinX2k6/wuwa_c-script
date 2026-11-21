using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200431B RID: 17179
	public static class ERogueResMainSpineTypeExtensions
	{
		// Token: 0x0602B699 RID: 177817 RVA: 0x00C342B0 File Offset: 0x00C324B0
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

		// Token: 0x0602B69A RID: 177818 RVA: 0x00C342E8 File Offset: 0x00C324E8
		public static ERogueResMainSpineType FromString(string name)
		{
			ERogueResMainSpineType result;
			if (!ERogueResMainSpineTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERogueResMainSpineType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0602B69B RID: 177819 RVA: 0x00C34311 File Offset: 0x00C32511
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

		// Token: 0x0602B69C RID: 177820 RVA: 0x00C3434A File Offset: 0x00C3254A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Female",
				"Male"
			};
		}

		// Token: 0x0602B69D RID: 177821 RVA: 0x00C34362 File Offset: 0x00C32562
		public static ERogueResMainSpineType[] GetValues()
		{
			return new ERogueResMainSpineType[]
			{
				ERogueResMainSpineType.Female,
				ERogueResMainSpineType.Male
			};
		}

		// Token: 0x0602B69E RID: 177822 RVA: 0x00C3436E File Offset: 0x00C3256E
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
