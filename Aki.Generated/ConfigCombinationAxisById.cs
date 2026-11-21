using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000191 RID: 401
	public class ConfigCombinationAxisById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x000921F7 File Offset: 0x000903F7
		static ConfigCombinationAxisById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationAxisById.CreateStaticDefaultValue), new Action(ConfigCombinationAxisById.ResetStaticDefaultValue));
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00092218 File Offset: 0x00090418
		public static void CreateStaticDefaultValue()
		{
			ConfigCombinationAxisById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCombinationAxisById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "CombinationAxis"),
				new ValueTuple<string, object>("语句", "select BinData from `CombinationAxis` where Id=?")
			});
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00092297 File Offset: 0x00090497
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationAxisById.LogPair = null;
			ConfigCombinationAxisById.HandleId = 0;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000922A5 File Offset: 0x000904A5
		public static void Init()
		{
			ConfigCombinationAxisById.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationAxisById.HandleId, "db_input_settings.db", "select BinData from `CombinationAxis` where Id=?");
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000922C0 File Offset: 0x000904C0
		public static CombinationAxis? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCombinationAxisById.HandleId, ConfigCombinationAxisById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CombinationAxisById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CombinationAxis?(CombinationAxis.GetRootAsCombinationAxis(configBuffer));
				}
			}
			ConfigCombinationAxisById.LogPair.Clear();
			ConfigCombinationAxisById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCombinationAxisById.HandleId, 1, p0Id, ConfigCombinationAxisById.LogPair) || ConfigCommon.Step(ConfigCombinationAxisById.HandleId, true, ConfigCombinationAxisById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCombinationAxisById.HandleId, ConfigCombinationAxisById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCombinationAxisById.HandleId, 0, ConfigCombinationAxisById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCombinationAxisById.HandleId, ConfigCombinationAxisById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CombinationAxis rootAsCombinationAxis = CombinationAxis.GetRootAsCombinationAxis(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CombinationAxisById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCombinationAxisById.HandleId, ConfigCombinationAxisById.LogPair);
			return new CombinationAxis?(rootAsCombinationAxis);
		}

		// Token: 0x04000ADB RID: 2779
		private const string DB = "db_input_settings.db";

		// Token: 0x04000ADC RID: 2780
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000ADD RID: 2781
		private const string TABLE = "CombinationAxis";

		// Token: 0x04000ADE RID: 2782
		private const string COMMAND = "select BinData from `CombinationAxis` where Id=?";

		// Token: 0x04000ADF RID: 2783
		private const string KEY_PREFIX = "CombinationAxisById";

		// Token: 0x04000AE0 RID: 2784
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AE1 RID: 2785
		private static int HandleId;
	}
}
