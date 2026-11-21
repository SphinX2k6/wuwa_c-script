using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037D RID: 893
	public class ConfigFurnitureFilterConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014F3 RID: 5363 RVA: 0x000D35FB File Offset: 0x000D17FB
		static ConfigFurnitureFilterConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureFilterConfigById.CreateStaticDefaultValue), new Action(ConfigFurnitureFilterConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000D361C File Offset: 0x000D181C
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

		// Token: 0x060014F5 RID: 5365 RVA: 0x000D369B File Offset: 0x000D189B
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureFilterConfigById.LogPair = null;
			ConfigFurnitureFilterConfigById.HandleId = 0;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000D36A9 File Offset: 0x000D18A9
		public static void Init()
		{
			ConfigFurnitureFilterConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureFilterConfigById.HandleId, "db_furniture.db", "select BinData from `FurnitureFilterConfig` where Id=?");
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000D36C4 File Offset: 0x000D18C4
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

		// Token: 0x0400184F RID: 6223
		private const string DB = "db_furniture.db";

		// Token: 0x04001850 RID: 6224
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001851 RID: 6225
		private const string TABLE = "FurnitureFilterConfig";

		// Token: 0x04001852 RID: 6226
		private const string COMMAND = "select BinData from `FurnitureFilterConfig` where Id=?";

		// Token: 0x04001853 RID: 6227
		private const string KEY_PREFIX = "FurnitureFilterConfigById";

		// Token: 0x04001854 RID: 6228
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001855 RID: 6229
		private static int HandleId;
	}
}
