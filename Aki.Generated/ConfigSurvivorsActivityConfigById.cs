using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000997 RID: 2455
	public class ConfigSurvivorsActivityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600399E RID: 14750 RVA: 0x0019F630 File Offset: 0x0019D830
		static ConfigSurvivorsActivityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsActivityConfigById.CreateStaticDefaultValue), new Action(ConfigSurvivorsActivityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x0019F650 File Offset: 0x0019D850
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsActivityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsActivityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_活动.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsActivityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsActivityConfig` where Id=?")
			});
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x0019F6CF File Offset: 0x0019D8CF
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsActivityConfigById.LogPair = null;
			ConfigSurvivorsActivityConfigById.HandleId = 0;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x0019F6DD File Offset: 0x0019D8DD
		public static void Init()
		{
			ConfigSurvivorsActivityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsActivityConfigById.HandleId, "db_survivors.db", "select BinData from `SurvivorsActivityConfig` where Id=?");
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0019F6F8 File Offset: 0x0019D8F8
		public static SurvivorsActivityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsActivityConfigById.HandleId, ConfigSurvivorsActivityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsActivityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsActivityConfig?(SurvivorsActivityConfig.GetRootAsSurvivorsActivityConfig(configBuffer));
				}
			}
			ConfigSurvivorsActivityConfigById.LogPair.Clear();
			ConfigSurvivorsActivityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsActivityConfigById.HandleId, 1, p0Id, ConfigSurvivorsActivityConfigById.LogPair) || ConfigCommon.Step(ConfigSurvivorsActivityConfigById.HandleId, true, ConfigSurvivorsActivityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsActivityConfigById.HandleId, ConfigSurvivorsActivityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsActivityConfigById.HandleId, 0, ConfigSurvivorsActivityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsActivityConfigById.HandleId, ConfigSurvivorsActivityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsActivityConfig rootAsSurvivorsActivityConfig = SurvivorsActivityConfig.GetRootAsSurvivorsActivityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsActivityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsActivityConfigById.HandleId, ConfigSurvivorsActivityConfigById.LogPair);
			return new SurvivorsActivityConfig?(rootAsSurvivorsActivityConfig);
		}

		// Token: 0x04004307 RID: 17159
		private const string DB = "db_survivors.db";

		// Token: 0x04004308 RID: 17160
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x04004309 RID: 17161
		private const string TABLE = "SurvivorsActivityConfig";

		// Token: 0x0400430A RID: 17162
		private const string COMMAND = "select BinData from `SurvivorsActivityConfig` where Id=?";

		// Token: 0x0400430B RID: 17163
		private const string KEY_PREFIX = "SurvivorsActivityConfigById";

		// Token: 0x0400430C RID: 17164
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400430D RID: 17165
		private static int HandleId;
	}
}
