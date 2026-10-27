using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000382 RID: 898
	public class ConfigGatherActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001512 RID: 5394 RVA: 0x000D0C33 File Offset: 0x000CEE33
		static ConfigGatherActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGatherActivityById.CreateStaticDefaultValue), new Action(ConfigGatherActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000D0C54 File Offset: 0x000CEE54
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

		// Token: 0x06001514 RID: 5396 RVA: 0x000D0CD3 File Offset: 0x000CEED3
		public static void ResetStaticDefaultValue()
		{
			ConfigGatherActivityById.LogPair = null;
			ConfigGatherActivityById.HandleId = 0;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000D0CE1 File Offset: 0x000CEEE1
		public static void Init()
		{
			ConfigGatherActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigGatherActivityById.HandleId, "db_collectionactivity.db", "select BinData from `GatherActivity` where Id=?");
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000D0CFC File Offset: 0x000CEEFC
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

		// Token: 0x04001872 RID: 6258
		private const string DB = "db_collectionactivity.db";

		// Token: 0x04001873 RID: 6259
		private const string FILE = "s.收集活动.xlsx";

		// Token: 0x04001874 RID: 6260
		private const string TABLE = "GatherActivity";

		// Token: 0x04001875 RID: 6261
		private const string COMMAND = "select BinData from `GatherActivity` where Id=?";

		// Token: 0x04001876 RID: 6262
		private const string KEY_PREFIX = "GatherActivityById";

		// Token: 0x04001877 RID: 6263
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001878 RID: 6264
		private static int HandleId;
	}
}
