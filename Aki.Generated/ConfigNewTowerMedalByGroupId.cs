using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000617 RID: 1559
	public class ConfigNewTowerMedalByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600249A RID: 9370 RVA: 0x0012BFA4 File Offset: 0x0012A1A4
		static ConfigNewTowerMedalByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerMedalByGroupId.CreateStaticDefaultValue), new Action(ConfigNewTowerMedalByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x0012BFC4 File Offset: 0x0012A1C4
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

		// Token: 0x0600249C RID: 9372 RVA: 0x0012C043 File Offset: 0x0012A243
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerMedalByGroupId.LogPair = null;
			ConfigNewTowerMedalByGroupId.HandleId = 0;
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0012C051 File Offset: 0x0012A251
		public static void Init()
		{
			ConfigNewTowerMedalByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerMedalByGroupId.HandleId, "db_newtower.db", "select BinData from `NewTowerMedal` where GroupId=?");
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x0012C06C File Offset: 0x0012A26C
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

		// Token: 0x04002A87 RID: 10887
		private const string DB = "db_newtower.db";

		// Token: 0x04002A88 RID: 10888
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A89 RID: 10889
		private const string TABLE = "NewTowerMedal";

		// Token: 0x04002A8A RID: 10890
		private const string COMMAND = "select BinData from `NewTowerMedal` where GroupId=?";

		// Token: 0x04002A8B RID: 10891
		private const string KEY_PREFIX = "NewTowerMedalByGroupId";

		// Token: 0x04002A8C RID: 10892
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A8D RID: 10893
		private static int HandleId;
	}
}
