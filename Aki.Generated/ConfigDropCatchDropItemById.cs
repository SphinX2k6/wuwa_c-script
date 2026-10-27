using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000236 RID: 566
	public class ConfigDropCatchDropItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x000A49DB File Offset: 0x000A2BDB
		static ConfigDropCatchDropItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchDropItemById.CreateStaticDefaultValue), new Action(ConfigDropCatchDropItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000A49FC File Offset: 0x000A2BFC
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

		// Token: 0x06000D4A RID: 3402 RVA: 0x000A4A7B File Offset: 0x000A2C7B
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchDropItemById.LogPair = null;
			ConfigDropCatchDropItemById.HandleId = 0;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000A4A89 File Offset: 0x000A2C89
		public static void Init()
		{
			ConfigDropCatchDropItemById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchDropItemById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchDropItem` where Id=?");
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000A4AA4 File Offset: 0x000A2CA4
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

		// Token: 0x04000F5E RID: 3934
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F5F RID: 3935
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F60 RID: 3936
		private const string TABLE = "DropCatchDropItem";

		// Token: 0x04000F61 RID: 3937
		private const string COMMAND = "select BinData from `DropCatchDropItem` where Id=?";

		// Token: 0x04000F62 RID: 3938
		private const string KEY_PREFIX = "DropCatchDropItemById";

		// Token: 0x04000F63 RID: 3939
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F64 RID: 3940
		private static int HandleId;
	}
}
