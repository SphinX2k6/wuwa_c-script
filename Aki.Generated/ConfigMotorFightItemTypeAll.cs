using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058D RID: 1421
	public class ConfigMotorFightItemTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600215B RID: 8539 RVA: 0x00116174 File Offset: 0x00114374
		static ConfigMotorFightItemTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightItemTypeAll.CreateStaticDefaultValue), new Action(ConfigMotorFightItemTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00116194 File Offset: 0x00114394
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightItemTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightItemTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightItemType"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightItemType`")
			});
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00116213 File Offset: 0x00114413
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightItemTypeAll.LogPair = null;
			ConfigMotorFightItemTypeAll.HandleId = 0;
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00116221 File Offset: 0x00114421
		public static void Init()
		{
			ConfigMotorFightItemTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightItemTypeAll.HandleId, "db_motorfight.db", "select BinData from `MotorFightItemType`");
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0011623C File Offset: 0x0011443C
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightItemType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightItemTypeAll.HandleId, ConfigMotorFightItemTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorFightItemType> readOnlyList = (IReadOnlyList<MotorFightItemType>)ConfigCommon.GetConfig("MotorFightItemTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorFightItemType> list = new List<MotorFightItemType>();
			while (ConfigCommon.Step(ConfigMotorFightItemTypeAll.HandleId, false, ConfigMotorFightItemTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightItemTypeAll.HandleId, 0, ConfigMotorFightItemTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightItemTypeAll.HandleId, ConfigMotorFightItemTypeAll.LogPair);
					return null;
				}
				MotorFightItemType rootAsMotorFightItemType = MotorFightItemType.GetRootAsMotorFightItemType(new ByteBuffer(item2));
				list.Add(rootAsMotorFightItemType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorFightItemTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightItemTypeAll.HandleId, ConfigMotorFightItemTypeAll.LogPair);
			return list;
		}

		// Token: 0x040026BF RID: 9919
		private const string DB = "db_motorfight.db";

		// Token: 0x040026C0 RID: 9920
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040026C1 RID: 9921
		private const string TABLE = "MotorFightItemType";

		// Token: 0x040026C2 RID: 9922
		private const string COMMAND = "select BinData from `MotorFightItemType`";

		// Token: 0x040026C3 RID: 9923
		private const string KEY_PREFIX = "MotorFightItemTypeAll";

		// Token: 0x040026C4 RID: 9924
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026C5 RID: 9925
		private static int HandleId;
	}
}
