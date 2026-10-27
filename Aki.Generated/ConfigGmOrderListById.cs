using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A6 RID: 934
	public class ConfigGmOrderListById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015EB RID: 5611 RVA: 0x000D5683 File Offset: 0x000D3883
		static ConfigGmOrderListById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmOrderListById.CreateStaticDefaultValue), new Action(ConfigGmOrderListById.ResetStaticDefaultValue));
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000D56A4 File Offset: 0x000D38A4
		public static void CreateStaticDefaultValue()
		{
			ConfigGmOrderListById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmOrderListById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmOrderList"),
				new ValueTuple<string, object>("语句", "select BinData from `GmOrderList` where Id=?")
			});
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000D5723 File Offset: 0x000D3923
		public static void ResetStaticDefaultValue()
		{
			ConfigGmOrderListById.LogPair = null;
			ConfigGmOrderListById.HandleId = 0;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000D5731 File Offset: 0x000D3931
		public static void Init()
		{
			ConfigGmOrderListById.HandleId = ConfigCommon.InitDataStatement(ConfigGmOrderListById.HandleId, "db_gm.db", "select BinData from `GmOrderList` where Id=?");
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000D574C File Offset: 0x000D394C
		public static GmOrderList? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmOrderListById.HandleId, ConfigGmOrderListById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmOrderListById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GmOrderList?(GmOrderList.GetRootAsGmOrderList(configBuffer));
				}
			}
			ConfigGmOrderListById.LogPair.Clear();
			ConfigGmOrderListById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGmOrderListById.HandleId, 1, p0Id, ConfigGmOrderListById.LogPair) || ConfigCommon.Step(ConfigGmOrderListById.HandleId, true, ConfigGmOrderListById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGmOrderListById.HandleId, ConfigGmOrderListById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmOrderListById.HandleId, 0, ConfigGmOrderListById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGmOrderListById.HandleId, ConfigGmOrderListById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GmOrderList rootAsGmOrderList = GmOrderList.GetRootAsGmOrderList(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmOrderListById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGmOrderListById.HandleId, ConfigGmOrderListById.LogPair);
			return new GmOrderList?(rootAsGmOrderList);
		}

		// Token: 0x0400196E RID: 6510
		private const string DB = "db_gm.db";

		// Token: 0x0400196F RID: 6511
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001970 RID: 6512
		private const string TABLE = "GmOrderList";

		// Token: 0x04001971 RID: 6513
		private const string COMMAND = "select BinData from `GmOrderList` where Id=?";

		// Token: 0x04001972 RID: 6514
		private const string KEY_PREFIX = "GmOrderListById";

		// Token: 0x04001973 RID: 6515
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001974 RID: 6516
		private static int HandleId;
	}
}
