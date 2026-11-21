using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035B RID: 859
	public class ConfigFoleySynthBoneConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001427 RID: 5159 RVA: 0x000CEDE7 File Offset: 0x000CCFE7
		static ConfigFoleySynthBoneConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFoleySynthBoneConfigById.CreateStaticDefaultValue), new Action(ConfigFoleySynthBoneConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000CEE08 File Offset: 0x000CD008
		public static void CreateStaticDefaultValue()
		{
			ConfigFoleySynthBoneConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFoleySynthBoneConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "FoleySynthBoneConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FoleySynthBoneConfig` where Id=?")
			});
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000CEE87 File Offset: 0x000CD087
		public static void ResetStaticDefaultValue()
		{
			ConfigFoleySynthBoneConfigById.LogPair = null;
			ConfigFoleySynthBoneConfigById.HandleId = 0;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000CEE95 File Offset: 0x000CD095
		public static void Init()
		{
			ConfigFoleySynthBoneConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFoleySynthBoneConfigById.HandleId, "db_entity_audio.db", "select BinData from `FoleySynthBoneConfig` where Id=?");
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000CEEB0 File Offset: 0x000CD0B0
		public static FoleySynthBoneConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFoleySynthBoneConfigById.HandleId, ConfigFoleySynthBoneConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FoleySynthBoneConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FoleySynthBoneConfig?(FoleySynthBoneConfig.GetRootAsFoleySynthBoneConfig(configBuffer));
				}
			}
			ConfigFoleySynthBoneConfigById.LogPair.Clear();
			ConfigFoleySynthBoneConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFoleySynthBoneConfigById.HandleId, 1, p0Id, ConfigFoleySynthBoneConfigById.LogPair) || ConfigCommon.Step(ConfigFoleySynthBoneConfigById.HandleId, true, ConfigFoleySynthBoneConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFoleySynthBoneConfigById.HandleId, ConfigFoleySynthBoneConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFoleySynthBoneConfigById.HandleId, 0, ConfigFoleySynthBoneConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFoleySynthBoneConfigById.HandleId, ConfigFoleySynthBoneConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FoleySynthBoneConfig rootAsFoleySynthBoneConfig = FoleySynthBoneConfig.GetRootAsFoleySynthBoneConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FoleySynthBoneConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFoleySynthBoneConfigById.HandleId, ConfigFoleySynthBoneConfigById.LogPair);
			return new FoleySynthBoneConfig?(rootAsFoleySynthBoneConfig);
		}

		// Token: 0x04001761 RID: 5985
		private const string DB = "db_entity_audio.db";

		// Token: 0x04001762 RID: 5986
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x04001763 RID: 5987
		private const string TABLE = "FoleySynthBoneConfig";

		// Token: 0x04001764 RID: 5988
		private const string COMMAND = "select BinData from `FoleySynthBoneConfig` where Id=?";

		// Token: 0x04001765 RID: 5989
		private const string KEY_PREFIX = "FoleySynthBoneConfigById";

		// Token: 0x04001766 RID: 5990
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001767 RID: 5991
		private static int HandleId;
	}
}
