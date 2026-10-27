using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009C RID: 156
	public class ConfigAnniversaryEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x0006E38C File Offset: 0x0006C58C
		static ConfigAnniversaryEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnniversaryEntranceById.CreateStaticDefaultValue), new Action(ConfigAnniversaryEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0006E3AC File Offset: 0x0006C5AC
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

		// Token: 0x060003AA RID: 938 RVA: 0x0006E42B File Offset: 0x0006C62B
		public static void ResetStaticDefaultValue()
		{
			ConfigAnniversaryEntranceById.LogPair = null;
			ConfigAnniversaryEntranceById.HandleId = 0;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0006E439 File Offset: 0x0006C639
		public static void Init()
		{
			ConfigAnniversaryEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigAnniversaryEntranceById.HandleId, "db_anniversaryt.db", "select BinData from `AnniversaryEntrance` where Id=?");
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0006E454 File Offset: 0x0006C654
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

		// Token: 0x04000428 RID: 1064
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04000429 RID: 1065
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x0400042A RID: 1066
		private const string TABLE = "AnniversaryEntrance";

		// Token: 0x0400042B RID: 1067
		private const string COMMAND = "select BinData from `AnniversaryEntrance` where Id=?";

		// Token: 0x0400042C RID: 1068
		private const string KEY_PREFIX = "AnniversaryEntranceById";

		// Token: 0x0400042D RID: 1069
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400042E RID: 1070
		private static int HandleId;
	}
}
