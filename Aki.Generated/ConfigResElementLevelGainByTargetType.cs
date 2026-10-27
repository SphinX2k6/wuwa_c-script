using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E3 RID: 2019
	public class ConfigResElementLevelGainByTargetType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F64 RID: 12132 RVA: 0x001650E7 File Offset: 0x001632E7
		static ConfigResElementLevelGainByTargetType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResElementLevelGainByTargetType.CreateStaticDefaultValue), new Action(ConfigResElementLevelGainByTargetType.ResetStaticDefaultValue));
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00165108 File Offset: 0x00163308
		public static void CreateStaticDefaultValue()
		{
			ConfigResElementLevelGainByTargetType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigResElementLevelGainByTargetType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "ResElementLevelGain"),
				new ValueTuple<string, object>("语句", "select BinData from `ResElementLevelGain` where TargetType=?")
			});
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00165187 File Offset: 0x00163387
		public static void ResetStaticDefaultValue()
		{
			ConfigResElementLevelGainByTargetType.LogPair = null;
			ConfigResElementLevelGainByTargetType.HandleId = 0;
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00165195 File Offset: 0x00163395
		public static void Init()
		{
			ConfigResElementLevelGainByTargetType.HandleId = ConfigCommon.InitDataStatement(ConfigResElementLevelGainByTargetType.HandleId, "db_permanentrogue.db", "select BinData from `ResElementLevelGain` where TargetType=?");
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x001651B0 File Offset: 0x001633B0
		public static ResElementLevelGain? GetConfig(int p0TargetType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigResElementLevelGainByTargetType.HandleId, ConfigResElementLevelGainByTargetType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ResElementLevelGainByTargetType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TargetType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ResElementLevelGain?(ResElementLevelGain.GetRootAsResElementLevelGain(configBuffer));
				}
			}
			ConfigResElementLevelGainByTargetType.LogPair.Clear();
			ConfigResElementLevelGainByTargetType.LogPair.Add(new ValueTuple<string, object>("TargetType", p0TargetType));
			if (!ConfigCommon.BindInt(ConfigResElementLevelGainByTargetType.HandleId, 1, p0TargetType, ConfigResElementLevelGainByTargetType.LogPair) || ConfigCommon.Step(ConfigResElementLevelGainByTargetType.HandleId, true, ConfigResElementLevelGainByTargetType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigResElementLevelGainByTargetType.HandleId, ConfigResElementLevelGainByTargetType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigResElementLevelGainByTargetType.HandleId, 0, ConfigResElementLevelGainByTargetType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigResElementLevelGainByTargetType.HandleId, ConfigResElementLevelGainByTargetType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ResElementLevelGain rootAsResElementLevelGain = ResElementLevelGain.GetRootAsResElementLevelGain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ResElementLevelGainByTargetType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TargetType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigResElementLevelGainByTargetType.HandleId, ConfigResElementLevelGainByTargetType.LogPair);
			return new ResElementLevelGain?(rootAsResElementLevelGain);
		}

		// Token: 0x0400371B RID: 14107
		private const string DB = "db_permanentrogue.db";

		// Token: 0x0400371C RID: 14108
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x0400371D RID: 14109
		private const string TABLE = "ResElementLevelGain";

		// Token: 0x0400371E RID: 14110
		private const string COMMAND = "select BinData from `ResElementLevelGain` where TargetType=?";

		// Token: 0x0400371F RID: 14111
		private const string KEY_PREFIX = "ResElementLevelGainByTargetType";

		// Token: 0x04003720 RID: 14112
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003721 RID: 14113
		private static int HandleId;
	}
}
