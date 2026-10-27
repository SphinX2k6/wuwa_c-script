using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099C RID: 2460
	public class ConfigSurvivorsLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039BC RID: 14780 RVA: 0x001A0188 File Offset: 0x0019E388
		static ConfigSurvivorsLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x001A01A8 File Offset: 0x0019E3A8
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsLevelByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsLevelByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsLevel` where ActivityId=?")
			});
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x001A0227 File Offset: 0x0019E427
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsLevelByActivityId.LogPair = null;
			ConfigSurvivorsLevelByActivityId.HandleId = 0;
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x001A0235 File Offset: 0x0019E435
		public static void Init()
		{
			ConfigSurvivorsLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsLevelByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsLevel` where ActivityId=?");
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x001A0250 File Offset: 0x0019E450
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsLevel> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsLevelByActivityId.HandleId, ConfigSurvivorsLevelByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SurvivorsLevel> readOnlyList = (IReadOnlyList<SurvivorsLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsLevelByActivityId.LogPair.Clear();
			ConfigSurvivorsLevelByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsLevelByActivityId.HandleId, 1, p0ActivityId, ConfigSurvivorsLevelByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsLevelByActivityId.HandleId, ConfigSurvivorsLevelByActivityId.LogPair);
				return null;
			}
			List<SurvivorsLevel> list = new List<SurvivorsLevel>();
			while (ConfigCommon.Step(ConfigSurvivorsLevelByActivityId.HandleId, false, ConfigSurvivorsLevelByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsLevelByActivityId.HandleId, 0, ConfigSurvivorsLevelByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsLevelByActivityId.HandleId, ConfigSurvivorsLevelByActivityId.LogPair);
					return null;
				}
				SurvivorsLevel rootAsSurvivorsLevel = SurvivorsLevel.GetRootAsSurvivorsLevel(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsLevelByActivityId.HandleId, ConfigSurvivorsLevelByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400432A RID: 17194
		private const string DB = "db_survivors.db";

		// Token: 0x0400432B RID: 17195
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x0400432C RID: 17196
		private const string TABLE = "SurvivorsLevel";

		// Token: 0x0400432D RID: 17197
		private const string COMMAND = "select BinData from `SurvivorsLevel` where ActivityId=?";

		// Token: 0x0400432E RID: 17198
		private const string KEY_PREFIX = "SurvivorsLevelByActivityId";

		// Token: 0x0400432F RID: 17199
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004330 RID: 17200
		private static int HandleId;
	}
}
