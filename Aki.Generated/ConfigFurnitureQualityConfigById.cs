using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036A RID: 874
	public class ConfigFurnitureQualityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001481 RID: 5249 RVA: 0x000CD580 File Offset: 0x000CB780
		static ConfigFurnitureQualityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureQualityConfigById.CreateStaticDefaultValue), new Action(ConfigFurnitureQualityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x000CD5A0 File Offset: 0x000CB7A0
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

		// Token: 0x06001483 RID: 5251 RVA: 0x000CD61F File Offset: 0x000CB81F
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureQualityConfigById.LogPair = null;
			ConfigFurnitureQualityConfigById.HandleId = 0;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000CD62D File Offset: 0x000CB82D
		public static void Init()
		{
			ConfigFurnitureQualityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureQualityConfigById.HandleId, "db_furniture.db", "select BinData from `FurnitureQualityConfig` where Id=?");
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x000CD648 File Offset: 0x000CB848
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

		// Token: 0x040017CA RID: 6090
		private const string DB = "db_furniture.db";

		// Token: 0x040017CB RID: 6091
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x040017CC RID: 6092
		private const string TABLE = "FurnitureQualityConfig";

		// Token: 0x040017CD RID: 6093
		private const string COMMAND = "select BinData from `FurnitureQualityConfig` where Id=?";

		// Token: 0x040017CE RID: 6094
		private const string KEY_PREFIX = "FurnitureQualityConfigById";

		// Token: 0x040017CF RID: 6095
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017D0 RID: 6096
		private static int HandleId;
	}
}
