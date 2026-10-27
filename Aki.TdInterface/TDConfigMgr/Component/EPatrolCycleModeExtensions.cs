using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C8 RID: 2504
	public static class EPatrolCycleModeExtensions
	{
		// Token: 0x060037B5 RID: 14261 RVA: 0x00090BE4 File Offset: 0x0008EDE4
		public static string ToEnumString(this EPatrolCycleMode value)
		{
			string result;
			if (value != EPatrolCycleMode.Loop)
			{
				if (value != EPatrolCycleMode.Once)
				{
					result = value.ToString();
				}
				else
				{
					result = "Once";
				}
			}
			else
			{
				result = "Loop";
			}
			return result;
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00090C1C File Offset: 0x0008EE1C
		public static EPatrolCycleMode FromString(string name)
		{
			EPatrolCycleMode result;
			if (!EPatrolCycleModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPatrolCycleMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x00090C45 File Offset: 0x0008EE45
		public static bool TryFromString(string name, out EPatrolCycleMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPatrolCycleMode.Loop;
				return false;
			}
			if (name == "Loop")
			{
				value = EPatrolCycleMode.Loop;
				return true;
			}
			if (!(name == "Once"))
			{
				value = EPatrolCycleMode.Loop;
				return false;
			}
			value = EPatrolCycleMode.Once;
			return true;
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00090C7E File Offset: 0x0008EE7E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Loop",
				"Once"
			};
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00090C96 File Offset: 0x0008EE96
		public static EPatrolCycleMode[] GetValues()
		{
			return new EPatrolCycleMode[]
			{
				EPatrolCycleMode.Loop,
				EPatrolCycleMode.Once
			};
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00090CA2 File Offset: 0x0008EEA2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Loop",
				"Once"
			};
		}
	}
}
