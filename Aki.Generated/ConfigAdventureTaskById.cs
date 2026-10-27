using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005C RID: 92
	public class ConfigAdventureTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00065E43 File Offset: 0x00064043
		static ConfigAdventureTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskById.CreateStaticDefaultValue), new Action(ConfigAdventureTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00065E64 File Offset: 0x00064064
		public static void CreateStaticDefaultValue()
		{
			ConfigAdventureTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdventureTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventuretask.db"),
				new ValueTuple<string, object>("文件", "k.开拓任务.xlsx"),
				new ValueTuple<string, object>("表名", "AdventureTask"),
				new ValueTuple<string, object>("语句", "select BinData from `AdventureTask` where Id=?")
			});
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00065EE3 File Offset: 0x000640E3
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskById.LogPair = null;
			ConfigAdventureTaskById.HandleId = 0;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00065EF1 File Offset: 0x000640F1
		public static void Init()
		{
			ConfigAdventureTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskById.HandleId, "db_adventuretask.db", "select BinData from `AdventureTask` where Id=?");
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00065F0C File Offset: 0x0006410C
		public static AdventureTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdventureTaskById.HandleId, ConfigAdventureTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdventureTask?(AdventureTask.GetRootAsAdventureTask(configBuffer));
				}
			}
			ConfigAdventureTaskById.LogPair.Clear();
			ConfigAdventureTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdventureTaskById.HandleId, 1, p0Id, ConfigAdventureTaskById.LogPair) || ConfigCommon.Step(ConfigAdventureTaskById.HandleId, true, ConfigAdventureTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdventureTaskById.HandleId, ConfigAdventureTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdventureTaskById.HandleId, 0, ConfigAdventureTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdventureTaskById.HandleId, ConfigAdventureTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdventureTask rootAsAdventureTask = AdventureTask.GetRootAsAdventureTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdventureTaskById.HandleId, ConfigAdventureTaskById.LogPair);
			return new AdventureTask?(rootAsAdventureTask);
		}

		// Token: 0x04000268 RID: 616
		private const string DB = "db_adventuretask.db";

		// Token: 0x04000269 RID: 617
		private const string FILE = "k.开拓任务.xlsx";

		// Token: 0x0400026A RID: 618
		private const string TABLE = "AdventureTask";

		// Token: 0x0400026B RID: 619
		private const string COMMAND = "select BinData from `AdventureTask` where Id=?";

		// Token: 0x0400026C RID: 620
		private const string KEY_PREFIX = "AdventureTaskById";

		// Token: 0x0400026D RID: 621
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400026E RID: 622
		private static int HandleId;
	}
}
