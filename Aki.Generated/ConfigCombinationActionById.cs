using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017B RID: 379
	public class ConfigCombinationActionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x0008BAB3 File Offset: 0x00089CB3
		static ConfigCombinationActionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationActionById.CreateStaticDefaultValue), new Action(ConfigCombinationActionById.ResetStaticDefaultValue));
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0008BAD4 File Offset: 0x00089CD4
		public static void CreateStaticDefaultValue()
		{
			ConfigCombinationActionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCombinationActionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "CombinationAction"),
				new ValueTuple<string, object>("语句", "select BinData from `CombinationAction` where Id=?")
			});
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0008BB53 File Offset: 0x00089D53
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationActionById.LogPair = null;
			ConfigCombinationActionById.HandleId = 0;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0008BB61 File Offset: 0x00089D61
		public static void Init()
		{
			ConfigCombinationActionById.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationActionById.HandleId, "db_input_settings.db", "select BinData from `CombinationAction` where Id=?");
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0008BB7C File Offset: 0x00089D7C
		public static CombinationAction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCombinationActionById.HandleId, ConfigCombinationActionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CombinationActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CombinationAction?(CombinationAction.GetRootAsCombinationAction(configBuffer));
				}
			}
			ConfigCombinationActionById.LogPair.Clear();
			ConfigCombinationActionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCombinationActionById.HandleId, 1, p0Id, ConfigCombinationActionById.LogPair) || ConfigCommon.Step(ConfigCombinationActionById.HandleId, true, ConfigCombinationActionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCombinationActionById.HandleId, ConfigCombinationActionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCombinationActionById.HandleId, 0, ConfigCombinationActionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCombinationActionById.HandleId, ConfigCombinationActionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CombinationAction rootAsCombinationAction = CombinationAction.GetRootAsCombinationAction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CombinationActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCombinationActionById.HandleId, ConfigCombinationActionById.LogPair);
			return new CombinationAction?(rootAsCombinationAction);
		}

		// Token: 0x04000A41 RID: 2625
		private const string DB = "db_input_settings.db";

		// Token: 0x04000A42 RID: 2626
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000A43 RID: 2627
		private const string TABLE = "CombinationAction";

		// Token: 0x04000A44 RID: 2628
		private const string COMMAND = "select BinData from `CombinationAction` where Id=?";

		// Token: 0x04000A45 RID: 2629
		private const string KEY_PREFIX = "CombinationActionById";

		// Token: 0x04000A46 RID: 2630
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A47 RID: 2631
		private static int HandleId;
	}
}
