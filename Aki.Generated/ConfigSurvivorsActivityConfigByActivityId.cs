using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000996 RID: 2454
	public class ConfigSurvivorsActivityConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003998 RID: 14744 RVA: 0x0019F3E8 File Offset: 0x0019D5E8
		static ConfigSurvivorsActivityConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsActivityConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsActivityConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0019F408 File Offset: 0x0019D608
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

		// Token: 0x0600399A RID: 14746 RVA: 0x0019F487 File Offset: 0x0019D687
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsActivityConfigByActivityId.LogPair = null;
			ConfigSurvivorsActivityConfigByActivityId.HandleId = 0;
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x0019F495 File Offset: 0x0019D695
		public static void Init()
		{
			ConfigSurvivorsActivityConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsActivityConfigByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsActivityConfig` where ActivityId=?");
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x0019F4B0 File Offset: 0x0019D6B0
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

		// Token: 0x04004300 RID: 17152
		private const string DB = "db_survivors.db";

		// Token: 0x04004301 RID: 17153
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x04004302 RID: 17154
		private const string TABLE = "SurvivorsActivityConfig";

		// Token: 0x04004303 RID: 17155
		private const string COMMAND = "select BinData from `SurvivorsActivityConfig` where ActivityId=?";

		// Token: 0x04004304 RID: 17156
		private const string KEY_PREFIX = "SurvivorsActivityConfigByActivityId";

		// Token: 0x04004305 RID: 17157
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004306 RID: 17158
		private static int HandleId;
	}
}
