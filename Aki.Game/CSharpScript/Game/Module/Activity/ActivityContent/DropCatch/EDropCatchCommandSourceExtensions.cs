using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066D4 RID: 26324
	public static class EDropCatchCommandSourceExtensions
	{
		// Token: 0x06041D0D RID: 269581 RVA: 0x00FF67F0 File Offset: 0x00FF49F0
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

		// Token: 0x06041D0E RID: 269582 RVA: 0x00FF6818 File Offset: 0x00FF4A18
		public static EDropCatchCommandSource FromString(string name)
		{
			EDropCatchCommandSource result;
			if (!EDropCatchCommandSourceExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchCommandSource 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041D0F RID: 269583 RVA: 0x00FF6841 File Offset: 0x00FF4A41
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

		// Token: 0x06041D10 RID: 269584 RVA: 0x00FF6866 File Offset: 0x00FF4A66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Skill"
			};
		}

		// Token: 0x06041D11 RID: 269585 RVA: 0x00FF6876 File Offset: 0x00FF4A76
		public static EDropCatchCommandSource[] GetValues()
		{
			return new EDropCatchCommandSource[1];
		}

		// Token: 0x06041D12 RID: 269586 RVA: 0x00FF687E File Offset: 0x00FF4A7E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Skill"
			};
		}
	}
}
