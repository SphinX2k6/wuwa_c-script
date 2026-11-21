using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050A RID: 1290
	public class ConfigLordGymByDifficulty : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E47 RID: 7751 RVA: 0x00107F13 File Offset: 0x00106113
		static ConfigLordGymByDifficulty()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymByDifficulty.CreateStaticDefaultValue), new Action(ConfigLordGymByDifficulty.ResetStaticDefaultValue));
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00107F34 File Offset: 0x00106134
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymByDifficulty.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymByDifficulty.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGym"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGym` where Difficulty=?")
			});
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00107FB3 File Offset: 0x001061B3
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymByDifficulty.LogPair = null;
			ConfigLordGymByDifficulty.HandleId = 0;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00107FC1 File Offset: 0x001061C1
		public static void Init()
		{
			ConfigLordGymByDifficulty.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymByDifficulty.HandleId, "db_lordgym.db", "select BinData from `LordGym` where Difficulty=?");
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00107FDC File Offset: 0x001061DC
		[NullableContext(2)]
		public static IReadOnlyList<LordGym> GetConfigList(int p0Difficulty, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymByDifficulty.HandleId, ConfigLordGymByDifficulty.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymByDifficulty");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Difficulty);
				IReadOnlyList<LordGym> readOnlyList = (IReadOnlyList<LordGym>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLordGymByDifficulty.LogPair.Clear();
			ConfigLordGymByDifficulty.LogPair.Add(new ValueTuple<string, object>("Difficulty", p0Difficulty));
			if (!ConfigCommon.BindInt(ConfigLordGymByDifficulty.HandleId, 1, p0Difficulty, ConfigLordGymByDifficulty.LogPair))
			{
				ConfigCommon.Reset(ConfigLordGymByDifficulty.HandleId, ConfigLordGymByDifficulty.LogPair);
				return null;
			}
			List<LordGym> list = new List<LordGym>();
			while (ConfigCommon.Step(ConfigLordGymByDifficulty.HandleId, false, ConfigLordGymByDifficulty.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymByDifficulty.HandleId, 0, ConfigLordGymByDifficulty.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLordGymByDifficulty.HandleId, ConfigLordGymByDifficulty.LogPair);
					return null;
				}
				LordGym rootAsLordGym = LordGym.GetRootAsLordGym(new ByteBuffer(item2));
				list.Add(rootAsLordGym);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymByDifficulty");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Difficulty);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigLordGymByDifficulty.HandleId, ConfigLordGymByDifficulty.LogPair);
			return list;
		}

		// Token: 0x0400232A RID: 9002
		private const string DB = "db_lordgym.db";

		// Token: 0x0400232B RID: 9003
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x0400232C RID: 9004
		private const string TABLE = "LordGym";

		// Token: 0x0400232D RID: 9005
		private const string COMMAND = "select BinData from `LordGym` where Difficulty=?";

		// Token: 0x0400232E RID: 9006
		private const string KEY_PREFIX = "LordGymByDifficulty";

		// Token: 0x0400232F RID: 9007
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002330 RID: 9008
		private static int HandleId;
	}
}
