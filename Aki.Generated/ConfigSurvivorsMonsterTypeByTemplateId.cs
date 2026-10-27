using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099F RID: 2463
	public class ConfigSurvivorsMonsterTypeByTemplateId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039CE RID: 14798 RVA: 0x001A0850 File Offset: 0x0019EA50
		static ConfigSurvivorsMonsterTypeByTemplateId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsMonsterTypeByTemplateId.CreateStaticDefaultValue), new Action(ConfigSurvivorsMonsterTypeByTemplateId.ResetStaticDefaultValue));
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x001A0870 File Offset: 0x0019EA70
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

		// Token: 0x060039D0 RID: 14800 RVA: 0x001A08EF File Offset: 0x0019EAEF
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsMonsterTypeByTemplateId.LogPair = null;
			ConfigSurvivorsMonsterTypeByTemplateId.HandleId = 0;
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x001A08FD File Offset: 0x0019EAFD
		public static void Init()
		{
			ConfigSurvivorsMonsterTypeByTemplateId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsMonsterTypeByTemplateId.HandleId, "db_survivors.db", "select BinData from `SurvivorsMonsterType` where TemplateId=?");
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x001A0918 File Offset: 0x0019EB18
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

		// Token: 0x0400433F RID: 17215
		private const string DB = "db_survivors.db";

		// Token: 0x04004340 RID: 17216
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x04004341 RID: 17217
		private const string TABLE = "SurvivorsMonsterType";

		// Token: 0x04004342 RID: 17218
		private const string COMMAND = "select BinData from `SurvivorsMonsterType` where TemplateId=?";

		// Token: 0x04004343 RID: 17219
		private const string KEY_PREFIX = "SurvivorsMonsterTypeByTemplateId";

		// Token: 0x04004344 RID: 17220
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004345 RID: 17221
		private static int HandleId;
	}
}
