using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000347 RID: 839
	public class ConfigFoleySynthConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013AF RID: 5039 RVA: 0x000C8B24 File Offset: 0x000C6D24
		static ConfigFoleySynthConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFoleySynthConfigById.CreateStaticDefaultValue), new Action(ConfigFoleySynthConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x000C8B44 File Offset: 0x000C6D44
		public static void CreateStaticDefaultValue()
		{
			ConfigFoleySynthConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFoleySynthConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "FoleySynthConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FoleySynthConfig` where Id=?")
			});
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x000C8BC3 File Offset: 0x000C6DC3
		public static void ResetStaticDefaultValue()
		{
			ConfigFoleySynthConfigById.LogPair = null;
			ConfigFoleySynthConfigById.HandleId = 0;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000C8BD1 File Offset: 0x000C6DD1
		public static void Init()
		{
			ConfigFoleySynthConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFoleySynthConfigById.HandleId, "db_entity_audio.db", "select BinData from `FoleySynthConfig` where Id=?");
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000C8BEC File Offset: 0x000C6DEC
		public static FoleySynthConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFoleySynthConfigById.HandleId, ConfigFoleySynthConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FoleySynthConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FoleySynthConfig?(FoleySynthConfig.GetRootAsFoleySynthConfig(configBuffer));
				}
			}
			ConfigFoleySynthConfigById.LogPair.Clear();
			ConfigFoleySynthConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFoleySynthConfigById.HandleId, 1, p0Id, ConfigFoleySynthConfigById.LogPair) || ConfigCommon.Step(ConfigFoleySynthConfigById.HandleId, true, ConfigFoleySynthConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFoleySynthConfigById.HandleId, ConfigFoleySynthConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFoleySynthConfigById.HandleId, 0, ConfigFoleySynthConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFoleySynthConfigById.HandleId, ConfigFoleySynthConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FoleySynthConfig rootAsFoleySynthConfig = FoleySynthConfig.GetRootAsFoleySynthConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FoleySynthConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFoleySynthConfigById.HandleId, ConfigFoleySynthConfigById.LogPair);
			return new FoleySynthConfig?(rootAsFoleySynthConfig);
		}

		// Token: 0x040016D5 RID: 5845
		private const string DB = "db_entity_audio.db";

		// Token: 0x040016D6 RID: 5846
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x040016D7 RID: 5847
		private const string TABLE = "FoleySynthConfig";

		// Token: 0x040016D8 RID: 5848
		private const string COMMAND = "select BinData from `FoleySynthConfig` where Id=?";

		// Token: 0x040016D9 RID: 5849
		private const string KEY_PREFIX = "FoleySynthConfigById";

		// Token: 0x040016DA RID: 5850
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016DB RID: 5851
		private static int HandleId;
	}
}
