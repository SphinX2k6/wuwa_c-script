using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B03 RID: 2819
	public static class ETrackControlModeExtensions
	{
		// Token: 0x06003DA0 RID: 15776 RVA: 0x0009D9DC File Offset: 0x0009BBDC
		public static string ToEnumString(this ETrackControlMode value)
		{
			string result;
			if (value != ETrackControlMode.Sequence)
			{
				if (value != ETrackControlMode.Entity)
				{
					result = value.ToString();
				}
				else
				{
					result = "Entity";
				}
			}
			else
			{
				result = "Sequence";
			}
			return result;
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x0009DA14 File Offset: 0x0009BC14
		public static ETrackControlMode FromString(string name)
		{
			ETrackControlMode result;
			if (!ETrackControlModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackControlMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x0009DA3D File Offset: 0x0009BC3D
		public static bool TryFromString(string name, out ETrackControlMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrackControlMode.Sequence;
				return false;
			}
			if (name == "Sequence")
			{
				value = ETrackControlMode.Sequence;
				return true;
			}
			if (!(name == "Entity"))
			{
				value = ETrackControlMode.Sequence;
				return false;
			}
			value = ETrackControlMode.Entity;
			return true;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x0009DA76 File Offset: 0x0009BC76
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Sequence",
				"Entity"
			};
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x0009DA8E File Offset: 0x0009BC8E
		public static ETrackControlMode[] GetValues()
		{
			return new ETrackControlMode[]
			{
				ETrackControlMode.Sequence,
				ETrackControlMode.Entity
			};
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x0009DA9A File Offset: 0x0009BC9A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Sequence",
				"Entity"
			};
		}
	}
}
