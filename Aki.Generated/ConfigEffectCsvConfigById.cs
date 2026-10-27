using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000257 RID: 599
	public class ConfigEffectCsvConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E0E RID: 3598 RVA: 0x000A8EE5 File Offset: 0x000A70E5
		static ConfigEffectCsvConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectCsvConfigById.CreateStaticDefaultValue), new Action(ConfigEffectCsvConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000A8F04 File Offset: 0x000A7104
		public static void CreateStaticDefaultValue()
		{
			ConfigEffectCsvConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEffectCsvConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_effectcsvconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.特效配置/*.csv*"),
				new ValueTuple<string, object>("表名", "EffectCsvConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EffectCsvConfig` where Id=?")
			});
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000A8F83 File Offset: 0x000A7183
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectCsvConfigById.LogPair = null;
			ConfigEffectCsvConfigById.HandleId = 0;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000A8F91 File Offset: 0x000A7191
		public static void Init()
		{
			ConfigEffectCsvConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEffectCsvConfigById.HandleId, "db_effectcsvconfig.db", "select BinData from `EffectCsvConfig` where Id=?");
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000A8FAC File Offset: 0x000A71AC
		public static EffectCsvConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEffectCsvConfigById.HandleId, ConfigEffectCsvConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EffectCsvConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EffectCsvConfig?(EffectCsvConfig.GetRootAsEffectCsvConfig(configBuffer));
				}
			}
			ConfigEffectCsvConfigById.LogPair.Clear();
			ConfigEffectCsvConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEffectCsvConfigById.HandleId, 1, p0Id, ConfigEffectCsvConfigById.LogPair) || ConfigCommon.Step(ConfigEffectCsvConfigById.HandleId, true, ConfigEffectCsvConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEffectCsvConfigById.HandleId, ConfigEffectCsvConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEffectCsvConfigById.HandleId, 0, ConfigEffectCsvConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEffectCsvConfigById.HandleId, ConfigEffectCsvConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EffectCsvConfig rootAsEffectCsvConfig = EffectCsvConfig.GetRootAsEffectCsvConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EffectCsvConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEffectCsvConfigById.HandleId, ConfigEffectCsvConfigById.LogPair);
			return new EffectCsvConfig?(rootAsEffectCsvConfig);
		}

		// Token: 0x04001045 RID: 4165
		private const string DB = "db_effectcsvconfig.db";

		// Token: 0x04001046 RID: 4166
		private const string FILE = "k.可视化编辑/c.Csv/t.特效配置/*.csv*";

		// Token: 0x04001047 RID: 4167
		private const string TABLE = "EffectCsvConfig";

		// Token: 0x04001048 RID: 4168
		private const string COMMAND = "select BinData from `EffectCsvConfig` where Id=?";

		// Token: 0x04001049 RID: 4169
		private const string KEY_PREFIX = "EffectCsvConfigById";

		// Token: 0x0400104A RID: 4170
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400104B RID: 4171
		private static int HandleId;
	}
}
