using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E1 RID: 481
	public class ConfigDangoBrawlShopEvtById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x000995DC File Offset: 0x000977DC
		static ConfigDangoBrawlShopEvtById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlShopEvtById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlShopEvtById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000995FC File Offset: 0x000977FC
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

		// Token: 0x06000B4B RID: 2891 RVA: 0x0009967B File Offset: 0x0009787B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlShopEvtById.LogPair = null;
			ConfigDangoBrawlShopEvtById.HandleId = 0;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00099689 File Offset: 0x00097889
		public static void Init()
		{
			ConfigDangoBrawlShopEvtById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlShopEvtById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlShopEvt` where Id=?");
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000996A4 File Offset: 0x000978A4
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

		// Token: 0x04000D0B RID: 3339
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D0C RID: 3340
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000D0D RID: 3341
		private const string TABLE = "DangoBrawlShopEvt";

		// Token: 0x04000D0E RID: 3342
		private const string COMMAND = "select BinData from `DangoBrawlShopEvt` where Id=?";

		// Token: 0x04000D0F RID: 3343
		private const string KEY_PREFIX = "DangoBrawlShopEvtById";

		// Token: 0x04000D10 RID: 3344
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D11 RID: 3345
		private static int HandleId;
	}
}
