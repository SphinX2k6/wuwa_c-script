using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200002D RID: 45
	public class ConfigAbyssRouteByRouterAndFloor : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600010E RID: 270 RVA: 0x0005FBE0 File Offset: 0x0005DDE0
		static ConfigAbyssRouteByRouterAndFloor()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRouteByRouterAndFloor.CreateStaticDefaultValue), new Action(ConfigAbyssRouteByRouterAndFloor.ResetStaticDefaultValue));
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0005FC00 File Offset: 0x0005DE00
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRouteByRouterAndFloor.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRouteByRouterAndFloor.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoute"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoute` where RouteId=? And Floor=?")
			});
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0005FC7F File Offset: 0x0005DE7F
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRouteByRouterAndFloor.LogPair = null;
			ConfigAbyssRouteByRouterAndFloor.HandleId = 0;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0005FC8D File Offset: 0x0005DE8D
		public static void Init()
		{
			ConfigAbyssRouteByRouterAndFloor.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRouteByRouterAndFloor.HandleId, "db_dangoabyss.db", "select BinData from `AbyssRoute` where RouteId=? And Floor=?");
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0005FCA8 File Offset: 0x0005DEA8
		[NullableContext(2)]
		public static IReadOnlyList<AbyssRoute> GetConfigList(int p0RouteId, int p1Floor, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRouteByRouterAndFloor.HandleId, ConfigAbyssRouteByRouterAndFloor.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRouteByRouterAndFloor");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RouteId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Floor);
				IReadOnlyList<AbyssRoute> readOnlyList = (IReadOnlyList<AbyssRoute>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAbyssRouteByRouterAndFloor.LogPair.Clear();
			ConfigAbyssRouteByRouterAndFloor.LogPair.Add(new ValueTuple<string, object>("RouteId", p0RouteId));
			ConfigAbyssRouteByRouterAndFloor.LogPair.Add(new ValueTuple<string, object>("Floor", p1Floor));
			if (!ConfigCommon.BindInt(ConfigAbyssRouteByRouterAndFloor.HandleId, 1, p0RouteId, ConfigAbyssRouteByRouterAndFloor.LogPair) || !ConfigCommon.BindInt(ConfigAbyssRouteByRouterAndFloor.HandleId, 2, p1Floor, ConfigAbyssRouteByRouterAndFloor.LogPair))
			{
				ConfigCommon.Reset(ConfigAbyssRouteByRouterAndFloor.HandleId, ConfigAbyssRouteByRouterAndFloor.LogPair);
				return null;
			}
			List<AbyssRoute> list = new List<AbyssRoute>();
			while (ConfigCommon.Step(ConfigAbyssRouteByRouterAndFloor.HandleId, false, ConfigAbyssRouteByRouterAndFloor.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRouteByRouterAndFloor.HandleId, 0, ConfigAbyssRouteByRouterAndFloor.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRouteByRouterAndFloor.HandleId, ConfigAbyssRouteByRouterAndFloor.LogPair);
					return null;
				}
				AbyssRoute rootAsAbyssRoute = AbyssRoute.GetRootAsAbyssRoute(new ByteBuffer(item2));
				list.Add(rootAsAbyssRoute);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRouteByRouterAndFloor");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RouteId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Floor);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRouteByRouterAndFloor.HandleId, ConfigAbyssRouteByRouterAndFloor.LogPair);
			return list;
		}

		// Token: 0x0400011F RID: 287
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000120 RID: 288
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x04000121 RID: 289
		private const string TABLE = "AbyssRoute";

		// Token: 0x04000122 RID: 290
		private const string COMMAND = "select BinData from `AbyssRoute` where RouteId=? And Floor=?";

		// Token: 0x04000123 RID: 291
		private const string KEY_PREFIX = "AbyssRouteByRouterAndFloor";

		// Token: 0x04000124 RID: 292
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000125 RID: 293
		private static int HandleId;
	}
}
