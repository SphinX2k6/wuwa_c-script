using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B4 RID: 2484
	public static class ENpcModelTypeExtensions
	{
		// Token: 0x0600375B RID: 14171 RVA: 0x0008FF84 File Offset: 0x0008E184
		public static string ToEnumString(this ENpcModelType value)
		{
			string result;
			if (value != ENpcModelType.Mesh)
			{
				if (value != ENpcModelType.Da)
				{
					result = value.ToString();
				}
				else
				{
					result = "Da";
				}
			}
			else
			{
				result = "Mesh";
			}
			return result;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x0008FFBC File Offset: 0x0008E1BC
		public static ENpcModelType FromString(string name)
		{
			ENpcModelType result;
			if (!ENpcModelTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcModelType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x0008FFE5 File Offset: 0x0008E1E5
		public static bool TryFromString(string name, out ENpcModelType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcModelType.Mesh;
				return false;
			}
			if (name == "Mesh")
			{
				value = ENpcModelType.Mesh;
				return true;
			}
			if (!(name == "Da"))
			{
				value = ENpcModelType.Mesh;
				return false;
			}
			value = ENpcModelType.Da;
			return true;
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x0009001E File Offset: 0x0008E21E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mesh",
				"Da"
			};
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00090036 File Offset: 0x0008E236
		public static ENpcModelType[] GetValues()
		{
			return new ENpcModelType[]
			{
				ENpcModelType.Mesh,
				ENpcModelType.Da
			};
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00090042 File Offset: 0x0008E242
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mesh",
				"Da"
			};
		}
	}
}
