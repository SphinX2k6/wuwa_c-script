using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A1 RID: 2465
	public class ConfigSlashBuffToItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039D9 RID: 14809 RVA: 0x001A3C44 File Offset: 0x001A1E44
		static ConfigSlashBuffToItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemByItemId.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x001A3C64 File Offset: 0x001A1E64
		public static void CreateStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlashBuffToItemByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shiptower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔常驻.xlsx"),
				new ValueTuple<string, object>("表名", "SlashBuffToItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SlashBuffToItem` where ItemId=?")
			});
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x001A3CE3 File Offset: 0x001A1EE3
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemId.LogPair = null;
			ConfigSlashBuffToItemByItemId.HandleId = 0;
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x001A3CF1 File Offset: 0x001A1EF1
		public static void Init()
		{
			ConfigSlashBuffToItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemByItemId.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where ItemId=?");
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x001A3D0C File Offset: 0x001A1F0C
		public static SlashBuffToItem? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlashBuffToItemByItemId.HandleId, ConfigSlashBuffToItemByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SlashBuffToItem?(SlashBuffToItem.GetRootAsSlashBuffToItem(configBuffer));
				}
			}
			ConfigSlashBuffToItemByItemId.LogPair.Clear();
			ConfigSlashBuffToItemByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigSlashBuffToItemByItemId.HandleId, 1, p0ItemId, ConfigSlashBuffToItemByItemId.LogPair) || ConfigCommon.Step(ConfigSlashBuffToItemByItemId.HandleId, true, ConfigSlashBuffToItemByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSlashBuffToItemByItemId.HandleId, ConfigSlashBuffToItemByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlashBuffToItemByItemId.HandleId, 0, ConfigSlashBuffToItemByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSlashBuffToItemByItemId.HandleId, ConfigSlashBuffToItemByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SlashBuffToItem rootAsSlashBuffToItem = SlashBuffToItem.GetRootAsSlashBuffToItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SlashBuffToItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSlashBuffToItemByItemId.HandleId, ConfigSlashBuffToItemByItemId.LogPair);
			return new SlashBuffToItem?(rootAsSlashBuffToItem);
		}

		// Token: 0x0400434D RID: 17229
		private const string DB = "db_shiptower.db";

		// Token: 0x0400434E RID: 17230
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x0400434F RID: 17231
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004350 RID: 17232
		private const string COMMAND = "select BinData from `SlashBuffToItem` where ItemId=?";

		// Token: 0x04004351 RID: 17233
		private const string KEY_PREFIX = "SlashBuffToItemByItemId";

		// Token: 0x04004352 RID: 17234
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004353 RID: 17235
		private static int HandleId;
	}
}
