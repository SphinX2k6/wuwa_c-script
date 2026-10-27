using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009B RID: 155
	public class ConfigAnniversaryEntranceByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0006E143 File Offset: 0x0006C343
		static ConfigAnniversaryEntranceByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnniversaryEntranceByActivityId.CreateStaticDefaultValue), new Action(ConfigAnniversaryEntranceByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0006E164 File Offset: 0x0006C364
		public static void CreateStaticDefaultValue()
		{
			ConfigAnniversaryEntranceByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAnniversaryEntranceByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_anniversaryt.db"),
				new ValueTuple<string, object>("文件", "z.周年庆主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "AnniversaryEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `AnniversaryEntrance` where ActivityId=?")
			});
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0006E1E3 File Offset: 0x0006C3E3
		public static void ResetStaticDefaultValue()
		{
			ConfigAnniversaryEntranceByActivityId.LogPair = null;
			ConfigAnniversaryEntranceByActivityId.HandleId = 0;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0006E1F1 File Offset: 0x0006C3F1
		public static void Init()
		{
			ConfigAnniversaryEntranceByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigAnniversaryEntranceByActivityId.HandleId, "db_anniversaryt.db", "select BinData from `AnniversaryEntrance` where ActivityId=?");
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0006E20C File Offset: 0x0006C40C
		public static AnniversaryEntrance? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAnniversaryEntranceByActivityId.HandleId, ConfigAnniversaryEntranceByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnniversaryEntranceByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AnniversaryEntrance?(AnniversaryEntrance.GetRootAsAnniversaryEntrance(configBuffer));
				}
			}
			ConfigAnniversaryEntranceByActivityId.LogPair.Clear();
			ConfigAnniversaryEntranceByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigAnniversaryEntranceByActivityId.HandleId, 1, p0ActivityId, ConfigAnniversaryEntranceByActivityId.LogPair) || ConfigCommon.Step(ConfigAnniversaryEntranceByActivityId.HandleId, true, ConfigAnniversaryEntranceByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAnniversaryEntranceByActivityId.HandleId, ConfigAnniversaryEntranceByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAnniversaryEntranceByActivityId.HandleId, 0, ConfigAnniversaryEntranceByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAnniversaryEntranceByActivityId.HandleId, ConfigAnniversaryEntranceByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AnniversaryEntrance rootAsAnniversaryEntrance = AnniversaryEntrance.GetRootAsAnniversaryEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnniversaryEntranceByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAnniversaryEntranceByActivityId.HandleId, ConfigAnniversaryEntranceByActivityId.LogPair);
			return new AnniversaryEntrance?(rootAsAnniversaryEntrance);
		}

		// Token: 0x04000421 RID: 1057
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04000422 RID: 1058
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04000423 RID: 1059
		private const string TABLE = "AnniversaryEntrance";

		// Token: 0x04000424 RID: 1060
		private const string COMMAND = "select BinData from `AnniversaryEntrance` where ActivityId=?";

		// Token: 0x04000425 RID: 1061
		private const string KEY_PREFIX = "AnniversaryEntranceByActivityId";

		// Token: 0x04000426 RID: 1062
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000427 RID: 1063
		private static int HandleId;
	}
}
