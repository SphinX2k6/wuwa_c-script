using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000591 RID: 1425
	public class ConfigMotorDecalQuestByIp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002173 RID: 8563 RVA: 0x0011A140 File Offset: 0x00118340
		static ConfigMotorDecalQuestByIp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalQuestByIp.CreateStaticDefaultValue), new Action(ConfigMotorDecalQuestByIp.ResetStaticDefaultValue));
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0011A160 File Offset: 0x00118360
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecalQuestByIp.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecalQuestByIp.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorstickerip.db"),
				new ValueTuple<string, object>("文件", "m.摩托车贴纸活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecalQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecalQuest` where Ip=?")
			});
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0011A1DF File Offset: 0x001183DF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalQuestByIp.LogPair = null;
			ConfigMotorDecalQuestByIp.HandleId = 0;
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0011A1ED File Offset: 0x001183ED
		public static void Init()
		{
			ConfigMotorDecalQuestByIp.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalQuestByIp.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalQuest` where Ip=?");
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x0011A208 File Offset: 0x00118408
		[NullableContext(2)]
		public static IReadOnlyList<MotorDecalQuest> GetConfigList(int p0Ip, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecalQuestByIp.HandleId, ConfigMotorDecalQuestByIp.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalQuestByIp");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Ip);
				IReadOnlyList<MotorDecalQuest> readOnlyList = (IReadOnlyList<MotorDecalQuest>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorDecalQuestByIp.LogPair.Clear();
			ConfigMotorDecalQuestByIp.LogPair.Add(new ValueTuple<string, object>("Ip", p0Ip));
			if (!ConfigCommon.BindInt(ConfigMotorDecalQuestByIp.HandleId, 1, p0Ip, ConfigMotorDecalQuestByIp.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorDecalQuestByIp.HandleId, ConfigMotorDecalQuestByIp.LogPair);
				return null;
			}
			List<MotorDecalQuest> list = new List<MotorDecalQuest>();
			while (ConfigCommon.Step(ConfigMotorDecalQuestByIp.HandleId, false, ConfigMotorDecalQuestByIp.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecalQuestByIp.HandleId, 0, ConfigMotorDecalQuestByIp.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorDecalQuestByIp.HandleId, ConfigMotorDecalQuestByIp.LogPair);
					return null;
				}
				MotorDecalQuest rootAsMotorDecalQuest = MotorDecalQuest.GetRootAsMotorDecalQuest(new ByteBuffer(item2));
				list.Add(rootAsMotorDecalQuest);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalQuestByIp");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Ip);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorDecalQuestByIp.HandleId, ConfigMotorDecalQuestByIp.LogPair);
			return list;
		}

		// Token: 0x040026DB RID: 9947
		private const string DB = "db_motorstickerip.db";

		// Token: 0x040026DC RID: 9948
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x040026DD RID: 9949
		private const string TABLE = "MotorDecalQuest";

		// Token: 0x040026DE RID: 9950
		private const string COMMAND = "select BinData from `MotorDecalQuest` where Ip=?";

		// Token: 0x040026DF RID: 9951
		private const string KEY_PREFIX = "MotorDecalQuestByIp";

		// Token: 0x040026E0 RID: 9952
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026E1 RID: 9953
		private static int HandleId;
	}
}
