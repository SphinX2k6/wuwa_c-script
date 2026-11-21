using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9C RID: 2716
	public class ConfigTeleporterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FBC RID: 16316 RVA: 0x001C52C0 File Offset: 0x001C34C0
		static ConfigTeleporterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeleporterById.CreateStaticDefaultValue), new Action(ConfigTeleporterById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x001C52E0 File Offset: 0x001C34E0
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

		// Token: 0x06003FBE RID: 16318 RVA: 0x001C535F File Offset: 0x001C355F
		public static void ResetStaticDefaultValue()
		{
			ConfigTeleporterById.LogPair = null;
			ConfigTeleporterById.HandleId = 0;
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x001C536D File Offset: 0x001C356D
		public static void Init()
		{
			ConfigTeleporterById.HandleId = ConfigCommon.InitDataStatement(ConfigTeleporterById.HandleId, "db_teleporter.db", "select BinData from `Teleporter` where Id = ?");
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x001C5388 File Offset: 0x001C3588
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

		// Token: 0x04004A2A RID: 18986
		private const string DB = "db_teleporter.db";

		// Token: 0x04004A2B RID: 18987
		private const string FILE = "c.传送.xlsx";

		// Token: 0x04004A2C RID: 18988
		private const string TABLE = "Teleporter";

		// Token: 0x04004A2D RID: 18989
		private const string COMMAND = "select BinData from `Teleporter` where Id = ?";

		// Token: 0x04004A2E RID: 18990
		private const string KEY_PREFIX = "TeleporterById";

		// Token: 0x04004A2F RID: 18991
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A30 RID: 18992
		private static int HandleId;
	}
}
