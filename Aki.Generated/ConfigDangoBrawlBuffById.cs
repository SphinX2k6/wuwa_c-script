using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C4 RID: 452
	public class ConfigDangoBrawlBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A9B RID: 2715 RVA: 0x000958BF File Offset: 0x00093ABF
		static ConfigDangoBrawlBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlBuffById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000958E0 File Offset: 0x00093AE0
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗战斗.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlBuff` where Id=?")
			});
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0009595F File Offset: 0x00093B5F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlBuffById.LogPair = null;
			ConfigDangoBrawlBuffById.HandleId = 0;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0009596D File Offset: 0x00093B6D
		public static void Init()
		{
			ConfigDangoBrawlBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlBuffById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlBuff` where Id=?");
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00095988 File Offset: 0x00093B88
		public static DangoBrawlBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlBuffById.HandleId, ConfigDangoBrawlBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlBuff?(DangoBrawlBuff.GetRootAsDangoBrawlBuff(configBuffer));
				}
			}
			ConfigDangoBrawlBuffById.LogPair.Clear();
			ConfigDangoBrawlBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlBuffById.HandleId, 1, p0Id, ConfigDangoBrawlBuffById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlBuffById.HandleId, true, ConfigDangoBrawlBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlBuffById.HandleId, ConfigDangoBrawlBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlBuffById.HandleId, 0, ConfigDangoBrawlBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlBuffById.HandleId, ConfigDangoBrawlBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlBuff rootAsDangoBrawlBuff = DangoBrawlBuff.GetRootAsDangoBrawlBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlBuffById.HandleId, ConfigDangoBrawlBuffById.LogPair);
			return new DangoBrawlBuff?(rootAsDangoBrawlBuff);
		}

		// Token: 0x04000C40 RID: 3136
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C41 RID: 3137
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000C42 RID: 3138
		private const string TABLE = "DangoBrawlBuff";

		// Token: 0x04000C43 RID: 3139
		private const string COMMAND = "select BinData from `DangoBrawlBuff` where Id=?";

		// Token: 0x04000C44 RID: 3140
		private const string KEY_PREFIX = "DangoBrawlBuffById";

		// Token: 0x04000C45 RID: 3141
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C46 RID: 3142
		private static int HandleId;
	}
}
