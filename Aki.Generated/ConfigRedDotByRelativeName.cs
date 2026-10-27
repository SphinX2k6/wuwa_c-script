using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C2 RID: 1986
	public class ConfigRedDotByRelativeName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E9E RID: 11934 RVA: 0x00160E44 File Offset: 0x0015F044
		static ConfigRedDotByRelativeName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRedDotByRelativeName.CreateStaticDefaultValue), new Action(ConfigRedDotByRelativeName.ResetStaticDefaultValue));
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00160E64 File Offset: 0x0015F064
		public static void CreateStaticDefaultValue()
		{
			ConfigRedDotByRelativeName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRedDotByRelativeName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_reddot.db"),
				new ValueTuple<string, object>("文件", "h.红点.xlsx"),
				new ValueTuple<string, object>("表名", "RedDot"),
				new ValueTuple<string, object>("语句", "select BinData from `RedDot` where RelativeName IS NOT NULL")
			});
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00160EE3 File Offset: 0x0015F0E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRedDotByRelativeName.LogPair = null;
			ConfigRedDotByRelativeName.HandleId = 0;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00160EF1 File Offset: 0x0015F0F1
		public static void Init()
		{
			ConfigRedDotByRelativeName.HandleId = ConfigCommon.InitDataStatement(ConfigRedDotByRelativeName.HandleId, "db_reddot.db", "select BinData from `RedDot` where RelativeName IS NOT NULL");
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00160F0C File Offset: 0x0015F10C
		[NullableContext(2)]
		public static IReadOnlyList<RedDot> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRedDotByRelativeName.HandleId, ConfigRedDotByRelativeName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RedDot> readOnlyList = (IReadOnlyList<RedDot>)ConfigCommon.GetConfig("RedDotByRelativeName");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RedDot> list = new List<RedDot>();
			while (ConfigCommon.Step(ConfigRedDotByRelativeName.HandleId, false, ConfigRedDotByRelativeName.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRedDotByRelativeName.HandleId, 0, ConfigRedDotByRelativeName.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRedDotByRelativeName.HandleId, ConfigRedDotByRelativeName.LogPair);
					return null;
				}
				RedDot rootAsRedDot = RedDot.GetRootAsRedDot(new ByteBuffer(item2));
				list.Add(rootAsRedDot);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RedDotByRelativeName", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRedDotByRelativeName.HandleId, ConfigRedDotByRelativeName.LogPair);
			return list;
		}

		// Token: 0x04003634 RID: 13876
		private const string DB = "db_reddot.db";

		// Token: 0x04003635 RID: 13877
		private const string FILE = "h.红点.xlsx";

		// Token: 0x04003636 RID: 13878
		private const string TABLE = "RedDot";

		// Token: 0x04003637 RID: 13879
		private const string COMMAND = "select BinData from `RedDot` where RelativeName IS NOT NULL";

		// Token: 0x04003638 RID: 13880
		private const string KEY_PREFIX = "RedDotByRelativeName";

		// Token: 0x04003639 RID: 13881
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400363A RID: 13882
		private static int HandleId;
	}
}
