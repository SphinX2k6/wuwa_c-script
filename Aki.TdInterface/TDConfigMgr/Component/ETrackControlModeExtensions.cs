using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3E RID: 2622
	public static class ETrackControlModeExtensions
	{
		// Token: 0x060039C8 RID: 14792 RVA: 0x000950A8 File Offset: 0x000932A8
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

		// Token: 0x060039C9 RID: 14793 RVA: 0x000950E0 File Offset: 0x000932E0
		public static ETrackControlMode FromString(string name)
		{
			ETrackControlMode result;
			if (!ETrackControlModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrackControlMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x00095109 File Offset: 0x00093309
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

		// Token: 0x060039CB RID: 14795 RVA: 0x00095142 File Offset: 0x00093342
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Sequence",
				"Entity"
			};
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x0009515A File Offset: 0x0009335A
		public static ETrackControlMode[] GetValues()
		{
			return new ETrackControlMode[]
			{
				ETrackControlMode.Sequence,
				ETrackControlMode.Entity
			};
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x00095166 File Offset: 0x00093366
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
