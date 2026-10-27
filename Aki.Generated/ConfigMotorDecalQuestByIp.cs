using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057B RID: 1403
	public class ConfigMotorDecalQuestByIp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020EF RID: 8431 RVA: 0x001139EC File Offset: 0x00111BEC
		static ConfigMotorDecalQuestByIp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalQuestByIp.CreateStaticDefaultValue), new Action(ConfigMotorDecalQuestByIp.ResetStaticDefaultValue));
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00113A0C File Offset: 0x00111C0C
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

		// Token: 0x060020F1 RID: 8433 RVA: 0x00113A8B File Offset: 0x00111C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalQuestByIp.LogPair = null;
			ConfigMotorDecalQuestByIp.HandleId = 0;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00113A99 File Offset: 0x00111C99
		public static void Init()
		{
			ConfigMotorDecalQuestByIp.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalQuestByIp.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalQuest` where Ip=?");
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00113AB4 File Offset: 0x00111CB4
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

		// Token: 0x04002641 RID: 9793
		private const string DB = "db_motorstickerip.db";

		// Token: 0x04002642 RID: 9794
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x04002643 RID: 9795
		private const string TABLE = "MotorDecalQuest";

		// Token: 0x04002644 RID: 9796
		private const string COMMAND = "select BinData from `MotorDecalQuest` where Ip=?";

		// Token: 0x04002645 RID: 9797
		private const string KEY_PREFIX = "MotorDecalQuestByIp";

		// Token: 0x04002646 RID: 9798
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002647 RID: 9799
		private static int HandleId;
	}
}
