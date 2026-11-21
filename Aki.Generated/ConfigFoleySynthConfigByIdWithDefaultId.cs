using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035D RID: 861
	public class ConfigFoleySynthConfigByIdWithDefaultId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001433 RID: 5171 RVA: 0x000CF278 File Offset: 0x000CD478
		static ConfigFoleySynthConfigByIdWithDefaultId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFoleySynthConfigByIdWithDefaultId.CreateStaticDefaultValue), new Action(ConfigFoleySynthConfigByIdWithDefaultId.ResetStaticDefaultValue));
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000CF298 File Offset: 0x000CD498
		public static void CreateStaticDefaultValue()
		{
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "FoleySynthConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FoleySynthConfig` where id = ? AND (SELECT count() from `FoleySynthConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `FoleySynthConfig` WHERE id = ?) >0;")
			});
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x000CF317 File Offset: 0x000CD517
		public static void ResetStaticDefaultValue()
		{
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair = null;
			ConfigFoleySynthConfigByIdWithDefaultId.HandleId = 0;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000CF325 File Offset: 0x000CD525
		public static void Init()
		{
			ConfigFoleySynthConfigByIdWithDefaultId.HandleId = ConfigCommon.InitDataStatement(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, "db_entity_audio.db", "select BinData from `FoleySynthConfig` where id = ? AND (SELECT count() from `FoleySynthConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `FoleySynthConfig` WHERE id = ?) >0;");
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000CF340 File Offset: 0x000CD540
		public static FoleySynthConfig? GetConfig(int p0Id, int p1Id, int p2Id, int p3Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, ConfigFoleySynthConfigByIdWithDefaultId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
				defaultInterpolatedStringHandler.AppendFormatted("FoleySynthConfigByIdWithDefaultId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p3Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FoleySynthConfig?(FoleySynthConfig.GetRootAsFoleySynthConfig(configBuffer));
				}
			}
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair.Clear();
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p2Id));
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p3Id));
			if (!ConfigCommon.BindInt(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, 1, p0Id, ConfigFoleySynthConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindInt(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, 2, p1Id, ConfigFoleySynthConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindInt(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, 3, p2Id, ConfigFoleySynthConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindInt(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, 4, p3Id, ConfigFoleySynthConfigByIdWithDefaultId.LogPair) || ConfigCommon.Step(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, true, ConfigFoleySynthConfigByIdWithDefaultId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, ConfigFoleySynthConfigByIdWithDefaultId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, 0, ConfigFoleySynthConfigByIdWithDefaultId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, ConfigFoleySynthConfigByIdWithDefaultId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FoleySynthConfig rootAsFoleySynthConfig = FoleySynthConfig.GetRootAsFoleySynthConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
				defaultInterpolatedStringHandler.AppendFormatted("FoleySynthConfigByIdWithDefaultId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p3Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, ConfigFoleySynthConfigByIdWithDefaultId.LogPair);
			return new FoleySynthConfig?(rootAsFoleySynthConfig);
		}

		// Token: 0x0400176F RID: 5999
		private const string DB = "db_entity_audio.db";

		// Token: 0x04001770 RID: 6000
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x04001771 RID: 6001
		private const string TABLE = "FoleySynthConfig";

		// Token: 0x04001772 RID: 6002
		private const string COMMAND = "select BinData from `FoleySynthConfig` where id = ? AND (SELECT count() from `FoleySynthConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `FoleySynthConfig` WHERE id = ?) >0;";

		// Token: 0x04001773 RID: 6003
		private const string KEY_PREFIX = "FoleySynthConfigByIdWithDefaultId";

		// Token: 0x04001774 RID: 6004
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001775 RID: 6005
		private static int HandleId;
	}
}
