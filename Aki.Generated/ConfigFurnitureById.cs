using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000377 RID: 887
	public class ConfigFurnitureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014CF RID: 5327 RVA: 0x000D297B File Offset: 0x000D0B7B
		static ConfigFurnitureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureById.CreateStaticDefaultValue), new Action(ConfigFurnitureById.ResetStaticDefaultValue));
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000D299C File Offset: 0x000D0B9C
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "Furniture"),
				new ValueTuple<string, object>("语句", "select BinData from `Furniture` where Id=?")
			});
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000D2A1B File Offset: 0x000D0C1B
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureById.LogPair = null;
			ConfigFurnitureById.HandleId = 0;
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x000D2A29 File Offset: 0x000D0C29
		public static void Init()
		{
			ConfigFurnitureById.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureById.HandleId, "db_furniture.db", "select BinData from `Furniture` where Id=?");
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000D2A44 File Offset: 0x000D0C44
		public static Furniture? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureById.HandleId, ConfigFurnitureById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Furniture?(Furniture.GetRootAsFurniture(configBuffer));
				}
			}
			ConfigFurnitureById.LogPair.Clear();
			ConfigFurnitureById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFurnitureById.HandleId, 1, p0Id, ConfigFurnitureById.LogPair) || ConfigCommon.Step(ConfigFurnitureById.HandleId, true, ConfigFurnitureById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFurnitureById.HandleId, ConfigFurnitureById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureById.HandleId, 0, ConfigFurnitureById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFurnitureById.HandleId, ConfigFurnitureById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Furniture rootAsFurniture = Furniture.GetRootAsFurniture(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFurnitureById.HandleId, ConfigFurnitureById.LogPair);
			return new Furniture?(rootAsFurniture);
		}

		// Token: 0x04001825 RID: 6181
		private const string DB = "db_furniture.db";

		// Token: 0x04001826 RID: 6182
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001827 RID: 6183
		private const string TABLE = "Furniture";

		// Token: 0x04001828 RID: 6184
		private const string COMMAND = "select BinData from `Furniture` where Id=?";

		// Token: 0x04001829 RID: 6185
		private const string KEY_PREFIX = "FurnitureById";

		// Token: 0x0400182A RID: 6186
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400182B RID: 6187
		private static int HandleId;
	}
}
