using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002345 RID: 9029
	public static class EGamepadShakeAttenuationShapeExtensions
	{
		// Token: 0x0600C535 RID: 50485 RVA: 0x001CC8F8 File Offset: 0x001CAAF8
		public static string ToEnumString(this EGamepadShakeAttenuationShape value)
		{
			string result;
			if (value == EGamepadShakeAttenuationShape.Sphere)
			{
				result = "Sphere";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C536 RID: 50486 RVA: 0x001CC920 File Offset: 0x001CAB20
		public static EGamepadShakeAttenuationShape FromString(string name)
		{
			EGamepadShakeAttenuationShape result;
			if (!EGamepadShakeAttenuationShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGamepadShakeAttenuationShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C537 RID: 50487 RVA: 0x001CC949 File Offset: 0x001CAB49
		public static bool TryFromString(string name, out EGamepadShakeAttenuationShape value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGamepadShakeAttenuationShape.Sphere;
				return false;
			}
			if (name == "Sphere")
			{
				value = EGamepadShakeAttenuationShape.Sphere;
				return true;
			}
			value = EGamepadShakeAttenuationShape.Sphere;
			return false;
		}

		// Token: 0x0600C538 RID: 50488 RVA: 0x001CC96E File Offset: 0x001CAB6E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Sphere"
			};
		}

		// Token: 0x0600C539 RID: 50489 RVA: 0x001CC97E File Offset: 0x001CAB7E
		public static EGamepadShakeAttenuationShape[] GetValues()
		{
			return new EGamepadShakeAttenuationShape[1];
		}

		// Token: 0x0600C53A RID: 50490 RVA: 0x001CC986 File Offset: 0x001CAB86
		public static string[] GetNames()
		{
			return new string[]
			{
				"Sphere"
			};
		}
	}
}
