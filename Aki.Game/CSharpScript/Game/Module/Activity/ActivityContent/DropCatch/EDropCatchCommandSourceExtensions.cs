using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005624 RID: 22052
	public static class EDropCatchCommandSourceExtensions
	{
		// Token: 0x06036859 RID: 223321 RVA: 0x00F37BF4 File Offset: 0x00F35DF4
		public static string ToEnumString(this EDropCatchCommandSource value)
		{
			string result;
			if (value == EDropCatchCommandSource.Skill)
			{
				result = "Skill";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0603685A RID: 223322 RVA: 0x00F37C1C File Offset: 0x00F35E1C
		public static EDropCatchCommandSource FromString(string name)
		{
			EDropCatchCommandSource result;
			if (!EDropCatchCommandSourceExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchCommandSource 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603685B RID: 223323 RVA: 0x00F37C45 File Offset: 0x00F35E45
		public static bool TryFromString(string name, out EDropCatchCommandSource value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchCommandSource.Skill;
				return false;
			}
			if (name == "Skill")
			{
				value = EDropCatchCommandSource.Skill;
				return true;
			}
			value = EDropCatchCommandSource.Skill;
			return false;
		}

		// Token: 0x0603685C RID: 223324 RVA: 0x00F37C6A File Offset: 0x00F35E6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Skill"
			};
		}

		// Token: 0x0603685D RID: 223325 RVA: 0x00F37C7A File Offset: 0x00F35E7A
		public static EDropCatchCommandSource[] GetValues()
		{
			return new EDropCatchCommandSource[1];
		}

		// Token: 0x0603685E RID: 223326 RVA: 0x00F37C82 File Offset: 0x00F35E82
		public static string[] GetNames()
		{
			return new string[]
			{
				"Skill"
			};
		}
	}
}
