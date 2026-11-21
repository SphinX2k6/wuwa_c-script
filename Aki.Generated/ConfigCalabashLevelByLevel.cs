using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000146 RID: 326
	public class ConfigCalabashLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x0008874F File Offset: 0x0008694F
		static ConfigCalabashLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashLevelByLevel.CreateStaticDefaultValue), new Action(ConfigCalabashLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00088770 File Offset: 0x00086970
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashLevelByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashLevelByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashLevel` where Level=?")
			});
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000887EF File Offset: 0x000869EF
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashLevelByLevel.LogPair = null;
			ConfigCalabashLevelByLevel.HandleId = 0;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000887FD File Offset: 0x000869FD
		public static void Init()
		{
			ConfigCalabashLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashLevelByLevel.HandleId, "db_calabash.db", "select BinData from `CalabashLevel` where Level=?");
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00088818 File Offset: 0x00086A18
		public static CalabashLevel? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashLevelByLevel.HandleId, ConfigCalabashLevelByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashLevel?(CalabashLevel.GetRootAsCalabashLevel(configBuffer));
				}
			}
			ConfigCalabashLevelByLevel.LogPair.Clear();
			ConfigCalabashLevelByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigCalabashLevelByLevel.HandleId, 1, p0Level, ConfigCalabashLevelByLevel.LogPair) || ConfigCommon.Step(ConfigCalabashLevelByLevel.HandleId, true, ConfigCalabashLevelByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashLevelByLevel.HandleId, ConfigCalabashLevelByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashLevelByLevel.HandleId, 0, ConfigCalabashLevelByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashLevelByLevel.HandleId, ConfigCalabashLevelByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashLevel rootAsCalabashLevel = CalabashLevel.GetRootAsCalabashLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashLevelByLevel.HandleId, ConfigCalabashLevelByLevel.LogPair);
			return new CalabashLevel?(rootAsCalabashLevel);
		}

		// Token: 0x040008CE RID: 2254
		private const string DB = "db_calabash.db";

		// Token: 0x040008CF RID: 2255
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008D0 RID: 2256
		private const string TABLE = "CalabashLevel";

		// Token: 0x040008D1 RID: 2257
		private const string COMMAND = "select BinData from `CalabashLevel` where Level=?";

		// Token: 0x040008D2 RID: 2258
		private const string KEY_PREFIX = "CalabashLevelByLevel";

		// Token: 0x040008D3 RID: 2259
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008D4 RID: 2260
		private static int HandleId;
	}
}
