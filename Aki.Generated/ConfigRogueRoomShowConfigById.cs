using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000862 RID: 2146
	public class ConfigRogueRoomShowConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600325E RID: 12894 RVA: 0x001763A8 File Offset: 0x001745A8
		static ConfigRogueRoomShowConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueRoomShowConfigById.CreateStaticDefaultValue), new Action(ConfigRogueRoomShowConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x001763C8 File Offset: 0x001745C8
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

		// Token: 0x06003260 RID: 12896 RVA: 0x00176447 File Offset: 0x00174647
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueRoomShowConfigById.LogPair = null;
			ConfigRogueRoomShowConfigById.HandleId = 0;
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00176455 File Offset: 0x00174655
		public static void Init()
		{
			ConfigRogueRoomShowConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueRoomShowConfigById.HandleId, "db_rogue.db", "select BinData from `RogueRoomShowConfig` where BehaviorTree=?");
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00176470 File Offset: 0x00174670
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

		// Token: 0x04003A94 RID: 14996
		private const string DB = "db_rogue.db";

		// Token: 0x04003A95 RID: 14997
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003A96 RID: 14998
		private const string TABLE = "RogueRoomShowConfig";

		// Token: 0x04003A97 RID: 14999
		private const string COMMAND = "select BinData from `RogueRoomShowConfig` where BehaviorTree=?";

		// Token: 0x04003A98 RID: 15000
		private const string KEY_PREFIX = "RogueRoomShowConfigById";

		// Token: 0x04003A99 RID: 15001
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A9A RID: 15002
		private static int HandleId;
	}
}
