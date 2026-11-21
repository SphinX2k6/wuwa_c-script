using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A74 RID: 2676
	public class ConfigSurvivorsMonsterTypeByTemplateId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ECC RID: 16076 RVA: 0x001BFBE4 File Offset: 0x001BDDE4
		static ConfigSurvivorsMonsterTypeByTemplateId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsMonsterTypeByTemplateId.CreateStaticDefaultValue), new Action(ConfigSurvivorsMonsterTypeByTemplateId.ResetStaticDefaultValue));
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x001BFC04 File Offset: 0x001BDE04
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsMonsterTypeByTemplateId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsMonsterTypeByTemplateId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsMonsterType"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsMonsterType` where TemplateId=?")
			});
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x001BFC83 File Offset: 0x001BDE83
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsMonsterTypeByTemplateId.LogPair = null;
			ConfigSurvivorsMonsterTypeByTemplateId.HandleId = 0;
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x001BFC91 File Offset: 0x001BDE91
		public static void Init()
		{
			ConfigSurvivorsMonsterTypeByTemplateId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, "db_survivors.db", "select BinData from `SurvivorsMonsterType` where TemplateId=?");
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x001BFCAC File Offset: 0x001BDEAC
		public static SurvivorsMonsterType? GetConfig(int p0TemplateId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, ConfigSurvivorsMonsterTypeByTemplateId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsMonsterTypeByTemplateId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TemplateId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsMonsterType?(SurvivorsMonsterType.GetRootAsSurvivorsMonsterType(configBuffer));
				}
			}
			ConfigSurvivorsMonsterTypeByTemplateId.LogPair.Clear();
			ConfigSurvivorsMonsterTypeByTemplateId.LogPair.Add(new ValueTuple<string, object>("TemplateId", p0TemplateId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, 1, p0TemplateId, ConfigSurvivorsMonsterTypeByTemplateId.LogPair) || ConfigCommon.Step(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, true, ConfigSurvivorsMonsterTypeByTemplateId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, ConfigSurvivorsMonsterTypeByTemplateId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, 0, ConfigSurvivorsMonsterTypeByTemplateId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, ConfigSurvivorsMonsterTypeByTemplateId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsMonsterType rootAsSurvivorsMonsterType = SurvivorsMonsterType.GetRootAsSurvivorsMonsterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsMonsterTypeByTemplateId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TemplateId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, ConfigSurvivorsMonsterTypeByTemplateId.LogPair);
			return new SurvivorsMonsterType?(rootAsSurvivorsMonsterType);
		}

		// Token: 0x04004912 RID: 18706
		private const string DB = "db_survivors.db";

		// Token: 0x04004913 RID: 18707
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x04004914 RID: 18708
		private const string TABLE = "SurvivorsMonsterType";

		// Token: 0x04004915 RID: 18709
		private const string COMMAND = "select BinData from `SurvivorsMonsterType` where TemplateId=?";

		// Token: 0x04004916 RID: 18710
		private const string KEY_PREFIX = "SurvivorsMonsterTypeByTemplateId";

		// Token: 0x04004917 RID: 18711
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004918 RID: 18712
		private static int HandleId;
	}
}
