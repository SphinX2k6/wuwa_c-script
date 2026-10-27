using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AB RID: 427
	public class ConfigCorniceQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A05 RID: 2565 RVA: 0x00092348 File Offset: 0x00090548
		static ConfigCorniceQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCorniceQuestById.CreateStaticDefaultValue), new Action(ConfigCorniceQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00092368 File Offset: 0x00090568
		public static void CreateStaticDefaultValue()
		{
			ConfigCorniceQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCorniceQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cornicechallenge.db"),
				new ValueTuple<string, object>("文件", "s.数据收集异常活动.xlsx"),
				new ValueTuple<string, object>("表名", "CorniceQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `CorniceQuest` where Id=?")
			});
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x000923E7 File Offset: 0x000905E7
		public static void ResetStaticDefaultValue()
		{
			ConfigCorniceQuestById.LogPair = null;
			ConfigCorniceQuestById.HandleId = 0;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x000923F5 File Offset: 0x000905F5
		public static void Init()
		{
			ConfigCorniceQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigCorniceQuestById.HandleId, "db_cornicechallenge.db", "select BinData from `CorniceQuest` where Id=?");
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00092410 File Offset: 0x00090610
		public static CorniceQuest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCorniceQuestById.HandleId, ConfigCorniceQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CorniceQuest?(CorniceQuest.GetRootAsCorniceQuest(configBuffer));
				}
			}
			ConfigCorniceQuestById.LogPair.Clear();
			ConfigCorniceQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCorniceQuestById.HandleId, 1, p0Id, ConfigCorniceQuestById.LogPair) || ConfigCommon.Step(ConfigCorniceQuestById.HandleId, true, ConfigCorniceQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCorniceQuestById.HandleId, ConfigCorniceQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCorniceQuestById.HandleId, 0, ConfigCorniceQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCorniceQuestById.HandleId, ConfigCorniceQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CorniceQuest rootAsCorniceQuest = CorniceQuest.GetRootAsCorniceQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCorniceQuestById.HandleId, ConfigCorniceQuestById.LogPair);
			return new CorniceQuest?(rootAsCorniceQuest);
		}

		// Token: 0x04000B91 RID: 2961
		private const string DB = "db_cornicechallenge.db";

		// Token: 0x04000B92 RID: 2962
		private const string FILE = "s.数据收集异常活动.xlsx";

		// Token: 0x04000B93 RID: 2963
		private const string TABLE = "CorniceQuest";

		// Token: 0x04000B94 RID: 2964
		private const string COMMAND = "select BinData from `CorniceQuest` where Id=?";

		// Token: 0x04000B95 RID: 2965
		private const string KEY_PREFIX = "CorniceQuestById";

		// Token: 0x04000B96 RID: 2966
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B97 RID: 2967
		private static int HandleId;
	}
}
