using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A2 RID: 2466
	public class ConfigSlashBuffToItemByItemIdAndSeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039DF RID: 14815 RVA: 0x001A3E8C File Offset: 0x001A208C
		static ConfigSlashBuffToItemByItemIdAndSeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemByItemIdAndSeason.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemByItemIdAndSeason.ResetStaticDefaultValue));
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x001A3EAC File Offset: 0x001A20AC
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemIdAndSeason.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashBuffToItemByItemIdAndSeason.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashBuffToItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashBuffToItem` where ItemId=? AND Season=?")
			});
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x001A3F2B File Offset: 0x001A212B
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemIdAndSeason.LogPair = null;
			ConfigSlashBuffToItemByItemIdAndSeason.HandleId = 0;
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x001A3F39 File Offset: 0x001A2139
		public static void Init()
		{
			ConfigSlashBuffToItemByItemIdAndSeason.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where ItemId=? AND Season=?");
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x001A3F54 File Offset: 0x001A2154
		public static SlashBuffToItem? GetConfig(int p0ItemId, int p1Season, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, ConfigSlashBuffToItemByItemIdAndSeason.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemByItemIdAndSeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Season);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SlashBuffToItem?(SlashBuffToItem.GetRootAsSlashBuffToItem(configBuffer));
				}
			}
			ConfigSlashBuffToItemByItemIdAndSeason.LogPair.Clear();
			ConfigSlashBuffToItemByItemIdAndSeason.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			ConfigSlashBuffToItemByItemIdAndSeason.LogPair.Add(new ValueTuple<string, object>("Season", p1Season));
			if (!ConfigCommon.BindInt(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, 1, p0ItemId, ConfigSlashBuffToItemByItemIdAndSeason.LogPair) || !ConfigCommon.BindInt(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, 2, p1Season, ConfigSlashBuffToItemByItemIdAndSeason.LogPair) || ConfigCommon.Step(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, true, ConfigSlashBuffToItemByItemIdAndSeason.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, ConfigSlashBuffToItemByItemIdAndSeason.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, 0, ConfigSlashBuffToItemByItemIdAndSeason.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, ConfigSlashBuffToItemByItemIdAndSeason.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SlashBuffToItem rootAsSlashBuffToItem = SlashBuffToItem.GetRootAsSlashBuffToItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemByItemIdAndSeason");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Season);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, ConfigSlashBuffToItemByItemIdAndSeason.LogPair);
			return new SlashBuffToItem?(rootAsSlashBuffToItem);
		}

		// Token: 0x04004354 RID: 17236
		private const string DB = "db_shiptower.db";

		// Token: 0x04004355 RID: 17237
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004356 RID: 17238
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004357 RID: 17239
		private const string COMMAND = "select BinData from `SlashBuffToItem` where ItemId=? AND Season=?";

		// Token: 0x04004358 RID: 17240
		private const string KEY_PREFIX = "SlashBuffToItemByItemIdAndSeason";

		// Token: 0x04004359 RID: 17241
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400435A RID: 17242
		private static int HandleId;
	}
}
