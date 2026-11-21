using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F0 RID: 9712
	public static class ELiveForceDanmakuStateExtensions
	{
		// Token: 0x0600D212 RID: 53778 RVA: 0x001E8A88 File Offset: 0x001E6C88
		public static string ToEnumString(this ELiveForceDanmakuState value)
		{
			string result;
			if (value != ELiveForceDanmakuState.Force)
			{
				if (value != ELiveForceDanmakuState.Release)
				{
					result = value.ToString();
				}
				else
				{
					result = "Release";
				}
			}
			else
			{
				result = "Force";
			}
			return result;
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x001E8AC0 File Offset: 0x001E6CC0
		public static ELiveForceDanmakuState FromString(string name)
		{
			ELiveForceDanmakuState result;
			if (!ELiveForceDanmakuStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveForceDanmakuState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D214 RID: 53780 RVA: 0x001E8AE9 File Offset: 0x001E6CE9
		public static bool TryFromString(string name, out ELiveForceDanmakuState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveForceDanmakuState.Force;
				return false;
			}
			if (name == "Force")
			{
				value = ELiveForceDanmakuState.Force;
				return true;
			}
			if (!(name == "Release"))
			{
				value = ELiveForceDanmakuState.Force;
				return false;
			}
			value = ELiveForceDanmakuState.Release;
			return true;
		}

		// Token: 0x0600D215 RID: 53781 RVA: 0x001E8B22 File Offset: 0x001E6D22
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Force",
				"Release"
			};
		}

		// Token: 0x0600D216 RID: 53782 RVA: 0x001E8B3A File Offset: 0x001E6D3A
		public static ELiveForceDanmakuState[] GetValues()
		{
			return new ELiveForceDanmakuState[]
			{
				ELiveForceDanmakuState.Force,
				ELiveForceDanmakuState.Release
			};
		}

		// Token: 0x0600D217 RID: 53783 RVA: 0x001E8B46 File Offset: 0x001E6D46
		public static string[] GetNames()
		{
			return new string[]
			{
				"Force",
				"Release"
			};
		}
	}
}
