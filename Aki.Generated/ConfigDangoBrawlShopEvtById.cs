using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F3 RID: 499
	public class ConfigDangoBrawlShopEvtById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x0009F514 File Offset: 0x0009D714
		static ConfigDangoBrawlShopEvtById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlShopEvtById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlShopEvtById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0009F534 File Offset: 0x0009D734
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlShopEvtById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlShopEvtById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗局内.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlShopEvt"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlShopEvt` where Id=?")
			});
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0009F5B3 File Offset: 0x0009D7B3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlShopEvtById.LogPair = null;
			ConfigDangoBrawlShopEvtById.HandleId = 0;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0009F5C1 File Offset: 0x0009D7C1
		public static void Init()
		{
			ConfigDangoBrawlShopEvtById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlShopEvtById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlShopEvt` where Id=?");
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0009F5DC File Offset: 0x0009D7DC
		public static DangoBrawlShopEvt? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlShopEvtById.HandleId, ConfigDangoBrawlShopEvtById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlShopEvtById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlShopEvt?(DangoBrawlShopEvt.GetRootAsDangoBrawlShopEvt(configBuffer));
				}
			}
			ConfigDangoBrawlShopEvtById.LogPair.Clear();
			ConfigDangoBrawlShopEvtById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlShopEvtById.HandleId, 1, p0Id, ConfigDangoBrawlShopEvtById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlShopEvtById.HandleId, true, ConfigDangoBrawlShopEvtById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlShopEvtById.HandleId, ConfigDangoBrawlShopEvtById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlShopEvtById.HandleId, 0, ConfigDangoBrawlShopEvtById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlShopEvtById.HandleId, ConfigDangoBrawlShopEvtById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlShopEvt rootAsDangoBrawlShopEvt = DangoBrawlShopEvt.GetRootAsDangoBrawlShopEvt(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlShopEvtById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlShopEvtById.HandleId, ConfigDangoBrawlShopEvtById.LogPair);
			return new DangoBrawlShopEvt?(rootAsDangoBrawlShopEvt);
		}

		// Token: 0x04000D89 RID: 3465
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D8A RID: 3466
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000D8B RID: 3467
		private const string TABLE = "DangoBrawlShopEvt";

		// Token: 0x04000D8C RID: 3468
		private const string COMMAND = "select BinData from `DangoBrawlShopEvt` where Id=?";

		// Token: 0x04000D8D RID: 3469
		private const string KEY_PREFIX = "DangoBrawlShopEvtById";

		// Token: 0x04000D8E RID: 3470
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D8F RID: 3471
		private static int HandleId;
	}
}
