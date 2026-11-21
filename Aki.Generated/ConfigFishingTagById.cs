using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000302 RID: 770
	public class ConfigFishingTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001211 RID: 4625 RVA: 0x000C3228 File Offset: 0x000C1428
		static ConfigFishingTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingTagById.CreateStaticDefaultValue), new Action(ConfigFishingTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x000C3248 File Offset: 0x000C1448
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

		// Token: 0x06001213 RID: 4627 RVA: 0x000C32C7 File Offset: 0x000C14C7
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingTagById.LogPair = null;
			ConfigFishingTagById.HandleId = 0;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000C32D5 File Offset: 0x000C14D5
		public static void Init()
		{
			ConfigFishingTagById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingTagById.HandleId, "db_fishing.db", "select BinData from `FishingTag` where Id=?");
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000C32F0 File Offset: 0x000C14F0
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

		// Token: 0x040014F2 RID: 5362
		private const string DB = "db_fishing.db";

		// Token: 0x040014F3 RID: 5363
		private const string FILE = "b.捕鱼相关.xlsx";

		// Token: 0x040014F4 RID: 5364
		private const string TABLE = "FishingTag";

		// Token: 0x040014F5 RID: 5365
		private const string COMMAND = "select BinData from `FishingTag` where Id=?";

		// Token: 0x040014F6 RID: 5366
		private const string KEY_PREFIX = "FishingTagById";

		// Token: 0x040014F7 RID: 5367
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014F8 RID: 5368
		private static int HandleId;
	}
}
