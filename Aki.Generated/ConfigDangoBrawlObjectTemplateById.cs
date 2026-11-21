using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E4 RID: 484
	public class ConfigDangoBrawlObjectTemplateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x0009D518 File Offset: 0x0009B718
		static ConfigDangoBrawlObjectTemplateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlObjectTemplateById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlObjectTemplateById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0009D538 File Offset: 0x0009B738
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

		// Token: 0x06000B5D RID: 2909 RVA: 0x0009D5B7 File Offset: 0x0009B7B7
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlObjectTemplateById.LogPair = null;
			ConfigDangoBrawlObjectTemplateById.HandleId = 0;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0009D5C5 File Offset: 0x0009B7C5
		public static void Init()
		{
			ConfigDangoBrawlObjectTemplateById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlObjectTemplateById.HandleId, "db_dangobrawlobjecttemplate.db", "select BinData from `DangoBrawlObjectTemplate` where Id=?");
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0009D5E0 File Offset: 0x0009B7E0
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

		// Token: 0x04000D20 RID: 3360
		private const string DB = "db_dangobrawlobjecttemplate.db";

		// Token: 0x04000D21 RID: 3361
		private const string FILE = "UniverseEditor/DangoBrawlObjectTemplate.csv";

		// Token: 0x04000D22 RID: 3362
		private const string TABLE = "DangoBrawlObjectTemplate";

		// Token: 0x04000D23 RID: 3363
		private const string COMMAND = "select BinData from `DangoBrawlObjectTemplate` where Id=?";

		// Token: 0x04000D24 RID: 3364
		private const string KEY_PREFIX = "DangoBrawlObjectTemplateById";

		// Token: 0x04000D25 RID: 3365
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D26 RID: 3366
		private static int HandleId;
	}
}
