using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017F RID: 383
	public class ConfigCombinationAxisById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008FB RID: 2299 RVA: 0x0008C2BF File Offset: 0x0008A4BF
		static ConfigCombinationAxisById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationAxisById.CreateStaticDefaultValue), new Action(ConfigCombinationAxisById.ResetStaticDefaultValue));
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0008C2E0 File Offset: 0x0008A4E0
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

		// Token: 0x060008FD RID: 2301 RVA: 0x0008C35F File Offset: 0x0008A55F
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationAxisById.LogPair = null;
			ConfigCombinationAxisById.HandleId = 0;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0008C36D File Offset: 0x0008A56D
		public static void Init()
		{
			ConfigCombinationAxisById.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationAxisById.HandleId, "db_input_settings.db", "select BinData from `CombinationAxis` where Id=?");
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0008C388 File Offset: 0x0008A588
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

		// Token: 0x04000A5D RID: 2653
		private const string DB = "db_input_settings.db";

		// Token: 0x04000A5E RID: 2654
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000A5F RID: 2655
		private const string TABLE = "CombinationAxis";

		// Token: 0x04000A60 RID: 2656
		private const string COMMAND = "select BinData from `CombinationAxis` where Id=?";

		// Token: 0x04000A61 RID: 2657
		private const string KEY_PREFIX = "CombinationAxisById";

		// Token: 0x04000A62 RID: 2658
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A63 RID: 2659
		private static int HandleId;
	}
}
