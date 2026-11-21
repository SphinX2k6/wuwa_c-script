using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A9F RID: 2719
	public static class EPortalModelExtensions
	{
		// Token: 0x06003BDE RID: 15326 RVA: 0x00099E7C File Offset: 0x0009807C
		public static string ToEnumString(this EPortalModel value)
		{
			string result;
			if (value != EPortalModel.A)
			{
				if (value != EPortalModel.B)
				{
					result = value.ToString();
				}
				else
				{
					result = "B";
				}
			}
			else
			{
				result = "A";
			}
			return result;
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x00099EB4 File Offset: 0x000980B4
		public static EPortalModel FromString(string name)
		{
			EPortalModel result;
			if (!EPortalModelExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPortalModel 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x00099EDD File Offset: 0x000980DD
		public static bool TryFromString(string name, out EPortalModel value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPortalModel.A;
				return false;
			}
			if (name == "A")
			{
				value = EPortalModel.A;
				return true;
			}
			if (!(name == "B"))
			{
				value = EPortalModel.A;
				return false;
			}
			value = EPortalModel.B;
			return true;
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00099F16 File Offset: 0x00098116
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"A",
				"B"
			};
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00099F2E File Offset: 0x0009812E
		public static EPortalModel[] GetValues()
		{
			return new EPortalModel[]
			{
				EPortalModel.A,
				EPortalModel.B
			};
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00099F3A File Offset: 0x0009813A
		public static string[] GetNames()
		{
			return new string[]
			{
				"A",
				"B"
			};
		}
	}
}
