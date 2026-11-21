using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C4 RID: 1476
	public class ConfigMotorLinkageQuestByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022A5 RID: 8869 RVA: 0x00120F77 File Offset: 0x0011F177
		static ConfigMotorLinkageQuestByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageQuestByQuestId.CreateStaticDefaultValue), new Action(ConfigMotorLinkageQuestByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00120F98 File Offset: 0x0011F198
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLinkageQuestByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLinkageQuestByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorlinkage.db"),
				new ValueTuple<string, object>("文件", "m.摩托车IP联动活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLinkageQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLinkageQuest` where TaskId=?")
			});
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00121017 File Offset: 0x0011F217
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageQuestByQuestId.LogPair = null;
			ConfigMotorLinkageQuestByQuestId.HandleId = 0;
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00121025 File Offset: 0x0011F225
		public static void Init()
		{
			ConfigMotorLinkageQuestByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageQuestByQuestId.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageQuest` where TaskId=?");
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00121040 File Offset: 0x0011F240
		public static MotorLinkageQuest? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLinkageQuestByQuestId.HandleId, ConfigMotorLinkageQuestByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLinkageQuestByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorLinkageQuest?(MotorLinkageQuest.GetRootAsMotorLinkageQuest(configBuffer));
				}
			}
			ConfigMotorLinkageQuestByQuestId.LogPair.Clear();
			ConfigMotorLinkageQuestByQuestId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigMotorLinkageQuestByQuestId.HandleId, 1, p0TaskId, ConfigMotorLinkageQuestByQuestId.LogPair) || ConfigCommon.Step(ConfigMotorLinkageQuestByQuestId.HandleId, true, ConfigMotorLinkageQuestByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorLinkageQuestByQuestId.HandleId, ConfigMotorLinkageQuestByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLinkageQuestByQuestId.HandleId, 0, ConfigMotorLinkageQuestByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorLinkageQuestByQuestId.HandleId, ConfigMotorLinkageQuestByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorLinkageQuest rootAsMotorLinkageQuest = MotorLinkageQuest.GetRootAsMotorLinkageQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLinkageQuestByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorLinkageQuestByQuestId.HandleId, ConfigMotorLinkageQuestByQuestId.LogPair);
			return new MotorLinkageQuest?(rootAsMotorLinkageQuest);
		}

		// Token: 0x04002840 RID: 10304
		private const string DB = "db_motorlinkage.db";

		// Token: 0x04002841 RID: 10305
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x04002842 RID: 10306
		private const string TABLE = "MotorLinkageQuest";

		// Token: 0x04002843 RID: 10307
		private const string COMMAND = "select BinData from `MotorLinkageQuest` where TaskId=?";

		// Token: 0x04002844 RID: 10308
		private const string KEY_PREFIX = "MotorLinkageQuestByQuestId";

		// Token: 0x04002845 RID: 10309
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002846 RID: 10310
		private static int HandleId;
	}
}
