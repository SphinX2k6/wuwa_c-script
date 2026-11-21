using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000641 RID: 1601
	public class ConfigOnlineMotorLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002596 RID: 9622 RVA: 0x00131B60 File Offset: 0x0012FD60
		static ConfigOnlineMotorLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorLevelAll.CreateStaticDefaultValue), new Action(ConfigOnlineMotorLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00131B80 File Offset: 0x0012FD80
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorLevel`")
			});
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00131BFF File Offset: 0x0012FDFF
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorLevelAll.LogPair = null;
			ConfigOnlineMotorLevelAll.HandleId = 0;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00131C0D File Offset: 0x0012FE0D
		public static void Init()
		{
			ConfigOnlineMotorLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorLevelAll.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorLevel`");
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00131C28 File Offset: 0x0012FE28
		[NullableContext(2)]
		public static IReadOnlyList<OnlineMotorLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorLevelAll.HandleId, ConfigOnlineMotorLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<OnlineMotorLevel> readOnlyList = (IReadOnlyList<OnlineMotorLevel>)ConfigCommon.GetConfig("OnlineMotorLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<OnlineMotorLevel> list = new List<OnlineMotorLevel>();
			while (ConfigCommon.Step(ConfigOnlineMotorLevelAll.HandleId, false, ConfigOnlineMotorLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorLevelAll.HandleId, 0, ConfigOnlineMotorLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOnlineMotorLevelAll.HandleId, ConfigOnlineMotorLevelAll.LogPair);
					return null;
				}
				OnlineMotorLevel rootAsOnlineMotorLevel = OnlineMotorLevel.GetRootAsOnlineMotorLevel(new ByteBuffer(item2));
				list.Add(rootAsOnlineMotorLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("OnlineMotorLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigOnlineMotorLevelAll.HandleId, ConfigOnlineMotorLevelAll.LogPair);
			return list;
		}

		// Token: 0x04002BAD RID: 11181
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002BAE RID: 11182
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002BAF RID: 11183
		private const string TABLE = "OnlineMotorLevel";

		// Token: 0x04002BB0 RID: 11184
		private const string COMMAND = "select BinData from `OnlineMotorLevel`";

		// Token: 0x04002BB1 RID: 11185
		private const string KEY_PREFIX = "OnlineMotorLevelAll";

		// Token: 0x04002BB2 RID: 11186
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BB3 RID: 11187
		private static int HandleId;
	}
}
