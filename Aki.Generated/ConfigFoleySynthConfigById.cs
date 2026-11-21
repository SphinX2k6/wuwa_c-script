using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035C RID: 860
	public class ConfigFoleySynthConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600142D RID: 5165 RVA: 0x000CF030 File Offset: 0x000CD230
		static ConfigFoleySynthConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFoleySynthConfigById.CreateStaticDefaultValue), new Action(ConfigFoleySynthConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000CF050 File Offset: 0x000CD250
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

		// Token: 0x0600142F RID: 5167 RVA: 0x000CF0CF File Offset: 0x000CD2CF
		public static void ResetStaticDefaultValue()
		{
			ConfigFoleySynthConfigById.LogPair = null;
			ConfigFoleySynthConfigById.HandleId = 0;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000CF0DD File Offset: 0x000CD2DD
		public static void Init()
		{
			ConfigFoleySynthConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFoleySynthConfigById.HandleId, "db_entity_audio.db", "select BinData from `FoleySynthConfig` where Id=?");
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000CF0F8 File Offset: 0x000CD2F8
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

		// Token: 0x04001768 RID: 5992
		private const string DB = "db_entity_audio.db";

		// Token: 0x04001769 RID: 5993
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x0400176A RID: 5994
		private const string TABLE = "FoleySynthConfig";

		// Token: 0x0400176B RID: 5995
		private const string COMMAND = "select BinData from `FoleySynthConfig` where Id=?";

		// Token: 0x0400176C RID: 5996
		private const string KEY_PREFIX = "FoleySynthConfigById";

		// Token: 0x0400176D RID: 5997
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400176E RID: 5998
		private static int HandleId;
	}
}
