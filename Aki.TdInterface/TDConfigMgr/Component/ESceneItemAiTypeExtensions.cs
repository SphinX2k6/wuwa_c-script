using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC5 RID: 2757
	public static class ESceneItemAiTypeExtensions
	{
		// Token: 0x06003C89 RID: 15497 RVA: 0x0009B394 File Offset: 0x00099594
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

		// Token: 0x06003C8A RID: 15498 RVA: 0x0009B3BC File Offset: 0x000995BC
		public static ESceneItemAiType FromString(string name)
		{
			ESceneItemAiType result;
			if (!ESceneItemAiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneItemAiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x0009B3E5 File Offset: 0x000995E5
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

		// Token: 0x06003C8C RID: 15500 RVA: 0x0009B40A File Offset: 0x0009960A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneItemPatrol"
			};
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x0009B41A File Offset: 0x0009961A
		public static ESceneItemAiType[] GetValues()
		{
			return new ESceneItemAiType[1];
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x0009B422 File Offset: 0x00099622
		public static string[] GetNames()
		{
			return new string[]
			{
				"SceneItemPatrol"
			};
		}
	}
}
