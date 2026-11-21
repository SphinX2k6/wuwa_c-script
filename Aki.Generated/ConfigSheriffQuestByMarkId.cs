using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000967 RID: 2407
	public class ConfigSheriffQuestByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600387D RID: 14461 RVA: 0x0019BE37 File Offset: 0x0019A037
		static ConfigSheriffQuestByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffQuestByMarkId.CreateStaticDefaultValue), new Action(ConfigSheriffQuestByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x0019BE58 File Offset: 0x0019A058
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffQuestByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffQuestByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffQuest` where MarkId=?")
			});
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x0019BED7 File Offset: 0x0019A0D7
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffQuestByMarkId.LogPair = null;
			ConfigSheriffQuestByMarkId.HandleId = 0;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0019BEE5 File Offset: 0x0019A0E5
		public static void Init()
		{
			ConfigSheriffQuestByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffQuestByMarkId.HandleId, "db_sheriff.db", "select BinData from `SheriffQuest` where MarkId=?");
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0019BF00 File Offset: 0x0019A100
		public static SheriffQuest? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffQuestByMarkId.HandleId, ConfigSheriffQuestByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffQuest?(SheriffQuest.GetRootAsSheriffQuest(configBuffer));
				}
			}
			ConfigSheriffQuestByMarkId.LogPair.Clear();
			ConfigSheriffQuestByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigSheriffQuestByMarkId.HandleId, 1, p0MarkId, ConfigSheriffQuestByMarkId.LogPair) || ConfigCommon.Step(ConfigSheriffQuestByMarkId.HandleId, true, ConfigSheriffQuestByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffQuestByMarkId.HandleId, ConfigSheriffQuestByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffQuestByMarkId.HandleId, 0, ConfigSheriffQuestByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffQuestByMarkId.HandleId, ConfigSheriffQuestByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffQuest rootAsSheriffQuest = SheriffQuest.GetRootAsSheriffQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffQuestByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffQuestByMarkId.HandleId, ConfigSheriffQuestByMarkId.LogPair);
			return new SheriffQuest?(rootAsSheriffQuest);
		}

		// Token: 0x040041B7 RID: 16823
		private const string DB = "db_sheriff.db";

		// Token: 0x040041B8 RID: 16824
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x040041B9 RID: 16825
		private const string TABLE = "SheriffQuest";

		// Token: 0x040041BA RID: 16826
		private const string COMMAND = "select BinData from `SheriffQuest` where MarkId=?";

		// Token: 0x040041BB RID: 16827
		private const string KEY_PREFIX = "SheriffQuestByMarkId";

		// Token: 0x040041BC RID: 16828
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041BD RID: 16829
		private static int HandleId;
	}
}
