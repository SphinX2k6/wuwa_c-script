using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C6 RID: 454
	public class ConfigDangoBrawlDamageShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x00095D50 File Offset: 0x00093F50
		static ConfigDangoBrawlDamageShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlDamageShowById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlDamageShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00095D70 File Offset: 0x00093F70
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlDamageShowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlDamageShowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗战斗.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlDamageShow"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlDamageShow` where Id=?")
			});
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00095DEF File Offset: 0x00093FEF
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlDamageShowById.LogPair = null;
			ConfigDangoBrawlDamageShowById.HandleId = 0;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00095DFD File Offset: 0x00093FFD
		public static void Init()
		{
			ConfigDangoBrawlDamageShowById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlDamageShowById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlDamageShow` where Id=?");
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00095E18 File Offset: 0x00094018
		public static DangoBrawlDamageShow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlDamageShowById.HandleId, ConfigDangoBrawlDamageShowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlDamageShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlDamageShow?(DangoBrawlDamageShow.GetRootAsDangoBrawlDamageShow(configBuffer));
				}
			}
			ConfigDangoBrawlDamageShowById.LogPair.Clear();
			ConfigDangoBrawlDamageShowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlDamageShowById.HandleId, 1, p0Id, ConfigDangoBrawlDamageShowById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlDamageShowById.HandleId, true, ConfigDangoBrawlDamageShowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlDamageShowById.HandleId, ConfigDangoBrawlDamageShowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlDamageShowById.HandleId, 0, ConfigDangoBrawlDamageShowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlDamageShowById.HandleId, ConfigDangoBrawlDamageShowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlDamageShow rootAsDangoBrawlDamageShow = DangoBrawlDamageShow.GetRootAsDangoBrawlDamageShow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlDamageShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlDamageShowById.HandleId, ConfigDangoBrawlDamageShowById.LogPair);
			return new DangoBrawlDamageShow?(rootAsDangoBrawlDamageShow);
		}

		// Token: 0x04000C4E RID: 3150
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C4F RID: 3151
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000C50 RID: 3152
		private const string TABLE = "DangoBrawlDamageShow";

		// Token: 0x04000C51 RID: 3153
		private const string COMMAND = "select BinData from `DangoBrawlDamageShow` where Id=?";

		// Token: 0x04000C52 RID: 3154
		private const string KEY_PREFIX = "DangoBrawlDamageShowById";

		// Token: 0x04000C53 RID: 3155
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C54 RID: 3156
		private static int HandleId;
	}
}
