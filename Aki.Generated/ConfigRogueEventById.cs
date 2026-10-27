using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000823 RID: 2083
	public class ConfigRogueEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030E4 RID: 12516 RVA: 0x0016DBA8 File Offset: 0x0016BDA8
		static ConfigRogueEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueEventById.CreateStaticDefaultValue), new Action(ConfigRogueEventById.ResetStaticDefaultValue));
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0016DBC8 File Offset: 0x0016BDC8
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

		// Token: 0x060030E6 RID: 12518 RVA: 0x0016DC47 File Offset: 0x0016BE47
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueEventById.LogPair = null;
			ConfigRogueEventById.HandleId = 0;
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x0016DC55 File Offset: 0x0016BE55
		public static void Init()
		{
			ConfigRogueEventById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueEventById.HandleId, "db_rogue.db", "select BinData from `RogueEvent` where Id=?");
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0016DC70 File Offset: 0x0016BE70
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

		// Token: 0x040038DB RID: 14555
		private const string DB = "db_rogue.db";

		// Token: 0x040038DC RID: 14556
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040038DD RID: 14557
		private const string TABLE = "RogueEvent";

		// Token: 0x040038DE RID: 14558
		private const string COMMAND = "select BinData from `RogueEvent` where Id=?";

		// Token: 0x040038DF RID: 14559
		private const string KEY_PREFIX = "RogueEventById";

		// Token: 0x040038E0 RID: 14560
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038E1 RID: 14561
		private static int HandleId;
	}
}
