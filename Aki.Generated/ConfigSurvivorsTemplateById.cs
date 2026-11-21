using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A84 RID: 2692
	public class ConfigSurvivorsTemplateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F2C RID: 16172 RVA: 0x001C1F5F File Offset: 0x001C015F
		static ConfigSurvivorsTemplateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTemplateById.CreateStaticDefaultValue), new Action(ConfigSurvivorsTemplateById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x001C1F80 File Offset: 0x001C0180
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

		// Token: 0x06003F2E RID: 16174 RVA: 0x001C1FFF File Offset: 0x001C01FF
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTemplateById.LogPair = null;
			ConfigSurvivorsTemplateById.HandleId = 0;
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x001C200D File Offset: 0x001C020D
		public static void Init()
		{
			ConfigSurvivorsTemplateById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTemplateById.HandleId, "db_survivors.db", "select BinData from `SurvivorsTemplate` where Id=?");
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x001C2028 File Offset: 0x001C0228
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

		// Token: 0x04004982 RID: 18818
		private const string DB = "db_survivors.db";

		// Token: 0x04004983 RID: 18819
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x04004984 RID: 18820
		private const string TABLE = "SurvivorsTemplate";

		// Token: 0x04004985 RID: 18821
		private const string COMMAND = "select BinData from `SurvivorsTemplate` where Id=?";

		// Token: 0x04004986 RID: 18822
		private const string KEY_PREFIX = "SurvivorsTemplateById";

		// Token: 0x04004987 RID: 18823
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004988 RID: 18824
		private static int HandleId;
	}
}
