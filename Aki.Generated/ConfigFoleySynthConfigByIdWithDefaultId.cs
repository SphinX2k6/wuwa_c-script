using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000348 RID: 840
	public class ConfigFoleySynthConfigByIdWithDefaultId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013B5 RID: 5045 RVA: 0x000C8D6C File Offset: 0x000C6F6C
		static ConfigFoleySynthConfigByIdWithDefaultId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFoleySynthConfigByIdWithDefaultId.CreateStaticDefaultValue), new Action(ConfigFoleySynthConfigByIdWithDefaultId.ResetStaticDefaultValue));
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x000C8D8C File Offset: 0x000C6F8C
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

		// Token: 0x060013B7 RID: 5047 RVA: 0x000C8E0B File Offset: 0x000C700B
		public static void ResetStaticDefaultValue()
		{
			ConfigFoleySynthConfigByIdWithDefaultId.LogPair = null;
			ConfigFoleySynthConfigByIdWithDefaultId.HandleId = 0;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x000C8E19 File Offset: 0x000C7019
		public static void Init()
		{
			ConfigFoleySynthConfigByIdWithDefaultId.HandleId = ConfigCommon.InitDataStatement(ConfigFoleySynthConfigByIdWithDefaultId.HandleId, "db_entity_audio.db", "select BinData from `FoleySynthConfig` where id = ? AND (SELECT count() from `FoleySynthConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `FoleySynthConfig` WHERE id = ?) >0;");
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000C8E34 File Offset: 0x000C7034
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

		// Token: 0x040016DC RID: 5852
		private const string DB = "db_entity_audio.db";

		// Token: 0x040016DD RID: 5853
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x040016DE RID: 5854
		private const string TABLE = "FoleySynthConfig";

		// Token: 0x040016DF RID: 5855
		private const string COMMAND = "select BinData from `FoleySynthConfig` where id = ? AND (SELECT count() from `FoleySynthConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `FoleySynthConfig` WHERE id = ?) >0;";

		// Token: 0x040016E0 RID: 5856
		private const string KEY_PREFIX = "FoleySynthConfigByIdWithDefaultId";

		// Token: 0x040016E1 RID: 5857
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016E2 RID: 5858
		private static int HandleId;
	}
}
