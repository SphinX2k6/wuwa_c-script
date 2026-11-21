using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A4 RID: 164
	public class ConfigAnniversaryEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x00072C40 File Offset: 0x00070E40
		static ConfigAnniversaryEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnniversaryEntranceById.CreateStaticDefaultValue), new Action(ConfigAnniversaryEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00072C60 File Offset: 0x00070E60
		public static void CreateStaticDefaultValue()
		{
			ConfigAnniversaryEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAnniversaryEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_anniversaryt.db"),
				new ValueTuple<string, object>("文件", "z.周年庆主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "AnniversaryEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `AnniversaryEntrance` where Id=?")
			});
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00072CDF File Offset: 0x00070EDF
		public static void ResetStaticDefaultValue()
		{
			ConfigAnniversaryEntranceById.LogPair = null;
			ConfigAnniversaryEntranceById.HandleId = 0;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00072CED File Offset: 0x00070EED
		public static void Init()
		{
			ConfigAnniversaryEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigAnniversaryEntranceById.HandleId, "db_anniversaryt.db", "select BinData from `AnniversaryEntrance` where Id=?");
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00072D08 File Offset: 0x00070F08
		public static AnniversaryEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAnniversaryEntranceById.HandleId, ConfigAnniversaryEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnniversaryEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AnniversaryEntrance?(AnniversaryEntrance.GetRootAsAnniversaryEntrance(configBuffer));
				}
			}
			ConfigAnniversaryEntranceById.LogPair.Clear();
			ConfigAnniversaryEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAnniversaryEntranceById.HandleId, 1, p0Id, ConfigAnniversaryEntranceById.LogPair) || ConfigCommon.Step(ConfigAnniversaryEntranceById.HandleId, true, ConfigAnniversaryEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAnniversaryEntranceById.HandleId, ConfigAnniversaryEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAnniversaryEntranceById.HandleId, 0, ConfigAnniversaryEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAnniversaryEntranceById.HandleId, ConfigAnniversaryEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AnniversaryEntrance rootAsAnniversaryEntrance = AnniversaryEntrance.GetRootAsAnniversaryEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnniversaryEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAnniversaryEntranceById.HandleId, ConfigAnniversaryEntranceById.LogPair);
			return new AnniversaryEntrance?(rootAsAnniversaryEntrance);
		}

		// Token: 0x04000460 RID: 1120
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04000461 RID: 1121
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04000462 RID: 1122
		private const string TABLE = "AnniversaryEntrance";

		// Token: 0x04000463 RID: 1123
		private const string COMMAND = "select BinData from `AnniversaryEntrance` where Id=?";

		// Token: 0x04000464 RID: 1124
		private const string KEY_PREFIX = "AnniversaryEntranceById";

		// Token: 0x04000465 RID: 1125
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000466 RID: 1126
		private static int HandleId;
	}
}
