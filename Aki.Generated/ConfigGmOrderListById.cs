using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BC RID: 956
	public class ConfigGmOrderListById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600166F RID: 5743 RVA: 0x000DBDD7 File Offset: 0x000D9FD7
		static ConfigGmOrderListById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmOrderListById.CreateStaticDefaultValue), new Action(ConfigGmOrderListById.ResetStaticDefaultValue));
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000DBDF8 File Offset: 0x000D9FF8
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

		// Token: 0x06001671 RID: 5745 RVA: 0x000DBE77 File Offset: 0x000DA077
		public static void ResetStaticDefaultValue()
		{
			ConfigGmOrderListById.LogPair = null;
			ConfigGmOrderListById.HandleId = 0;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000DBE85 File Offset: 0x000DA085
		public static void Init()
		{
			ConfigGmOrderListById.HandleId = ConfigCommon.InitDataStatement(ConfigGmOrderListById.HandleId, "db_gm.db", "select BinData from `GmOrderList` where Id=?");
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000DBEA0 File Offset: 0x000DA0A0
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

		// Token: 0x04001A08 RID: 6664
		private const string DB = "db_gm.db";

		// Token: 0x04001A09 RID: 6665
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001A0A RID: 6666
		private const string TABLE = "GmOrderList";

		// Token: 0x04001A0B RID: 6667
		private const string COMMAND = "select BinData from `GmOrderList` where Id=?";

		// Token: 0x04001A0C RID: 6668
		private const string KEY_PREFIX = "GmOrderListById";

		// Token: 0x04001A0D RID: 6669
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A0E RID: 6670
		private static int HandleId;
	}
}
