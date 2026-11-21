using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C4 RID: 5060
	public static class ERoleTowerSystemVarTypeExtensions
	{
		// Token: 0x0600714C RID: 29004 RVA: 0x0010E694 File Offset: 0x0010C894
		public static string ToEnumString(this ERoleTowerSystemVarType value)
		{
			string result;
			switch (value)
			{
			case ERoleTowerSystemVarType.Batch:
				result = "Batch";
				break;
			case ERoleTowerSystemVarType.MaxBatch:
				result = "MaxBatch";
				break;
			case ERoleTowerSystemVarType.IsLastFloor:
				result = "IsLastFloor";
				break;
			case ERoleTowerSystemVarType.CurrentFloorId:
				result = "CurrentFloorId";
				break;
			case ERoleTowerSystemVarType.IsMainRoleDead:
				result = "IsMainRoleDead";
				break;
			case ERoleTowerSystemVarType.IsChallengeTimeExhausted:
				result = "IsChallengeTimeExhausted";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x0010E700 File Offset: 0x0010C900
		public static ERoleTowerSystemVarType FromString(string name)
		{
			ERoleTowerSystemVarType result;
			if (!ERoleTowerSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoleTowerSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x0010E72C File Offset: 0x0010C92C
		public static bool TryFromString(string name, out ERoleTowerSystemVarType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoleTowerSystemVarType.Batch;
				return false;
			}
			if (name == "Batch")
			{
				value = ERoleTowerSystemVarType.Batch;
				return true;
			}
			if (name == "MaxBatch")
			{
				value = ERoleTowerSystemVarType.MaxBatch;
				return true;
			}
			if (name == "IsLastFloor")
			{
				value = ERoleTowerSystemVarType.IsLastFloor;
				return true;
			}
			if (name == "CurrentFloorId")
			{
				value = ERoleTowerSystemVarType.CurrentFloorId;
				return true;
			}
			if (name == "IsMainRoleDead")
			{
				value = ERoleTowerSystemVarType.IsMainRoleDead;
				return true;
			}
			if (!(name == "IsChallengeTimeExhausted"))
			{
				value = ERoleTowerSystemVarType.Batch;
				return false;
			}
			value = ERoleTowerSystemVarType.IsChallengeTimeExhausted;
			return true;
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x0010E7B8 File Offset: 0x0010C9B8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Batch",
				"MaxBatch",
				"IsLastFloor",
				"CurrentFloorId",
				"IsMainRoleDead",
				"IsChallengeTimeExhausted"
			};
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x0010E7F0 File Offset: 0x0010C9F0
		public static ERoleTowerSystemVarType[] GetValues()
		{
			return new ERoleTowerSystemVarType[]
			{
				ERoleTowerSystemVarType.Batch,
				ERoleTowerSystemVarType.MaxBatch,
				ERoleTowerSystemVarType.IsLastFloor,
				ERoleTowerSystemVarType.CurrentFloorId,
				ERoleTowerSystemVarType.IsMainRoleDead,
				ERoleTowerSystemVarType.IsChallengeTimeExhausted
			};
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x0010E803 File Offset: 0x0010CA03
		public static string[] GetNames()
		{
			return new string[]
			{
				"Batch",
				"MaxBatch",
				"IsLastFloor",
				"CurrentFloorId",
				"IsMainRoleDead",
				"IsChallengeTimeExhausted"
			};
		}
	}
}
