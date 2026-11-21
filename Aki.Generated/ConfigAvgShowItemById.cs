using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C9 RID: 201
	public class ConfigAvgShowItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004B7 RID: 1207 RVA: 0x00077F89 File Offset: 0x00076189
		static ConfigAvgShowItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgShowItemById.CreateStaticDefaultValue), new Action(ConfigAvgShowItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00077FA8 File Offset: 0x000761A8
		public static void CreateStaticDefaultValue()
		{
			ConfigAvgShowItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvgShowItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avgshowitem.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.Avg展示物品/*.csv*"),
				new ValueTuple<string, object>("表名", "AvgShowItem"),
				new ValueTuple<string, object>("语句", "select BinData from `AvgShowItem` where Id=?")
			});
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00078027 File Offset: 0x00076227
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgShowItemById.LogPair = null;
			ConfigAvgShowItemById.HandleId = 0;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00078035 File Offset: 0x00076235
		public static void Init()
		{
			ConfigAvgShowItemById.HandleId = ConfigCommon.InitDataStatement(ConfigAvgShowItemById.HandleId, "db_avgshowitem.db", "select BinData from `AvgShowItem` where Id=?");
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00078050 File Offset: 0x00076250
		public static AvgShowItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvgShowItemById.HandleId, ConfigAvgShowItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgShowItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvgShowItem?(AvgShowItem.GetRootAsAvgShowItem(configBuffer));
				}
			}
			ConfigAvgShowItemById.LogPair.Clear();
			ConfigAvgShowItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvgShowItemById.HandleId, 1, p0Id, ConfigAvgShowItemById.LogPair) || ConfigCommon.Step(ConfigAvgShowItemById.HandleId, true, ConfigAvgShowItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvgShowItemById.HandleId, ConfigAvgShowItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvgShowItemById.HandleId, 0, ConfigAvgShowItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvgShowItemById.HandleId, ConfigAvgShowItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvgShowItem rootAsAvgShowItem = AvgShowItem.GetRootAsAvgShowItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgShowItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvgShowItemById.HandleId, ConfigAvgShowItemById.LogPair);
			return new AvgShowItem?(rootAsAvgShowItem);
		}

		// Token: 0x04000563 RID: 1379
		private const string DB = "db_avgshowitem.db";

		// Token: 0x04000564 RID: 1380
		private const string FILE = "k.可视化编辑/c.Csv/a.Avg展示物品/*.csv*";

		// Token: 0x04000565 RID: 1381
		private const string TABLE = "AvgShowItem";

		// Token: 0x04000566 RID: 1382
		private const string COMMAND = "select BinData from `AvgShowItem` where Id=?";

		// Token: 0x04000567 RID: 1383
		private const string KEY_PREFIX = "AvgShowItemById";

		// Token: 0x04000568 RID: 1384
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000569 RID: 1385
		private static int HandleId;
	}
}
