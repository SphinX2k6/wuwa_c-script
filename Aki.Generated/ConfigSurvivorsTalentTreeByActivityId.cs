using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AA RID: 2474
	public class ConfigSurvivorsTalentTreeByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A10 RID: 14864 RVA: 0x001A2138 File Offset: 0x001A0338
		static ConfigSurvivorsTalentTreeByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTalentTreeByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsTalentTreeByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x001A2158 File Offset: 0x001A0358
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTalentTreeByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTalentTreeByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局外.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTalentTree` where ActivityId=?")
			});
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x001A21D7 File Offset: 0x001A03D7
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTalentTreeByActivityId.LogPair = null;
			ConfigSurvivorsTalentTreeByActivityId.HandleId = 0;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x001A21E5 File Offset: 0x001A03E5
		public static void Init()
		{
			ConfigSurvivorsTalentTreeByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTalentTreeByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsTalentTree` where ActivityId=?");
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x001A2200 File Offset: 0x001A0400
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsTalentTree> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTalentTreeByActivityId.HandleId, ConfigSurvivorsTalentTreeByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTalentTreeByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SurvivorsTalentTree> readOnlyList = (IReadOnlyList<SurvivorsTalentTree>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsTalentTreeByActivityId.LogPair.Clear();
			ConfigSurvivorsTalentTreeByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsTalentTreeByActivityId.HandleId, 1, p0ActivityId, ConfigSurvivorsTalentTreeByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsTalentTreeByActivityId.HandleId, ConfigSurvivorsTalentTreeByActivityId.LogPair);
				return null;
			}
			List<SurvivorsTalentTree> list = new List<SurvivorsTalentTree>();
			while (ConfigCommon.Step(ConfigSurvivorsTalentTreeByActivityId.HandleId, false, ConfigSurvivorsTalentTreeByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTalentTreeByActivityId.HandleId, 0, ConfigSurvivorsTalentTreeByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsTalentTreeByActivityId.HandleId, ConfigSurvivorsTalentTreeByActivityId.LogPair);
					return null;
				}
				SurvivorsTalentTree rootAsSurvivorsTalentTree = SurvivorsTalentTree.GetRootAsSurvivorsTalentTree(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsTalentTree);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTalentTreeByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsTalentTreeByActivityId.HandleId, ConfigSurvivorsTalentTreeByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400438C RID: 17292
		private const string DB = "db_survivors.db";

		// Token: 0x0400438D RID: 17293
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x0400438E RID: 17294
		private const string TABLE = "SurvivorsTalentTree";

		// Token: 0x0400438F RID: 17295
		private const string COMMAND = "select BinData from `SurvivorsTalentTree` where ActivityId=?";

		// Token: 0x04004390 RID: 17296
		private const string KEY_PREFIX = "SurvivorsTalentTreeByActivityId";

		// Token: 0x04004391 RID: 17297
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004392 RID: 17298
		private static int HandleId;
	}
}
