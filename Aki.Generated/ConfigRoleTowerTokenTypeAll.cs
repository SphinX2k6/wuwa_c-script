using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000913 RID: 2323
	public class ConfigRoleTowerTokenTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003685 RID: 13957 RVA: 0x00190C30 File Offset: 0x0018EE30
		static ConfigRoleTowerTokenTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerTokenTypeAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerTokenTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x00190C50 File Offset: 0x0018EE50
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerTokenTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerTokenTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_信物.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerTokenType"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerTokenType`")
			});
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x00190CCF File Offset: 0x0018EECF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerTokenTypeAll.LogPair = null;
			ConfigRoleTowerTokenTypeAll.HandleId = 0;
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x00190CDD File Offset: 0x0018EEDD
		public static void Init()
		{
			ConfigRoleTowerTokenTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerTokenTypeAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerTokenType`");
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00190CF8 File Offset: 0x0018EEF8
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerTokenType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerTokenTypeAll.HandleId, ConfigRoleTowerTokenTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerTokenType> readOnlyList = (IReadOnlyList<RoleTowerTokenType>)ConfigCommon.GetConfig("RoleTowerTokenTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerTokenType> list = new List<RoleTowerTokenType>();
			while (ConfigCommon.Step(ConfigRoleTowerTokenTypeAll.HandleId, false, ConfigRoleTowerTokenTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerTokenTypeAll.HandleId, 0, ConfigRoleTowerTokenTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerTokenTypeAll.HandleId, ConfigRoleTowerTokenTypeAll.LogPair);
					return null;
				}
				RoleTowerTokenType rootAsRoleTowerTokenType = RoleTowerTokenType.GetRootAsRoleTowerTokenType(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerTokenType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerTokenTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerTokenTypeAll.HandleId, ConfigRoleTowerTokenTypeAll.LogPair);
			return list;
		}

		// Token: 0x04003F6B RID: 16235
		private const string DB = "db_roletower.db";

		// Token: 0x04003F6C RID: 16236
		private const string FILE = "j.角色爬塔_信物.xlsx";

		// Token: 0x04003F6D RID: 16237
		private const string TABLE = "RoleTowerTokenType";

		// Token: 0x04003F6E RID: 16238
		private const string COMMAND = "select BinData from `RoleTowerTokenType`";

		// Token: 0x04003F6F RID: 16239
		private const string KEY_PREFIX = "RoleTowerTokenTypeAll";

		// Token: 0x04003F70 RID: 16240
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F71 RID: 16241
		private static int HandleId;
	}
}
