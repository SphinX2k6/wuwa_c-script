using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C7 RID: 2503
	public class ConfigTeleporterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ABE RID: 15038 RVA: 0x001A5F2C File Offset: 0x001A412C
		static ConfigTeleporterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeleporterById.CreateStaticDefaultValue), new Action(ConfigTeleporterById.ResetStaticDefaultValue));
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x001A5F4C File Offset: 0x001A414C
		public static void CreateStaticDefaultValue()
		{
			ConfigTeleporterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeleporterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teleporter.db"),
				new ValueTuple<string, object>("文件", "c.传送.xlsx"),
				new ValueTuple<string, object>("表名", "Teleporter"),
				new ValueTuple<string, object>("语句", "select BinData from `Teleporter` where Id = ?")
			});
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x001A5FCB File Offset: 0x001A41CB
		public static void ResetStaticDefaultValue()
		{
			ConfigTeleporterById.LogPair = null;
			ConfigTeleporterById.HandleId = 0;
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x001A5FD9 File Offset: 0x001A41D9
		public static void Init()
		{
			ConfigTeleporterById.HandleId = ConfigCommon.InitDataStatement(ConfigTeleporterById.HandleId, "db_teleporter.db", "select BinData from `Teleporter` where Id = ?");
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x001A5FF4 File Offset: 0x001A41F4
		public static Teleporter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeleporterById.HandleId, ConfigTeleporterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeleporterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Teleporter?(Teleporter.GetRootAsTeleporter(configBuffer));
				}
			}
			ConfigTeleporterById.LogPair.Clear();
			ConfigTeleporterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTeleporterById.HandleId, 1, p0Id, ConfigTeleporterById.LogPair) || ConfigCommon.Step(ConfigTeleporterById.HandleId, true, ConfigTeleporterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTeleporterById.HandleId, ConfigTeleporterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeleporterById.HandleId, 0, ConfigTeleporterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTeleporterById.HandleId, ConfigTeleporterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Teleporter rootAsTeleporter = Teleporter.GetRootAsTeleporter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeleporterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTeleporterById.HandleId, ConfigTeleporterById.LogPair);
			return new Teleporter?(rootAsTeleporter);
		}

		// Token: 0x04004457 RID: 17495
		private const string DB = "db_teleporter.db";

		// Token: 0x04004458 RID: 17496
		private const string FILE = "c.传送.xlsx";

		// Token: 0x04004459 RID: 17497
		private const string TABLE = "Teleporter";

		// Token: 0x0400445A RID: 17498
		private const string COMMAND = "select BinData from `Teleporter` where Id = ?";

		// Token: 0x0400445B RID: 17499
		private const string KEY_PREFIX = "TeleporterById";

		// Token: 0x0400445C RID: 17500
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400445D RID: 17501
		private static int HandleId;
	}
}
