using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087E RID: 2174
	public class ConfigRogueRoomShowConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003306 RID: 13062 RVA: 0x0017D690 File Offset: 0x0017B890
		static ConfigRogueRoomShowConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueRoomShowConfigById.CreateStaticDefaultValue), new Action(ConfigRogueRoomShowConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x0017D6B0 File Offset: 0x0017B8B0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueRoomShowConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueRoomShowConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueRoomShowConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueRoomShowConfig` where BehaviorTree=?")
			});
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x0017D72F File Offset: 0x0017B92F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueRoomShowConfigById.LogPair = null;
			ConfigRogueRoomShowConfigById.HandleId = 0;
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x0017D73D File Offset: 0x0017B93D
		public static void Init()
		{
			ConfigRogueRoomShowConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueRoomShowConfigById.HandleId, "db_rogue.db", "select BinData from `RogueRoomShowConfig` where BehaviorTree=?");
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x0017D758 File Offset: 0x0017B958
		public static RogueRoomShowConfig? GetConfig(int p0BehaviorTree, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueRoomShowConfigById.HandleId, ConfigRogueRoomShowConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueRoomShowConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BehaviorTree);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueRoomShowConfig?(RogueRoomShowConfig.GetRootAsRogueRoomShowConfig(configBuffer));
				}
			}
			ConfigRogueRoomShowConfigById.LogPair.Clear();
			ConfigRogueRoomShowConfigById.LogPair.Add(new ValueTuple<string, object>("BehaviorTree", p0BehaviorTree));
			if (!ConfigCommon.BindInt(ConfigRogueRoomShowConfigById.HandleId, 1, p0BehaviorTree, ConfigRogueRoomShowConfigById.LogPair) || ConfigCommon.Step(ConfigRogueRoomShowConfigById.HandleId, true, ConfigRogueRoomShowConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueRoomShowConfigById.HandleId, ConfigRogueRoomShowConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueRoomShowConfigById.HandleId, 0, ConfigRogueRoomShowConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueRoomShowConfigById.HandleId, ConfigRogueRoomShowConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueRoomShowConfig rootAsRogueRoomShowConfig = RogueRoomShowConfig.GetRootAsRogueRoomShowConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueRoomShowConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BehaviorTree);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueRoomShowConfigById.HandleId, ConfigRogueRoomShowConfigById.LogPair);
			return new RogueRoomShowConfig?(rootAsRogueRoomShowConfig);
		}

		// Token: 0x04003B58 RID: 15192
		private const string DB = "db_rogue.db";

		// Token: 0x04003B59 RID: 15193
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B5A RID: 15194
		private const string TABLE = "RogueRoomShowConfig";

		// Token: 0x04003B5B RID: 15195
		private const string COMMAND = "select BinData from `RogueRoomShowConfig` where BehaviorTree=?";

		// Token: 0x04003B5C RID: 15196
		private const string KEY_PREFIX = "RogueRoomShowConfigById";

		// Token: 0x04003B5D RID: 15197
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B5E RID: 15198
		private static int HandleId;
	}
}
