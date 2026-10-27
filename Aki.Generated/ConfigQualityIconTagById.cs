using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076D RID: 1901
	public class ConfigQualityIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C9F RID: 11423 RVA: 0x0015568D File Offset: 0x0015388D
		static ConfigQualityIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQualityIconTagById.CreateStaticDefaultValue), new Action(ConfigQualityIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x001556AC File Offset: 0x001538AC
		public static void CreateStaticDefaultValue()
		{
			ConfigQualityIconTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQualityIconTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_component_config.db"),
				new ValueTuple<string, object>("文件", "t.通用组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "QualityIconTag"),
				new ValueTuple<string, object>("语句", "select BinData from `QualityIconTag` where Id=?")
			});
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x0015572B File Offset: 0x0015392B
		public static void ResetStaticDefaultValue()
		{
			ConfigQualityIconTagById.LogPair = null;
			ConfigQualityIconTagById.HandleId = 0;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00155739 File Offset: 0x00153939
		public static void Init()
		{
			ConfigQualityIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigQualityIconTagById.HandleId, "db_component_config.db", "select BinData from `QualityIconTag` where Id=?");
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x00155754 File Offset: 0x00153954
		public static QualityIconTag? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQualityIconTagById.HandleId, ConfigQualityIconTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("QualityIconTagById#" + p0Id);
				if (configBuffer != null)
				{
					return new QualityIconTag?(QualityIconTag.GetRootAsQualityIconTag(configBuffer));
				}
			}
			ConfigQualityIconTagById.LogPair.Clear();
			ConfigQualityIconTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigQualityIconTagById.HandleId, 1, p0Id, ConfigQualityIconTagById.LogPair) || ConfigCommon.Step(ConfigQualityIconTagById.HandleId, true, ConfigQualityIconTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQualityIconTagById.HandleId, ConfigQualityIconTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQualityIconTagById.HandleId, 0, ConfigQualityIconTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQualityIconTagById.HandleId, ConfigQualityIconTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QualityIconTag rootAsQualityIconTag = QualityIconTag.GetRootAsQualityIconTag(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("QualityIconTagById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQualityIconTagById.HandleId, ConfigQualityIconTagById.LogPair);
			return new QualityIconTag?(rootAsQualityIconTag);
		}

		// Token: 0x040033E1 RID: 13281
		private const string DB = "db_component_config.db";

		// Token: 0x040033E2 RID: 13282
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x040033E3 RID: 13283
		private const string TABLE = "QualityIconTag";

		// Token: 0x040033E4 RID: 13284
		private const string COMMAND = "select BinData from `QualityIconTag` where Id=?";

		// Token: 0x040033E5 RID: 13285
		private const string KEY_PREFIX = "QualityIconTagById";

		// Token: 0x040033E6 RID: 13286
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033E7 RID: 13287
		private static int HandleId;
	}
}
