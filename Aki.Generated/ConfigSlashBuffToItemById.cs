using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000955 RID: 2389
	public class ConfigSlashBuffToItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003811 RID: 14353 RVA: 0x001967DB File Offset: 0x001949DB
		static ConfigSlashBuffToItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemById.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x001967FC File Offset: 0x001949FC
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashBuffToItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashBuffToItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashBuffToItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashBuffToItem` where Id=?")
			});
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0019687B File Offset: 0x00194A7B
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemById.LogPair = null;
			ConfigSlashBuffToItemById.HandleId = 0;
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00196889 File Offset: 0x00194A89
		public static void Init()
		{
			ConfigSlashBuffToItemById.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemById.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where Id=?");
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x001968A4 File Offset: 0x00194AA4
		public static SlashBuffToItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashBuffToItemById.HandleId, ConfigSlashBuffToItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SlashBuffToItem?(SlashBuffToItem.GetRootAsSlashBuffToItem(configBuffer));
				}
			}
			ConfigSlashBuffToItemById.LogPair.Clear();
			ConfigSlashBuffToItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSlashBuffToItemById.HandleId, 1, p0Id, ConfigSlashBuffToItemById.LogPair) || ConfigCommon.Step(ConfigSlashBuffToItemById.HandleId, true, ConfigSlashBuffToItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSlashBuffToItemById.HandleId, ConfigSlashBuffToItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashBuffToItemById.HandleId, 0, ConfigSlashBuffToItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSlashBuffToItemById.HandleId, ConfigSlashBuffToItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SlashBuffToItem rootAsSlashBuffToItem = SlashBuffToItem.GetRootAsSlashBuffToItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSlashBuffToItemById.HandleId, ConfigSlashBuffToItemById.LogPair);
			return new SlashBuffToItem?(rootAsSlashBuffToItem);
		}

		// Token: 0x04004139 RID: 16697
		private const string DB = "db_shiptower.db";

		// Token: 0x0400413A RID: 16698
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400413B RID: 16699
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x0400413C RID: 16700
		private const string COMMAND = "select BinData from `SlashBuffToItem` where Id=?";

		// Token: 0x0400413D RID: 16701
		private const string KEY_PREFIX = "SlashBuffToItemById";

		// Token: 0x0400413E RID: 16702
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400413F RID: 16703
		private static int HandleId;
	}
}
