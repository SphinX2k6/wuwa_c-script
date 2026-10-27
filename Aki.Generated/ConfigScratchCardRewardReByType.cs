using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FD RID: 2301
	public class ConfigScratchCardRewardReByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003601 RID: 13825 RVA: 0x0018A984 File Offset: 0x00188B84
		static ConfigScratchCardRewardReByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScratchCardRewardReByType.CreateStaticDefaultValue), new Action(ConfigScratchCardRewardReByType.ResetStaticDefaultValue));
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x0018A9A4 File Offset: 0x00188BA4
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

		// Token: 0x06003603 RID: 13827 RVA: 0x0018AA23 File Offset: 0x00188C23
		public static void ResetStaticDefaultValue()
		{
			ConfigScratchCardRewardReByType.LogPair = null;
			ConfigScratchCardRewardReByType.HandleId = 0;
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x0018AA31 File Offset: 0x00188C31
		public static void Init()
		{
			ConfigScratchCardRewardReByType.HandleId = ConfigCommon.InitDataStatement(ConfigScratchCardRewardReByType.HandleId, "db_scratchcard.db", "select BinData from `ScratchCardRewardRe` where RoundId=?");
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x0018AA4C File Offset: 0x00188C4C
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

		// Token: 0x04003ED1 RID: 16081
		private const string DB = "db_scratchcard.db";

		// Token: 0x04003ED2 RID: 16082
		private const string FILE = "g.刮刮乐.xlsx";

		// Token: 0x04003ED3 RID: 16083
		private const string TABLE = "ScratchCardRewardRe";

		// Token: 0x04003ED4 RID: 16084
		private const string COMMAND = "select BinData from `ScratchCardRewardRe` where RoundId=?";

		// Token: 0x04003ED5 RID: 16085
		private const string KEY_PREFIX = "ScratchCardRewardReByType";

		// Token: 0x04003ED6 RID: 16086
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003ED7 RID: 16087
		private static int HandleId;
	}
}
