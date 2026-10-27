using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FD RID: 1533
	public class ConfigNewTowerLevelByCycleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023FE RID: 9214 RVA: 0x001250A7 File Offset: 0x001232A7
		static ConfigNewTowerLevelByCycleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerLevelByCycleId.CreateStaticDefaultValue), new Action(ConfigNewTowerLevelByCycleId.ResetStaticDefaultValue));
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x001250C8 File Offset: 0x001232C8
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

		// Token: 0x06002400 RID: 9216 RVA: 0x00125147 File Offset: 0x00123347
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerLevelByCycleId.LogPair = null;
			ConfigNewTowerLevelByCycleId.HandleId = 0;
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00125155 File Offset: 0x00123355
		public static void Init()
		{
			ConfigNewTowerLevelByCycleId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerLevelByCycleId.HandleId, "db_newtower.db", "select BinData from `NewTowerLevel` where Param=?");
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00125170 File Offset: 0x00123370
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

		// Token: 0x040029D1 RID: 10705
		private const string DB = "db_newtower.db";

		// Token: 0x040029D2 RID: 10706
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029D3 RID: 10707
		private const string TABLE = "NewTowerLevel";

		// Token: 0x040029D4 RID: 10708
		private const string COMMAND = "select BinData from `NewTowerLevel` where Param=?";

		// Token: 0x040029D5 RID: 10709
		private const string KEY_PREFIX = "NewTowerLevelByCycleId";

		// Token: 0x040029D6 RID: 10710
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029D7 RID: 10711
		private static int HandleId;
	}
}
