using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002ED RID: 749
	public class ConfigFishingTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001193 RID: 4499 RVA: 0x000BCD1C File Offset: 0x000BAF1C
		static ConfigFishingTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTagById.CreateStaticDefaultValue), new Action(ConfigFishingTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x000BCD3C File Offset: 0x000BAF3C
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼相关.xlsx"),
				new ValueTuple<string, object>("表名", "FishingTag"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingTag` where Id=?")
			});
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x000BCDBB File Offset: 0x000BAFBB
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTagById.LogPair = null;
			ConfigFishingTagById.HandleId = 0;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000BCDC9 File Offset: 0x000BAFC9
		public static void Init()
		{
			ConfigFishingTagById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTagById.HandleId, "db_fishing.db", "select BinData from `FishingTag` where Id=?");
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x000BCDE4 File Offset: 0x000BAFE4
		public static FishingTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingTagById.HandleId, ConfigFishingTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingTag?(FishingTag.GetRootAsFishingTag(configBuffer));
				}
			}
			ConfigFishingTagById.LogPair.Clear();
			ConfigFishingTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingTagById.HandleId, 1, p0Id, ConfigFishingTagById.LogPair) || ConfigCommon.Step(ConfigFishingTagById.HandleId, true, ConfigFishingTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingTagById.HandleId, ConfigFishingTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingTagById.HandleId, 0, ConfigFishingTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingTagById.HandleId, ConfigFishingTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingTag rootAsFishingTag = FishingTag.GetRootAsFishingTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingTagById.HandleId, ConfigFishingTagById.LogPair);
			return new FishingTag?(rootAsFishingTag);
		}

		// Token: 0x0400145F RID: 5215
		private const string DB = "db_fishing.db";

		// Token: 0x04001460 RID: 5216
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x04001461 RID: 5217
		private const string TABLE = "FishingTag";

		// Token: 0x04001462 RID: 5218
		private const string COMMAND = "select BinData from `FishingTag` where Id=?";

		// Token: 0x04001463 RID: 5219
		private const string KEY_PREFIX = "FishingTagById";

		// Token: 0x04001464 RID: 5220
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001465 RID: 5221
		private static int HandleId;
	}
}
