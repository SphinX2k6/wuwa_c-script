using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CE RID: 974
	public class ConfigHandBookQuestTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016DB RID: 5851 RVA: 0x000DAAFB File Offset: 0x000D8CFB
		static ConfigHandBookQuestTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHandBookQuestTabById.CreateStaticDefaultValue), new Action(ConfigHandBookQuestTabById.ResetStaticDefaultValue));
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x000DAB1C File Offset: 0x000D8D1C
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

		// Token: 0x060016DD RID: 5853 RVA: 0x000DAB9B File Offset: 0x000D8D9B
		public static void ResetStaticDefaultValue()
		{
			ConfigHandBookQuestTabById.LogPair = null;
			ConfigHandBookQuestTabById.HandleId = 0;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x000DABA9 File Offset: 0x000D8DA9
		public static void Init()
		{
			ConfigHandBookQuestTabById.HandleId = ConfigCommon.InitDataStatement(ConfigHandBookQuestTabById.HandleId, "db_handbook.db", "select BinData from `HandBookQuestTab` where Id=?");
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x000DABC4 File Offset: 0x000D8DC4
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

		// Token: 0x04001A86 RID: 6790
		private const string DB = "db_handbook.db";

		// Token: 0x04001A87 RID: 6791
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001A88 RID: 6792
		private const string TABLE = "HandBookQuestTab";

		// Token: 0x04001A89 RID: 6793
		private const string COMMAND = "select BinData from `HandBookQuestTab` where Id=?";

		// Token: 0x04001A8A RID: 6794
		private const string KEY_PREFIX = "HandBookQuestTabById";

		// Token: 0x04001A8B RID: 6795
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A8C RID: 6796
		private static int HandleId;
	}
}
