using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B21 RID: 2849
	public class ConfigTravelTaskAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042DA RID: 17114 RVA: 0x001D6E5B File Offset: 0x001D505B
		static ConfigTravelTaskAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTravelTaskAreaById.CreateStaticDefaultValue), new Action(ConfigTravelTaskAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x001D6E7C File Offset: 0x001D507C
		public static void CreateStaticDefaultValue()
		{
			ConfigTravelTaskAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTravelTaskAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "TravelTaskArea"),
				new ValueTuple<string, object>("语句", "select BinData from `TravelTaskArea` where Id=?")
			});
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x001D6EFB File Offset: 0x001D50FB
		public static void ResetStaticDefaultValue()
		{
			ConfigTravelTaskAreaById.LogPair = null;
			ConfigTravelTaskAreaById.HandleId = 0;
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x001D6F09 File Offset: 0x001D5109
		public static void Init()
		{
			ConfigTravelTaskAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigTravelTaskAreaById.HandleId, "db_activitymaptravel.db", "select BinData from `TravelTaskArea` where Id=?");
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x001D6F24 File Offset: 0x001D5124
		public static TravelTaskArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTravelTaskAreaById.HandleId, ConfigTravelTaskAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TravelTaskArea?(TravelTaskArea.GetRootAsTravelTaskArea(configBuffer));
				}
			}
			ConfigTravelTaskAreaById.LogPair.Clear();
			ConfigTravelTaskAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTravelTaskAreaById.HandleId, 1, p0Id, ConfigTravelTaskAreaById.LogPair) || ConfigCommon.Step(ConfigTravelTaskAreaById.HandleId, true, ConfigTravelTaskAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTravelTaskAreaById.HandleId, ConfigTravelTaskAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTravelTaskAreaById.HandleId, 0, ConfigTravelTaskAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTravelTaskAreaById.HandleId, ConfigTravelTaskAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TravelTaskArea rootAsTravelTaskArea = TravelTaskArea.GetRootAsTravelTaskArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TravelTaskAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTravelTaskAreaById.HandleId, ConfigTravelTaskAreaById.LogPair);
			return new TravelTaskArea?(rootAsTravelTaskArea);
		}

		// Token: 0x04004DCD RID: 19917
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04004DCE RID: 19918
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04004DCF RID: 19919
		private const string TABLE = "TravelTaskArea";

		// Token: 0x04004DD0 RID: 19920
		private const string COMMAND = "select BinData from `TravelTaskArea` where Id=?";

		// Token: 0x04004DD1 RID: 19921
		private const string KEY_PREFIX = "TravelTaskAreaById";

		// Token: 0x04004DD2 RID: 19922
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DD3 RID: 19923
		private static int HandleId;
	}
}
