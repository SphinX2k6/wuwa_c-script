using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D9 RID: 729
	public class ConfigFishingEntrustTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600111B RID: 4379 RVA: 0x000BA1B0 File Offset: 0x000B83B0
		static ConfigFishingEntrustTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingEntrustTypeById.CreateStaticDefaultValue), new Action(ConfigFishingEntrustTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000BA1D0 File Offset: 0x000B83D0
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingEntrustTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingEntrustTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼委托.xlsx"),
				new ValueTuple<string, object>("表名", "FishingEntrustType"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingEntrustType` where Id=?")
			});
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000BA24F File Offset: 0x000B844F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingEntrustTypeById.LogPair = null;
			ConfigFishingEntrustTypeById.HandleId = 0;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000BA25D File Offset: 0x000B845D
		public static void Init()
		{
			ConfigFishingEntrustTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingEntrustTypeById.HandleId, "db_fishing.db", "select BinData from `FishingEntrustType` where Id=?");
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000BA278 File Offset: 0x000B8478
		public static FishingEntrustType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingEntrustTypeById.HandleId, ConfigFishingEntrustTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingEntrustType?(FishingEntrustType.GetRootAsFishingEntrustType(configBuffer));
				}
			}
			ConfigFishingEntrustTypeById.LogPair.Clear();
			ConfigFishingEntrustTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingEntrustTypeById.HandleId, 1, p0Id, ConfigFishingEntrustTypeById.LogPair) || ConfigCommon.Step(ConfigFishingEntrustTypeById.HandleId, true, ConfigFishingEntrustTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingEntrustTypeById.HandleId, ConfigFishingEntrustTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingEntrustTypeById.HandleId, 0, ConfigFishingEntrustTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingEntrustTypeById.HandleId, ConfigFishingEntrustTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingEntrustType rootAsFishingEntrustType = FishingEntrustType.GetRootAsFishingEntrustType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingEntrustTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingEntrustTypeById.HandleId, ConfigFishingEntrustTypeById.LogPair);
			return new FishingEntrustType?(rootAsFishingEntrustType);
		}

		// Token: 0x040013D3 RID: 5075
		private const string DB = "db_fishing.db";

		// Token: 0x040013D4 RID: 5076
		private const string FILE = "b.捕鱼委托.xlsx";

		// Token: 0x040013D5 RID: 5077
		private const string TABLE = "FishingEntrustType";

		// Token: 0x040013D6 RID: 5078
		private const string COMMAND = "select BinData from `FishingEntrustType` where Id=?";

		// Token: 0x040013D7 RID: 5079
		private const string KEY_PREFIX = "FishingEntrustTypeById";

		// Token: 0x040013D8 RID: 5080
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013D9 RID: 5081
		private static int HandleId;
	}
}
