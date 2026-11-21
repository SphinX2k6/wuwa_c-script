using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000615 RID: 1557
	public class ConfigNewTowerLevelByCycleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600248E RID: 9358 RVA: 0x0012BB23 File Offset: 0x00129D23
		static ConfigNewTowerLevelByCycleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerLevelByCycleId.CreateStaticDefaultValue), new Action(ConfigNewTowerLevelByCycleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0012BB44 File Offset: 0x00129D44
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerLevelByCycleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerLevelByCycleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerLevel` where Param=?")
			});
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x0012BBC3 File Offset: 0x00129DC3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerLevelByCycleId.LogPair = null;
			ConfigNewTowerLevelByCycleId.HandleId = 0;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0012BBD1 File Offset: 0x00129DD1
		public static void Init()
		{
			ConfigNewTowerLevelByCycleId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerLevelByCycleId.HandleId, "db_newtower.db", "select BinData from `NewTowerLevel` where Param=?");
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x0012BBEC File Offset: 0x00129DEC
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerLevel> GetConfigList(int p0Param, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerLevelByCycleId.HandleId, ConfigNewTowerLevelByCycleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerLevelByCycleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Param);
				IReadOnlyList<NewTowerLevel> readOnlyList = (IReadOnlyList<NewTowerLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewTowerLevelByCycleId.LogPair.Clear();
			ConfigNewTowerLevelByCycleId.LogPair.Add(new ValueTuple<string, object>("Param", p0Param));
			if (!ConfigCommon.BindInt(ConfigNewTowerLevelByCycleId.HandleId, 1, p0Param, ConfigNewTowerLevelByCycleId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewTowerLevelByCycleId.HandleId, ConfigNewTowerLevelByCycleId.LogPair);
				return null;
			}
			List<NewTowerLevel> list = new List<NewTowerLevel>();
			while (ConfigCommon.Step(ConfigNewTowerLevelByCycleId.HandleId, false, ConfigNewTowerLevelByCycleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerLevelByCycleId.HandleId, 0, ConfigNewTowerLevelByCycleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerLevelByCycleId.HandleId, ConfigNewTowerLevelByCycleId.LogPair);
					return null;
				}
				NewTowerLevel rootAsNewTowerLevel = NewTowerLevel.GetRootAsNewTowerLevel(new ByteBuffer(item2));
				list.Add(rootAsNewTowerLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerLevelByCycleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Param);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerLevelByCycleId.HandleId, ConfigNewTowerLevelByCycleId.LogPair);
			return list;
		}

		// Token: 0x04002A79 RID: 10873
		private const string DB = "db_newtower.db";

		// Token: 0x04002A7A RID: 10874
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A7B RID: 10875
		private const string TABLE = "NewTowerLevel";

		// Token: 0x04002A7C RID: 10876
		private const string COMMAND = "select BinData from `NewTowerLevel` where Param=?";

		// Token: 0x04002A7D RID: 10877
		private const string KEY_PREFIX = "NewTowerLevelByCycleId";

		// Token: 0x04002A7E RID: 10878
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A7F RID: 10879
		private static int HandleId;
	}
}
