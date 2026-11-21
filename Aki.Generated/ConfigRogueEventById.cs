using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083F RID: 2111
	public class ConfigRogueEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600318C RID: 12684 RVA: 0x00174E90 File Offset: 0x00173090
		static ConfigRogueEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueEventById.CreateStaticDefaultValue), new Action(ConfigRogueEventById.ResetStaticDefaultValue));
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x00174EB0 File Offset: 0x001730B0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueEvent` where Id=?")
			});
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00174F2F File Offset: 0x0017312F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueEventById.LogPair = null;
			ConfigRogueEventById.HandleId = 0;
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x00174F3D File Offset: 0x0017313D
		public static void Init()
		{
			ConfigRogueEventById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueEventById.HandleId, "db_rogue.db", "select BinData from `RogueEvent` where Id=?");
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x00174F58 File Offset: 0x00173158
		public static RogueEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueEventById.HandleId, ConfigRogueEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueEvent?(RogueEvent.GetRootAsRogueEvent(configBuffer));
				}
			}
			ConfigRogueEventById.LogPair.Clear();
			ConfigRogueEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueEventById.HandleId, 1, p0Id, ConfigRogueEventById.LogPair) || ConfigCommon.Step(ConfigRogueEventById.HandleId, true, ConfigRogueEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueEventById.HandleId, ConfigRogueEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueEventById.HandleId, 0, ConfigRogueEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueEventById.HandleId, ConfigRogueEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueEvent rootAsRogueEvent = RogueEvent.GetRootAsRogueEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueEventById.HandleId, ConfigRogueEventById.LogPair);
			return new RogueEvent?(rootAsRogueEvent);
		}

		// Token: 0x0400399F RID: 14751
		private const string DB = "db_rogue.db";

		// Token: 0x040039A0 RID: 14752
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040039A1 RID: 14753
		private const string TABLE = "RogueEvent";

		// Token: 0x040039A2 RID: 14754
		private const string COMMAND = "select BinData from `RogueEvent` where Id=?";

		// Token: 0x040039A3 RID: 14755
		private const string KEY_PREFIX = "RogueEventById";

		// Token: 0x040039A4 RID: 14756
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039A5 RID: 14757
		private static int HandleId;
	}
}
