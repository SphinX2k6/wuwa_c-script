using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F4 RID: 2548
	public static class ERenderSpecifiedRangeTypeExtensions
	{
		// Token: 0x0600387B RID: 14459 RVA: 0x00092460 File Offset: 0x00090660
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
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x000924B4 File Offset: 0x000906B4
		public static ERenderSpecifiedRangeType FromString(string name)
		{
			ERenderSpecifiedRangeType result;
			if (!ERenderSpecifiedRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERenderSpecifiedRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x000924E0 File Offset: 0x000906E0
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
			if (!(name == "QuantumFollowShooter"))
			{
				value = ERenderSpecifiedRangeType.FlowerBridge;
				return false;
			}
			value = ERenderSpecifiedRangeType.QuantumFollowShooter;
			return true;
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x00092548 File Offset: 0x00090748
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FlowerBridge",
				"BookPage",
				"FogBarrier",
				"QuantumFollowShooter"
			};
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00092570 File Offset: 0x00090770
		public static ERenderSpecifiedRangeType[] GetValues()
		{
			return new ERenderSpecifiedRangeType[]
			{
				ERenderSpecifiedRangeType.FlowerBridge,
				ERenderSpecifiedRangeType.BookPage,
				ERenderSpecifiedRangeType.FogBarrier,
				ERenderSpecifiedRangeType.QuantumFollowShooter
			};
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00092583 File Offset: 0x00090783
		public static string[] GetNames()
		{
			return new string[]
			{
				"FlowerBridge",
				"BookPage",
				"FogBarrier",
				"QuantumFollowShooter"
			};
		}
	}
}
