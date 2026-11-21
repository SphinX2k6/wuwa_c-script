using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002544 RID: 9540
	public static class EChangeEntityStateExtensions
	{
		// Token: 0x0600CF0C RID: 53004 RVA: 0x001E058C File Offset: 0x001DE78C
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

		// Token: 0x0600CF0D RID: 53005 RVA: 0x001E05D4 File Offset: 0x001DE7D4
		public static EChangeEntityState FromString(string name)
		{
			EChangeEntityState result;
			if (!EChangeEntityStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EChangeEntityState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF0E RID: 53006 RVA: 0x001E0600 File Offset: 0x001DE800
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

		// Token: 0x0600CF0F RID: 53007 RVA: 0x001E0656 File Offset: 0x001DE856
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Directly",
				"BatchDirectly",
				"Loop"
			};
		}

		// Token: 0x0600CF10 RID: 53008 RVA: 0x001E0676 File Offset: 0x001DE876
		public static EChangeEntityState[] GetValues()
		{
			return new EChangeEntityState[]
			{
				EChangeEntityState.Directly,
				EChangeEntityState.BatchDirectly,
				EChangeEntityState.Loop
			};
		}

		// Token: 0x0600CF11 RID: 53009 RVA: 0x001E0686 File Offset: 0x001DE886
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
