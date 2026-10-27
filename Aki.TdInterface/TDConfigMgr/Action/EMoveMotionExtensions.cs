using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239B RID: 9115
	public static class EMoveMotionExtensions
	{
		// Token: 0x0600C6B8 RID: 50872 RVA: 0x001D19CC File Offset: 0x001CFBCC
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

		// Token: 0x0600C6B9 RID: 50873 RVA: 0x001D1A04 File Offset: 0x001CFC04
		public static EMoveMotion FromString(string name)
		{
			EMoveMotion result;
			if (!EMoveMotionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveMotion 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6BA RID: 50874 RVA: 0x001D1A2D File Offset: 0x001CFC2D
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

		// Token: 0x0600C6BB RID: 50875 RVA: 0x001D1A66 File Offset: 0x001CFC66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UniformMotion",
				"VariableMotion"
			};
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x001D1A7E File Offset: 0x001CFC7E
		public static EMoveMotion[] GetValues()
		{
			return new EMoveMotion[]
			{
				EMoveMotion.UniformMotion,
				EMoveMotion.VariableMotion
			};
		}

		// Token: 0x0600C6BD RID: 50877 RVA: 0x001D1A8A File Offset: 0x001CFC8A
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
