using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228B RID: 8843
	public static class EActorFaceExpressionTypeExtensions
	{
		// Token: 0x0600C1F0 RID: 49648 RVA: 0x001C5128 File Offset: 0x001C3328
		public static string ToEnumString(this EActorFaceExpressionType value)
		{
			string result;
			if (value != EActorFaceExpressionType.Play)
			{
				if (value != EActorFaceExpressionType.Stop)
				{
					result = value.ToString();
				}
				else
				{
					result = "Stop";
				}
			}
			else
			{
				result = "Play";
			}
			return result;
		}

		// Token: 0x0600C1F1 RID: 49649 RVA: 0x001C5160 File Offset: 0x001C3360
		public static EActorFaceExpressionType FromString(string name)
		{
			EActorFaceExpressionType result;
			if (!EActorFaceExpressionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorFaceExpressionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C1F2 RID: 49650 RVA: 0x001C5189 File Offset: 0x001C3389
		public static bool TryFromString(string name, out EActorFaceExpressionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActorFaceExpressionType.Play;
				return false;
			}
			if (name == "Play")
			{
				value = EActorFaceExpressionType.Play;
				return true;
			}
			if (!(name == "Stop"))
			{
				value = EActorFaceExpressionType.Play;
				return false;
			}
			value = EActorFaceExpressionType.Stop;
			return true;
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x001C51C2 File Offset: 0x001C33C2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x001C51DA File Offset: 0x001C33DA
		public static EActorFaceExpressionType[] GetValues()
		{
			return new EActorFaceExpressionType[]
			{
				EActorFaceExpressionType.Play,
				EActorFaceExpressionType.Stop
			};
		}

		// Token: 0x0600C1F5 RID: 49653 RVA: 0x001C51E6 File Offset: 0x001C33E6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}
	}
}
