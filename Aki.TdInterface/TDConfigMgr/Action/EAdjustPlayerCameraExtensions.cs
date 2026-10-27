using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002297 RID: 8855
	public static class EAdjustPlayerCameraExtensions
	{
		// Token: 0x0600C226 RID: 49702 RVA: 0x001C5C78 File Offset: 0x001C3E78
		public static string ToEnumString(this EAdjustPlayerCamera value)
		{
			string result;
			switch (value)
			{
			case EAdjustPlayerCamera.Basic:
				result = "关卡.Common.镜头调整";
				break;
			case EAdjustPlayerCamera.Horizontal:
				result = "关卡.Common.镜头.横版镜头";
				break;
			case EAdjustPlayerCamera.Dialog:
				result = "关卡.Common.镜头.对话镜头";
				break;
			case EAdjustPlayerCamera.Fixed:
				result = "关卡.Common.镜头.固定镜头";
				break;
			case EAdjustPlayerCamera.AxisLock:
				result = "关卡.Common.镜头.锁轴镜头";
				break;
			case EAdjustPlayerCamera.FirstPerson:
				result = "关卡.Common.镜头.第一人称镜头";
				break;
			case EAdjustPlayerCamera.FixedLookAt:
				result = "关卡.Common.镜头.固定镜头看向目标";
				break;
			case EAdjustPlayerCamera.FixedSurveillance:
				result = "关卡.Common.镜头.固定位置监控镜头";
				break;
			case EAdjustPlayerCamera.ZoneFollow:
				result = "关卡.Common.镜头.区域焦点镜头";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C227 RID: 49703 RVA: 0x001C5D08 File Offset: 0x001C3F08
		public static EAdjustPlayerCamera FromString(string name)
		{
			EAdjustPlayerCamera result;
			if (!EAdjustPlayerCameraExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAdjustPlayerCamera 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C228 RID: 49704 RVA: 0x001C5D34 File Offset: 0x001C3F34
		public static bool TryFromString(string name, out EAdjustPlayerCamera value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAdjustPlayerCamera.Basic;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length != 14)
				{
					switch (length)
					{
					case 17:
					{
						char c = name[13];
						if (c <= '对')
						{
							if (c != '固')
							{
								if (c == '对')
								{
									if (name == "关卡.Common.镜头.对话镜头")
									{
										value = EAdjustPlayerCamera.Dialog;
										return true;
									}
								}
							}
							else if (name == "关卡.Common.镜头.固定镜头")
							{
								value = EAdjustPlayerCamera.Fixed;
								return true;
							}
						}
						else if (c != '横')
						{
							if (c == '锁')
							{
								if (name == "关卡.Common.镜头.锁轴镜头")
								{
									value = EAdjustPlayerCamera.AxisLock;
									return true;
								}
							}
						}
						else if (name == "关卡.Common.镜头.横版镜头")
						{
							value = EAdjustPlayerCamera.Horizontal;
							return true;
						}
						break;
					}
					case 19:
					{
						char c = name[13];
						if (c != '区')
						{
							if (c == '第')
							{
								if (name == "关卡.Common.镜头.第一人称镜头")
								{
									value = EAdjustPlayerCamera.FirstPerson;
									return true;
								}
							}
						}
						else if (name == "关卡.Common.镜头.区域焦点镜头")
						{
							value = EAdjustPlayerCamera.ZoneFollow;
							return true;
						}
						break;
					}
					case 21:
					{
						char c = name[15];
						if (c != '位')
						{
							if (c == '镜')
							{
								if (name == "关卡.Common.镜头.固定镜头看向目标")
								{
									value = EAdjustPlayerCamera.FixedLookAt;
									return true;
								}
							}
						}
						else if (name == "关卡.Common.镜头.固定位置监控镜头")
						{
							value = EAdjustPlayerCamera.FixedSurveillance;
							return true;
						}
						break;
					}
					}
				}
				else if (name == "关卡.Common.镜头调整")
				{
					value = EAdjustPlayerCamera.Basic;
					return true;
				}
			}
			value = EAdjustPlayerCamera.Basic;
			return false;
		}

		// Token: 0x0600C229 RID: 49705 RVA: 0x001C5ED0 File Offset: 0x001C40D0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"关卡.Common.镜头调整",
				"关卡.Common.镜头.横版镜头",
				"关卡.Common.镜头.对话镜头",
				"关卡.Common.镜头.固定镜头",
				"关卡.Common.镜头.锁轴镜头",
				"关卡.Common.镜头.第一人称镜头",
				"关卡.Common.镜头.固定镜头看向目标",
				"关卡.Common.镜头.固定位置监控镜头",
				"关卡.Common.镜头.区域焦点镜头"
			};
		}

		// Token: 0x0600C22A RID: 49706 RVA: 0x001C5F2C File Offset: 0x001C412C
		public static EAdjustPlayerCamera[] GetValues()
		{
			return new EAdjustPlayerCamera[]
			{
				EAdjustPlayerCamera.Basic,
				EAdjustPlayerCamera.Horizontal,
				EAdjustPlayerCamera.Dialog,
				EAdjustPlayerCamera.Fixed,
				EAdjustPlayerCamera.AxisLock,
				EAdjustPlayerCamera.FirstPerson,
				EAdjustPlayerCamera.FixedLookAt,
				EAdjustPlayerCamera.FixedSurveillance,
				EAdjustPlayerCamera.ZoneFollow
			};
		}

		// Token: 0x0600C22B RID: 49707 RVA: 0x001C5F40 File Offset: 0x001C4140
		public static string[] GetNames()
		{
			return new string[]
			{
				"Basic",
				"Horizontal",
				"Dialog",
				"Fixed",
				"AxisLock",
				"FirstPerson",
				"FixedLookAt",
				"FixedSurveillance",
				"ZoneFollow"
			};
		}
	}
}
