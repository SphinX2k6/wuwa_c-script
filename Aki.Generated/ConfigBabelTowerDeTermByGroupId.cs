using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DF RID: 223
	public class ConfigBabelTowerDeTermByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x0007ACEF File Offset: 0x00078EEF
		static ConfigBabelTowerDeTermByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDeTermByGroupId.CreateStaticDefaultValue), new Action(ConfigBabelTowerDeTermByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0007AD10 File Offset: 0x00078F10
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDeTermByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDeTermByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDeTerm"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDeTerm` where GroupId=?")
			});
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0007AD8F File Offset: 0x00078F8F
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDeTermByGroupId.LogPair = null;
			ConfigBabelTowerDeTermByGroupId.HandleId = 0;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0007AD9D File Offset: 0x00078F9D
		public static void Init()
		{
			ConfigBabelTowerDeTermByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDeTermByGroupId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDeTerm` where GroupId=?");
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0007ADB8 File Offset: 0x00078FB8
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerDeTerm> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDeTermByGroupId.HandleId, ConfigBabelTowerDeTermByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDeTermByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<BabelTowerDeTerm> readOnlyList = (IReadOnlyList<BabelTowerDeTerm>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBabelTowerDeTermByGroupId.LogPair.Clear();
			ConfigBabelTowerDeTermByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigBabelTowerDeTermByGroupId.HandleId, 1, p0GroupId, ConfigBabelTowerDeTermByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigBabelTowerDeTermByGroupId.HandleId, ConfigBabelTowerDeTermByGroupId.LogPair);
				return null;
			}
			List<BabelTowerDeTerm> list = new List<BabelTowerDeTerm>();
			while (ConfigCommon.Step(ConfigBabelTowerDeTermByGroupId.HandleId, false, ConfigBabelTowerDeTermByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDeTermByGroupId.HandleId, 0, ConfigBabelTowerDeTermByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerDeTermByGroupId.HandleId, ConfigBabelTowerDeTermByGroupId.LogPair);
					return null;
				}
				BabelTowerDeTerm rootAsBabelTowerDeTerm = BabelTowerDeTerm.GetRootAsBabelTowerDeTerm(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerDeTerm);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDeTermByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerDeTermByGroupId.HandleId, ConfigBabelTowerDeTermByGroupId.LogPair);
			return list;
		}

		// Token: 0x040005FD RID: 1533
		private const string DB = "db_babeltower.db";

		// Token: 0x040005FE RID: 1534
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005FF RID: 1535
		private const string TABLE = "BabelTowerDeTerm";

		// Token: 0x04000600 RID: 1536
		private const string COMMAND = "select BinData from `BabelTowerDeTerm` where GroupId=?";

		// Token: 0x04000601 RID: 1537
		private const string KEY_PREFIX = "BabelTowerDeTermByGroupId";

		// Token: 0x04000602 RID: 1538
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000603 RID: 1539
		private static int HandleId;
	}
}
