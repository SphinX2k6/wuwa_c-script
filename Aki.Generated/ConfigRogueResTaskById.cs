using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085C RID: 2140
	public class ConfigRogueResTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600323A RID: 12858 RVA: 0x00175760 File Offset: 0x00173960
		static ConfigRogueResTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTaskById.CreateStaticDefaultValue), new Action(ConfigRogueResTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x00175780 File Offset: 0x00173980
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

		// Token: 0x0600323C RID: 12860 RVA: 0x001757FF File Offset: 0x001739FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTaskById.LogPair = null;
			ConfigRogueResTaskById.HandleId = 0;
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x0017580D File Offset: 0x00173A0D
		public static void Init()
		{
			ConfigRogueResTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTaskById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTask` where Id=?");
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x00175828 File Offset: 0x00173A28
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

		// Token: 0x04003A6A RID: 14954
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A6B RID: 14955
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A6C RID: 14956
		private const string TABLE = "RogueResTask";

		// Token: 0x04003A6D RID: 14957
		private const string COMMAND = "select BinData from `RogueResTask` where Id=?";

		// Token: 0x04003A6E RID: 14958
		private const string KEY_PREFIX = "RogueResTaskById";

		// Token: 0x04003A6F RID: 14959
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A70 RID: 14960
		private static int HandleId;
	}
}
