using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DA RID: 2266
	public class ConfigRougePopularEntrieById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600352F RID: 13615 RVA: 0x00185F7B File Offset: 0x0018417B
		static ConfigRougePopularEntrieById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougePopularEntrieById.CreateStaticDefaultValue), new Action(ConfigRougePopularEntrieById.ResetStaticDefaultValue));
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x00185F9C File Offset: 0x0018419C
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

		// Token: 0x06003531 RID: 13617 RVA: 0x0018601B File Offset: 0x0018421B
		public static void ResetStaticDefaultValue()
		{
			ConfigRougePopularEntrieById.LogPair = null;
			ConfigRougePopularEntrieById.HandleId = 0;
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00186029 File Offset: 0x00184229
		public static void Init()
		{
			ConfigRougePopularEntrieById.HandleId = ConfigCommon.InitDataStatement(ConfigRougePopularEntrieById.HandleId, "db_rogue.db", "select BinData from `RougePopularEntrie` where Id=?");
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00186044 File Offset: 0x00184244
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

		// Token: 0x04003DDC RID: 15836
		private const string DB = "db_rogue.db";

		// Token: 0x04003DDD RID: 15837
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003DDE RID: 15838
		private const string TABLE = "RougePopularEntrie";

		// Token: 0x04003DDF RID: 15839
		private const string COMMAND = "select BinData from `RougePopularEntrie` where Id=?";

		// Token: 0x04003DE0 RID: 15840
		private const string KEY_PREFIX = "RougePopularEntrieById";

		// Token: 0x04003DE1 RID: 15841
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DE2 RID: 15842
		private static int HandleId;
	}
}
