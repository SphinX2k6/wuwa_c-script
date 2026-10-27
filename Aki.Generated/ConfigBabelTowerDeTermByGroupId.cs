using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D0 RID: 208
	public class ConfigBabelTowerDeTermByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x0007538B File Offset: 0x0007358B
		static ConfigBabelTowerDeTermByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDeTermByGroupId.CreateStaticDefaultValue), new Action(ConfigBabelTowerDeTermByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000753AC File Offset: 0x000735AC
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

		// Token: 0x060004E3 RID: 1251 RVA: 0x0007542B File Offset: 0x0007362B
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDeTermByGroupId.LogPair = null;
			ConfigBabelTowerDeTermByGroupId.HandleId = 0;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00075439 File Offset: 0x00073639
		public static void Init()
		{
			ConfigBabelTowerDeTermByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDeTermByGroupId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDeTerm` where GroupId=?");
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00075454 File Offset: 0x00073654
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

		// Token: 0x04000594 RID: 1428
		private const string DB = "db_babeltower.db";

		// Token: 0x04000595 RID: 1429
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000596 RID: 1430
		private const string TABLE = "BabelTowerDeTerm";

		// Token: 0x04000597 RID: 1431
		private const string COMMAND = "select BinData from `BabelTowerDeTerm` where GroupId=?";

		// Token: 0x04000598 RID: 1432
		private const string KEY_PREFIX = "BabelTowerDeTermByGroupId";

		// Token: 0x04000599 RID: 1433
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400059A RID: 1434
		private static int HandleId;
	}
}
