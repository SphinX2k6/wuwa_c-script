using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200263E RID: 9790
	public static class ENpcGroupSequenceBindingTypeExtensions
	{
		// Token: 0x0600D371 RID: 54129 RVA: 0x001EB968 File Offset: 0x001E9B68
		public static string ToEnumString(this ENpcGroupSequenceBindingType value)
		{
			string result;
			if (value == ENpcGroupSequenceBindingType.StaticEntity)
			{
				result = "StaticEntity";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D372 RID: 54130 RVA: 0x001EB990 File Offset: 0x001E9B90
		public static ENpcGroupSequenceBindingType FromString(string name)
		{
			ENpcGroupSequenceBindingType result;
			if (!ENpcGroupSequenceBindingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcGroupSequenceBindingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D373 RID: 54131 RVA: 0x001EB9B9 File Offset: 0x001E9BB9
		public static bool TryFromString(string name, out ENpcGroupSequenceBindingType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcGroupSequenceBindingType.StaticEntity;
				return false;
			}
			if (name == "StaticEntity")
			{
				value = ENpcGroupSequenceBindingType.StaticEntity;
				return true;
			}
			value = ENpcGroupSequenceBindingType.StaticEntity;
			return false;
		}

		// Token: 0x0600D374 RID: 54132 RVA: 0x001EB9DE File Offset: 0x001E9BDE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StaticEntity"
			};
		}

		// Token: 0x0600D375 RID: 54133 RVA: 0x001EB9EE File Offset: 0x001E9BEE
		public static ENpcGroupSequenceBindingType[] GetValues()
		{
			return new ENpcGroupSequenceBindingType[1];
		}

		// Token: 0x0600D376 RID: 54134 RVA: 0x001EB9F6 File Offset: 0x001E9BF6
		public static string[] GetNames()
		{
			return new string[]
			{
				"StaticEntity"
			};
		}
	}
}
