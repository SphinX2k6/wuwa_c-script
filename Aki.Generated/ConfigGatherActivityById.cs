using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000398 RID: 920
	public class ConfigGatherActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001596 RID: 5526 RVA: 0x000D7387 File Offset: 0x000D5587
		static ConfigGatherActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGatherActivityById.CreateStaticDefaultValue), new Action(ConfigGatherActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x000D73A8 File Offset: 0x000D55A8
		public static void CreateStaticDefaultValue()
		{
			ConfigGatherActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGatherActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_collectionactivity.db"),
				new ValueTuple<string, object>("文件", "s.收集活动.xlsx"),
				new ValueTuple<string, object>("表名", "GatherActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `GatherActivity` where Id=?")
			});
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000D7427 File Offset: 0x000D5627
		public static void ResetStaticDefaultValue()
		{
			ConfigGatherActivityById.LogPair = null;
			ConfigGatherActivityById.HandleId = 0;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000D7435 File Offset: 0x000D5635
		public static void Init()
		{
			ConfigGatherActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigGatherActivityById.HandleId, "db_collectionactivity.db", "select BinData from `GatherActivity` where Id=?");
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x000D7450 File Offset: 0x000D5650
		public static GatherActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGatherActivityById.HandleId, ConfigGatherActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GatherActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GatherActivity?(GatherActivity.GetRootAsGatherActivity(configBuffer));
				}
			}
			ConfigGatherActivityById.LogPair.Clear();
			ConfigGatherActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGatherActivityById.HandleId, 1, p0Id, ConfigGatherActivityById.LogPair) || ConfigCommon.Step(ConfigGatherActivityById.HandleId, true, ConfigGatherActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGatherActivityById.HandleId, ConfigGatherActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGatherActivityById.HandleId, 0, ConfigGatherActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGatherActivityById.HandleId, ConfigGatherActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GatherActivity rootAsGatherActivity = GatherActivity.GetRootAsGatherActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GatherActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGatherActivityById.HandleId, ConfigGatherActivityById.LogPair);
			return new GatherActivity?(rootAsGatherActivity);
		}

		// Token: 0x0400190C RID: 6412
		private const string DB = "db_collectionactivity.db";

		// Token: 0x0400190D RID: 6413
		private const string FILE = "s.收集活动.xlsx";

		// Token: 0x0400190E RID: 6414
		private const string TABLE = "GatherActivity";

		// Token: 0x0400190F RID: 6415
		private const string COMMAND = "select BinData from `GatherActivity` where Id=?";

		// Token: 0x04001910 RID: 6416
		private const string KEY_PREFIX = "GatherActivityById";

		// Token: 0x04001911 RID: 6417
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001912 RID: 6418
		private static int HandleId;
	}
}
