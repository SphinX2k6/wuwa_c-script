using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F4 RID: 1268
	public class ConfigLordGymByDifficulty : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DC3 RID: 7619 RVA: 0x001017BF File Offset: 0x000FF9BF
		static ConfigLordGymByDifficulty()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymByDifficulty.CreateStaticDefaultValue), new Action(ConfigLordGymByDifficulty.ResetStaticDefaultValue));
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x001017E0 File Offset: 0x000FF9E0
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

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0010185F File Offset: 0x000FFA5F
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymByDifficulty.LogPair = null;
			ConfigLordGymByDifficulty.HandleId = 0;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0010186D File Offset: 0x000FFA6D
		public static void Init()
		{
			ConfigLordGymByDifficulty.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymByDifficulty.HandleId, "db_lordgym.db", "select BinData from `LordGym` where Difficulty=?");
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00101888 File Offset: 0x000FFA88
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

		// Token: 0x04002290 RID: 8848
		private const string DB = "db_lordgym.db";

		// Token: 0x04002291 RID: 8849
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002292 RID: 8850
		private const string TABLE = "LordGym";

		// Token: 0x04002293 RID: 8851
		private const string COMMAND = "select BinData from `LordGym` where Difficulty=?";

		// Token: 0x04002294 RID: 8852
		private const string KEY_PREFIX = "LordGymByDifficulty";

		// Token: 0x04002295 RID: 8853
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002296 RID: 8854
		private static int HandleId;
	}
}
