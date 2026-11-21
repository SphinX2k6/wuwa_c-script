using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A0 RID: 2464
	public class ConfigSlashBuffToItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039D3 RID: 14803 RVA: 0x001A39FB File Offset: 0x001A1BFB
		static ConfigSlashBuffToItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlashBuffToItemById.CreateStaticDefaultValue), new Action(ConfigSlashBuffToItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x001A3A1C File Offset: 0x001A1C1C
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

		// Token: 0x060039D5 RID: 14805 RVA: 0x001A3A9B File Offset: 0x001A1C9B
		public static void ResetStaticDefaultValue()
		{
			ConfigSlashBuffToItemById.LogPair = null;
			ConfigSlashBuffToItemById.HandleId = 0;
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x001A3AA9 File Offset: 0x001A1CA9
		public static void Init()
		{
			ConfigSlashBuffToItemById.HandleId = ConfigCommon.InitDataStatement(ConfigSlashBuffToItemById.HandleId, "db_shiptower.db", "select BinData from `SlashBuffToItem` where Id=?");
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x001A3AC4 File Offset: 0x001A1CC4
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

		// Token: 0x04004346 RID: 17222
		private const string DB = "db_shiptower.db";

		// Token: 0x04004347 RID: 17223
		private const string FILE = "g.割草爬塔常驻.xlsx";

		// Token: 0x04004348 RID: 17224
		private const string TABLE = "SlashBuffToItem";

		// Token: 0x04004349 RID: 17225
		private const string COMMAND = "select BinData from `SlashBuffToItem` where Id=?";

		// Token: 0x0400434A RID: 17226
		private const string KEY_PREFIX = "SlashBuffToItemById";

		// Token: 0x0400434B RID: 17227
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400434C RID: 17228
		private static int HandleId;
	}
}
