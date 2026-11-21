using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000878 RID: 2168
	public class ConfigRogueResTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032E2 RID: 13026 RVA: 0x0017CA48 File Offset: 0x0017AC48
		static ConfigRogueResTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTaskById.CreateStaticDefaultValue), new Action(ConfigRogueResTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x0017CA68 File Offset: 0x0017AC68
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTask` where Id=?")
			});
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x0017CAE7 File Offset: 0x0017ACE7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTaskById.LogPair = null;
			ConfigRogueResTaskById.HandleId = 0;
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x0017CAF5 File Offset: 0x0017ACF5
		public static void Init()
		{
			ConfigRogueResTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTaskById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTask` where Id=?");
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x0017CB10 File Offset: 0x0017AD10
		public static RogueResTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResTaskById.HandleId, ConfigRogueResTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResTask?(RogueResTask.GetRootAsRogueResTask(configBuffer));
				}
			}
			ConfigRogueResTaskById.LogPair.Clear();
			ConfigRogueResTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResTaskById.HandleId, 1, p0Id, ConfigRogueResTaskById.LogPair) || ConfigCommon.Step(ConfigRogueResTaskById.HandleId, true, ConfigRogueResTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResTaskById.HandleId, ConfigRogueResTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResTaskById.HandleId, 0, ConfigRogueResTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResTaskById.HandleId, ConfigRogueResTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResTask rootAsRogueResTask = RogueResTask.GetRootAsRogueResTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResTaskById.HandleId, ConfigRogueResTaskById.LogPair);
			return new RogueResTask?(rootAsRogueResTask);
		}

		// Token: 0x04003B2E RID: 15150
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B2F RID: 15151
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B30 RID: 15152
		private const string TABLE = "RogueResTask";

		// Token: 0x04003B31 RID: 15153
		private const string COMMAND = "select BinData from `RogueResTask` where Id=?";

		// Token: 0x04003B32 RID: 15154
		private const string KEY_PREFIX = "RogueResTaskById";

		// Token: 0x04003B33 RID: 15155
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B34 RID: 15156
		private static int HandleId;
	}
}
