using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D1 RID: 209
	public class ConfigAvoidBlockLevelByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x00079104 File Offset: 0x00077304
		static ConfigAvoidBlockLevelByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvoidBlockLevelByInstId.CreateStaticDefaultValue), new Action(ConfigAvoidBlockLevelByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00079124 File Offset: 0x00077324
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

		// Token: 0x060004E9 RID: 1257 RVA: 0x000791A3 File Offset: 0x000773A3
		public static void ResetStaticDefaultValue()
		{
			ConfigAvoidBlockLevelByInstId.LogPair = null;
			ConfigAvoidBlockLevelByInstId.HandleId = 0;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000791B1 File Offset: 0x000773B1
		public static void Init()
		{
			ConfigAvoidBlockLevelByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigAvoidBlockLevelByInstId.HandleId, "db_avoidblock.db", "select BinData from `AvoidBlockLevel` where InstId=?");
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000791CC File Offset: 0x000773CC
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

		// Token: 0x0400059B RID: 1435
		private const string DB = "db_avoidblock.db";

		// Token: 0x0400059C RID: 1436
		private const string FILE = "d.躲避方块.xlsx";

		// Token: 0x0400059D RID: 1437
		private const string TABLE = "AvoidBlockLevel";

		// Token: 0x0400059E RID: 1438
		private const string COMMAND = "select BinData from `AvoidBlockLevel` where InstId=?";

		// Token: 0x0400059F RID: 1439
		private const string KEY_PREFIX = "AvoidBlockLevelByInstId";

		// Token: 0x040005A0 RID: 1440
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005A1 RID: 1441
		private static int HandleId;
	}
}
