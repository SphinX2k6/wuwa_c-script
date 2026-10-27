using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009D RID: 157
	public class ConfigAnsPerformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003AE RID: 942 RVA: 0x0006E5D4 File Offset: 0x0006C7D4
		static ConfigAnsPerformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnsPerformById.CreateStaticDefaultValue), new Action(ConfigAnsPerformById.ResetStaticDefaultValue));
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0006E5F4 File Offset: 0x0006C7F4
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

		// Token: 0x060003B0 RID: 944 RVA: 0x0006E673 File Offset: 0x0006C873
		public static void ResetStaticDefaultValue()
		{
			ConfigAnsPerformById.LogPair = null;
			ConfigAnsPerformById.HandleId = 0;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0006E681 File Offset: 0x0006C881
		public static void Init()
		{
			ConfigAnsPerformById.HandleId = ConfigCommon.InitDataStatement(ConfigAnsPerformById.HandleId, "db_ansperform.db", "select BinData from `AnsPerform` where Id=?");
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0006E69C File Offset: 0x0006C89C
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

		// Token: 0x0400042F RID: 1071
		private const string DB = "db_ansperform.db";

		// Token: 0x04000430 RID: 1072
		private const string FILE = "k.可视化编辑/c.Csv/a.ANS表演表/*.csv*";

		// Token: 0x04000431 RID: 1073
		private const string TABLE = "AnsPerform";

		// Token: 0x04000432 RID: 1074
		private const string COMMAND = "select BinData from `AnsPerform` where Id=?";

		// Token: 0x04000433 RID: 1075
		private const string KEY_PREFIX = "AnsPerformById";

		// Token: 0x04000434 RID: 1076
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000435 RID: 1077
		private static int HandleId;
	}
}
