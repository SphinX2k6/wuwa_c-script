using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D8 RID: 472
	public class ConfigDangoBrawlDamageShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B13 RID: 2835 RVA: 0x0009BC88 File Offset: 0x00099E88
		static ConfigDangoBrawlDamageShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlDamageShowById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlDamageShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0009BCA8 File Offset: 0x00099EA8
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

		// Token: 0x06000B15 RID: 2837 RVA: 0x0009BD27 File Offset: 0x00099F27
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlDamageShowById.LogPair = null;
			ConfigDangoBrawlDamageShowById.HandleId = 0;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0009BD35 File Offset: 0x00099F35
		public static void Init()
		{
			ConfigDangoBrawlDamageShowById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlDamageShowById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlDamageShow` where Id=?");
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0009BD50 File Offset: 0x00099F50
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

		// Token: 0x04000CCC RID: 3276
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CCD RID: 3277
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000CCE RID: 3278
		private const string TABLE = "DangoBrawlDamageShow";

		// Token: 0x04000CCF RID: 3279
		private const string COMMAND = "select BinData from `DangoBrawlDamageShow` where Id=?";

		// Token: 0x04000CD0 RID: 3280
		private const string KEY_PREFIX = "DangoBrawlDamageShowById";

		// Token: 0x04000CD1 RID: 3281
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CD2 RID: 3282
		private static int HandleId;
	}
}
