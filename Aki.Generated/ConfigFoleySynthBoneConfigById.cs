using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000346 RID: 838
	public class ConfigFoleySynthBoneConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x000C88DB File Offset: 0x000C6ADB
		static ConfigFoleySynthBoneConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFoleySynthBoneConfigById.CreateStaticDefaultValue), new Action(ConfigFoleySynthBoneConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000C88FC File Offset: 0x000C6AFC
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

		// Token: 0x060013AB RID: 5035 RVA: 0x000C897B File Offset: 0x000C6B7B
		public static void ResetStaticDefaultValue()
		{
			ConfigFoleySynthBoneConfigById.LogPair = null;
			ConfigFoleySynthBoneConfigById.HandleId = 0;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x000C8989 File Offset: 0x000C6B89
		public static void Init()
		{
			ConfigFoleySynthBoneConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFoleySynthBoneConfigById.HandleId, "db_entity_audio.db", "select BinData from `FoleySynthBoneConfig` where Id=?");
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x000C89A4 File Offset: 0x000C6BA4
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

		// Token: 0x040016CE RID: 5838
		private const string DB = "db_entity_audio.db";

		// Token: 0x040016CF RID: 5839
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x040016D0 RID: 5840
		private const string TABLE = "FoleySynthBoneConfig";

		// Token: 0x040016D1 RID: 5841
		private const string COMMAND = "select BinData from `FoleySynthBoneConfig` where Id=?";

		// Token: 0x040016D2 RID: 5842
		private const string KEY_PREFIX = "FoleySynthBoneConfigById";

		// Token: 0x040016D3 RID: 5843
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016D4 RID: 5844
		private static int HandleId;
	}
}
