using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037F RID: 895
	public class ConfigFurnitureQualityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014FF RID: 5375 RVA: 0x000D3A8C File Offset: 0x000D1C8C
		static ConfigFurnitureQualityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureQualityConfigById.CreateStaticDefaultValue), new Action(ConfigFurnitureQualityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000D3AAC File Offset: 0x000D1CAC
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureQualityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureQualityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FurnitureQualityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FurnitureQualityConfig` where Id=?")
			});
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x000D3B2B File Offset: 0x000D1D2B
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureQualityConfigById.LogPair = null;
			ConfigFurnitureQualityConfigById.HandleId = 0;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x000D3B39 File Offset: 0x000D1D39
		public static void Init()
		{
			ConfigFurnitureQualityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureQualityConfigById.HandleId, "db_furniture.db", "select BinData from `FurnitureQualityConfig` where Id=?");
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000D3B54 File Offset: 0x000D1D54
		public static FurnitureQualityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureQualityConfigById.HandleId, ConfigFurnitureQualityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FurnitureQualityConfig?(FurnitureQualityConfig.GetRootAsFurnitureQualityConfig(configBuffer));
				}
			}
			ConfigFurnitureQualityConfigById.LogPair.Clear();
			ConfigFurnitureQualityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFurnitureQualityConfigById.HandleId, 1, p0Id, ConfigFurnitureQualityConfigById.LogPair) || ConfigCommon.Step(ConfigFurnitureQualityConfigById.HandleId, true, ConfigFurnitureQualityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFurnitureQualityConfigById.HandleId, ConfigFurnitureQualityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureQualityConfigById.HandleId, 0, ConfigFurnitureQualityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFurnitureQualityConfigById.HandleId, ConfigFurnitureQualityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FurnitureQualityConfig rootAsFurnitureQualityConfig = FurnitureQualityConfig.GetRootAsFurnitureQualityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureQualityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFurnitureQualityConfigById.HandleId, ConfigFurnitureQualityConfigById.LogPair);
			return new FurnitureQualityConfig?(rootAsFurnitureQualityConfig);
		}

		// Token: 0x0400185D RID: 6237
		private const string DB = "db_furniture.db";

		// Token: 0x0400185E RID: 6238
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x0400185F RID: 6239
		private const string TABLE = "FurnitureQualityConfig";

		// Token: 0x04001860 RID: 6240
		private const string COMMAND = "select BinData from `FurnitureQualityConfig` where Id=?";

		// Token: 0x04001861 RID: 6241
		private const string KEY_PREFIX = "FurnitureQualityConfigById";

		// Token: 0x04001862 RID: 6242
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001863 RID: 6243
		private static int HandleId;
	}
}
