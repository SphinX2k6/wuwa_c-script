using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037E RID: 894
	public class ConfigFurniturePresetConfigByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014F9 RID: 5369 RVA: 0x000D3844 File Offset: 0x000D1A44
		static ConfigFurniturePresetConfigByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurniturePresetConfigByAreaId.CreateStaticDefaultValue), new Action(ConfigFurniturePresetConfigByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x000D3864 File Offset: 0x000D1A64
		public static void CreateStaticDefaultValue()
		{
			ConfigFurniturePresetConfigByAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurniturePresetConfigByAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FurniturePresetConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FurniturePresetConfig` where AreaId=?")
			});
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000D38E3 File Offset: 0x000D1AE3
		public static void ResetStaticDefaultValue()
		{
			ConfigFurniturePresetConfigByAreaId.LogPair = null;
			ConfigFurniturePresetConfigByAreaId.HandleId = 0;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000D38F1 File Offset: 0x000D1AF1
		public static void Init()
		{
			ConfigFurniturePresetConfigByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigFurniturePresetConfigByAreaId.HandleId, "db_furniture.db", "select BinData from `FurniturePresetConfig` where AreaId=?");
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000D390C File Offset: 0x000D1B0C
		public static FurniturePresetConfig? GetConfig(int p0AreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurniturePresetConfigByAreaId.HandleId, ConfigFurniturePresetConfigByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurniturePresetConfigByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FurniturePresetConfig?(FurniturePresetConfig.GetRootAsFurniturePresetConfig(configBuffer));
				}
			}
			ConfigFurniturePresetConfigByAreaId.LogPair.Clear();
			ConfigFurniturePresetConfigByAreaId.LogPair.Add(new ValueTuple<string, object>("AreaId", p0AreaId));
			if (!ConfigCommon.BindInt(ConfigFurniturePresetConfigByAreaId.HandleId, 1, p0AreaId, ConfigFurniturePresetConfigByAreaId.LogPair) || ConfigCommon.Step(ConfigFurniturePresetConfigByAreaId.HandleId, true, ConfigFurniturePresetConfigByAreaId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFurniturePresetConfigByAreaId.HandleId, ConfigFurniturePresetConfigByAreaId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurniturePresetConfigByAreaId.HandleId, 0, ConfigFurniturePresetConfigByAreaId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFurniturePresetConfigByAreaId.HandleId, ConfigFurniturePresetConfigByAreaId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FurniturePresetConfig rootAsFurniturePresetConfig = FurniturePresetConfig.GetRootAsFurniturePresetConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurniturePresetConfigByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFurniturePresetConfigByAreaId.HandleId, ConfigFurniturePresetConfigByAreaId.LogPair);
			return new FurniturePresetConfig?(rootAsFurniturePresetConfig);
		}

		// Token: 0x04001856 RID: 6230
		private const string DB = "db_furniture.db";

		// Token: 0x04001857 RID: 6231
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001858 RID: 6232
		private const string TABLE = "FurniturePresetConfig";

		// Token: 0x04001859 RID: 6233
		private const string COMMAND = "select BinData from `FurniturePresetConfig` where AreaId=?";

		// Token: 0x0400185A RID: 6234
		private const string KEY_PREFIX = "FurniturePresetConfigByAreaId";

		// Token: 0x0400185B RID: 6235
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400185C RID: 6236
		private static int HandleId;
	}
}
