using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000956 RID: 2390
	public class ConfigSlashBuffToItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003817 RID: 14359 RVA: 0x00196A24 File Offset: 0x00194C24
		static ConfigSlashBuffToItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemByItemId.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00196A44 File Offset: 0x00194C44
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

		// Token: 0x06003819 RID: 14361 RVA: 0x00196AC3 File Offset: 0x00194CC3
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemByItemId.LogPair = null;
			ConfigSlashBuffToItemByItemId.HandleId = 0;
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00196AD1 File Offset: 0x00194CD1
		public static void Init()
		{
			ConfigSlashBuffToItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemByItemId.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where ItemId=?");
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00196AEC File Offset: 0x00194CEC
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

		// Token: 0x04004140 RID: 16704
		private const string DB = "db_shiptower.db";

		// Token: 0x04004141 RID: 16705
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004142 RID: 16706
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004143 RID: 16707
		private const string COMMAND = "select BinData from `SlashBuffToItem` where ItemId=?";

		// Token: 0x04004144 RID: 16708
		private const string KEY_PREFIX = "SlashBuffToItemByItemId";

		// Token: 0x04004145 RID: 16709
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004146 RID: 16710
		private static int HandleId;
	}
}
