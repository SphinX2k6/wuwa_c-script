using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000376 RID: 886
	public class ConfigFurnitureByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x000D2743 File Offset: 0x000D0943
		static ConfigFurnitureByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureByActivityId.CreateStaticDefaultValue), new Action(ConfigFurnitureByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000D2764 File Offset: 0x000D0964
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "Furniture"),
				new ValueTuple<string, object>("语句", "select BinData from `Furniture` where ActivityId=?")
			});
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000D27E3 File Offset: 0x000D09E3
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureByActivityId.LogPair = null;
			ConfigFurnitureByActivityId.HandleId = 0;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000D27F1 File Offset: 0x000D09F1
		public static void Init()
		{
			ConfigFurnitureByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureByActivityId.HandleId, "db_furniture.db", "select BinData from `Furniture` where ActivityId=?");
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000D280C File Offset: 0x000D0A0C
		[NullableContext(2)]
		public static IReadOnlyList<Furniture> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureByActivityId.HandleId, ConfigFurnitureByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<Furniture> readOnlyList = (IReadOnlyList<Furniture>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFurnitureByActivityId.LogPair.Clear();
			ConfigFurnitureByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFurnitureByActivityId.HandleId, 1, p0ActivityId, ConfigFurnitureByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFurnitureByActivityId.HandleId, ConfigFurnitureByActivityId.LogPair);
				return null;
			}
			List<Furniture> list = new List<Furniture>();
			while (ConfigCommon.Step(ConfigFurnitureByActivityId.HandleId, false, ConfigFurnitureByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureByActivityId.HandleId, 0, ConfigFurnitureByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFurnitureByActivityId.HandleId, ConfigFurnitureByActivityId.LogPair);
					return null;
				}
				Furniture rootAsFurniture = Furniture.GetRootAsFurniture(new ByteBuffer(item2));
				list.Add(rootAsFurniture);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFurnitureByActivityId.HandleId, ConfigFurnitureByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400181E RID: 6174
		private const string DB = "db_furniture.db";

		// Token: 0x0400181F RID: 6175
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001820 RID: 6176
		private const string TABLE = "Furniture";

		// Token: 0x04001821 RID: 6177
		private const string COMMAND = "select BinData from `Furniture` where ActivityId=?";

		// Token: 0x04001822 RID: 6178
		private const string KEY_PREFIX = "FurnitureByActivityId";

		// Token: 0x04001823 RID: 6179
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001824 RID: 6180
		private static int HandleId;
	}
}
