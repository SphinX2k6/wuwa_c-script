using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000248 RID: 584
	public class ConfigDropCatchDropItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DB4 RID: 3508 RVA: 0x000AA913 File Offset: 0x000A8B13
		static ConfigDropCatchDropItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchDropItemById.CreateStaticDefaultValue), new Action(ConfigDropCatchDropItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000AA934 File Offset: 0x000A8B34
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchDropItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchDropItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchDropItem"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchDropItem` where Id=?")
			});
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000AA9B3 File Offset: 0x000A8BB3
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchDropItemById.LogPair = null;
			ConfigDropCatchDropItemById.HandleId = 0;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x000AA9C1 File Offset: 0x000A8BC1
		public static void Init()
		{
			ConfigDropCatchDropItemById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchDropItemById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchDropItem` where Id=?");
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x000AA9DC File Offset: 0x000A8BDC
		public static DropCatchDropItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchDropItemById.HandleId, ConfigDropCatchDropItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchDropItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropCatchDropItem?(DropCatchDropItem.GetRootAsDropCatchDropItem(configBuffer));
				}
			}
			ConfigDropCatchDropItemById.LogPair.Clear();
			ConfigDropCatchDropItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropCatchDropItemById.HandleId, 1, p0Id, ConfigDropCatchDropItemById.LogPair) || ConfigCommon.Step(ConfigDropCatchDropItemById.HandleId, true, ConfigDropCatchDropItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropCatchDropItemById.HandleId, ConfigDropCatchDropItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchDropItemById.HandleId, 0, ConfigDropCatchDropItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropCatchDropItemById.HandleId, ConfigDropCatchDropItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropCatchDropItem rootAsDropCatchDropItem = DropCatchDropItem.GetRootAsDropCatchDropItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchDropItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropCatchDropItemById.HandleId, ConfigDropCatchDropItemById.LogPair);
			return new DropCatchDropItem?(rootAsDropCatchDropItem);
		}

		// Token: 0x04000FDC RID: 4060
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000FDD RID: 4061
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000FDE RID: 4062
		private const string TABLE = "DropCatchDropItem";

		// Token: 0x04000FDF RID: 4063
		private const string COMMAND = "select BinData from `DropCatchDropItem` where Id=?";

		// Token: 0x04000FE0 RID: 4064
		private const string KEY_PREFIX = "DropCatchDropItemById";

		// Token: 0x04000FE1 RID: 4065
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FE2 RID: 4066
		private static int HandleId;
	}
}
