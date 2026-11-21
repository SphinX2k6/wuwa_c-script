using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A3 RID: 163
	public class ConfigAnniversaryEntranceByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x000729F7 File Offset: 0x00070BF7
		static ConfigAnniversaryEntranceByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnniversaryEntranceByActivityId.CreateStaticDefaultValue), new Action(ConfigAnniversaryEntranceByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00072A18 File Offset: 0x00070C18
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

		// Token: 0x060003D4 RID: 980 RVA: 0x00072A97 File Offset: 0x00070C97
		public static void ResetStaticDefaultValue()
		{
			ConfigAnniversaryEntranceByActivityId.LogPair = null;
			ConfigAnniversaryEntranceByActivityId.HandleId = 0;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00072AA5 File Offset: 0x00070CA5
		public static void Init()
		{
			ConfigAnniversaryEntranceByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigAnniversaryEntranceByActivityId.HandleId, "db_anniversaryt.db", "select BinData from `AnniversaryEntrance` where ActivityId=?");
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00072AC0 File Offset: 0x00070CC0
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

		// Token: 0x04000459 RID: 1113
		private const string DB = "db_anniversaryt.db";

		// Token: 0x0400045A RID: 1114
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x0400045B RID: 1115
		private const string TABLE = "AnniversaryEntrance";

		// Token: 0x0400045C RID: 1116
		private const string COMMAND = "select BinData from `AnniversaryEntrance` where ActivityId=?";

		// Token: 0x0400045D RID: 1117
		private const string KEY_PREFIX = "AnniversaryEntranceByActivityId";

		// Token: 0x0400045E RID: 1118
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400045F RID: 1119
		private static int HandleId;
	}
}
