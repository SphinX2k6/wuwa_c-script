using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018D RID: 397
	public class ConfigCombinationActionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600094F RID: 2383 RVA: 0x000919EB File Offset: 0x0008FBEB
		static ConfigCombinationActionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationActionById.CreateStaticDefaultValue), new Action(ConfigCombinationActionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00091A0C File Offset: 0x0008FC0C
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

		// Token: 0x06000951 RID: 2385 RVA: 0x00091A8B File Offset: 0x0008FC8B
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationActionById.LogPair = null;
			ConfigCombinationActionById.HandleId = 0;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00091A99 File Offset: 0x0008FC99
		public static void Init()
		{
			ConfigCombinationActionById.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationActionById.HandleId, "db_input_settings.db", "select BinData from `CombinationAction` where Id=?");
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00091AB4 File Offset: 0x0008FCB4
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

		// Token: 0x04000ABF RID: 2751
		private const string DB = "db_input_settings.db";

		// Token: 0x04000AC0 RID: 2752
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000AC1 RID: 2753
		private const string TABLE = "CombinationAction";

		// Token: 0x04000AC2 RID: 2754
		private const string COMMAND = "select BinData from `CombinationAction` where Id=?";

		// Token: 0x04000AC3 RID: 2755
		private const string KEY_PREFIX = "CombinationActionById";

		// Token: 0x04000AC4 RID: 2756
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AC5 RID: 2757
		private static int HandleId;
	}
}
