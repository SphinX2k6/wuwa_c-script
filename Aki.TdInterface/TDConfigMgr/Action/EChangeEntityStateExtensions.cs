using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D5 RID: 8917
	public static class EChangeEntityStateExtensions
	{
		// Token: 0x0600C33D RID: 49981 RVA: 0x001C8784 File Offset: 0x001C6984
		public static string ToEnumString(this EChangeEntityState value)
		{
			string result;
			switch (value)
			{
			case EChangeEntityState.Directly:
				result = "Directly";
				break;
			case EChangeEntityState.BatchDirectly:
				result = "BatchDirectly";
				break;
			case EChangeEntityState.Loop:
				result = "Loop";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C33E RID: 49982 RVA: 0x001C87CC File Offset: 0x001C69CC
		public static EChangeEntityState FromString(string name)
		{
			EChangeEntityState result;
			if (!EChangeEntityStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChangeEntityState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x001C87F8 File Offset: 0x001C69F8
		public static bool TryFromString(string name, out EChangeEntityState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EChangeEntityState.Directly;
				return false;
			}
			if (name == "Directly")
			{
				value = EChangeEntityState.Directly;
				return true;
			}
			if (name == "BatchDirectly")
			{
				value = EChangeEntityState.BatchDirectly;
				return true;
			}
			if (!(name == "Loop"))
			{
				value = EChangeEntityState.Directly;
				return false;
			}
			value = EChangeEntityState.Loop;
			return true;
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x001C884E File Offset: 0x001C6A4E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Directly",
				"BatchDirectly",
				"Loop"
			};
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x001C886E File Offset: 0x001C6A6E
		public static EChangeEntityState[] GetValues()
		{
			return new EChangeEntityState[]
			{
				EChangeEntityState.Directly,
				EChangeEntityState.BatchDirectly,
				EChangeEntityState.Loop
			};
		}

		// Token: 0x0600C342 RID: 49986 RVA: 0x001C887E File Offset: 0x001C6A7E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Directly",
				"BatchDirectly",
				"Loop"
			};
		}
	}
}
