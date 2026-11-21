using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E4 RID: 996
	public class ConfigHandBookQuestTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x000E124F File Offset: 0x000DF44F
		static ConfigHandBookQuestTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHandBookQuestTabById.CreateStaticDefaultValue), new Action(ConfigHandBookQuestTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000E1270 File Offset: 0x000DF470
		public static void CreateStaticDefaultValue()
		{
			ConfigHandBookQuestTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHandBookQuestTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "HandBookQuestTab"),
				new ValueTuple<string, object>("语句", "select BinData from `HandBookQuestTab` where Id=?")
			});
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000E12EF File Offset: 0x000DF4EF
		public static void ResetStaticDefaultValue()
		{
			ConfigHandBookQuestTabById.LogPair = null;
			ConfigHandBookQuestTabById.HandleId = 0;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000E12FD File Offset: 0x000DF4FD
		public static void Init()
		{
			ConfigHandBookQuestTabById.HandleId = ConfigCommon.InitDataStatement(ConfigHandBookQuestTabById.HandleId, "db_handbook.db", "select BinData from `HandBookQuestTab` where Id=?");
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000E1318 File Offset: 0x000DF518
		public static HandBookQuestTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHandBookQuestTabById.HandleId, ConfigHandBookQuestTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HandBookQuestTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HandBookQuestTab?(HandBookQuestTab.GetRootAsHandBookQuestTab(configBuffer));
				}
			}
			ConfigHandBookQuestTabById.LogPair.Clear();
			ConfigHandBookQuestTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHandBookQuestTabById.HandleId, 1, p0Id, ConfigHandBookQuestTabById.LogPair) || ConfigCommon.Step(ConfigHandBookQuestTabById.HandleId, true, ConfigHandBookQuestTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHandBookQuestTabById.HandleId, ConfigHandBookQuestTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHandBookQuestTabById.HandleId, 0, ConfigHandBookQuestTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHandBookQuestTabById.HandleId, ConfigHandBookQuestTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HandBookQuestTab rootAsHandBookQuestTab = HandBookQuestTab.GetRootAsHandBookQuestTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HandBookQuestTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHandBookQuestTabById.HandleId, ConfigHandBookQuestTabById.LogPair);
			return new HandBookQuestTab?(rootAsHandBookQuestTab);
		}

		// Token: 0x04001B20 RID: 6944
		private const string DB = "db_handbook.db";

		// Token: 0x04001B21 RID: 6945
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001B22 RID: 6946
		private const string TABLE = "HandBookQuestTab";

		// Token: 0x04001B23 RID: 6947
		private const string COMMAND = "select BinData from `HandBookQuestTab` where Id=?";

		// Token: 0x04001B24 RID: 6948
		private const string KEY_PREFIX = "HandBookQuestTabById";

		// Token: 0x04001B25 RID: 6949
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B26 RID: 6950
		private static int HandleId;
	}
}
