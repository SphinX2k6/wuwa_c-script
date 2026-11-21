using System;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200364E RID: 13902
	public static class EGameplayEntityStateExtensions
	{
		// Token: 0x06024111 RID: 147729 RVA: 0x00A35198 File Offset: 0x00A33398
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

		// Token: 0x06024112 RID: 147730 RVA: 0x00A351EC File Offset: 0x00A333EC
		public static EGameplayEntityState FromString(string name)
		{
			EGameplayEntityState result;
			if (!EGameplayEntityStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGameplayEntityState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06024113 RID: 147731 RVA: 0x00A35218 File Offset: 0x00A33418
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

		// Token: 0x06024114 RID: 147732 RVA: 0x00A35280 File Offset: 0x00A33480
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

		// Token: 0x06024115 RID: 147733 RVA: 0x00A352A8 File Offset: 0x00A334A8
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

		// Token: 0x06024116 RID: 147734 RVA: 0x00A352BB File Offset: 0x00A334BB
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
