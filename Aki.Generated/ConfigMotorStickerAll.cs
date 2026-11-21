using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DD RID: 1501
	public class ConfigMotorStickerAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600233B RID: 9019 RVA: 0x00124384 File Offset: 0x00122584
		static ConfigMotorStickerAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorStickerAll.CreateStaticDefaultValue), new Action(ConfigMotorStickerAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x001243A4 File Offset: 0x001225A4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorStickerAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorStickerAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorSticker"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorSticker`")
			});
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00124423 File Offset: 0x00122623
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorStickerAll.LogPair = null;
			ConfigMotorStickerAll.HandleId = 0;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00124431 File Offset: 0x00122631
		public static void Init()
		{
			ConfigMotorStickerAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorStickerAll.HandleId, "db_motordiy.db", "select BinData from `MotorSticker`");
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0012444C File Offset: 0x0012264C
		[NullableContext(2)]
		public static IReadOnlyList<MotorSticker> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorStickerAll.HandleId, ConfigMotorStickerAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorSticker> readOnlyList = (IReadOnlyList<MotorSticker>)ConfigCommon.GetConfig("MotorStickerAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorSticker> list = new List<MotorSticker>();
			while (ConfigCommon.Step(ConfigMotorStickerAll.HandleId, false, ConfigMotorStickerAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorStickerAll.HandleId, 0, ConfigMotorStickerAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorStickerAll.HandleId, ConfigMotorStickerAll.LogPair);
					return null;
				}
				MotorSticker rootAsMotorSticker = MotorSticker.GetRootAsMotorSticker(new ByteBuffer(item2));
				list.Add(rootAsMotorSticker);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorStickerAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorStickerAll.HandleId, ConfigMotorStickerAll.LogPair);
			return list;
		}

		// Token: 0x040028EF RID: 10479
		private const string DB = "db_motordiy.db";

		// Token: 0x040028F0 RID: 10480
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040028F1 RID: 10481
		private const string TABLE = "MotorSticker";

		// Token: 0x040028F2 RID: 10482
		private const string COMMAND = "select BinData from `MotorSticker`";

		// Token: 0x040028F3 RID: 10483
		private const string KEY_PREFIX = "MotorStickerAll";

		// Token: 0x040028F4 RID: 10484
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028F5 RID: 10485
		private static int HandleId;
	}
}
