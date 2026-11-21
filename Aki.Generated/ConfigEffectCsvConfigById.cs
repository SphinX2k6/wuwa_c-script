using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026B RID: 619
	public class ConfigEffectCsvConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E86 RID: 3718 RVA: 0x000AF1A9 File Offset: 0x000AD3A9
		static ConfigEffectCsvConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectCsvConfigById.CreateStaticDefaultValue), new Action(ConfigEffectCsvConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000AF1C8 File Offset: 0x000AD3C8
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

		// Token: 0x06000E88 RID: 3720 RVA: 0x000AF247 File Offset: 0x000AD447
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectCsvConfigById.LogPair = null;
			ConfigEffectCsvConfigById.HandleId = 0;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000AF255 File Offset: 0x000AD455
		public static void Init()
		{
			ConfigEffectCsvConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEffectCsvConfigById.HandleId, "db_effectcsvconfig.db", "select BinData from `EffectCsvConfig` where Id=?");
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000AF270 File Offset: 0x000AD470
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

		// Token: 0x040010D1 RID: 4305
		private const string DB = "db_effectcsvconfig.db";

		// Token: 0x040010D2 RID: 4306
		private const string FILE = "k.可视化编辑/c.Csv/t.特效配置/*.csv*";

		// Token: 0x040010D3 RID: 4307
		private const string TABLE = "EffectCsvConfig";

		// Token: 0x040010D4 RID: 4308
		private const string COMMAND = "select BinData from `EffectCsvConfig` where Id=?";

		// Token: 0x040010D5 RID: 4309
		private const string KEY_PREFIX = "EffectCsvConfigById";

		// Token: 0x040010D6 RID: 4310
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010D7 RID: 4311
		private static int HandleId;
	}
}
