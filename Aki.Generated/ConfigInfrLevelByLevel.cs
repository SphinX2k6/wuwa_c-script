using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042C RID: 1068
	public class ConfigInfrLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001911 RID: 6417 RVA: 0x000E7573 File Offset: 0x000E5773
		static ConfigInfrLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrLevelByLevel.CreateStaticDefaultValue), new Action(ConfigInfrLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000E7594 File Offset: 0x000E5794
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

		// Token: 0x06001913 RID: 6419 RVA: 0x000E7613 File Offset: 0x000E5813
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrLevelByLevel.LogPair = null;
			ConfigInfrLevelByLevel.HandleId = 0;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000E7621 File Offset: 0x000E5821
		public static void Init()
		{
			ConfigInfrLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigInfrLevelByLevel.HandleId, "db_infrastructure.db", "select BinData from `InfrLevel` where Level=?");
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000E763C File Offset: 0x000E583C
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

		// Token: 0x04001D18 RID: 7448
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D19 RID: 7449
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D1A RID: 7450
		private const string TABLE = "InfrLevel";

		// Token: 0x04001D1B RID: 7451
		private const string COMMAND = "select BinData from `InfrLevel` where Level=?";

		// Token: 0x04001D1C RID: 7452
		private const string KEY_PREFIX = "InfrLevelByLevel";

		// Token: 0x04001D1D RID: 7453
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D1E RID: 7454
		private static int HandleId;
	}
}
