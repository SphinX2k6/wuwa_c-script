using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A00 RID: 2560
	public static class ESceneItemAiTypeExtensions
	{
		// Token: 0x060038B1 RID: 14513 RVA: 0x00092AA4 File Offset: 0x00090CA4
		public static string ToEnumString(this ESceneItemAiType value)
		{
			string result;
			if (value == ESceneItemAiType.SceneItemPatrol)
			{
				result = "SceneItemPatrol";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00092ACC File Offset: 0x00090CCC
		public static ESceneItemAiType FromString(string name)
		{
			ESceneItemAiType result;
			if (!ESceneItemAiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneItemAiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x00092AF5 File Offset: 0x00090CF5
		public static bool TryFromString(string name, out ESceneItemAiType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneItemAiType.SceneItemPatrol;
				return false;
			}
			if (name == "SceneItemPatrol")
			{
				value = ESceneItemAiType.SceneItemPatrol;
				return true;
			}
			value = ESceneItemAiType.SceneItemPatrol;
			return false;
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00092B1A File Offset: 0x00090D1A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneItemPatrol"
			};
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00092B2A File Offset: 0x00090D2A
		public static ESceneItemAiType[] GetValues()
		{
			return new ESceneItemAiType[1];
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00092B32 File Offset: 0x00090D32
		public static string[] GetNames()
		{
			return new string[]
			{
				"SceneItemPatrol"
			};
		}
	}
}
