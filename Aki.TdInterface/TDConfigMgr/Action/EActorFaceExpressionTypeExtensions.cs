using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F8 RID: 9464
	public static class EActorFaceExpressionTypeExtensions
	{
		// Token: 0x0600CDB6 RID: 52662 RVA: 0x001DCE1C File Offset: 0x001DB01C
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

		// Token: 0x0600CDB7 RID: 52663 RVA: 0x001DCE54 File Offset: 0x001DB054
		public static EActorFaceExpressionType FromString(string name)
		{
			EActorFaceExpressionType result;
			if (!EActorFaceExpressionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorFaceExpressionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x001DCE7D File Offset: 0x001DB07D
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

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x001DCEB6 File Offset: 0x001DB0B6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}

		// Token: 0x0600CDBA RID: 52666 RVA: 0x001DCECE File Offset: 0x001DB0CE
		public static EActorFaceExpressionType[] GetValues()
		{
			return new EActorFaceExpressionType[]
			{
				EActorFaceExpressionType.Play,
				EActorFaceExpressionType.Stop
			};
		}

		// Token: 0x0600CDBB RID: 52667 RVA: 0x001DCEDA File Offset: 0x001DB0DA
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
