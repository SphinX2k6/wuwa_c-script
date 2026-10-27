using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000957 RID: 2391
	public class ConfigSlashBuffToItemByItemIdAndSeason : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600381D RID: 14365 RVA: 0x00196C6C File Offset: 0x00194E6C
		static ConfigSlashBuffToItemByItemIdAndSeason()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemByItemIdAndSeason.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemByItemIdAndSeason.ResetStaticDefaultValue));
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00196C8C File Offset: 0x00194E8C
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

		// Token: 0x0600381F RID: 14367 RVA: 0x00196D0B File Offset: 0x00194F0B
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemIdAndSeason.LogPair = null;
			ConfigSlashBuffToItemByItemIdAndSeason.HandleId = 0;
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00196D19 File Offset: 0x00194F19
		public static void Init()
		{
			ConfigSlashBuffToItemByItemIdAndSeason.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemByItemIdAndSeason.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where ItemId=? AND Season=?");
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00196D34 File Offset: 0x00194F34
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

		// Token: 0x04004147 RID: 16711
		private const string DB = "db_shiptower.db";

		// Token: 0x04004148 RID: 16712
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004149 RID: 16713
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x0400414A RID: 16714
		private const string COMMAND = "select BinData from `SlashBuffToItem` where ItemId=? AND Season=?";

		// Token: 0x0400414B RID: 16715
		private const string KEY_PREFIX = "SlashBuffToItemByItemIdAndSeason";

		// Token: 0x0400414C RID: 16716
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400414D RID: 16717
		private static int HandleId;
	}
}
