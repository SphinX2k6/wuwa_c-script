using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D2 RID: 466
	public class ConfigDangoBrawlObjectTemplateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x000975E0 File Offset: 0x000957E0
		static ConfigDangoBrawlObjectTemplateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlObjectTemplateById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlObjectTemplateById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00097600 File Offset: 0x00095800
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlObjectTemplateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlObjectTemplateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawlobjecttemplate.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/DangoBrawlObjectTemplate.csv"),
				new ValueTuple<string, object>("表名", "DangoBrawlObjectTemplate"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlObjectTemplate` where Id=?")
			});
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0009767F File Offset: 0x0009587F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlObjectTemplateById.LogPair = null;
			ConfigDangoBrawlObjectTemplateById.HandleId = 0;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0009768D File Offset: 0x0009588D
		public static void Init()
		{
			ConfigDangoBrawlObjectTemplateById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlObjectTemplateById.HandleId, "db_dangobrawlobjecttemplate.db", "select BinData from `DangoBrawlObjectTemplate` where Id=?");
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x000976A8 File Offset: 0x000958A8
		public static DangoBrawlObjectTemplate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlObjectTemplateById.HandleId, ConfigDangoBrawlObjectTemplateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlObjectTemplateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlObjectTemplate?(DangoBrawlObjectTemplate.GetRootAsDangoBrawlObjectTemplate(configBuffer));
				}
			}
			ConfigDangoBrawlObjectTemplateById.LogPair.Clear();
			ConfigDangoBrawlObjectTemplateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlObjectTemplateById.HandleId, 1, p0Id, ConfigDangoBrawlObjectTemplateById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlObjectTemplateById.HandleId, true, ConfigDangoBrawlObjectTemplateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlObjectTemplateById.HandleId, ConfigDangoBrawlObjectTemplateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlObjectTemplateById.HandleId, 0, ConfigDangoBrawlObjectTemplateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlObjectTemplateById.HandleId, ConfigDangoBrawlObjectTemplateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlObjectTemplate rootAsDangoBrawlObjectTemplate = DangoBrawlObjectTemplate.GetRootAsDangoBrawlObjectTemplate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlObjectTemplateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlObjectTemplateById.HandleId, ConfigDangoBrawlObjectTemplateById.LogPair);
			return new DangoBrawlObjectTemplate?(rootAsDangoBrawlObjectTemplate);
		}

		// Token: 0x04000CA2 RID: 3234
		private const string DB = "db_dangobrawlobjecttemplate.db";

		// Token: 0x04000CA3 RID: 3235
		private const string FILE = "UniverseEditor/DangoBrawlObjectTemplate.csv";

		// Token: 0x04000CA4 RID: 3236
		private const string TABLE = "DangoBrawlObjectTemplate";

		// Token: 0x04000CA5 RID: 3237
		private const string COMMAND = "select BinData from `DangoBrawlObjectTemplate` where Id=?";

		// Token: 0x04000CA6 RID: 3238
		private const string KEY_PREFIX = "DangoBrawlObjectTemplateById";

		// Token: 0x04000CA7 RID: 3239
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CA8 RID: 3240
		private static int HandleId;
	}
}
