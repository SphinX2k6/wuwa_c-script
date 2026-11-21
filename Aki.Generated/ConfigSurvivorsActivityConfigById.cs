using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6C RID: 2668
	public class ConfigSurvivorsActivityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E9C RID: 16028 RVA: 0x001BE9C4 File Offset: 0x001BCBC4
		static ConfigSurvivorsActivityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsActivityConfigById.CreateStaticDefaultValue), new Action(ConfigSurvivorsActivityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x001BE9E4 File Offset: 0x001BCBE4
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

		// Token: 0x06003E9E RID: 16030 RVA: 0x001BEA63 File Offset: 0x001BCC63
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsActivityConfigById.LogPair = null;
			ConfigSurvivorsActivityConfigById.HandleId = 0;
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x001BEA71 File Offset: 0x001BCC71
		public static void Init()
		{
			ConfigSurvivorsActivityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsActivityConfigById.HandleId, "db_survivors.db", "select BinData from `SurvivorsActivityConfig` where Id=?");
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x001BEA8C File Offset: 0x001BCC8C
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

		// Token: 0x040048DA RID: 18650
		private const string DB = "db_survivors.db";

		// Token: 0x040048DB RID: 18651
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x040048DC RID: 18652
		private const string TABLE = "SurvivorsActivityConfig";

		// Token: 0x040048DD RID: 18653
		private const string COMMAND = "select BinData from `SurvivorsActivityConfig` where Id=?";

		// Token: 0x040048DE RID: 18654
		private const string KEY_PREFIX = "SurvivorsActivityConfigById";

		// Token: 0x040048DF RID: 18655
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048E0 RID: 18656
		private static int HandleId;
	}
}
