using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000948 RID: 2376
	public class ConfigScratchCardRewardReByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037C3 RID: 14275 RVA: 0x00197BA4 File Offset: 0x00195DA4
		static ConfigScratchCardRewardReByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardRewardReByType.CreateStaticDefaultValue), new Action(ConfigScratchCardRewardReByType.ResetStaticDefaultValue));
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00197BC4 File Offset: 0x00195DC4
		public static void CreateStaticDefaultValue()
		{
			ConfigScratchCardRewardReByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigScratchCardRewardReByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_scratchcard.db"),
				new ValueTuple<string, object>("文件", "g.刮刮乐.xlsx"),
				new ValueTuple<string, object>("表名", "ScratchCardRewardRe"),
				new ValueTuple<string, object>("语句", "select BinData from `ScratchCardRewardRe` where RoundId=?")
			});
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00197C43 File Offset: 0x00195E43
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardRewardReByType.LogPair = null;
			ConfigScratchCardRewardReByType.HandleId = 0;
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00197C51 File Offset: 0x00195E51
		public static void Init()
		{
			ConfigScratchCardRewardReByType.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardRewardReByType.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardRewardRe` where RoundId=?");
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00197C6C File Offset: 0x00195E6C
		[NullableContext(2)]
		public static IReadOnlyList<ScratchCardRewardRe> GetConfigList(int p0RoundId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigScratchCardRewardReByType.HandleId, ConfigScratchCardRewardReByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardRewardReByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoundId);
				IReadOnlyList<ScratchCardRewardRe> readOnlyList = (IReadOnlyList<ScratchCardRewardRe>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigScratchCardRewardReByType.LogPair.Clear();
			ConfigScratchCardRewardReByType.LogPair.Add(new ValueTuple<string, object>("RoundId", p0RoundId));
			if (!ConfigCommon.BindInt(ConfigScratchCardRewardReByType.HandleId, 1, p0RoundId, ConfigScratchCardRewardReByType.LogPair))
			{
				ConfigCommon.Reset(ConfigScratchCardRewardReByType.HandleId, ConfigScratchCardRewardReByType.LogPair);
				return null;
			}
			List<ScratchCardRewardRe> list = new List<ScratchCardRewardRe>();
			while (ConfigCommon.Step(ConfigScratchCardRewardReByType.HandleId, false, ConfigScratchCardRewardReByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigScratchCardRewardReByType.HandleId, 0, ConfigScratchCardRewardReByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigScratchCardRewardReByType.HandleId, ConfigScratchCardRewardReByType.LogPair);
					return null;
				}
				ScratchCardRewardRe rootAsScratchCardRewardRe = ScratchCardRewardRe.GetRootAsScratchCardRewardRe(new ByteBuffer(item2));
				list.Add(rootAsScratchCardRewardRe);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScratchCardRewardReByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoundId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigScratchCardRewardReByType.HandleId, ConfigScratchCardRewardReByType.LogPair);
			return list;
		}

		// Token: 0x040040DE RID: 16606
		private const string DB = "db_scratchcard.db";

		// Token: 0x040040DF RID: 16607
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x040040E0 RID: 16608
		private const string TABLE = "ScratchCardRewardRe";

		// Token: 0x040040E1 RID: 16609
		private const string COMMAND = "select BinData from `ScratchCardRewardRe` where RoundId=?";

		// Token: 0x040040E2 RID: 16610
		private const string KEY_PREFIX = "ScratchCardRewardReByType";

		// Token: 0x040040E3 RID: 16611
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040E4 RID: 16612
		private static int HandleId;
	}
}
