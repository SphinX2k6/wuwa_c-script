using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000593 RID: 1427
	public class ConfigMotorDecorationsAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600217F RID: 8575 RVA: 0x0011A5C0 File Offset: 0x001187C0
		static ConfigMotorDecorationsAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecorationsAll.CreateStaticDefaultValue), new Action(ConfigMotorDecorationsAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x0011A5E0 File Offset: 0x001187E0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecorationsAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecorationsAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecorations"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecorations`")
			});
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0011A65F File Offset: 0x0011885F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecorationsAll.LogPair = null;
			ConfigMotorDecorationsAll.HandleId = 0;
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x0011A66D File Offset: 0x0011886D
		public static void Init()
		{
			ConfigMotorDecorationsAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecorationsAll.HandleId, "db_motordiy.db", "select BinData from `MotorDecorations`");
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x0011A688 File Offset: 0x00118888
		[NullableContext(2)]
		public static IReadOnlyList<MotorDecorations> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecorationsAll.HandleId, ConfigMotorDecorationsAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorDecorations> readOnlyList = (IReadOnlyList<MotorDecorations>)ConfigCommon.GetConfig("MotorDecorationsAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorDecorations> list = new List<MotorDecorations>();
			while (ConfigCommon.Step(ConfigMotorDecorationsAll.HandleId, false, ConfigMotorDecorationsAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecorationsAll.HandleId, 0, ConfigMotorDecorationsAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorDecorationsAll.HandleId, ConfigMotorDecorationsAll.LogPair);
					return null;
				}
				MotorDecorations rootAsMotorDecorations = MotorDecorations.GetRootAsMotorDecorations(new ByteBuffer(item2));
				list.Add(rootAsMotorDecorations);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorDecorationsAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorDecorationsAll.HandleId, ConfigMotorDecorationsAll.LogPair);
			return list;
		}

		// Token: 0x040026E9 RID: 9961
		private const string DB = "db_motordiy.db";

		// Token: 0x040026EA RID: 9962
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040026EB RID: 9963
		private const string TABLE = "MotorDecorations";

		// Token: 0x040026EC RID: 9964
		private const string COMMAND = "select BinData from `MotorDecorations`";

		// Token: 0x040026ED RID: 9965
		private const string KEY_PREFIX = "MotorDecorationsAll";

		// Token: 0x040026EE RID: 9966
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026EF RID: 9967
		private static int HandleId;
	}
}
