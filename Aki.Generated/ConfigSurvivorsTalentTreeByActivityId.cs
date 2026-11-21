using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7F RID: 2687
	public class ConfigSurvivorsTalentTreeByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F0E RID: 16142 RVA: 0x001C14CC File Offset: 0x001BF6CC
		static ConfigSurvivorsTalentTreeByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTalentTreeByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsTalentTreeByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x001C14EC File Offset: 0x001BF6EC
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

		// Token: 0x06003F10 RID: 16144 RVA: 0x001C156B File Offset: 0x001BF76B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTalentTreeByActivityId.LogPair = null;
			ConfigSurvivorsTalentTreeByActivityId.HandleId = 0;
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x001C1579 File Offset: 0x001BF779
		public static void Init()
		{
			ConfigSurvivorsTalentTreeByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTalentTreeByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsTalentTree` where ActivityId=?");
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x001C1594 File Offset: 0x001BF794
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

		// Token: 0x0400495F RID: 18783
		private const string DB = "db_survivors.db";

		// Token: 0x04004960 RID: 18784
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x04004961 RID: 18785
		private const string TABLE = "SurvivorsTalentTree";

		// Token: 0x04004962 RID: 18786
		private const string COMMAND = "select BinData from `SurvivorsTalentTree` where ActivityId=?";

		// Token: 0x04004963 RID: 18787
		private const string KEY_PREFIX = "SurvivorsTalentTreeByActivityId";

		// Token: 0x04004964 RID: 18788
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004965 RID: 18789
		private static int HandleId;
	}
}
