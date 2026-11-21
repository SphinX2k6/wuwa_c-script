using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FF RID: 2047
	public class ConfigResElementLevelGainByTargetType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600300C RID: 12300 RVA: 0x0016C3CF File Offset: 0x0016A5CF
		static ConfigResElementLevelGainByTargetType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigResElementLevelGainByTargetType.CreateStaticDefaultValue), new Action(ConfigResElementLevelGainByTargetType.ResetStaticDefaultValue));
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x0016C3F0 File Offset: 0x0016A5F0
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

		// Token: 0x0600300E RID: 12302 RVA: 0x0016C46F File Offset: 0x0016A66F
		public static void ResetStaticDefaultValue()
		{
			ConfigResElementLevelGainByTargetType.LogPair = null;
			ConfigResElementLevelGainByTargetType.HandleId = 0;
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x0016C47D File Offset: 0x0016A67D
		public static void Init()
		{
			ConfigResElementLevelGainByTargetType.HandleId = ConfigCommon.InitDataStatement(ConfigResElementLevelGainByTargetType.HandleId, "db_permanentrogue.db", "select BinData from `ResElementLevelGain` where TargetType=?");
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x0016C498 File Offset: 0x0016A698
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

		// Token: 0x040037DF RID: 14303
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040037E0 RID: 14304
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040037E1 RID: 14305
		private const string TABLE = "ResElementLevelGain";

		// Token: 0x040037E2 RID: 14306
		private const string COMMAND = "select BinData from `ResElementLevelGain` where TargetType=?";

		// Token: 0x040037E3 RID: 14307
		private const string KEY_PREFIX = "ResElementLevelGainByTargetType";

		// Token: 0x040037E4 RID: 14308
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037E5 RID: 14309
		private static int HandleId;
	}
}
