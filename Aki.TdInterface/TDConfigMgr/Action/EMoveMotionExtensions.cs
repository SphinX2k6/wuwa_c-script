using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002626 RID: 9766
	public static class EMoveMotionExtensions
	{
		// Token: 0x0600D305 RID: 54021 RVA: 0x001EAB6C File Offset: 0x001E8D6C
		public static string ToEnumString(this EMoveMotion value)
		{
			string result;
			if (value != EMoveMotion.UniformMotion)
			{
				if (value != EMoveMotion.VariableMotion)
				{
					result = value.ToString();
				}
				else
				{
					result = "VariableMotion";
				}
			}
			else
			{
				result = "UniformMotion";
			}
			return result;
		}

		// Token: 0x0600D306 RID: 54022 RVA: 0x001EABA4 File Offset: 0x001E8DA4
		public static EMoveMotion FromString(string name)
		{
			EMoveMotion result;
			if (!EMoveMotionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveMotion 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D307 RID: 54023 RVA: 0x001EABCD File Offset: 0x001E8DCD
		public static bool TryFromString(string name, out EMoveMotion value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMoveMotion.UniformMotion;
				return false;
			}
			if (name == "UniformMotion")
			{
				value = EMoveMotion.UniformMotion;
				return true;
			}
			if (!(name == "VariableMotion"))
			{
				value = EMoveMotion.UniformMotion;
				return false;
			}
			value = EMoveMotion.VariableMotion;
			return true;
		}

		// Token: 0x0600D308 RID: 54024 RVA: 0x001EAC06 File Offset: 0x001E8E06
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UniformMotion",
				"VariableMotion"
			};
		}

		// Token: 0x0600D309 RID: 54025 RVA: 0x001EAC1E File Offset: 0x001E8E1E
		public static EMoveMotion[] GetValues()
		{
			return new EMoveMotion[]
			{
				EMoveMotion.UniformMotion,
				EMoveMotion.VariableMotion
			};
		}

		// Token: 0x0600D30A RID: 54026 RVA: 0x001EAC2A File Offset: 0x001E8E2A
		public static string[] GetNames()
		{
			return new string[]
			{
				"UniformMotion",
				"VariableMotion"
			};
		}
	}
}
