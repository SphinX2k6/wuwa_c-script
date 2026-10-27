using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C9 RID: 2505
	public class ConfigTeleportTransitionConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ACA RID: 15050 RVA: 0x001A63AB File Offset: 0x001A45AB
		static ConfigTeleportTransitionConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeleportTransitionConfigById.CreateStaticDefaultValue), new Action(ConfigTeleportTransitionConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x001A63CC File Offset: 0x001A45CC
		public static void CreateStaticDefaultValue()
		{
			ConfigTeleportTransitionConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeleportTransitionConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teleporttransitionconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/c.传送过渡效果/*.csv*"),
				new ValueTuple<string, object>("表名", "TeleportTransitionConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TeleportTransitionConfig` where Id = ?")
			});
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x001A644B File Offset: 0x001A464B
		public static void ResetStaticDefaultValue()
		{
			ConfigTeleportTransitionConfigById.LogPair = null;
			ConfigTeleportTransitionConfigById.HandleId = 0;
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x001A6459 File Offset: 0x001A4659
		public static void Init()
		{
			ConfigTeleportTransitionConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTeleportTransitionConfigById.HandleId, "db_teleporttransitionconfig.db", "select BinData from `TeleportTransitionConfig` where Id = ?");
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x001A6474 File Offset: 0x001A4674
		public static TeleportTransitionConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeleportTransitionConfigById.HandleId, ConfigTeleportTransitionConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeleportTransitionConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TeleportTransitionConfig?(TeleportTransitionConfig.GetRootAsTeleportTransitionConfig(configBuffer));
				}
			}
			ConfigTeleportTransitionConfigById.LogPair.Clear();
			ConfigTeleportTransitionConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTeleportTransitionConfigById.HandleId, 1, p0Id, ConfigTeleportTransitionConfigById.LogPair) || ConfigCommon.Step(ConfigTeleportTransitionConfigById.HandleId, true, ConfigTeleportTransitionConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTeleportTransitionConfigById.HandleId, ConfigTeleportTransitionConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeleportTransitionConfigById.HandleId, 0, ConfigTeleportTransitionConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTeleportTransitionConfigById.HandleId, ConfigTeleportTransitionConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TeleportTransitionConfig rootAsTeleportTransitionConfig = TeleportTransitionConfig.GetRootAsTeleportTransitionConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeleportTransitionConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTeleportTransitionConfigById.HandleId, ConfigTeleportTransitionConfigById.LogPair);
			return new TeleportTransitionConfig?(rootAsTeleportTransitionConfig);
		}

		// Token: 0x04004465 RID: 17509
		private const string DB = "db_teleporttransitionconfig.db";

		// Token: 0x04004466 RID: 17510
		private const string FILE = "k.可视化编辑/c.Csv/c.传送过渡效果/*.csv*";

		// Token: 0x04004467 RID: 17511
		private const string TABLE = "TeleportTransitionConfig";

		// Token: 0x04004468 RID: 17512
		private const string COMMAND = "select BinData from `TeleportTransitionConfig` where Id = ?";

		// Token: 0x04004469 RID: 17513
		private const string KEY_PREFIX = "TeleportTransitionConfigById";

		// Token: 0x0400446A RID: 17514
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400446B RID: 17515
		private static int HandleId;
	}
}
