using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AF RID: 2479
	public class ConfigSurvivorsTemplateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A2E RID: 14894 RVA: 0x001A2BCB File Offset: 0x001A0DCB
		static ConfigSurvivorsTemplateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTemplateById.CreateStaticDefaultValue), new Action(ConfigSurvivorsTemplateById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x001A2BEC File Offset: 0x001A0DEC
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTemplateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTemplateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTemplate"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTemplate` where Id=?")
			});
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x001A2C6B File Offset: 0x001A0E6B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTemplateById.LogPair = null;
			ConfigSurvivorsTemplateById.HandleId = 0;
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x001A2C79 File Offset: 0x001A0E79
		public static void Init()
		{
			ConfigSurvivorsTemplateById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTemplateById.HandleId, "db_survivors.db", "select BinData from `SurvivorsTemplate` where Id=?");
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x001A2C94 File Offset: 0x001A0E94
		public static SurvivorsTemplate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTemplateById.HandleId, ConfigSurvivorsTemplateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTemplateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsTemplate?(SurvivorsTemplate.GetRootAsSurvivorsTemplate(configBuffer));
				}
			}
			ConfigSurvivorsTemplateById.LogPair.Clear();
			ConfigSurvivorsTemplateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsTemplateById.HandleId, 1, p0Id, ConfigSurvivorsTemplateById.LogPair) || ConfigCommon.Step(ConfigSurvivorsTemplateById.HandleId, true, ConfigSurvivorsTemplateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsTemplateById.HandleId, ConfigSurvivorsTemplateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTemplateById.HandleId, 0, ConfigSurvivorsTemplateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsTemplateById.HandleId, ConfigSurvivorsTemplateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsTemplate rootAsSurvivorsTemplate = SurvivorsTemplate.GetRootAsSurvivorsTemplate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTemplateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsTemplateById.HandleId, ConfigSurvivorsTemplateById.LogPair);
			return new SurvivorsTemplate?(rootAsSurvivorsTemplate);
		}

		// Token: 0x040043AF RID: 17327
		private const string DB = "db_survivors.db";

		// Token: 0x040043B0 RID: 17328
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x040043B1 RID: 17329
		private const string TABLE = "SurvivorsTemplate";

		// Token: 0x040043B2 RID: 17330
		private const string COMMAND = "select BinData from `SurvivorsTemplate` where Id=?";

		// Token: 0x040043B3 RID: 17331
		private const string KEY_PREFIX = "SurvivorsTemplateById";

		// Token: 0x040043B4 RID: 17332
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043B5 RID: 17333
		private static int HandleId;
	}
}
