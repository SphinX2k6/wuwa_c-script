using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A5 RID: 165
	public class ConfigAnsPerformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003DE RID: 990 RVA: 0x00072E88 File Offset: 0x00071088
		static ConfigAnsPerformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnsPerformById.CreateStaticDefaultValue), new Action(ConfigAnsPerformById.ResetStaticDefaultValue));
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00072EA8 File Offset: 0x000710A8
		public static void CreateStaticDefaultValue()
		{
			ConfigAnsPerformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAnsPerformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ansperform.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.ANS表演表/*.csv*"),
				new ValueTuple<string, object>("表名", "AnsPerform"),
				new ValueTuple<string, object>("语句", "select BinData from `AnsPerform` where Id=?")
			});
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00072F27 File Offset: 0x00071127
		public static void ResetStaticDefaultValue()
		{
			ConfigAnsPerformById.LogPair = null;
			ConfigAnsPerformById.HandleId = 0;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00072F35 File Offset: 0x00071135
		public static void Init()
		{
			ConfigAnsPerformById.HandleId = ConfigCommon.InitDataStatement(ConfigAnsPerformById.HandleId, "db_ansperform.db", "select BinData from `AnsPerform` where Id=?");
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00072F50 File Offset: 0x00071150
		public static AnsPerform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAnsPerformById.HandleId, ConfigAnsPerformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnsPerformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AnsPerform?(AnsPerform.GetRootAsAnsPerform(configBuffer));
				}
			}
			ConfigAnsPerformById.LogPair.Clear();
			ConfigAnsPerformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAnsPerformById.HandleId, 1, p0Id, ConfigAnsPerformById.LogPair) || ConfigCommon.Step(ConfigAnsPerformById.HandleId, true, ConfigAnsPerformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAnsPerformById.HandleId, ConfigAnsPerformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAnsPerformById.HandleId, 0, ConfigAnsPerformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAnsPerformById.HandleId, ConfigAnsPerformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AnsPerform rootAsAnsPerform = AnsPerform.GetRootAsAnsPerform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnsPerformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAnsPerformById.HandleId, ConfigAnsPerformById.LogPair);
			return new AnsPerform?(rootAsAnsPerform);
		}

		// Token: 0x04000467 RID: 1127
		private const string DB = "db_ansperform.db";

		// Token: 0x04000468 RID: 1128
		private const string FILE = "k.可视化编辑/c.Csv/a.ANS表演表/*.csv*";

		// Token: 0x04000469 RID: 1129
		private const string TABLE = "AnsPerform";

		// Token: 0x0400046A RID: 1130
		private const string COMMAND = "select BinData from `AnsPerform` where Id=?";

		// Token: 0x0400046B RID: 1131
		private const string KEY_PREFIX = "AnsPerformById";

		// Token: 0x0400046C RID: 1132
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400046D RID: 1133
		private static int HandleId;
	}
}
