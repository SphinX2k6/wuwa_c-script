using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000362 RID: 866
	public class ConfigFurnitureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001451 RID: 5201 RVA: 0x000CC46F File Offset: 0x000CA66F
		static ConfigFurnitureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureById.CreateStaticDefaultValue), new Action(ConfigFurnitureById.ResetStaticDefaultValue));
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x000CC490 File Offset: 0x000CA690
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

		// Token: 0x06001453 RID: 5203 RVA: 0x000CC50F File Offset: 0x000CA70F
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureById.LogPair = null;
			ConfigFurnitureById.HandleId = 0;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000CC51D File Offset: 0x000CA71D
		public static void Init()
		{
			ConfigFurnitureById.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureById.HandleId, "db_furniture.db", "select BinData from `Furniture` where Id=?");
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x000CC538 File Offset: 0x000CA738
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

		// Token: 0x04001792 RID: 6034
		private const string DB = "db_furniture.db";

		// Token: 0x04001793 RID: 6035
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001794 RID: 6036
		private const string TABLE = "Furniture";

		// Token: 0x04001795 RID: 6037
		private const string COMMAND = "select BinData from `Furniture` where Id=?";

		// Token: 0x04001796 RID: 6038
		private const string KEY_PREFIX = "FurnitureById";

		// Token: 0x04001797 RID: 6039
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001798 RID: 6040
		private static int HandleId;
	}
}
