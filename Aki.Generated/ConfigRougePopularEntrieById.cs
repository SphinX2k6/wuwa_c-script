using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000925 RID: 2341
	public class ConfigRougePopularEntrieById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036F1 RID: 14065 RVA: 0x0019319B File Offset: 0x0019139B
		static ConfigRougePopularEntrieById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougePopularEntrieById.CreateStaticDefaultValue), new Action(ConfigRougePopularEntrieById.ResetStaticDefaultValue));
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x001931BC File Offset: 0x001913BC
		public static void CreateStaticDefaultValue()
		{
			ConfigRougePopularEntrieById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRougePopularEntrieById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RougePopularEntrie"),
				new ValueTuple<string, object>("语句", "select BinData from `RougePopularEntrie` where Id=?")
			});
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x0019323B File Offset: 0x0019143B
		public static void ResetStaticDefaultValue()
		{
			ConfigRougePopularEntrieById.LogPair = null;
			ConfigRougePopularEntrieById.HandleId = 0;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00193249 File Offset: 0x00191449
		public static void Init()
		{
			ConfigRougePopularEntrieById.HandleId = ConfigCommon.InitDataStatement(ConfigRougePopularEntrieById.HandleId, "db_rogue.db", "select BinData from `RougePopularEntrie` where Id=?");
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00193264 File Offset: 0x00191464
		public static RougePopularEntrie? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRougePopularEntrieById.HandleId, ConfigRougePopularEntrieById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougePopularEntrieById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RougePopularEntrie?(RougePopularEntrie.GetRootAsRougePopularEntrie(configBuffer));
				}
			}
			ConfigRougePopularEntrieById.LogPair.Clear();
			ConfigRougePopularEntrieById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRougePopularEntrieById.HandleId, 1, p0Id, ConfigRougePopularEntrieById.LogPair) || ConfigCommon.Step(ConfigRougePopularEntrieById.HandleId, true, ConfigRougePopularEntrieById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRougePopularEntrieById.HandleId, ConfigRougePopularEntrieById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRougePopularEntrieById.HandleId, 0, ConfigRougePopularEntrieById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRougePopularEntrieById.HandleId, ConfigRougePopularEntrieById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RougePopularEntrie rootAsRougePopularEntrie = RougePopularEntrie.GetRootAsRougePopularEntrie(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougePopularEntrieById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRougePopularEntrieById.HandleId, ConfigRougePopularEntrieById.LogPair);
			return new RougePopularEntrie?(rootAsRougePopularEntrie);
		}

		// Token: 0x04003FE9 RID: 16361
		private const string DB = "db_rogue.db";

		// Token: 0x04003FEA RID: 16362
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003FEB RID: 16363
		private const string TABLE = "RougePopularEntrie";

		// Token: 0x04003FEC RID: 16364
		private const string COMMAND = "select BinData from `RougePopularEntrie` where Id=?";

		// Token: 0x04003FED RID: 16365
		private const string KEY_PREFIX = "RougePopularEntrieById";

		// Token: 0x04003FEE RID: 16366
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FEF RID: 16367
		private static int HandleId;
	}
}
