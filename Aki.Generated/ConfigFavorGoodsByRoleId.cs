using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C9 RID: 713
	public class ConfigFavorGoodsByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010BB RID: 4283 RVA: 0x000BB880 File Offset: 0x000B9A80
		static ConfigFavorGoodsByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorGoodsByRoleId.CreateStaticDefaultValue), new Action(ConfigFavorGoodsByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x000BB8A0 File Offset: 0x000B9AA0
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

		// Token: 0x060010BD RID: 4285 RVA: 0x000BB91F File Offset: 0x000B9B1F
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorGoodsByRoleId.LogPair = null;
			ConfigFavorGoodsByRoleId.HandleId = 0;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000BB92D File Offset: 0x000B9B2D
		public static void Init()
		{
			ConfigFavorGoodsByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigFavorGoodsByRoleId.HandleId, "db_favor.db", "select BinData from `FavorGoods` where RoleId=? Order By Sort");
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000BB948 File Offset: 0x000B9B48
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

		// Token: 0x04001363 RID: 4963
		private const string DB = "db_favor.db";

		// Token: 0x04001364 RID: 4964
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x04001365 RID: 4965
		private const string TABLE = "FavorGoods";

		// Token: 0x04001366 RID: 4966
		private const string COMMAND = "select BinData from `FavorGoods` where RoleId=? Order By Sort";

		// Token: 0x04001367 RID: 4967
		private const string KEY_PREFIX = "FavorGoodsByRoleId";

		// Token: 0x04001368 RID: 4968
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001369 RID: 4969
		private static int HandleId;
	}
}
