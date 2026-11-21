using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B8 RID: 9656
	public static class EGamepadShakeAttenuationShapeExtensions
	{
		// Token: 0x0600D116 RID: 53526 RVA: 0x001E4AC4 File Offset: 0x001E2CC4
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

		// Token: 0x0600D117 RID: 53527 RVA: 0x001E4AEC File Offset: 0x001E2CEC
		public static EGamepadShakeAttenuationShape FromString(string name)
		{
			EGamepadShakeAttenuationShape result;
			if (!EGamepadShakeAttenuationShapeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGamepadShakeAttenuationShape 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D118 RID: 53528 RVA: 0x001E4B15 File Offset: 0x001E2D15
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

		// Token: 0x0600D119 RID: 53529 RVA: 0x001E4B3A File Offset: 0x001E2D3A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Sphere"
			};
		}

		// Token: 0x0600D11A RID: 53530 RVA: 0x001E4B4A File Offset: 0x001E2D4A
		public static EGamepadShakeAttenuationShape[] GetValues()
		{
			return new EGamepadShakeAttenuationShape[1];
		}

		// Token: 0x0600D11B RID: 53531 RVA: 0x001E4B52 File Offset: 0x001E2D52
		public static string[] GetNames()
		{
			return new string[]
			{
				"Sphere"
			};
		}
	}
}
