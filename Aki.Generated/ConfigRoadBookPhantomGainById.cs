using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000816 RID: 2070
	public class ConfigRoadBookPhantomGainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003096 RID: 12438 RVA: 0x0016BEC3 File Offset: 0x0016A0C3
		static ConfigRoadBookPhantomGainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookPhantomGainById.CreateStaticDefaultValue), new Action(ConfigRoadBookPhantomGainById.ResetStaticDefaultValue));
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x0016BEE4 File Offset: 0x0016A0E4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookPhantomGainById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookPhantomGainById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookPhantomGain"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookPhantomGain` where Id=?")
			});
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x0016BF63 File Offset: 0x0016A163
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookPhantomGainById.LogPair = null;
			ConfigRoadBookPhantomGainById.HandleId = 0;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x0016BF71 File Offset: 0x0016A171
		public static void Init()
		{
			ConfigRoadBookPhantomGainById.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookPhantomGainById.HandleId, "db_roadbook.db", "select BinData from `RoadBookPhantomGain` where Id=?");
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x0016BF8C File Offset: 0x0016A18C
		public static RoadBookPhantomGain? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookPhantomGainById.HandleId, ConfigRoadBookPhantomGainById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookPhantomGainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoadBookPhantomGain?(RoadBookPhantomGain.GetRootAsRoadBookPhantomGain(configBuffer));
				}
			}
			ConfigRoadBookPhantomGainById.LogPair.Clear();
			ConfigRoadBookPhantomGainById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoadBookPhantomGainById.HandleId, 1, p0Id, ConfigRoadBookPhantomGainById.LogPair) || ConfigCommon.Step(ConfigRoadBookPhantomGainById.HandleId, true, ConfigRoadBookPhantomGainById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoadBookPhantomGainById.HandleId, ConfigRoadBookPhantomGainById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookPhantomGainById.HandleId, 0, ConfigRoadBookPhantomGainById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoadBookPhantomGainById.HandleId, ConfigRoadBookPhantomGainById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoadBookPhantomGain rootAsRoadBookPhantomGain = RoadBookPhantomGain.GetRootAsRoadBookPhantomGain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookPhantomGainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoadBookPhantomGainById.HandleId, ConfigRoadBookPhantomGainById.LogPair);
			return new RoadBookPhantomGain?(rootAsRoadBookPhantomGain);
		}

		// Token: 0x04003880 RID: 14464
		private const string DB = "db_roadbook.db";

		// Token: 0x04003881 RID: 14465
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003882 RID: 14466
		private const string TABLE = "RoadBookPhantomGain";

		// Token: 0x04003883 RID: 14467
		private const string COMMAND = "select BinData from `RoadBookPhantomGain` where Id=?";

		// Token: 0x04003884 RID: 14468
		private const string KEY_PREFIX = "RoadBookPhantomGainById";

		// Token: 0x04003885 RID: 14469
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003886 RID: 14470
		private static int HandleId;
	}
}
