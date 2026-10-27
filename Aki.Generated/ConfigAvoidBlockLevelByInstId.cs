using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C2 RID: 194
	public class ConfigAvoidBlockLevelByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x000737A0 File Offset: 0x000719A0
		static ConfigAvoidBlockLevelByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvoidBlockLevelByInstId.CreateStaticDefaultValue), new Action(ConfigAvoidBlockLevelByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000737C0 File Offset: 0x000719C0
		public static void CreateStaticDefaultValue()
		{
			ConfigAvoidBlockLevelByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvoidBlockLevelByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avoidblock.db"),
				new ValueTuple<string, object>("文件", "d.躲避方块.xlsx"),
				new ValueTuple<string, object>("表名", "AvoidBlockLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AvoidBlockLevel` where InstId=?")
			});
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0007383F File Offset: 0x00071A3F
		public static void ResetStaticDefaultValue()
		{
			ConfigAvoidBlockLevelByInstId.LogPair = null;
			ConfigAvoidBlockLevelByInstId.HandleId = 0;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0007384D File Offset: 0x00071A4D
		public static void Init()
		{
			ConfigAvoidBlockLevelByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigAvoidBlockLevelByInstId.HandleId, "db_avoidblock.db", "select BinData from `AvoidBlockLevel` where InstId=?");
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00073868 File Offset: 0x00071A68
		public static AvoidBlockLevel? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvoidBlockLevelByInstId.HandleId, ConfigAvoidBlockLevelByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvoidBlockLevelByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvoidBlockLevel?(AvoidBlockLevel.GetRootAsAvoidBlockLevel(configBuffer));
				}
			}
			ConfigAvoidBlockLevelByInstId.LogPair.Clear();
			ConfigAvoidBlockLevelByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigAvoidBlockLevelByInstId.HandleId, 1, p0InstId, ConfigAvoidBlockLevelByInstId.LogPair) || ConfigCommon.Step(ConfigAvoidBlockLevelByInstId.HandleId, true, ConfigAvoidBlockLevelByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvoidBlockLevelByInstId.HandleId, ConfigAvoidBlockLevelByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvoidBlockLevelByInstId.HandleId, 0, ConfigAvoidBlockLevelByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvoidBlockLevelByInstId.HandleId, ConfigAvoidBlockLevelByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvoidBlockLevel rootAsAvoidBlockLevel = AvoidBlockLevel.GetRootAsAvoidBlockLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvoidBlockLevelByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvoidBlockLevelByInstId.HandleId, ConfigAvoidBlockLevelByInstId.LogPair);
			return new AvoidBlockLevel?(rootAsAvoidBlockLevel);
		}

		// Token: 0x04000532 RID: 1330
		private const string DB = "db_avoidblock.db";

		// Token: 0x04000533 RID: 1331
		private const string FILE = "d.躲避方块.xlsx";

		// Token: 0x04000534 RID: 1332
		private const string TABLE = "AvoidBlockLevel";

		// Token: 0x04000535 RID: 1333
		private const string COMMAND = "select BinData from `AvoidBlockLevel` where InstId=?";

		// Token: 0x04000536 RID: 1334
		private const string KEY_PREFIX = "AvoidBlockLevelByInstId";

		// Token: 0x04000537 RID: 1335
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000538 RID: 1336
		private static int HandleId;
	}
}
