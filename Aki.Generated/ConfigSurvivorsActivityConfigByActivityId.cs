using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6B RID: 2667
	public class ConfigSurvivorsActivityConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E96 RID: 16022 RVA: 0x001BE77C File Offset: 0x001BC97C
		static ConfigSurvivorsActivityConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsActivityConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsActivityConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x001BE79C File Offset: 0x001BC99C
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsActivityConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsActivityConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_活动.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsActivityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsActivityConfig` where ActivityId=?")
			});
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x001BE81B File Offset: 0x001BCA1B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsActivityConfigByActivityId.LogPair = null;
			ConfigSurvivorsActivityConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x001BE829 File Offset: 0x001BCA29
		public static void Init()
		{
			ConfigSurvivorsActivityConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsActivityConfigByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsActivityConfig` where ActivityId=?");
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x001BE844 File Offset: 0x001BCA44
		public static SurvivorsActivityConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsActivityConfigByActivityId.HandleId, ConfigSurvivorsActivityConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsActivityConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsActivityConfig?(SurvivorsActivityConfig.GetRootAsSurvivorsActivityConfig(configBuffer));
				}
			}
			ConfigSurvivorsActivityConfigByActivityId.LogPair.Clear();
			ConfigSurvivorsActivityConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsActivityConfigByActivityId.HandleId, 1, p0ActivityId, ConfigSurvivorsActivityConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigSurvivorsActivityConfigByActivityId.HandleId, true, ConfigSurvivorsActivityConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsActivityConfigByActivityId.HandleId, ConfigSurvivorsActivityConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsActivityConfigByActivityId.HandleId, 0, ConfigSurvivorsActivityConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsActivityConfigByActivityId.HandleId, ConfigSurvivorsActivityConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsActivityConfig rootAsSurvivorsActivityConfig = SurvivorsActivityConfig.GetRootAsSurvivorsActivityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsActivityConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsActivityConfigByActivityId.HandleId, ConfigSurvivorsActivityConfigByActivityId.LogPair);
			return new SurvivorsActivityConfig?(rootAsSurvivorsActivityConfig);
		}

		// Token: 0x040048D3 RID: 18643
		private const string DB = "db_survivors.db";

		// Token: 0x040048D4 RID: 18644
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x040048D5 RID: 18645
		private const string TABLE = "SurvivorsActivityConfig";

		// Token: 0x040048D6 RID: 18646
		private const string COMMAND = "select BinData from `SurvivorsActivityConfig` where ActivityId=?";

		// Token: 0x040048D7 RID: 18647
		private const string KEY_PREFIX = "SurvivorsActivityConfigByActivityId";

		// Token: 0x040048D8 RID: 18648
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048D9 RID: 18649
		private static int HandleId;
	}
}
