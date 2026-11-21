using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A4 RID: 1444
	public class ConfigMotorFightItemTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021E5 RID: 8677 RVA: 0x0011CA5C File Offset: 0x0011AC5C
		static ConfigMotorFightItemTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightItemTypeAll.CreateStaticDefaultValue), new Action(ConfigMotorFightItemTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0011CA7C File Offset: 0x0011AC7C
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

		// Token: 0x060021E7 RID: 8679 RVA: 0x0011CAFB File Offset: 0x0011ACFB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightItemTypeAll.LogPair = null;
			ConfigMotorFightItemTypeAll.HandleId = 0;
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x0011CB09 File Offset: 0x0011AD09
		public static void Init()
		{
			ConfigMotorFightItemTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightItemTypeAll.HandleId, "db_motorfight.db", "select BinData from `MotorFightItemType`");
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0011CB24 File Offset: 0x0011AD24
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

		// Token: 0x04002760 RID: 10080
		private const string DB = "db_motorfight.db";

		// Token: 0x04002761 RID: 10081
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002762 RID: 10082
		private const string TABLE = "MotorFightItemType";

		// Token: 0x04002763 RID: 10083
		private const string COMMAND = "select BinData from `MotorFightItemType`";

		// Token: 0x04002764 RID: 10084
		private const string KEY_PREFIX = "MotorFightItemTypeAll";

		// Token: 0x04002765 RID: 10085
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002766 RID: 10086
		private static int HandleId;
	}
}
