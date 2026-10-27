using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000369 RID: 873
	public class ConfigFurniturePresetConfigByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600147B RID: 5243 RVA: 0x000CD338 File Offset: 0x000CB538
		static ConfigFurniturePresetConfigByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurniturePresetConfigByAreaId.CreateStaticDefaultValue), new Action(ConfigFurniturePresetConfigByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x000CD358 File Offset: 0x000CB558
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

		// Token: 0x0600147D RID: 5245 RVA: 0x000CD3D7 File Offset: 0x000CB5D7
		public static void ResetStaticDefaultValue()
		{
			ConfigFurniturePresetConfigByAreaId.LogPair = null;
			ConfigFurniturePresetConfigByAreaId.HandleId = 0;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000CD3E5 File Offset: 0x000CB5E5
		public static void Init()
		{
			ConfigFurniturePresetConfigByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigFurniturePresetConfigByAreaId.HandleId, "db_furniture.db", "select BinData from `FurniturePresetConfig` where AreaId=?");
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000CD400 File Offset: 0x000CB600
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

		// Token: 0x040017C3 RID: 6083
		private const string DB = "db_furniture.db";

		// Token: 0x040017C4 RID: 6084
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x040017C5 RID: 6085
		private const string TABLE = "FurniturePresetConfig";

		// Token: 0x040017C6 RID: 6086
		private const string COMMAND = "select BinData from `FurniturePresetConfig` where AreaId=?";

		// Token: 0x040017C7 RID: 6087
		private const string KEY_PREFIX = "FurniturePresetConfigByAreaId";

		// Token: 0x040017C8 RID: 6088
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017C9 RID: 6089
		private static int HandleId;
	}
}
