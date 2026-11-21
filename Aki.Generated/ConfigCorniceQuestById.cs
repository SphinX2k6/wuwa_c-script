using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BD RID: 445
	public class ConfigCorniceQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x00098280 File Offset: 0x00096480
		static ConfigCorniceQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCorniceQuestById.CreateStaticDefaultValue), new Action(ConfigCorniceQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000982A0 File Offset: 0x000964A0
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

		// Token: 0x06000A73 RID: 2675 RVA: 0x0009831F File Offset: 0x0009651F
		public static void ResetStaticDefaultValue()
		{
			ConfigCorniceQuestById.LogPair = null;
			ConfigCorniceQuestById.HandleId = 0;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0009832D File Offset: 0x0009652D
		public static void Init()
		{
			ConfigCorniceQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigCorniceQuestById.HandleId, "db_cornicechallenge.db", "select BinData from `CorniceQuest` where Id=?");
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00098348 File Offset: 0x00096548
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

		// Token: 0x04000C0F RID: 3087
		private const string DB = "db_cornicechallenge.db";

		// Token: 0x04000C10 RID: 3088
		private const string FILE = "s.数据收集异常活动.xlsx";

		// Token: 0x04000C11 RID: 3089
		private const string TABLE = "CorniceQuest";

		// Token: 0x04000C12 RID: 3090
		private const string COMMAND = "select BinData from `CorniceQuest` where Id=?";

		// Token: 0x04000C13 RID: 3091
		private const string KEY_PREFIX = "CorniceQuestById";

		// Token: 0x04000C14 RID: 3092
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C15 RID: 3093
		private static int HandleId;
	}
}
