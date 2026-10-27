using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001284 RID: 4740
	public static class ERoleTowerSystemVarTypeExtensions
	{
		// Token: 0x06006AF9 RID: 27385 RVA: 0x00100A68 File Offset: 0x000FEC68
		public static string ToEnumString(this ERoleTowerSystemVarType value)
		{
			string result;
			if (value != ERoleTowerSystemVarType.Batch)
			{
				if (value != ERoleTowerSystemVarType.MaxBatch)
				{
					result = value.ToString();
				}
				else
				{
					result = "MaxBatch";
				}
			}
			else
			{
				result = "Batch";
			}
			return result;
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x00100AA0 File Offset: 0x000FECA0
		public static ERoleTowerSystemVarType FromString(string name)
		{
			ERoleTowerSystemVarType result;
			if (!ERoleTowerSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoleTowerSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00100AC9 File Offset: 0x000FECC9
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
			if (!(name == "MaxBatch"))
			{
				value = ERoleTowerSystemVarType.Batch;
				return false;
			}
			value = ERoleTowerSystemVarType.MaxBatch;
			return true;
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x00100B02 File Offset: 0x000FED02
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Batch",
				"MaxBatch"
			};
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x00100B1A File Offset: 0x000FED1A
		public static ERoleTowerSystemVarType[] GetValues()
		{
			return new ERoleTowerSystemVarType[]
			{
				ERoleTowerSystemVarType.Batch,
				ERoleTowerSystemVarType.MaxBatch
			};
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x00100B26 File Offset: 0x000FED26
		public static string[] GetNames()
		{
			return new string[]
			{
				"Batch",
				"MaxBatch"
			};
		}
	}
}
