using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057C RID: 1404
	public class ConfigMotorDecalQuestByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020F5 RID: 8437 RVA: 0x00113C23 File Offset: 0x00111E23
		static ConfigMotorDecalQuestByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalQuestByTaskId.CreateStaticDefaultValue), new Action(ConfigMotorDecalQuestByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00113C44 File Offset: 0x00111E44
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecalQuestByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecalQuestByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorstickerip.db"),
				new ValueTuple<string, object>("文件", "m.摩托车贴纸活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecalQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecalQuest` where TaskId=?")
			});
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00113CC3 File Offset: 0x00111EC3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalQuestByTaskId.LogPair = null;
			ConfigMotorDecalQuestByTaskId.HandleId = 0;
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00113CD1 File Offset: 0x00111ED1
		public static void Init()
		{
			ConfigMotorDecalQuestByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalQuestByTaskId.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalQuest` where TaskId=?");
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00113CEC File Offset: 0x00111EEC
		public static MotorDecalQuest? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecalQuestByTaskId.HandleId, ConfigMotorDecalQuestByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalQuestByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorDecalQuest?(MotorDecalQuest.GetRootAsMotorDecalQuest(configBuffer));
				}
			}
			ConfigMotorDecalQuestByTaskId.LogPair.Clear();
			ConfigMotorDecalQuestByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigMotorDecalQuestByTaskId.HandleId, 1, p0TaskId, ConfigMotorDecalQuestByTaskId.LogPair) || ConfigCommon.Step(ConfigMotorDecalQuestByTaskId.HandleId, true, ConfigMotorDecalQuestByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorDecalQuestByTaskId.HandleId, ConfigMotorDecalQuestByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecalQuestByTaskId.HandleId, 0, ConfigMotorDecalQuestByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorDecalQuestByTaskId.HandleId, ConfigMotorDecalQuestByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorDecalQuest rootAsMotorDecalQuest = MotorDecalQuest.GetRootAsMotorDecalQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalQuestByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorDecalQuestByTaskId.HandleId, ConfigMotorDecalQuestByTaskId.LogPair);
			return new MotorDecalQuest?(rootAsMotorDecalQuest);
		}

		// Token: 0x04002648 RID: 9800
		private const string DB = "db_motorstickerip.db";

		// Token: 0x04002649 RID: 9801
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x0400264A RID: 9802
		private const string TABLE = "MotorDecalQuest";

		// Token: 0x0400264B RID: 9803
		private const string COMMAND = "select BinData from `MotorDecalQuest` where TaskId=?";

		// Token: 0x0400264C RID: 9804
		private const string KEY_PREFIX = "MotorDecalQuestByTaskId";

		// Token: 0x0400264D RID: 9805
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400264E RID: 9806
		private static int HandleId;
	}
}
