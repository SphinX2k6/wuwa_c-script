using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A89 RID: 2697
	public static class EPatrolCycleModeExtensions
	{
		// Token: 0x06003B7B RID: 15227 RVA: 0x000992B4 File Offset: 0x000974B4
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

		// Token: 0x06003B7C RID: 15228 RVA: 0x000992EC File Offset: 0x000974EC
		public static EPatrolCycleMode FromString(string name)
		{
			EPatrolCycleMode result;
			if (!EPatrolCycleModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPatrolCycleMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x00099315 File Offset: 0x00097515
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

		// Token: 0x06003B7E RID: 15230 RVA: 0x0009934E File Offset: 0x0009754E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Loop",
				"Once"
			};
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x00099366 File Offset: 0x00097566
		public static EPatrolCycleMode[] GetValues()
		{
			return new EPatrolCycleMode[]
			{
				EPatrolCycleMode.Loop,
				EPatrolCycleMode.Once
			};
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x00099372 File Offset: 0x00097572
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
