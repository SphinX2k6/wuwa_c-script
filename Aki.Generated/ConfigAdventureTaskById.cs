using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000064 RID: 100
	public class ConfigAdventureTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000258 RID: 600 RVA: 0x0006A6F7 File Offset: 0x000688F7
		static ConfigAdventureTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskById.CreateStaticDefaultValue), new Action(ConfigAdventureTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0006A718 File Offset: 0x00068918
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

		// Token: 0x0600025A RID: 602 RVA: 0x0006A797 File Offset: 0x00068997
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskById.LogPair = null;
			ConfigAdventureTaskById.HandleId = 0;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0006A7A5 File Offset: 0x000689A5
		public static void Init()
		{
			ConfigAdventureTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskById.HandleId, "db_adventuretask.db", "select BinData from `AdventureTask` where Id=?");
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0006A7C0 File Offset: 0x000689C0
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

		// Token: 0x040002A0 RID: 672
		private const string DB = "db_adventuretask.db";

		// Token: 0x040002A1 RID: 673
		private const string FILE = "k.开拓任务.xlsx";

		// Token: 0x040002A2 RID: 674
		private const string TABLE = "AdventureTask";

		// Token: 0x040002A3 RID: 675
		private const string COMMAND = "select BinData from `AdventureTask` where Id=?";

		// Token: 0x040002A4 RID: 676
		private const string KEY_PREFIX = "AdventureTaskById";

		// Token: 0x040002A5 RID: 677
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002A6 RID: 678
		private static int HandleId;
	}
}
