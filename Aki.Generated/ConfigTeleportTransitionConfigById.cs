using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9E RID: 2718
	public class ConfigTeleportTransitionConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FC8 RID: 16328 RVA: 0x001C573F File Offset: 0x001C393F
		static ConfigTeleportTransitionConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeleportTransitionConfigById.CreateStaticDefaultValue), new Action(ConfigTeleportTransitionConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x001C5760 File Offset: 0x001C3960
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

		// Token: 0x06003FCA RID: 16330 RVA: 0x001C57DF File Offset: 0x001C39DF
		public static void ResetStaticDefaultValue()
		{
			ConfigTeleportTransitionConfigById.LogPair = null;
			ConfigTeleportTransitionConfigById.HandleId = 0;
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x001C57ED File Offset: 0x001C39ED
		public static void Init()
		{
			ConfigTeleportTransitionConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTeleportTransitionConfigById.HandleId, "db_teleporttransitionconfig.db", "select BinData from `TeleportTransitionConfig` where Id = ?");
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x001C5808 File Offset: 0x001C3A08
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

		// Token: 0x04004A38 RID: 19000
		private const string DB = "db_teleporttransitionconfig.db";

		// Token: 0x04004A39 RID: 19001
		private const string FILE = "k.可视化编辑/c.Csv/c.传送过渡效果/*.csv*";

		// Token: 0x04004A3A RID: 19002
		private const string TABLE = "TeleportTransitionConfig";

		// Token: 0x04004A3B RID: 19003
		private const string COMMAND = "select BinData from `TeleportTransitionConfig` where Id = ?";

		// Token: 0x04004A3C RID: 19004
		private const string KEY_PREFIX = "TeleportTransitionConfigById";

		// Token: 0x04004A3D RID: 19005
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A3E RID: 19006
		private static int HandleId;
	}
}
