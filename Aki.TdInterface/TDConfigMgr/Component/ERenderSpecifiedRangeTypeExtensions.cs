using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB9 RID: 2745
	public static class ERenderSpecifiedRangeTypeExtensions
	{
		// Token: 0x06003C53 RID: 15443 RVA: 0x0009AD20 File Offset: 0x00098F20
		public static string ToEnumString(this ERenderSpecifiedRangeType value)
		{
			string result;
			switch (value)
			{
			case ERenderSpecifiedRangeType.FlowerBridge:
				result = "FlowerBridge";
				break;
			case ERenderSpecifiedRangeType.BookPage:
				result = "BookPage";
				break;
			case ERenderSpecifiedRangeType.FogBarrier:
				result = "FogBarrier";
				break;
			case ERenderSpecifiedRangeType.QuantumFollowShooter:
				result = "QuantumFollowShooter";
				break;
			case ERenderSpecifiedRangeType.BeforeYourEyesSceneReveal:
				result = "BeforeYourEyesSceneReveal";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x0009AD80 File Offset: 0x00098F80
		public static ERenderSpecifiedRangeType FromString(string name)
		{
			ERenderSpecifiedRangeType result;
			if (!ERenderSpecifiedRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERenderSpecifiedRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x0009ADAC File Offset: 0x00098FAC
		public static bool TryFromString(string name, out ERenderSpecifiedRangeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERenderSpecifiedRangeType.FlowerBridge;
				return false;
			}
			if (name == "FlowerBridge")
			{
				value = ERenderSpecifiedRangeType.FlowerBridge;
				return true;
			}
			if (name == "BookPage")
			{
				value = ERenderSpecifiedRangeType.BookPage;
				return true;
			}
			if (name == "FogBarrier")
			{
				value = ERenderSpecifiedRangeType.FogBarrier;
				return true;
			}
			if (name == "QuantumFollowShooter")
			{
				value = ERenderSpecifiedRangeType.QuantumFollowShooter;
				return true;
			}
			if (!(name == "BeforeYourEyesSceneReveal"))
			{
				value = ERenderSpecifiedRangeType.FlowerBridge;
				return false;
			}
			value = ERenderSpecifiedRangeType.BeforeYourEyesSceneReveal;
			return true;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x0009AE26 File Offset: 0x00099026
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FlowerBridge",
				"BookPage",
				"FogBarrier",
				"QuantumFollowShooter",
				"BeforeYourEyesSceneReveal"
			};
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x0009AE56 File Offset: 0x00099056
		public static ERenderSpecifiedRangeType[] GetValues()
		{
			return new ERenderSpecifiedRangeType[]
			{
				ERenderSpecifiedRangeType.FlowerBridge,
				ERenderSpecifiedRangeType.BookPage,
				ERenderSpecifiedRangeType.FogBarrier,
				ERenderSpecifiedRangeType.QuantumFollowShooter,
				ERenderSpecifiedRangeType.BeforeYourEyesSceneReveal
			};
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x0009AE69 File Offset: 0x00099069
		public static string[] GetNames()
		{
			return new string[]
			{
				"FlowerBridge",
				"BookPage",
				"FogBarrier",
				"QuantumFollowShooter",
				"BeforeYourEyesSceneReveal"
			};
		}
	}
}
