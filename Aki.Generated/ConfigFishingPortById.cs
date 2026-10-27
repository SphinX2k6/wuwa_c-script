using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E5 RID: 741
	public class ConfigFishingPortById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001163 RID: 4451 RVA: 0x000BBC43 File Offset: 0x000B9E43
		static ConfigFishingPortById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPortById.CreateStaticDefaultValue), new Action(ConfigFishingPortById.ResetStaticDefaultValue));
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000BBC64 File Offset: 0x000B9E64
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingPortById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingPortById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingPort"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingPort` where Id=?")
			});
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x000BBCE3 File Offset: 0x000B9EE3
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPortById.LogPair = null;
			ConfigFishingPortById.HandleId = 0;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x000BBCF1 File Offset: 0x000B9EF1
		public static void Init()
		{
			ConfigFishingPortById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPortById.HandleId, "db_fishing.db", "select BinData from `FishingPort` where Id=?");
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x000BBD0C File Offset: 0x000B9F0C
		public static FishingPort? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingPortById.HandleId, ConfigFishingPortById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingPort?(FishingPort.GetRootAsFishingPort(configBuffer));
				}
			}
			ConfigFishingPortById.LogPair.Clear();
			ConfigFishingPortById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingPortById.HandleId, 1, p0Id, ConfigFishingPortById.LogPair) || ConfigCommon.Step(ConfigFishingPortById.HandleId, true, ConfigFishingPortById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingPortById.HandleId, ConfigFishingPortById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingPortById.HandleId, 0, ConfigFishingPortById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingPortById.HandleId, ConfigFishingPortById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingPort rootAsFishingPort = FishingPort.GetRootAsFishingPort(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingPortById.HandleId, ConfigFishingPortById.LogPair);
			return new FishingPort?(rootAsFishingPort);
		}

		// Token: 0x04001427 RID: 5159
		private const string DB = "db_fishing.db";

		// Token: 0x04001428 RID: 5160
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x04001429 RID: 5161
		private const string TABLE = "FishingPort";

		// Token: 0x0400142A RID: 5162
		private const string COMMAND = "select BinData from `FishingPort` where Id=?";

		// Token: 0x0400142B RID: 5163
		private const string KEY_PREFIX = "FishingPortById";

		// Token: 0x0400142C RID: 5164
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400142D RID: 5165
		private static int HandleId;
	}
}
