using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E3 RID: 483
	public class ConfigDangoBrawlLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x0009D2D0 File Offset: 0x0009B4D0
		static ConfigDangoBrawlLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlLevelById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0009D2F0 File Offset: 0x0009B4F0
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

		// Token: 0x06000B57 RID: 2903 RVA: 0x0009D36F File Offset: 0x0009B56F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlLevelById.LogPair = null;
			ConfigDangoBrawlLevelById.HandleId = 0;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0009D37D File Offset: 0x0009B57D
		public static void Init()
		{
			ConfigDangoBrawlLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlLevelById.HandleId, "db_dangobrawllevel.db", "select BinData from `DangoBrawlLevel` where Id=?");
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0009D398 File Offset: 0x0009B598
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

		// Token: 0x04000D19 RID: 3353
		private const string DB = "db_dangobrawllevel.db";

		// Token: 0x04000D1A RID: 3354
		private const string FILE = "UniverseEditor/DangoBrawlLevel.csv";

		// Token: 0x04000D1B RID: 3355
		private const string TABLE = "DangoBrawlLevel";

		// Token: 0x04000D1C RID: 3356
		private const string COMMAND = "select BinData from `DangoBrawlLevel` where Id=?";

		// Token: 0x04000D1D RID: 3357
		private const string KEY_PREFIX = "DangoBrawlLevelById";

		// Token: 0x04000D1E RID: 3358
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D1F RID: 3359
		private static int HandleId;
	}
}
