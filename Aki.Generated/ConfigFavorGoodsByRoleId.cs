using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B4 RID: 692
	public class ConfigFavorGoodsByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600103D RID: 4157 RVA: 0x000B5374 File Offset: 0x000B3574
		static ConfigFavorGoodsByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorGoodsByRoleId.CreateStaticDefaultValue), new Action(ConfigFavorGoodsByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000B5394 File Offset: 0x000B3594
		public static void CreateStaticDefaultValue()
		{
			ConfigFavorGoodsByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFavorGoodsByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_favor.db"),
				new ValueTuple<string, object>("文件", "h.好感度.xlsx"),
				new ValueTuple<string, object>("表名", "FavorGoods"),
				new ValueTuple<string, object>("语句", "select BinData from `FavorGoods` where RoleId=? Order By Sort")
			});
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x000B5413 File Offset: 0x000B3613
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorGoodsByRoleId.LogPair = null;
			ConfigFavorGoodsByRoleId.HandleId = 0;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000B5421 File Offset: 0x000B3621
		public static void Init()
		{
			ConfigFavorGoodsByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigFavorGoodsByRoleId.HandleId, "db_favor.db", "select BinData from `FavorGoods` where RoleId=? Order By Sort");
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000B543C File Offset: 0x000B363C
		[NullableContext(2)]
		public static IReadOnlyList<FavorGoods> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFavorGoodsByRoleId.HandleId, ConfigFavorGoodsByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorGoodsByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<FavorGoods> readOnlyList = (IReadOnlyList<FavorGoods>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFavorGoodsByRoleId.LogPair.Clear();
			ConfigFavorGoodsByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigFavorGoodsByRoleId.HandleId, 1, p0RoleId, ConfigFavorGoodsByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigFavorGoodsByRoleId.HandleId, ConfigFavorGoodsByRoleId.LogPair);
				return null;
			}
			List<FavorGoods> list = new List<FavorGoods>();
			while (ConfigCommon.Step(ConfigFavorGoodsByRoleId.HandleId, false, ConfigFavorGoodsByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFavorGoodsByRoleId.HandleId, 0, ConfigFavorGoodsByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFavorGoodsByRoleId.HandleId, ConfigFavorGoodsByRoleId.LogPair);
					return null;
				}
				FavorGoods rootAsFavorGoods = FavorGoods.GetRootAsFavorGoods(new ByteBuffer(item2));
				list.Add(rootAsFavorGoods);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorGoodsByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFavorGoodsByRoleId.HandleId, ConfigFavorGoodsByRoleId.LogPair);
			return list;
		}

		// Token: 0x040012D0 RID: 4816
		private const string DB = "db_favor.db";

		// Token: 0x040012D1 RID: 4817
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x040012D2 RID: 4818
		private const string TABLE = "FavorGoods";

		// Token: 0x040012D3 RID: 4819
		private const string COMMAND = "select BinData from `FavorGoods` where RoleId=? Order By Sort";

		// Token: 0x040012D4 RID: 4820
		private const string KEY_PREFIX = "FavorGoodsByRoleId";

		// Token: 0x040012D5 RID: 4821
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012D6 RID: 4822
		private static int HandleId;
	}
}
