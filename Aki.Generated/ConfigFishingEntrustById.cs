using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EB RID: 747
	public class ConfigFishingEntrustById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001187 RID: 4487 RVA: 0x000C0098 File Offset: 0x000BE298
		static ConfigFishingEntrustById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingEntrustById.CreateStaticDefaultValue), new Action(ConfigFishingEntrustById.ResetStaticDefaultValue));
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000C00B8 File Offset: 0x000BE2B8
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingEntrustById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingEntrustById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingEntrust"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingEntrust` where Id=?")
			});
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000C0137 File Offset: 0x000BE337
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingEntrustById.LogPair = null;
			ConfigFishingEntrustById.HandleId = 0;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000C0145 File Offset: 0x000BE345
		public static void Init()
		{
			ConfigFishingEntrustById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingEntrustById.HandleId, "db_fishing.db", "select BinData from `FishingEntrust` where Id=?");
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000C0160 File Offset: 0x000BE360
		public static FishingEntrust? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingEntrustById.HandleId, ConfigFishingEntrustById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingEntrust?(FishingEntrust.GetRootAsFishingEntrust(configBuffer));
				}
			}
			ConfigFishingEntrustById.LogPair.Clear();
			ConfigFishingEntrustById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingEntrustById.HandleId, 1, p0Id, ConfigFishingEntrustById.LogPair) || ConfigCommon.Step(ConfigFishingEntrustById.HandleId, true, ConfigFishingEntrustById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingEntrustById.HandleId, ConfigFishingEntrustById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingEntrustById.HandleId, 0, ConfigFishingEntrustById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingEntrustById.HandleId, ConfigFishingEntrustById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingEntrust rootAsFishingEntrust = FishingEntrust.GetRootAsFishingEntrust(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingEntrustById.HandleId, ConfigFishingEntrustById.LogPair);
			return new FishingEntrust?(rootAsFishingEntrust);
		}

		// Token: 0x04001451 RID: 5201
		private const string DB = "db_fishing.db";

		// Token: 0x04001452 RID: 5202
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x04001453 RID: 5203
		private const string TABLE = "FishingEntrust";

		// Token: 0x04001454 RID: 5204
		private const string COMMAND = "select BinData from `FishingEntrust` where Id=?";

		// Token: 0x04001455 RID: 5205
		private const string KEY_PREFIX = "FishingEntrustById";

		// Token: 0x04001456 RID: 5206
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001457 RID: 5207
		private static int HandleId;
	}
}
