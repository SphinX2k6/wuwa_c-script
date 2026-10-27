using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D1 RID: 465
	public class ConfigDangoBrawlLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x00097398 File Offset: 0x00095598
		static ConfigDangoBrawlLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlLevelById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x000973B8 File Offset: 0x000955B8
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawllevel.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/DangoBrawlLevel.csv"),
				new ValueTuple<string, object>("表名", "DangoBrawlLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlLevel` where Id=?")
			});
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00097437 File Offset: 0x00095637
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlLevelById.LogPair = null;
			ConfigDangoBrawlLevelById.HandleId = 0;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00097445 File Offset: 0x00095645
		public static void Init()
		{
			ConfigDangoBrawlLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlLevelById.HandleId, "db_dangobrawllevel.db", "select BinData from `DangoBrawlLevel` where Id=?");
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00097460 File Offset: 0x00095660
		public static DangoBrawlLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlLevelById.HandleId, ConfigDangoBrawlLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlLevel?(DangoBrawlLevel.GetRootAsDangoBrawlLevel(configBuffer));
				}
			}
			ConfigDangoBrawlLevelById.LogPair.Clear();
			ConfigDangoBrawlLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlLevelById.HandleId, 1, p0Id, ConfigDangoBrawlLevelById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlLevelById.HandleId, true, ConfigDangoBrawlLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlLevelById.HandleId, ConfigDangoBrawlLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlLevelById.HandleId, 0, ConfigDangoBrawlLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlLevelById.HandleId, ConfigDangoBrawlLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlLevel rootAsDangoBrawlLevel = DangoBrawlLevel.GetRootAsDangoBrawlLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlLevelById.HandleId, ConfigDangoBrawlLevelById.LogPair);
			return new DangoBrawlLevel?(rootAsDangoBrawlLevel);
		}

		// Token: 0x04000C9B RID: 3227
		private const string DB = "db_dangobrawllevel.db";

		// Token: 0x04000C9C RID: 3228
		private const string FILE = "UniverseEditor/DangoBrawlLevel.csv";

		// Token: 0x04000C9D RID: 3229
		private const string TABLE = "DangoBrawlLevel";

		// Token: 0x04000C9E RID: 3230
		private const string COMMAND = "select BinData from `DangoBrawlLevel` where Id=?";

		// Token: 0x04000C9F RID: 3231
		private const string KEY_PREFIX = "DangoBrawlLevelById";

		// Token: 0x04000CA0 RID: 3232
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CA1 RID: 3233
		private static int HandleId;
	}
}
