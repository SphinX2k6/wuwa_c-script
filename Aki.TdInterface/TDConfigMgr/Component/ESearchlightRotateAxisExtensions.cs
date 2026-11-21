using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ACD RID: 2765
	public static class ESearchlightRotateAxisExtensions
	{
		// Token: 0x06003CAD RID: 15533 RVA: 0x0009B7AC File Offset: 0x000999AC
		public static string ToEnumString(this ESearchlightRotateAxis value)
		{
			string result;
			if (value != ESearchlightRotateAxis.Yaw)
			{
				if (value != ESearchlightRotateAxis.Pitch)
				{
					result = value.ToString();
				}
				else
				{
					result = "Pitch";
				}
			}
			else
			{
				result = "Yaw";
			}
			return result;
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x0009B7E4 File Offset: 0x000999E4
		public static ESearchlightRotateAxis FromString(string name)
		{
			ESearchlightRotateAxis result;
			if (!ESearchlightRotateAxisExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESearchlightRotateAxis 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x0009B80D File Offset: 0x00099A0D
		public static bool TryFromString(string name, out ESearchlightRotateAxis value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESearchlightRotateAxis.Yaw;
				return false;
			}
			if (name == "Yaw")
			{
				value = ESearchlightRotateAxis.Yaw;
				return true;
			}
			if (!(name == "Pitch"))
			{
				value = ESearchlightRotateAxis.Yaw;
				return false;
			}
			value = ESearchlightRotateAxis.Pitch;
			return true;
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x0009B846 File Offset: 0x00099A46
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Yaw",
				"Pitch"
			};
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x0009B85E File Offset: 0x00099A5E
		public static ESearchlightRotateAxis[] GetValues()
		{
			return new ESearchlightRotateAxis[]
			{
				ESearchlightRotateAxis.Yaw,
				ESearchlightRotateAxis.Pitch
			};
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x0009B86A File Offset: 0x00099A6A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Yaw",
				"Pitch"
			};
		}
	}
}
