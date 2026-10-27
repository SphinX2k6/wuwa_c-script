using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000368 RID: 872
	public class ConfigFurnitureFilterConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001475 RID: 5237 RVA: 0x000CD0EF File Offset: 0x000CB2EF
		static ConfigFurnitureFilterConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureFilterConfigById.CreateStaticDefaultValue), new Action(ConfigFurnitureFilterConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000CD110 File Offset: 0x000CB310
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureFilterConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureFilterConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FurnitureFilterConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FurnitureFilterConfig` where Id=?")
			});
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x000CD18F File Offset: 0x000CB38F
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureFilterConfigById.LogPair = null;
			ConfigFurnitureFilterConfigById.HandleId = 0;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000CD19D File Offset: 0x000CB39D
		public static void Init()
		{
			ConfigFurnitureFilterConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureFilterConfigById.HandleId, "db_furniture.db", "select BinData from `FurnitureFilterConfig` where Id=?");
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000CD1B8 File Offset: 0x000CB3B8
		public static FurnitureFilterConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureFilterConfigById.HandleId, ConfigFurnitureFilterConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureFilterConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FurnitureFilterConfig?(FurnitureFilterConfig.GetRootAsFurnitureFilterConfig(configBuffer));
				}
			}
			ConfigFurnitureFilterConfigById.LogPair.Clear();
			ConfigFurnitureFilterConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFurnitureFilterConfigById.HandleId, 1, p0Id, ConfigFurnitureFilterConfigById.LogPair) || ConfigCommon.Step(ConfigFurnitureFilterConfigById.HandleId, true, ConfigFurnitureFilterConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFurnitureFilterConfigById.HandleId, ConfigFurnitureFilterConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureFilterConfigById.HandleId, 0, ConfigFurnitureFilterConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFurnitureFilterConfigById.HandleId, ConfigFurnitureFilterConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FurnitureFilterConfig rootAsFurnitureFilterConfig = FurnitureFilterConfig.GetRootAsFurnitureFilterConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureFilterConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFurnitureFilterConfigById.HandleId, ConfigFurnitureFilterConfigById.LogPair);
			return new FurnitureFilterConfig?(rootAsFurnitureFilterConfig);
		}

		// Token: 0x040017BC RID: 6076
		private const string DB = "db_furniture.db";

		// Token: 0x040017BD RID: 6077
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x040017BE RID: 6078
		private const string TABLE = "FurnitureFilterConfig";

		// Token: 0x040017BF RID: 6079
		private const string COMMAND = "select BinData from `FurnitureFilterConfig` where Id=?";

		// Token: 0x040017C0 RID: 6080
		private const string KEY_PREFIX = "FurnitureFilterConfigById";

		// Token: 0x040017C1 RID: 6081
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017C2 RID: 6082
		private static int HandleId;
	}
}
