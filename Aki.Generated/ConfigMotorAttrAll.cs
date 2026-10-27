using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000573 RID: 1395
	public class ConfigMotorAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020BF RID: 8383 RVA: 0x00112923 File Offset: 0x00110B23
		static ConfigMotorAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorAttrAll.CreateStaticDefaultValue), new Action(ConfigMotorAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00112944 File Offset: 0x00110B44
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorAttrAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorAttrAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorAttr`")
			});
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x001129C3 File Offset: 0x00110BC3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorAttrAll.LogPair = null;
			ConfigMotorAttrAll.HandleId = 0;
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x001129D1 File Offset: 0x00110BD1
		public static void Init()
		{
			ConfigMotorAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorAttrAll.HandleId, "db_motor.db", "select BinData from `MotorAttr`");
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x001129EC File Offset: 0x00110BEC
		[NullableContext(2)]
		public static IReadOnlyList<MotorAttr> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorAttrAll.HandleId, ConfigMotorAttrAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorAttr> readOnlyList = (IReadOnlyList<MotorAttr>)ConfigCommon.GetConfig("MotorAttrAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorAttr> list = new List<MotorAttr>();
			while (ConfigCommon.Step(ConfigMotorAttrAll.HandleId, false, ConfigMotorAttrAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorAttrAll.HandleId, 0, ConfigMotorAttrAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorAttrAll.HandleId, ConfigMotorAttrAll.LogPair);
					return null;
				}
				MotorAttr rootAsMotorAttr = MotorAttr.GetRootAsMotorAttr(new ByteBuffer(item2));
				list.Add(rootAsMotorAttr);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorAttrAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorAttrAll.HandleId, ConfigMotorAttrAll.LogPair);
			return list;
		}

		// Token: 0x04002609 RID: 9737
		private const string DB = "db_motor.db";

		// Token: 0x0400260A RID: 9738
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400260B RID: 9739
		private const string TABLE = "MotorAttr";

		// Token: 0x0400260C RID: 9740
		private const string COMMAND = "select BinData from `MotorAttr`";

		// Token: 0x0400260D RID: 9741
		private const string KEY_PREFIX = "MotorAttrAll";

		// Token: 0x0400260E RID: 9742
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400260F RID: 9743
		private static int HandleId;
	}
}
