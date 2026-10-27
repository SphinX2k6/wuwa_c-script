using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000107 RID: 263
	public class ConfigBossPilingTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x0007C8C0 File Offset: 0x0007AAC0
		static ConfigBossPilingTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossPilingTaskById.CreateStaticDefaultValue), new Action(ConfigBossPilingTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0007C8E0 File Offset: 0x0007AAE0
		public static void CreateStaticDefaultValue()
		{
			ConfigBossPilingTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossPilingTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bosspiling.db"),
				new ValueTuple<string, object>("文件", "b.Boss打桩活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossPilingTask"),
				new ValueTuple<string, object>("语句", "select BinData from `BossPilingTask` where Id=?")
			});
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0007C95F File Offset: 0x0007AB5F
		public static void ResetStaticDefaultValue()
		{
			ConfigBossPilingTaskById.LogPair = null;
			ConfigBossPilingTaskById.HandleId = 0;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0007C96D File Offset: 0x0007AB6D
		public static void Init()
		{
			ConfigBossPilingTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigBossPilingTaskById.HandleId, "db_bosspiling.db", "select BinData from `BossPilingTask` where Id=?");
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0007C988 File Offset: 0x0007AB88
		public static BossPilingTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossPilingTaskById.HandleId, ConfigBossPilingTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossPilingTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossPilingTask?(BossPilingTask.GetRootAsBossPilingTask(configBuffer));
				}
			}
			ConfigBossPilingTaskById.LogPair.Clear();
			ConfigBossPilingTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossPilingTaskById.HandleId, 1, p0Id, ConfigBossPilingTaskById.LogPair) || ConfigCommon.Step(ConfigBossPilingTaskById.HandleId, true, ConfigBossPilingTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossPilingTaskById.HandleId, ConfigBossPilingTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossPilingTaskById.HandleId, 0, ConfigBossPilingTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossPilingTaskById.HandleId, ConfigBossPilingTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossPilingTask rootAsBossPilingTask = BossPilingTask.GetRootAsBossPilingTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossPilingTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossPilingTaskById.HandleId, ConfigBossPilingTaskById.LogPair);
			return new BossPilingTask?(rootAsBossPilingTask);
		}

		// Token: 0x04000715 RID: 1813
		private const string DB = "db_bosspiling.db";

		// Token: 0x04000716 RID: 1814
		private const string FILE = "b.Boss打桩活动.xlsx";

		// Token: 0x04000717 RID: 1815
		private const string TABLE = "BossPilingTask";

		// Token: 0x04000718 RID: 1816
		private const string COMMAND = "select BinData from `BossPilingTask` where Id=?";

		// Token: 0x04000719 RID: 1817
		private const string KEY_PREFIX = "BossPilingTaskById";

		// Token: 0x0400071A RID: 1818
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400071B RID: 1819
		private static int HandleId;
	}
}
