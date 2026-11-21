using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000442 RID: 1090
	public class ConfigInfrLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001995 RID: 6549 RVA: 0x000EDCC7 File Offset: 0x000EBEC7
		static ConfigInfrLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrLevelByLevel.CreateStaticDefaultValue), new Action(ConfigInfrLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000EDCE8 File Offset: 0x000EBEE8
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrLevelByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrLevelByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrLevel` where Level=?")
			});
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000EDD67 File Offset: 0x000EBF67
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrLevelByLevel.LogPair = null;
			ConfigInfrLevelByLevel.HandleId = 0;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000EDD75 File Offset: 0x000EBF75
		public static void Init()
		{
			ConfigInfrLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigInfrLevelByLevel.HandleId, "db_infrastructure.db", "select BinData from `InfrLevel` where Level=?");
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000EDD90 File Offset: 0x000EBF90
		public static InfrLevel? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrLevelByLevel.HandleId, ConfigInfrLevelByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrLevel?(InfrLevel.GetRootAsInfrLevel(configBuffer));
				}
			}
			ConfigInfrLevelByLevel.LogPair.Clear();
			ConfigInfrLevelByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigInfrLevelByLevel.HandleId, 1, p0Level, ConfigInfrLevelByLevel.LogPair) || ConfigCommon.Step(ConfigInfrLevelByLevel.HandleId, true, ConfigInfrLevelByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrLevelByLevel.HandleId, ConfigInfrLevelByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrLevelByLevel.HandleId, 0, ConfigInfrLevelByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrLevelByLevel.HandleId, ConfigInfrLevelByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrLevel rootAsInfrLevel = InfrLevel.GetRootAsInfrLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrLevelByLevel.HandleId, ConfigInfrLevelByLevel.LogPair);
			return new InfrLevel?(rootAsInfrLevel);
		}

		// Token: 0x04001DB2 RID: 7602
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DB3 RID: 7603
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001DB4 RID: 7604
		private const string TABLE = "InfrLevel";

		// Token: 0x04001DB5 RID: 7605
		private const string COMMAND = "select BinData from `InfrLevel` where Level=?";

		// Token: 0x04001DB6 RID: 7606
		private const string KEY_PREFIX = "InfrLevelByLevel";

		// Token: 0x04001DB7 RID: 7607
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DB8 RID: 7608
		private static int HandleId;
	}
}
