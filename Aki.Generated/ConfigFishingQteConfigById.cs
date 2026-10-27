using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E7 RID: 743
	public class ConfigFishingQteConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600116F RID: 4463 RVA: 0x000BC0D4 File Offset: 0x000BA2D4
		static ConfigFishingQteConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingQteConfigById.CreateStaticDefaultValue), new Action(ConfigFishingQteConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000BC0F4 File Offset: 0x000BA2F4
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingQteConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingQteConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishingqteconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/b.捕鱼转盘/*.csv*"),
				new ValueTuple<string, object>("表名", "FishingQteConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingQteConfig` where Id=?")
			});
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000BC173 File Offset: 0x000BA373
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingQteConfigById.LogPair = null;
			ConfigFishingQteConfigById.HandleId = 0;
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000BC181 File Offset: 0x000BA381
		public static void Init()
		{
			ConfigFishingQteConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingQteConfigById.HandleId, "db_fishingqteconfig.db", "select BinData from `FishingQteConfig` where Id=?");
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000BC19C File Offset: 0x000BA39C
		public static FishingQteConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingQteConfigById.HandleId, ConfigFishingQteConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingQteConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingQteConfig?(FishingQteConfig.GetRootAsFishingQteConfig(configBuffer));
				}
			}
			ConfigFishingQteConfigById.LogPair.Clear();
			ConfigFishingQteConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingQteConfigById.HandleId, 1, p0Id, ConfigFishingQteConfigById.LogPair) || ConfigCommon.Step(ConfigFishingQteConfigById.HandleId, true, ConfigFishingQteConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingQteConfigById.HandleId, ConfigFishingQteConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingQteConfigById.HandleId, 0, ConfigFishingQteConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingQteConfigById.HandleId, ConfigFishingQteConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingQteConfig rootAsFishingQteConfig = FishingQteConfig.GetRootAsFishingQteConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingQteConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingQteConfigById.HandleId, ConfigFishingQteConfigById.LogPair);
			return new FishingQteConfig?(rootAsFishingQteConfig);
		}

		// Token: 0x04001435 RID: 5173
		private const string DB = "db_fishingqteconfig.db";

		// Token: 0x04001436 RID: 5174
		private const string FILE = "k.可视化编辑/c.Csv/b.捕鱼转盘/*.csv*";

		// Token: 0x04001437 RID: 5175
		private const string TABLE = "FishingQteConfig";

		// Token: 0x04001438 RID: 5176
		private const string COMMAND = "select BinData from `FishingQteConfig` where Id=?";

		// Token: 0x04001439 RID: 5177
		private const string KEY_PREFIX = "FishingQteConfigById";

		// Token: 0x0400143A RID: 5178
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400143B RID: 5179
		private static int HandleId;
	}
}
