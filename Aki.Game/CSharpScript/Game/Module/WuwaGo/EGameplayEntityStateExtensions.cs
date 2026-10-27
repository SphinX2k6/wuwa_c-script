using System;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200471E RID: 18206
	public static class EGameplayEntityStateExtensions
	{
		// Token: 0x0602F94B RID: 194891 RVA: 0x00B054C8 File Offset: 0x00B036C8
		public static string ToEnumString(this EGameplayEntityState value)
		{
			string result;
			switch (value)
			{
			case EGameplayEntityState.Locked:
				result = "关卡.Common.状态.封锁";
				break;
			case EGameplayEntityState.Normal:
				result = "关卡.Common.状态.常态";
				break;
			case EGameplayEntityState.Activated:
				result = "关卡.Common.状态.激活";
				break;
			case EGameplayEntityState.Completed:
				result = "关卡.Common.状态.完成";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0602F94C RID: 194892 RVA: 0x00B0551C File Offset: 0x00B0371C
		public static EGameplayEntityState FromString(string name)
		{
			EGameplayEntityState result;
			if (!EGameplayEntityStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGameplayEntityState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0602F94D RID: 194893 RVA: 0x00B05548 File Offset: 0x00B03748
		public static bool TryFromString(string name, out EGameplayEntityState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGameplayEntityState.Locked;
				return false;
			}
			if (name == "关卡.Common.状态.封锁")
			{
				value = EGameplayEntityState.Locked;
				return true;
			}
			if (name == "关卡.Common.状态.常态")
			{
				value = EGameplayEntityState.Normal;
				return true;
			}
			if (name == "关卡.Common.状态.激活")
			{
				value = EGameplayEntityState.Activated;
				return true;
			}
			if (!(name == "关卡.Common.状态.完成"))
			{
				value = EGameplayEntityState.Locked;
				return false;
			}
			value = EGameplayEntityState.Completed;
			return true;
		}

		// Token: 0x0602F94E RID: 194894 RVA: 0x00B055B0 File Offset: 0x00B037B0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"关卡.Common.状态.封锁",
				"关卡.Common.状态.常态",
				"关卡.Common.状态.激活",
				"关卡.Common.状态.完成"
			};
		}

		// Token: 0x0602F94F RID: 194895 RVA: 0x00B055D8 File Offset: 0x00B037D8
		public static EGameplayEntityState[] GetValues()
		{
			return new EGameplayEntityState[]
			{
				EGameplayEntityState.Locked,
				EGameplayEntityState.Normal,
				EGameplayEntityState.Activated,
				EGameplayEntityState.Completed
			};
		}

		// Token: 0x0602F950 RID: 194896 RVA: 0x00B055EB File Offset: 0x00B037EB
		public static string[] GetNames()
		{
			return new string[]
			{
				"Locked",
				"Normal",
				"Activated",
				"Completed"
			};
		}
	}
}
