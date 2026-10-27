using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FF RID: 1535
	public class ConfigNewTowerMedalByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600240A RID: 9226 RVA: 0x00125528 File Offset: 0x00123728
		static ConfigNewTowerMedalByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerMedalByGroupId.CreateStaticDefaultValue), new Action(ConfigNewTowerMedalByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00125548 File Offset: 0x00123748
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerMedalByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerMedalByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerMedal"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerMedal` where GroupId=?")
			});
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x001255C7 File Offset: 0x001237C7
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerMedalByGroupId.LogPair = null;
			ConfigNewTowerMedalByGroupId.HandleId = 0;
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x001255D5 File Offset: 0x001237D5
		public static void Init()
		{
			ConfigNewTowerMedalByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerMedalByGroupId.HandleId, "db_newtower.db", "select BinData from `NewTowerMedal` where GroupId=?");
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x001255F0 File Offset: 0x001237F0
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerMedal> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerMedalByGroupId.HandleId, ConfigNewTowerMedalByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerMedalByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<NewTowerMedal> readOnlyList = (IReadOnlyList<NewTowerMedal>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewTowerMedalByGroupId.LogPair.Clear();
			ConfigNewTowerMedalByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigNewTowerMedalByGroupId.HandleId, 1, p0GroupId, ConfigNewTowerMedalByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewTowerMedalByGroupId.HandleId, ConfigNewTowerMedalByGroupId.LogPair);
				return null;
			}
			List<NewTowerMedal> list = new List<NewTowerMedal>();
			while (ConfigCommon.Step(ConfigNewTowerMedalByGroupId.HandleId, false, ConfigNewTowerMedalByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerMedalByGroupId.HandleId, 0, ConfigNewTowerMedalByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerMedalByGroupId.HandleId, ConfigNewTowerMedalByGroupId.LogPair);
					return null;
				}
				NewTowerMedal rootAsNewTowerMedal = NewTowerMedal.GetRootAsNewTowerMedal(new ByteBuffer(item2));
				list.Add(rootAsNewTowerMedal);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerMedalByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerMedalByGroupId.HandleId, ConfigNewTowerMedalByGroupId.LogPair);
			return list;
		}

		// Token: 0x040029DF RID: 10719
		private const string DB = "db_newtower.db";

		// Token: 0x040029E0 RID: 10720
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029E1 RID: 10721
		private const string TABLE = "NewTowerMedal";

		// Token: 0x040029E2 RID: 10722
		private const string COMMAND = "select BinData from `NewTowerMedal` where GroupId=?";

		// Token: 0x040029E3 RID: 10723
		private const string KEY_PREFIX = "NewTowerMedalByGroupId";

		// Token: 0x040029E4 RID: 10724
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029E5 RID: 10725
		private static int HandleId;
	}
}
